""" Replaces all occurences of a given string to another string in a file. """

import glob


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


if __name__ == "__main__":
    replace_everywhere(before=" async ", after=" ")
    replace_everywhere(before="return await", after="return")
