using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ResistorsWithUI
{
    internal class ResistorInput
    {

        private const int xStart = 5;
        private const int yStart = 5;

        private const int yJump = 25;

        public static int inputCount = 0;

        public TextBox resistorValue;
        public TextBox count;

        public ResistorInput(Control.ControlCollection c)
        {
            int y = (yStart + (yJump * inputCount));

            resistorValue = new TextBox();
            resistorValue.Location = new System.Drawing.Point(xStart, y);
            resistorValue.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            resistorValue.Size = new System.Drawing.Size(258, 25);

            count = new TextBox();
            count.Location = new System.Drawing.Point(xStart + 258 + 5, y);
            count.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            count.Size = new System.Drawing.Size(75, 25);

            c.Add(resistorValue);
            c.Add(count);

            inputCount++;
        }

        private void ResistorValue_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
