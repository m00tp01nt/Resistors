using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Resistors;

namespace ResistorsWithUI
{
    public partial class Form1 : Form
    {

        List<ResistorInput> inputList;

        ResistorCollection table;
        List<Resistor> list;

        bool computed;

        public Form1()
        {
            InitializeComponent();

            inputList = new List<ResistorInput>();

            list = new List<Resistor>();

            computed = false;

            go.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e) { }

        public void recalculate(object sender, EventArgs e)
        {
            this.computed = false;
        }

        public void addNewResistor()
        {
            ResistorInput input = new ResistorInput(Controls);

            inputList.Add(input);

            computed = false;
        }

        private void add_Click(object sender, EventArgs e)
        {
            addNewResistor();
        }

        private void go_Click(object sender, EventArgs e)
        {
            if (!computed)
            {
                list.Clear();

                double count;
                double value;

                foreach (ResistorInput input in inputList)
                {
                    try
                    {
                        count = Double.Parse(input.count.Text);
                    }
                    catch (FormatException)
                    {
                        count = 1;
                    }
                    for (int i = 0; i < count; i++)
                    {
                        
                        try
                        {
                            value = Double.Parse(input.resistorValue.Text);
                        }
                        catch (FormatException)
                        {
                            break;
                        }
                        list.Add(new Resistor(value));
                    }
                }

                Combine.findAllCombinations(table, list);
                computed = true;
            }

            Resistor closest = table.findClosestValue(new Resistor(Double.Parse(target.Text)));

            result.Text = closest.definition + " , which is " + Math.Round(closest.value, (int)Double.Parse(precision.Text));
        }

        private void precision_TextChanged(object sender, EventArgs e)
        {
            try
            {
                table = new ResistorCollection((int)Double.Parse(precision.Text));

                computed = false;
                go.Enabled = true;
            }
            catch (FormatException)
            {
                go.Enabled = false;
            }
        }

        private void target_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double targetValue = Double.Parse(target.Text);
            }
            catch (FormatException)
            {
                go.Enabled = false;
                return;
            }

            if (computed)
            {
                go_Click(sender, e);
            }
        }
    }
}
