# -*- coding: utf-8 -*-

import os

from tools import to_camel_case, read_file, generate_instances

from objects_generator import JObjects 
from methods_generator import JMethods
from responses_generator import JResponses

# Main actions
if __name__ == "__main__":

    folder = 'VkLibrary.Schema/'
    output_folder = 'VkLib.Core/'

    objects_json = read_file(folder + 'objects.json')
    j_objects = JObjects(objects_json, output_folder, output=False, save=True)

    responses_json = read_file(folder + 'responses.json')
    j_responses = JResponses(responses_json, output_folder, output=False, save=True)

    methods_json = read_file(folder + 'methods.json')
    j_methods = JMethods(methods_json, output_folder, output=False, save=True)

    j_objects.print_errors('object_invalid_types.txt')
