import numpy as np
print("Hello, and welcome,to the virtual gradebook.")
i = 1
while i > 0:
    numgrades= input("How many grades would you like to store?")
    if numgrades.isdigit():
        students = np.array([a,b],[c,d])
        grades = np.array([1,2], [3,4])
        np.append(students,grades)
    else:
        print("That wasn't a number!You scum!")
        i -1
