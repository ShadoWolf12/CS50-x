#include <stdio.h>
#include <stdbool.h>
#include <string.h>
int main(void) 
{
   
 printf("Welcome to grade recorder. You can store 5 grades and get the average of those 5 grades.\n");   
    while (true){
        int numGrades =5; 
        int grades[numGrades];
        int i = 0;
        
  
        for(i = 0; i<numGrades; i++)
 {
            printf("Enter Grade #%d:\n", i+1);
            scanf("%d", &grades[i]);
    }
  
            int sum, j;
            float avg;
            sum = avg = 0;
            for(j = 0; j<numGrades; j++)
    {
            sum = sum + grades[j];
    }
    
            avg = (float)sum / numGrades;
  
            if ( avg < 60 ) 
    {
            printf("The average grade is %.5f, making the average grade a F. Step it up, kids.\n", avg);
    }
            else if(avg >= 60 && avg < 70) 
    {
            printf("The average grade is %.5f, making the average grade a D. It isn't an F, but you still need to do better.\n", avg);
    }
            else if (avg>= 70 && avg < 80) 
    {
            printf("The average grade is %.5f, making the average grade a C. I know you can do better than this.\n", avg);
    }
            else if (avg >= 80 && avg < 90)
    {
            printf("The average grade is %.5f, making the average grade a B Not bad, but I think you guys can get the A.\n", avg);
    }
            else if (avg >= 90 && avg <= 100) {
            printf("The average grade is %.5f, making the average grade a A. Well done, students!\n", avg);
    }
            else if (avg > 100) 
    {
            printf("The average grade is %.5f, making the average grade over 100! Exceptionally well done students!\n", avg);
    }
        char goAgain[256];
        printf("Want to do it again? Enter 'exit' to quit, otherwise, press anything else to continue.\n ");
        scanf("%s", goAgain);
        
        if ( strcmp(goAgain, "exit") == 0 )
    {
            printf("Aight Imma headout.\n");
            break;
    }
        else 
    {
            printf("Okay, let's go again!\n") ;  
    }    
        

 }
    return 0;
} 
