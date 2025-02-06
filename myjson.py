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
def loads(tstr:str)->dict:
    str2dict_init=tstr.replace(" ","") # del all space
    str2dict_init=str2dict_init.replace('\n','')
    str_len=len(str2dict_init)
    obj={}
    if str_len==0:
        raise ValueError("empty string")
    try:
        obj, _ = __parse_value(str2dict_init, 0)
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

def __parse_value(string,index):
    if string[index]==SpecChar.single_quote.value: # string
        return __parse_string_single(string,index)
    elif string[index]==SpecChar.double_quote.value:
        return __parse_string_double(string,index)
    elif string[index]==SpecChar.LEFT_BIG.value: # {
        return __parse_object(string,index)
    elif string[index]==SpecChar.LEFT_MID.value: # [
        return __parse_list(string,index)
    elif string[index]==SpecChar.LEFT_SAMLL.value: # (
        return __parse_tuple(string,index)
    elif string[index] in '0123456789-':
        return __parse_number(string,index)
    elif string[index:index+4]=="true":
        return True,index+4
    elif string[index:index+5]=="false":
        return False,index+5
    elif string[index:index+4]=="null":
        return None,index+4
    else:
        raise ValueError(f"invalid char {string[index]} at index: {index}")

def __parse_object(string,index):
    out=dict()
    index+=1
    while index<len(string):
        if string[index]==SpecChar.RIGHT_BIG.value:
            return out,index+1
        key,index=__parse_value(string,index)
        if string[index]!=SpecChar.key_value.value:
            raise ValueError(f"parse object error, invalid char {string[index]} at index: {index}")
        index=string.index(':',index)+1
        value,index=__parse_value(string,index)
        out[key]=value
        if string[index]==SpecChar.COMMA.value:
            index+=1
        elif string[index]==SpecChar.RIGHT_BIG.value:
            return out,index+1

def __parse_list(string,index):
    out=list()
    index+=1
    while index<len(string):
        if string[index]==SpecChar.RIGHT_MID.value:
            return out,index+1
        value,index=__parse_value(string,index)
        out.append(value)
        if string[index]==SpecChar.COMMA.value:
            index+=1
        elif string[index]==SpecChar.RIGHT_MID.value:
            return out,index+1
        else:
            raise ValueError(f"parse list error, invalid char {string[index]} at index: {index}")

def __parse_tuple(string,index):
    out=list()
    index+=1
    while index<len(string):
        if string[index]==SpecChar.RIGHT_SAMLL.value:
            return tuple(),index+1
        value,index=__parse_value(string,index)
        out.append(value)
        if string[index]==SpecChar.COMMA.value:
            index+=1
        elif string[index]==SpecChar.RIGHT_SAMLL.value:
            return tuple(out),index+1
        else:
            raise ValueError(f"parse tuple error, invalid char {string[index]} at index: {index}")

def __parse_number(string,index):
    start_index=index
    while index<len(string):
        if string[index] in '0123456789-.':
            index+=1
        else:
            break
    num_temp=string[start_index:index]
    if "." in num_temp:
        return float(num_temp),index
    else:
        return int(num_temp),index

def __parse_string_single(string, index):
    return __parse_string(string, index)

def __parse_string_double(string, index):
    return __parse_string(string, index, '\"')

def __parse_string(string, index, start_char='\''):
    index+=1
    start_index = index
    while index<len(string) and string[index]!=start_char:
        index+=1
    if index>=len(string):
        raise ValueError(f"string not closed starting at index {start_index - 1}")
    return string[start_index:index],index+1

def dumps(dtict:dict)->str:
    if isinstance(dtict,dict):
        out=[]
        for key,value in dtict.items():
            k=f"'{key}'" if isinstance(key,str) else dumps(key)
            v=dumps(value)
            out.append(f"{k}:{v}")
        return '{'+','.join(out)+'}'
    elif isinstance(dtict,list):
        out=[dumps(temp) for temp in dtict]
        return '['+','.join(out)+']'
    elif isinstance(dtict,tuple):
        out=(dumps(temp) for temp in dtict)
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
    with open("test1.json","r") as f,open("result1.txt","w") as out:
        try:
            print("dict to str test:")
            string=f.read()
            DictFromStr=loads(string)
            print(DictFromStr)
            print(f"loads() result type is:---------->",type(DictFromStr))

            print("str to dict test:")
            StrFromDict=dumps(DictFromStr)
            print(StrFromDict)
            print(f"dumps() result type is:---------->",type(StrFromDict))
            out.write(StrFromDict)
        except ValueError as e:
            if "invalid type" in str(e):
                print(f"dumps error")
            else:
                print(f"loads error")
else:
    pass

