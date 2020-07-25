# Ethan
class Student:
    def __init__(self, FirstName, lastName, grade):
        self.first_name = FirstName
        self.last_name = lastName 
        self.grade = grade 
        directory = []
   
    print("Hello, and welcome,to the virtual gradebook")
    while True:
        print("Press 1 add Student, 2 view, anything else to exit.")
        choice = int(input())
        if choice == 1:
            print("What's this student's First name?\n")
            newKidfirst = input()
            print("What's this student's last name\n")
            newKidlast = input()
            print("What grade did they get?\n")
            newgrade = int(input())
            directory.append(new Student(newKidfirst, newKidlast, newgrade))
        
        elif choice == 2:
        #code for displaying grades
        will_continue = int(input())
        if will_continue == 1
            print("")
            elif will_continue == 2
            print("Bye!!!!\n")
            break
        else
            print("For your sheer stupidity, go back to the beginning.\n")
    else:
        break 





