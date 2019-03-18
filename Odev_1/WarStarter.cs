using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace War_simulation
{
    public class WarStarter
    {
        public Ermeydani warMap = new Ermeydani();
        public Takim teamOne = new Takim(0, 9);  // karsilikli koselerde
        public Takim teamTwo = new Takim(9, 16); // baslatmak icin
        public List<Asker> listAll = new List<Asker>(); // tum askerleri bir listede tutmak icin.


        public WarStarter()
        {
            
        }
    }
}
