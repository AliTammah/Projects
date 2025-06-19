from Customers import customers
from PrintScreen import printScreen
from clsTransaction import Transactions

class find(printScreen):
    @staticmethod
    def __get_check_id():
        ID = int(input("Enter a Acount  number : "))
        while not Transactions.Is_Found(ID):  # find acount  number:
            ID = int(input("Sorry!,not found acount number :"))
        return ID

    @staticmethod
    def _printClient():
       client= Transactions.search(find.__get_check_id())

       s = (f"ID : {client[0]}"
            f"\n Name : {client[1]} {client[2]} \n"
            f"Phone : {client[3]} \n"
            f"Date of Birth : {client[4]} \n"
            f"Password : {client[5]} \n"
            f"Email : {client[6]} \n")
       s += (f"Gender :{client[7]}\n"
             f"Balance : {client[8]} \n"
             f"Account Type: {client[9]}")

       print(s)






