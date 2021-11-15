using System;
using System.Collections.Generic;
using System.Text;

namespace Naloga3_Sah
{
    public class PieceKnight : ChessPiece
    {
        private const double chessWeight = 3;
        private const string oznakaFigure = "N";

        public PieceKnight(ChessBoardField start) : base(start)
        {
            this.OznakaFigure = oznakaFigure;
            this.ChessWeight = chessWeight;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nMoje ime je {this.GetType()}";
        }
          

        public override List<ChessBoardField> allowedMove( )
        {
            List<ChessBoardField> seznam = new List<ChessBoardField>();


            for (int i = -1; i <= 1; i += 2)
            {
                for (int j = -1; j <= 1; j += 2)
                {
                    int temp_x = Position.X + 2 * i;
                    int temp_y = Position.Y + j;

                    if (temp_x > 8 || temp_x < 1 || temp_y > 8 || temp_y < 1) continue;
                        seznam.Add(new ChessBoardField(temp_x, temp_y));


                    temp_x = Position.X + i;
                    temp_y = Position.Y + 2 * j;
                    if (temp_x > 8 || temp_x < 1 || temp_y > 8 || temp_y < 1) continue;
                         seznam.Add(new ChessBoardField(temp_x, temp_y));

                }
            }

            return seznam;
        }
    }
}
