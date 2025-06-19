class student:
    def __init__(self,name,id,age,dept):
        self.name=name
        self.id=id
        self.age=age
        self.dept=dept
    def __str__(self):
        return f'{self.name} {self.id} {self.age} {self.dept}'



class gstudent(student):
    def __init__(self,name,id,age,dept,gy):
        super().__init__(name,id,age,dept)
        self.gyear=gy

    def __str__(self):
        return f'{super().__str__()}  {self.gyear}'


tam=gstudent('tam',22,20,'cs',2020)
print(tam)











class employee:
    def __init__(self,fname,lnaame,ssn):
        self.fname=fname
        self.lnaame=lnaame
        self.ssn=ssn

    def __str__(self):
        return f'{self.fname} {self.lnaame} {self.ssn}'

class houremployee(employee):
    def __init__(self,fname,lnaame,ssn,hour,wage):
        super().__init__(fname,lnaame,ssn)
        self.hour=hour
        self.wage=wage

    @classmethod
    def tam(cls):
        
    def erning(self):

        if self.hour<=40:
            return self.wage*self.hour
        elif self.hour>40:
            return  40*self.wage*(self.hour-40)*self.wage*1.5

    def __str__(self):
        return f'{super().__str__()} salary:{self.erning()} '


emp=houremployee('tam','alabdi',122,50,1000)
print(emp)




