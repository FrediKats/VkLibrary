import os
import re

for filename in os.listdir('.'):
    if filename.endswith('.cs'): 
        print('Working with {}'.format(filename))
        file = open(filename, 'r')
        data = file.read()
        file.close()

        def repl(data, m):
            data = data.replace(
                m.group(0), m.group(1) + '.ToApiString()'
            )

        # Create a regex
        regex = re.compile(r'string\.Join\(",", (.+?)\)')
        data = regex.sub(lambda m: 
            m.group()
                .replace('string.Join(",", ', '')
                .replace(')', '.ToApiString()')
        , data)

        file = open(filename, 'w')
        file.write(data)
        file.close()
    else:
        continue