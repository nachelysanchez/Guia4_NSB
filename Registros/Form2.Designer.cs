
namespace Guia4_NSB.Registros
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnIngresarC = new System.Windows.Forms.Button();
            this.btnLimpiarC = new System.Windows.Forms.Button();
            this.btnVolverC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnIngresarC
            // 
            this.btnIngresarC.Location = new System.Drawing.Point(65, 178);
            this.btnIngresarC.Name = "btnIngresarC";
            this.btnIngresarC.Size = new System.Drawing.Size(75, 40);
            this.btnIngresarC.TabIndex = 3;
            this.btnIngresarC.Text = "Ingresar";
            this.btnIngresarC.UseVisualStyleBackColor = true;
            this.btnIngresarC.Click += new System.EventHandler(this.btnIngresarC_Click);
            // 
            // btnLimpiarC
            // 
            this.btnLimpiarC.Location = new System.Drawing.Point(184, 178);
            this.btnLimpiarC.Name = "btnLimpiarC";
            this.btnLimpiarC.Size = new System.Drawing.Size(75, 40);
            this.btnLimpiarC.TabIndex = 4;
            this.btnLimpiarC.Text = "Limpiar";
            this.btnLimpiarC.UseVisualStyleBackColor = true;
            this.btnLimpiarC.Click += new System.EventHandler(this.btnLimpiarC_Click);
            // 
            // btnVolverC
            // 
            this.btnVolverC.Location = new System.Drawing.Point(292, 178);
            this.btnVolverC.Name = "btnVolverC";
            this.btnVolverC.Size = new System.Drawing.Size(75, 40);
            this.btnVolverC.TabIndex = 5;
            this.btnVolverC.Text = "Volver";
            this.btnVolverC.UseVisualStyleBackColor = true;
            this.btnVolverC.Click += new System.EventHandler(this.btnVolverC_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 269);
            this.Controls.Add(this.btnVolverC);
            this.Controls.Add(this.btnLimpiarC);
            this.Controls.Add(this.btnIngresarC);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnIngresarC;
        private System.Windows.Forms.Button btnLimpiarC;
        private System.Windows.Forms.Button btnVolverC;
    }
}