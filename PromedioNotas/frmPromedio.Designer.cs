namespace PromedioNotas
{
    partial class frmPromedio
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtnombre = new TextBox();
            btncalcular = new Button();
            btnlimpiar = new Button();
            txtN1 = new TextBox();
            txtN2 = new TextBox();
            txtN3 = new TextBox();
            txtN4 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lblCondicion = new Label();
            lblPromedio = new Label();
            lblNotaBaja = new Label();
            btnsalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(58, 9);
            label1.Name = "label1";
            label1.Size = new Size(345, 26);
            label1.TabIndex = 0;
            label1.Text = "CONTROL DE PROMEDIO DE NOTAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "ESTUDIANTE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(259, 66);
            label3.Name = "label3";
            label3.Size = new Size(168, 20);
            label3.TabIndex = 2;
            label3.Text = "REGISTRO DE NOTAS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(207, 108);
            label4.Name = "label4";
            label4.Size = new Size(60, 17);
            label4.TabIndex = 3;
            label4.Text = "NOTA 1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(273, 108);
            label5.Name = "label5";
            label5.Size = new Size(60, 17);
            label5.TabIndex = 4;
            label5.Text = "NOTA 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(339, 106);
            label6.Name = "label6";
            label6.Size = new Size(55, 16);
            label6.TabIndex = 5;
            label6.Text = "NOTA 3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(394, 106);
            label7.Name = "label7";
            label7.Size = new Size(60, 17);
            label7.TabIndex = 6;
            label7.Text = "NOTA 4";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(12, 106);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(151, 23);
            txtnombre.TabIndex = 7;
            // 
            // btncalcular
            // 
            btncalcular.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btncalcular.Location = new Point(9, 151);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(84, 28);
            btncalcular.TabIndex = 8;
            btncalcular.Text = "CALCULAR";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += button1_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnlimpiar.Location = new Point(99, 151);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(75, 28);
            btnlimpiar.TabIndex = 9;
            btnlimpiar.Text = "LIMPIAR";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // txtN1
            // 
            txtN1.Location = new Point(212, 128);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(55, 23);
            txtN1.TabIndex = 10;
            // 
            // txtN2
            // 
            txtN2.Location = new Point(273, 128);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(55, 23);
            txtN2.TabIndex = 11;
            // 
            // txtN3
            // 
            txtN3.Location = new Point(338, 128);
            txtN3.Name = "txtN3";
            txtN3.Size = new Size(55, 23);
            txtN3.TabIndex = 12;
            // 
            // txtN4
            // 
            txtN4.Location = new Point(399, 128);
            txtN4.Name = "txtN4";
            txtN4.Size = new Size(55, 23);
            txtN4.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(15, 208);
            label8.Name = "label8";
            label8.Size = new Size(143, 16);
            label8.TabIndex = 14;
            label8.Text = "PROMEDIO DE NOTAS";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 249);
            label9.Name = "label9";
            label9.Size = new Size(111, 16);
            label9.TabIndex = 15;
            label9.Text = "NOTA MAS BAJA";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(12, 288);
            label10.Name = "label10";
            label10.Size = new Size(82, 16);
            label10.TabIndex = 16;
            label10.Text = "CONDICION";
            // 
            // lblCondicion
            // 
            lblCondicion.AutoSize = true;
            lblCondicion.Location = new Point(177, 288);
            lblCondicion.Name = "lblCondicion";
            lblCondicion.Size = new Size(10, 15);
            lblCondicion.TabIndex = 19;
            lblCondicion.Text = "l";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(177, 249);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(10, 15);
            lblPromedio.TabIndex = 18;
            lblPromedio.Text = "l";
            // 
            // lblNotaBaja
            // 
            lblNotaBaja.AutoSize = true;
            lblNotaBaja.Location = new Point(177, 208);
            lblNotaBaja.Name = "lblNotaBaja";
            lblNotaBaja.Size = new Size(10, 15);
            lblNotaBaja.TabIndex = 17;
            lblNotaBaja.Text = "l";
            // 
            // btnsalir
            // 
            btnsalir.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnsalir.Location = new Point(373, 298);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(78, 28);
            btnsalir.TabIndex = 20;
            btnsalir.Text = "SALIR";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // frmPromedio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(463, 329);
            Controls.Add(btnsalir);
            Controls.Add(lblCondicion);
            Controls.Add(lblPromedio);
            Controls.Add(lblNotaBaja);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtN4);
            Controls.Add(txtN3);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(btnlimpiar);
            Controls.Add(btncalcular);
            Controls.Add(txtnombre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPromedio";
            Text = "frmPromedio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtnombre;
        private Button btncalcular;
        private Button btnlimpiar;
        private TextBox txtN1;
        private TextBox txtN2;
        private TextBox txtN3;
        private TextBox txtN4;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lblCondicion;
        private Label lblPromedio;
        private Label lblNotaBaja;
        private Button btnsalir;
    }
}