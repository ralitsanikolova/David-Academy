using System;
using System.Collections.Generic;
using System.Text;

namespace Snow
{
    class Snowflake : PictureBox
    {
        public snowflake()
        {
            create();
            move();
        }

        Random r = new Random();

        private void create()
        {
            //the line below sets a random point to the newly created snowflake
            this.Location = new Point(r.Next(-Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Width), r.Next(-Screen.PrimaryScreen.Bounds.Height, Screen.PrimaryScreen.Bounds.Height));

            //here we define the picturebox's size & the image
            this.MinimumSize = new Size(7, 7);
            this.Size = new Size(10, 10);
            this.BackgroundImage = Image.FromFile("snowflake.jpg");
        }

        private void move()
        {
            //a snowflake has a timer that moves it on the screen
            Timer t = new Timer();
            t.Interval = 40;

            t.Tick += new EventHandler(t_Tick);

            t.Start();
        }

        void t_Tick(object sender, EventArgs e)
        {
            //moves the snowflake by constantly adding a values to its location
            this.Location += new Size(1, 3);

            //checking if the snowflake isn't going out of the visible area
            //if it goes out we reset its location to a random one.
            if (this.Location.X > Screen.PrimaryScreen.Bounds.Width || this.Location.Y > Screen.PrimaryScreen.Bounds.Height)
                this.Location = new Point(r.Next(-Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Width), r.Next(-Screen.PrimaryScreen.Bounds.Height, Screen.PrimaryScreen.Bounds.Height));

        }
    }
}
