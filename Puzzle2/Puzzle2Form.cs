using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Puzzle2
{
    public partial class Puzzle2Form : Form
    {
        public Puzzle2Form()
        {
            InitializeComponent();
        }

        private void btnTriangleType_Click(object sender, EventArgs e)
        {
            try
            {
                var a = int.Parse(this.txtSideA.Text);
                var b = int.Parse(this.txtSideB.Text);
                var c = int.Parse(this.txtSideC.Text);

                lblTriangleType.Text = TriangleType.GetType(a, b, c);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblTriangleType_Click(object sender, EventArgs e)
        {

        }

    }
}
