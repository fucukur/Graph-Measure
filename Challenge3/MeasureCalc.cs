using System.Reflection;

namespace Challenge3
{
    public class MeasureCalc
    {
        public static int Calculate(char measureFirstCity, char measureSecondCity, int[,] cityMap)
        {
            int distance = 0;
            int firstCityInt, secondCityInt;// Gelen degeri int degere cevirdik.
            firstCityInt = measureFirstCity - 'A';
            secondCityInt = measureSecondCity - 'A';

            distance = cityMap[firstCityInt, secondCityInt];

            return distance;
        }
    }
}