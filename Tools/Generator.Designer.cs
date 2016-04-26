namespace Tools
{
    partial class Generator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVkupno = new System.Windows.Forms.TextBox();
            this.txtZenski = new System.Windows.Forms.TextBox();
            this.txtMashki = new System.Windows.Forms.TextBox();
            this.btnGeneriraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Колку податоци сакате да бидат изгенерирани:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Колку женски податоци сакате да бидат изгенерирани:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Колку машки податоци сакате да бидат изгенерирани:";
            // 
            // txtVkupno
            // 
            this.txtVkupno.Location = new System.Drawing.Point(370, 10);
            this.txtVkupno.Name = "txtVkupno";
            this.txtVkupno.Size = new System.Drawing.Size(100, 20);
            this.txtVkupno.TabIndex = 0;
            // 
            // txtZenski
            // 
            this.txtZenski.Location = new System.Drawing.Point(370, 43);
            this.txtZenski.Name = "txtZenski";
            this.txtZenski.Size = new System.Drawing.Size(100, 20);
            this.txtZenski.TabIndex = 1;
            // 
            // txtMashki
            // 
            this.txtMashki.Location = new System.Drawing.Point(370, 76);
            this.txtMashki.Name = "txtMashki";
            this.txtMashki.Size = new System.Drawing.Size(100, 20);
            this.txtMashki.TabIndex = 2;
            // 
            // btnGeneriraj
            // 
            this.btnGeneriraj.Location = new System.Drawing.Point(501, 39);
            this.btnGeneriraj.Name = "btnGeneriraj";
            this.btnGeneriraj.Size = new System.Drawing.Size(75, 23);
            this.btnGeneriraj.TabIndex = 3;
            this.btnGeneriraj.Text = "Генерирај";
            this.btnGeneriraj.UseVisualStyleBackColor = true;
            this.btnGeneriraj.Click += new System.EventHandler(this.btnGeneriraj_Click);
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 262);
            this.Controls.Add(this.btnGeneriraj);
            this.Controls.Add(this.txtMashki);
            this.Controls.Add(this.txtZenski);
            this.Controls.Add(this.txtVkupno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Generator";
            this.Text = "Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVkupno;
        private System.Windows.Forms.TextBox txtZenski;
        private System.Windows.Forms.TextBox txtMashki;
        private System.Windows.Forms.Button btnGeneriraj;
    }
}