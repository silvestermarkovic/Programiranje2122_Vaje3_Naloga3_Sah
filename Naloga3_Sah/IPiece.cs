using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga3_Sah
{
    public interface IPiece
    {

        //ustvarite najavo metode Move, ki bo kot paramter dobila ChessBoardField novaPozicija,
        //medtoda bo premaknila objekt na to pozicijo
        void Move(ChessBoardField novaPozicija);

        //ustvarite najavo metode, allowedMove ki vrne seznam dovoljeneh premikov figure,
        //glede na trenutno pozicijo
        List<ChessBoardField> allowedMove();

        //izpiše seznam allowedMove (dovoljene premike)
        void printAllowedMove();


        /// <summary>
        /// Vmesniki definirajo tudi lastnosti v enaki obliki, 
        /// kot v razredu definiramo samodejno implementirane lastnosti.
        /// Vendar moramo lastnosti vmesnika dejansko implementirati v razredu.
        /// </summary>
        /// 
        //ustvarite lastnost IsAlive, v kateri bomo vodili ali je figura aktivna ali ne
        //lastnost je tipa bool in jo lahko spreminjamo in beremo
        bool IsAlive { get; set; }


        //ustvarite lastnost ChessWeight, ki bo določala vrednost figure
        //lastnost je tipa double in jo lahko samo beremo
        double ChessWeight { get; }

        //ustvarite lastnost Position (vrni polje position)
        //lastnost je tipa ChessBoardField in jo lahko samo beremo
        ChessBoardField Position { get; }
    }

}
