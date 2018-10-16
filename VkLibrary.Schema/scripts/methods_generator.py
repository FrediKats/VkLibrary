from itertools import groupby

import os

import constants
from tools import to_camel_case, read_file, generate_instances

# Generates Methods from JSON
class JMethods:
    def __init__(self, j_object, output_folder, save=False, output=False):
        print("Parsing methods...")

        # Get objects
        methods = j_object["methods"]

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
            filename = output_folder + "Methods/{}.cs".format(method_group)

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
        if response_type in constants.STRUCT_RESPONSES:
            path = constants.STRUCT_RESPONSES[response_type]
        elif response_type in constants.PSEUDO_ENUMS:
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
                        constants.C_SHARP_TYPES[value["items"]["type"]]
                    )
                else:
                    json_type = constants.C_SHARP_TYPES[json_type]

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