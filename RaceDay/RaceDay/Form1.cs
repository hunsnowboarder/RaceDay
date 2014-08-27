using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RaceDay
{
    public partial class Form1 : Form
    {

        Rabbit[] rabbit = new Rabbit[4];
        

        
            
            
            
            
        
        public Form1()
        {
            InitializeComponent();
        }

        public void btnRace_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(pictureBox1.Size.Height.ToString());

            rabbit[0] = new Rabbit
            {
                Name = "Rabbit1",
                myPictureBox = pbRabbit1,
                

            };

            rabbit[1] = new Rabbit
            {
                Name = "Rabbit2",
                myPictureBox = pbRabbit2,
                

            };

            rabbit[2] = new Rabbit
            {
                Name = "Rabbit3",
                myPictureBox = pbRabbit3,
                

            };

            rabbit[3] = new Rabbit
            {
                Name = "Rabbit4",
                myPictureBox = pbRabbit4,
                

            };


            rabbit[0].myPictureBox.Location = new Point(35, 15);
            rabbit[1].myPictureBox.Location = new Point(35, 58);
            rabbit[2].myPictureBox.Location = new Point(35, 108);
            rabbit[3].myPictureBox.Location = new Point(35, 148);

            timer1.Enabled = true;
            timer1.Start();


            //bool weHaveAWinner = false;
            
            //while (!weHaveAWinner)
            //{
            //    foreach (Rabbit i in rabbitArray)
            //    {
                    
            //        if (i.Run())
            //        {
            //            weHaveAWinner = true;
            //            MessageBox.Show("Rabbit " + i.Name + " wins");
                       
            //            break;
            //        }
            //    }
            //}
            
            
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            
            
            
                for (int i = 0; i < rabbit.Length;i++ )
                {

                    if (rabbit[i].Run())
                    {
                        timer1.Stop();
                        MessageBox.Show("Rabbit " + rabbit[i].Name + " is the winner!");
                        break;
                    }
                    
                }
            
        }

        

        
    }
}
