namespace Trab_Interdiciplinar.Inicio
{
    public partial class TelaPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.btn_ListaCarro = new System.Windows.Forms.Button();
            this.btn_CadastroCarro = new System.Windows.Forms.Button();
            this.btn_Planejamento = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Ajuda = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_ListaCarro
            // 
            this.btn_ListaCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ListaCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListaCarro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ListaCarro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ListaCarro.Location = new System.Drawing.Point(31, 142);
            this.btn_ListaCarro.Name = "btn_ListaCarro";
            this.btn_ListaCarro.Size = new System.Drawing.Size(170, 44);
            this.btn_ListaCarro.TabIndex = 0;
            this.btn_ListaCarro.Text = "LISTA DE CARROS";
            this.btn_ListaCarro.UseVisualStyleBackColor = true;
            this.btn_ListaCarro.Click += new System.EventHandler(this.btn_ListaCarro_Click);
            // 
            // btn_CadastroCarro
            // 
            this.btn_CadastroCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CadastroCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadastroCarro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CadastroCarro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CadastroCarro.Location = new System.Drawing.Point(31, 205);
            this.btn_CadastroCarro.Name = "btn_CadastroCarro";
            this.btn_CadastroCarro.Size = new System.Drawing.Size(170, 44);
            this.btn_CadastroCarro.TabIndex = 1;
            this.btn_CadastroCarro.Text = "CADASTRAR CARRO";
            this.btn_CadastroCarro.UseVisualStyleBackColor = true;
            this.btn_CadastroCarro.Click += new System.EventHandler(this.btn_CadastroCarro_Click);
            // 
            // btn_Planejamento
            // 
            this.btn_Planejamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Planejamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Planejamento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Planejamento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Planejamento.Location = new System.Drawing.Point(31, 268);
            this.btn_Planejamento.Name = "btn_Planejamento";
            this.btn_Planejamento.Size = new System.Drawing.Size(170, 44);
            this.btn_Planejamento.TabIndex = 2;
            this.btn_Planejamento.Text = "PLANEJAMENTO";
            this.btn_Planejamento.UseVisualStyleBackColor = true;
            this.btn_Planejamento.Click += new System.EventHandler(this.btn_Planejamento_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sair.FlatAppearance.BorderSize = 0;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Sair.Location = new System.Drawing.Point(541, 43);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(88, 32);
            this.btn_Sair.TabIndex = 3;
            this.btn_Sair.Text = "SAIR";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Ajuda
            // 
            this.btn_Ajuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ajuda.FlatAppearance.BorderSize = 0;
            this.btn_Ajuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ajuda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Ajuda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Ajuda.Location = new System.Drawing.Point(635, 46);
            this.btn_Ajuda.Name = "btn_Ajuda";
            this.btn_Ajuda.Size = new System.Drawing.Size(75, 26);
            this.btn_Ajuda.TabIndex = 4;
            this.btn_Ajuda.Text = "AJUDA";
            this.btn_Ajuda.UseVisualStyleBackColor = true;
            this.btn_Ajuda.Click += new System.EventHandler(this.btn_Ajuda_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Ajuda);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Planejamento);
            this.Controls.Add(this.btn_CadastroCarro);
            this.Controls.Add(this.btn_ListaCarro);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ListaCarro;
        private System.Windows.Forms.Button btn_CadastroCarro;
        private System.Windows.Forms.Button btn_Planejamento;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Ajuda;
        private System.Windows.Forms.Timer timer1;
    }
}