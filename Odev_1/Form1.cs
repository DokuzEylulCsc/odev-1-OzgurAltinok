using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace War_simulation
{
    public partial class Form1 : Form
    {
        WarStarter w = new WarStarter();

        public int boxSize;

        public Form1()
        {
            InitializeComponent();

            this.boxSize = panel1.Width / 16; // panel width / 16 pieces         

            w.teamOne.AssignToTeams(w.teamOne.PlacedList, "team1");
            w.teamTwo.AssignToTeams(w.teamTwo.PlacedList, "team2");

            w.listAll.AddRange(w.teamOne.PlacedList);
            w.listAll.AddRange(w.teamTwo.PlacedList); // to start with whole askers
            
        }

        public void SetBolgesPositions() // assign box coordinates
        {
            for (int i = 0; i < 16; i++)
                for (int j = 0; j < 16; j++)
                {
                    w.warMap.GetBolges[i, j].CoordinateX = i * boxSize;
                    w.warMap.GetBolges[i, j].CoordinateY = j * boxSize;
                }
        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {

            SetBolgesPositions();
            Graphics graphics = e.Graphics;

            Pen pen = new Pen(Color.Black);
            pen.Width = 3.33F;

            for (int i = 0; i <= 16; i++) // 16 x 16 boxes
            {
                graphics.DrawLine(pen, 0, i * boxSize, panel1.Width, i * boxSize);
                graphics.DrawLine(pen, i * boxSize, 0, i * boxSize, panel1.Height);
            }

            pen.Color = Color.Red;
            pen.Width = 5;

            Font drawFont = new Font("Comic Sans MS", 18);
            SolidBrush drawBrush = new SolidBrush(Color.Red);

            for (int i = 0; i < w.teamOne.PlacedList.Count; i++)
            {
                if (w.teamOne.PlacedList.ElementAt(i) is Er) // if is Er write "E"
                {
                    graphics.DrawString("E", drawFont, drawBrush, w.teamOne.PlacedList.ElementAt(i).GetKoordinat.CoordinateX, w.teamOne.PlacedList.ElementAt(i).GetKoordinat.CoordinateY);
                }
                else if (w.teamOne.PlacedList.ElementAt(i) is Tegmen) // if is Er write "T"
                {
                    graphics.DrawString("T", drawFont, drawBrush, w.teamOne.PlacedList.ElementAt(i).GetKoordinat.CoordinateX, w.teamOne.PlacedList.ElementAt(i).GetKoordinat.CoordinateY);
                }
                else if (w.teamOne.PlacedList.ElementAt(i) is Yuzbasi) // if is Er write "Y"
                {
                    graphics.DrawString("Y", drawFont, drawBrush, w.teamOne.PlacedList.ElementAt(i).GetKoordinat.CoordinateX, w.teamOne.PlacedList.ElementAt(i).GetKoordinat.CoordinateY);
                }
            }

            drawBrush.Color = Color.Blue;

            for (int i = 0; i < w.teamTwo.PlacedList.Count; i++)
            {
                if (w.teamTwo.PlacedList.ElementAt(i) is Er) // if is Er write "E"
                {
                    graphics.DrawString("E", drawFont, drawBrush, w.teamTwo.PlacedList.ElementAt(i).GetKoordinat.CoordinateX, w.teamTwo.PlacedList.ElementAt(i).GetKoordinat.CoordinateY);
                }
                else if (w.teamTwo.PlacedList.ElementAt(i) is Tegmen) // if is Er write "T"
                {
                    graphics.DrawString("T", drawFont, drawBrush, w.teamTwo.PlacedList.ElementAt(i).GetKoordinat.CoordinateX, w.teamTwo.PlacedList.ElementAt(i).GetKoordinat.CoordinateY);
                }
                else if (w.teamTwo.PlacedList.ElementAt(i) is Yuzbasi) // if is Er write "Y"
                {
                    graphics.DrawString("Y", drawFont, drawBrush, w.teamTwo.PlacedList.ElementAt(i).GetKoordinat.CoordinateX, w.teamTwo.PlacedList.ElementAt(i).GetKoordinat.CoordinateY);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < w.listAll.Count; i++)
            {
                if (i % 2 == 0)
                    w.listAll.First().Possiblity();
                else
                    w.listAll.Last().Possiblity();
            }
            panel1.Refresh();
        }

    }
}
