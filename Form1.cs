using System;
namespace FactoryMethod
{
    public partial class Form1 : Form
    {
        int i = 0;
        List<int> u = new List<int>();
        public Form1()
        {
            InitializeComponent();
            button1.Click += this.addServant_Clikc;
            // panel1.Paint += panel1_Paint;
            btnLeft.Click += this.btnLeft_click;
            btnRight.Click += this.btnRight_click;
            btnClaw.Click += this.clawGrab;
        }
        private void addServant_Clikc(object sender, EventArgs e)
        {
            AddCharacterBox();
        }

        private void AddCharacterBox()
        {
            u.Add(1);
            u.Add(2);
            u.Add(3);
            foreach(int box in u)
            {
                PictureBox pictureBox = new PictureBox();
                Random rand = new Random();
                pictureBox.AutoSize = false;
                pictureBox.Name = box.ToString();
                pictureBox.Location = new System.Drawing.Point(rand.Next(0, this.Size.Width), rand.Next(0,this.Size.Height));
                pictureBox.Image = System.Drawing.Image.FromFile(@"img_resource/Mushashi.png");
                pictureBox.ClientSize = new System.Drawing.Size(50,50);
                pictureBox.SizeMode =PictureBoxSizeMode.StretchImage;
                pictureBox.BackColor = Color.BlueViolet;
                this.Controls.Add(pictureBox);
                orderToBack();
            }
            
        }
        private void orderToBack()
        {
            
            this.Controls.Add(horizontal);
            this.Controls.Add(verticalLine);
            this.Controls.Add(clawAnimated);
            this.Controls.Add(leftPic1);
            this.Controls.Add(leftPic2);
            this.Controls.Add(backGround);
            this.Controls.Add(BGbottom);
        }
        private void btnLeft_click(object sender, EventArgs e)
        {
            if(posX<=180)
            {
                btnLeft.Enabled = false;
            }
            else
            {
                if(btnLeft.Enabled == false)
                {
                    btnLeft.Enabled=true;
                }
                clawAnimated.Location = new Point(posX-=30,posY);
            }
        }
        private void btnRight_click(object sender, EventArgs e)
        {
            if(posX>=1440)
            {
                btnLeft.Enabled = false;
            }
            else
            {
                if(btnRight.Enabled == false)
                {
                    btnRight.Enabled=true;
                }
                clawAnimated.Location = new Point(posX+=30,posY);
            }
        }
        private void clawGrab(object sender, EventArgs e)
        {
            do
            {
                clawAnimated.ClientSize = new System.Drawing.Size(5,clawVerticalLine+=5);
            }while(clawVerticalLine <= 730);
        }
    //     private void panel1_Paint(object sender, PaintEventArgs e)
    //    {
    //            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle,
    //            Color.FromArgb(255,0,0), 2, ButtonBorderStyle.Solid, // left
    //            Color.White, 1, ButtonBorderStyle.None, // top
    //            Color.DimGray, 1, ButtonBorderStyle.None, // right
    //            Color.FromArgb(255,0,0), 2, ButtonBorderStyle.Solid);// bottom
    //    }
    }
}