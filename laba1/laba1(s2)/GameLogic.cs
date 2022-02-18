using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1_s2_
{
    public class GameLogic
    {
        public string CurrentPlayer { get; set; } = X;
        private const string X = "X";
        private const string O = "O";
        private string[,] Board = new string[5, 5];

        public void SetNextPlayer()
        {
            if (CurrentPlayer == X)
            {
                CurrentPlayer = O;
            }
            else
            {
                CurrentPlayer = X;
            }
        }
        public bool PlayerWin()
        {
            for (var i = 0; i < 5; i++)
            {
                if (!String.IsNullOrWhiteSpace(Board[i, 0]))
                {
                    if (Board[i,0] == Board[i,1] && Board[i,0] == Board[i,2] && Board[i, 0] == Board[i, 3] && Board[i, 0] == Board[i, 4])
                    {
                        return true;
                    }
                }
            }

            for (var i = 0; i < 5; i++)
            {
                if (!String.IsNullOrWhiteSpace(Board[0, i]))
                {
                    if (Board[0, i] == Board[1, i] && Board[0, i] == Board[2, i] && Board[0, i] == Board[3, i] && Board[0, i] == Board[4, i])
                    {
                        return true;
                    }
                }
            }

            if (!String.IsNullOrWhiteSpace(Board[2, 2]))
            {
                if (Board[0, 0] == Board[1, 1] && Board[0, 0] == Board[2, 2] && Board[0, 0] == Board[3, 3] && Board[0, 0] == Board[4, 4])
                {
                    return true;
                }

                if (Board[4, 0] == Board[3, 1] && Board[4, 0] == Board[2, 2] && Board[4, 0] == Board[1, 3] && Board[4, 0] == Board[0, 4])
                {
                    return true;
                }
            }

            return false;
        }
        internal void UpdateBoard(Posssition postion, string value)
        {
            Board[postion.x, postion.y] = value;
        }
    }
}
