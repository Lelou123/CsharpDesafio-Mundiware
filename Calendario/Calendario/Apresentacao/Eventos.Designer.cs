namespace Calendario.Apresentacao
{
    partial class Eventos
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
            this.txbData = new System.Windows.Forms.TextBox();
            this.txbEvento = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblEvento = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbData
            // 
            this.txbData.Location = new System.Drawing.Point(118, 104);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(229, 20);
            this.txbData.TabIndex = 0;
            // 
            // txbEvento
            // 
            this.txbEvento.Location = new System.Drawing.Point(118, 201);
            this.txbEvento.Name = "txbEvento";
            this.txbEvento.Size = new System.Drawing.Size(229, 20);
            this.txbEvento.TabIndex = 1;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(115, 66);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(35, 15);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data";
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvento.Location = new System.Drawing.Point(115, 164);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(63, 15);
            this.lblEvento.TabIndex = 3;
            this.lblEvento.Text = "Evento: ";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(189, 273);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 359);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblEvento);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txbEvento);
            this.Controls.Add(this.txbData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Eventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.Eventos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbData;
        private System.Windows.Forms.TextBox txbEvento;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.Button btnSalvar;
    }
}