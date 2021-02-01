using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Basic_Observer_Pattern_Using_Delegates
{
    public class TrainSignal
    {
        public Action TrainsAComing;
        public void HereComesATrain()
        {
            TrainsAComing();
        }
    }

    class Car
    {
        public Car(TrainSignal trainSignal)
        {
            trainSignal.TrainsAComing += StopTheCar;
        }

        void StopTheCar()
        {
            Console.WriteLine("Screeeeeeetch");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TrainSignal trainSignal = new TrainSignal();
            new Car(trainSignal);
            new Car(trainSignal);
            new Car(trainSignal);
            new Car(trainSignal);
            new Car(trainSignal);
            trainSignal.HereComesATrain();
        }
    }
}
