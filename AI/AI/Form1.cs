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

        private void btnEduRed_Click(object sender, EventArgs e)
        {
            MyNetwork.eduRedStep();
        }

        private void checkBoxPeople_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPeople.Checked)
            {
                MyNetwork.ledPeople.Value = 1;
            }
            else
            {
                MyNetwork.ledPeople.Value = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                MyNetwork.eduRedStep();
                MyNetwork.eduYellowStep();
                MyNetwork.eduGreenStep();
            }
        }

        private void checkBoxRoad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRoad.Checked)
            {
                MyNetwork.ledRoad.Value = 1;
            }
            else
            {
                MyNetwork.ledRoad.Value = 0;
            }
        }

        private void checkBoxFest_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFest.Checked)
            {
                MyNetwork.ledFest.Value = 1;
            }
            else
            {
                MyNetwork.ledFest.Value = 0;
            }
        }
    }
}