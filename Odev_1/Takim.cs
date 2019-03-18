using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace War_simulation
{
    public class Takim
    {
        private Asker[] birlik = new Asker[7];
        private List<Asker> placedList = new List<Asker>(); //asker list
        public int tegmenCount;
        public int yuzbasiCount;
        public int erCount;

        public Takim(int placeScale, int placeScale2)
        {
            Random r = new Random();

            this.yuzbasiCount = 1; // 1 Yuzbasi
            this.tegmenCount = r.Next(1, 3); // 2 or 3 Tegmen
            if (tegmenCount == 2) // 4 or 5 Er
                this.erCount = 4;
            else if (tegmenCount == 1)
                this.erCount = 5;

            this.placedList.Add(new Yuzbasi());
            int counterTegmen = this.tegmenCount;
            while (counterTegmen > 0)
            {
                this.placedList.Add(new Tegmen());
                counterTegmen--;
            }

            int counterEr = this.erCount;

            while (counterEr > 0)
            {
                this.placedList.Add(new Er());
                counterEr--;
            }

            this.AssignPlace(this.placedList, placeScale, placeScale2);
        }

        internal List<Asker> PlacedList { get => placedList; set => placedList = value; }

        internal void AssignPlace(List<Asker> askers, int scale, int scale2) // assign place of askers
        {
            Random newOne = new Random();

            List<int> uniqueNumbers = new List<int>();
            int randomUnique = newOne.Next(scale, scale2);
            int randomUnique2 = newOne.Next(scale, scale2);

            for (int i = 0; i < askers.Count; i++)
            {
                do
                {
                    randomUnique = newOne.Next(scale, scale2);
                    randomUnique2 = newOne.Next(scale, scale2);
                } while (uniqueNumbers.Contains(randomUnique) && uniqueNumbers.Contains(randomUnique2)); // generate unique numbers

                askers.ElementAt(i).GetKoordinat.CoordinateX = randomUnique * 500 / 16;
                askers.ElementAt(i).GetKoordinat.CoordinateY = randomUnique2 * 500 / 16;

            }
        }

        internal void AssignToTeams(List<Asker> askers, string nameOfTeam) // Name of team
        {
            for (int i = 0; i < askers.Count; i++)
            {
                askers.ElementAt(i).TeamName = nameOfTeam;
            }
        }
    }
}
