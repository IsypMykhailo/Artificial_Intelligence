using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI
{
    internal class Neuron
    {
        public bool isBegin = true; // Начальный ли нейрон
        public double Value; // Начальный нейрон может только передавать данные
        // Тут же зафиксируем вычисление сигмоида

        // Предыдущий уровень нейронов
        public List<Neuron> Level = new List<Neuron>();
        // Вес мнения предыдущего уровня
        public List<double> Weight = new List<double>();
        // Место отображения весов
        public List<TextBox> TextBoxes = new List<TextBox>();

        public double Sum = 0; // Сумма сигналов с левого уровня
        public TextBox txtSum;
        public void CalcSum()
        {
            Sum = 0;
            for(int i=0; i < Level.Count; i++)
            {
                Sum += Level[i].Value * Weight[i];
            }
            if(txtSum != null)
            {
                txtSum.Text = Sum.ToString();
            }
        }

        public void CalcSigmoid()
        {
            if (isBegin) return;
            Value = 1 / (1 + Math.Exp(-Sum));
        }

        public double Expected; // Я ждал что будет такое решение

        public void CorrectWeight()
        {
            double error = Value - Expected;
            double weightCor = error * Value * (1 - Value);

            double learningRate = 0.1;

            for(int i=0; i<Weight.Count; i++)
            {
                Weight[i] = Weight[i] - Level[i].Value * weightCor * learningRate;

                if (TextBoxes[i] != null)
                {
                    TextBoxes[i].Text = Weight[i].ToString();
                }
            }
        }
    }
}
