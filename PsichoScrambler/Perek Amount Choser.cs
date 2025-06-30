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
        public const int k_RequiredSections = 8;
        public int NumberOfSections { get; private set; } = 0;

        private int camotiNum = 0;
        private int hebrewNum = 0;
        private int englishNum = 0;
        public PerekAmountChoser()
        {
            InitializeComponent();
        }

        private void CamotiAmount_ValueChanged(object i_Sender, EventArgs i_E)
        {
            NumericUpDown? camotiAmount = i_Sender as NumericUpDown;
            camotiNum = (int)camotiAmount!.Value;
        }

        private void HebrewAmount_ValueChanged(object i_Sender, EventArgs i_E)
        {
            NumericUpDown? hebrewAmount = i_Sender as NumericUpDown;
            hebrewNum = (int)hebrewAmount!.Value;
        }

        private void EnglishAmount_ValueChanged(object i_Sender, EventArgs i_E)
        {
            NumericUpDown? englishAmount = i_Sender as NumericUpDown;
            englishNum = (int)EnglishAmount!.Value;
        }

        private void GenerateButton_Click(object i_Sender, EventArgs i_E)
        {
            NumberOfSections = camotiNum + hebrewNum + englishNum;
            if (NumberOfSections != k_RequiredSections)
            {
                Error screen = new Error();
                screen.ShowDialog();
            }
            else
            {
                SectionView sectionView = new SectionView();
                sectionView.ShowDialog();
            }
        }
    }
}
