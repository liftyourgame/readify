using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Puzzle3
{
    public partial class Puzzle3Form : Form
    {
        public Puzzle3Form()
        {
            InitializeComponent();
        }

        private void btnReverseWords_Click(object sender, EventArgs e)
        {
            txtOutput.Text = ReverseWords.Reverse(txtInput.Text);
        }
    }
}
