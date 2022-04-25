using System;  
  public class PrimeNumber  
   {  
     public static void Main(string[] args)  
      {  

          bool isprime = true; 
          Console.Write("Enter the Number to check Prime: ");    
          int number = int.Parse(Console.ReadLine());    
          for(int i = 2; i <= number/2; i++)    
          {    
           if(number % i == 0)    
            {    
             Console.Write("Number is not Prime.");   
             isprime = false;    
             break;    
            }    
          }    
          if (isprime)    
           Console.Write("Number is Prime.");       
     }  
   }  