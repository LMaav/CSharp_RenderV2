namespace AutoRenderizador
{
    partial class Form1
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
            this.btn_Criar = new System.Windows.Forms.Button();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Preco = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Preco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Criar
            // 
            this.btn_Criar.BackColor = System.Drawing.Color.Snow;
            this.btn_Criar.FlatAppearance.BorderSize = 0;
            this.btn_Criar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Criar.Location = new System.Drawing.Point(288, 48);
            this.btn_Criar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Criar.Name = "btn_Criar";
            this.btn_Criar.Size = new System.Drawing.Size(114, 80);
            this.btn_Criar.TabIndex = 2;
            this.btn_Criar.Text = "Criar";
            this.btn_Criar.UseVisualStyleBackColor = false;
            this.btn_Criar.Click += new System.EventHandler(this.btn_Criar_Click);
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(29, 48);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(51, 20);
            this.lbl_Nome.TabIndex = 1;
            this.lbl_Nome.Text = "Nome";
            // 
            // lbl_Preco
            // 
            this.lbl_Preco.AutoSize = true;
            this.lbl_Preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Preco.Location = new System.Drawing.Point(29, 105);
            this.lbl_Preco.Name = "lbl_Preco";
            this.lbl_Preco.Size = new System.Drawing.Size(50, 20);
            this.lbl_Preco.TabIndex = 1;
            this.lbl_Preco.Text = "Preço";
            // 
            // txt_Nome
            // 
            this.txt_Nome.BackColor = System.Drawing.Color.Snow;
            this.txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(143, 48);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(125, 26);
            this.txt_Nome.TabIndex = 0;
            // 
            // txt_Preco
            // 
            this.txt_Preco.BackColor = System.Drawing.Color.Snow;
            this.txt_Preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Preco.Location = new System.Drawing.Point(143, 102);
            this.txt_Preco.Name = "txt_Preco";
            this.txt_Preco.Size = new System.Drawing.Size(125, 26);
            this.txt_Preco.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(445, 485);
            this.Controls.Add(this.txt_Preco);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Preco);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.btn_Criar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Criar;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Preco;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Preco;
    }
}

