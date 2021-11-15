using System;

namespace Naloga3_Sah
{
    class Program
    {
        static void Main(string[] args)
        {


            //testni primeri
            
            PieceKing kralj1 = new PieceKing(new ChessBoardField(3,5));
            kralj1.printAllowedMove();
            kralj1.Move(new ChessBoardField(6,7));
            kralj1.printAllowedMove();
            kralj1.Move(new ChessBoardField(1, 4));

            //Enako naredi za tekača

            PieceBishop tekac1 = new PieceBishop(new ChessBoardField(3, 5));
            tekac1.printAllowedMove();
            tekac1.Move(new ChessBoardField(1,3));
            tekac1.printAllowedMove();
            PieceBishop tekac2 = new PieceBishop(new ChessBoardField(1, 6));

            //top
            PieceRook top1 = new PieceRook(new ChessBoardField(2, 2));
            top1.printAllowedMove();
            top1.Move(new ChessBoardField(1, 1));
            top1.printAllowedMove();
            PieceRook top2 = new PieceRook(new ChessBoardField(1, 8));


            //konj
            PieceKnight konj1 = new PieceKnight(new ChessBoardField(2, 2));
            konj1.printAllowedMove();
            konj1.Move(new ChessBoardField(1, 2));
            konj1.printAllowedMove();

            PieceKnight konj2 = new PieceKnight(new ChessBoardField(1, 7));
            konj2.printAllowedMove();

            //TODO 10 (po vzoru ostalih figur)
            //ustvarite razred kraljica, ki deduje ChessPiece
            //oznaka figure je Q, vrednost pa je 9
            //odkomentirajte spodnjo kodo in jo preizkusite, ali vam vrne pravilno
            /* PieceQueen kraljica1 = new PieceQueen(new ChessBoardField(2, 2));
            kraljica1.printAllowedMove();
            kraljica1.Move(new ChessBoardField(5, 5));
            kraljica1.printAllowedMove();  */


            //TODO 30
            //ustvarite razred igra (razred imate pripravljen)
            //vse dodane figure dodajte v seznam figur

            Igra igra = new Igra();
            /*
             igra.seznam.Add(konj1);
             igra.seznam.Add(konj2);
             igra.seznam.Add(tekac1);
             igra.seznam.Add(tekac2);
             igra.seznam.Add(top1);
             igra.seznam.Add(top2);
             igra.seznam.Add(kralj1);
             //dodamo še kraljico1
             igra.izrisiStanjeIgre(); */


        }
    }
}
