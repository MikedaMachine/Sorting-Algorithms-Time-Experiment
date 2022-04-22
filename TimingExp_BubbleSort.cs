using System;
using System.Diagnostics;

class Program {
  public static void Main (string[] args) 
  {
// Prompt the user for a number    
    Console.WriteLine("Enter one number");
// Store the user input    
    int n = Convert.ToInt32(Console.ReadLine());
// Create the array
    int[] user = new int[n];
// Intiate the random function   
    Random r = new Random();
// Start program timer
  var watch = Stopwatch.StartNew();
// Fill the array    
    Console.WriteLine("");
    for (int i = 0; i < user.Length; i++)
     {
      user[i] = r.Next(0,999);
      Console.Write(user[i] + " ");
     }
    Console.WriteLine("");
    Console.WriteLine("");

// Bubble Sort 
    for(int i = 0; i < user.Length -1; i++)
      {
        for(int j = 0; j < user.Length -i -1; j++)
        {
          if(user[j] > user[j+1])
          {
            int temp = user[j];
            user[j] = user[j+1];
            user[j+1] = temp;
          }
        }
      }
// Display the sorted array
    for(int i=0; i<user.Length; i++)
      {
        Console.Write(user[i] + " ");
      }
    Console.WriteLine("");
// End program timer    
  watch.Stop();
// Display the number of sorted items 
    Console.WriteLine(" ");
    Console.WriteLine("Number of items sorted " + n );
// Display the total program runtime
    Console.WriteLine("The Execution time of the program is " + watch.ElapsedMilliseconds + " ms");
// Display average runtime for each array
    Console.WriteLine("The average running time for each array is: " + watch.ElapsedMilliseconds * .001 +" ms");
    
  }
}
