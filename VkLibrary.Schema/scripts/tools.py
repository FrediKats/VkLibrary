# -*- coding: utf-8 -*-

import json

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