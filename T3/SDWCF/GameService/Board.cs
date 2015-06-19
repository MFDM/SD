using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameService
{
    public class Board
    {
        public Cell[][] _celsContainer;
        public Board(int x, int y)
        {
            _celsContainer = new Cell[x][];
            FillBoard(x,y);
            SetTreasure(x,y);
        }

        private void SetTreasure(int x, int y)
        {
            int tx = new Random().Next(0, x);
            int ty = new Random().Next(0, y);
            _celsContainer[tx][ty].SetTreasure();
        }

        private void FillBoard(int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                _celsContainer[i] = new Cell [y];
                for (int j = 0; j < y; j++)
                {
                    _celsContainer[i][j] = new Cell();
                }
            }
        }
    }
}