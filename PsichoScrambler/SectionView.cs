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
    public partial class SectionView : Form
    {
        public SectionView()
        {
            InitializeComponent();
        }

        // Example: Update boxes in your logic
        private void SectionView_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Data 1";
            textBox2.Text = "Data 2";
        }
    }
}
