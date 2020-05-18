from typing import List


class Vertex:
    def __init__(self):
        self.visited: bool = False
        self.is_on_the_stack: bool = False
        self.incoming_vertex: List = []
        self.outgoing_vertex: List = []
        self.from_pipes = []
        self.to_pipes = []
        self.flow_min: float = 0.0
        self.flow_max: float = 0.0
        self.from_flow: float = 0.0
        self.to_flow: float = 0.0
        self.flow_in_out: float = 0.0

    def __str__(self):
        return "visited: {}, is_on_the_stack: {}, incoming_vertex: {}, outgoing_vertex: {}". \
            format(self.visited, self.is_on_the_stack, self.incoming_vertex, self.outgoing_vertex)

    def assign_neighbouring_vertexes(self):
        for pipe in self.from_pipes:
            self.outgoing_vertex.append(pipe.to_node)
        for pipe in self.to_pipes:
            self.incoming_vertex.append(pipe.from_node)

    def get_un_visited_vertexes(self) -> List:
        un_visited_vertexes = []
        for vertex in self.incoming_vertex:
            if not vertex.visited:
                un_visited_vertexes.append(vertex)
        for vertex in self.outgoing_vertex:
            if not vertex.visited:
                un_visited_vertexes.append(vertex)
        return un_visited_vertexes

    def attempt_mark_as_visited(self) -> bool:
        if len(self.get_un_visited_vertexes()) <= 1 and self.flow_in_out:
            return True
        return False

    def is_from_node(self, node) -> bool:
        for vertex in self.outgoing_vertex:
            if vertex.id == node.id:
                return True
        return False

    def from_flow_defined(self):
        for vertex in self.outgoing_vertex:
            if not vertex.visited:
                return False
        return True

    def to_flow_defined(self):
        for vertex in self.incoming_vertex:
            if not vertex.visited:
                return False
        return True

    def all_neighbouring_un_visited_vertexes_on_stack(self):
        for vertex in self.get_un_visited_vertexes():
            if not vertex.is_on_the_stack:
                return False
        return True

    def has_neighbours_on_stack(self):
        for vertex in self.get_un_visited_vertexes():
            if vertex.is_on_the_stack:
                return True
        return False
