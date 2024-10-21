using System.Drawing;

namespace Praktyki2024.StronaInternetowa.Models
{
    public class CarStatsViewModel
    {
        public int IloscMercedes { get; set; }
        public int IloscBmw { get; set; }
        public int IloscDostawcze { get; set; }
        public int IloscZielony { get; set; }
        public int IloscSerwis { get; set; }

        public CarStatsViewModel() { }

        public CarStatsViewModel(int mercedes, int bmw, int dostawcze, int zielony, int serwis) {
            this.IloscMercedes = mercedes;
            this.IloscBmw = bmw;
            this.IloscDostawcze = dostawcze;
            this.IloscZielony = zielony;
            this.IloscSerwis = serwis;
        }
    }
}