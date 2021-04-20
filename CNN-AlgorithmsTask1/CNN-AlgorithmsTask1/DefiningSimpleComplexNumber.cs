using System;
using System.Collections.Generic;
using System.Text;

namespace CNN_AlgorithmsTask1
{


   public class DefiningSimpleComplexNumber
    {


       public int d = 0;
        public int i = 2;
        public int z = 0;

        public void DefiningSimpleComplexNumber1(double number)
        {
            double number1 = 0; // вспомогательная переменная для выполнения функции 1 раз для каждого number

            while ( number1!=number) // while для возврата переменнх i и d с помощью оператора continue
            {
                if (i < number) { if (number % i == 0) { d++; continue; } else { i++; continue; }; }
                else { if (d == 0) { Console.WriteLine("{0} - простое число", number); z++;  } else { Console.WriteLine("{0} - не простое", number); z++;} }

                 number1 = number;


            }
                
               
            
        }




       public DefiningSimpleComplexNumber() {    }



        














    }




}

        









       

  
