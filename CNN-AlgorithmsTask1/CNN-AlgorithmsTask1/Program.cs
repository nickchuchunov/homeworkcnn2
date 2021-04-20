using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CNN_AlgorithmsTask1
{
    class Program
    {
       
        static void Main()
        {
            /* Напишите на C# функцию согласно блок-схеме    */


            // DefiningSimpleComplexNumber fdfv = new DefiningSimpleComplexNumber(); 
            // TestCaseComplexNumber aefs = new TestCaseComplexNumber(); // экземпляр конструктора класа для проверки DefiningSimpleComplexNumber

            //fdfv.DefiningSimpleComplexNumber1(aefs.test1_number);



            //for (int i = 0; i < aefs.test1.Length; i++) { fdfv.DefiningSimpleComplexNumber1(aefs.test1[i]); } // проверка DefiningSimpleComplexNumber простыми числами
            //for (int i = 0; i < aefs.test2.Length; i++) { fdfv.DefiningSimpleComplexNumber1(aefs.test2[i]); } // проверка DefiningSimpleComplexNumber не простыми числами






















            /*  Посчитайте сложность функции */

            /* public static int  StrangeSum(int[] inputArray)
         {
         int sum = 0;
         for (int i = 0; i < inputArray.Length; i++) // O(f(i))
         {
         for (int j = 0; j < inputArray.Length; j++) // O(f(j))
                     {
            for (int k = 0; k < inputArray.Length; k++) // O(f(k))
                         {
                int y = 0;

                if (j != 0) 
                             {
                    y = k / j;  // O(f(i*j*k))
                             }

                sum += inputArray[i] + i + k + j + y; // O(f(i*j*k))
                         }
         }
         }

         return sum; }


             // сложность функции = O(f(i))*O(f(j))*O(f(k))+ O(f(i*j*k))+  O(f(i*j*k)) */


            /*  Реализуйте функцию вычисления числа Фибоначчи  (Требуется реализовать рекурсивную версию и версию без рекурсии (через цикл).) */


           static void FibonacciFunction(int F, out int Ffib1) { Ffib1 = 0; for (int i = 0; i < F; i++) { int Ffib = (F - i); Ffib1 += Ffib; }; Console.WriteLine(Ffib1);  }

           FibonacciFunction(6, out int Ffib1);

            // Реализуйте функцию вычисления числа Фибоначчи с рекурсией мне не удалось реализовать



            // 


        }
    }
}
