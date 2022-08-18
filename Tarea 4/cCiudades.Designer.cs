
namespace Guia4_NSB.Tarea_4
{
    partial class cCiudades
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ciudadesdtg = new System.Windows.Forms.DataGridView();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.filtrotxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesdtg)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Criterio";
            // 
            // comboFiltro
            // 
            this.comboFiltro.FormattingEnabled = true;
            this.comboFiltro.Items.AddRange(new object[] {
            "Id_Ciudad",
            "NombreCiudad"});
            this.comboFiltro.Location = new System.Drawing.Point(11, 41);
            this.comboFiltro.Name = "comboFiltro";
            this.comboFiltro.Size = new System.Drawing.Size(121, 24);
            this.comboFiltro.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtro";
            // 
            // ciudadesdtg
            // 
            this.ciudadesdtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ciudadesdtg.Location = new System.Drawing.Point(11, 85);
            this.ciudadesdtg.Name = "ciudadesdtg";
            this.ciudadesdtg.RowHeadersWidth = 51;
            this.ciudadesdtg.RowTemplate.Height = 24;
            this.ciudadesdtg.Size = new System.Drawing.Size(784, 272);
            this.ciudadesdtg.TabIndex = 9;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(705, 37);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 31);
            this.BuscarButton.TabIndex = 8;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // filtrotxt
            // 
            this.filtrotxt.Location = new System.Drawing.Point(166, 41);
            this.filtrotxt.Name = "filtrotxt";
            this.filtrotxt.Size = new System.Drawing.Size(471, 22);
            this.filtrotxt.TabIndex = 7;
            // 
            // cCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ciudadesdtg);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.filtrotxt);
            this.Name = "cCiudades";
            this.Text = "cCiudades";
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesdtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ciudadesdtg;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox filtrotxt;
    }
}