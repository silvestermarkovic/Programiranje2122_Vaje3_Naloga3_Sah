using System;
using System.Collections.Generic;
using System.Text;

namespace Naloga3_Sah
{
    public class PieceRook : ChessPiece
    {
        private const double chessWeight = 4.9;
        private const string oznakaFigure = "R";
        public PieceRook(ChessBoardField start) : base(start)
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

            //premik Desno
            for (int i = 1; i <= 8 - Position.X; i++)
            {

                int temp_x = Position.X + i;
                int temp_y = Position.Y;

                
                     seznam.Add(new ChessBoardField(temp_x, temp_y));
                
            }
            //premik Levo
            for (int i = 1; i < Position.X; i++)
            {
                int temp_x = Position.X - i;
                int temp_y = Position.Y;
                 
                    seznam.Add(new ChessBoardField(temp_x, temp_y));
                 
            }


            //premik Gor
            for (int i = 1; i <= 8 - Position.Y; i++)
            {
                int temp_x = Position.X;
                int temp_y = Position.Y + i;
                
                    seznam.Add(new ChessBoardField(temp_x, temp_y));
                 
            }

            //premik Dol
            for (int i = 1; i < Position.Y; i++)
            {
                int temp_x = Position.X;
                int temp_y = Position.Y - i;
                
                    seznam.Add(new ChessBoardField(temp_x, temp_y));
                
            }

            return seznam;
        }
    }
}
