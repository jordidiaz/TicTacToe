using System;

namespace TicTacToe.TicTacToe
{
    public class Game
    {
        private string LastSymbolPlayed;
        
        public Game()
        {
            Board = new Board();
            
            LastSymbolPlayed = String.Empty;
        }
        
        public Board Board { get; set; }

        public void PlayRound(string symbol, int x, int y)
        {
            if (symbol == "X" && LastSymbolPlayed == String.Empty)
            {
                LastSymbolPlayed = symbol;
                return;
            }

            if (LastSymbolPlayed == symbol)
            {
                throw new Exception();
            }

            throw new Exception();
        }
    }
}