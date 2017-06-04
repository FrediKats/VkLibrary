""" Replaces all occurences of a given string to anothers string in a file. """

import glob


def process_files():
    """ Scans all files. """
    print("Scanning files...")
    for filename in glob.glob('**/*.cs', recursive=True):
        with open(filename, mode='r') as read_file:
            contents = read_file.read()
        contents = contents.replace("///     ", "/// ")
        with open(filename, mode='w') as write_file:
            write_file.write(contents)
    print("Finished scanning files.")

if __name__ == "__main__":
    process_files()
