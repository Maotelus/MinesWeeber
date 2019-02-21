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

        public int Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
            }
        }

        public SpielFeld(int h, int w, int mines)
        {
            this._height = h;
            this._width = w;
            this._amountOfMines = mines;

            Feld[,] spielfeld = new Feld[h,w]; 

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
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

        public List<Feld> GetSurroundingFields(Feld feld)
        {


            int xMax = feld.X + 1;
            int yMax = feld.Y + 1;
            int xMin =  feld.X - 1;
            int yMin = feld.Y - 1;

            List<Feld> surroundings = new List<Feld>();

            if (yMax >= this._height)
            {
                yMax--;
            }
            if (xMax >= this._width)
            {
                yMax--;
            }
            if (yMin < 0)
            {
                yMin = 0;
            }
            if (xMin < 0)
            {
                xMin = 0;
            }

            for (int i = yMin; i < yMax; i++)
            {
                for (int j = xMin; i < xMax; j++)
                {
                    surroundings.Add(this._spielfeld[i, j]);
                }

            }

            

            return surroundings;

        }

        public int GetNumberOfMines(Feld feld)
        {
            List<Feld> sur = GetSurroundingFields(feld);
            int numMines = 0;

            foreach (Feld element in sur)
            {
                if (element.Mine)
                {
                    numMines++;
                }
            }

            return numMines;
        }

        public void FelderAufdecken(Feld feld)
        {
            //ToDo
        }

        
    }
}
