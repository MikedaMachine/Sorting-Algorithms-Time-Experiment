using System;

class Program 
{
  public static void Main (string[] args) 
  {
    int[] numbers = new int[5];
    
    Console.WriteLine("Please Enter 5 numbers");
    
    for (int i = 0; i < numbers.Length; i++)
    {
      numbers[i] = Convert.ToInt32(Console.ReadLine());
    }

    for (int i = 0; i < numbers.Length; i++)
    {
      Console.Write(" ");
      Console.Write(numbers[i] + " ");
    } 
// Selection Sort
    for(int i = 0; i < numbers.Length -1; i++)
      {
       int min = i;
       for (int j = i + 1; j < numbers.Length; j++)
         if (numbers[j] < numbers[min]) min = j;
        {
          int temp = numbers[i];
          numbers[i] = numbers[min];
          numbers[min] = temp;
        }
    }
      for(int i = 0; i < numbers.Length; i++)
      {
        Console.WriteLine(" ");
        Console.Write(numbers[i] + " ");
      }  
    }
  }
