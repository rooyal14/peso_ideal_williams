
namespace peso_ideal_williams
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioFem = new System.Windows.Forms.RadioButton();
            this.radioMasc = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.fmAltura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPesoIdeal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioFem);
            this.groupBox1.Controls.Add(this.radioMasc);
            this.groupBox1.Location = new System.Drawing.Point(14, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // radioFem
            // 
            this.radioFem.AutoSize = true;
            this.radioFem.Location = new System.Drawing.Point(91, 19);
            this.radioFem.Name = "radioFem";
            this.radioFem.Size = new System.Drawing.Size(67, 17);
            this.radioFem.TabIndex = 1;
            this.radioFem.TabStop = true;
            this.radioFem.Text = "Feminino";
            this.radioFem.UseVisualStyleBackColor = true;
            this.radioFem.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // radioMasc
            // 
            this.radioMasc.AutoSize = true;
            this.radioMasc.Location = new System.Drawing.Point(12, 19);
            this.radioMasc.Name = "radioMasc";
            this.radioMasc.Size = new System.Drawing.Size(73, 17);
            this.radioMasc.TabIndex = 0;
            this.radioMasc.TabStop = true;
            this.radioMasc.Text = "Masculino";
            this.radioMasc.UseVisualStyleBackColor = true;
            this.radioMasc.CheckedChanged += new System.EventHandler(this.radioCheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Altura:";
            // 
            // fmAltura
            // 
            this.fmAltura.Cursor = System.Windows.Forms.Cursors.Default;
            this.fmAltura.Location = new System.Drawing.Point(192, 41);
            this.fmAltura.Name = "fmAltura";
            this.fmAltura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fmAltura.Size = new System.Drawing.Size(72, 20);
            this.fmAltura.TabIndex = 2;
            this.fmAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fmAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fmAltura_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Peso Ideal";
            // 
            // lblPesoIdeal
            // 
            this.lblPesoIdeal.AutoSize = true;
            this.lblPesoIdeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoIdeal.ForeColor = System.Drawing.Color.Red;
            this.lblPesoIdeal.Location = new System.Drawing.Point(94, 87);
            this.lblPesoIdeal.Name = "lblPesoIdeal";
            this.lblPesoIdeal.Size = new System.Drawing.Size(78, 25);
            this.lblPesoIdeal.TabIndex = 4;
            this.lblPesoIdeal.Text = "XX.XX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 126);
            this.Controls.Add(this.lblPesoIdeal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fmAltura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioFem;
        private System.Windows.Forms.RadioButton radioMasc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fmAltura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPesoIdeal;
    }
}

