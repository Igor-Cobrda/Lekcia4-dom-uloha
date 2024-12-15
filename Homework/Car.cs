using System;

namespace Homework
{
    public class Car : Vehicle, IDriveable
    {
        private string _color;
        public Car(int idVozidla, string popisVozidla, string clolor) : base(idVozidla, popisVozidla)
        {
            _color = clolor;
        }
        public string GetColor()
        {
            return _color;
        }
        public void SetColor(string color)
        {
            _color = color;
        }


        public int Drive()
        {
            return 3;
        }

        public override void VodicskeOpravnenie()
        {
            Console.WriteLine("Vodič auta");
        }
    }
}
