using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("fill in length of array");
            int a = Convert.ToInt32(Console.ReadLine());//lets user input a value for a and converts that into an integer a.

            //int[] arr1 = new int[a];  //starts array and a defines the length of the array.
            //                                                            //between brackets "[]" is the length of an array.

            //Console.WriteLine("fill in numbers");
            //for (int i = 0; i < arr1.Length; i++)//i is used to let know how long the loop has gone for and as long its less than the length of an array the loop will keep going.
            //{
            //    arr1[i] = Convert.ToInt32(Console.ReadLine()); //i is used to determain position of each user input into the array. only int because array was started with an int declaration.
            //}

            //Console.WriteLine("numbers");

            ////foreach is used here to trigger this loop for each character within the array.
            //foreach (int character in arr1)// character here is referring to items in the array. in this case integers. int is becasue is is an int list, charachter refers to an item of that list, "in" is to specify which array to use, "arr1" is the name of the array being used.
            //{
            //    Console.WriteLine(character);//writes a character for the array
            //}

            //Console.WriteLine("");// blank line in code

            //double Sum = arr1.Sum();//sum of all the values in the array, saved as a double under the name "sum"
            //Console.WriteLine(Sum);//displays "sum"

            //Console.WriteLine("");//blank line

            //double Average = Sum / a;// double average is declared. average value is "sum" devided by "a". sum being the sum of all the values in the array and "a" being the length of the array.
            //Console.WriteLine(Average.ToString("0.000"));// writes the value of averga with 3 decimals. is there are no decimals it will display it as "0".


            Console.ReadKey();

            int b = Convert.ToInt32(Console.ReadLine());

            string[] names = new string[b];








            Console.ReadKey();//stops program from instantly closing after completing the last loop

        }
    }
}
