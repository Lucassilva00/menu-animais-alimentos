namespace Trabalho_pavao
{
    partial class delalimentos
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btapagar = new System.Windows.Forms.Button();
            this.txtalimento = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.lblalimenot = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btpesquisar = new System.Windows.Forms.Button();
            this.txtcodalimento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btcancelar);
            this.groupBox2.Controls.Add(this.btapagar);
            this.groupBox2.Controls.Add(this.txtalimento);
            this.groupBox2.Controls.Add(this.txtdescricao);
            this.groupBox2.Controls.Add(this.lblalimenot);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(131, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 208);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Apagar";
            // 
            // btcancelar
            // 
            this.btcancelar.Location = new System.Drawing.Point(563, 123);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(131, 50);
            this.btcancelar.TabIndex = 6;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            this.btcancelar.Click += new System.EventHandler(this.Btcancelar_Click);
            // 
            // btapagar
            // 
            this.btapagar.Location = new System.Drawing.Point(563, 62);
            this.btapagar.Name = "btapagar";
            this.btapagar.Size = new System.Drawing.Size(131, 50);
            this.btapagar.TabIndex = 7;
            this.btapagar.Text = "Apagar";
            this.btapagar.UseVisualStyleBackColor = true;
            this.btapagar.Click += new System.EventHandler(this.Btapagar_Click);
            // 
            // txtalimento
            // 
            this.txtalimento.Location = new System.Drawing.Point(183, 62);
            this.txtalimento.Name = "txtalimento";
            this.txtalimento.Size = new System.Drawing.Size(333, 29);
            this.txtalimento.TabIndex = 1;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(183, 123);
            this.txtdescricao.Multiline = true;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(333, 59);
            this.txtdescricao.TabIndex = 2;
            // 
            // lblalimenot
            // 
            this.lblalimenot.AutoSize = true;
            this.lblalimenot.Location = new System.Drawing.Point(41, 65);
            this.lblalimenot.Name = "lblalimenot";
            this.lblalimenot.Size = new System.Drawing.Size(98, 24);
            this.lblalimenot.TabIndex = 2;
            this.lblalimenot.Text = "Alimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descrição:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btpesquisar);
            this.groupBox1.Controls.Add(this.txtcodalimento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(131, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // btpesquisar
            // 
            this.btpesquisar.Location = new System.Drawing.Point(563, 36);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(131, 50);
            this.btpesquisar.TabIndex = 5;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = true;
            this.btpesquisar.Click += new System.EventHandler(this.Btpesquisar_Click);
            // 
            // txtcodalimento
            // 
            this.txtcodalimento.Location = new System.Drawing.Point(183, 46);
            this.txtcodalimento.Name = "txtcodalimento";
            this.txtcodalimento.Size = new System.Drawing.Size(333, 29);
            this.txtcodalimento.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cód Alimento:";
            // 
            // delalimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 692);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "delalimentos";
            this.Text = "delalimentos";
            this.Load += new System.EventHandler(this.Delalimentos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btapagar;
        private System.Windows.Forms.TextBox txtalimento;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label lblalimenot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.TextBox txtcodalimento;
        private System.Windows.Forms.Label label1;
    }
}