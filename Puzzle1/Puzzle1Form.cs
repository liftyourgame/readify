using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Puzzle1
{
    public partial class Puzzle1Form : Form
    {
        public Puzzle1Form()
        {
            InitializeComponent();
        }

        private void Puzzle1Form_Load(object sender, EventArgs e)
        {

        }

        private void getFifth_Click(object sender, EventArgs e)
        {
            const int stackSize = 10;
            const int nthLastItem = 5;

            try
            {
                var s = input.Text;
                var a = s.Split('\n');

                var stack = new Stack<string>(stackSize);

                try
                {
                    foreach (var t in a.Where(t => t.Trim().Length > 0))
                    {
                        stack.Push(t);
                    }
                } catch(InvalidOperationException ex)
                {
                    throw new Exception("No more than " + stackSize + " item(s) allowed", ex);
                }

                try
                {
                    var nthElement = "";
                    for (var i = 0; i < nthLastItem; i++)
                    {
                        nthElement = stack.Pop();
                    }
                    result.Text = nthElement;
                }
                catch (InvalidOperationException ex)
                {
                    throw new Exception("Less than " + nthLastItem + " item(s) provided", ex);
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
