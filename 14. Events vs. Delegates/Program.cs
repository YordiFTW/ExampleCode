using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Events_vs.Delegates
{
    public class TrainSignal
    {
        public event Action TrainsAComing;
        public void HereComesATrain()
        {
            if(TrainsAComing != null)
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
            //trainSignal.TrainsAComing();
            //trainSignal.TrainsAComing();
            //trainSignal.TrainsAComing();
            //trainSignal.TrainsAComing();
            //trainSignal.TrainsAComing = null;
            trainSignal.HereComesATrain();
        }
    }
}