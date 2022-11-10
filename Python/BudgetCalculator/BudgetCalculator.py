import os
import time

os.system("cls")

print("Welcome!")
time.sleep(1)
print("initialising.....")
time.sleep(1)
print("This is a tool that you can use to calculate your monthly budget!")
print("")

MonthlySalary = float(input("What is your monthly income after tax?: "))
NumbersList = {1.0,1000000.0}

for MonthlySalary in NumbersList:
    print("yes")
elif MonthlySalary not in NumbersList:
    print("Broken")
    MonthlySalary = float(input("What is your monthly income after tax?: "))



# work in progress!!!