using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
 static class Calculator
    {
        private static int _resulststorage = 0;
        public static string type = "Arithmetic";
        public static  int Sum(int num1,int num2)
        {
            return num1 + num2;
        }
        public static void Store(int result)
        {
            _resulststorage = result;
        }
    }
}
