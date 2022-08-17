
namespace Guia4_NSB
{
    partial class Form1
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
            this.GenerarButton = new System.Windows.Forms.Button();
            this.ClientesButton = new System.Windows.Forms.Button();
            this.PedidosButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base de Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Generada en C#";
            // 
            // GenerarButton
            // 
            this.GenerarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerarButton.Location = new System.Drawing.Point(159, 189);
            this.GenerarButton.Name = "GenerarButton";
            this.GenerarButton.Size = new System.Drawing.Size(97, 32);
            this.GenerarButton.TabIndex = 2;
            this.GenerarButton.Text = "Generar";
            this.GenerarButton.UseVisualStyleBackColor = true;
            this.GenerarButton.Click += new System.EventHandler(this.GenerarButton_Click);
            // 
            // ClientesButton
            // 
            this.ClientesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientesButton.Location = new System.Drawing.Point(56, 255);
            this.ClientesButton.Name = "ClientesButton";
            this.ClientesButton.Size = new System.Drawing.Size(97, 32);
            this.ClientesButton.TabIndex = 3;
            this.ClientesButton.Text = "Clientes";
            this.ClientesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ClientesButton.UseVisualStyleBackColor = true;
            this.ClientesButton.Click += new System.EventHandler(this.ClientesButton_Click);
            // 
            // PedidosButton
            // 
            this.PedidosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PedidosButton.Location = new System.Drawing.Point(253, 255);
            this.PedidosButton.Name = "PedidosButton";
            this.PedidosButton.Size = new System.Drawing.Size(97, 32);
            this.PedidosButton.TabIndex = 4;
            this.PedidosButton.Text = "Pedidos";
            this.PedidosButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PedidosButton.UseVisualStyleBackColor = true;
            this.PedidosButton.Click += new System.EventHandler(this.PedidosButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 338);
            this.Controls.Add(this.PedidosButton);
            this.Controls.Add(this.ClientesButton);
            this.Controls.Add(this.GenerarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GenerarButton;
        private System.Windows.Forms.Button ClientesButton;
        private System.Windows.Forms.Button PedidosButton;
    }
}

