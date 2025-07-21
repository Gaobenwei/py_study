import time

class PlayerMeta(type):
    def __new__(cls, name, bases, attrs_dict):
        fields={}
        for k, v in attrs_dict.items():
            if isinstance(v, Field):
                fields[k] = v

        attrs_dict['_fields'] = fields
        return super().__new__(cls, name, bases, attrs_dict)

def ShowResult(func):
    def wrapper(*args, **kwargs):
        # start = time.time()
        start = time.perf_counter()
        result = func(*args, **kwargs)
        # cost_time = time.time() - start
        cost_time = time.perf_counter() - start
        print(f"func_name:{func.__name__} result:{result}  time:{cost_time}")
        return result
    return wrapper

class Field(object):
    def __init__(self,default = None):
        self.default = default
        self.data = {}
        self._field_name = None

    def __get__(self, obj, cls):
        if obj is None:
            return self # 类而非实例化对象的获取数据
        return self.data.get(obj, self.default)

    def __set__(self, obj, value):
        if not self._ValueIsErr(value):
            # 类型不对
            raise TypeError
        self.data[obj] = value
        obj._changed_fields.add(self._field_name)

    def _ValueIsErr(self, value):
        return True

    def set_field_name(self, name):
        self._field_name = name

class StringField(Field):
    def __init__(self, default = "default_str"):
        super().__init__(default)

    def _ValueIsErr(self, value):
        return isinstance(value, str) or value is None

class IntField(Field):
    def __init__(self, default = 1):
        super().__init__(default)

    def _ValueIsErr(self, value):
        return isinstance(value, int) or value is None
class FloatField(Field):
    def __init__(self, default = 5.0):
        super().__init__(default)

    def _ValueIsErr(self, value):
        return isinstance(value, float) or value is None

class Player(metaclass=PlayerMeta):
    name = StringField()
    hp = IntField(default=100)
    atk = FloatField()

    def __init__(self):
        self._changed_fields = set()
        for field_name, field in self._fields.items():
            field.set_field_name(field_name)

    @ShowResult
    def SerializeChangeFields(self):
        '''
        打包所有field数据，只打包修改了的值
        '''
        res = {key:getattr(self, key) for key in self._changed_fields}
        self._changed_fields.clear()
        return res

    @ShowResult
    def SerializeFields(self):
        '''
        返回所有的field，包含未初始化的field
        '''
        res = { key: getattr(self, key) for key in self._fields}
        return res

if __name__ == '__main__':
    player = Player()
    print(player.hp)
    player.name="1324"
    player.hp = 200
    player.SerializeFields()
    player.SerializeChangeFields()

    # player.atk = 50.0
    # player.SerializeChangeFields()

    # 个人测试
    # print(Player.hp, Player.atk,Player.name)
    # player1 = Player()
    # print(f"{player1.hp}  {player1.atk}  {player1.name}")
    # player1.hp = 1000
    # player1.atk = 1.0
    # player1.name = "player1"
    # print(f"{player1.hp}  {player1.atk}  {player1.name}")
    # # player1.hp = 10.0
    # player2 = Player()
    # print(f"{player2.hp}  {player2.atk}  {player2.name}")
    # player2.hp = 200
    # player2.atk = 1.0
    # player2.name = "player2"
    # print(f"{player2.hp}  {player2.atk}  {player2.name}")




