using System.Windows.Forms;

namespace FactoryMethod
{
    partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1440, 900);
        this.Text = "Form1";
        // this.BackgroundImage = Image.FromFile(@"");

        btnLeft = new Button();
        btnLeft.Name = "btnLeft";
        btnLeft.Text = "";
        btnLeft.Location = new System.Drawing.Point(250,780);
        btnLeft.ClientSize = new System.Drawing.Size(100, 75);
        btnLeft.Image = System.Drawing.Image.FromFile(@"img_resource/left-arrow.png");
        btnLeft.BackColor = Color.White;

        btnRight = new Button();
        btnRight.Name = "btnRight";
        btnRight.Text = "";
        btnRight.Location = new System.Drawing.Point(450,780);
        btnRight.ClientSize = new System.Drawing.Size(100, 75);
        btnRight.Image = System.Drawing.Image.FromFile(@"img_resource/right-arrow.png");
        btnRight.BackColor = Color.White;

        btnClaw = new Button();
        btnClaw.Name = "btnClaw";
        btnClaw.Text = "";
        btnClaw.Location = new System.Drawing.Point(720,780);
        btnClaw.ClientSize = new System.Drawing.Size(100, 75);
        btnClaw.Image = System.Drawing.Image.FromFile(@"img_resource/claw-machine.png");
        btnClaw.BackColor = Color.White;

        btnStart = new Button();
        btnStart.Name = "btnStart";
        btnStart.Text = "";
        btnStart.Location = new System.Drawing.Point(1000,780);
        btnStart.ClientSize = new System.Drawing.Size(130, 75);
        btnStart.Image = System.Drawing.Image.FromFile(@"img_resource/start-button-big.png");
        btnStart.BackColor = Color.White;



        horizontal = new Label();
        horizontal.Text = "";
        horizontal.BorderStyle = BorderStyle.Fixed3D;
        horizontal.AutoSize = false;
        horizontal.Location = new System.Drawing.Point(ScrWidth-1260,ScrHeight-150);
        horizontal.ClientSize = new System.Drawing.Size(1080,5);
        horizontal.BackColor = Color.BlueViolet;

        
        verticalLine1 = new Label();
        verticalLine1.Text = "";
        verticalLine1.BorderStyle = BorderStyle.Fixed3D;
        verticalLine1.AutoSize = false;
        verticalLine1.Location = new System.Drawing.Point(ScrWidth-1260,ScrHeight-900);
        verticalLine1.ClientSize = new System.Drawing.Size(5,755);
        verticalLine1.BackColor = Color.BlueViolet;


        verticalLine2 = new Label();
        verticalLine2.Text = "";
        verticalLine2.BorderStyle = BorderStyle.Fixed3D;
        verticalLine2.AutoSize = false;
        verticalLine2.Location = new System.Drawing.Point(ScrWidth-185,ScrHeight-900);
        verticalLine2.ClientSize = new System.Drawing.Size(5,755);
        verticalLine2.BackColor = Color.BlueViolet;


        // GBOutline = new Panel();
        // GBOutline.Text = "";
        // GBOutline.AutoSize = false;
        // GBOutline.BorderStyle = BorderStyle.Fixed3D;
        // GBOutline.Location = new System.Drawing.Point(180,0);
        // GBOutline.ClientSize = new System.Drawing.Size(1140,752);
        // GBOutline.BackColor = Color.White;


        clawAnimated = new Label();
        clawAnimated.Text = "";
        clawAnimated.BorderStyle = BorderStyle.Fixed3D;
        clawAnimated.AutoSize = false;
        clawAnimated.Location = new System.Drawing.Point(clawVerticalLineX,clawVerticalLineY);
        clawAnimated.ClientSize = new System.Drawing.Size(clawOrgSizeWidth,clawOrgSizeHeight);
        clawAnimated.BackColor = Color.BlueViolet;

        leftPic1 = new PictureBox();
        leftPic1.BorderStyle = BorderStyle.Fixed3D;
        leftPic1.AutoSize = false;
        leftPic1.Location = new System.Drawing.Point(ScrWidth-1440,ScrHeight-850);
        leftPic1.Image = System.Drawing.Image.FromFile(@"img_resource/servant_img/Mushashi.png");
        leftPic1.ClientSize = new System.Drawing.Size(175,300);
        leftPic1.SizeMode =PictureBoxSizeMode.StretchImage;
        // leftPic1.BackColor = Color.BlueViolet;

        // rightPic1 = new PictureBox();
        // rightPic1.BorderStyle = BorderStyle.Fixed3D;
        // rightPic1.AutoSize = false;
        // rightPic1.Location = new System.Drawing.Point(1260,50);
        // rightPic1.Image = System.Drawing.Image.FromFile(@"img_resource/Mushashi.png");
        // rightPic1.ClientSize = new System.Drawing.Size(175,300);
        // rightPic1.SizeMode =PictureBoxSizeMode.StretchImage;

        leftPic2 = new PictureBox();
        leftPic2.BorderStyle = BorderStyle.Fixed3D;
        leftPic2.AutoSize = false;
        leftPic2.Location = new System.Drawing.Point(ScrWidth-1440,ScrHeight-450);
        leftPic2.Image = System.Drawing.Image.FromFile(@"img_resource/servant_img/Karna.png");
        leftPic2.ClientSize = new System.Drawing.Size(175,300);
        leftPic2.SizeMode =PictureBoxSizeMode.StretchImage;

        backGround = new PictureBox();
        backGround.BorderStyle = BorderStyle.Fixed3D;
        backGround.AutoSize = false;
        backGround.Location = new System.Drawing.Point(ScrWidth-1260,ScrHeight-900);
        backGround.Image = System.Drawing.Image.FromFile(@"img_resource/BG_game2.jpg");
        backGround.ClientSize = new System.Drawing.Size(1078,750);
        backGround.SizeMode =PictureBoxSizeMode.StretchImage;

        BGbottom = new PictureBox();
        BGbottom.BorderStyle = BorderStyle.Fixed3D;
        BGbottom.AutoSize = false;
        BGbottom.Location = new System.Drawing.Point(ScrWidth-1440,ScrHeight-150);
        BGbottom.BackColor = Color.FromArgb(68,77,202);
        BGbottom.ClientSize = new System.Drawing.Size(1440,150);
        BGbottom.SizeMode =PictureBoxSizeMode.StretchImage;

        BGright = new PictureBox();
        BGright.BorderStyle = BorderStyle.None;
        BGright.AutoSize = false;
        BGright.Location = new System.Drawing.Point(1260,0);
        BGright.Image = System.Drawing.Image.FromFile(@"img_resource/command.png");
        BGright.ClientSize = new System.Drawing.Size(180,760);
        // BGright.BackColor = Color.FromArgb(68,77,202);
        BGright.SizeMode =PictureBoxSizeMode.StretchImage;

        


        
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
        // this.Controls.Add(rightPic1);
        this.Controls.Add(backGround);
        this.Controls.Add(BGbottom);
        // this.Controls.Add(GBOutline);
    }
    private Button btnLeft,btnRight,btnClaw,btnStart;
    private Label horizontal,verticalLine1,verticalLine2,clawAnimated;
    private PictureBox leftPic1,leftPic2,backGround,BGbottom,BGright;
    private int clawVerticalLineX = 720,
     clawVerticalLineY = 0,
     clawOrgSizeWidth = 5,
     clawOrgSizeHeight = 600,
     ScrWidth = 1440,
     ScrHeight = 900;
    
    

    // private Panel GBOutline;
    #endregion
}

}