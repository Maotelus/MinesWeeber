using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesWeeber
{
    class SpielFeld
    {
        private bool[,] _spielfeld;
        private int _amountOfMines;
        private int _height;
        private int _width;


        public SpielFeld(int h, int w, int mines)
        {
            this._height = h;
            this._width = w;
            this._spielfeld = new bool[this._height, this._width];
            this._amountOfMines = mines;
        }


        public void PlaceMines()
        {
            Random ran = new Random();
            int MinesToBePlaced = this._amountOfMines;

            while (_amountOfMines > 0)
            {
                int h = ran.Next(0, this._height);
                int w = ran.Next(0, this._width);

                if (!this._spielfeld[h, w])
                {
                    this._spielfeld[h, w] = true;
                }
            }
        }

        public bool CheckField(int h, int w)
        {
            return this._spielfeld[h, w];
        }
    }
}
