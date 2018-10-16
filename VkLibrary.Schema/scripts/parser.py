# -*- coding: utf-8 -*-

import os

from objects_generator import JObjects
from methods_generator import JMethods
from responses_generator import JResponses

# Main actions
if __name__ == "__main__":

    # j_objects = JObjects('VkLibrary.Schema/scripts/Test.json', output=False, save=False)
    j_objects = JObjects('../vk-api-schema/objects.json', output=False, save=False)
    j_responses = JResponses('../vk-api-schema/responses.json', output=False, save=True)
    j_methods = JMethods('../vk-api-schema/methods.json', output=False, save=True)
    print("done")


