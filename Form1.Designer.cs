namespace PracticaGUI
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
            this.Saludo = new System.Windows.Forms.Button();
            this.Rojo = new System.Windows.Forms.Button();
            this.Naranja = new System.Windows.Forms.Button();
            this.Amarillo = new System.Windows.Forms.Button();
            this.Verde = new System.Windows.Forms.Button();
            this.Azul = new System.Windows.Forms.Button();
            this.Morado = new System.Windows.Forms.Button();
            this.Rosado = new System.Windows.Forms.Button();
            this.Salida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Saludo
            // 
            this.Saludo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Saludo.Location = new System.Drawing.Point(256, 12);
            this.Saludo.Name = "Saludo";
            this.Saludo.Size = new System.Drawing.Size(120, 35);
            this.Saludo.TabIndex = 0;
            this.Saludo.Text = "Saludo";
            this.Saludo.UseVisualStyleBackColor = true;
            this.Saludo.Click += new System.EventHandler(this.Saludo_Click);
            // 
            // Rojo
            // 
            this.Rojo.BackColor = System.Drawing.Color.Red;
            this.Rojo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rojo.Location = new System.Drawing.Point(12, 80);
            this.Rojo.Name = "Rojo";
            this.Rojo.Size = new System.Drawing.Size(120, 35);
            this.Rojo.TabIndex = 1;
            this.Rojo.Text = "Rojo";
            this.Rojo.UseVisualStyleBackColor = false;
            this.Rojo.Click += new System.EventHandler(this.Rojo_Click);
            // 
            // Naranja
            // 
            this.Naranja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Naranja.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Naranja.Location = new System.Drawing.Point(178, 80);
            this.Naranja.Name = "Naranja";
            this.Naranja.Size = new System.Drawing.Size(120, 35);
            this.Naranja.TabIndex = 2;
            this.Naranja.Text = "Naranja";
            this.Naranja.UseVisualStyleBackColor = false;
            this.Naranja.Click += new System.EventHandler(this.Naranja_Click);
            // 
            // Amarillo
            // 
            this.Amarillo.BackColor = System.Drawing.Color.Yellow;
            this.Amarillo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amarillo.Location = new System.Drawing.Point(331, 80);
            this.Amarillo.Name = "Amarillo";
            this.Amarillo.Size = new System.Drawing.Size(120, 35);
            this.Amarillo.TabIndex = 3;
            this.Amarillo.Text = "Amarillo";
            this.Amarillo.UseVisualStyleBackColor = false;
            this.Amarillo.Click += new System.EventHandler(this.Amarillo_Click);
            // 
            // Verde
            // 
            this.Verde.BackColor = System.Drawing.Color.Lime;
            this.Verde.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Verde.Location = new System.Drawing.Point(485, 80);
            this.Verde.Name = "Verde";
            this.Verde.Size = new System.Drawing.Size(120, 35);
            this.Verde.TabIndex = 4;
            this.Verde.Text = "Verde";
            this.Verde.UseVisualStyleBackColor = false;
            this.Verde.Click += new System.EventHandler(this.Verde_Click);
            // 
            // Azul
            // 
            this.Azul.BackColor = System.Drawing.Color.Blue;
            this.Azul.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Azul.Location = new System.Drawing.Point(94, 149);
            this.Azul.Name = "Azul";
            this.Azul.Size = new System.Drawing.Size(120, 35);
            this.Azul.TabIndex = 5;
            this.Azul.Text = "Azul";
            this.Azul.UseVisualStyleBackColor = false;
            this.Azul.Click += new System.EventHandler(this.Azul_Click);
            // 
            // Morado
            // 
            this.Morado.BackColor = System.Drawing.Color.Purple;
            this.Morado.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Morado.Location = new System.Drawing.Point(256, 149);
            this.Morado.Name = "Morado";
            this.Morado.Size = new System.Drawing.Size(120, 35);
            this.Morado.TabIndex = 6;
            this.Morado.Text = "Morado";
            this.Morado.UseVisualStyleBackColor = false;
            this.Morado.Click += new System.EventHandler(this.Morado_Click);
            // 
            // Rosado
            // 
            this.Rosado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Rosado.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rosado.Location = new System.Drawing.Point(410, 149);
            this.Rosado.Name = "Rosado";
            this.Rosado.Size = new System.Drawing.Size(120, 35);
            this.Rosado.TabIndex = 7;
            this.Rosado.Text = "Rosado";
            this.Rosado.UseVisualStyleBackColor = false;
            this.Rosado.Click += new System.EventHandler(this.Rosado_Click);
            // 
            // Salida
            // 
            this.Salida.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Salida.Location = new System.Drawing.Point(256, 221);
            this.Salida.Name = "Salida";
            this.Salida.Size = new System.Drawing.Size(120, 35);
            this.Salida.TabIndex = 8;
            this.Salida.Text = "Salida";
            this.Salida.UseVisualStyleBackColor = true;
            this.Salida.Click += new System.EventHandler(this.Salida_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 268);
            this.Controls.Add(this.Salida);
            this.Controls.Add(this.Rosado);
            this.Controls.Add(this.Morado);
            this.Controls.Add(this.Azul);
            this.Controls.Add(this.Verde);
            this.Controls.Add(this.Amarillo);
            this.Controls.Add(this.Naranja);
            this.Controls.Add(this.Rojo);
            this.Controls.Add(this.Saludo);
            this.Name = "Form1";
            this.Text = "Practica de Interfaz Gráfica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Saludo;
        private System.Windows.Forms.Button Rojo;
        private System.Windows.Forms.Button Naranja;
        private System.Windows.Forms.Button Amarillo;
        private System.Windows.Forms.Button Verde;
        private System.Windows.Forms.Button Azul;
        private System.Windows.Forms.Button Morado;
        private System.Windows.Forms.Button Rosado;
        private System.Windows.Forms.Button Salida;
    }
}

