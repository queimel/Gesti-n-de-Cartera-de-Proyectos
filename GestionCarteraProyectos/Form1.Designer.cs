namespace GestionCarteraProyectos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_periodo = new System.Windows.Forms.TextBox();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.tb_duracion = new System.Windows.Forms.TextBox();
            this.tb_montoTotal1 = new System.Windows.Forms.TextBox();
            this.cb_nivel1 = new System.Windows.Forms.ComboBox();
            this.dt_fecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_nProyectosCarpeta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_nivel2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_montoDesde = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_hasta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_cantidad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_montoTotal2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_promedioMeses = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_promedio = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_reestablecer = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.l_mensajes = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "[ Datos del Proyecto ]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(587, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "[ Acciones sobre proyecto ]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Periodo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Código";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Duración";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nivel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Monto Total";
            // 
            // tb_periodo
            // 
            this.tb_periodo.Location = new System.Drawing.Point(158, 78);
            this.tb_periodo.Name = "tb_periodo";
            this.tb_periodo.Size = new System.Drawing.Size(69, 20);
            this.tb_periodo.TabIndex = 8;
            // 
            // tb_codigo
            // 
            this.tb_codigo.Location = new System.Drawing.Point(158, 126);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(276, 20);
            this.tb_codigo.TabIndex = 9;
            // 
            // tb_duracion
            // 
            this.tb_duracion.Location = new System.Drawing.Point(158, 226);
            this.tb_duracion.Name = "tb_duracion";
            this.tb_duracion.Size = new System.Drawing.Size(104, 20);
            this.tb_duracion.TabIndex = 11;
            // 
            // tb_montoTotal1
            // 
            this.tb_montoTotal1.Location = new System.Drawing.Point(158, 326);
            this.tb_montoTotal1.Name = "tb_montoTotal1";
            this.tb_montoTotal1.Size = new System.Drawing.Size(276, 20);
            this.tb_montoTotal1.TabIndex = 12;
            // 
            // cb_nivel1
            // 
            this.cb_nivel1.FormattingEnabled = true;
            this.cb_nivel1.Location = new System.Drawing.Point(158, 272);
            this.cb_nivel1.Name = "cb_nivel1";
            this.cb_nivel1.Size = new System.Drawing.Size(276, 21);
            this.cb_nivel1.TabIndex = 13;
            // 
            // dt_fecha
            // 
            this.dt_fecha.CustomFormat = "dd/MM/yy";
            this.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fecha.Location = new System.Drawing.Point(158, 172);
            this.dt_fecha.MaxDate = new System.DateTime(2018, 7, 21, 0, 0, 0, 0);
            this.dt_fecha.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(276, 20);
            this.dt_fecha.TabIndex = 14;
            this.dt_fecha.Value = new System.DateTime(2018, 7, 21, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(300, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Meses";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(598, 98);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(200, 47);
            this.btn_agregar.TabIndex = 16;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(599, 173);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(200, 47);
            this.btn_eliminar.TabIndex = 17;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(557, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(272, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "[ número de Proyectos en Carpeta ]";
            // 
            // tb_nProyectosCarpeta
            // 
            this.tb_nProyectosCarpeta.Location = new System.Drawing.Point(642, 285);
            this.tb_nProyectosCarpeta.Multiline = true;
            this.tb_nProyectosCarpeta.Name = "tb_nProyectosCarpeta";
            this.tb_nProyectosCarpeta.Size = new System.Drawing.Size(93, 61);
            this.tb_nProyectosCarpeta.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.tb_hasta);
            this.groupBox1.Controls.Add(this.tb_montoDesde);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cb_nivel2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 157);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Parámetros de Consulta ]";
            // 
            // cb_nivel2
            // 
            this.cb_nivel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cb_nivel2.FormattingEnabled = true;
            this.cb_nivel2.Location = new System.Drawing.Point(162, 33);
            this.cb_nivel2.Name = "cb_nivel2";
            this.cb_nivel2.Size = new System.Drawing.Size(276, 27);
            this.cb_nivel2.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 19);
            this.label12.TabIndex = 23;
            this.label12.Text = "Nivel";
            // 
            // tb_montoDesde
            // 
            this.tb_montoDesde.Location = new System.Drawing.Point(162, 95);
            this.tb_montoDesde.Name = "tb_montoDesde";
            this.tb_montoDesde.Size = new System.Drawing.Size(276, 27);
            this.tb_montoDesde.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "Monto Desde";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(492, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 19);
            this.label13.TabIndex = 26;
            this.label13.Text = "Hasta";
            // 
            // tb_hasta
            // 
            this.tb_hasta.Location = new System.Drawing.Point(574, 95);
            this.tb_hasta.Name = "tb_hasta";
            this.tb_hasta.Size = new System.Drawing.Size(216, 27);
            this.tb_hasta.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.tb_promedio);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.tb_promedioMeses);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.tb_montoTotal2);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tb_cantidad);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 574);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(832, 149);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[ Resultados Consulta General ]";
            // 
            // tb_cantidad
            // 
            this.tb_cantidad.Location = new System.Drawing.Point(162, 42);
            this.tb_cantidad.Name = "tb_cantidad";
            this.tb_cantidad.Size = new System.Drawing.Size(108, 27);
            this.tb_cantidad.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 19);
            this.label14.TabIndex = 28;
            this.label14.Text = "Cantidad";
            // 
            // tb_montoTotal2
            // 
            this.tb_montoTotal2.Location = new System.Drawing.Point(162, 92);
            this.tb_montoTotal2.Name = "tb_montoTotal2";
            this.tb_montoTotal2.Size = new System.Drawing.Size(276, 27);
            this.tb_montoTotal2.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 19);
            this.label15.TabIndex = 28;
            this.label15.Text = "Monto Total";
            // 
            // tb_promedioMeses
            // 
            this.tb_promedioMeses.Location = new System.Drawing.Point(585, 33);
            this.tb_promedioMeses.Name = "tb_promedioMeses";
            this.tb_promedioMeses.Size = new System.Drawing.Size(99, 27);
            this.tb_promedioMeses.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(492, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 19);
            this.label16.TabIndex = 30;
            this.label16.Text = "Promedio";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(690, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 19);
            this.label17.TabIndex = 32;
            this.label17.Text = "Meses";
            // 
            // tb_promedio
            // 
            this.tb_promedio.Location = new System.Drawing.Point(585, 90);
            this.tb_promedio.Name = "tb_promedio";
            this.tb_promedio.Size = new System.Drawing.Size(205, 27);
            this.tb_promedio.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(492, 95);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 19);
            this.label18.TabIndex = 33;
            this.label18.Text = "Promedio";
            // 
            // btn_consultar
            // 
            this.btn_consultar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Location = new System.Drawing.Point(16, 749);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(200, 47);
            this.btn_consultar.TabIndex = 25;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            // 
            // btn_reestablecer
            // 
            this.btn_reestablecer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reestablecer.Location = new System.Drawing.Point(332, 749);
            this.btn_reestablecer.Name = "btn_reestablecer";
            this.btn_reestablecer.Size = new System.Drawing.Size(200, 47);
            this.btn_reestablecer.TabIndex = 26;
            this.btn_reestablecer.Text = "Reestablecer";
            this.btn_reestablecer.UseVisualStyleBackColor = true;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.Location = new System.Drawing.Point(648, 749);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(200, 47);
            this.btn_cerrar.TabIndex = 27;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            // 
            // l_mensajes
            // 
            this.l_mensajes.AutoSize = true;
            this.l_mensajes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_mensajes.ForeColor = System.Drawing.Color.Red;
            this.l_mensajes.Location = new System.Drawing.Point(12, 825);
            this.l_mensajes.MaximumSize = new System.Drawing.Size(800, 0);
            this.l_mensajes.Name = "l_mensajes";
            this.l_mensajes.Size = new System.Drawing.Size(155, 19);
            this.l_mensajes.TabIndex = 28;
            this.l_mensajes.Text = "Zona de Mensajes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 897);
            this.Controls.Add(this.l_mensajes);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_reestablecer);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_nProyectosCarpeta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dt_fecha);
            this.Controls.Add(this.cb_nivel1);
            this.Controls.Add(this.tb_montoTotal1);
            this.Controls.Add(this.tb_duracion);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.tb_periodo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Gestión de Carpeta de Proyectos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_periodo;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.TextBox tb_duracion;
        private System.Windows.Forms.TextBox tb_montoTotal1;
        private System.Windows.Forms.ComboBox cb_nivel1;
        private System.Windows.Forms.DateTimePicker dt_fecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_nProyectosCarpeta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_hasta;
        private System.Windows.Forms.TextBox tb_montoDesde;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_nivel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_promedioMeses;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_montoTotal2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_cantidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_promedio;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_reestablecer;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label l_mensajes;
    }
}

