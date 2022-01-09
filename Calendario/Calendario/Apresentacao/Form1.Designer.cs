namespace Calendario
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
            this.diaContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.lblSegunda = new System.Windows.Forms.Label();
            this.lblTerca = new System.Windows.Forms.Label();
            this.lblQuinta = new System.Windows.Forms.Label();
            this.lblQuarta = new System.Windows.Forms.Label();
            this.lblSabado = new System.Windows.Forms.Label();
            this.lblSexta = new System.Windows.Forms.Label();
            this.lblDomingo = new System.Windows.Forms.Label();
            this.lbMesAno = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // diaContainer
            // 
            this.diaContainer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.diaContainer.Location = new System.Drawing.Point(79, 81);
            this.diaContainer.Name = "diaContainer";
            this.diaContainer.Size = new System.Drawing.Size(954, 680);
            this.diaContainer.TabIndex = 0;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(1049, 326);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(77, 30);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(1049, 362);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(77, 32);
            this.btnProximo.TabIndex = 2;
            this.btnProximo.Text = "Proximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click_1);
            // 
            // lblSegunda
            // 
            this.lblSegunda.AutoSize = true;
            this.lblSegunda.BackColor = System.Drawing.SystemColors.Window;
            this.lblSegunda.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegunda.Location = new System.Drawing.Point(213, 48);
            this.lblSegunda.Name = "lblSegunda";
            this.lblSegunda.Size = new System.Drawing.Size(126, 19);
            this.lblSegunda.TabIndex = 3;
            this.lblSegunda.Text = "Segunda-Feira";
            // 
            // lblTerca
            // 
            this.lblTerca.AutoSize = true;
            this.lblTerca.BackColor = System.Drawing.SystemColors.Window;
            this.lblTerca.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerca.Location = new System.Drawing.Point(363, 48);
            this.lblTerca.Name = "lblTerca";
            this.lblTerca.Size = new System.Drawing.Size(108, 19);
            this.lblTerca.TabIndex = 4;
            this.lblTerca.Text = "Terça-Feira";
            // 
            // lblQuinta
            // 
            this.lblQuinta.AutoSize = true;
            this.lblQuinta.BackColor = System.Drawing.SystemColors.Window;
            this.lblQuinta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuinta.Location = new System.Drawing.Point(625, 48);
            this.lblQuinta.Name = "lblQuinta";
            this.lblQuinta.Size = new System.Drawing.Size(117, 19);
            this.lblQuinta.TabIndex = 6;
            this.lblQuinta.Text = "Quinta-Feira";
            // 
            // lblQuarta
            // 
            this.lblQuarta.AutoSize = true;
            this.lblQuarta.BackColor = System.Drawing.SystemColors.Window;
            this.lblQuarta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuarta.Location = new System.Drawing.Point(489, 48);
            this.lblQuarta.Name = "lblQuarta";
            this.lblQuarta.Size = new System.Drawing.Size(117, 19);
            this.lblQuarta.TabIndex = 5;
            this.lblQuarta.Text = "Quarta-Feira";
            // 
            // lblSabado
            // 
            this.lblSabado.AutoSize = true;
            this.lblSabado.BackColor = System.Drawing.SystemColors.Window;
            this.lblSabado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabado.Location = new System.Drawing.Point(929, 48);
            this.lblSabado.Name = "lblSabado";
            this.lblSabado.Size = new System.Drawing.Size(63, 19);
            this.lblSabado.TabIndex = 8;
            this.lblSabado.Text = "Sabado";
            // 
            // lblSexta
            // 
            this.lblSexta.AutoSize = true;
            this.lblSexta.BackColor = System.Drawing.SystemColors.Window;
            this.lblSexta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexta.Location = new System.Drawing.Point(771, 48);
            this.lblSexta.Name = "lblSexta";
            this.lblSexta.Size = new System.Drawing.Size(108, 19);
            this.lblSexta.TabIndex = 7;
            this.lblSexta.Text = "Sexta-Feira";
            // 
            // lblDomingo
            // 
            this.lblDomingo.AutoSize = true;
            this.lblDomingo.BackColor = System.Drawing.SystemColors.Window;
            this.lblDomingo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomingo.Location = new System.Drawing.Point(103, 48);
            this.lblDomingo.Name = "lblDomingo";
            this.lblDomingo.Size = new System.Drawing.Size(72, 19);
            this.lblDomingo.TabIndex = 9;
            this.lblDomingo.Text = "Domingo";
            this.lblDomingo.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbMesAno
            // 
            this.lbMesAno.AutoSize = true;
            this.lbMesAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMesAno.Location = new System.Drawing.Point(489, 9);
            this.lbMesAno.Name = "lbMesAno";
            this.lbMesAno.Size = new System.Drawing.Size(121, 25);
            this.lbMesAno.TabIndex = 0;
            this.lbMesAno.Text = "MES   ANO";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1049, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 786);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbMesAno);
            this.Controls.Add(this.lblSabado);
            this.Controls.Add(this.lblSexta);
            this.Controls.Add(this.lblQuinta);
            this.Controls.Add(this.lblQuarta);
            this.Controls.Add(this.lblTerca);
            this.Controls.Add(this.lblSegunda);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.lblDomingo);
            this.Controls.Add(this.diaContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel diaContainer;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Label lblSegunda;
        private System.Windows.Forms.Label lblTerca;
        private System.Windows.Forms.Label lblQuinta;
        private System.Windows.Forms.Label lblQuarta;
        private System.Windows.Forms.Label lblSabado;
        private System.Windows.Forms.Label lblSexta;
        private System.Windows.Forms.Label lblDomingo;
        private System.Windows.Forms.Label lbMesAno;
        private System.Windows.Forms.Button button1;
    }
}

