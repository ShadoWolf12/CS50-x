#include <stdio.h>
#include <cs50.h> 
#include <string.h>
#include <stdlib.h>
typedef struct person {char[] name, int grade}
 person;
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
  
  return 0;
 }
}

 

