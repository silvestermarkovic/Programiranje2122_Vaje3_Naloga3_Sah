using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga3_Sah
{
    //TODO A10 Ustvarite razred ChessBoardField
    //TODO A10      -ustvatite 2 public lastnosti X, Y tipa int 
    //TODO A10      -razred naj ima kontruktor s parametroma X, Y, ki določi vrednost lastnostima X, Y
    //TODO A10     -prepišite metotodo ToString, da izpiše točko v obliki (X,Y)
    //                  prepišemo metodo ToSting za izpis metode
    public class ChessBoardField
    {

        //vododravna kordinata
        public int X { get; set; }

        // Navpična koordinata
        public int Y { get; set; }

        public ChessBoardField(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        //prepišemo metodo ToSting za izpis metode
        public override string ToString()
        {
            return $"({this.X},{this.Y})";
        }
    }
}
