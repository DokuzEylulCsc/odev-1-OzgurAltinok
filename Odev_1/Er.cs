using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace War_simulation
{
    public class Er : Asker
    {
        // ..... //

        public override void HaraketEt(string direction)
        {
            if (direction == "south") // asagi
            {
                if (this.GetKoordinat.CoordinateY + (500 / 16) > 500)
                {
                    this.GetKoordinat.CoordinateX -= 500 / 16;
                }
                else
                    this.GetKoordinat.CoordinateY += 500 / 16;
            }
            else if (direction == "north") // yukari
            {
                if (this.GetKoordinat.CoordinateY - (500 / 16) < 0)
                {
                    this.GetKoordinat.CoordinateX += 500 / 16;
                }
                else
                    this.GetKoordinat.CoordinateY -= 500 / 16;
            }
        }
        public override void Bekle()
        {
            // bos
        }

        public override void AtesEt(int damage)
        {

        }

        public override int DamagePossiblity() // kac vuracaginin ihtimali
        {
            Random randomNum = new Random();
            double generated = randomNum.NextDouble();
            int damage = 0;

            if (generated <= 0.15)
            {
                damage = 5;
            }
            else if (generated > 0.15 && generated <= 0.4)
            {
                damage = 10;
            }
            else if (generated > 0.4 && generated <= 1)
            {
                damage = 15;
            }

            return damage;
        }

        public override void Possiblity() // yapilacak davranisin ihtimali
        {
            Random randomNum = new Random();
            double generated = randomNum.NextDouble();

            if (generated <= 0.1)
            {
                this.HaraketEt("south");
            }
            else if (generated > 0.1 && generated <= 0.3)
            {
                this.HaraketEt("north");
            }
            else if (generated > 0.3 && generated <= 0.5)
            {
                this.AtesEt(this.DamagePossiblity());
            }
            else if (generated < 3)
            {
                this.Bekle();
            }
        }
    }
}
