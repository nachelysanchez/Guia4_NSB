
namespace Guia4_NSB.Tarea_4
{
    partial class rUsuarios
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.Nombrestxt = new System.Windows.Forms.TextBox();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.Ciudadcombo = new System.Windows.Forms.ComboBox();
            this.EstadoRadio = new System.Windows.Forms.RadioButton();
            this.btnVolverP = new System.Windows.Forms.Button();
            this.btnLimpiarP = new System.Windows.Forms.Button();
            this.btnIngresarP = new System.Windows.Forms.Button();
            this.lbNombreC = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ciudad";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(128, 91);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(368, 22);
            this.idtxt.TabIndex = 6;
            // 
            // Nombrestxt
            // 
            this.Nombrestxt.Location = new System.Drawing.Point(128, 139);
            this.Nombrestxt.Name = "Nombrestxt";
            this.Nombrestxt.Size = new System.Drawing.Size(368, 22);
            this.Nombrestxt.TabIndex = 7;
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(128, 184);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(368, 22);
            this.usertxt.TabIndex = 8;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(128, 229);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(368, 22);
            this.passwordtxt.TabIndex = 9;
            // 
            // Ciudadcombo
            // 
            this.Ciudadcombo.FormattingEnabled = true;
            this.Ciudadcombo.Location = new System.Drawing.Point(128, 274);
            this.Ciudadcombo.Name = "Ciudadcombo";
            this.Ciudadcombo.Size = new System.Drawing.Size(275, 24);
            this.Ciudadcombo.TabIndex = 10;
            this.Ciudadcombo.SelectedIndexChanged += new System.EventHandler(this.Ciudadcombo_SelectedIndexChanged);
            // 
            // EstadoRadio
            // 
            this.EstadoRadio.AutoSize = true;
            this.EstadoRadio.Location = new System.Drawing.Point(515, 90);
            this.EstadoRadio.Name = "EstadoRadio";
            this.EstadoRadio.Size = new System.Drawing.Size(67, 21);
            this.EstadoRadio.TabIndex = 11;
            this.EstadoRadio.TabStop = true;
            this.EstadoRadio.Text = "Activo";
            this.EstadoRadio.UseVisualStyleBackColor = true;
            // 
            // btnVolverP
            // 
            this.btnVolverP.Location = new System.Drawing.Point(455, 328);
            this.btnVolverP.Name = "btnVolverP";
            this.btnVolverP.Size = new System.Drawing.Size(75, 32);
            this.btnVolverP.TabIndex = 14;
            this.btnVolverP.Text = "Volver";
            this.btnVolverP.UseVisualStyleBackColor = true;
            this.btnVolverP.Click += new System.EventHandler(this.btnVolverP_Click);
            // 
            // btnLimpiarP
            // 
            this.btnLimpiarP.Location = new System.Drawing.Point(155, 328);
            this.btnLimpiarP.Name = "btnLimpiarP";
            this.btnLimpiarP.Size = new System.Drawing.Size(75, 32);
            this.btnLimpiarP.TabIndex = 13;
            this.btnLimpiarP.Text = "Limpiar";
            this.btnLimpiarP.UseVisualStyleBackColor = true;
            this.btnLimpiarP.Click += new System.EventHandler(this.btnLimpiarP_Click);
            // 
            // btnIngresarP
            // 
            this.btnIngresarP.Location = new System.Drawing.Point(32, 328);
            this.btnIngresarP.Name = "btnIngresarP";
            this.btnIngresarP.Size = new System.Drawing.Size(75, 32);
            this.btnIngresarP.TabIndex = 12;
            this.btnIngresarP.Text = "Ingresar";
            this.btnIngresarP.UseVisualStyleBackColor = true;
            this.btnIngresarP.Click += new System.EventHandler(this.btnIngresarP_Click);
            // 
            // lbNombreC
            // 
            this.lbNombreC.AutoSize = true;
            this.lbNombreC.Location = new System.Drawing.Point(493, 279);
            this.lbNombreC.Name = "lbNombreC";
            this.lbNombreC.Size = new System.Drawing.Size(102, 17);
            this.lbNombreC.TabIndex = 16;
            this.lbNombreC.Text = "NombreCiudad";
            this.lbNombreC.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ciudad";
            // 
            // rUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 409);
            this.Controls.Add(this.lbNombreC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnVolverP);
            this.Controls.Add(this.btnLimpiarP);
            this.Controls.Add(this.btnIngresarP);
            this.Controls.Add(this.EstadoRadio);
            this.Controls.Add(this.Ciudadcombo);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.Nombrestxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rUsuarios";
            this.Text = "rUsuarios";
            this.Load += new System.EventHandler(this.rUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox Nombrestxt;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.ComboBox Ciudadcombo;
        private System.Windows.Forms.RadioButton EstadoRadio;
        private System.Windows.Forms.Button btnVolverP;
        private System.Windows.Forms.Button btnLimpiarP;
        private System.Windows.Forms.Button btnIngresarP;
        private System.Windows.Forms.Label lbNombreC;
        private System.Windows.Forms.Label label7;
    }
}