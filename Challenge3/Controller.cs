using System;

namespace Challenge3
{
    class Controller
    {
        static void Main(string[] args)
        {
            int cityCount;
            int i, j;

            Console.WriteLine("Eklemek Istediginiz Sehir Sayisini Giriniz");
            cityCount = Convert.ToInt32(Console.ReadLine());

            //Alfabede 26 harf bulunuyor.
            while (cityCount > 26) {
                Console.WriteLine("Sehir Sayisi 26 dan buyuk olamaz.\nEklemek Istediginiz Sehir Sayisini Giriniz");
                cityCount = Convert.ToInt32(Console.ReadLine());
            }

            int[,] cityMap = new int[cityCount, cityCount];

            for (i = 0; i < cityCount; i++) {
                for (j = 0; j < cityCount; j++) {

                    if (i == j) {
                        cityMap[i, j] = -2;
                    }
                    else cityMap[i, j] = -1;

                }
            }
            char chooseAdd, firstCity, secondCity;
            char chooseMeasure, measureFirstCity, measureSecondCity;
            int measure = 0, firstCityInt, secondCityInt, result;

            MeasureCalc Calculate = new MeasureCalc();


            while (true) {
                Console.Write("\nSehir Mesafesi Eklemek Ister misiniz? [Y/N]");
                chooseAdd = Convert.ToChar(Console.ReadLine());

                if (chooseAdd == 'Y')
                {
                    Console.Write("Ilk Sehri Giriniz :");
                    firstCity = Convert.ToChar(Console.ReadLine());
                    Console.Write("Ikinci Sehri Giriniz :");
                    secondCity = Convert.ToChar(Console.ReadLine());
                    Console.Write("Sehirler Arasi Mesafeleri Giriniz :");
                    measure = Convert.ToInt32(Console.ReadLine());

                    firstCityInt = firstCity - 'A';
                    secondCityInt = secondCity - 'A';

                    cityMap[firstCityInt, secondCityInt] = measure;

                }
                else {
                    Console.Write("\nMesafe Olcmek Istiyor musunuz ? [Y/N]");
                    chooseMeasure = Convert.ToChar(Console.ReadLine());

                    if (chooseMeasure == 'Y')
                    {
                        Console.Write("Ilk Sehri Seciniz : ");
                        measureFirstCity = Convert.ToChar(Console.ReadLine());
                        Console.Write("Ikinci Sehri Seciniz : ");
                        measureSecondCity = Convert.ToChar(Console.ReadLine());


                        result = MeasureCalc.Calculate(measureFirstCity, measureSecondCity, cityMap);

                        if (result == -1)
                        {
                            Console.Write("Mesafe Bulunamadi..");
                        }
                        else if (result == -2)
                        {
                            Console.Write("Girdiginiz iki sehir ayni..");
                        }
                        else
                        {
                            Console.Write("Mesafeniz :" + result + " birimdir.. ");
                        }
                    }

                    else
                    {
                        Console.Write("Seciminiz Hayir Oldugu Icin Program 5 sn Sonra Kapanacaktir..");
                        System.Threading.Thread.Sleep(5000);
                        Environment.Exit(0);
                    }
                    
                }
            }
        }


    }

}
