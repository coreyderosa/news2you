using System;
using System.IO;
namespace problem1
{

  class Program
  {

       public static void Main(){
 
         //use Console.ReadLine(); to get console input 
         string firstInput = Console.ReadLine();
         string secondInput = Console.ReadLine(); 
         
         
         string[] firstInputSplit = firstInput.Split(' ');
         int[] firstInputNumbers = new int[firstInputSplit.Length];
        
         for (var i = 0; i < firstInputNumbers.Length; i++)
         {
           firstInputNumbers[i] = int.Parse(firstInputSplit[i]);
           Console.WriteLine(firstInputNumbers[i]);
         }
         
         string[] secondInputSplit = secondInput.Split(' ');
         int[] secondInputNumbers = new int[secondInputSplit.Length];
        
         for (var i = 0; i < secondInputNumbers.Length; i++)
         {
           secondInputNumbers[i] = int.Parse(secondInputSplit[i]);
           Console.WriteLine(secondInputNumbers[i]);
         }
         
         //use Console.WriteLine(); to print output
         Console.WriteLine(firstInput);
         Console.WriteLine(secondInput);
         
        
    

    }
  }
}