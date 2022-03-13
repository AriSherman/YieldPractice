using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldCollectionPractice
{
    internal class Agency
    {
        public Car[] Cars;
        public IEnumerator<Car> GetEnumerator()
        {
            foreach (var car in Cars)
                yield return car;
        }

        public IEnumerable<Car> GetCars(int model)
        {
            foreach (Car car in Cars)
            {
                if (car.ModelYear == model)
                {
                    yield return car;
                }
            }
        }
        public IEnumerable<Car> GetCars(string maker)
        {
            foreach (Car car in Cars)
            {
                if (car.Maker == maker)
                {
                    yield return car;
                }
            }
        }
    }
}
