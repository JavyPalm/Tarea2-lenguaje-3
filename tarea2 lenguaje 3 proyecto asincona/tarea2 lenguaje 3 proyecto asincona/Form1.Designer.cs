namespace tarea2_lenguaje_3_proyecto_asincona
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
            this.Nota1label = new System.Windows.Forms.Label();
            this.Nota2label = new System.Windows.Forms.Label();
            this.Nota3label = new System.Windows.Forms.Label();
            this.Nota4label = new System.Windows.Forms.Label();
            this.nota1textBox = new System.Windows.Forms.TextBox();
            this.nota2textBox = new System.Windows.Forms.TextBox();
            this.nota3textBox = new System.Windows.Forms.TextBox();
            this.nota4textBox = new System.Windows.Forms.TextBox();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nota1label
            // 
            this.Nota1label.AutoSize = true;
            this.Nota1label.Location = new System.Drawing.Point(31, 45);
            this.Nota1label.Name = "Nota1label";
            this.Nota1label.Size = new System.Drawing.Size(90, 16);
            this.Nota1label.TabIndex = 0;
            this.Nota1label.Text = "Nota parcial 1";
            // 
            // Nota2label
            // 
            this.Nota2label.AutoSize = true;
            this.Nota2label.Location = new System.Drawing.Point(31, 102);
            this.Nota2label.Name = "Nota2label";
            this.Nota2label.Size = new System.Drawing.Size(90, 16);
            this.Nota2label.TabIndex = 1;
            this.Nota2label.Text = "Nota parcial 2";
            // 
            // Nota3label
            // 
            this.Nota3label.AutoSize = true;
            this.Nota3label.Location = new System.Drawing.Point(31, 151);
            this.Nota3label.Name = "Nota3label";
            this.Nota3label.Size = new System.Drawing.Size(90, 16);
            this.Nota3label.TabIndex = 2;
            this.Nota3label.Text = "Nota parcial 3";
            // 
            // Nota4label
            // 
            this.Nota4label.AutoSize = true;
            this.Nota4label.Location = new System.Drawing.Point(31, 207);
            this.Nota4label.Name = "Nota4label";
            this.Nota4label.Size = new System.Drawing.Size(90, 16);
            this.Nota4label.TabIndex = 3;
            this.Nota4label.Text = "Nota parcial 4";
            // 
            // nota1textBox
            // 
            this.nota1textBox.Location = new System.Drawing.Point(144, 52);
            this.nota1textBox.Name = "nota1textBox";
            this.nota1textBox.Size = new System.Drawing.Size(100, 22);
            this.nota1textBox.TabIndex = 5;
            // 
            // nota2textBox
            // 
            this.nota2textBox.Location = new System.Drawing.Point(144, 99);
            this.nota2textBox.Name = "nota2textBox";
            this.nota2textBox.Size = new System.Drawing.Size(100, 22);
            this.nota2textBox.TabIndex = 7;
            // 
            // nota3textBox
            // 
            this.nota3textBox.Location = new System.Drawing.Point(144, 148);
            this.nota3textBox.Name = "nota3textBox";
            this.nota3textBox.Size = new System.Drawing.Size(100, 22);
            this.nota3textBox.TabIndex = 8;
            // 
            // nota4textBox
            // 
            this.nota4textBox.Location = new System.Drawing.Point(144, 204);
            this.nota4textBox.Name = "nota4textBox";
            this.nota4textBox.Size = new System.Drawing.Size(100, 22);
            this.nota4textBox.TabIndex = 9;
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(282, 173);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(147, 53);
            this.Calcularbutton.TabIndex = 11;
            this.Calcularbutton.Text = "Calcular Promedio";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 300);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.nota4textBox);
            this.Controls.Add(this.nota3textBox);
            this.Controls.Add(this.nota2textBox);
            this.Controls.Add(this.nota1textBox);
            this.Controls.Add(this.Nota4label);
            this.Controls.Add(this.Nota3label);
            this.Controls.Add(this.Nota2label);
            this.Controls.Add(this.Nota1label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nota1label;
        private System.Windows.Forms.Label Nota2label;
        private System.Windows.Forms.Label Nota3label;
        private System.Windows.Forms.Label Nota4label;
        private System.Windows.Forms.TextBox nota1textBox;
        private System.Windows.Forms.TextBox nota2textBox;
        private System.Windows.Forms.TextBox nota3textBox;
        private System.Windows.Forms.TextBox nota4textBox;
        private System.Windows.Forms.Button Calcularbutton;
    }
}

