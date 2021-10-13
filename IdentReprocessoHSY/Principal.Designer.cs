using System.Windows.Forms;
namespace IdentReprocessoHSY
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.boxDias1 = new System.Windows.Forms.TextBox();
            this.boxInicio = new System.Windows.Forms.MaskedTextBox();
            this.boxValidade1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.boxLote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label6 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.boxCobertura = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.boxAgregado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.boxAroma = new System.Windows.Forms.TextBox();
            this.boxPeso = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.boxLinha = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.boxFinal = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.boxValidade2 = new System.Windows.Forms.MaskedTextBox();
            this.boxDias2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.boxProduto = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.boxCopias = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.boxCodigo = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxDias1
            // 
            this.boxDias1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDias1.Location = new System.Drawing.Point(171, 273);
            this.boxDias1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boxDias1.MaxLength = 3;
            this.boxDias1.Name = "boxDias1";
            this.boxDias1.ReadOnly = true;
            this.boxDias1.Size = new System.Drawing.Size(20, 21);
            this.boxDias1.TabIndex = 11;
            // 
            // boxInicio
            // 
            this.boxInicio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxInicio.Location = new System.Drawing.Point(257, 211);
            this.boxInicio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boxInicio.Mask = "          00/00/0000      00:00";
            this.boxInicio.Name = "boxInicio";
            this.boxInicio.ReadOnly = true;
            this.boxInicio.Size = new System.Drawing.Size(184, 21);
            this.boxInicio.TabIndex = 8;
            this.boxInicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxInicio_KeyPress);
            // 
            // boxValidade1
            // 
            this.boxValidade1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxValidade1.Location = new System.Drawing.Point(89, 273);
            this.boxValidade1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boxValidade1.Mask = "00/00/0000";
            this.boxValidade1.Name = "boxValidade1";
            this.boxValidade1.ReadOnly = true;
            this.boxValidade1.Size = new System.Drawing.Size(76, 21);
            this.boxValidade1.TabIndex = 10;
            this.boxValidade1.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(20, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data e hora de início do abastecimento -";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpar.Location = new System.Drawing.Point(89, 310);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(0);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(93, 27);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // boxLote
            // 
            this.boxLote.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxLote.Location = new System.Drawing.Point(257, 178);
            this.boxLote.Name = "boxLote";
            this.boxLote.ReadOnly = true;
            this.boxLote.Size = new System.Drawing.Size(59, 21);
            this.boxLote.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lote -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dias";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 350);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(115, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "Desenvolvido por :  Allan de Abreu";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(291, 310);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(93, 27);
            this.btnImprimir.TabIndex = 16;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(191, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Produto -";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(40, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cobertura -";
            // 
            // boxCobertura
            // 
            this.boxCobertura.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCobertura.Location = new System.Drawing.Point(117, 149);
            this.boxCobertura.Name = "boxCobertura";
            this.boxCobertura.ReadOnly = true;
            this.boxCobertura.Size = new System.Drawing.Size(59, 21);
            this.boxCobertura.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(182, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Agregado -";
            // 
            // boxAgregado
            // 
            this.boxAgregado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxAgregado.Location = new System.Drawing.Point(257, 149);
            this.boxAgregado.Name = "boxAgregado";
            this.boxAgregado.ReadOnly = true;
            this.boxAgregado.Size = new System.Drawing.Size(59, 21);
            this.boxAgregado.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(322, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Aroma -";
            // 
            // boxAroma
            // 
            this.boxAroma.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxAroma.Location = new System.Drawing.Point(382, 149);
            this.boxAroma.Name = "boxAroma";
            this.boxAroma.ReadOnly = true;
            this.boxAroma.Size = new System.Drawing.Size(59, 21);
            this.boxAroma.TabIndex = 4;
            // 
            // boxPeso
            // 
            this.boxPeso.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPeso.Location = new System.Drawing.Point(382, 178);
            this.boxPeso.Name = "boxPeso";
            this.boxPeso.Size = new System.Drawing.Size(59, 21);
            this.boxPeso.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(333, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "Peso -";
            // 
            // boxLinha
            // 
            this.boxLinha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxLinha.Location = new System.Drawing.Point(117, 178);
            this.boxLinha.Name = "boxLinha";
            this.boxLinha.ReadOnly = true;
            this.boxLinha.Size = new System.Drawing.Size(59, 21);
            this.boxLinha.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(64, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Linha -";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(7, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(248, 15);
            this.label11.TabIndex = 31;
            this.label11.Text = "Data e hora de término do abastecimento -";
            // 
            // boxFinal
            // 
            this.boxFinal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxFinal.Location = new System.Drawing.Point(257, 242);
            this.boxFinal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boxFinal.Mask = "          00/00/0000      00:00";
            this.boxFinal.Name = "boxFinal";
            this.boxFinal.Size = new System.Drawing.Size(184, 21);
            this.boxFinal.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 15);
            this.label14.TabIndex = 34;
            this.label14.Text = "Validade -";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(416, 275);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 15);
            this.label15.TabIndex = 39;
            this.label15.Text = "Dias";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(239, 277);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 15);
            this.label16.TabIndex = 38;
            this.label16.Text = "Validade -";
            // 
            // boxValidade2
            // 
            this.boxValidade2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxValidade2.Location = new System.Drawing.Point(308, 272);
            this.boxValidade2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boxValidade2.Mask = "00/00/0000";
            this.boxValidade2.Name = "boxValidade2";
            this.boxValidade2.ReadOnly = true;
            this.boxValidade2.Size = new System.Drawing.Size(76, 21);
            this.boxValidade2.TabIndex = 12;
            this.boxValidade2.ValidatingType = typeof(System.DateTime);
            // 
            // boxDias2
            // 
            this.boxDias2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDias2.Location = new System.Drawing.Point(390, 272);
            this.boxDias2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boxDias2.MaxLength = 3;
            this.boxDias2.Name = "boxDias2";
            this.boxDias2.ReadOnly = true;
            this.boxDias2.Size = new System.Drawing.Size(20, 21);
            this.boxDias2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(127, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "IDENTIFICAÇÃO DE REPROCESSO";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(373, 347);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Versão 1.07  /  2021";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // boxProduto
            // 
            this.boxProduto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxProduto.Location = new System.Drawing.Point(257, 120);
            this.boxProduto.Name = "boxProduto";
            this.boxProduto.ReadOnly = true;
            this.boxProduto.Size = new System.Drawing.Size(184, 21);
            this.boxProduto.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(57, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 15);
            this.label17.TabIndex = 45;
            this.label17.Text = "Código -";
            // 
            // boxCopias
            // 
            this.boxCopias.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCopias.Location = new System.Drawing.Point(390, 312);
            this.boxCopias.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boxCopias.MaxLength = 3;
            this.boxCopias.Name = "boxCopias";
            this.boxCopias.Size = new System.Drawing.Size(20, 21);
            this.boxCopias.TabIndex = 17;
            this.boxCopias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(416, 315);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 15);
            this.label18.TabIndex = 47;
            this.label18.Text = "Cópias";
            // 
            // boxCodigo
            // 
            this.boxCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCodigo.Location = new System.Drawing.Point(117, 122);
            this.boxCodigo.Name = "boxCodigo";
            this.boxCodigo.Size = new System.Drawing.Size(59, 21);
            this.boxCodigo.TabIndex = 0;
            this.boxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxCodigo_KeyPress);
            // 
            // btnGerar
            // 
            this.btnGerar.Enabled = false;
            this.btnGerar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(190, 310);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(95, 27);
            this.btnGerar.TabIndex = 15;
            this.btnGerar.Text = "Gerar Validade";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(472, 363);
            this.Controls.Add(this.boxCodigo);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.boxCopias);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.boxProduto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.boxValidade2);
            this.Controls.Add(this.boxDias2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.boxFinal);
            this.Controls.Add(this.boxPeso);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.boxLinha);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.boxAroma);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.boxAgregado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.boxCobertura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxLote);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxValidade1);
            this.Controls.Add(this.boxInicio);
            this.Controls.Add(this.boxDias1);
            this.Controls.Add(this.label5);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identificação de Reprocesso";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxDias1;
        private System.Windows.Forms.MaskedTextBox boxInicio;
        private System.Windows.Forms.MaskedTextBox boxValidade1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox boxLote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boxCobertura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox boxAgregado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox boxAroma;
        private System.Windows.Forms.TextBox boxPeso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox boxLinha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox boxFinal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox boxValidade2;
        private System.Windows.Forms.TextBox boxDias2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private TextBox boxProduto;
        private Label label17;
        private TextBox boxCopias;
        private Label label18;
        private TextBox boxCodigo;
        private Button btnGerar;
    }
}

