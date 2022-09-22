namespace FactoryMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            // panel1.Paint += panel1_Paint;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ServantFactory servantSaber = new SaberFactory();
            IServant saber = servantSaber.CreateServant();
            string voice1 = saber.MyClass();
            MessageBox.Show(voice1);

            ServantFactory servantLancer = new LancerFactory();
            IServant lancer = servantLancer.CreateServant();
            string voice2 = lancer.MyClass();
            MessageBox.Show(voice2);
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