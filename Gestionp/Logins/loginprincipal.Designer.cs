namespace Gestionp
{
    partial class loginprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginprincipal));
            this.btn_Estudiante = new System.Windows.Forms.Button();
            this.btn_Profesor = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Admin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Estudiante
            // 
            this.btn_Estudiante.Location = new System.Drawing.Point(137, 273);
            this.btn_Estudiante.Name = "btn_Estudiante";
            this.btn_Estudiante.Size = new System.Drawing.Size(100, 43);
            this.btn_Estudiante.TabIndex = 4;
            this.btn_Estudiante.Text = "Estudiante";
            this.btn_Estudiante.UseVisualStyleBackColor = true;
            this.btn_Estudiante.Click += new System.EventHandler(this.btn_Estudiante_Click);
            // 
            // btn_Profesor
            // 
            this.btn_Profesor.Location = new System.Drawing.Point(137, 210);
            this.btn_Profesor.Name = "btn_Profesor";
            this.btn_Profesor.Size = new System.Drawing.Size(100, 43);
            this.btn_Profesor.TabIndex = 5;
            this.btn_Profesor.Text = "Profesor";
            this.btn_Profesor.UseVisualStyleBackColor = true;
            this.btn_Profesor.Click += new System.EventHandler(this.btn_Profesor_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(317, 380);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(74, 32);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(104, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Admin
            // 
            this.btn_Admin.Location = new System.Drawing.Point(137, 340);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(100, 43);
            this.btn_Admin.TabIndex = 8;
            this.btn_Admin.Text = "ADMIN";
            this.btn_Admin.UseVisualStyleBackColor = true;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // loginprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 424);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Profesor);
            this.Controls.Add(this.btn_Estudiante);
            this.Name = "loginprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginprincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Estudiante;
        private System.Windows.Forms.Button btn_Profesor;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Admin;
    }
}