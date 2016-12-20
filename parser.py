# -*- coding: utf-8 -*-

from itertools import groupby
import json
import os


# Constants
C_SHARP_TYPES = {
    "integer": "int?",
    "string": "string",
    "boolean": "bool?",
    "number": "uint?",
}

# Here JResponses push responses represented by a struct in C#
STRUCT_RESPONSES = dict()

# Special responses that should be stored in specially created classes
SPECIAL_RESPONSES = dict()

# Enums keys
PSEUDO_ENUMS = list()


# Example: pep_eight -> PepEight
def to_camel_case(string):
    ls = list(string.split('_'))
    for i, v in enumerate(ls):
        tmp = list(ls[i])
        tmp[0] = tmp[0].upper()
        ls[i] = "".join(tmp)
    return "".join(ls)


# Loads JSON object from a file
def read_file(filename):
    with open(filename, 'rt', encoding='utf8') as file:
        j_object = json.load(file)
        return j_object


# Generates class instances.
def generate_instances():
    ls = input("Enter classnames separated by semicolons:\n").split(";")
    for item in ls:
        string = "/// <summary>\n" \
                 "/// {0} API section.\n" \
                 "/// </summary>\n" \
                 "public {0} {0}\n{{\n    get {{ return new {0}(this); }}\n}}\n\n".format(item)
        print(string)


# Generates classes from JSON
class JObjects:
    def __init__(self, file, save=False, output=False):
        print("Reading file {}...".format(file))
        j_object = read_file(filename=file)

        print("Parsing methods...")
        definitions = j_object["definitions"]
        errors = 0

        # Find enums and form their list
        for key in definitions:
            prop = definitions[key]
            enum = prop.get("enum", None)
            if enum:
                PSEUDO_ENUMS.append(key)

        # Iterate and generate
        for value in definitions:

            # Form file structure
            content = self.__parse_object(definitions[value], value)

            # Check for NULL
            if content is None:
                errors += 1
                continue

            # Split data
            item_data = list(value.split("_"))

            # Get vital params
            folder_name = item_data.pop(0).capitalize()
            for index, item in enumerate(item_data):
                item_data[index] = item.capitalize()
            class_name = str().join(item_data)

            # Generate output
            if output:
                print(content)

            # Generate files
            if save:
                print("Saving...")
                filename = "VkLib.Core/Types/{}/{}.cs".format(folder_name, class_name)
                os.makedirs(os.path.dirname(filename), exist_ok=True)
                with open(filename, "w+") as file:
                    file.write(content)
                print("Saved to {}!".format(filename))

        print("Total objects viewed: {}".format(len(definitions)))
        print("Errors: {}".format(errors))
        print("Parsed: {}".format(len(definitions) - errors))

    @classmethod
    def __parse_object(cls, item, key):

        # Get sub values
        properties = item.get("properties", None)
        enum = item.get("enum", None)
        all_of = item.get("allOf", None)

        # Check and parse
        try:
            # Get inner props
            if properties:
                out = cls.__write_title(str(), key, "")
                out += cls.__parse_properties(properties, key)
                out += "    }\n}\n"
                return out
            elif all_of:
                out = cls.__parse_children(all_of, key)
                return out
            elif enum:
                return None
            else:
                raise KeyError("Unable to resolve this method.")
        except Exception:

            # Write exception
            from traceback import print_exc
            print_exc()
            return None

    @classmethod
    def __parse_children(cls, all_of, key):

        # Get and write name of a parent
        first = all_of[0]
        ref = first.get("$ref", None)

        if ref:

            # Prepare Title
            ls = ref.split("/")[2].split("_")
            category = ls.pop(0).capitalize()
            classname = to_camel_case("_".join(ls))
            title = cls.__write_title(str(), key, " : VkLib.Types.{}.{}".format(category, classname))

            # Parse properties
            properties = all_of[1]["properties"]
            output = cls.__parse_properties(properties, key)

            # Return content
            return title + output + "    }\n}\n"

    @classmethod
    def __parse_property(cls, data, name, key):

        # Get data
        data_type = data.get("type", None)
        ref = data.get("$ref", None)
        array = data.get("allOf", None)

        # Check type
        if data_type:

            # Fix tuples
            if isinstance(data_type, list):
                data_type = "string"

            # Generate data in correct form
            if data_type == "array":
                data_type = data["items"].get("$ref", None)
                if not data_type:
                    data_type = C_SHARP_TYPES[data["items"]["type"]]
                else:
                    data_type = cls.__type_from_ref(data_type)
                data_type = "IEnumerable<{}>".format(data_type)
            elif data_type == "object":
                data_type = "object"
            else:
                data_type = C_SHARP_TYPES[data_type]

        # Class type
        elif ref:
            data_type = cls.__type_from_ref(ref)
            if "base_bool_int" in ref or "base_ok_response" in ref:
                data_type = "int?"

        # Array
        elif array:
            data_type = "IEnumerable<{}>".format("object")

        # Camel
        camel_name = to_camel_case(name)

        # Fuck equality
        ls = key.split("_")
        ls.pop(0)
        if len(ls) == 1 and ls[0] == name:
            camel_name += "_"
        elif ls == name.split("_"):
            camel_name += "_"

        # Write text
        var = "        /// <summary>\n" \
              "        /// {0}\n" \
              "        /// </summary>\n" \
              "        [JsonProperty(\"{3}\")]\n" \
              "        public {1} {2} {{ get; set; }}\n\n" \
            .format(
                data.get("description", "Property"),
                data_type,
                camel_name,
                name
            )
        return var

    @classmethod
    def __parse_properties(cls, properties, key):
        output = str()
        for name in properties:
            output += cls.__parse_property(properties[name], name, key)
        return output

    @classmethod
    def __write_title(cls, string, item, parent):

        # Split to list
        ls = list(item.split('_'))
        for i, v in enumerate(ls):
            ls[i] = v.capitalize()
        category = ls.pop(0)
        title = "".join(ls)

        # Write text
        string += "using System;\n" \
                  "using Newtonsoft.Json;\n" \
                  "using System.Collections.Generic;\n" \
                  "\n" \
                  "namespace VkLib.Types.{} \n{{\n".format(category)
        string += "    public class {}{}\n" \
                  "    {{\n".format(title, parent)
        return string

    @staticmethod
    def __type_from_ref(string):

        # Form camel casic string
        s = string.split("/")[2]

        if s in PSEUDO_ENUMS:
            if s == "base_bool_int" or s == "base_ok_response":
                return "int?"
            else:
                return "string"
        else:
            ls = list(s.split('_'))
            category = ls.pop(0).capitalize()
            classname = to_camel_case("_".join(ls))
            return "VkLib.Types.{}.{}".format(category, classname)


# Generates Methods from JSON
class JMethods:
    def __init__(self, file, save=False, output=False):

        # Read file
        print("Reading file {}...".format(file))
        j_object = read_file(filename=file)

        # Get objects
        print("Parsing methods...")
        methods = j_object["methods"]
        errors = 0

        # Group items by methods sections
        grouping = {
            k: list(v) for k, v in groupby(
                methods,
                key=lambda x: x["name"].split(".")[0].capitalize()
            )
        }

        # Iterate through grouping
        for method_group in grouping:
            values = grouping[method_group]
            heading = """using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkLib.Methods
{{
    /// <summary>
    /// {0} API section.
    /// </summary>
    public class {0}
    {{
        private Vkontakte _vkontakte;

        internal {0}(Vkontakte vkontakte)
        {{
            _vkontakte = vkontakte;
        }}
""".format(method_group)
            mid = str()

            # Parse methods
            for item in values:
                mid += self.__parse_method(item)
            ending = "\n    }\n}\n"
            content = heading + mid + ending
            filename = "VkLib.Core/Methods/{}.cs".format(method_group)

            # Generate path
            os.makedirs(os.path.dirname(filename), exist_ok=True)

            # Save to file
            if save:
                with open(filename, "w+") as file:
                    file.write(content)

            # Output to console
            if output:
                print(content)

        # Log results
        print("Total methods parsed: {}".format(len(methods)))
        print("Errors: {}".format(errors))
        print("Parsed: {}".format(len(methods) - errors))

    @classmethod
    def __parse_method(cls, item):
        try:
            output = ""
            output = cls.__write_docs(output, item)
            output = cls.__prepare_name(output, item)
            output = cls.__write_variables(output, item)
            output = cls.__create_dictionary(output, item)
            output = cls.__write_query(output, item)
            return output
        except Exception:
            from traceback import print_exc
            print_exc()
            return None

    @classmethod
    def __write_docs(cls, string, item):

        # Exclude words-helpers
        name = item.get("name", "")
        if name == "long" or name == "out" or name == "object":
            name = "{}_".format(name)

        # Concat
        string += "\n" \
                  "        /// <summary>\n" \
                  "        /// {0}\n" \
                  "        /// Docs: <see href=\"https://vk.com/dev/{1}\">{1}</see>\n" \
                  "        /// </summary>\n" \
            .format(
                item.get("description", ""),
                name
            )

        # Print parameters
        variables = item.get("parameters")
        if variables:
            for index, value in enumerate(variables):
                string += "        /// <param name=\"{}\">{}</param>\n" \
                    .format(
                        value["name"],
                        value["description"] if "description" in value else ""
                    )
        return string

    @classmethod
    def __prepare_name(cls, string, item):

        # Form method name
        name = item["name"].split(".")[1]
        name_list = list(name)
        name_list[0] = name_list[0].upper()
        name = str().join(name_list)

        # Generate path
        path = cls.__generate_response_path(item)

        # Combine to path
        string += "        public async Task<{}> {}(".format(path, name)
        return string

    @staticmethod
    def __generate_response_path(item):
        response_type = item["responses"]["response"]["$ref"].split("/")[2]
        if response_type in STRUCT_RESPONSES:
            path = STRUCT_RESPONSES[response_type]
        elif response_type in PSEUDO_ENUMS:
            path = "string"
        else:
            ls = response_type.split("_")
            category = ls.pop(0)
            response_name = to_camel_case("_".join(ls))
            path = "VkLib.Responses.{}.{}".format(category.capitalize(), response_name)
        return path

    @classmethod
    def __write_variables(cls, string, item):
        variables = item.get("parameters", None)
        if variables:
            for index, value in enumerate(variables):
                json_type = value["type"]
                if json_type == "array":
                    json_type = "IEnumerable<{}>".format(
                        C_SHARP_TYPES[value["items"]["type"]]
                    )
                else:
                    json_type = C_SHARP_TYPES[json_type]

                # Exclude words-helpers
                name = value["name"]
                if name == "long" or name == "out" or name == "object":
                    name = "{}_".format(name)

                # Concat
                string += "{} {} = null{}".format(
                    json_type,
                    name,
                    ", " if len(variables) - 1 > index else ")\n        {\n"
                )
        else:
            string += ")\n        {\n"
        return string

    @classmethod
    def __create_dictionary(cls, string, item):
        string += "            Dictionary<string, string> parameters = new Dictionary<string, string>();\n\n"
        variables = item.get("parameters", None)
        if variables:
            for index, value in enumerate(variables):

                # Exclude words-helpers
                name = value["name"]
                if name == "long" or name == "out" or name == "object":
                    name = "{}_".format(name)

                # Write
                json_type = value["type"]
                if json_type == "array":
                    converted = "string.Join(\",\", {})".format(name)
                elif json_type == "string":
                    converted = name
                else:
                    converted = "{}.ToString()".format(name)

                # Concat
                string += "            if ({0} != null)\n" \
                          "                parameters.Add(\"{0}\", {1});\n"\
                    .format(
                        name,
                        converted
                    )
        return string

    @classmethod
    def __write_query(cls, string, item):

        # Extract response types
        path = cls.__generate_response_path(item)

        # Concat
        string += "\n            return await _vkontakte.GetAsync<{}>(\"{}\", parameters);\n" \
            .format(path, item["name"]) + "        }\n"
        return string


# Generates response classes from JSON
class JResponses:
    def __init__(self, file, save=False, output=False):
        print("Reading file {}...".format(file))
        j_response = read_file(filename=file)

        print("Parsing methods...")
        definitions = j_response["definitions"]
        errors = 0

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
                filename = "VkLib.Core/Responses/{}/{}.cs".format(foldername, classname)
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
        print("Errors: {}".format(errors))
        print("Parsed: {}".format(len(definitions) - errors))

    @classmethod
    def __parse_special_response(cls, item, name):
        if not STRUCT_RESPONSES.get(name, None):
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
                                inner_type = "IEnumerable<{}>".format(C_SHARP_TYPES["integer"])
                            else:
                                inner_type = C_SHARP_TYPES[_type]

                        # Fomat ready type
                        realtype = "IEnumerable<{}>".format(inner_type)

                    else:

                        # Get original type
                        realtype = C_SHARP_TYPES[_type]

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
                STRUCT_RESPONSES[name] = "int"
            else:
                ls = ref.split("/")[2].split("_")
                _type = ls.pop(0).capitalize()
                _name = to_camel_case("_".join(ls))
                STRUCT_RESPONSES[name] = "VkLib.Types.{}.{}".format(_type, _name)

        elif items:

            # Generate ItemsResponses
            ref = items.get("$ref", None)
            _type = items.get("type", None)

            if ref:
                ls = ref.split("/")[2].split("_")
                _type = ls.pop(0).capitalize()
                _name = to_camel_case("_".join(ls))
                STRUCT_RESPONSES[name] = "IEnumerable<VkLib.Types.{}.{}>".format(_type, _name)
            elif _type:
                sharp_type = C_SHARP_TYPES.get(_type)
                if sharp_type:
                    STRUCT_RESPONSES[name] = "IEnumerable<{}>".format(sharp_type)
                else:
                    STRUCT_RESPONSES[name] = "IEnumerable<IEnumerable<string>>"
            else:
                STRUCT_RESPONSES[name] = "IEnumerable<object>"

        elif properties:

            # Check for ApiItemsResponse
            if properties.get("items", None):
                items = properties["items"]
                ref = items["items"].get("$ref", None)
                if ref:
                    ls = ref.split("/")[2].split("_")
                    category = ls.pop(0).capitalize()
                    _name = to_camel_case("_".join(ls))
                    STRUCT_RESPONSES[name] = "ApiItemsResponse<VkLib.Types.{}.{}>".format(
                        category,
                        _name
                    )
                else:
                    _type = items["items"].get("type", None)
                    if _type == "integer":
                        STRUCT_RESPONSES[name] = "ApiItemsResponse<{}>".format(
                            C_SHARP_TYPES["integer"]
                        )
                    else:
                        STRUCT_RESPONSES[name] = "ApiItemsResponse<object>"
            else:
                pass

        elif pattern_properties:

            # Append unknown stuff (really, what the hell is this?) as object
            STRUCT_RESPONSES[name] = "object"

        else:

            # Append response to a response list
            STRUCT_RESPONSES[name] = C_SHARP_TYPES[response["type"]]


# Main actions
if __name__ == "__main__":

    j_objects = JObjects('VkLib.JsonSchema/objects.json', output=False, save=True)
    j_responses = JResponses('VkLib.JsonSchema/responses.json', output=False, save=False)
    j_methods = JMethods('VkLib.JsonSchema/methods.json', output=False, save=False)



