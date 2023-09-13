import unittest
from helpers import *
#import timeout_decorator

#Never do following! The test process can be halted by student code!
#from my_code import *



started_tests = 0
completed_tests = 0

def rmoutput():
    for filename in []:
        try:
            os.remove(filename)
        except:
            pass


class TestCode(unittest.TestCase):
    #@timeout_decorator.timeout(30)
    def test_DotNetFunction(self):
        #Test C# program
        self.startTest()

        #Negative operator and decimal separator
        neg, sep = dotNetNumbersFormat()

        # io_list has values for: input, expected output, not expected output
        io_list=[
            ('5\n2\n320\nk\nk\n5\n2\n280\nk\nk\n0\n0\n-100\ne\ne', ['426'+sep+'38','431'+sep+'38','653'+sep+'60'], []),
        ]

        build=True
        for input, eo, neo in io_list:
            output=callDotNet(cmdline_args=[], input=input, timeout=3, build=build)
            print(32*'-')
            print(input)
            print(output)
            print(32*'-')
            build=False
            for e in eo:
                print('Check if "'+e+'" is in output')
                self.assertIn(e, output)
            for n in neo:
                print('Check if "'+n+'" is not in output')
                self.assertNotIn(n, output)

        self.endTest()

    def startTest(self):
        global started_tests
        started_tests=started_tests+1
        print('\nStart test', started_tests)
        rmoutput()

    def endTest(self):
        global completed_tests
        print('End test', started_tests)
        completed_tests=completed_tests+1
        rmoutput()


def completed():
    global completed_tests
    return completed_tests

def started():
    global started_tests
    return started_tests

