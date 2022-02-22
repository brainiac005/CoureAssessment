using System;

namespace CoureAssessment
{
    //program to give an array of integers that keeps a total score based on parameters
   public class Program
    {
        //declaration of array
        int[] myArr = new int[] {8,8}; 

        int ArrayFunction()
        {
            int points = 0;
            var arrayLength = myArr.Length;

            //loop through each element in the array
            for (int i = 0; i<arrayLength; i++)
            {
                //check for first paramter ** Add 1 for each even number in the array
                var mod1 = myArr[i] % 2;
                if (mod1 == 0)
                {
                    //element is an even number
                    points += 1;
                }

                //check for second paramter ** Add 3 for odd even number in the array
                var mod2 = myArr[i] % 2;
                if (mod2 != 0)
                {
                    //element is an even number
                    points += 3;
                }

                //check for third paramter ** Add 5 for every time you encounter an 8 in the array
                
                if (myArr[i] == 8)
                {
                    //element is an even number
                    points += 5;
                }
            }

            return points;
        }
        //get the total elements in the array
        
        static void Main(string[] args)
        {
            var myObj = new Program();
            Console.WriteLine("Output: "+ myObj.ArrayFunction());
        }
    }
}
