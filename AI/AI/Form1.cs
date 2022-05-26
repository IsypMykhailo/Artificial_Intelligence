namespace AI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Network MyNetwork;

        private void Form1_Load(object sender, EventArgs e)
        {
            MyNetwork = new Network(this);
        }
    }
}