namespace FactoryMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
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
    }
}