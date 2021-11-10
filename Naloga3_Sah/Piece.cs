using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga3_Sah
{
     
     
    public abstract class ChessPiece : IPiece
    {
        //določi lokalno spremenljivko position, ki bo hranila pozicijo figure
        //position (z malo!) je tipa  ChessBoardField,
        //ki bo dosegljiva samo znotraj razreda
        private ChessBoardField position;

        //ustvarite konstrukor razreda, ki dobi kot parameter začetno polje ChessBoardField
        //in ga zapiše v spremenljivko position
        public ChessPiece(ChessBoardField start)
        {
            this.position = start;
        }

        //določimo vse potrebne metode in lastnosti
        public bool IsAlive { get; set; }


        //ustvari lastnost Position, ki vrne position, vrednosti ne določa!!!
        public ChessBoardField Position
        {
            get
            {
                return position;
            }
            /*private set 
            {
                position = value;
            } */
        }

        //ustvarite lastnost ChessWeight
        public double ChessWeight { get; protected set; }


        //oznaka figure, bo predstavljala String, ki se bo izpisovala, 1 znak
        public string OznakaFigure { get; protected set; }


        public override string ToString()
        {
            return $"Sem šahovska figura {this.OznakaFigure} z vrednostjo {this.ChessWeight}.";
        }


        // Implementiramo metodo za premik figure.
        // Vsaka figura ima svoja pravila za premike, 
        // zato bomo to metodo zelo verjetno v vsakem izmed podrazredov prepisali ("override").
        // V ta namen jo označimo za virtualno.
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual?f1url=%3FappId%3DDev16IDEF1%26l%3DEN-US%26k%3Dk(virtual_CSharpKeyword);k(DevLang-csharp)%26rd%3Dtrue
        // </summary>
        // <param name="field">Polje, kamor naj se figura premakne</param>
        public virtual void Move(ChessBoardField field)
        {
            //v tem trenutku figuro samo premaknemo
            position = field;
        }

        //ustvarite najavo seznama tipa ChessBoardField z imenom allowedMove, ki jo mora razred definirati,
        //in je za vsak razred drugačna
        public abstract List<ChessBoardField> allowedMove();
        //seznam figur, ki jih lahko požrem napolni se v metodi dovoljeniPremikiIgra!


        //ustvarite metodo, ki izpiše seznam allowedMove
        public void printAllowedMove()
        {
            Console.WriteLine($"Dovoljeni premiki za {OznakaFigure} na poziciji {position.ToString()} so:");
            foreach (ChessBoardField poz in allowedMove())
            {
                Console.WriteLine($"{poz.ToString(),10}");
            }
        }

    }
