namespace Trab_Interdiciplinar.Menu
{
    partial class Planejamento
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
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Ajuda = new System.Windows.Forms.Button();
            this.btnAtualizarDados = new System.Windows.Forms.Button();
            this.dgvListaDeCarros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sair
            // 
            this.btn_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Sair.Location = new System.Drawing.Point(704, 403);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(84, 35);
            this.btn_Sair.TabIndex = 15;
            this.btn_Sair.Text = "SAIR";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click_1);
            // 
            // btn_Ajuda
            // 
            this.btn_Ajuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ajuda.FlatAppearance.BorderSize = 0;
            this.btn_Ajuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ajuda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Ajuda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Ajuda.Location = new System.Drawing.Point(704, 12);
            this.btn_Ajuda.Name = "btn_Ajuda";
            this.btn_Ajuda.Size = new System.Drawing.Size(84, 35);
            this.btn_Ajuda.TabIndex = 16;
            this.btn_Ajuda.Text = "AJUDA";
            this.btn_Ajuda.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarDados
            // 
            this.btnAtualizarDados.Location = new System.Drawing.Point(39, 403);
            this.btnAtualizarDados.Name = "btnAtualizarDados";
            this.btnAtualizarDados.Size = new System.Drawing.Size(103, 35);
            this.btnAtualizarDados.TabIndex = 18;
            this.btnAtualizarDados.Text = "Atualizar Dados";
            this.btnAtualizarDados.UseVisualStyleBackColor = true;
            this.btnAtualizarDados.Click += new System.EventHandler(this.btnAtualizarDados_Click);
            // 
            // dgvListaDeCarros
            // 
            this.dgvListaDeCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDeCarros.Location = new System.Drawing.Point(123, 52);
            this.dgvListaDeCarros.Name = "dgvListaDeCarros";
            this.dgvListaDeCarros.RowTemplate.Height = 25;
            this.dgvListaDeCarros.Size = new System.Drawing.Size(558, 311);
            this.dgvListaDeCarros.TabIndex = 19;
            this.dgvListaDeCarros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaDeCarros_CellContentClick);
            // 
            // Planejamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvListaDeCarros);
            this.Controls.Add(this.btnAtualizarDados);
            this.Controls.Add(this.btn_Ajuda);
            this.Controls.Add(this.btn_Sair);
            this.Name = "Planejamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planejamento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeCarros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Ajuda;
        private System.Windows.Forms.Button btnAtualizarDados;
        private System.Windows.Forms.DataGridView dgvListaDeCarros;
    }
}