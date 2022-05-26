using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI
{
    internal class Network
    {
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

            moveDir.Level.Add(ledYellow);
            w = rnd.NextDouble();
            moveDir.Weight.Add(w);

            moveDir.Level.Add(ledGreen);
            w = rnd.NextDouble();
            moveDir.Weight.Add(w);

            #endregion
        }
    }
}
