using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace War_simulation
{
    public class Tegmen : Asker
    {
        // ..... //

        public override void HaraketEt(string direction)
        {
            if (direction == "south") // guneye
            {
                if (this.GetKoordinat.CoordinateY + (500 / 16) > 500)
                {
                    this.GetKoordinat.CoordinateX -= 500 / 16;
                }
                else
                    this.GetKoordinat.CoordinateY += 500 / 16;
            }
            else if (direction == "north") // kuzeye
            {
                if (this.GetKoordinat.CoordinateY - (500 / 16) < 0)
                {
                    this.GetKoordinat.CoordinateX += 500 / 16;
                }
                else
                    this.GetKoordinat.CoordinateY -= 500 / 16;
            }
            else if (direction == "west") // batiya
            {
                if (this.GetKoordinat.CoordinateX - (500 / 16) < 0)
                {
                    this.GetKoordinat.CoordinateY += 500 / 16;
                }
                else
                    this.GetKoordinat.CoordinateX -= 500 / 16;
            }
            else if (direction == "east") // doguya
            {
                if (this.GetKoordinat.CoordinateX + (500 / 16) > 500)
                {
                    this.GetKoordinat.CoordinateY -= 500 / 16;
                }
                else
                    this.GetKoordinat.CoordinateX += 500 / 16;
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

            if (generated <= 0.25)
            {
                damage = 10;
            }
            else if (generated > 0.25 && generated <= 0.9)
            {
                damage = 20;
            }
            else if (generated > 0.9 && generated <= 1)
            {
                damage = 25;
            }

            return damage;
        }

        public override void Possiblity() // yapilacak davranisin ihtimali
        {
            Random randomNum = new Random();
            double generated = randomNum.NextDouble();

            if (generated <= 0.18)
            {
                this.HaraketEt("south");
            }
            else if (generated > 0.18 && generated <= 0.34)
            {
                this.HaraketEt("north");
            }
            else if (generated > 0.34 && generated <= 0.51)
            {
                this.HaraketEt("west");
                this.AtesEt(this.DamagePossiblity());
            }
            else if (generated > 0.51 && generated <= 0.88)
            {
                this.HaraketEt("east");
            }
            else if (generated > 0.88 && generated <= 1)
            {
                this.AtesEt(this.DamagePossiblity());
            }
        }
    }
}
