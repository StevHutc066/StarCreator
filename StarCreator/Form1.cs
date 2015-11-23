using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace StarCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void StarField(int stars)
        {
            //creates a counter to track how many stars have been drawn
            int counter = 0;

            //loop to draw all the stars on-screen
            while (counter < stars)
            {
                //creates a randum number generator
                Random randNum = new Random();

                //creates random colour values
                int red = randNum.Next(0, 225);
                int green = randNum.Next(0, 225);
                int blue = randNum.Next(0, 225);

                //creates random size values
                int size = randNum.Next(0, 50);
                int thickness = randNum.Next(0, 40);

                //initialization
                int x = randNum.Next(0, (this.Width));
                int y = randNum.Next(0, (this.Height));
                int z;
                //draw shapes
                Graphics g = this.CreateGraphics();
                SolidBrush blueBrush = new SolidBrush(Color.FromArgb(255, red, green, blue));
                g.FillRectangle(blueBrush, x, y, size, size);
                counter++;

                //wait time
                Thread.Sleep(100);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StarField(100);
        }
    }
}
