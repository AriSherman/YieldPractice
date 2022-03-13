/*
Yield collection practice
Create a Car class that contains Maker ,  ModelYear fields
Create an Agency class that contains Cars list fields,  GetEnumerator , GetCars methods to enable foreach iteration. GetCars can receive maker or modelYear parameter that filters the returned cars
Use this documentation to learn about yield, iterators : 
Use the following code :
*/

using System;
using System.Collections;
using System.Collections.Generic;

namespace YieldCollectionPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Agency a1 = new Agency();
            a1.Cars = new Car[]{
                    new Car(){ ModelYear = 2001 , Maker = "Subaro"},
                    new Car(){ ModelYear = 2021 , Maker = "Toyota"},
                    new Car(){ ModelYear = 2013 , Maker = "Subaro"},
                    new Car(){ ModelYear = 2004 , Maker = "Fiat"},
                    new Car(){ ModelYear = 2021 , Maker = "Fiat"},
                    new Car(){ ModelYear = 2015 , Maker = "Subaro"}
            };
            //
            System.Console.WriteLine("All cars in the agency:");
            foreach (var car in a1)
                System.Console.WriteLine(car);
            System.Console.WriteLine("All cars in the agency from 2021:");
            foreach (var car in a1.GetCars(2021))
                System.Console.WriteLine(car);
            System.Console.WriteLine("All cars in the agency of Fiat:");
            foreach (var car in a1.GetCars("Fiat"))
                System.Console.WriteLine(car);

            //foreach (var item in GetNumbers())
            //{
            //    Console.WriteLine("item = {0}", item);
            //}
        }


        //public static IEnumerable GetNumbers()
        //{
        //    yield return 0; 
        //    yield return 1; 
        //    yield return 3; 
        //    yield return 5; 
        //    yield return 0; 
        //    yield return 10; 
        //    yield break;
        //    Console.WriteLine("Function ended");

        //}

        //public static int[] GetNumbers()
        //{
        //    int[] numbers = new int[10];
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine(i);
        //        numbers[i] = i;
        //    }
        //    return numbers;
        //}
    }


}
//


/* out pormat:
agencyEn
All cars in the agency:
2001,Subaro
2021,Toyota
2013,Subaro
2004,Fiat
2021,Fiat
2015,Subaro
All cars in the agency from 2021:
2021,Toyota
2021,Fiat
All cars in the agency of Fiat:
2004,Fiat

*/