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
        Neuron ledRed = new Neuron();
        Neuron ledYellow = new Neuron();
        Neuron ledGreen = new Neuron();

        Neuron moveDir = new Neuron();

        public void BuildNetwork()
        {
            Random rnd = new Random();
            double w = 0;

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
    }
}
