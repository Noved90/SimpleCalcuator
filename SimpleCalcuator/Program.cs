using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalcuator
{
    class Program
    {
        public static string modCharactor = "%";
        public static string additionChar = "+";
        public static string subtractionChar = "-";
        public static string divisionChar = "/";
        public static string multiplicationChar = "*";
        public static float CalculateAnswer = 0;
        public static string UserOperand = "";
        public static float UserNumInput = 0;
        public static float UserNumInputTwo = 0;
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter First Num");
            float.TryParse(Console.ReadLine(), out UserNumInput);
            Console.WriteLine("Enter Second Num");
            float.TryParse(Console.ReadLine(), out UserNumInputTwo);
            Console.WriteLine("Enter Charactor: +,-,/,*, : ");
            UserOperand = Console.ReadLine();
            if (UserOperand == modCharactor)
            {
                CalculateAnswer = UserNumInput % UserNumInputTwo;
                Console.WriteLine(CalculateAnswer.ToString());
                Console.ReadKey();
            }
            else if (UserOperand == additionChar)
            {
                CalculateAnswer = UserNumInput + UserNumInputTwo;
                Console.WriteLine(CalculateAnswer.ToString());
                Console.ReadKey();
            }
            else if(UserOperand == subtractionChar)
            {
                CalculateAnswer = UserNumInput - UserNumInputTwo;
                Console.WriteLine(CalculateAnswer.ToString());
                Console.ReadKey();
            }
            else if(UserOperand == additionChar)
            {
                CalculateAnswer = UserNumInput + UserNumInputTwo;
                Console.WriteLine(CalculateAnswer.ToString());
            }
            else if(UserOperand == multiplicationChar)
            {
                CalculateAnswer = UserNumInput * UserNumInputTwo;
                Console.WriteLine(CalculateAnswer.ToString());
                Console.ReadKey();
            }
            else if(UserOperand == divisionChar)
            {
                CalculateAnswer = UserNumInput / UserNumInputTwo;
                Console.WriteLine(CalculateAnswer.ToString());
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Nope");
                return;

            }
            
                
        }
    }
}
