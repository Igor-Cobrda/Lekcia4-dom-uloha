using System;

namespace Homework
{
    public abstract class Vehicle
    {

        private int _idVozidla;                 //identifikator vozidla
        public int GetIdVozidla()
        { 
            return _idVozidla; 
        }
        public void SetIdVozidla(int idVozidla)
        {
            _idVozidla = idVozidla;
        }


        private string _popisVozidla;    //popis vozidla
        public string GetPopisVozidla()
        {
            return _popisVozidla;
        }
        public void SetPopisVozidla(string popisVozodla)
        {
            _popisVozidla = popisVozodla;
        }


        // konstruktor
        public Vehicle(int idVozidla, string popisVozidla)
        {
            _idVozidla = idVozidla;
            _popisVozidla = popisVozidla;
        }


        // metody
        public abstract void VodicskeOpravnenie();

        public virtual void UcelJazdy()
        {
            Console.WriteLine("Súkromná jazda");
        }

    }
}
