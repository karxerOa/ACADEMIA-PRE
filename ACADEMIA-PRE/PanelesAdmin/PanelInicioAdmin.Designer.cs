namespace ACADEMIA_PRE.PanelesAdmin
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBESTUDIANTESregsitrados = new System.Windows.Forms.Label();
            this.lblTotalMatriculados = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotalMatriculados);
            this.panel2.Location = new System.Drawing.Point(407, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 257);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL DE ESTUDIANTES REGISTRADOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "TOTAL DE ESTUDIANTES MATRICULADOS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LBESTUDIANTESregsitrados);
            this.panel1.Location = new System.Drawing.Point(81, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 257);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LBESTUDIANTESregsitrados
            // 
            this.LBESTUDIANTESregsitrados.AutoSize = true;
            this.LBESTUDIANTESregsitrados.Font = new System.Drawing.Font("Modern No. 20", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBESTUDIANTESregsitrados.Location = new System.Drawing.Point(47, 74);
            this.LBESTUDIANTESregsitrados.Name = "LBESTUDIANTESregsitrados";
            this.LBESTUDIANTESregsitrados.Size = new System.Drawing.Size(87, 98);
            this.LBESTUDIANTESregsitrados.TabIndex = 0;
            this.LBESTUDIANTESregsitrados.Text = "0";
            // 
            // lblTotalMatriculados
            // 
            this.lblTotalMatriculados.AutoSize = true;
            this.lblTotalMatriculados.Font = new System.Drawing.Font("Modern No. 20", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMatriculados.Location = new System.Drawing.Point(57, 74);
            this.lblTotalMatriculados.Name = "lblTotalMatriculados";
            this.lblTotalMatriculados.Size = new System.Drawing.Size(87, 98);
            this.lblTotalMatriculados.TabIndex = 1;
            this.lblTotalMatriculados.Text = "0";
            // 
            // PanelInicioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(699, 395);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "PanelInicioAdmin";
            this.Text = "PanelInicioAdmin";
            this.Load += new System.EventHandler(this.PanelInicioAdmin_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalMatriculados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBESTUDIANTESregsitrados;
    }
}