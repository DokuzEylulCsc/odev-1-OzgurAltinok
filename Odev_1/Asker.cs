using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace War_simulation
{
    public abstract class Asker
    {
        private bool isAlive;
        private Takim team;
        private int health;
        private string teamName;

        private Bolge koordinat = new Bolge();

        public Asker()
        {
            this.IsAlive = true;
            this.Team = team;
            this.Health = 100;
            this.GetKoordinat = koordinat;
        }

        public Bolge GetKoordinat { get => koordinat; set => koordinat = value; }
        public bool IsAlive { get => isAlive; set => isAlive = value; }
        public Takim Team { get => team; set => team = value; }
        public int Health { get => health; set => health = value; }
        public string TeamName { get => teamName; set => teamName = value; }

        //Abstract sınıfların implementasyonları çoçuk sınıflarda gerçekleştirilmelidir.

        public abstract void HaraketEt(string direction);

        public abstract void Bekle(); // bos

        public abstract void AtesEt(int damage); 

        public abstract int DamagePossiblity();

        public abstract void Possiblity(); // yapilacak davranisin ihtimali

    }
}
