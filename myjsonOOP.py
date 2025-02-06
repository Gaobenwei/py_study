# coding=utf-8
from enum import Enum
class SpecChar(Enum):
    COMMA = ','
    LEFT_SAMLL = '('
    RIGHT_SAMLL = ')'
    LEFT_MID = '['
    RIGHT_MID = ']'
    LEFT_BIG = '{'
    RIGHT_BIG = '}'
    single_quote = '\''
    double_quote = '\"'
    key_value = ':'

class myjson(object):
    def __init__(self,text):
        str2dict_init = text.replace(" ", "")  # del all space
        str2dict_init = str2dict_init.replace('\n', '')
        str_len = len(str2dict_init)
        self._string = str2dict_init
        self._index = 0
        self._len=str_len

    def __parse_value(self):
        if self._string[self._index] == SpecChar.single_quote.value:  # string
            return self.__parse_string_single()
        elif self._string[self._index] == SpecChar.double_quote.value:
            return self.__parse_string_double()
        elif self._string[self._index] == SpecChar.LEFT_BIG.value:  # {
            return self.__parse_object()
        elif self._string[self._index] == SpecChar.LEFT_MID.value:  # [
            return self.__parse_list()
        elif self._string[self._index] == SpecChar.LEFT_SAMLL.value:  # (
            return self.__parse_tuple()
        elif self._string[self._index] in '0123456789-':
            return self.__parse_number()
        elif self._string[self._index:self._index + 4] == "true":
            return True, self._index + 4
        elif self._string[self._index:self._index + 5] == "false":
            return False, self._index + 5
        elif self._string[self._index:self._index + 4] == "null":
            return None, self._index + 4
        else:
            raise ValueError(f"invalid char {self._string[self._index]} at index: {self._index}")

    def __parse_object(self):
        out=dict()
        self._index+=1
        while self._index<self._len:
            if self._string[self._index]==SpecChar.RIGHT_BIG.value:
                self._index+=1
                return out
            key=self.__parse_value()
            if self._string[self._index]!=SpecChar.key_value.value:
                raise ValueError(f"parse object error, invalid char {self._string[self._index]} at index: {self._index}")
            self._index=self._string.index(':',self._index)+1
            value=self.__parse_value()
            out[key]=value
            if self._string[self._index]==SpecChar.COMMA.value:
                self._index+=1
            elif self._string[self._index]==SpecChar.RIGHT_BIG.value:
                self._index+=1
                return out

    def __parse_list(self):
        out=list()
        self._index+=1
        while self._index<self._len:
            if self._string[self._index]==SpecChar.RIGHT_MID.value:
                self._index+=1
                return out
            value=self.__parse_value()
            out.append(value)
            if self._string[self._index]==SpecChar.COMMA.value:
                self._index+=1
            elif self._string[self._index]==SpecChar.RIGHT_MID.value:
                self._index+=1
                return out
            else:
                raise ValueError(f"parse list error, invalid char {self._string[self._index]} at index: {self._index}")

    def __parse_tuple(self):
        out=list()
        self._index+=1
        while self._index<self._len:
            if self._string[self._index]==SpecChar.RIGHT_SAMLL.value:
                self._index+=1
                return tuple()
            value=self.__parse_value()
            out.append(value)
            if self._string[self._index]==SpecChar.COMMA.value:
                self._index+=1
            elif self._string[self._index]==SpecChar.RIGHT_SAMLL.value:
                self._index+=1
                return tuple(out)
            else:
                raise ValueError(f"parse tuple error, invalid char {self._string[self._index]} at index: {self._index}")

    def __parse_number(self):
        start_index=self._index
        while self._index<self._len:
            if self._string[self._index] in '0123456789-.':
                self._index+=1
            else:
                break
        num_temp=self._string[start_index:self._index]
        if "." in num_temp:
            return float(num_temp)
        else:
            return int(num_temp)

    def __parse_string(self, start_char='\''):
        self._index+=1
        start_index = self._index
        while self._index<self._len and self._string[self._index]!=start_char:
            self._index+=1
        if self._index>=self._len:
            raise ValueError(f"string not closed starting at index {start_index - 1}")
        self._index+=1
        return self._string[start_index:self._index-1]

    def __parse_string_single(self):
        return self.__parse_string('\'')

    def __parse_string_double(self):
        return self.__parse_string('\"')

    def loads(self)->dict:
        obj={}
        if self._len==0:
            raise ValueError("empty string")
        try:
            obj= self.__parse_value()
        except ValueError as e:
            print(e)
            if "invalid char" in str(e):
                print(f"loads error , please check the string")
            elif "parse object error" in str(e):
                print(f"loads error ,maybe you forget char \':\' ")
            elif "parse tuple error" in str(e):
                print(f"loads error ,maybe you forget char \')\' ")
            elif "parse list error" in str(e):
                print(f"loads error ,maybe you forget char \']\' ")
            elif "string not closed" in str(e):
                print(f"loads error ,maybe you forget char \' or  \" ")
            return {}
        return obj

    @staticmethod
    def dumps(dtict:dict)->str:
        if isinstance(dtict,dict):
            out=[]
            for key,value in dtict.items():
                k=f"'{key}'" if isinstance(key,str) else myjson.dumps(key)
                v=myjson.dumps(value)
                out.append(f"{k}:{v}")
            return '{'+','.join(out)+'}'
        elif isinstance(dtict,list):
            out=[myjson.dumps(temp) for temp in dtict]
            return '['+','.join(out)+']'
        elif isinstance(dtict,tuple):
            out=(myjson.dumps(temp) for temp in dtict)
            return '('+','.join(out)+')'
        elif isinstance(dtict,(int,float,bool)) or dtict is None:
            return str(dtict).lower()
        elif isinstance(dtict,str):
            return f"'{dtict}'"
        else:
            raise ValueError(f"invalid type {type(dtict)}")

    def __json_str(str):
        pass

if __name__=="__main__":
    with open("test.txt","r") as f:
        try:
            print("dict to str test:")
            string=f.read()
            MyJson=myjson(string)
            DictFromStr=MyJson.loads()
            print(DictFromStr)
            print(f"loads() result type is:---------->",type(DictFromStr))

            print("str to dict test:")
            StrFromDict=myjson.dumps(DictFromStr)
            print(StrFromDict)
            print(f"dumps() result type is:---------->",type(StrFromDict))
        except ValueError as e:
            if "invalid type" in str(e):
                print(f"dumps error")
            else:
                print(f"loads error")
else:
    pass

