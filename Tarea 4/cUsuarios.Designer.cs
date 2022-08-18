
namespace Guia4_NSB.Tarea_4
{
    partial class cUsuarios
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
            this.filtrotxt = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.usuariosdtg = new System.Windows.Forms.DataGridView();
            this.Idcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombrescol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboFiltro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosdtg)).BeginInit();
            this.SuspendLayout();
            // 
            // filtrotxt
            // 
            this.filtrotxt.Location = new System.Drawing.Point(180, 43);
            this.filtrotxt.Name = "filtrotxt";
            this.filtrotxt.Size = new System.Drawing.Size(471, 22);
            this.filtrotxt.TabIndex = 1;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(719, 39);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 31);
            this.BuscarButton.TabIndex = 2;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // usuariosdtg
            // 
            this.usuariosdtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosdtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idcol,
            this.Nombrescol,
            this.userCol,
            this.passCol,
            this.estadoCol,
            this.ciudadCol});
            this.usuariosdtg.Location = new System.Drawing.Point(25, 87);
            this.usuariosdtg.Name = "usuariosdtg";
            this.usuariosdtg.RowHeadersWidth = 51;
            this.usuariosdtg.RowTemplate.Height = 24;
            this.usuariosdtg.Size = new System.Drawing.Size(784, 272);
            this.usuariosdtg.TabIndex = 3;
            // 
            // Idcol
            // 
            this.Idcol.HeaderText = "Id Usuario";
            this.Idcol.MinimumWidth = 6;
            this.Idcol.Name = "Idcol";
            this.Idcol.ReadOnly = true;
            this.Idcol.Width = 125;
            // 
            // Nombrescol
            // 
            this.Nombrescol.HeaderText = "Nombres";
            this.Nombrescol.MinimumWidth = 6;
            this.Nombrescol.Name = "Nombrescol";
            this.Nombrescol.ReadOnly = true;
            this.Nombrescol.Width = 125;
            // 
            // userCol
            // 
            this.userCol.HeaderText = "Nombre de Usuario";
            this.userCol.MinimumWidth = 6;
            this.userCol.Name = "userCol";
            this.userCol.ReadOnly = true;
            this.userCol.Width = 125;
            // 
            // passCol
            // 
            this.passCol.HeaderText = "Contraseña";
            this.passCol.MinimumWidth = 6;
            this.passCol.Name = "passCol";
            this.passCol.ReadOnly = true;
            this.passCol.Width = 125;
            // 
            // estadoCol
            // 
            this.estadoCol.HeaderText = "Estado";
            this.estadoCol.MinimumWidth = 6;
            this.estadoCol.Name = "estadoCol";
            this.estadoCol.ReadOnly = true;
            this.estadoCol.Width = 125;
            // 
            // ciudadCol
            // 
            this.ciudadCol.HeaderText = "Ciudad";
            this.ciudadCol.MinimumWidth = 6;
            this.ciudadCol.Name = "ciudadCol";
            this.ciudadCol.ReadOnly = true;
            this.ciudadCol.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtro";
            // 
            // comboFiltro
            // 
            this.comboFiltro.FormattingEnabled = true;
            this.comboFiltro.Items.AddRange(new object[] {
            "Id Usuario",
            "Nombres"});
            this.comboFiltro.Location = new System.Drawing.Point(25, 43);
            this.comboFiltro.Name = "comboFiltro";
            this.comboFiltro.Size = new System.Drawing.Size(121, 24);
            this.comboFiltro.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Criterio";
            // 
            // cUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 409);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuariosdtg);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.filtrotxt);
            this.Name = "cUsuarios";
            this.Text = "cUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.usuariosdtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox filtrotxt;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView usuariosdtg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombrescol;
        private System.Windows.Forms.DataGridViewTextBoxColumn userCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn passCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboFiltro;
        private System.Windows.Forms.Label label2;
    }
}