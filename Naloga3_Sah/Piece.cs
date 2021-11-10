using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga3_Sah
{
    //TODO B10 ustvarite interface IPiece

    public interface IPiece
    {
        //TODO B11
        //ustvarite najavo metode Move, ki bo kot paramter dobila ChessBoardField novaPozicija,
        //medtoda bo premaknila objekt na to pozicijo
        //koda

        //TODO B12
        //ustvarite najavo metode, allowedMove ki vrne seznam dovoljeneh premikov figure,
        //glede na trenutno pozicijo
        //koda

        //TODO B13 najavite metodo allowedMove
        //izpiše seznam (dovoljene premike)
        //koda


        // 
        // Vmesniki definirajo tudi lastnosti v enaki obliki, 
        // kot v razredu definiramo samodejno implementirane lastnosti.
        // Vendar moramo lastnosti vmesnika dejansko implementirati v razredu.
        // 
        //TODO B14
        //ustvarite lastnost IsAlive, v kateri bomo vodili ali je figura aktivna ali ne
        //lastnost je tipa bool in jo lahko spreminjamo in beremo
        //koda


        //TODO B15 ustvarite lastnost ChessWeight, ki bo določala vrednost figure
        //lastnost je tipa double in jo lahko samo beremo
        //koda

        //TODO B16 ustvarite lastnost Position (vrni polje position)
        //lastnost je tipa ChessBoardField in jo lahko samo beremo
        //koda
    }


    //TODO 20 ustvarite abstraktni razred ChessPiece

    public abstract class ChessPiece : IPiece
    {
        //TODO 21 določi lokalno spremenljivko position, ki bo hranila pozicijo figure
        //position (z malo!) je tipa  ChessBoardField,
        //ki bo dosegljiva samo znotraj razreda


        //TODO 22 
        //ustvarite konstrukor razreda, ki dobi kot parameter začetno polje ChessBoardField
        //in ga zapiše v spremenljivko position


        //TODO 23
        //določimo vse potrebne metode in lastnosti, isAlive (bool, get,set)


        //TODO 24
        //ustvarite lastnost ChessWeight
        public double ChessWeight { get; protected set; }


        //TODO 25
        //ustvari lastnost Position, ki vrne position, vrednosti ne določa!!!
        //samo get




        //oznaka figure, bo predstavljala String, ki se bo izpisovala, 1 znak
        public string OznakaFigure { get; protected set; }

        //TODO 28 prepiši metodo ToString in izpišite vrstico v konzolo v obliki
        //   OznakaFigure    Pozicija
        //   K  (2,3)




        //TODO 30
        // Implementiramo metodo za premik figure.
        // Vsaka figura ima svoja pravila za premike, 
        // zato bomo to metodo zelo verjetno v vsakem izmed podrazredov prepisali ("override").
        // V ta namen jo označimo za virtualno.
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual?f1url=%3FappId%3DDev16IDEF1%26l%3DEN-US%26k%3Dk(virtual_CSharpKeyword);k(DevLang-csharp)%26rd%3Dtrue
        // </summary>
        // <param name="field">Polje, kamor naj se figura premakne</param>
        public virtual void Move(ChessBoardField field)
        {
            //v tem trenutku figuro samo premaknemo na določeno pozicijo
            position = field;
        }


        //TODO 35
        //ustvarite najavo seznama tipa ChessBoardField z imenom allowedMove, ki jo mora razred definirati,
        //in je za vsak razred drugačna

        //TODO 40
        //ustvarite metodo, ki izpiše seznam allowedMove


    }

}
