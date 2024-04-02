namespace Loja_Jogos
{
    partial class Cadastro_Vendas
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewPRODUTOS = new System.Windows.Forms.DataGridView();
            this.buttonADICIONAR = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonCONCLUIR = new System.Windows.Forms.Button();
            this.buttonCANCELAR = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelUNIDADE = new System.Windows.Forms.Label();
            this.textBoxUNIDADE = new System.Windows.Forms.TextBox();
            this.labelTOTAL = new System.Windows.Forms.Label();
            this.textBoxTOTAL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPRODUTOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nova Venda";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(654, 185);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dataGridViewPRODUTOS
            // 
            this.dataGridViewPRODUTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPRODUTOS.Location = new System.Drawing.Point(552, 84);
            this.dataGridViewPRODUTOS.Name = "dataGridViewPRODUTOS";
            this.dataGridViewPRODUTOS.ReadOnly = true;
            this.dataGridViewPRODUTOS.Size = new System.Drawing.Size(350, 329);
            this.dataGridViewPRODUTOS.TabIndex = 10;
            this.dataGridViewPRODUTOS.DoubleClick += new System.EventHandler(this.dataGridViewPRODUTOS_DoubleClick);
            // 
            // buttonADICIONAR
            // 
            this.buttonADICIONAR.Location = new System.Drawing.Point(13, 360);
            this.buttonADICIONAR.Name = "buttonADICIONAR";
            this.buttonADICIONAR.Size = new System.Drawing.Size(154, 53);
            this.buttonADICIONAR.TabIndex = 13;
            this.buttonADICIONAR.Text = "Adicionar";
            this.buttonADICIONAR.UseVisualStyleBackColor = true;
            this.buttonADICIONAR.Click += new System.EventHandler(this.buttonADICIONAR_Click_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(115, 84);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Quantidade:";
            // 
            // buttonCONCLUIR
            // 
            this.buttonCONCLUIR.Location = new System.Drawing.Point(173, 360);
            this.buttonCONCLUIR.Name = "buttonCONCLUIR";
            this.buttonCONCLUIR.Size = new System.Drawing.Size(154, 53);
            this.buttonCONCLUIR.TabIndex = 17;
            this.buttonCONCLUIR.Text = "Concluir Compra";
            this.buttonCONCLUIR.UseVisualStyleBackColor = true;
            this.buttonCONCLUIR.Click += new System.EventHandler(this.buttonCONCLUIR_Click_1);
            // 
            // buttonCANCELAR
            // 
            this.buttonCANCELAR.Location = new System.Drawing.Point(336, 360);
            this.buttonCANCELAR.Name = "buttonCANCELAR";
            this.buttonCANCELAR.Size = new System.Drawing.Size(152, 53);
            this.buttonCANCELAR.TabIndex = 18;
            this.buttonCANCELAR.Text = "Cancelar";
            this.buttonCANCELAR.UseVisualStyleBackColor = true;
            this.buttonCANCELAR.Click += new System.EventHandler(this.buttonCANCELAR_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(547, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Lista_Compras";
            // 
            // labelUNIDADE
            // 
            this.labelUNIDADE.AutoSize = true;
            this.labelUNIDADE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUNIDADE.Location = new System.Drawing.Point(13, 121);
            this.labelUNIDADE.Name = "labelUNIDADE";
            this.labelUNIDADE.Size = new System.Drawing.Size(119, 20);
            this.labelUNIDADE.TabIndex = 20;
            this.labelUNIDADE.Text = "Valor_Unidade:";
            // 
            // textBoxUNIDADE
            // 
            this.textBoxUNIDADE.Location = new System.Drawing.Point(138, 121);
            this.textBoxUNIDADE.Name = "textBoxUNIDADE";
            this.textBoxUNIDADE.ReadOnly = true;
            this.textBoxUNIDADE.Size = new System.Drawing.Size(138, 20);
            this.textBoxUNIDADE.TabIndex = 21;
            // 
            // labelTOTAL
            // 
            this.labelTOTAL.AutoSize = true;
            this.labelTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTOTAL.Location = new System.Drawing.Point(718, 53);
            this.labelTOTAL.Name = "labelTOTAL";
            this.labelTOTAL.Size = new System.Drawing.Size(56, 24);
            this.labelTOTAL.TabIndex = 22;
            this.labelTOTAL.Text = "Total:";
            // 
            // textBoxTOTAL
            // 
            this.textBoxTOTAL.Location = new System.Drawing.Point(780, 57);
            this.textBoxTOTAL.Name = "textBoxTOTAL";
            this.textBoxTOTAL.ReadOnly = true;
            this.textBoxTOTAL.Size = new System.Drawing.Size(122, 20);
            this.textBoxTOTAL.TabIndex = 23;
            // 
            // Cadastro_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 420);
            this.Controls.Add(this.textBoxTOTAL);
            this.Controls.Add(this.labelTOTAL);
            this.Controls.Add(this.textBoxUNIDADE);
            this.Controls.Add(this.labelUNIDADE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCANCELAR);
            this.Controls.Add(this.buttonCONCLUIR);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonADICIONAR);
            this.Controls.Add(this.dataGridViewPRODUTOS);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro_Vendas";
            this.Text = "Cadastro de Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPRODUTOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridViewPRODUTOS;
        private System.Windows.Forms.Button buttonADICIONAR;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonCONCLUIR;
        private System.Windows.Forms.Button buttonCANCELAR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelUNIDADE;
        private System.Windows.Forms.TextBox textBoxUNIDADE;
        private System.Windows.Forms.Label labelTOTAL;
        private System.Windows.Forms.TextBox textBoxTOTAL;
    }
}

