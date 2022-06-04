using System;

namespace StringChallenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputTemp = 0;
            string tempMessage = string.Empty;
            string inputValue = string.Empty;

            //takes input from console
            Console.WriteLine("Enter the current temperature: ");
            inputValue = Console.ReadLine();

            // validate the input as valid integer value
            bool validInteger = int.TryParse(inputValue, out inputTemp);

            if (validInteger)
            {
                //if is valid integer then it will check for the conditions using nested ternary ooperator
                tempMessage = inputTemp <= 15 ? 
                    //true
                    "it is too cold here" :
                    //false
                    (inputTemp >= 16 && inputTemp <= 28) ? 
                    //true
                    "it is cold here" : 
                    //false
                    inputTemp > 28 ? 
                    //true
                    "it is hot here" : 
                    //false
                    "";
                Console.WriteLine(tempMessage);
            }
            else
            {
                //in case if the input value is not a valid temperatur
                Console.WriteLine("Not a valid Temperature");
            }
            Console.ReadKey();
        }
    }
}
