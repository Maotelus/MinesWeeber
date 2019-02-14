using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesWeeber
{
    class SpielFeld
    {
        private Feld[,] _spielfeld;
        private int _amountOfMines;
        private int _height;
        private int _width;


        public SpielFeld(int h, int w, int mines)
        {
            this._height = h;
            this._width = w;
            this._amountOfMines = mines;

            Feld[,] spielfeld = new Feld[h,w]; 

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; i < w; j++)
                {
                    spielfeld[i,j] = new Feld(i,j);
                }
            }

            this._spielfeld = spielfeld;
        }


        public void PlaceMines()
        {
            Random ran = new Random();
            int MinesToBePlaced = this._amountOfMines;

            while (_amountOfMines > 0)
            {
                int h = ran.Next(0, this._height);
                int w = ran.Next(0, this._width);

                if (!this._spielfeld[h, w].Mine)
                {
                    this._spielfeld[h, w].Mine = true;
                }
            }
        }

        
    }
}
