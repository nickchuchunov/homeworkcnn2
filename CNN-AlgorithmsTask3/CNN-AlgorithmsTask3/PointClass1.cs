using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace CNN_AlgorithmsTask3
{
   public class PointClass1
    {


        


        public PointClass1()



        {



            






        }
              
        public static float PointDistance(float x1, float y1, float x2, float y2) //Обычный метод расчёта дистанции со ссылочным типом (PointClass — координаты типа float).
        {
            
            float x = x2 - x1;
            float y = y2 - y1;
            return MathF.Sqrt((x * x) + (y * y));
        }










    }
}
