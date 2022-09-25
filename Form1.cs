using System;
using System.Collections.Generic;
using System.Data.SqlClient; 

namespace FactoryMethod
{
    public partial class Form1 : Form
    {
        List<IServant> u = new List<IServant>(20);
        string connectionString = 
        "Data Source=A9JCAFENOAYCBYU;Initial Catalog=FGO;Trusted_Connection=True;";
        public Form1()
        {
            InitializeComponent();
            btnStart.Click += btnStart_Click;
            // GBOutline.Paint += GBOutline_Paint;
            btnLeft.Click += btnLeft_click;
            btnRight.Click += btnRight_click;
            btnClaw.Click += clawGrab;
        }

        /*================================*/
        /*======Main Control Start========*/
        /*================================*/

        //Start the game
        private void btnStart_Click(object sender, EventArgs e)
        {
            generateServant();
        }

        //Create Servent at random on screen
        private void generateServant()
        {
            var randItem = new Random();
            var randPos = new Random();
            var list = GetDataFromDB();
            foreach(IServant servant in list)
            {
                int index = randItem.Next(list.Count);
                PictureBox serventPic = new PictureBox();
                serventPic.AutoSize = false;
                serventPic.Location = new Point(randPos.Next(verticalLine1.Location.X + 50,verticalLine2.Location.X - 50),randPos.Next(horizontal.Location.Y - 200, horizontal.Location.Y - 50));
                serventPic.Size = new Size(50,50);
                serventPic.SizeMode = PictureBoxSizeMode.StretchImage;
                serventPic.Image = System.Drawing.Image.FromFile(@"img_resource/servant_img/"+servant.getMyImg()+".png");
                this.Controls.Add(serventPic);
                orderToBack();
            }
        }

        //Get Data From DB
        private List<IServant> GetDataFromDB()
        {
            ServantFactory factory;
            string querry = "SELECT O.servantName, O.servantType, O.servantStar, O.servantImg FROM [FGO].[dbo].[servantInfo] O;";
            List<IServant> serventData = new List<IServant>();
            try
            {
                using(SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using(SqlCommand cmd = new SqlCommand(querry, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        string name = reader.GetString(0);
                        string clss = reader.GetString(1);
                        int stars = reader.GetInt32(2);
                        string imgs = reader.GetString(3);
                        if(clss == "Saber")
                        {
                            factory = new SaberFactory();
                            factory.CreateServant(name, clss, stars, imgs);
                            serventData.Add(factory.CreateServant(name, clss, stars, imgs));
                        }
                        // if(clss == "Lancer")
                        // {
                        //     factory = new LancerFactory();
                        //     factory.CreateServant(name, clss, stars, imgs);
                        //     serventData.Add(factory.CreateServant(name, clss, stars, imgs));
                        // }
                    }
                }
            }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return serventData;
        }

        /*================================*/
        /*======Main Control End========*/
        /*================================*/
        
        /*====================================*/
        /*=======Claw Control Start===========*/
        /*====================================*/

        // Move Left
        private void btnLeft_click(object sender, EventArgs e)
        {
            if(clawVerticalLineX<=verticalLine1.Location.X)
            {
                btnLeft.Enabled = false;
            }
            else
            {
                if(btnRight.Enabled == false)
                {
                    btnRight.Enabled=true;
                }
                clawAnimated.Location = new Point(clawVerticalLineX-=30,clawVerticalLineY);
            }
        }

        // Move Right
        private void btnRight_click(object sender, EventArgs e)
        {
            if(clawVerticalLineX>=verticalLine2.Location.X)
            {
                btnRight.Enabled = false;
            }
            else
            {
                if(btnLeft.Enabled == false)
                {
                    btnLeft.Enabled=true;
                }
                clawAnimated.Location = new Point(clawVerticalLineX+=30,clawVerticalLineY);
            }
        }

        // Claw Move down to grab item up
        private void clawGrab(object sender, EventArgs e)
        {
            clawMoveDown();
            clawMoveUp();
        }
        
        //grab the servant
        private void grabServant(object sender, EventArgs e)
        {

        }
        
        //animate the claw to move up
        private void clawMoveDown()
        {
            // while(clawAnimated.Size.Height <= clawOrgSizeHeight)
        }

        //animate the claw to move down
        private void clawMoveUp()
        {

        }

        /*====================================*/
        /*========Claw Control End============*/
        /*====================================*/
        
    //     private void GBOutline_Paint(object sender, PaintEventArgs e)
    //    {
    //            ControlPaint.DrawBorder(e.Graphics, GBOutline.ClientRectangle,
    //            Color.Red, 3, ButtonBorderStyle.Solid, // left
    //            Color.Red, 3, ButtonBorderStyle.Solid, // top
    //            Color.Red, 3, ButtonBorderStyle.Solid, // right
    //            Color.Red, 3, ButtonBorderStyle.Solid);// bottom
    //    }
        
        /*====================================*/
        /*===========Utility Start============*/
        /*====================================*/

        //Reposition of each item 
        private void orderToBack()
        {
            this.Controls.Add(btnLeft);
            this.Controls.Add(btnRight);
            this.Controls.Add(btnClaw);
            this.Controls.Add(btnStart);
            this.Controls.Add(horizontal);
            this.Controls.Add(verticalLine1);
            this.Controls.Add(verticalLine2);
            this.Controls.Add(clawAnimated);
            this.Controls.Add(leftPic1);
            this.Controls.Add(leftPic2);
            this.Controls.Add(BGright);
            this.Controls.Add(backGround);
            this.Controls.Add(BGbottom);
        }

        /*====================================*/
        /*============Utility End=============*/
        /*====================================*/

        /*====================================*/
        /*===========Test code Start============*/
        /*====================================*/

        //Generate character at random 
        private void generateARandomServant()
        {
            var rand = new Random();
            var list = GetDataFromDB();
            for(int repeat = 0; repeat < list.Count; repeat++)
            {
                
                int index = rand.Next(list.Count);
                MessageBox.Show(list[index].getMyName());
            }
        }

        //Get Item that has class is saber

        // private List<Saber> OnlySaber()
        // {
        //     List<Saber> saberList = new List<Saber>();
        //     Saber mySaberList1 = new Saber("a","b",1,"c");
        //     Saber mySaberList2 = new Saber("c","a",2,"b");
        //     saberList.Add(mySaberList1); 
        //     saberList.Add(mySaberList2); 
        //     return saberList;
        // }

        //Print out the result
        private void print()
        {
            // ServantFactory factory = new LancerFactory();
            // IServant servant = factory.CreateServant("Spartan","Lancer",3,"");
            // MessageBox.Show(servant.getMyName());
            // var result = OnlySaber();
            // foreach(Saber saber in result)
            // {
            //     MessageBox.Show(saber.servantName);
            // }
            var servantSaber = GetDataFromDB();
            foreach(IServant gen in servantSaber)
            {
                MessageBox.Show(gen.getMyName());
            }
            
        }

        /*====================================*/
        /*============Test code End=============*/
        /*====================================*/
    }
}