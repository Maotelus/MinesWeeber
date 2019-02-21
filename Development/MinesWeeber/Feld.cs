using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesWeeber
{
    class Feld
    {
        private int _x;
        private int _y;
        private bool _mine;

        public Feld(int x, int y)
        {
            this._x = x;
            this._y = y;
            this._mine = false;
        }

        public int X
        {
            get { return this._x; }
            set { this._x = value; }
        }
        public int Y
        {
            get { return this._y; }
            set { this._y = value; }
        }

        public bool Mine
        {
            get { return this._mine; }
            set { this._mine = value; }
        }
    }
}
