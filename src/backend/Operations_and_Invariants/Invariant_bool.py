import networkx as nx
import grinpy as gp
import numpy.linalg as la
import numpy as np


class Invariant_bool:

    def __init__(self):
        self.all = Invariant_bool.__subclasses__()
        '''
        data = pd.read_excel(os.path.abspath('invariants_data.xlsx'), sheet_name='Invariant_bool')
        i = 0
        for inv in self.all:
            inv.defi = data.loc[i].at['Definition']
            inv.link = data.loc[i].at['Link']
            inv.implement = data.loc[i].at['Implementation']
            i = i + 1
        '''

    name = None
    defi = None
    link = None
    implement = None
    error = 0.00001

    @staticmethod
    def calculate(graph, k=0):
        pass


class Planar(Invariant_bool):
    name = "planar"

    @staticmethod
    def calculate(graph):
        return nx.check_planarity(graph)


class Connected(Invariant_bool):
    name = "connected"

    @staticmethod
    def calculate(graph):
        return nx.is_connected(graph)


class Biconnected(Invariant_bool):
    name = "biconnected"

    @staticmethod
    def calculate(graph):
        return nx.is_biconnected(graph)


class Bipartite(Invariant_bool):
    name = 'bipartite'

    @staticmethod
    def calculate(graph):
        return nx.is_bipartite(graph)


class Eulerian(Invariant_bool):
    name = 'Eulerian'

    @staticmethod
    def calculate(graph):
        return gp.is_eulerian(graph)


class Chordal(Invariant_bool):
    name = 'Chordal'

    @staticmethod
    def calculate(graph):
        return gp.is_chordal(graph)


class Triangle_free(Invariant_bool):
    name = 'Triangle-free'

    @staticmethod
    def calculate(graph):
        return gp.is_triangle_free(graph)


class Regular(Invariant_bool):
    name = 'Regular'

    @staticmethod
    def calculate(graph):
        return gp.is_regular(graph)


class k_Regular(Invariant_bool):
    name = 'k-regular'

    @staticmethod
    def calculate(graph, k):
        return gp.is_k_regular(graph, k=k)


class Some_Aeigen_integer(Invariant_bool):
    name = 'Some A-eigenvalue integer'

    @staticmethod
    def calculate(graph):
        return Utils.Is_there_a_integer(la.eigvalsh(nx.adj_matrix(graph)))


class Some_Leigen_integer(Invariant_bool):
    name = "Some L-eigenvalue integer"

    @staticmethod
    def calculate(graph):
        return Utils.Is_there_a_integer(la.eigvalsh(nx.laplacian_matrix(graph)))


class Some_Qeigen_integer(Invariant_bool):
    name = "Some Q-eigenvalue integer"

    @staticmethod
    def calculate(graph):
        return Utils.Is_there_a_integer(la.eigvalsh(np.abs(nx.laplacian_matrix(graph))))


class Some_Deigen_integer(Invariant_bool):
    name = "Some D-eigenvalue integer"

    @staticmethod
    def calculate(graph):
        return Utils.Is_there_a_integer(la.eigvalsh(nx.floyd_warshall_numpy(graph)))


class A_integral(Invariant_bool):
    name = "A-integral"

    @staticmethod
    def calculate(graph):
        return Utils.Integral(la.eigvalsh(la.eigvalsh(nx.adj_matrix(graph))))


class L_integral(Invariant_bool):
    name = "L-integral"

    @staticmethod
    def calculate(graph):
        return Utils.Integral(la.eigvalsh(nx.laplacian_matrix(graph)))


class Q_integral(Invariant_bool):
    name = "Q-integral"

    @staticmethod
    def calculate(graph):
        return Utils.Integral(la.eigvalsh(np.abs(nx.laplacian_matrix(graph))))


class D_integral(Invariant_bool):
    name = "D-integral"

    @staticmethod
    def calculate(graph):
        return Utils.Integral(la.eigvalsh(nx.floyd_warshall_numpy(graph)))


class Largest_Aeigen_integer(Invariant_bool):
    name = "Largest A-eigenvalue is integer"

    @staticmethod
    def calculate(graph):
        return Utils.Is_a_integer(la.eigvalsh(nx.adj_matrix(graph))[nx.number_of_nodes(graph) - 1])


class Largest_Leigen_integer(Invariant_bool):
    name = "Largest L-eigenvalue is integer"

    @staticmethod
    def calculate(graph):
        return Utils.Is_a_integer(la.eigvalsh(nx.laplacian_matrix(graph))[nx.number_of_nodes(graph) - 1])


class Largest_Qeigen_integer(Invariant_bool):
    name = "Largest Q-eigenvalue is integer"

    @staticmethod
    def calculate(graph):
        return Utils.Is_a_integer(la.eigvalsh(np.abs(nx.laplacian_matrix(graph)))[nx.number_of_nodes(graph) - 1])


class Largest_Deigen_integer(Invariant_bool):
    name = "Largest D-eigenvalue is integer"

    @staticmethod
    def calculate(graph):
        return Utils.Is_a_integer(la.eigvalsh(nx.floyd_warshall_numpy(graph))[nx.number_of_nodes(graph) - 1])


class Utils:

    @staticmethod
    def Approx_to_int(number, error=0.00001):
        if abs(int(number) - number) <= error:
            return int(number)
        else:
            return number

    @staticmethod
    def Is_there_a_integer(list):
        for number in list:
            if Utils.Approx_to_int(number).is_integer():
                return True
        return False

    @staticmethod
    def Is_a_integer(number):
        return Utils.Approx_to_int(number).is_integer()

    @staticmethod
    def Integral(list):
        for number in list:
            if not Utils.Approx_to_int(number).is_integer():
                return False
        return True


if __name__ == '__main__':
    I_bool = Invariant_bool()
    print(Regular.defi)
    print(Regular.link)
    print(Regular.implement)
