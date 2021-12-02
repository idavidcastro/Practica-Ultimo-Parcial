
namespace Presentationn
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbSedes = new System.Windows.Forms.ComboBox();
            this.BtnSeleccione = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtRutaArchivo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtRutaArchivo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BtnSeleccione);
            this.panel1.Controls.Add(this.CmbSedes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(32, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 569);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrada de Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sede:";
            // 
            // CmbSedes
            // 
            this.CmbSedes.FormattingEnabled = true;
            this.CmbSedes.Location = new System.Drawing.Point(131, 98);
            this.CmbSedes.Name = "CmbSedes";
            this.CmbSedes.Size = new System.Drawing.Size(174, 24);
            this.CmbSedes.TabIndex = 3;
            // 
            // BtnSeleccione
            // 
            this.BtnSeleccione.Location = new System.Drawing.Point(320, 165);
            this.BtnSeleccione.Name = "BtnSeleccione";
            this.BtnSeleccione.Size = new System.Drawing.Size(118, 33);
            this.BtnSeleccione.TabIndex = 4;
            this.BtnSeleccione.Text = "Seleccione";
            this.BtnSeleccione.UseVisualStyleBackColor = true;
            this.BtnSeleccione.Click += new System.EventHandler(this.BtnSeleccione_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ruta:";
            // 
            // TxtRutaArchivo
            // 
            this.TxtRutaArchivo.Location = new System.Drawing.Point(131, 171);
            this.TxtRutaArchivo.Name = "TxtRutaArchivo";
            this.TxtRutaArchivo.Size = new System.Drawing.Size(174, 22);
            this.TxtRutaArchivo.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 624);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Ruta: ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CmbSedes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSeleccione;
        private System.Windows.Forms.TextBox TxtRutaArchivo;
        private System.Windows.Forms.Label label3;
    }
}

