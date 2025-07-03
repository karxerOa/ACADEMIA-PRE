namespace ACADEMIA_PRE.Paneles
{
    partial class PanelInicioAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMatriculados = new System.Windows.Forms.Label();
            this.lblRegistrdos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL DE ESTUDIANTES REGISTRADOS: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(375, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TOTAL DE ESTUDIANTES MATRICULADOS: ";
            // 
            // lbMatriculados
            // 
            this.lbMatriculados.AutoSize = true;
            this.lbMatriculados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbMatriculados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatriculados.Location = new System.Drawing.Point(519, 172);
            this.lbMatriculados.Name = "lbMatriculados";
            this.lbMatriculados.Size = new System.Drawing.Size(30, 25);
            this.lbMatriculados.TabIndex = 2;
            this.lbMatriculados.Text = "...";
            this.lbMatriculados.Click += new System.EventHandler(this.lbMatriculados_Click);
            // 
            // lblRegistrdos
            // 
            this.lblRegistrdos.AutoSize = true;
            this.lblRegistrdos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblRegistrdos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrdos.Location = new System.Drawing.Point(151, 172);
            this.lblRegistrdos.Name = "lblRegistrdos";
            this.lblRegistrdos.Size = new System.Drawing.Size(30, 25);
            this.lblRegistrdos.TabIndex = 3;
            this.lblRegistrdos.Text = "...";
            this.lblRegistrdos.Click += new System.EventHandler(this.lblRegistrdos_Click);
            // 
            // PanelInicioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 396);
            this.Controls.Add(this.lblRegistrdos);
            this.Controls.Add(this.lbMatriculados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PanelInicioAdmin";
            this.Text = "PanelInicioAdmin";
            this.Load += new System.EventHandler(this.PanelInicioAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMatriculados;
        private System.Windows.Forms.Label lblRegistrdos;
    }
}