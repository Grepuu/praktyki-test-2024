using System.Drawing;

namespace Praktyki2024.StronaInternetowa.Models
{
    public class CarDetailsViewModel
    {
        public string Marka { get; set; }
        public string Kolor { get; set; }
        public float Cena { get; set; }
        public bool CzyZepsuty { get; set; }
        public float Przebieg { get; set; }

        public CarDetailsViewModel() { }

        public CarDetailsViewModel(string marka, string kolor, float cena, bool czyZepsuty, float przebieg)
        {
            this.Marka = marka;
            this.Kolor = kolor;
            this.Cena = cena;
            this.CzyZepsuty = czyZepsuty;
            this.Przebieg = przebieg;
        }
    }
}