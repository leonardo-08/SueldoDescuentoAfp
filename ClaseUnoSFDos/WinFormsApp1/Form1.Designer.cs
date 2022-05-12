namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Calcular = new System.Windows.Forms.Button();
            this.SueldoBruto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SueldoNeto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Calcular
            // 
            this.Calcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Calcular.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calcular.Location = new System.Drawing.Point(31, 303);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(299, 78);
            this.Calcular.TabIndex = 0;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = false;
            this.Calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // SueldoBruto
            // 
            this.SueldoBruto.Location = new System.Drawing.Point(31, 233);
            this.SueldoBruto.Name = "SueldoBruto";
            this.SueldoBruto.Size = new System.Drawing.Size(299, 27);
            this.SueldoBruto.TabIndex = 1;
            this.SueldoBruto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sueldo bruto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(405, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 54);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sueldo neto:";
            // 
            // SueldoNeto
            // 
            this.SueldoNeto.AutoSize = true;
            this.SueldoNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SueldoNeto.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SueldoNeto.ForeColor = System.Drawing.Color.Lime;
            this.SueldoNeto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SueldoNeto.Location = new System.Drawing.Point(448, 220);
            this.SueldoNeto.Name = "SueldoNeto";
            this.SueldoNeto.Size = new System.Drawing.Size(133, 108);
            this.SueldoNeto.TabIndex = 4;
            this.SueldoNeto.Text = "00";
            this.SueldoNeto.Click += new System.EventHandler(this.SueldoNeto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(31, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(757, 81);
            this.label4.TabIndex = 5;
            this.label4.Text = "Calculadora de sueldo neto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SueldoNeto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SueldoBruto);
            this.Controls.Add(this.Calcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Calcular;
        private TextBox SueldoBruto;
        private Label label1;
        private Label label2;
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label SueldoNeto;
    }
}