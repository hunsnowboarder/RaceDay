using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace RaceDay
{
    class Rabbit
    {
        public int startingPosition;
        public int raceTrackLength = 815; // vagy 780
        public PictureBox myPictureBox = null;
        public int location = 0;
        public Random randomizer = new Random();
        public string Name;

        //randomizer = new Random();
        
        
        public bool Run()
        {
           
            
            
            location += randomizer.Next(1, 4);
            Point p = myPictureBox.Location;
            p.X += location;
            myPictureBox.Location = p;
            //MessageBox.Show("Location is now: " + location);
 
            
            
            
            


            if (Convert.ToInt32(p.X) >= raceTrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
        
        public void TakeStartingPosition()
        {
            

            // kitölteni
        }
    
    }


}
