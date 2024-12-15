using System;

namespace Homework
{
    internal class Truck : Vehicle, IDriveable
    {
        private int _tonaz;     // tonaz vozidla
        public Truck(int idVozidla, string popisVozidla, int tonaz) : base(idVozidla, popisVozidla)
        {
            _tonaz = tonaz;
        }
        public int GetTonaz()
        {
            return _tonaz;
        }
        public void SetModel(int tonaz)
        {
            _tonaz = tonaz;
        }

        public int Drive()
        {
            return 10;
        }

        public override void VodicskeOpravnenie()
        {
            Console.WriteLine("Vodič nákladného auta");
        }

        public override void UcelJazdy()
        {
            Console.WriteLine("Preprava tovaru");
        }
    }
}
