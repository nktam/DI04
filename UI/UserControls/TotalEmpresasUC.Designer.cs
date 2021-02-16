
namespace UI.UserControls
{
    partial class TotalEmpresasUC
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbEmp2tot = new System.Windows.Forms.Label();
            this.lbEmp1tot = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbEmpresa1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbEmp2tot, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbEmpresa1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbEmp1tot, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(186, 112);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // lbEmp2tot
            // 
            this.lbEmp2tot.AutoSize = true;
            this.lbEmp2tot.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbEmp2tot.Font = new System.Drawing.Font("Impact", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmp2tot.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbEmp2tot.Location = new System.Drawing.Point(3, 84);
            this.lbEmp2tot.Name = "lbEmp2tot";
            this.lbEmp2tot.Size = new System.Drawing.Size(87, 28);
            this.lbEmp2tot.TabIndex = 3;
            this.lbEmp2tot.Text = "45000 €";
            // 
            // lbEmp1tot
            // 
            this.lbEmp1tot.AutoSize = true;
            this.lbEmp1tot.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbEmp1tot.Font = new System.Drawing.Font("Impact", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmp1tot.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbEmp1tot.Location = new System.Drawing.Point(3, 28);
            this.lbEmp1tot.Name = "lbEmp1tot";
            this.lbEmp1tot.Size = new System.Drawing.Size(87, 28);
            this.lbEmp1tot.TabIndex = 2;
            this.lbEmp1tot.Text = "45000 €";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empresa 2";
            // 
            // lbEmpresa1
            // 
            this.lbEmpresa1.AutoSize = true;
            this.lbEmpresa1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbEmpresa1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpresa1.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbEmpresa1.Location = new System.Drawing.Point(3, 2);
            this.lbEmpresa1.Name = "lbEmpresa1";
            this.lbEmpresa1.Size = new System.Drawing.Size(180, 26);
            this.lbEmpresa1.TabIndex = 0;
            this.lbEmpresa1.Text = "Empresa 1";
            // 
            // TotalEmpresasUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TotalEmpresasUC";
            this.Size = new System.Drawing.Size(230, 215);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbEmp2tot;
        private System.Windows.Forms.Label lbEmp1tot;
        private System.Windows.Forms.Label lbEmpresa1;
        private System.Windows.Forms.Label label1;
    }
}
