#include <stdio.h>
#include <string.h>
#include <stdlib.h>
typedef struct {
    char* nameFirst[16]; 
    int* grade;
    char* nameLast[16];
}Person; 
int main(void) {
    int fixer = 0;
    while(1){
    int count;
    Person student[count];    
    if (fixer == 0){
        char bam;
        int count= 0;
        printf("Hello and welcome to the Student roster storer.\n You can only add Students, or exit right now, what do you want to do?\n");
        printf("Press a to continue and add a roster, or press b to leave right now.(please leave right now.)");
        scanf("%c", &bam);
        if (bam == "a"){
            printf("How many students do you want to add?\n");
            scanf("%d", &count);
            Person student[count];
            int i = 0;
            int j = 0;
            int k = 0;
            for(; i <= count; i++) {
                int counter = 0;
                printf("Enter student # %d:\n", i+1);
                scanf("%s", &student[i].nameFirst);       
                
            }
            for(; k <= count; k++){
                int counter = 0;
                printf("Enter student # %d:\n", i+1);
                scanf("%s", &student[i].nameFirst);       
                
            }
            for(; j <= 4; j++) {
                int counter = 0;
                printf("Enter student %d's grade:\n", j+1);
                scanf("%d", &student[i].grade);
	            
            }
        }
        else{
        printf("Get out!!!!! Get out!!!!" );
        break;
        }
 
    }
    else{
  printf("Welcome to the Gradebook. You can:\n 1.) Add some students\n 2. Display items\n 3.) Exit.\n");
  char goer;
  scanf("%c", &goer);
  if(goer == 'a'){
      printf("How many students do you want to add?\n");
          scanf("%d", &count);
           Person student[count];
      int i = 0;
      int j = 0;
      int k = 0;
    for(; i <= count; i++) {
        int counter = 0;
      printf("Enter student # %d:\n", i+1);
      scanf("%s", &student[i].nameFirst);       
      
    }
    for(; k <= count; k++){
        int counter = 0;
      printf("Enter student # %d:\n", i+1);
      scanf("%s", &student[i].nameFirst);       
      
    }
    for(; j <= 4; j++) {
        int counter = 0;
      printf("Enter student %d's grade:\n", j+1);
      scanf("%d", &student[i].grade);
	  
	  
    }
  }
  else if(goer == 'b'){
     printf("We're through!\n");
     printf("Would you like to sort the array or just display them as they are?\n");
     printf("Press 1 to sort start sorting the array, and press anything else to simply print it out.\n");
     int con;
     scanf("%d", &con);
     if(con = 1){
	  break;
      }
     else{
	 int z = 0;
	 for(; z <= count;) {
	 printf("Student %d name is %s %s \n",z+1,student[z].nameFirst, student[z].nameLast);
     printf(" Their grade is %d\n",z+1,student[z].grade);
   break;
     }
 
      break;
      }
  }
  else if(goer == 'c'){
      printf("Yay, we're done!!!!!\n");
      break;
      }
  else{
      printf("Nani???? What have you done?!?!\n");
    }
}
  return 0;
    }
 } 
