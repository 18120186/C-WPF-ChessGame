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
        List<List<Unit>> ChessBoard = new List<List<Unit>>();
        //bool Turn = true; //true == White turn, false == Black turn
        public MainGame()
        {
            List<Unit> Row_0 = new List<Unit>();
            List<Unit> Row_1 = new List<Unit>();
            WhiteRook w1 = new WhiteRook();
            WhiteKnight w2 = new WhiteKnight();
            WhiteBishop w3 = new WhiteBishop();
            WhiteQueen w4 = new WhiteQueen();
            WhiteKing w5 = new WhiteKing();
            WhiteBishop w6 = new WhiteBishop();
            WhiteKnight w7 = new WhiteKnight();
            WhiteRook w8 = new WhiteRook();
            WhitePawn w9 = new WhitePawn();
            Row_0.Add(w1);
            Row_0.Add(w2);
            Row_0.Add(w3);
            Row_0.Add(w4);
            Row_0.Add(w5);
            Row_0.Add(w6);
            Row_0.Add(w7);
            Row_0.Add(w8);
            ChessBoard.Add(Row_0);
        }
        public List<List<Unit>> getChessBoard()
        {
            return ChessBoard;
        }
    }
}
