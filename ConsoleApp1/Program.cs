using System;

namespace ConsoleApp1
{
   public class Program
    {

        public void GetFibonancySeries()
        {
            //Fibonancy series//output -Entered number 10 then result is 0,0,1,1,2,3,5,8,13,21
            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
            for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
        public void GetPrimeNumber()
        {
            //int number = 5, a = 0;
            int  number ,a = 0;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    a++;//it will come 2 times only and make value of a is 2 for prime number other than prime number it will add more then 2 
                }
            }
            if (a == 2)
            {
                Console.WriteLine("{0} is a Prime Number", number);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
            Console.ReadLine();
        }

        public void GetPelindromeNumber()
        {
            //Get the number from user
            //Hold the number in temporary variable
            //Reverse the number
            //Compare the temporary number with reversed number
            //If both numbers are same, print palindrome number
            //Else print not palindrome number

            string string1, rev;
            string1 = "Madam";
            char[] ch = string1.ToCharArray();

            Array.Reverse(ch);
            rev = new string(ch);

            bool b = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine("String " + string1 + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine("String " + string1 + " is not a Palindrome!");
            }
            Console.Read();
        }

        public void GetFactorial()
        {
            //4! = 4 * 3 * 2 * 1 = 24
            //6! = 6 * 5 * 4 * 3 * 2 * 1 = 720
            int i, fact = 1, number;
            Console.Write("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            //p.GetFibonancySeries();
            //p.GetPrimeNumber();
            //p.GetPelindromeNumber();
            p.GetFactorial();
        }

    }
}
