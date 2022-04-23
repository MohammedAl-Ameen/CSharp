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



namespace Lab07
{

    public partial class Form1 : Form

    {

      
        int side;
        bool flag = false, fireFlag = false, rock0flag = false, rock1flag = false, rock2flag = false, rock3flag = false, rock4flag = false;
        Random rand = new Random();
        private int lives = 5;
        int seconds = 0;
       
        public Form1()
        {

            MessageBox.Show("Rules\nYou can Fire to destroy the stones by pressing SPACE\nYou will win if you survived 2 minutes");
            InitializeComponent();
            load();
         
            

            
        }




    
   

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (collusionrocket())
            {
                if (lives == 1)
                {

                    MessageBox.Show($"GameOver!");
                    System.Windows.Forms.Application.ExitThread();


                }

                lives--;
               
                rocket.Image = Lab07.Properties.Resources.Explosion;
                timer2.Interval = 1200;
                timer2.Start();
                flag = true;
                MessageBox.Show($"Your have: {lives} left, be carefull");

               
               
               
                

            }

            switch (e.KeyCode)
            {
                case Keys.Right:
                    if (collusionborders(rocket) & (side == 0))
                    {
                        flag = false;
                        break;
                    }
                    else
                    {
                        rocket.Location = new Point(rocket.Location.X + 5, rocket.Location.Y);
                        break;
                    }
                case Keys.Left:
                    if (collusionborders(rocket) & (side == 1))
                    {
                        
                        break;

                    }
                    else
                    {
                        rocket.Location = new Point(rocket.Location.X - 5, rocket.Location.Y);
                        break;
                    }
                case Keys.Up:
                    if (collusionborders(rocket) & (side == 3))
                    {
                       
                        break;

                    }
                    else
                    {
                        rocket.Location = new Point(rocket.Location.X, rocket.Location.Y - 5);
                        break;
                    }
                case Keys.Down:
                    if (collusionborders(rocket) & (side == 2))
                    {
                       
                        break;

                    }
                    {
                        rocket.Location = new Point(rocket.Location.X, rocket.Location.Y + 5);
                        break;
                    }
                
            
            }

            switch (e.KeyCode)
            {

                case Keys.Space:
                    fire.Location = rocket.Location;
                    fire.Visible = true;
                    fireFlag = true;

                    break;


            }

           







        }
    


        private bool iscollusion(PictureBox item)
        {

            if (item.Location == rock0.Location)
            {
                if (item.Bounds.IntersectsWith(rock1.Bounds) || item.Bounds.IntersectsWith(rock2.Bounds) || item.Bounds.IntersectsWith(rock3.Bounds) || item.Bounds.IntersectsWith(rock4.Bounds) || item.Bounds.IntersectsWith(rocket.Bounds))
                {
                    return true;
                }
                else
                {
                    return false;
                }

                

            }else if (item.Location == rock1.Location) {

                if (item.Bounds.IntersectsWith(rock0.Bounds) || item.Bounds.IntersectsWith(rock2.Bounds) || item.Bounds.IntersectsWith(rock3.Bounds) || item.Bounds.IntersectsWith(rock4.Bounds) || item.Bounds.IntersectsWith(rocket.Bounds))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (item.Location == rock2.Location)
            {

                if (item.Bounds.IntersectsWith(rock0.Bounds) || item.Bounds.IntersectsWith(rock1.Bounds) || item.Bounds.IntersectsWith(rock3.Bounds) || item.Bounds.IntersectsWith(rock4.Bounds) || item.Bounds.IntersectsWith(rocket.Bounds))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (item.Location == rock3.Location)
            {

                if (item.Bounds.IntersectsWith(rock0.Bounds) || item.Bounds.IntersectsWith(rock2.Bounds) || item.Bounds.IntersectsWith(rock1.Bounds) || item.Bounds.IntersectsWith(rock4.Bounds) || item.Bounds.IntersectsWith(rocket.Bounds))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (item.Location == rock4.Location)
            {

                if (item.Bounds.IntersectsWith(rock0.Bounds) || item.Bounds.IntersectsWith(rock1.Bounds) || item.Bounds.IntersectsWith(rock2.Bounds) || item.Bounds.IntersectsWith(rock3.Bounds) || item.Bounds.IntersectsWith(rocket.Bounds))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
          
            else
            {

                return false;
            }

        }

        private PictureBox create(PictureBox iteam) {

          
            int radnomx = rand.Next(0, this.ClientRectangle.Width - rock0.ClientRectangle.Width);
            int radnomy = rand.Next(0, this.ClientRectangle.Height - rock0.ClientRectangle.Height);
           
            iteam.Location = new Point(radnomx, radnomy);
            iteam.Visible = true;

            return iteam;

        }

        private void load() {

           

            rock0 = create(rock0);
            rock1 = create(rock1);
            rock2 = create(rock2);
            rock3 = create(rock3);
            rock4 = create(rock4);

            while (flag)
            {




                if (iscollusion(rock0))
                {

                    rock0 = create(rock0);

                }
                else if (iscollusion(rock1))
                {

                    rock1 = create(rock1);

                }
                else if (iscollusion(rock2))
                {

                    rock2 = create(rock2);

                }
                else if (iscollusion(rock3))
                {
                    rock3 = create(rock3);

                }
                else if (iscollusion(rock4))
                {

                    rock4 = create(rock4);
                }
                else
                {
                    flag = false;
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            move(rock0);
            move(rock1);
            move(rock2);
            move(rock3);
            move(rock4);

            if (fireFlag)
            {

                fire.Location = new Point(fire.Location.X, fire.Location.Y - 20);

            }
            if ((fire.Location.Y + 20) < 0)
            {
                fire.Visible = false;
                fire = create(fire);
                fire.Visible = false;
                fireFlag = false;

            }
            Explosion();

            seconds++;
            lblView.Text = TimeSpan.FromSeconds(seconds).ToString("mm\\:ss");
            if(seconds == 120)
            {

                MessageBox.Show("You have one the game");
                System.Windows.Forms.Application.ExitThread();
            }


        }


       private void move(PictureBox iteam) {

            Random rand = new Random();
            int random = rand.Next(0, 4);


            if (collusionborders(iteam) & (side == 0))
            {
                iteam.Location = new Point(iteam.Location.X - 20, iteam.Location.Y);


            } 
            else if (collusionborders(iteam) & (side == 1))
            {
                iteam.Location = new Point(iteam.Location.X + 20, iteam.Location.Y);


            }
            else if (collusionborders(iteam) & (side == 3))
            {
                iteam.Location = new Point(iteam.Location.X, iteam.Location.Y + 20);


            }
            else if (collusionborders(iteam) & (side == 2))
            {
                iteam.Location = new Point(iteam.Location.X, iteam.Location.Y - 20);


            }

            switch (random)
            {

                case 0:
                    iteam.Location = new Point(iteam.Location.X + 10, iteam.Location.Y); //move to the right on the x-aixes
                    if (iscollusion(iteam)) {
                        iteam.Location = new Point(iteam.Location.X - 30, iteam.Location.Y); //move to the left on the x-aixes
                    }
                    
                    break;
                case 1:
                    iteam.Location = new Point(iteam.Location.X - 10, iteam.Location.Y); //move to the left on the x-aixes
                    if (iscollusion(iteam))
                    {
                        iteam.Location = new Point(iteam.Location.X + 30, iteam.Location.Y); //move to the right on the x-aixes
                    }
                    break;
                case 2:
                    iteam.Location = new Point(iteam.Location.X, iteam.Location.Y + 10); //move to the down on the y-aixes
                    if (iscollusion(iteam))
                    {
                        iteam.Location = new Point(iteam.Location.X , iteam.Location.Y - 30); //move to the up on the y-aixes
                    }
                    break;
                case 3:
                    iteam.Location = new Point(iteam.Location.X , iteam.Location.Y -10); //move to the up on the y-aixes
                    if (iscollusion(iteam))
                    {
                        iteam.Location = new Point(iteam.Location.X, iteam.Location.Y + 30); //move to the down on the y-aixes
                    }
                    break;

                   


            }

           







        }
       private bool collusionborders(PictureBox item)
        {
            
            if ((item.Location.X + item.Width) > this.ClientRectangle.Width)  { side = 0;  return true; }
            else if (item.Location.X < 0 ) { side = 1; return true; }
            else if (item.Location.Y + item.Height > this.ClientRectangle.Height) { side = 2; return true;  }
            else if (item.Location.Y < 0) { side = 3;  return true;  } 
            { return false; }
          
        }

        private bool collusionrocket() {

            if (rocket.Bounds.IntersectsWith(rock0.Bounds) || rocket.Bounds.IntersectsWith(rock1.Bounds) || rocket.Bounds.IntersectsWith(rock2.Bounds) || rocket.Bounds.IntersectsWith(rock3.Bounds) || rocket.Bounds.IntersectsWith(rock4.Bounds))
            {
                return true;
            }
            else
            {
                return false;
            }

           
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                rocket.Visible = false;
                rocket.Image = Lab07.Properties.Resources.rocket2;
                timer2.Stop();
                rocket = create(rocket);
                flag = false;
               
            }
            else if (rock0flag)
            {
                rock0flag = false;
                rock0.Image = Lab07.Properties.Resources.stone;
                timer2.Stop();
                rock0 = create(rock0);

            }
            else if (rock1flag)
            {
                rock1flag = false;
                rock1.Image = Lab07.Properties.Resources.stone;
                timer2.Stop();
                rock1 = create(rock1);

            }
            else if (rock2flag)
            {
                rock2flag = false;
                rock2.Image = Lab07.Properties.Resources.stone;
                timer2.Stop();
                rock2 = create(rock2);
            }
            else if (rock3flag)
            {
                rock3flag = false;
                rock3.Image = Lab07.Properties.Resources.stone;
                timer2.Stop();
                rock3 = create(rock3);
            }
            else if (rock4flag)
            {
                rock4flag = false;
                rock4.Image = Lab07.Properties.Resources.stone;
                timer2.Stop();
                rock4 = create(rock4);
            }
        }

        private void Explosion() {

         


            
            if (fire.Bounds.IntersectsWith(rock0.Bounds))
            {

                rock0.Image = Lab07.Properties.Resources.Explosion;
                timer2.Interval = 1200;
                timer2.Start();
                rock0flag = true;


            }
            else if (fire.Bounds.IntersectsWith(rock1.Bounds))
                {

                    rock1.Image = Lab07.Properties.Resources.Explosion;
                    timer2.Interval = 1200;
                    timer2.Start();
                    rock1flag = true;


                }
            else if (fire.Bounds.IntersectsWith(rock2.Bounds))
            {

                rock2.Image = Lab07.Properties.Resources.Explosion;
                timer2.Interval = 1200;
                timer2.Start();
                rock2flag = true;


            }
            else if (fire.Bounds.IntersectsWith(rock3.Bounds))
            {

                rock3.Image = Lab07.Properties.Resources.Explosion;
                timer2.Interval = 1200;
                timer2.Start();
                rock3flag = true;


            }
            else if (fire.Bounds.IntersectsWith(rock4.Bounds))
            {

                rock4.Image = Lab07.Properties.Resources.Explosion;
                timer2.Interval = 1200;
                timer2.Start();
                rock4flag = true;


            }
        }
        
        
        }



    }

