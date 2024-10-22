namespace basler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VaihdaBT = new System.Windows.Forms.Button();
            this.JuttuLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VaihdaBT
            // 
            this.VaihdaBT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VaihdaBT.Location = new System.Drawing.Point(12, 154);
            this.VaihdaBT.Name = "VaihdaBT";
            this.VaihdaBT.Size = new System.Drawing.Size(129, 53);
            this.VaihdaBT.TabIndex = 0;
            this.VaihdaBT.Text = "Vaihda!";
            this.VaihdaBT.UseVisualStyleBackColor = true;
            this.VaihdaBT.Click += new System.EventHandler(this.VaihdaBT_Click);
            // 
            // JuttuLB
            // 
            this.JuttuLB.AutoSize = true;
            this.JuttuLB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JuttuLB.Location = new System.Drawing.Point(21, 85);
            this.JuttuLB.Name = "JuttuLB";
            this.JuttuLB.Size = new System.Drawing.Size(128, 30);
            this.JuttuLB.TabIndex = 1;
            this.JuttuLB.Text = "Hell o World";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.JuttuLB);
            this.Controls.Add(this.VaihdaBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button VaihdaBT;
        private Label JuttuLB;
    }
}