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

        private void btnCalcSum_Click(object sender, EventArgs e)
        {
            MyNetwork.CalcSum();
        }

        private void changeLed(object sender, EventArgs e)
        {
            if (rRed.Checked)
            {
                MyNetwork.ledRed.Value = 1;
            }
            else
            {
                MyNetwork.ledRed.Value = 0;
            }

            if (rYellow.Checked)
            {
                MyNetwork.ledYellow.Value = 1;
            }
            else
            {
                MyNetwork.ledYellow.Value = 0;
            }

            if (rGreen.Checked)
            {
                MyNetwork.ledGreen.Value = 1;
            }
            else
            {
                MyNetwork.ledGreen.Value = 0;
            }
        }

        private void btnEduAll_Click(object sender, EventArgs e)
        {
            MyNetwork.eduRedStep();
            MyNetwork.eduYellowStep();
            MyNetwork.eduGreenStep();
        }
    }
}