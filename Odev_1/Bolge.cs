using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace War_simulation
{
    public class Bolge
    {
        private int coordinateX = new int();
        private int coordinateY = new int();

        public Bolge()
        {
            this.CoordinateX = coordinateX;
            this.CoordinateY = coordinateY;
        }

        public int CoordinateX { get => coordinateX; set => coordinateX = value; }
        public int CoordinateY { get => coordinateY; set => coordinateY = value; }
    }
}
