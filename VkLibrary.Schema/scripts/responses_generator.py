import os

import constants
from tools import to_camel_case, read_file, generate_instances

# Generates response classes from JSON
class JResponses:
    def __init__(self, j_response, output_folder, save=False, output=False):

        print("Parsing responses...")
        definitions = j_response["definitions"]

        # Parse regular responses
        for key in definitions:
            self.__parse_response(definitions[key], key)

        # Parse special responses
        for key in definitions:

            # Get content
            content = self.__parse_special_response(definitions[key], key)

            # Is this real?
            if content:

                # Get variables
                ls = key.split("_")
                foldername = ls.pop(0).capitalize()
                classname = to_camel_case("_".join(ls))

                # Generate path
                filename = output_folder + "Responses/{}/{}.cs".format(foldername, classname)
                os.makedirs(os.path.dirname(filename), exist_ok=True)

                # Output
                if output:
                    print(content)

                # Save to file
                if save:
                    with open(filename, "w+") as file:
                        file.write(content)

        # Log
        print("Total responses viewed: {}".format(len(definitions)))

    @classmethod
    def __parse_special_response(cls, item, name):
        if not constants.STRUCT_RESPONSES.get(name, None):
            properties = item["properties"]["response"]["properties"]

            ls = name.split("_")
            category = ls.pop(0).capitalize()
            classname = to_camel_case("_".join(ls))

            # Write header
            string = "using System;\n" \
                     "using System.Collections.Generic;\n" \
                     "using Newtonsoft.Json;\n" \
                     "using VkLib.Types;\n" \
                     "\n" \
                     "namespace VkLib.Responses.{}\n" \
                     "{{\n" \
                     "    public class {}\n" \
                     "    {{\n".format(category, classname)

            # Iterate through properties
            for key in properties:
                value = properties[key]

                # Parse types
                _type = value.get("type", None)
                _ref = value.get("$ref", None)

                if _type:
                    if _type == "array":

                        # Determine type
                        _ref = value["items"].get("$ref")
                        _type = value["items"].get("type")

                        if _ref:

                            # From path
                            ls = _ref.split("/")[2].split("_")
                            category = ls.pop(0).capitalize()
                            full_path = to_camel_case("_".join(ls))
                            inner_type = "VkLib.Types.{}.{}".format(category, full_path)

                        else:

                            # Enumerable
                            if _type == "array":
                                inner_type = "IEnumerable<{}>".format(constants.C_SHARP_TYPES["integer"])
                            else:
                                inner_type = constants.C_SHARP_TYPES[_type]

                        # Fomat ready type
                        realtype = "IEnumerable<{}>".format(inner_type)

                    else:

                        # Get original type
                        realtype = constants.C_SHARP_TYPES[_type]

                elif _ref:

                    if "base_bool_int" in _ref or "base_ok_response" in _ref:
                        realtype = "int"
                    else:
                        ls = _ref.split("/")[2].split("_")
                        category = ls.pop(0).capitalize()
                        full_path = to_camel_case("_".join(ls))
                        realtype = "VkLib.Types.{}.{}".format(category, full_path)

                description = value.get("description", None)

                # Docs
                string += "        /// <summary>\n" \
                          "        /// {}\n" \
                          "        /// </summary>\n" \
                          "        [JsonProperty(\"{}\")]\n" \
                          "        public {} {} {{ get; set; }}\n\n"\
                    .format(
                        description,
                        key,
                        realtype,
                        to_camel_case(key)
                    )

            # Write ending
            string += "    }\n" \
                      "}\n"

            return string

    @classmethod
    def __parse_response(cls, item, name):
        # Extract response
        response = item["properties"]["response"]

        # Check fields existance
        ref = response.get("$ref", None)
        items = response.get("items", None)
        properties = response.get("properties", None)
        pattern_properties = response.get("patternProperties", None)

        if ref:

            # Work with clean and good responses
            if "base_ok_response" in ref or "base_bool_int" in ref:
                constants.STRUCT_RESPONSES[name] = "int"
            else:
                ls = ref.split("/")[2].split("_")
                _type = ls.pop(0).capitalize()
                _name = to_camel_case("_".join(ls))
                constants.STRUCT_RESPONSES[name] = "VkLib.Types.{}.{}".format(_type, _name)

        elif items:

            # Generate ItemsResponses
            ref = items.get("$ref", None)
            _type = items.get("type", None)

            if ref:
                ls = ref.split("/")[2].split("_")
                _type = ls.pop(0).capitalize()
                _name = to_camel_case("_".join(ls))
                constants.STRUCT_RESPONSES[name] = "IEnumerable<VkLib.Types.{}.{}>".format(_type, _name)
            elif _type:
                sharp_type = constants.C_SHARP_TYPES.get(_type)
                if sharp_type:
                    constants.STRUCT_RESPONSES[name] = "IEnumerable<{}>".format(sharp_type)
                else:
                    constants.STRUCT_RESPONSES[name] = "IEnumerable<IEnumerable<string>>"
            else:
                constants.STRUCT_RESPONSES[name] = "IEnumerable<object>"

        elif properties:

            # Check for ApiItemsResponse
            if properties.get("items", None):
                items = properties["items"]
                ref = items["items"].get("$ref", None)
                if ref:
                    ls = ref.split("/")[2].split("_")
                    category = ls.pop(0).capitalize()
                    _name = to_camel_case("_".join(ls))
                    constants.STRUCT_RESPONSES[name] = "ApiItemsResponse<VkLib.Types.{}.{}>".format(
                        category,
                        _name
                    )
                else:
                    _type = items["items"].get("type", None)
                    if _type == "integer":
                        constants.STRUCT_RESPONSES[name] = "ApiItemsResponse<{}>".format(
                            constants.C_SHARP_TYPES["integer"]
                        )
                    else:
                        constants.STRUCT_RESPONSES[name] = "ApiItemsResponse<object>"
            else:
                pass

        elif pattern_properties:

            # Append unknown stuff (really, what the hell is this?) as object
            constants.STRUCT_RESPONSES[name] = "object"

        else:

            # Append response to a response list
            constants.STRUCT_RESPONSES[name] = constants.C_SHARP_TYPES[response["type"]]