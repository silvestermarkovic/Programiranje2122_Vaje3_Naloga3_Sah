using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga3_Sah
{

    //ustvarite razred PieceKing
    //določite chessWeight kot neskončno, kot privatne konstante
    //določite oznakoFigure kot "K"
    //konstruktor, naj kliče deduje bazični konstruktor base(zacetnatocka)
    //v konstruktorju določite  OznakaFigure, in ji priredite vrednost oznakaFigure
    //enako naredimo za ChessWeight = chessWeight
    //prepišemo metodo allowedMove, ki v vrne seznam, kam se lahko premakne figura, glede na trenutno pozicijo
    public class PieceKing : ChessPiece
    {
        private const double chessWeight = double.PositiveInfinity;
        private const string oznakaFigure = "K";

        public PieceKing(ChessBoardField start) : base(start)
        {
            this.OznakaFigure = oznakaFigure;
            this.ChessWeight = chessWeight;

        }


        //TODO 66!!!!!!!!!!!!!! Kreirajte tabelo 
        public override List<ChessBoardField> allowedMove()
        {
            List<ChessBoardField> tempDovoljeniPremiki = new List<ChessBoardField>();

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i != 0 || j != 0)
                    {

                        if (this.Position.X + i >= 1 && this.Position.X + i <= 8 &&
                            this.Position.Y + j >= 1 && this.Position.Y + j <= 8)
                        { 

                            tempDovoljeniPremiki.Add(new ChessBoardField(this.Position.X + i, this.Position.Y + j));
                        }

                    }
                }
            }
            return tempDovoljeniPremiki;
        }

    }
}
