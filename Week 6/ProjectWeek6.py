class Student:
    def __init__(self, FirstName, lastName, grade):
        self.first_name = FirstName
        self.last_name = lastName 
        self.grade = grade 

class Directory:
    def __init__(self):
        self.students_list = []
        self.sort_by = "selection"

    def add(self):
        print("What's this student's First name?\n")
        newKidfirst = input()
        print("What's this student's last name\n")
        newKidlast = input()
        print("What grade did they get?\n")
        newgrade = int(input())
        self.students_list.append(Student(newKidfirst, newKidlast, newgrade))

    def __str__(self):
        string = ""
        studentNum = 0
        for student in range(len(self.students_list)):
            string +=  studentNum + ")" + student.first_name + " " + student.last_name + " scored " + student.grade +"\n"
            student += 1
            return string

container = Directory()
print("Hello, and welcome,to the virtual gradebook\n")
while True:
    print("Press 1 add Student, 2 view, anything else to exit.\n")
    choice = int(input())
    if choice == 1:
        container.add()
    elif choice ==2:
        print(container)
    else:
        print("Thank God.\n")
        break
