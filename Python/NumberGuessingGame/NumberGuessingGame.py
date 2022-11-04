# This is a game that will generate a game and the user will need to guess what that number is.

import random
import time
import os

os.system('cls')
GeneratedNumber = random.randint(1, 100)
Attempts = 0

print("===================================")
print("")
print("======= NumberGuessingGame ========")
print("")
print("===================================")

time.sleep(3)

print(f"Hey there! "
      f"To play this game, you will need to guess the number that the computer has chosen between from 1 to 100")

time.sleep(1)

print(f"The computer will now chose a number from 1 to 100.....")

time.sleep(1)

UserGuess = int(input("Please choose a number between 1 and 100: "))

NumberList = {1, 100}

while UserGuess != GeneratedNumber:
      Attempts += 1
      
      if UserGuess > GeneratedNumber:

            print("You number is higher than the Computer generate number.")
      elif UserGuess < GeneratedNumber:
            print("You number is lower than the Computer generate number.")
      
      UserGuess = int(input("Please choose a number between 1 and 100: "))

      


time.sleep(1)
os.system('cls')
print(f"Nice one! You did it in {Attempts} attempts!")
