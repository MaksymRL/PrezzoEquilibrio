namespace PrezzoEquilibrio
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.formsPlot = new ScottPlot.WinForms.FormsPlot();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_reset = new System.Windows.Forms.Button();
            this.lblEquilibrio = new System.Windows.Forms.Label();
            this.numOffertaEsponente = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numOffertaCoeff = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numOffertaIntercetta = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numDomandaCoeff = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numDomandaIntercetta = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOffertaEsponente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffertaCoeff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffertaIntercetta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDomandaCoeff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDomandaIntercetta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // formsPlot
            // 
            this.formsPlot.DisplayScale = 0F;
            this.formsPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlot.Location = new System.Drawing.Point(0, 0);
            this.formsPlot.Name = "formsPlot";
            this.formsPlot.Size = new System.Drawing.Size(984, 661);
            this.formsPlot.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.button_reset);
            this.panel1.Controls.Add(this.lblEquilibrio);
            this.panel1.Controls.Add(this.numOffertaEsponente);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.numOffertaCoeff);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.numOffertaIntercetta);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numDomandaCoeff);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numDomandaIntercetta);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(684, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 661);
            this.panel1.TabIndex = 1;
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(23, 602);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(150, 30);
            this.button_reset.TabIndex = 14;
            this.button_reset.Text = "Reset Valori Originali";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // lblEquilibrio
            // 
            this.lblEquilibrio.AutoSize = true;
            this.lblEquilibrio.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblEquilibrio.Location = new System.Drawing.Point(20, 295);
            this.lblEquilibrio.Name = "lblEquilibrio";
            this.lblEquilibrio.Size = new System.Drawing.Size(172, 16);
            this.lblEquilibrio.TabIndex = 13;
            this.lblEquilibrio.Text = "Equilibrio: Calcolando...";
            // 
            // numOffertaEsponente
            // 
            this.numOffertaEsponente.Location = new System.Drawing.Point(120, 260);
            this.numOffertaEsponente.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numOffertaEsponente.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOffertaEsponente.Name = "numOffertaEsponente";
            this.numOffertaEsponente.Size = new System.Drawing.Size(80, 20);
            this.numOffertaEsponente.TabIndex = 12;
            this.numOffertaEsponente.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numOffertaEsponente.ValueChanged += new System.EventHandler(this.numOffertaEsponente_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Esponente (e):";
            // 
            // numOffertaCoeff
            // 
            this.numOffertaCoeff.DecimalPlaces = 4;
            this.numOffertaCoeff.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numOffertaCoeff.Location = new System.Drawing.Point(120, 230);
            this.numOffertaCoeff.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numOffertaCoeff.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numOffertaCoeff.Name = "numOffertaCoeff";
            this.numOffertaCoeff.Size = new System.Drawing.Size(80, 20);
            this.numOffertaCoeff.TabIndex = 10;
            this.numOffertaCoeff.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numOffertaCoeff.ValueChanged += new System.EventHandler(this.numOffertaCoeff_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Coefficiente (d):";
            // 
            // numOffertaIntercetta
            // 
            this.numOffertaIntercetta.DecimalPlaces = 2;
            this.numOffertaIntercetta.Location = new System.Drawing.Point(120, 200);
            this.numOffertaIntercetta.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numOffertaIntercetta.Name = "numOffertaIntercetta";
            this.numOffertaIntercetta.Size = new System.Drawing.Size(80, 20);
            this.numOffertaIntercetta.TabIndex = 8;
            this.numOffertaIntercetta.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numOffertaIntercetta.ValueChanged += new System.EventHandler(this.numOffertaIntercetta_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Intercetta (c):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(20, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "OFFERTA: o = c + d·q^e";
            // 
            // numDomandaCoeff
            // 
            this.numDomandaCoeff.DecimalPlaces = 2;
            this.numDomandaCoeff.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numDomandaCoeff.Location = new System.Drawing.Point(120, 120);
            this.numDomandaCoeff.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numDomandaCoeff.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.numDomandaCoeff.Name = "numDomandaCoeff";
            this.numDomandaCoeff.Size = new System.Drawing.Size(80, 20);
            this.numDomandaCoeff.TabIndex = 5;
            this.numDomandaCoeff.Value = new decimal(new int[] {
            4,
            0,
            0,
            -2147483648});
            this.numDomandaCoeff.ValueChanged += new System.EventHandler(this.numDomandaCoeff_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Coefficiente (b):";
            // 
            // numDomandaIntercetta
            // 
            this.numDomandaIntercetta.DecimalPlaces = 2;
            this.numDomandaIntercetta.Location = new System.Drawing.Point(120, 90);
            this.numDomandaIntercetta.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numDomandaIntercetta.Name = "numDomandaIntercetta";
            this.numDomandaIntercetta.Size = new System.Drawing.Size(80, 20);
            this.numDomandaIntercetta.TabIndex = 3;
            this.numDomandaIntercetta.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numDomandaIntercetta.ValueChanged += new System.EventHandler(this.numDomandaIntercetta_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Intercetta (a):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "DOMANDA: d = a + b·q";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PARAMETRI";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 413);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(240, 150);
            this.dataGridView.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(20, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tabella Dati";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.formsPlot);
            this.Name = "Form1";
            this.Text = "Analisi Prezzo di Equilibrio - Domanda e Offerta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOffertaEsponente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffertaCoeff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffertaIntercetta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDomandaCoeff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDomandaIntercetta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numDomandaIntercetta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numDomandaCoeff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numOffertaIntercetta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEquilibrio;
        private System.Windows.Forms.NumericUpDown numOffertaEsponente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numOffertaCoeff;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}





