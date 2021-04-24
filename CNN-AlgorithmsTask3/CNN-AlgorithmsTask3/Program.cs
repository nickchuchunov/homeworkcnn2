using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace CNN_AlgorithmsTask3
{












    public class Program



    {




        public static void Main(string[] args)
        {




            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);










        }


        public class BechmarkClass
        {
            public int SumValueType(int value)
            {
                return 9 + value;
            }
            public int SumRefType(object value)
            {
                return 9 + (int)value;
            }




            public float x1 = 6;
            public float x2 = 9;
            public float y1 = 8;
            public float y2 = 13;


            

            
            [Benchmark]
            public float PointDistance() //Обычный метод расчёта дистанции со ссылочным типом (PointClass — координаты типа float).
            {





                float x = x2 - x1;
                float y = y2 - y1;
                return MathF.Sqrt((x * x) + (y * y));





            }


           public struct testFloat_X_Y { public float X { get; set; } public float Y { get; set; } }

            public struct testDoubl_X_Y { public double X { get; set; } public double Y { get; set; } }












            [Benchmark]
           public float PointDistanceFloat() // Обычный метод расчёта дистанции со значимым типом (PointStruct — координаты типа float).
             {

                testFloat_X_Y TestFloat_X_Y = new testFloat_X_Y { X = 5, Y=5 };


                float x = TestFloat_X_Y.X;
                float y = TestFloat_X_Y.Y;

                return MathF.Sqrt((x * x) + (y * y));




      }


     [Benchmark]
            public double PointDistanceDouble() // Обычный метод расчёта дистанции со значимым типом (PointStruct — координаты типа double).
            {

                testDoubl_X_Y TestDoubl_X_Y = new testDoubl_X_Y { X = 8, Y = 10 };

                double x = TestDoubl_X_Y.X;
                double y = TestDoubl_X_Y.Y;
                double z = (x * x) + (y * y);
                float z1 = (float)z;   // так как функция Sqrt принимает аргумент типа float

                return MathF.Sqrt(z1); //
            }

            [Benchmark]
            public float PointDistanceStruct() //Метод расчёта дистанции без квадратного корня со значимым типом (PointStruct — координаты типа float).
            {
                testFloat_X_Y TestFloat_X_Y = new testFloat_X_Y { X = 5, Y = 5 };
                float x = TestFloat_X_Y.X;
                float y = TestFloat_X_Y.Y;



                return (x * x) + (y * y);



            }





        }





    }
}
            


        
    





















