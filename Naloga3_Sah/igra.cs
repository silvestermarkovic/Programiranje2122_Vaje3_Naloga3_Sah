using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga3_Sah
{
    //TODO 20
    class Igra
    {
        //TODO 25 dodajte seznam figur, kamor boste dodali ustvarjene figure
        //ustvarite 2 seznama za vsakega igralca posebaj
        //igralec1 in igralec2
        //koda
        public List<ChessPiece> igralec1 = new List<ChessPiece>();
        public List<ChessPiece> igralec2 = new List<ChessPiece>();


        //TODO 26 usvarite metodo izrisiStanjeIgre, ki bo izpisala trenutno stanje figur v seznamu
        //primer oblike izpisa:
        //metoda naj razlikuje med prvim in drugim igralcem (oznake figur prvega igralca naj bodo zapisane z veliko)

        // ob strani oznaka Y osi, spodaj X osi in izpis oznak figur
        /*  8r
            7n
            6b
            5
            4k      K
            3b      B
            2n      N
            1r      R
             12345678
          
         //pomagajte si z dvodimenzionalno tabelo 
         //string[,] polja = new string[9, 9];
         * */
        //ta metoda bo izrisala trenutno stanje postavitve fiur
        //koda metode
        public void izrisiStanjeIgre()
        {
            string[,] polja = new string[9, 9];

            foreach (ChessPiece figura in igralec1)
            {
                polja[figura.Position.X, figura.Position.Y] = figura.OznakaFigure.ToUpper();
            }
            foreach (ChessPiece figura in igralec2)
            {
                polja[figura.Position.X, figura.Position.Y] = figura.OznakaFigure.ToLower();
            }

            for (int osy = 8; osy > 0; osy--)
            {
                string vrstica = osy.ToString();
                for (int osx = 1; osx <= 8; osx++)
                {
                    vrstica += (polja[osx, osy] != null) ? polja[osx, osy] : " ";
                }
                Console.WriteLine(vrstica);

            }
            Console.WriteLine(" 12345678");
        }
    }
}
