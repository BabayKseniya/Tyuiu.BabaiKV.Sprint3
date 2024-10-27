﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BabaiKV.Sprint3.Task0.V4.Lib
{
    public class DataService : ISprint3Task0V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double proSeries = 1;
            int i ;
            for ( i = startValue; i <= stopValue; i ++ )
            {
                proSeries = proSeries * (Math.Sin(0.1) + i);

            }
            return Math.Round(proSeries, 3);
        }
    }
}
