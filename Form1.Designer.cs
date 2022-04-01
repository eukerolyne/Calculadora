namespace Calculadora
{
    partial class form_Caluladora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Caluladora));
            this.txt_Numprimeiro = new System.Windows.Forms.Label();
            this.txt_NumSegundo = new System.Windows.Forms.Label();
            this.txt_Num1 = new System.Windows.Forms.TextBox();
            this.txt_Num2 = new System.Windows.Forms.TextBox();
            this.btn_Soma = new System.Windows.Forms.Button();
            this.btn_Sub = new System.Windows.Forms.Button();
            this.btn_Multi = new System.Windows.Forms.Button();
            this.btn_Dividir = new System.Windows.Forms.Button();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Numprimeiro
            // 
            this.txt_Numprimeiro.AutoSize = true;
            this.txt_Numprimeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Numprimeiro.Location = new System.Drawing.Point(62, 74);
            this.txt_Numprimeiro.Name = "txt_Numprimeiro";
            this.txt_Numprimeiro.Size = new System.Drawing.Size(84, 20);
            this.txt_Numprimeiro.TabIndex = 0;
            this.txt_Numprimeiro.Text = "1º Número";
            // 
            // txt_NumSegundo
            // 
            this.txt_NumSegundo.AutoSize = true;
            this.txt_NumSegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumSegundo.Location = new System.Drawing.Point(202, 74);
            this.txt_NumSegundo.Name = "txt_NumSegundo";
            this.txt_NumSegundo.Size = new System.Drawing.Size(84, 20);
            this.txt_NumSegundo.TabIndex = 1;
            this.txt_NumSegundo.Text = "2º Número";
            // 
            // txt_Num1
            // 
            this.txt_Num1.Location = new System.Drawing.Point(57, 106);
            this.txt_Num1.Name = "txt_Num1";
            this.txt_Num1.Size = new System.Drawing.Size(100, 20);
            this.txt_Num1.TabIndex = 2;
            // 
            // txt_Num2
            // 
            this.txt_Num2.Location = new System.Drawing.Point(195, 106);
            this.txt_Num2.Name = "txt_Num2";
            this.txt_Num2.Size = new System.Drawing.Size(100, 20);
            this.txt_Num2.TabIndex = 3;
            // 
            // btn_Soma
            // 
            this.btn_Soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Soma.Location = new System.Drawing.Point(81, 175);
            this.btn_Soma.Name = "btn_Soma";
            this.btn_Soma.Size = new System.Drawing.Size(91, 32);
            this.btn_Soma.TabIndex = 4;
            this.btn_Soma.Text = "+";
            this.btn_Soma.UseVisualStyleBackColor = true;
            this.btn_Soma.Click += new System.EventHandler(this.btn_Soma_Click);
            // 
            // btn_Sub
            // 
            this.btn_Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sub.Location = new System.Drawing.Point(178, 175);
            this.btn_Sub.Name = "btn_Sub";
            this.btn_Sub.Size = new System.Drawing.Size(91, 32);
            this.btn_Sub.TabIndex = 5;
            this.btn_Sub.Text = "-";
            this.btn_Sub.UseVisualStyleBackColor = true;
            this.btn_Sub.Click += new System.EventHandler(this.btn_Sub_Click);
            // 
            // btn_Multi
            // 
            this.btn_Multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Multi.Location = new System.Drawing.Point(81, 213);
            this.btn_Multi.Name = "btn_Multi";
            this.btn_Multi.Size = new System.Drawing.Size(91, 32);
            this.btn_Multi.TabIndex = 6;
            this.btn_Multi.Text = "x";
            this.btn_Multi.UseVisualStyleBackColor = true;
            this.btn_Multi.Click += new System.EventHandler(this.btn_Multi_Click);
            // 
            // btn_Dividir
            // 
            this.btn_Dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dividir.Location = new System.Drawing.Point(178, 213);
            this.btn_Dividir.Name = "btn_Dividir";
            this.btn_Dividir.Size = new System.Drawing.Size(91, 32);
            this.btn_Dividir.TabIndex = 7;
            this.btn_Dividir.Text = "/";
            this.btn_Dividir.UseVisualStyleBackColor = true;
            this.btn_Dividir.Click += new System.EventHandler(this.btn_Dividir_Click);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.BackColor = System.Drawing.Color.LightGreen;
            this.lbl_Resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.Location = new System.Drawing.Point(122, 319);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(90, 26);
            this.lbl_Resultado.TabIndex = 8;
            this.lbl_Resultado.Text = "Resposta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Resultado:";
            // 
            // form_Caluladora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(349, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.btn_Dividir);
            this.Controls.Add(this.btn_Multi);
            this.Controls.Add(this.btn_Sub);
            this.Controls.Add(this.btn_Soma);
            this.Controls.Add(this.txt_Num2);
            this.Controls.Add(this.txt_Num1);
            this.Controls.Add(this.txt_NumSegundo);
            this.Controls.Add(this.txt_Numprimeiro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_Caluladora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_Numprimeiro;
        private System.Windows.Forms.Label txt_NumSegundo;
        private System.Windows.Forms.TextBox txt_Num1;
        private System.Windows.Forms.TextBox txt_Num2;
        private System.Windows.Forms.Button btn_Soma;
        private System.Windows.Forms.Button btn_Sub;
        private System.Windows.Forms.Button btn_Multi;
        private System.Windows.Forms.Button btn_Dividir;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Label label2;
    }
}

