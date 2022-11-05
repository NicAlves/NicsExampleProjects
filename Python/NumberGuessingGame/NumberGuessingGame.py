# This is a game that will generate a game and the user will need to guess what that number is.

#importing the modules I need so far.
import random
import time
import os

# Clearing the console/terminal so there is no clutter.
os.system('cls')
# generating a random number that the user will then need to guess.
GeneratedNumber = random.randint(1, 100)
# Setting the number of attmpts veriable to 0 is just to create it into existance for us to manipulate downt he line.
Attempts = 0

print("===================================")
print("***********************************")
print("======= NumberGuessingGame ========")
print("***********************************")
print("===================================")

# Creating a delay in the program to give it more "life"
time.sleep(3)

print(f"Hey there! "
      f"To play this game, you will need to guess the number that the computer has chosen between from 1 to 100")

time.sleep(1)

print(f"The computer will now chose a number from 1 to 100.....")

time.sleep(1)

# taking the users input of a number, the same will be repeated in the while loop if they dont get it right on the first go.
UserGuess = int(input("Please choose a number between 1 and 100: "))

NumberList = {1, 100}

# This will make sure the program loops if the user does not enter the correct answer
while UserGuess != GeneratedNumber:
      Attempts += 1
      
      if UserGuess > GeneratedNumber:

            print("You number is higher than the Computer generate number.")
      elif UserGuess < GeneratedNumber:
            print("You number is lower than the Computer generate number.")
      
      UserGuess = int(input("Please choose a number between 1 and 100: "))


time.sleep(1)
os.system('cls')
print(f"Nice one! You did it in {Attempts} attempts!"
      "Try again to beat your score!")

