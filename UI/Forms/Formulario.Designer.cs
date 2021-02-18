
namespace UI.Forms
{
    partial class Formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.tlpAside = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSeleccion = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbComercial = new System.Windows.Forms.ComboBox();
            this.tlpBase.SuspendLayout();
            this.tlpAside.SuspendLayout();
            this.tlpSeleccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.ColumnCount = 2;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.6F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.4F));
            this.tlpBase.Controls.Add(this.tlpAside, 0, 0);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 1;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tlpBase.Size = new System.Drawing.Size(1000, 600);
            this.tlpBase.TabIndex = 0;
            // 
            // tlpAside
            // 
            this.tlpAside.ColumnCount = 1;
            this.tlpAside.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAside.Controls.Add(this.tlpSeleccion, 0, 0);
            this.tlpAside.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAside.Location = new System.Drawing.Point(3, 3);
            this.tlpAside.Name = "tlpAside";
            this.tlpAside.RowCount = 4;
            this.tlpAside.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAside.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAside.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAside.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpAside.Size = new System.Drawing.Size(170, 594);
            this.tlpAside.TabIndex = 0;
            // 
            // tlpSeleccion
            // 
            this.tlpSeleccion.ColumnCount = 1;
            this.tlpSeleccion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSeleccion.Controls.Add(this.pictureBox1, 0, 0);
            this.tlpSeleccion.Controls.Add(this.panel2, 0, 1);
            this.tlpSeleccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSeleccion.Location = new System.Drawing.Point(3, 3);
            this.tlpSeleccion.Name = "tlpSeleccion";
            this.tlpSeleccion.RowCount = 2;
            this.tlpSeleccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.33334F));
            this.tlpSeleccion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66667F));
            this.tlpSeleccion.Size = new System.Drawing.Size(164, 142);
            this.tlpSeleccion.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbComercial);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 104);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 38);
            this.panel2.TabIndex = 1;
            // 
            // cbComercial
            // 
            this.cbComercial.BackColor = System.Drawing.Color.Gray;
            this.cbComercial.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.cbComercial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComercial.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbComercial.FormattingEnabled = true;
            this.cbComercial.Location = new System.Drawing.Point(6, 8);
            this.cbComercial.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.cbComercial.Name = "cbComercial";
            this.cbComercial.Size = new System.Drawing.Size(158, 24);
            this.cbComercial.TabIndex = 1;
            this.cbComercial.SelectedIndexChanged += new System.EventHandler(this.cbComercial_SelectedIndexChanged);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tlpBase);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Formulario";
            this.Text = "Formulario";
            this.tlpBase.ResumeLayout(false);
            this.tlpAside.ResumeLayout(false);
            this.tlpSeleccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.TableLayoutPanel tlpAside;
        private System.Windows.Forms.TableLayoutPanel tlpSeleccion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbComercial;
        private System.Windows.Forms.Panel panel2;
    }
}