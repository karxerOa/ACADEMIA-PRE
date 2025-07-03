namespace ACADEMIA_PRE.Paneles
{
    partial class PanelGestionEstudiante
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
            this.btnRegistrarEstu = new RJCodeAdvance.RJControls.RJButton();
            this.btnMatricularEstu = new RJCodeAdvance.RJControls.RJButton();
            this.btnAsistencias = new RJCodeAdvance.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // btnRegistrarEstu
            // 
            this.btnRegistrarEstu.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistrarEstu.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistrarEstu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRegistrarEstu.BorderRadius = 0;
            this.btnRegistrarEstu.BorderSize = 0;
            this.btnRegistrarEstu.FlatAppearance.BorderSize = 0;
            this.btnRegistrarEstu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarEstu.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEstu.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarEstu.Location = new System.Drawing.Point(72, 125);
            this.btnRegistrarEstu.Name = "btnRegistrarEstu";
            this.btnRegistrarEstu.Size = new System.Drawing.Size(227, 63);
            this.btnRegistrarEstu.TabIndex = 0;
            this.btnRegistrarEstu.Text = "Registrar estudiante";
            this.btnRegistrarEstu.TextColor = System.Drawing.Color.White;
            this.btnRegistrarEstu.UseVisualStyleBackColor = false;
            // 
            // btnMatricularEstu
            // 
            this.btnMatricularEstu.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMatricularEstu.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.btnMatricularEstu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMatricularEstu.BorderRadius = 0;
            this.btnMatricularEstu.BorderSize = 0;
            this.btnMatricularEstu.FlatAppearance.BorderSize = 0;
            this.btnMatricularEstu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatricularEstu.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatricularEstu.ForeColor = System.Drawing.Color.White;
            this.btnMatricularEstu.Location = new System.Drawing.Point(390, 125);
            this.btnMatricularEstu.Name = "btnMatricularEstu";
            this.btnMatricularEstu.Size = new System.Drawing.Size(227, 63);
            this.btnMatricularEstu.TabIndex = 1;
            this.btnMatricularEstu.Text = "Matricular estudiante";
            this.btnMatricularEstu.TextColor = System.Drawing.Color.White;
            this.btnMatricularEstu.UseVisualStyleBackColor = false;
            // 
            // btnAsistencias
            // 
            this.btnAsistencias.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAsistencias.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.btnAsistencias.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAsistencias.BorderRadius = 0;
            this.btnAsistencias.BorderSize = 0;
            this.btnAsistencias.FlatAppearance.BorderSize = 0;
            this.btnAsistencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencias.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencias.ForeColor = System.Drawing.Color.White;
            this.btnAsistencias.Location = new System.Drawing.Point(231, 246);
            this.btnAsistencias.Name = "btnAsistencias";
            this.btnAsistencias.Size = new System.Drawing.Size(227, 63);
            this.btnAsistencias.TabIndex = 2;
            this.btnAsistencias.Text = "Ver asistencias";
            this.btnAsistencias.TextColor = System.Drawing.Color.White;
            this.btnAsistencias.UseVisualStyleBackColor = false;
            // 
            // PanelGestionEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(734, 396);
            this.Controls.Add(this.btnAsistencias);
            this.Controls.Add(this.btnMatricularEstu);
            this.Controls.Add(this.btnRegistrarEstu);
            this.Name = "PanelGestionEstudiante";
            this.Text = "PanelGestionEstudiante";
            this.ResumeLayout(false);

        }

        #endregion

        private RJCodeAdvance.RJControls.RJButton btnRegistrarEstu;
        private RJCodeAdvance.RJControls.RJButton btnMatricularEstu;
        private RJCodeAdvance.RJControls.RJButton btnAsistencias;
    }
}