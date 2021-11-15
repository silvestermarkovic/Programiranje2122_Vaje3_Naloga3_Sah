using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga3_Sah
{
    public class PieceBishop : ChessPiece
    {
        private const double chessWeight = 2;
        private const string oznakaFigure = "B";

        public PieceBishop(ChessBoardField start) : base(start)
        {
            this.OznakaFigure = oznakaFigure;
            this.ChessWeight = chessWeight;

        }

        public override List<ChessBoardField> allowedMove()
        {
            List<ChessBoardField> tempDovoljeniPremiki = new List<ChessBoardField>();


            for (int i = 1; i <= 7; i++)
            {
                //gremo v 4 strani

                if (this.Position.X + i <= 8 && this.Position.Y + i <= 8)
                    tempDovoljeniPremiki.Add(new ChessBoardField(this.Position.X + i, this.Position.Y + i));

                if (this.Position.X - i > 0 && this.Position.Y + i <= 8)
                    tempDovoljeniPremiki.Add(new ChessBoardField(this.Position.X - i, this.Position.Y + i));

                if (this.Position.X + i <= 8 && this.Position.Y - i > 0)
                    tempDovoljeniPremiki.Add(new ChessBoardField(this.Position.X + i, this.Position.Y - i));

                if (this.Position.X - i > 0 && this.Position.Y - i > 0)
                    tempDovoljeniPremiki.Add(new ChessBoardField(this.Position.X - i, this.Position.Y - i));

            }
            return tempDovoljeniPremiki;
        }
    }
}
