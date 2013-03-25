namespace Puzzle3
{
    partial class Puzzle3Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnReverseWords = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(46, 43);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(198, 20);
            this.txtInput.TabIndex = 1;
            this.txtInput.Text = "Cat and dog";
            // 
            // btnReverseWords
            // 
            this.btnReverseWords.Location = new System.Drawing.Point(46, 94);
            this.btnReverseWords.Name = "btnReverseWords";
            this.btnReverseWords.Size = new System.Drawing.Size(99, 23);
            this.btnReverseWords.TabIndex = 2;
            this.btnReverseWords.Text = "Reverse Words";
            this.btnReverseWords.UseVisualStyleBackColor = true;
            this.btnReverseWords.Click += new System.EventHandler(this.btnReverseWords_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(46, 174);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(198, 20);
            this.txtOutput.TabIndex = 4;
            // 
            // Puzzle3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReverseWords);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "Puzzle3Form";
            this.Text = "Puzzle3 - Reverse Words";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnReverseWords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

