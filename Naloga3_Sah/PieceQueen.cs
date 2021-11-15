using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga3_Sah
{
    public class PieceQueen : ChessPiece 
    {
        private const double chessWeight = 9;
        private const string oznakaFigure = "Q";
        public PieceQueen(ChessBoardField start) : base(start)
        {
            this.OznakaFigure = oznakaFigure;
            this.ChessWeight = chessWeight;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nMoje ime je {this.GetType()}";
        }
        public override List<ChessBoardField> allowedMove()
        {
            /*
             //premike dobimo tako, da damo skupaj dovoljene premike na tem mestu od Tekača in Topa

            PieceBishop  tempTekac = new PieceBishop(this.Position);
            PieceRook  tempTop = new PieceRook(this.Position);

            List<ChessBoardField> tempSezTekac = tempTekac.allowedMove();
            List<ChessBoardField> tempSezTop = tempTop.allowedMove();

            foreach (ChessBoardField poz in tempSezTekac) {
                tempSezTop.Add(poz);
            }
            return tempSezTop;
              
            //*/


            List<ChessBoardField> seznam = new List<ChessBoardField>();

                //polja tekača
                for (int i = 1; i <= 7; i++)
                {
                    //gremo v 4 strani kot tekač in kot top
                    if (this.Position.X + i <= 8 && this.Position.Y + i <= 8)
                        seznam.Add(new ChessBoardField(this.Position.X + i, this.Position.Y + i));

                    if (this.Position.X - i > 0 && this.Position.Y + i <= 8)
                        seznam.Add(new ChessBoardField(this.Position.X - i, this.Position.Y + i));

                    if (this.Position.X + i <= 8 && this.Position.Y - i > 0)
                        seznam.Add(new ChessBoardField(this.Position.X + i, this.Position.Y - i));

                    if (this.Position.X - i > 0 && this.Position.Y - i > 0)
                        seznam.Add(new ChessBoardField(this.Position.X - i, this.Position.Y - i));


                    //premiki top
                    if (Position.X + i <= 8) seznam.Add(new ChessBoardField(Position.X + 1, Position.Y));
                    if (Position.X - i > 0) seznam.Add(new ChessBoardField(Position.X - 1, Position.Y));

                    if (Position.Y + i <= 8) seznam.Add(new ChessBoardField(Position.X, Position.Y + 1));
                    if (Position.Y - i > 0) seznam.Add(new ChessBoardField(Position.X, Position.Y - 1));

                }
                return seznam;
             
        }
     }
}
