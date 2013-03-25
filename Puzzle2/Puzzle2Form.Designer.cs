namespace Puzzle2
{
    partial class Puzzle2Form
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
            this.txtSideA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSideB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSideC = new System.Windows.Forms.TextBox();
            this.btnTriangleType = new System.Windows.Forms.Button();
            this.lblTriangleType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSideA
            // 
            this.txtSideA.Location = new System.Drawing.Point(87, 21);
            this.txtSideA.Name = "txtSideA";
            this.txtSideA.Size = new System.Drawing.Size(100, 20);
            this.txtSideA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Side";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Second Side";
            // 
            // txtSideB
            // 
            this.txtSideB.Location = new System.Drawing.Point(87, 60);
            this.txtSideB.Name = "txtSideB";
            this.txtSideB.Size = new System.Drawing.Size(100, 20);
            this.txtSideB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Third Side";
            // 
            // txtSideC
            // 
            this.txtSideC.Location = new System.Drawing.Point(87, 96);
            this.txtSideC.Name = "txtSideC";
            this.txtSideC.Size = new System.Drawing.Size(100, 20);
            this.txtSideC.TabIndex = 4;
            // 
            // btnTriangleType
            // 
            this.btnTriangleType.Location = new System.Drawing.Point(87, 137);
            this.btnTriangleType.Name = "btnTriangleType";
            this.btnTriangleType.Size = new System.Drawing.Size(100, 23);
            this.btnTriangleType.TabIndex = 6;
            this.btnTriangleType.Text = "Triangle Type";
            this.btnTriangleType.UseVisualStyleBackColor = true;
            this.btnTriangleType.Click += new System.EventHandler(this.btnTriangleType_Click);
            // 
            // lblTriangleType
            // 
            this.lblTriangleType.AutoSize = true;
            this.lblTriangleType.Location = new System.Drawing.Point(84, 190);
            this.lblTriangleType.Name = "lblTriangleType";
            this.lblTriangleType.Size = new System.Drawing.Size(0, 13);
            this.lblTriangleType.TabIndex = 8;
            this.lblTriangleType.Click += new System.EventHandler(this.lblTriangleType_Click);
            // 
            // Puzzle2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblTriangleType);
            this.Controls.Add(this.btnTriangleType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSideC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSideB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSideA);
            this.Name = "Puzzle2";
            this.Text = "Puzzle2 - Triangles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSideA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSideB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSideC;
        private System.Windows.Forms.Button btnTriangleType;
        private System.Windows.Forms.Label lblTriangleType;
    }
}

