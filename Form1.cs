namespace FactoryMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            // GBOutline.Paint += GBOutline_Paint;
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
    //     private void GBOutline_Paint(object sender, PaintEventArgs e)
    //    {
    //            ControlPaint.DrawBorder(e.Graphics, GBOutline.ClientRectangle,
    //            Color.Red, 3, ButtonBorderStyle.Solid, // left
    //            Color.Red, 3, ButtonBorderStyle.Solid, // top
    //            Color.Red, 3, ButtonBorderStyle.Solid, // right
    //            Color.Red, 3, ButtonBorderStyle.Solid);// bottom
    //    }
    }
}