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
// Bubble Sort
      for(int i = 0; i < numbers.Length -1; i++)
      {
        for(int j = 0; j < numbers.Length -i -1; j++)
        {
          if(numbers[j] > numbers[j+1])
          {
            int temp = numbers[j];
            numbers[j] = numbers[j+1];
            numbers[j+1] = temp;
          }
        }
      }
      for(int i=0; i<numbers.Length; i++)
      {
        Console.WriteLine(" ");
        Console.Write(numbers[i] + " ");
      }
  }
}
