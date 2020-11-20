import networkx as nx
import numpy as np
import pandas as pd
import os


class Math_operations:
    code = None
    dic_function = {}
    all = []

    def __init__(self):
        for subclass in Math_operations.__subclasses__():
            self.all.append(subclass)
            self.dic_function[subclass.code] = subclass.Calculate

    @staticmethod
    def Calculate(graph):
        pass


class Graph_operations:
    code = None
    dic_function = {}
    all = []

    def __init__(self):
        self.all = Graph_operations.__subclasses__()
        '''
        data = pd.read_excel(os.path.abspath('invariants_data.xlsx'), sheet_name='Operation')
        line = 0
        for subclass in self.all:
            subclass.defi = data.loc[line].at['Definition']
            subclass.link = data.loc[line].at['Link']
            subclass.implement = data.loc[line].at['Implementation']
        '''
        for subclass in Graph_operations.__subclasses__():
            self.all.append(subclass)
            self.dic_function[subclass.code] = subclass.Calculate

    name = None
    defi = None
    link = None
    implement = None

    @staticmethod
    def Calculate(graph):
        pass


class ComplementOf(Graph_operations):
    name = "Complement of graph"
    code = "c"

    @staticmethod
    def Calculate(graph):
        return nx.complement(graph)


class LineOf(Graph_operations):
    name = "Line of graph"
    code = "l"

    @staticmethod
    def Calculate(graph):
        return nx.line_graph(graph)


class Sin(Math_operations):
    name = "sin"
    code = "sin"

    @staticmethod
    def Calculate(x):
        return np.sin(x)


class Cos(Math_operations):
    name = "cos"
    code = "cos"

    @staticmethod
    def Calculate(x):
        return np.sin(x)


class Tan(Math_operations):
    name = "tan"
    code = "tan"

    @staticmethod
    def Calculate(x):
        return np.tan(x)


class Log(Math_operations):
    name = "Logarithm in base 10"
    code = "log"

    @staticmethod
    def Calculate(x):
        return np.log10(x)


class Ln(Math_operations):
    name = "Natural Logarithm"
    code = "ln"

    @staticmethod
    def Calculate(x):
        return np.log(x)


class Sqrt(Math_operations):
    name = "Square root"
    code = "sqrt"

    @staticmethod
    def Calculate(x):
        return np.sqrt(x)


class Absolute(Math_operations):
    name = "Absolute"
    code = "abs"

    @staticmethod
    def Calculate(x):
        return np.abs(x)

if __name__ == '__main__':
    Operations = Graph_operations()
    print(ComplementOf.defi)
    print(ComplementOf.link)
    print(ComplementOf.implement)