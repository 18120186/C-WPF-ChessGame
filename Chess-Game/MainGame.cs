using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game
{
    class MainGame
    {
        List<Unit> ChessBoard = new List<Unit>();
        //bool Turn = true; //true == White turn, false == Black turn
        public MainGame()
        {
            //Tạo quân trắng
            Unit w1 = new WhiteRook(0, 0);
            Unit w2 = new WhiteKnight(0, 1);
            Unit w3 = new WhiteBishop(0, 2);
            Unit w4 = new WhiteQueen(0, 3);
            Unit w5 = new WhiteKing(0, 4);
            Unit w6 = new WhiteBishop(0, 5);
            Unit w7 = new WhiteKnight(0, 6);
            Unit w8 = new WhiteRook(0, 7);
            Unit w9 = new WhitePawn(1, 0);
            Unit w10 = new WhitePawn(1, 1);
            Unit w11 = new WhitePawn(1, 2);
            Unit w12 = new WhitePawn(1, 3);
            Unit w13 = new WhitePawn(1, 4);
            Unit w14 = new WhitePawn(1, 5);
            Unit w15 = new WhitePawn(1, 6);
            Unit w16 = new WhitePawn(1, 7);

            ChessBoard.Add(w1);
            ChessBoard.Add(w2);
            ChessBoard.Add(w3);
            ChessBoard.Add(w4);
            ChessBoard.Add(w5);
            ChessBoard.Add(w6);
            ChessBoard.Add(w7);
            ChessBoard.Add(w8);
            ChessBoard.Add(w9);
            ChessBoard.Add(w10);
            ChessBoard.Add(w11);
            ChessBoard.Add(w12);
            ChessBoard.Add(w13);
            ChessBoard.Add(w14);
            ChessBoard.Add(w15);
            ChessBoard.Add(w16);

        }
        public List<Unit> getChessBoard()
        {
            return ChessBoard;
        }
    }
}
