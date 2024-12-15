using System;

namespace Homework
{
    internal class Motorcycle : Vehicle, IDriveable
    {
        private string _model;    // model motrocykla
        public Motorcycle(int idVozidla, string popisVozidla, string model) : base(idVozidla, popisVozidla)
        {
            _model = model;
        }
        public string GetModel()
        {
            return _model;
        }
        public void SetModel(string model)
        {
            _model = model;
        }

        public int Drive()
        {
            return 1;
        }

        public override void VodicskeOpravnenie()
        {
            Console.WriteLine("Vodič motocykla");
        }

        public override void UcelJazdy()
        {
            base.UcelJazdy();
            Console.WriteLine("Výlet na moterke");
        }
    }
}
