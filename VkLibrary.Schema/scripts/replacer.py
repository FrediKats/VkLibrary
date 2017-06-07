""" Replaces all occurences of a given string to another string in a file. """

import glob
import re


def replace_everywhere(before, after):
    """ Scans all files and replaces 'before' to 'after'. """
    print("Scanning files...")
    for filename in glob.glob('**/*.cs', recursive=True):
        with open(filename, mode='r') as read_file:
            contents = read_file.read()
        contents = contents.replace(before, after)
        with open(filename, mode='w') as write_file:
            write_file.write(contents)
    print("Finished scanning files.")


def add_xml_docs():
    """ Scans all files and replaces 'before' to 'after'. """
    print("Scanning files...")
    for filename in glob.glob('**/*.cs', recursive=True):
        with open(filename, mode='r') as read_file:
            contents = read_file.read()
        match = re.search(r'class (\w+)', contents)
        name = match.groups(1)[0]
        print(name)
        contents = contents.replace(
            'public class ' + name,
            '/// <summary>\n    /// API ' + name + ' object.\n    /// </summary>\n    public class ' + name            
        )
        with open(filename, mode='w') as write_file:
            write_file.write(contents)
    print("Finished scanning files.")


if __name__ == "__main__":
    add_xml_docs()
    # replace_everywhere(before=" async ", after=" ")
