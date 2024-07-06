namespace TDE_4
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
            btnAcessar = new Button();
            btnBuscar = new Button();
            btnExcluir = new Button();
            txtCPF = new TextBox();
            txtTelefone = new TextBox();
            txtNome = new TextBox();
            txtEndereço = new TextBox();
            dgvDados = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // btnAcessar
            // 
            btnAcessar.Location = new Point(277, 258);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(116, 38);
            btnAcessar.TabIndex = 0;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = true;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(235, 302);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(356, 302);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(235, 177);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(196, 23);
            txtCPF.TabIndex = 3;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(235, 128);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(196, 23);
            txtTelefone.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(235, 81);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(196, 23);
            txtNome.TabIndex = 5;
            // 
            // txtEndereço
            // 
            txtEndereço.Location = new Point(235, 229);
            txtEndereço.Name = "txtEndereço";
            txtEndereço.Size = new Size(196, 23);
            txtEndereço.TabIndex = 6;
            // 
            // dgvDados
            // 
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(446, 81);
            dgvDados.Name = "dgvDados";
            dgvDados.Size = new Size(240, 150);
            dgvDados.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 63);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 8;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 110);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(311, 159);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 10;
            label3.Text = "CPF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(311, 211);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 11;
            label4.Text = "Endereço";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDados);
            Controls.Add(txtEndereço);
            Controls.Add(txtNome);
            Controls.Add(txtTelefone);
            Controls.Add(txtCPF);
            Controls.Add(btnExcluir);
            Controls.Add(btnBuscar);
            Controls.Add(btnAcessar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcessar;
        private Button btnBuscar;
        private Button btnExcluir;
        private TextBox txtCPF;
        private TextBox txtTelefone;
        private TextBox txtNome;
        private TextBox txtEndereço;
        private DataGridView dgvDados;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
