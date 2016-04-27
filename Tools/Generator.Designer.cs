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
            this.btnGeneriraj = new System.Windows.Forms.Button();
            this.numZenski = new System.Windows.Forms.NumericUpDown();
            this.numVkupno = new System.Windows.Forms.NumericUpDown();
            this.numMashki = new System.Windows.Forms.NumericUpDown();
            this.txtRezultati = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numZenski)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVkupno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMashki)).BeginInit();
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
            // numZenski
            // 
            this.numZenski.Location = new System.Drawing.Point(370, 42);
            this.numZenski.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numZenski.Name = "numZenski";
            this.numZenski.Size = new System.Drawing.Size(120, 20);
            this.numZenski.TabIndex = 4;
            this.numZenski.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // numVkupno
            // 
            this.numVkupno.Location = new System.Drawing.Point(370, 11);
            this.numVkupno.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numVkupno.Name = "numVkupno";
            this.numVkupno.Size = new System.Drawing.Size(120, 20);
            this.numVkupno.TabIndex = 5;
            // 
            // numMashki
            // 
            this.numMashki.Location = new System.Drawing.Point(370, 83);
            this.numMashki.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMashki.Name = "numMashki";
            this.numMashki.Size = new System.Drawing.Size(120, 20);
            this.numMashki.TabIndex = 6;
            this.numMashki.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // txtRezultati
            // 
            this.txtRezultati.AcceptsReturn = true;
            this.txtRezultati.AcceptsTab = true;
            this.txtRezultati.Location = new System.Drawing.Point(19, 126);
            this.txtRezultati.Multiline = true;
            this.txtRezultati.Name = "txtRezultati";
            this.txtRezultati.ReadOnly = true;
            this.txtRezultati.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRezultati.Size = new System.Drawing.Size(557, 20);
            this.txtRezultati.TabIndex = 7;
            this.txtRezultati.Text = "Генерирани корисници:";
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 325);
            this.Controls.Add(this.txtRezultati);
            this.Controls.Add(this.numMashki);
            this.Controls.Add(this.numVkupno);
            this.Controls.Add(this.numZenski);
            this.Controls.Add(this.btnGeneriraj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Generator";
            this.Text = "Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numZenski)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVkupno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMashki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGeneriraj;
        private System.Windows.Forms.NumericUpDown numZenski;
        private System.Windows.Forms.NumericUpDown numVkupno;
        private System.Windows.Forms.NumericUpDown numMashki;
        private System.Windows.Forms.TextBox txtRezultati;
    }
}