namespace SistemaPOS
{
    partial class MantenimientoClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoClientes));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textId_Cliente = new LibreriaDLL.ErrorTxtBox();
            this.textNombre_Cliente = new LibreriaDLL.ErrorTxtBox();
            this.textApellido_Cliente = new LibreriaDLL.ErrorTxtBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 469);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 469);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(569, 469);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(784, 469);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(718, 547);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(200, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(203, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(175, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID_Cliente:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(694, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 242);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(397, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 40);
            this.label4.TabIndex = 18;
            this.label4.Text = "CLIENTES";
            // 
            // textId_Cliente
            // 
            this.textId_Cliente.Location = new System.Drawing.Point(342, 165);
            this.textId_Cliente.Name = "textId_Cliente";
            this.textId_Cliente.Size = new System.Drawing.Size(226, 26);
            this.textId_Cliente.TabIndex = 19;
            this.textId_Cliente.Validar = true;
            this.textId_Cliente.ValidarNumeros = true;
            this.textId_Cliente.TextChanged += new System.EventHandler(this.textId_Cliente_TextChanged);
            // 
            // textNombre_Cliente
            // 
            this.textNombre_Cliente.Location = new System.Drawing.Point(342, 241);
            this.textNombre_Cliente.Name = "textNombre_Cliente";
            this.textNombre_Cliente.Size = new System.Drawing.Size(226, 26);
            this.textNombre_Cliente.TabIndex = 20;
            this.textNombre_Cliente.Validar = true;
            this.textNombre_Cliente.ValidarNumeros = false;
            // 
            // textApellido_Cliente
            // 
            this.textApellido_Cliente.Location = new System.Drawing.Point(342, 320);
            this.textApellido_Cliente.Name = "textApellido_Cliente";
            this.textApellido_Cliente.Size = new System.Drawing.Size(226, 26);
            this.textApellido_Cliente.TabIndex = 21;
            this.textApellido_Cliente.Validar = true;
            this.textApellido_Cliente.ValidarNumeros = false;
            // 
            // MantenimientoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 668);
            this.Controls.Add(this.textApellido_Cliente);
            this.Controls.Add(this.textNombre_Cliente);
            this.Controls.Add(this.textId_Cliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoClientes";
            this.Text = "MantenimientoClientes";
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textId_Cliente, 0);
            this.Controls.SetChildIndex(this.textNombre_Cliente, 0);
            this.Controls.SetChildIndex(this.textApellido_Cliente, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private LibreriaDLL.ErrorTxtBox textId_Cliente;
        private LibreriaDLL.ErrorTxtBox textNombre_Cliente;
        private LibreriaDLL.ErrorTxtBox textApellido_Cliente;
    }
}