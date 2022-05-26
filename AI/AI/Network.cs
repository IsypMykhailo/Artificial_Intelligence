using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI
{
    internal class Network
    {
        Form1 form;
        public Network(Form1 form)
        {
            this.form = form;
            BuildNetwork();
        }
        public Neuron ledRed = new Neuron();
        public Neuron ledYellow = new Neuron();
        public Neuron ledGreen = new Neuron();

        public Neuron moveDir = new Neuron();

        public void BuildNetwork()
        {
            Random rnd = new Random();
            double w = 0;

            moveDir.txtSum = form.textResult;
            moveDir.isBegin = false;

            #region Светофор

            moveDir.Level.Add(ledRed);
            w = rnd.NextDouble();
            moveDir.Weight.Add(w);
            form.wRed.Text = w.ToString();
            moveDir.TextBoxes.Add(form.wRed);

            moveDir.Level.Add(ledYellow);
            w = rnd.NextDouble();
            moveDir.Weight.Add(w);
            form.wYellow.Text = w.ToString();
            moveDir.TextBoxes.Add(form.wYellow);

            moveDir.Level.Add(ledGreen);
            w = rnd.NextDouble();
            moveDir.Weight.Add(w);
            form.wGreen.Text = w.ToString();
            moveDir.TextBoxes.Add(form.wGreen);

            #endregion
        }

        public void CalcSum()
        {
            moveDir.CalcSum();
        }

        public void eduRedStep()
        {
            ledRed.Value = 1;
            ledYellow.Value = 0;
            ledGreen.Value = 0;

            moveDir.Expected = 0;

            moveDir.CalcSum();
            moveDir.CalcSigmoid();
            moveDir.CorrectWeight();
        }

        public void eduYellowStep()
        {
            ledRed.Value = 0;
            ledYellow.Value = 1;
            ledGreen.Value = 0;

            moveDir.Expected = 0;

            moveDir.CalcSum();
            moveDir.CalcSigmoid();
            moveDir.CorrectWeight();
        }

        public void eduGreenStep()
        {
            ledRed.Value = 0;
            ledYellow.Value = 0;
            ledGreen.Value = 1;

            moveDir.Expected = 0;

            moveDir.CalcSum();
            moveDir.CalcSigmoid();
            moveDir.CorrectWeight();
        }
    }
}
