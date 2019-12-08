

class Element:

    def __init__(self, id, alias) -> None:
        super().__init__()
        self.id = id
        self.alias = alias

    def __eq__(self, o: object) -> bool:
        if isinstance(o, Element):
            return self.id == o.id
        return False

    def __hash__(self) -> int:
        return id.__hash__()

