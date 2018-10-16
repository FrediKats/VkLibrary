# -*- coding: utf-8 -*-

import os

import constants
from tools import to_camel_case, read_file, generate_instances

# Generates classes from JSON
class JObjects:
    error_list = []

    def __init__(self, j_object, output_folder, save=False, output=False):
        print("Parsing classes...")


        definitions = j_object["definitions"]

        # Find enums and form their list
        for key in definitions:
            prop = definitions[key]
            enum = prop.get("enum", None)
            if enum:
                constants.PSEUDO_ENUMS.append(key)

        # Iterate and generate
        for value in definitions:

            # Form file structure
            content = self.__parse_object(definitions[value], value)

            # Check for NULL
            if content is None:
                self.error_list.append(value)
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
                filename = output_folder + "Types/{}/{}.cs".format(folder_name, class_name)
                os.makedirs(os.path.dirname(filename), exist_ok=True)
                with open(filename, "w+") as file:
                    file.write(content)
                print("Saved to {}!".format(filename))

        print("Total objects viewed: {} (Error - {}, Parsed - {})".format(len(definitions),
            len(self.error_list),
            len(definitions) - len(self.error_list)))

    @classmethod
    def print_errors(cls, filePath):
        errors_data ='\n'.join(cls.error_list)

        if filePath == None:
            print(errors_data)
        else:
            with open(filePath, "w+") as file:
                file.write(errors_data)

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

        print(all_of)
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
                    data_type = constants.C_SHARP_TYPES[data["items"]["type"]]
                else:
                    data_type = cls.__type_from_ref(data_type)
                data_type = "IEnumerable<{}>".format(data_type)
            elif data_type == "object":
                data_type = "object"
            else:
                data_type = constants.C_SHARP_TYPES[data_type]

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

        if s in constants.PSEUDO_ENUMS:
            if s == "base_bool_int" or s == "base_ok_response":
                return "int?"
            else:
                return "string"
        else:
            ls = list(s.split('_'))
            category = ls.pop(0).capitalize()
            classname = to_camel_case("_".join(ls))
            return "VkLib.Types.{}.{}".format(category, classname)