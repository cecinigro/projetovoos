namespace CeciliaNigro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.GroupCaptura = new System.Windows.Forms.GroupBox();
            this.radioNao = new System.Windows.Forms.RadioButton();
            this.radioSim = new System.Windows.Forms.RadioButton();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.GridDados = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.GroupCaptura.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtData);
            this.panel1.Controls.Add(this.GroupCaptura);
            this.panel1.Controls.Add(this.txtNivel);
            this.panel1.Controls.Add(this.txtDistancia);
            this.panel1.Controls.Add(this.txtCusto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Location = new System.Drawing.Point(410, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 292);
            this.panel1.TabIndex = 0;
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(113, 18);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(192, 20);
            this.dtData.TabIndex = 12;
            this.dtData.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // GroupCaptura
            // 
            this.GroupCaptura.Controls.Add(this.radioNao);
            this.GroupCaptura.Controls.Add(this.radioSim);
            this.GroupCaptura.Location = new System.Drawing.Point(19, 122);
            this.GroupCaptura.Name = "GroupCaptura";
            this.GroupCaptura.Size = new System.Drawing.Size(200, 39);
            this.GroupCaptura.TabIndex = 11;
            this.GroupCaptura.TabStop = false;
            this.GroupCaptura.Text = "Captura";
            // 
            // radioNao
            // 
            this.radioNao.AutoSize = true;
            this.radioNao.Location = new System.Drawing.Point(94, 16);
            this.radioNao.Name = "radioNao";
            this.radioNao.Size = new System.Drawing.Size(33, 17);
            this.radioNao.TabIndex = 1;
            this.radioNao.TabStop = true;
            this.radioNao.Text = "N";
            this.radioNao.UseVisualStyleBackColor = true;
            // 
            // radioSim
            // 
            this.radioSim.AutoSize = true;
            this.radioSim.Location = new System.Drawing.Point(3, 16);
            this.radioSim.Name = "radioSim";
            this.radioSim.Size = new System.Drawing.Size(32, 17);
            this.radioSim.TabIndex = 0;
            this.radioSim.TabStop = true;
            this.radioSim.Text = "S";
            this.radioSim.UseVisualStyleBackColor = true;
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(113, 170);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(192, 20);
            this.txtNivel.TabIndex = 10;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(113, 96);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(192, 20);
            this.txtDistancia.TabIndex = 9;
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(113, 60);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(192, 20);
            this.txtCusto.TabIndex = 8;
            this.txtCusto.TextChanged += new System.EventHandler(this.txtCusto_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nivel dor";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Distancia";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Custo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(196, 242);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(47, 242);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExcluir);
            this.panel2.Controls.Add(this.btnIncluir);
            this.panel2.Location = new System.Drawing.Point(410, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 46);
            this.panel2.TabIndex = 1;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(113, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(19, 12);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // GridDados
            // 
            this.GridDados.AllowUserToAddRows = false;
            this.GridDados.AllowUserToDeleteRows = false;
            this.GridDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDados.Location = new System.Drawing.Point(12, 12);
            this.GridDados.MultiSelect = false;
            this.GridDados.Name = "GridDados";
            this.GridDados.ReadOnly = true;
            this.GridDados.RowHeadersVisible = false;
            this.GridDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridDados.Size = new System.Drawing.Size(392, 344);
            this.GridDados.TabIndex = 2;
            this.GridDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDados_CellContentClick);
            this.GridDados.SelectionChanged += new System.EventHandler(this.GridDados_SelectionChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(163, 177);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 2;
            this.txtID.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 368);
            this.Controls.Add(this.GridDados);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "ACME FLIGHT MANAGER";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GroupCaptura.ResumeLayout(false);
            this.GroupCaptura.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.GroupBox GroupCaptura;
        private System.Windows.Forms.RadioButton radioNao;
        private System.Windows.Forms.RadioButton radioSim;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.DataGridView GridDados;
        private System.Windows.Forms.TextBox txtID;
    }
}

