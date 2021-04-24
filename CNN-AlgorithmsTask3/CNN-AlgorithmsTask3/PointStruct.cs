using System;
using System.Collections.Generic;
using System.Text;

namespace CNN_AlgorithmsTask3
{
    public  struct PointStruct
    {



        public float PointDistanceFloat(float x1, float y1, float x2, float y2) // Обычный метод расчёта дистанции со значимым типом (PointStruct — координаты типа float).
        {
            float x = x2 - x1;
            float y = y2 - y1;
            return MathF.Sqrt((x * x) + (y * y));
        }


        double PointDistanceDouble(double x1, double y1, double x2, double y2) // Обычный метод расчёта дистанции со значимым типом (PointStruct — координаты типа double).
        {
            double x = x2 - x1;
            double y = y2 - y1;
            double z = (x * x) + (y * y);
           float z1 = (float)z;   // так как функция Sqrt принимает аргумент типа float

           return MathF.Sqrt(z1); //
        }


        float PointDistance(float x1, float y1, float x2, float y2) //Метод расчёта дистанции без квадратного корня со значимым типом (PointStruct — координаты типа float).
        {
            float x = x2 - x1;
            float y = y2 - y1;

            return (x * x) + (y * y);







        }
    }
}
