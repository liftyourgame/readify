namespace Puzzle1
{
    partial class Puzzle1Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input = new System.Windows.Forms.TextBox();
            this.getFifthLast = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(13, 22);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(243, 155);
            this.input.TabIndex = 0;
            this.input.Text = "Item1\r\nItem2\r\nItem3\r\nItem4\r\nItem5\r\nItem6\r\nItem7";
            // 
            // getFifthLast
            // 
            this.getFifthLast.Location = new System.Drawing.Point(13, 194);
            this.getFifthLast.Name = "getFifthLast";
            this.getFifthLast.Size = new System.Drawing.Size(114, 23);
            this.getFifthLast.TabIndex = 1;
            this.getFifthLast.Text = "Get Fifth Last";
            this.getFifthLast.UseVisualStyleBackColor = true;
            this.getFifthLast.Click += new System.EventHandler(this.getFifth_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(13, 224);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 2;
            // 
            // Puzzle1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.result);
            this.Controls.Add(this.getFifthLast);
            this.Controls.Add(this.input);
            this.Name = "Puzzle1Form";
            this.Text = "Puzzle1 Get Fifth Element";
            this.Load += new System.EventHandler(this.Puzzle1Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button getFifthLast;
        private System.Windows.Forms.Label result;
    }
}

