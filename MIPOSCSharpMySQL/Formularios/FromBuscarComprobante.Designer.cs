namespace MIPOSCSharpMySQL.Formularios
{
    partial class FromBuscarComprobante
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
            this.txtnumerofactura = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnumerofactura = new System.Windows.Forms.Label();
            this.lblfechaventa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblapmaterno = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblappaterno = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvproducto = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.lbliva = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnumerofactura);
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Numero de Factura";
            // 
            // txtnumerofactura
            // 
            this.txtnumerofactura.Location = new System.Drawing.Point(16, 22);
            this.txtnumerofactura.Name = "txtnumerofactura";
            this.txtnumerofactura.Size = new System.Drawing.Size(261, 20);
            this.txtnumerofactura.TabIndex = 1;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(290, 14);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(110, 34);
            this.btnbuscar.TabIndex = 0;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Factura N°:";
            // 
            // lblnumerofactura
            // 
            this.lblnumerofactura.AutoSize = true;
            this.lblnumerofactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumerofactura.Location = new System.Drawing.Point(129, 104);
            this.lblnumerofactura.Name = "lblnumerofactura";
            this.lblnumerofactura.Size = new System.Drawing.Size(34, 20);
            this.lblnumerofactura.TabIndex = 2;
            this.lblnumerofactura.Text = "-----";
            // 
            // lblfechaventa
            // 
            this.lblfechaventa.AutoSize = true;
            this.lblfechaventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechaventa.Location = new System.Drawing.Point(371, 104);
            this.lblfechaventa.Name = "lblfechaventa";
            this.lblfechaventa.Size = new System.Drawing.Size(34, 20);
            this.lblfechaventa.TabIndex = 4;
            this.lblfechaventa.Text = "-----";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(223, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Venta:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblapmaterno);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblappaterno);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblnombre);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 102);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Cliente";
            // 
            // lblapmaterno
            // 
            this.lblapmaterno.AutoSize = true;
            this.lblapmaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapmaterno.Location = new System.Drawing.Point(325, 58);
            this.lblapmaterno.Name = "lblapmaterno";
            this.lblapmaterno.Size = new System.Drawing.Size(34, 20);
            this.lblapmaterno.TabIndex = 11;
            this.lblapmaterno.Text = "-----";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(286, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Ap Materno:";
            // 
            // lblappaterno
            // 
            this.lblappaterno.AutoSize = true;
            this.lblappaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblappaterno.Location = new System.Drawing.Point(188, 58);
            this.lblappaterno.Name = "lblappaterno";
            this.lblappaterno.Size = new System.Drawing.Size(34, 20);
            this.lblappaterno.TabIndex = 9;
            this.lblappaterno.Text = "-----";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(145, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ap Paterno:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(35, 58);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(34, 20);
            this.lblnombre.TabIndex = 7;
            this.lblnombre.Text = "-----";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombres:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvproducto);
            this.groupBox3.Location = new System.Drawing.Point(12, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 160);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productos";
            // 
            // dgvproducto
            // 
            this.dgvproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducto.Location = new System.Drawing.Point(6, 19);
            this.dgvproducto.Name = "dgvproducto";
            this.dgvproducto.Size = new System.Drawing.Size(405, 135);
            this.dgvproducto.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(327, 446);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "IVA:";
            // 
            // lbliva
            // 
            this.lbliva.AutoSize = true;
            this.lbliva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliva.Location = new System.Drawing.Point(389, 446);
            this.lbliva.Name = "lbliva";
            this.lbliva.Size = new System.Drawing.Size(34, 20);
            this.lbliva.TabIndex = 12;
            this.lbliva.Text = "-----";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(317, 471);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Total:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(389, 471);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(34, 20);
            this.lbltotal.TabIndex = 14;
            this.lbltotal.Text = "-----";
            // 
            // FromBuscarComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 523);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbliva);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblfechaventa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblnumerofactura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FromBuscarComprobante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FromBuscarComprobante";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnumerofactura;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnumerofactura;
        private System.Windows.Forms.Label lblfechaventa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblapmaterno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblappaterno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvproducto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbliva;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbltotal;
    }
}