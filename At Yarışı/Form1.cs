using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarışı
{
    
    public partial class Form1 : Form
    {
        Point horse1Loc,horse2Loc,horse3Loc,horse4Loc,horse5Loc;
        int speed1, speed2, speed3, speed4, speed5;
        Random rnd = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            int horseNumber = Convert.ToInt32(horseNum.Value);

            switch (horseNumber)
            {
                case 2:
                    horse1.Left += speed1;
                    horse2.Left += speed2;
                    if (horse1.Location.X + horse1.Width >= finishLine.Location.X)
                    {
                        scoreBoard.Text = "Score Tablosu\r\n1 numaralı at: 50\r\n2 numaralı at: 40";
                        timer1.Stop();

                    }
                    if (horse2.Location.X + horse2.Width >= finishLine.Location.X)
                    {
                        scoreBoard.Text = "Score Tablosu\r\n2 numaralı at: 50 \r\n1 numaralı at: 40";
                        timer1.Stop();
                    }
                    break;
                case 3:
                    horse1.Left += speed1;
                    horse2.Left += speed2;
                    horse3.Left += speed3;
                    if (horse1.Location.X + horse1.Width >= finishLine.Location.X)
                    {
                        if (horse2.Location.X > horse3.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n1 numaralı at: 50 \r\n2 numaralı at: 40"; timer1.Stop(); }
                        else
                        { scoreBoard.Text = "Score Tablosu\r\n1 numaralı at: 50 \r\n3 numaralı at: 40"; timer1.Stop(); }
                        

                    }
                    if (horse2.Location.X + horse2.Width >= finishLine.Location.X)
                    {
                        if (horse1.Location.X > horse3.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n2 numaralı at: 50 \r\n1 numaralı at: 40"; timer1.Stop(); }
                        else
                        { scoreBoard.Text = "Score Tablosu\r\n2 numaralı at: 50 \r\n3 numaralı at: 40"; timer1.Stop(); }
                    }
                    if (horse3.Location.X + horse3.Width >= finishLine.Location.X)
                    {
                        if (horse2.Location.X > horse1.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n3 numaralı at: 50 \r\n2 numaralı at: 40"; timer1.Stop(); }
                        else
                        { scoreBoard.Text = "Score Tablosu\r\n3 numaralı at: 50 \r\n1 numaralı at: 40"; timer1.Stop(); }
                    }
                    break;
                case 4:
                    horse1.Left += speed1;
                    horse2.Left += speed2;
                    horse3.Left += speed3;
                    horse4.Left += speed4;
                    if (horse1.Location.X + horse1.Width >= finishLine.Location.X)
                    {
                        if (horse2.Location.X > horse3.Location.X && horse2.Location.X > horse4.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n1 numaralı at: 50 \r\n2 numaralı at: 40"; timer1.Stop(); }
                        else if(horse3.Location.X > horse2.Location.X && horse3.Location.X > horse4.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n1 numaralı at: 50 \r\n3 numaralı at: 40"; timer1.Stop(); }
                        else if(horse4.Location.X > horse3.Location.X && horse4.Location.X > horse2.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n1 numaralı at: 50 \r\n4 numaralı at: 40"; timer1.Stop(); }

                    }
                    if (horse2.Location.X + horse2.Width >= finishLine.Location.X)
                    {
                        if (horse1.Location.X > horse3.Location.X && horse1.Location.X > horse4.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n2 numaralı at: 50 \r\n1 numaralı at: 40"; timer1.Stop(); }
                        else if (horse3.Location.X > horse1.Location.X && horse3.Location.X > horse4.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n2 numaralı at: 50 \r\n3 numaralı at: 40"; timer1.Stop(); }
                        else if (horse4.Location.X > horse3.Location.X && horse4.Location.X > horse1.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n2 numaralı at: 50 \r\n4 numaralı at: 40"; timer1.Stop(); }
                    }
                    if (horse3.Location.X + horse3.Width >= finishLine.Location.X)
                    {
                        if (horse1.Location.X > horse2.Location.X && horse1.Location.X > horse4.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n3 numaralı at: 50 \r\n1 numaralı at: 40"; timer1.Stop(); }
                        else if (horse2.Location.X > horse1.Location.X && horse2.Location.X > horse4.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n3 numaralı at: 50 \r\n2 numaralı at: 40"; timer1.Stop(); }
                        else if (horse4.Location.X > horse1.Location.X && horse4.Location.X > horse2.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n3 numaralı at: 50 \r\n4 numaralı at: 40"; timer1.Stop(); }
                    }
                    if (horse4.Location.X + horse4.Width >= finishLine.Location.X)
                    {
                        if (horse1.Location.X > horse2.Location.X && horse1.Location.X > horse3.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n4 numaralı at: 50 \r\n1 numaralı at: 40"; timer1.Stop(); }
                        else if (horse2.Location.X > horse1.Location.X && horse2.Location.X > horse3.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n4 numaralı at: 50 \r\n2 numaralı at: 40"; timer1.Stop(); }
                        else if (horse3.Location.X > horse1.Location.X && horse3.Location.X > horse2.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n4 numaralı at: 50 \r\n3 numaralı at: 40"; timer1.Stop(); }
                    }
                    break;
                case 5:
                    horse1.Left += speed1;
                    horse2.Left += speed2;
                    horse3.Left += speed3;
                    horse4.Left += speed4;
                    horse5.Left += speed5;
                    if (horse1.Location.X + horse1.Width >= finishLine.Location.X)
                    {
                        if (horse2.Location.X > horse3.Location.X && horse2.Location.X > horse4.Location.X && horse2.Location.X > horse5.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n1 numaralı at: 50 \r\n2 numaralı at: 40"; timer1.Stop(); }
                        else if (horse3.Location.X > horse2.Location.X && horse3.Location.X > horse4.Location.X && horse3.Location.X > horse5.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n1 numaralı at: 50 \r\n3 numaralı at: 40"; timer1.Stop(); }
                        else if (horse4.Location.X > horse2.Location.X && horse4.Location.X > horse3.Location.X && horse4.Location.X > horse5.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n1 numaralı at: 50 \r\n4 numaralı at: 40"; timer1.Stop(); }
                        else if (horse5.Location.X > horse2.Location.X && horse5.Location.X > horse3.Location.X && horse5.Location.X > horse4.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n1 numaralı at: 50 \r\n4 numaralı at: 40"; timer1.Stop(); }

                    }
                    if (horse2.Location.X + horse2.Width >= finishLine.Location.X)
                    {
                        if (horse1.Location.X > horse3.Location.X && horse1.Location.X > horse4.Location.X && horse1.Location.X > horse5.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n2 numaralı at: 50 \r\n1 numaralı at: 40"; timer1.Stop(); }
                        else if (horse3.Location.X > horse1.Location.X && horse3.Location.X > horse4.Location.X && horse3.Location.X > horse5.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n2 numaralı at: 50 \r\n3 numaralı at: 40"; timer1.Stop(); }
                        else if (horse4.Location.X > horse1.Location.X && horse4.Location.X > horse3.Location.X && horse4.Location.X > horse5.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n2 numaralı at: 50 \r\n4 numaralı at: 40"; timer1.Stop(); }
                        else if (horse5.Location.X > horse1.Location.X && horse5.Location.X > horse3.Location.X && horse5.Location.X > horse4.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n2 numaralı at: 50 \r\n5 numaralı at: 40"; timer1.Stop(); }
                    }
                    if (horse3.Location.X + horse3.Width >= finishLine.Location.X)
                    {
                        if (horse1.Location.X > horse2.Location.X && horse1.Location.X > horse4.Location.X && horse1.Location.X > horse5.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n3 numaralı at: 50 \r\n1 numaralı at: 40"; timer1.Stop(); }
                        else if (horse2.Location.X > horse1.Location.X && horse2.Location.X > horse4.Location.X && horse2.Location.X > horse5.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n3 numaralı at: 50 \r\n2 numaralı at: 40"; timer1.Stop(); }
                        else if (horse4.Location.X > horse1.Location.X && horse4.Location.X > horse2.Location.X && horse4.Location.X > horse5.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n3 numaralı at: 50 \r\n4 numaralı at: 40"; timer1.Stop(); }
                        else if (horse5.Location.X > horse1.Location.X && horse5.Location.X > horse2.Location.X && horse5.Location.X > horse4.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n3 numaralı at: 50 \r\n5 numaralı at: 40"; timer1.Stop(); }
                    }
                    if (horse4.Location.X + horse4.Width >= finishLine.Location.X)
                    {
                        if (horse1.Location.X > horse2.Location.X && horse1.Location.X > horse3.Location.X && horse1.Location.X > horse5.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n4 numaralı at: 50 \r\n1 numaralı at: 40"; timer1.Stop(); }
                        else if (horse2.Location.X > horse1.Location.X && horse2.Location.X > horse3.Location.X && horse2.Location.X > horse5.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n4 numaralı at: 50 \r\n2 numaralı at: 40"; timer1.Stop(); }
                        else if (horse3.Location.X > horse1.Location.X && horse3.Location.X > horse2.Location.X && horse3.Location.X > horse5.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n4 numaralı at: 50 \r\n3 numaralı at: 40"; timer1.Stop(); }
                        else if (horse5.Location.X > horse1.Location.X && horse5.Location.X > horse2.Location.X && horse5.Location.X > horse3.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n4 numaralı at: 50 \r\n5 numaralı at: 40"; timer1.Stop(); }
                    }
                    if (horse5.Location.X + horse5.Width >= finishLine.Location.X)
                    {
                        if (horse1.Location.X > horse2.Location.X && horse1.Location.X > horse3.Location.X && horse1.Location.X > horse4.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n5 numaralı at: 50 \r\n1 numaralı at: 40"; timer1.Stop(); }
                        else if (horse2.Location.X > horse1.Location.X && horse2.Location.X > horse3.Location.X && horse2.Location.X > horse4.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n5 numaralı at: 50 \r\n2 numaralı at: 40"; timer1.Stop(); }
                        else if (horse3.Location.X > horse1.Location.X && horse3.Location.X > horse2.Location.X && horse3.Location.X > horse4.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n5 numaralı at: 50 \r\n3 numaralı at: 40"; timer1.Stop(); }
                        else if (horse4.Location.X > horse1.Location.X && horse4.Location.X > horse2.Location.X && horse4.Location.X > horse3.Location.X)
                        { scoreBoard.Text = "Score Tablosu\r\n5 numaralı at: 50 \r\n4 numaralı at: 40"; timer1.Stop(); }
                    }
                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            horse1.Location = horse1Loc;
            horse2.Location = horse2Loc;
            horse3.Location = horse3Loc;
            horse4.Location = horse4Loc;
            horse5.Location = horse5Loc;
            scoreBoard.Text = "" ;
            speed1 = rnd.Next(10, 40);
            speed2 = rnd.Next(10, 40);
            speed3 = rnd.Next(10, 40);
            speed4 = rnd.Next(10, 40);
            speed5 = rnd.Next(10, 40);

        }

        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void horseNum_ValueChanged(object sender, EventArgs e)
        {
            if (horseNum.Value < 2) 
            {
                horseNum.Value = 2;
            }
            else if (horseNum.Value > 5)
            {
                horseNum.Value = 5;
            }
            int horseNumber = Convert.ToInt32(horseNum.Value);
            
            switch (horseNumber)
            {
                case 2:
                    speed1 = rnd.Next(10, 40);
                    speed2 = rnd.Next(10, 40);
                    finishLine.Visible = true;
                    horse1.Visible = true;
                    horse2.Visible = true;
                    horse3.Visible = false;
                    horse4.Visible = false;
                    horse5.Visible = false; break;
                case 3:
                    speed1 = rnd.Next(10, 40);
                    speed2 = rnd.Next(10, 40);
                    speed3 = rnd.Next(10, 40);
                    finishLine.Visible = true;
                    horse1.Visible = true;
                    horse2.Visible = true;
                    horse3.Visible = true;
                    horse4.Visible = false;
                    horse5.Visible = false; break;
                case 4:
                    speed1 = rnd.Next(10, 40);
                    speed2 = rnd.Next(10, 40);
                    speed3 = rnd.Next(10, 40);
                    speed4 = rnd.Next(10, 40);
                    finishLine.Visible = true;
                    horse1.Visible = true;
                    horse2.Visible = true;
                    horse3.Visible = true;
                    horse4.Visible = true;
                    horse5.Visible = false; break;
                case 5:
                    speed1 = rnd.Next(10, 40);
                    speed2 = rnd.Next(10, 40);
                    speed3 = rnd.Next(10, 40);
                    speed4 = rnd.Next(10, 40);
                    speed5 = rnd.Next(10, 40);
                    finishLine.Visible = true;
                    horse1.Visible = true;
                    horse2.Visible = true;
                    horse3.Visible = true;
                    horse4.Visible = true;
                    horse5.Visible = true; break;
                default: break;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            horse1Loc = horse1.Location;
            horse2Loc = horse2.Location;
            horse3Loc = horse3.Location;
            horse4Loc = horse4.Location;
            horse5Loc = horse5.Location;
            speed1 = rnd.Next(10, 40);
            speed2 = rnd.Next(10, 40);
            finishLine.Visible = true;
            horse1.Visible = true;
            horse2.Visible = true;
            

        }
    }
}
