using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 4, 7, 8 };
            int[] arr2 = { 14, 57, 87, 12 };
            
            int[] birlesmis = new int[arr1.Length + arr2.Length];

            for (int i = 0, j = 0; j < birlesmis.Length; j++)
            {
                if(j< arr1.Length)
                {
                    birlesmis[j] = arr1[j];
                    
                }
                
                if (j==arr1.Length||j>arr1.Length)
                {

                    birlesmis[j] = arr2[i];
                    i++;
                    

                }
              


            }
            Array.Sort(birlesmis);
            Array.Reverse(birlesmis);
            Console.WriteLine($"2 arrayin boyukden kiciye birlesmis formasi  :{string.Join(" ", birlesmis)}");
           
           
        }
    }
}