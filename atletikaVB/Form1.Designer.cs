namespace atletikaVB
{
    partial class atletikaVB2017
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
            this.AranyNemzetLabel = new System.Windows.Forms.Label();
            this.AranyNemzetListBox = new System.Windows.Forms.ListBox();
            this.AranyNemzetGomb = new System.Windows.Forms.Button();
            this.VersenySzamLabel = new System.Windows.Forms.Label();
            this.VersenySzamTextBox = new System.Windows.Forms.TextBox();
            this.VersenySzamEremHelyzesLabel = new System.Windows.Forms.Label();
            this.VersenySzamEremHelyzesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.KeresesGomb = new System.Windows.Forms.Button();
            this.VesenyzőAdataiLabel = new System.Windows.Forms.Label();
            this.NeveLabel = new System.Windows.Forms.Label();
            this.NeveLabelEredemeny = new System.Windows.Forms.Label();
            this.EredmenyeLabel = new System.Windows.Forms.Label();
            this.EredmenyeLabelEredmeny = new System.Windows.Forms.Label();
            this.NemzeteLabel = new System.Windows.Forms.Label();
            this.NemzeteLabelEredmény = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VersenySzamEremHelyzesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AranyNemzetLabel
            // 
            this.AranyNemzetLabel.AutoSize = true;
            this.AranyNemzetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AranyNemzetLabel.Location = new System.Drawing.Point(27, 9);
            this.AranyNemzetLabel.Name = "AranyNemzetLabel";
            this.AranyNemzetLabel.Size = new System.Drawing.Size(230, 20);
            this.AranyNemzetLabel.TabIndex = 0;
            this.AranyNemzetLabel.Text = "Aranyérmet szerzett nemzetek:";
            // 
            // AranyNemzetListBox
            // 
            this.AranyNemzetListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AranyNemzetListBox.FormattingEnabled = true;
            this.AranyNemzetListBox.ItemHeight = 20;
            this.AranyNemzetListBox.Location = new System.Drawing.Point(12, 33);
            this.AranyNemzetListBox.Name = "AranyNemzetListBox";
            this.AranyNemzetListBox.Size = new System.Drawing.Size(245, 324);
            this.AranyNemzetListBox.TabIndex = 1;
            this.AranyNemzetListBox.SelectedIndexChanged += new System.EventHandler(this.AranyNemzetListBox_SelectedIndexChanged);
            // 
            // AranyNemzetGomb
            // 
            this.AranyNemzetGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AranyNemzetGomb.Location = new System.Drawing.Point(53, 391);
            this.AranyNemzetGomb.Name = "AranyNemzetGomb";
            this.AranyNemzetGomb.Size = new System.Drawing.Size(173, 37);
            this.AranyNemzetGomb.TabIndex = 2;
            this.AranyNemzetGomb.Text = "aranyos - nemzetek";
            this.AranyNemzetGomb.UseVisualStyleBackColor = true;
            // 
            // VersenySzamLabel
            // 
            this.VersenySzamLabel.AutoSize = true;
            this.VersenySzamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VersenySzamLabel.Location = new System.Drawing.Point(339, 13);
            this.VersenySzamLabel.Name = "VersenySzamLabel";
            this.VersenySzamLabel.Size = new System.Drawing.Size(216, 20);
            this.VersenySzamLabel.TabIndex = 3;
            this.VersenySzamLabel.Text = "Válassza ki a versenyszámot:";
            // 
            // VersenySzamTextBox
            // 
            this.VersenySzamTextBox.Location = new System.Drawing.Point(343, 36);
            this.VersenySzamTextBox.Multiline = true;
            this.VersenySzamTextBox.Name = "VersenySzamTextBox";
            this.VersenySzamTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.VersenySzamTextBox.Size = new System.Drawing.Size(212, 94);
            this.VersenySzamTextBox.TabIndex = 4;
            this.VersenySzamTextBox.TextChanged += new System.EventHandler(this.VersenySzamTextBox_TextChanged);
            // 
            // VersenySzamEremHelyzesLabel
            // 
            this.VersenySzamEremHelyzesLabel.AutoSize = true;
            this.VersenySzamEremHelyzesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VersenySzamEremHelyzesLabel.Location = new System.Drawing.Point(343, 147);
            this.VersenySzamEremHelyzesLabel.Name = "VersenySzamEremHelyzesLabel";
            this.VersenySzamEremHelyzesLabel.Size = new System.Drawing.Size(233, 20);
            this.VersenySzamEremHelyzesLabel.TabIndex = 5;
            this.VersenySzamEremHelyzesLabel.Text = "Válassza ki az érmes helyezést:";
            // 
            // VersenySzamEremHelyzesNumericUpDown
            // 
            this.VersenySzamEremHelyzesNumericUpDown.Location = new System.Drawing.Point(347, 171);
            this.VersenySzamEremHelyzesNumericUpDown.Name = "VersenySzamEremHelyzesNumericUpDown";
            this.VersenySzamEremHelyzesNumericUpDown.Size = new System.Drawing.Size(58, 20);
            this.VersenySzamEremHelyzesNumericUpDown.TabIndex = 6;
            // 
            // KeresesGomb
            // 
            this.KeresesGomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KeresesGomb.Location = new System.Drawing.Point(384, 210);
            this.KeresesGomb.Name = "KeresesGomb";
            this.KeresesGomb.Size = new System.Drawing.Size(131, 34);
            this.KeresesGomb.TabIndex = 7;
            this.KeresesGomb.Text = "Keresés";
            this.KeresesGomb.UseVisualStyleBackColor = true;
            // 
            // VesenyzőAdataiLabel
            // 
            this.VesenyzőAdataiLabel.AutoSize = true;
            this.VesenyzőAdataiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VesenyzőAdataiLabel.Location = new System.Drawing.Point(319, 256);
            this.VesenyzőAdataiLabel.Name = "VesenyzőAdataiLabel";
            this.VesenyzőAdataiLabel.Size = new System.Drawing.Size(142, 20);
            this.VesenyzőAdataiLabel.TabIndex = 8;
            this.VesenyzőAdataiLabel.Text = "Vesenyző adatai";
            // 
            // NeveLabel
            // 
            this.NeveLabel.AutoSize = true;
            this.NeveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NeveLabel.Location = new System.Drawing.Point(319, 292);
            this.NeveLabel.Name = "NeveLabel";
            this.NeveLabel.Size = new System.Drawing.Size(47, 20);
            this.NeveLabel.TabIndex = 9;
            this.NeveLabel.Text = "neve:";
            // 
            // NeveLabelEredemeny
            // 
            this.NeveLabelEredemeny.AutoSize = true;
            this.NeveLabelEredemeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NeveLabelEredemeny.Location = new System.Drawing.Point(417, 297);
            this.NeveLabelEredemeny.Name = "NeveLabelEredemeny";
            this.NeveLabelEredemeny.Size = new System.Drawing.Size(0, 20);
            this.NeveLabelEredemeny.TabIndex = 10;
            // 
            // EredmenyeLabel
            // 
            this.EredmenyeLabel.AutoSize = true;
            this.EredmenyeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EredmenyeLabel.Location = new System.Drawing.Point(319, 329);
            this.EredmenyeLabel.Name = "EredmenyeLabel";
            this.EredmenyeLabel.Size = new System.Drawing.Size(92, 20);
            this.EredmenyeLabel.TabIndex = 11;
            this.EredmenyeLabel.Text = "eredménye:";
            // 
            // EredmenyeLabelEredmeny
            // 
            this.EredmenyeLabelEredmeny.AutoSize = true;
            this.EredmenyeLabelEredmeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EredmenyeLabelEredmeny.Location = new System.Drawing.Point(425, 334);
            this.EredmenyeLabelEredmeny.Name = "EredmenyeLabelEredmeny";
            this.EredmenyeLabelEredmeny.Size = new System.Drawing.Size(0, 20);
            this.EredmenyeLabelEredmeny.TabIndex = 12;
            // 
            // NemzeteLabel
            // 
            this.NemzeteLabel.AutoSize = true;
            this.NemzeteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NemzeteLabel.Location = new System.Drawing.Point(323, 364);
            this.NemzeteLabel.Name = "NemzeteLabel";
            this.NemzeteLabel.Size = new System.Drawing.Size(75, 20);
            this.NemzeteLabel.TabIndex = 13;
            this.NemzeteLabel.Text = "nemzete:";
            // 
            // NemzeteLabelEredmény
            // 
            this.NemzeteLabelEredmény.AutoSize = true;
            this.NemzeteLabelEredmény.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NemzeteLabelEredmény.Location = new System.Drawing.Point(418, 371);
            this.NemzeteLabelEredmény.Name = "NemzeteLabelEredmény";
            this.NemzeteLabelEredmény.Size = new System.Drawing.Size(0, 20);
            this.NemzeteLabelEredmény.TabIndex = 14;
            // 
            // atletikaVB2017
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NemzeteLabelEredmény);
            this.Controls.Add(this.NemzeteLabel);
            this.Controls.Add(this.EredmenyeLabelEredmeny);
            this.Controls.Add(this.EredmenyeLabel);
            this.Controls.Add(this.NeveLabelEredemeny);
            this.Controls.Add(this.NeveLabel);
            this.Controls.Add(this.VesenyzőAdataiLabel);
            this.Controls.Add(this.KeresesGomb);
            this.Controls.Add(this.VersenySzamEremHelyzesNumericUpDown);
            this.Controls.Add(this.VersenySzamEremHelyzesLabel);
            this.Controls.Add(this.VersenySzamTextBox);
            this.Controls.Add(this.VersenySzamLabel);
            this.Controls.Add(this.AranyNemzetGomb);
            this.Controls.Add(this.AranyNemzetListBox);
            this.Controls.Add(this.AranyNemzetLabel);
            this.Name = "atletikaVB2017";
            this.Text = "Férfiak eredménye a 2017-es atlétikai VB-n";
            this.Load += new System.EventHandler(this.atletikaVB2017_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VersenySzamEremHelyzesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AranyNemzetLabel;
        private System.Windows.Forms.ListBox AranyNemzetListBox;
        private System.Windows.Forms.Button AranyNemzetGomb;
        private System.Windows.Forms.Label VersenySzamLabel;
        private System.Windows.Forms.TextBox VersenySzamTextBox;
        private System.Windows.Forms.Label VersenySzamEremHelyzesLabel;
        private System.Windows.Forms.NumericUpDown VersenySzamEremHelyzesNumericUpDown;
        private System.Windows.Forms.Button KeresesGomb;
        private System.Windows.Forms.Label VesenyzőAdataiLabel;
        private System.Windows.Forms.Label NeveLabel;
        private System.Windows.Forms.Label NeveLabelEredemeny;
        private System.Windows.Forms.Label EredmenyeLabel;
        private System.Windows.Forms.Label EredmenyeLabelEredmeny;
        private System.Windows.Forms.Label NemzeteLabel;
        private System.Windows.Forms.Label NemzeteLabelEredmény;
    }
}

