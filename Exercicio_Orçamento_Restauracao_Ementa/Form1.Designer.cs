namespace Exercicio_Orçamento_Restauracao_Ementa
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cboEmenta = new System.Windows.Forms.ComboBox();
            this.nudAdultos = new System.Windows.Forms.NumericUpDown();
            this.nudCriancas = new System.Windows.Forms.NumericUpDown();
            this.nudDieta = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblValorAdulto = new System.Windows.Forms.Label();
            this.lblValorCrianca = new System.Windows.Forms.Label();
            this.lblValorDieta = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimparValores = new System.Windows.Forms.Button();
            this.lblPagamentoDia = new System.Windows.Forms.Label();
            this.lblSinal = new System.Windows.Forms.Label();
            this.lblPrecoTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ntfMyNotify = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCriancas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDieta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ementa";
            // 
            // cboEmenta
            // 
            this.cboEmenta.FormattingEnabled = true;
            this.cboEmenta.Items.AddRange(new object[] {
            "DELUXE",
            "PORTUGUESA",
            "PRESTIGIO",
            "RODIZIO",
            "SOBERBA"});
            this.cboEmenta.Location = new System.Drawing.Point(114, 37);
            this.cboEmenta.Name = "cboEmenta";
            this.cboEmenta.Size = new System.Drawing.Size(121, 21);
            this.cboEmenta.TabIndex = 1;
            // 
            // nudAdultos
            // 
            this.nudAdultos.Location = new System.Drawing.Point(142, 132);
            this.nudAdultos.Name = "nudAdultos";
            this.nudAdultos.Size = new System.Drawing.Size(32, 20);
            this.nudAdultos.TabIndex = 2;
            this.nudAdultos.ValueChanged += new System.EventHandler(this.nudAdultos_ValueChanged);
            // 
            // nudCriancas
            // 
            this.nudCriancas.Location = new System.Drawing.Point(142, 158);
            this.nudCriancas.Name = "nudCriancas";
            this.nudCriancas.Size = new System.Drawing.Size(32, 20);
            this.nudCriancas.TabIndex = 3;
            this.nudCriancas.ValueChanged += new System.EventHandler(this.nudCriancas_ValueChanged);
            // 
            // nudDieta
            // 
            this.nudDieta.Location = new System.Drawing.Point(142, 184);
            this.nudDieta.Name = "nudDieta";
            this.nudDieta.Size = new System.Drawing.Size(32, 20);
            this.nudDieta.TabIndex = 4;
            this.nudDieta.ValueChanged += new System.EventHandler(this.nudDieta_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adultos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Crianças";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dieta";
            // 
            // lblValorAdulto
            // 
            this.lblValorAdulto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValorAdulto.Location = new System.Drawing.Point(215, 134);
            this.lblValorAdulto.Name = "lblValorAdulto";
            this.lblValorAdulto.Size = new System.Drawing.Size(45, 18);
            this.lblValorAdulto.TabIndex = 8;
            this.lblValorAdulto.Text = "label5";
            // 
            // lblValorCrianca
            // 
            this.lblValorCrianca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValorCrianca.Location = new System.Drawing.Point(215, 160);
            this.lblValorCrianca.Name = "lblValorCrianca";
            this.lblValorCrianca.Size = new System.Drawing.Size(45, 18);
            this.lblValorCrianca.TabIndex = 9;
            this.lblValorCrianca.Text = "label6";
            // 
            // lblValorDieta
            // 
            this.lblValorDieta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValorDieta.Location = new System.Drawing.Point(215, 186);
            this.lblValorDieta.Name = "lblValorDieta";
            this.lblValorDieta.Size = new System.Drawing.Size(45, 18);
            this.lblValorDieta.TabIndex = 10;
            this.lblValorDieta.Text = "label7";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(59, 263);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimparValores
            // 
            this.btnLimparValores.Location = new System.Drawing.Point(160, 263);
            this.btnLimparValores.Name = "btnLimparValores";
            this.btnLimparValores.Size = new System.Drawing.Size(75, 23);
            this.btnLimparValores.TabIndex = 12;
            this.btnLimparValores.Text = "Limpar";
            this.btnLimparValores.UseVisualStyleBackColor = true;
            this.btnLimparValores.Click += new System.EventHandler(this.btnLimparValores_Click);
            // 
            // lblPagamentoDia
            // 
            this.lblPagamentoDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPagamentoDia.Location = new System.Drawing.Point(191, 391);
            this.lblPagamentoDia.Name = "lblPagamentoDia";
            this.lblPagamentoDia.Size = new System.Drawing.Size(44, 20);
            this.lblPagamentoDia.TabIndex = 15;
            this.lblPagamentoDia.Text = "label8";
            // 
            // lblSinal
            // 
            this.lblSinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSinal.Location = new System.Drawing.Point(191, 365);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(44, 20);
            this.lblSinal.TabIndex = 14;
            this.lblSinal.Text = "label9";
            // 
            // lblPrecoTotal
            // 
            this.lblPrecoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrecoTotal.Location = new System.Drawing.Point(191, 339);
            this.lblPrecoTotal.Name = "lblPrecoTotal";
            this.lblPrecoTotal.Size = new System.Drawing.Size(44, 20);
            this.lblPrecoTotal.TabIndex = 13;
            this.lblPrecoTotal.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Pagamento no Dia";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 366);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Sinal da Reserva";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(56, 340);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Preço Total";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(139, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Qta.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(212, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Valor";
            // 
            // ntfMyNotify
            // 
            this.ntfMyNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfMyNotify.Icon")));
            this.ntfMyNotify.Text = "notifyIcon1";
            this.ntfMyNotify.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 438);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblPagamentoDia);
            this.Controls.Add(this.lblSinal);
            this.Controls.Add(this.lblPrecoTotal);
            this.Controls.Add(this.btnLimparValores);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblValorDieta);
            this.Controls.Add(this.lblValorCrianca);
            this.Controls.Add(this.lblValorAdulto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudDieta);
            this.Controls.Add(this.nudCriancas);
            this.Controls.Add(this.nudAdultos);
            this.Controls.Add(this.cboEmenta);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ementa do Restaurante";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCriancas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDieta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEmenta;
        private System.Windows.Forms.NumericUpDown nudAdultos;
        private System.Windows.Forms.NumericUpDown nudCriancas;
        private System.Windows.Forms.NumericUpDown nudDieta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblValorAdulto;
        private System.Windows.Forms.Label lblValorCrianca;
        private System.Windows.Forms.Label lblValorDieta;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimparValores;
        private System.Windows.Forms.Label lblPagamentoDia;
        private System.Windows.Forms.Label lblSinal;
        private System.Windows.Forms.Label lblPrecoTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NotifyIcon ntfMyNotify;
    }
}

