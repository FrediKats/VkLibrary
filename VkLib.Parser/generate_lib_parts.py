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


# Loads JSON object from a file
def read_file(filename):
    with open(filename, 'rt', encoding='utf8') as file:
        j_object = json.load(file)
        return j_object


class JMethods:
    """ Parses Methods from JSON """
    result = str()

    def __init__(self, file):
        """
        Parses the whole file on init.
        :param file: file name
        """
        print("Reading file {}...".format(file))
        j_object = read_file(filename=file)

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

            # Create template
            values = grouping[method_group]
            heading = """
using System;
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
            for item in values:
                mid += self.__parse_method(item)
            ending = "\n    }\n}\n"
            content = heading + mid + ending
            filename = "Methods/{}.cs".format(method_group)

            # Generate path
            os.makedirs(os.path.dirname(filename), exist_ok=True)
            with open(filename, "w+") as file:
                file.write(content)

        print("Total methods parsed: {}".format(len(methods)))
        print("Errors: {}".format(errors))
        print("Parsed: {}".format(len(methods) - errors))

    @classmethod
    def __parse_method(cls, item):
        """ Invokes parsing methods one by one. """
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
        string += "\n        /// <summary>\n" \
                  "        /// {0}\n" \
                  "        /// Docs: <see href=\"https://vk.com/dev/{1}\">{1}</see>\n" \
                  "        /// </summary>\n".format(item.get("description", ""), item.get("name", ""))
        variables = item.get("parameters")
        if variables:
            for index, value in enumerate(variables):
                string += "        /// <param name=\"{}\">{}</param>\n".format(
                    value["name"],
                    value["description"] if "description" in value else ""
                )
        return string

    @classmethod
    def __prepare_name(cls, string, item):
        name = item["name"].split(".")[1]
        name_list = list(name)
        name_list[0] = name_list[0].upper()
        name = str().join(name_list)
        string += "        public async Task<{}> {}(".format("object", name)
        return string

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
                string += "{} {} = null{}".format(
                    json_type,
                    value["name"],
                    ", " if len(variables) - 1 > index else ") {\n"
                )
        return string

    @classmethod
    def __create_dictionary(cls, string, item):
        string += "            Dictionary<string, string> parameters = new Dictionary<string, string>();\n\n"
        variables = item.get("parameters", None)
        if variables:
            for index, value in enumerate(variables):
                json_type = value["type"]
                if json_type == "array":
                    converted = "string.Join(\",\", {})".format(value["name"])
                elif json_type == "string":
                    converted = value["name"]
                else:
                    converted = "{}.ToString()".format(value["name"])
                string += "            if ({0} != null)\n" \
                          "                parameters.Add(\"{0}\", {1});\n".format(value["name"], converted)
        return string

    @classmethod
    def __write_query(cls, string, item):
        string += "\n            return await _vkontakte.GetAsync<{}>(\"{}\", parameters);\n" \
                      .format("object", item["name"]) + "        }\n"
        return string


class JObjects:
    """ Parses Objects from JSON """
    result = ""

    def __init__(self, file):
        print("Reading file {}...".format(file))
        j_object = read_file(filename=file)

        print("Parsing methods...")
        definitions = j_object["definitions"]
        errors = 0
        for value in definitions:

            # Form file structure
            heading = self.__write_title(str(), value)
            props = self.__parse_object(definitions[value])
            ending = "    }\n}\n"

            # Check for NULL
            if props is None or heading is None:
                errors += 1
                continue

            # Do stuff with displaying, saving, etc...
            content = heading + props + ending

            # Split data
            item_data = list(value.split("_"))

            # Get vital params
            folder_name = item_data.pop(0).capitalize()
            for index, item in enumerate(item_data):
                item_data[index] = item.capitalize()
            class_name = str().join(item_data)

            # Generate path
            filename = "Types/{}/{}.cs".format(folder_name, class_name)
            os.makedirs(os.path.dirname(filename), exist_ok=True)
            with open(filename, "w+") as file:
                file.write(content)

        print("Total objects viewed: {}".format(len(definitions)))
        print("Errors: {}".format(errors))
        print("Parsed: {}".format(len(definitions) - errors))

    @classmethod
    def __parse_object(cls, item):

        # Get sub values
        properties = item.get("properties", None)
        enum = item.get("enum", None)
        all_of = item.get("allOf", None)

        # Check and parse
        try:
            # Get inner props
            if properties:
                out = cls.__parse_properties(properties)
            elif all_of:
                return None
            elif enum:
                return None
            else:
                raise KeyError("Unable to resolve this method.")
            return out
        except Exception:

            # Write exception
            from traceback import print_exc
            print_exc()
            return None

    @classmethod
    def __parse_property(cls, data, name):
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

        # Array
        elif array:
            data_type = "IEnumerable<{}>".format("object")

        # Write text
        var = "        /// <summary>\n" \
              "        /// {0}\n" \
              "        /// </summary>\n" \
              "        [JsonProperty(\"{3}\")]\n" \
              "        public {1} {2} {{ get; set; }}\n\n" \
            .format(
                data.get("description", "Property"),
                data_type,
                cls.__to_camel_case(name),
                name
            )
        return var

    @classmethod
    def __parse_properties(cls, properties):
        output = str()
        for name in properties:
            output += cls.__parse_property(properties[name], name)
        return output

    @classmethod
    def __write_title(cls, string, item):

        # Split to list
        ls = list(item.split('_'))
        for i, v in enumerate(ls):
            ls[i] = v.capitalize()
        category = ls.pop(0)
        title = "".join(ls)

        # Write text
        string += "using System;\n" \
                  "using Newtonsoft.Json;\n" \
                  "\n" \
                  "namespace VkLib.Types.{} \n{{\n".format(category)
        string += "    public class {}\n" \
                  "    {{\n".format(title)
        return string

    @staticmethod
    def __type_from_ref(string):
        s = string.split("/")[2]
        ls = list(s.split('_'))
        del ls[0]
        for i, v in enumerate(ls):
            ls[i] = v.capitalize()
        return "".join(ls)

    @staticmethod
    def __to_camel_case(string):
        ls = list(string.split('_'))
        for i, v in enumerate(ls):
            ls[i] = v.capitalize()
        return "".join(ls)


if __name__ == "__main__":

    # Parse methods
    j_methods = JMethods('api/methods.json')
    j_objects = JObjects('api/objects.json')
    # print(j_methods.result)


