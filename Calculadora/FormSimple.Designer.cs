namespace Calculadora
{
    partial class FormSimple
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.comboBoxSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAños = new System.Windows.Forms.TextBox();
            this.textBoxMeses = new System.Windows.Forms.TextBox();
            this.textBoxDias = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelAños = new System.Windows.Forms.Label();
            this.labelMeses = new System.Windows.Forms.Label();
            this.labelDias = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelValorFinal = new System.Windows.Forms.Label();
            this.textBoxValorFinal = new System.Windows.Forms.TextBox();
            this.labelValorIncial = new System.Windows.Forms.Label();
            this.textBoxValorIncial = new System.Windows.Forms.TextBox();
            this.labelTasaInteres = new System.Windows.Forms.Label();
            this.textBoxTasaInteres = new System.Windows.Forms.TextBox();
            this.labelTiempo = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelPrincipal.Controls.Add(this.comboBoxSelector);
            this.panelPrincipal.Controls.Add(this.label1);
            this.panelPrincipal.Controls.Add(this.textBoxAños);
            this.panelPrincipal.Controls.Add(this.textBoxMeses);
            this.panelPrincipal.Controls.Add(this.textBoxDias);
            this.panelPrincipal.Controls.Add(this.labelValor);
            this.panelPrincipal.Controls.Add(this.labelAños);
            this.panelPrincipal.Controls.Add(this.labelMeses);
            this.panelPrincipal.Controls.Add(this.labelDias);
            this.panelPrincipal.Controls.Add(this.buttonCalcular);
            this.panelPrincipal.Controls.Add(this.labelValorFinal);
            this.panelPrincipal.Controls.Add(this.textBoxValorFinal);
            this.panelPrincipal.Controls.Add(this.labelValorIncial);
            this.panelPrincipal.Controls.Add(this.textBoxValorIncial);
            this.panelPrincipal.Controls.Add(this.labelTasaInteres);
            this.panelPrincipal.Controls.Add(this.textBoxTasaInteres);
            this.panelPrincipal.Controls.Add(this.labelTiempo);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(800, 450);
            this.panelPrincipal.TabIndex = 0;
            // 
            // comboBoxSelector
            // 
            this.comboBoxSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelector.FormattingEnabled = true;
            this.comboBoxSelector.Items.AddRange(new object[] {
            "Diario",
            "Mensual",
            "Anual",
            "Diario-Mensual-Anual",
            "Trimestral",
            "Cuatrimestral",
            "Semestral"});
            this.comboBoxSelector.Location = new System.Drawing.Point(140, 103);
            this.comboBoxSelector.Name = "comboBoxSelector";
            this.comboBoxSelector.Size = new System.Drawing.Size(69, 21);
            this.comboBoxSelector.TabIndex = 40;
            this.comboBoxSelector.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelector_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Interes Simple";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxAños
            // 
            this.textBoxAños.Location = new System.Drawing.Point(140, 221);
            this.textBoxAños.Name = "textBoxAños";
            this.textBoxAños.Size = new System.Drawing.Size(69, 20);
            this.textBoxAños.TabIndex = 21;
            this.textBoxAños.Visible = false;
            this.textBoxAños.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAños_KeyPress);
            // 
            // textBoxMeses
            // 
            this.textBoxMeses.Location = new System.Drawing.Point(140, 180);
            this.textBoxMeses.Name = "textBoxMeses";
            this.textBoxMeses.Size = new System.Drawing.Size(69, 20);
            this.textBoxMeses.TabIndex = 20;
            this.textBoxMeses.Visible = false;
            this.textBoxMeses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMeses_KeyPress);
            // 
            // textBoxDias
            // 
            this.textBoxDias.Location = new System.Drawing.Point(140, 141);
            this.textBoxDias.Name = "textBoxDias";
            this.textBoxDias.Size = new System.Drawing.Size(69, 20);
            this.textBoxDias.TabIndex = 19;
            this.textBoxDias.Visible = false;
            this.textBoxDias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDias_KeyPress);
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(120, 299);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(31, 13);
            this.labelValor.TabIndex = 18;
            this.labelValor.Text = "Valor";
            this.labelValor.Visible = false;
            // 
            // labelAños
            // 
            this.labelAños.AutoSize = true;
            this.labelAños.Location = new System.Drawing.Point(70, 221);
            this.labelAños.Name = "labelAños";
            this.labelAños.Size = new System.Drawing.Size(34, 13);
            this.labelAños.TabIndex = 16;
            this.labelAños.Text = "Anual";
            this.labelAños.Visible = false;
            // 
            // labelMeses
            // 
            this.labelMeses.AutoSize = true;
            this.labelMeses.Location = new System.Drawing.Point(67, 183);
            this.labelMeses.Name = "labelMeses";
            this.labelMeses.Size = new System.Drawing.Size(47, 13);
            this.labelMeses.TabIndex = 15;
            this.labelMeses.Text = "Mensual";
            this.labelMeses.Visible = false;
            // 
            // labelDias
            // 
            this.labelDias.AutoSize = true;
            this.labelDias.Location = new System.Drawing.Point(71, 144);
            this.labelDias.Name = "labelDias";
            this.labelDias.Size = new System.Drawing.Size(34, 13);
            this.labelDias.TabIndex = 14;
            this.labelDias.Text = "Diario";
            this.labelDias.Visible = false;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(533, 333);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(124, 23);
            this.buttonCalcular.TabIndex = 13;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelValorFinal
            // 
            this.labelValorFinal.AutoSize = true;
            this.labelValorFinal.Location = new System.Drawing.Point(555, 78);
            this.labelValorFinal.Name = "labelValorFinal";
            this.labelValorFinal.Size = new System.Drawing.Size(56, 13);
            this.labelValorFinal.TabIndex = 7;
            this.labelValorFinal.Text = "Valor Final";
            // 
            // textBoxValorFinal
            // 
            this.textBoxValorFinal.Location = new System.Drawing.Point(533, 103);
            this.textBoxValorFinal.Name = "textBoxValorFinal";
            this.textBoxValorFinal.Size = new System.Drawing.Size(108, 20);
            this.textBoxValorFinal.TabIndex = 6;
            this.textBoxValorFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValorFinal_KeyPress);
            // 
            // labelValorIncial
            // 
            this.labelValorIncial.AutoSize = true;
            this.labelValorIncial.Location = new System.Drawing.Point(427, 78);
            this.labelValorIncial.Name = "labelValorIncial";
            this.labelValorIncial.Size = new System.Drawing.Size(61, 13);
            this.labelValorIncial.TabIndex = 5;
            this.labelValorIncial.Text = "Valor Inicial";
            this.labelValorIncial.Click += new System.EventHandler(this.labelValorIncial_Click);
            // 
            // textBoxValorIncial
            // 
            this.textBoxValorIncial.Location = new System.Drawing.Point(402, 103);
            this.textBoxValorIncial.Name = "textBoxValorIncial";
            this.textBoxValorIncial.Size = new System.Drawing.Size(108, 20);
            this.textBoxValorIncial.TabIndex = 4;
            this.textBoxValorIncial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValorIncial_KeyPress);
            // 
            // labelTasaInteres
            // 
            this.labelTasaInteres.AutoSize = true;
            this.labelTasaInteres.Location = new System.Drawing.Point(280, 78);
            this.labelTasaInteres.Name = "labelTasaInteres";
            this.labelTasaInteres.Size = new System.Drawing.Size(81, 13);
            this.labelTasaInteres.TabIndex = 3;
            this.labelTasaInteres.Text = "Tasa de Interes";
            // 
            // textBoxTasaInteres
            // 
            this.textBoxTasaInteres.Location = new System.Drawing.Point(267, 103);
            this.textBoxTasaInteres.Name = "textBoxTasaInteres";
            this.textBoxTasaInteres.Size = new System.Drawing.Size(108, 20);
            this.textBoxTasaInteres.TabIndex = 2;
            this.textBoxTasaInteres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTasaInteres_KeyPress);
            // 
            // labelTiempo
            // 
            this.labelTiempo.AutoSize = true;
            this.labelTiempo.Location = new System.Drawing.Point(153, 78);
            this.labelTiempo.Name = "labelTiempo";
            this.labelTiempo.Size = new System.Drawing.Size(42, 13);
            this.labelTiempo.TabIndex = 1;
            this.labelTiempo.Text = "Tiempo";
            // 
            // FormSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSimple";
            this.Text = "FormSimple";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label labelValorFinal;
        private System.Windows.Forms.TextBox textBoxValorFinal;
        private System.Windows.Forms.Label labelValorIncial;
        private System.Windows.Forms.TextBox textBoxValorIncial;
        private System.Windows.Forms.Label labelTasaInteres;
        private System.Windows.Forms.TextBox textBoxTasaInteres;
        private System.Windows.Forms.Label labelTiempo;
        private System.Windows.Forms.Label labelAños;
        private System.Windows.Forms.Label labelMeses;
        private System.Windows.Forms.Label labelDias;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.TextBox textBoxAños;
        private System.Windows.Forms.TextBox textBoxMeses;
        private System.Windows.Forms.TextBox textBoxDias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelector;
    }
}