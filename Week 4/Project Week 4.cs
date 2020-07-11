#include <stdio.h>
#include <cs50.h> 
#include <string.h>
#include <stdlib.h>
typedef struct person {
    char name; 
    int grade;
}person;
int main(void) {
  while (true){
    int stopper = 5;
    person student[4];
    int i = 0;
    int j = 0;
    for(; i <= 4; i++) {
      printf("Enter student # %d:\n", i+1);
      scanf("%s", student[i].name);       

    }
    for(; j <= 4; j++) {
      printf("Enter student %d's grade:\n", j+1);
      scanf("%d", student[i].grade);
	  
	  
  }
  printf("Would you like to sort the array or just display them as they are?\n");
  printf("Press 1 to sort start sorting the array, and press anything else to simply print it out.\n");
  int con;
  scanf("%d", con);
  if(con = 1){
	  break;
  }
  else{
	  int z = 0;
	  for(; z <= 4;) {
	  printf("Student %d name is %s\n",z+1,student[z].name);
       printf(" Their grade is %d\n",z+1,student[z].grade);
       break;
	   }
  }
  return 0;
 }
}
