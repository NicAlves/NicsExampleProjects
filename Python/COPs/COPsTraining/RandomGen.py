import random

# printing an intro:
print('Hello there!\n'
      'If you want us to choose a car for you, press any key now:')

answer1 = input()
if answer1 == 'yes':
      print('Sweet, here is what we suggest you look at:')
else:
      print('Okay, see you next time!')
      quit()


# create list of cars:
cars = ['Toyota', 'Honda', 'VW', 'Audi', 'Vauxhal']

print(random.choice(cars))

