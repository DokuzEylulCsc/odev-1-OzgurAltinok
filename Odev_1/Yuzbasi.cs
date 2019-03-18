using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace War_simulation
{
    public class Yuzbasi : Asker
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
            //////////
            else if (direction == "southwest") // guneybatiya
            {
                if (this.GetKoordinat.CoordinateY + (500 / 16) > 500)
                {
                    this.GetKoordinat.CoordinateX -= 500 / 16;
                }
                else
                    this.GetKoordinat.CoordinateY += 500 / 16;
            }
            else if (direction == "southeast") // guneydoguya
            {
                if (this.GetKoordinat.CoordinateY - (500 / 16) < 0)
                {
                    this.GetKoordinat.CoordinateX += 500 / 16;
                }
                else
                    this.GetKoordinat.CoordinateY -= 500 / 16;
            }
            else if (direction == "northwest") // kuzeybatiya
            {
                if (this.GetKoordinat.CoordinateX - (500 / 16) < 0)
                {
                    this.GetKoordinat.CoordinateY += 500 / 16;
                }
                else
                    this.GetKoordinat.CoordinateX -= 500 / 16;
            }
            else if (direction == "northeast") // kuzeydoguya
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

            if (generated <= 0.3)
            {
                damage = 15;
            }
            else if (generated > 0.3 && generated <= 0.49)
            {
                damage = 25;
            }
            else if (generated > 0.49 && generated <= 1)
            {
                damage = 40;
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
            else if (generated > 0.1 && generated <= 0.15)
            {
                this.HaraketEt("north");
            }
            else if (generated > 0.15 && generated <= 0.23)
            {
                this.HaraketEt("west");
                this.AtesEt(this.DamagePossiblity());
            }
            else if (generated > 0.23 && generated <= 0.33)
            {
                this.HaraketEt("east");
            }
            else if (generated > 0.33 && generated <= 0.45)
            {
                this.HaraketEt("southwest");
            }
            else if (generated > 0.45 && generated <= 0.56)
            {
                this.HaraketEt("northeast");
            }
            else if (generated > 0.56 && generated <= 0.65)
            {
                this.HaraketEt("southeast");
                this.AtesEt(this.DamagePossiblity());
            }
            else if (generated > 0.65 && generated <= 0.75)
            {
                this.HaraketEt("northwest");
            }
            else if (generated > 0.75 && generated <= 1)
            {
                this.AtesEt(this.DamagePossiblity());
            }
        }
    }
}
