using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsichoScrambler
{
    public partial class PerekAmountChoser : Form
    {
        public int NumberOfSections { get; private set; } = 0;
        public PerekAmountChoser()
        {
            InitializeComponent();
        }

        private void CamotiAmount_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown? camotiAmount = sender as NumericUpDown;
            NumberOfSections += (int)camotiAmount!.Value;
        }

        private void HebrewAmount_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown? hebrewAmount = sender as NumericUpDown;
            NumberOfSections += (int)hebrewAmount!.Value;
        }

        private void EnglishAmount_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown? englishAmount = sender as NumericUpDown;
            NumberOfSections += (int)EnglishAmount!.Value;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if(NumberOfSections != 8)
            {
                Error screen = new Error();
                screen.ShowDialog();
            }
        }
    }
}
