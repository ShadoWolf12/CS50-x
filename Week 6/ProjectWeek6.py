print("Hello, and welcome,to the virtual gradebook.")
i = 1
while i > 0:
    print("How many student's grades would you like to store?\n")
    numgrades= int(input())
    if numgrades.isdigit():
        j = 0
        while j < numgrades:
            students = []
            grades = []
            print("What's this student's name?")
            newkid = input()
            students.append(newkid)
            print("What grade did they get?")
            newgrade = int(int())
            grades.append(newgrade)
            j += 1
            
    else:
        print("That wasn't a valid number!You scum!\n")
