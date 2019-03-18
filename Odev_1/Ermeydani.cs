using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace War_simulation
{
    public class Ermeydani
    {
        private Bolge[,] bolges = new Bolge[16, 16];

        public Ermeydani()
        {            
            for (int i = 0; i < 16; i++)
                for (int j = 0; j < 16; j++)
                {
                    GetBolges[i, j] = new Bolge();
                }
        }

        public Bolge[,] GetBolges { get => bolges; set => bolges = value; }
    }
}
