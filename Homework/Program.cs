using System;

namespace Homework
{
    public class Program
    {
        static void Main(string[] args)
        {

            IDriveable[] driveables = new IDriveable[150];

            int idVozidla = 1;

            for (int i = 0; i < 50; i++)
            {
                driveables[i] = new Car(idVozidla, "Skoda 105", "biela");
                idVozidla++;
            }

            for (int i = 50; i < 100; i++)
            {
                driveables[i] = new Motorcycle(idVozidla, "Yamaha 350", "Yamaha");
                idVozidla++;
            }

            for (int i = 100; i < 150; i++)
            {
                driveables[i] = new Truck(idVozidla, "Tatra 148", 8);
                idVozidla++;
            }


            Vehicle[] vehicles = new Vehicle[60];

            idVozidla = 1;

            for (int i = 0; i < 30; i++)
            {
                vehicles[i] = new Car(idVozidla, "Felicia", "zlta");
                idVozidla++;
            }

            for (int i = 30; i < 50; i++)
            {
                vehicles[i] = new Motorcycle(idVozidla, "Honda 500", "Honda");
                idVozidla++;
            }

            for (int i = 50; i < 60; i++)
            {
                vehicles[i] = new Truck(idVozidla, "Man", 10);
                idVozidla++;
            }


            int i1 = 1;
            foreach (IDriveable driveable in driveables)
            {
                Console.WriteLine(i1 + " Drive: " + driveable.Drive());
                i1++;
            }
            Console.WriteLine();


            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.GetIdVozidla() + " " + vehicle.GetPopisVozidla());
                vehicle.VodicskeOpravnenie();
                vehicle.UcelJazdy();
                Console.WriteLine();
            }
        }
    }
}
