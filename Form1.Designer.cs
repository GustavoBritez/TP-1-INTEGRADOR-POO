namespace TP1
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
            DGV_PERSONA = new DataGridView();
            TXT_DNI = new TextBox();
            TXT_NOMBRE = new TextBox();
            TXT_APELLIDO = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BTN_Agregar = new Button();
            BTN_Agregar_Auto = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TXT_Marca = new TextBox();
            TXT_Modelo = new TextBox();
            TXT_Patente = new TextBox();
            TXT_Año = new TextBox();
            label8 = new Label();
            DGV_Autos = new DataGridView();
            label9 = new Label();
            TXT_Precio = new TextBox();
            label10 = new Label();
            DGV_AUTOS_PERSONA = new DataGridView();
            label11 = new Label();
            button1 = new Button();
            DGV_Autos_Con_Dueño = new DataGridView();
            label12 = new Label();
            BTN_Eliminar_Persona = new Button();
            BTN_Eliminar_Auto = new Button();
            BTN_Modificar_Persona = new Button();
            BTN_Modificar_Auto = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_PERSONA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Autos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_AUTOS_PERSONA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Autos_Con_Dueño).BeginInit();
            SuspendLayout();
            // 
            // DGV_PERSONA
            // 
            DGV_PERSONA.AllowUserToAddRows = false;
            DGV_PERSONA.AllowUserToDeleteRows = false;
            DGV_PERSONA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_PERSONA.Location = new Point(12, 233);
            DGV_PERSONA.Name = "DGV_PERSONA";
            DGV_PERSONA.ReadOnly = true;
            DGV_PERSONA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_PERSONA.Size = new Size(258, 150);
            DGV_PERSONA.TabIndex = 0;
            DGV_PERSONA.CellClick += DGV_PERSONA_CellClick;
            // 
            // TXT_DNI
            // 
            TXT_DNI.Location = new Point(12, 64);
            TXT_DNI.Name = "TXT_DNI";
            TXT_DNI.Size = new Size(100, 23);
            TXT_DNI.TabIndex = 1;
            // 
            // TXT_NOMBRE
            // 
            TXT_NOMBRE.Location = new Point(12, 93);
            TXT_NOMBRE.Name = "TXT_NOMBRE";
            TXT_NOMBRE.Size = new Size(100, 23);
            TXT_NOMBRE.TabIndex = 2;
            // 
            // TXT_APELLIDO
            // 
            TXT_APELLIDO.Location = new Point(12, 122);
            TXT_APELLIDO.Name = "TXT_APELLIDO";
            TXT_APELLIDO.Size = new Size(100, 23);
            TXT_APELLIDO.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 215);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 4;
            label1.Text = "Lista de Personas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 72);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 5;
            label2.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 101);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 130);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 7;
            label4.Text = "Apellido";
            // 
            // BTN_Agregar
            // 
            BTN_Agregar.Location = new Point(37, 151);
            BTN_Agregar.Name = "BTN_Agregar";
            BTN_Agregar.Size = new Size(75, 23);
            BTN_Agregar.TabIndex = 8;
            BTN_Agregar.Text = "Agregar";
            BTN_Agregar.UseVisualStyleBackColor = true;
            BTN_Agregar.Click += BTN_Agregar_Click;
            // 
            // BTN_Agregar_Auto
            // 
            BTN_Agregar_Auto.Location = new Point(451, 180);
            BTN_Agregar_Auto.Name = "BTN_Agregar_Auto";
            BTN_Agregar_Auto.Size = new Size(75, 23);
            BTN_Agregar_Auto.TabIndex = 15;
            BTN_Agregar_Auto.Text = "Agregar";
            BTN_Agregar_Auto.UseVisualStyleBackColor = true;
            BTN_Agregar_Auto.Click += BTN_Agregar_Auto_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(532, 95);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 14;
            label5.Text = "Marca";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(532, 67);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 13;
            label6.Text = "Modelo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(532, 37);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 12;
            label7.Text = "Patente";
            // 
            // TXT_Marca
            // 
            TXT_Marca.Location = new Point(426, 87);
            TXT_Marca.Name = "TXT_Marca";
            TXT_Marca.Size = new Size(100, 23);
            TXT_Marca.TabIndex = 11;
            // 
            // TXT_Modelo
            // 
            TXT_Modelo.Location = new Point(426, 58);
            TXT_Modelo.Name = "TXT_Modelo";
            TXT_Modelo.Size = new Size(100, 23);
            TXT_Modelo.TabIndex = 10;
            // 
            // TXT_Patente
            // 
            TXT_Patente.Location = new Point(426, 29);
            TXT_Patente.Name = "TXT_Patente";
            TXT_Patente.Size = new Size(100, 23);
            TXT_Patente.TabIndex = 9;
            // 
            // TXT_Año
            // 
            TXT_Año.Location = new Point(426, 116);
            TXT_Año.Name = "TXT_Año";
            TXT_Año.Size = new Size(100, 23);
            TXT_Año.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(532, 122);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 17;
            label8.Text = "Año";
            // 
            // DGV_Autos
            // 
            DGV_Autos.AllowUserToAddRows = false;
            DGV_Autos.AllowUserToDeleteRows = false;
            DGV_Autos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Autos.Location = new Point(396, 233);
            DGV_Autos.Name = "DGV_Autos";
            DGV_Autos.ReadOnly = true;
            DGV_Autos.Size = new Size(258, 150);
            DGV_Autos.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(486, 215);
            label9.Name = "label9";
            label9.Size = new Size(81, 15);
            label9.TabIndex = 19;
            label9.Text = "Lista de Autos";
            // 
            // TXT_Precio
            // 
            TXT_Precio.Location = new Point(426, 145);
            TXT_Precio.Name = "TXT_Precio";
            TXT_Precio.Size = new Size(100, 23);
            TXT_Precio.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(532, 153);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 21;
            label10.Text = "Precio";
            // 
            // DGV_AUTOS_PERSONA
            // 
            DGV_AUTOS_PERSONA.AllowUserToAddRows = false;
            DGV_AUTOS_PERSONA.AllowUserToDeleteRows = false;
            DGV_AUTOS_PERSONA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_AUTOS_PERSONA.Location = new Point(12, 443);
            DGV_AUTOS_PERSONA.Name = "DGV_AUTOS_PERSONA";
            DGV_AUTOS_PERSONA.ReadOnly = true;
            DGV_AUTOS_PERSONA.Size = new Size(258, 170);
            DGV_AUTOS_PERSONA.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(88, 425);
            label11.Name = "label11";
            label11.Size = new Size(99, 15);
            label11.TabIndex = 23;
            label11.Text = "Autos de Persona";
            // 
            // button1
            // 
            button1.Location = new Point(299, 308);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 24;
            button1.Text = "Asignar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DGV_Autos_Con_Dueño
            // 
            DGV_Autos_Con_Dueño.AllowUserToAddRows = false;
            DGV_Autos_Con_Dueño.AllowUserToDeleteRows = false;
            DGV_Autos_Con_Dueño.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Autos_Con_Dueño.Location = new Point(396, 452);
            DGV_Autos_Con_Dueño.Name = "DGV_Autos_Con_Dueño";
            DGV_Autos_Con_Dueño.ReadOnly = true;
            DGV_Autos_Con_Dueño.Size = new Size(258, 161);
            DGV_Autos_Con_Dueño.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(481, 434);
            label12.Name = "label12";
            label12.Size = new Size(88, 15);
            label12.TabIndex = 26;
            label12.Text = "Todos los autos";
            // 
            // BTN_Eliminar_Persona
            // 
            BTN_Eliminar_Persona.Location = new Point(37, 180);
            BTN_Eliminar_Persona.Name = "BTN_Eliminar_Persona";
            BTN_Eliminar_Persona.Size = new Size(75, 23);
            BTN_Eliminar_Persona.TabIndex = 27;
            BTN_Eliminar_Persona.Text = "Eliminar";
            BTN_Eliminar_Persona.UseVisualStyleBackColor = true;
            BTN_Eliminar_Persona.Click += BTN_Eliminar_Persona_Click;
            // 
            // BTN_Eliminar_Auto
            // 
            BTN_Eliminar_Auto.Location = new Point(542, 180);
            BTN_Eliminar_Auto.Name = "BTN_Eliminar_Auto";
            BTN_Eliminar_Auto.Size = new Size(75, 23);
            BTN_Eliminar_Auto.TabIndex = 28;
            BTN_Eliminar_Auto.Text = "Eliminar";
            BTN_Eliminar_Auto.UseVisualStyleBackColor = true;
            BTN_Eliminar_Auto.Click += BTN_Eliminar_Auto_Click;
            // 
            // BTN_Modificar_Persona
            // 
            BTN_Modificar_Persona.Location = new Point(94, 389);
            BTN_Modificar_Persona.Name = "BTN_Modificar_Persona";
            BTN_Modificar_Persona.Size = new Size(75, 23);
            BTN_Modificar_Persona.TabIndex = 29;
            BTN_Modificar_Persona.Text = "Modificar";
            BTN_Modificar_Persona.UseVisualStyleBackColor = true;
            BTN_Modificar_Persona.Click += BTN_Modificar_Persona_Click;
            // 
            // BTN_Modificar_Auto
            // 
            BTN_Modificar_Auto.Location = new Point(494, 389);
            BTN_Modificar_Auto.Name = "BTN_Modificar_Auto";
            BTN_Modificar_Auto.Size = new Size(75, 23);
            BTN_Modificar_Auto.TabIndex = 30;
            BTN_Modificar_Auto.Text = "Modificar";
            BTN_Modificar_Auto.UseVisualStyleBackColor = true;
            BTN_Modificar_Auto.Click += BTN_Modificar_Auto_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 643);
            Controls.Add(BTN_Modificar_Auto);
            Controls.Add(BTN_Modificar_Persona);
            Controls.Add(BTN_Eliminar_Auto);
            Controls.Add(BTN_Eliminar_Persona);
            Controls.Add(label12);
            Controls.Add(DGV_Autos_Con_Dueño);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(DGV_AUTOS_PERSONA);
            Controls.Add(label10);
            Controls.Add(TXT_Precio);
            Controls.Add(label9);
            Controls.Add(DGV_Autos);
            Controls.Add(label8);
            Controls.Add(TXT_Año);
            Controls.Add(BTN_Agregar_Auto);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(TXT_Marca);
            Controls.Add(TXT_Modelo);
            Controls.Add(TXT_Patente);
            Controls.Add(BTN_Agregar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TXT_APELLIDO);
            Controls.Add(TXT_NOMBRE);
            Controls.Add(TXT_DNI);
            Controls.Add(DGV_PERSONA);
            Name = "Form1";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)DGV_PERSONA).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Autos).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_AUTOS_PERSONA).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Autos_Con_Dueño).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV_PERSONA;
        private TextBox TXT_DNI;
        private TextBox TXT_NOMBRE;
        private TextBox TXT_APELLIDO;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BTN_Agregar;
        private Button BTN_Agregar_Auto;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TXT_Marca;
        private TextBox TXT_Modelo;
        private TextBox TXT_Patente;
        private TextBox TXT_Año;
        private Label label8;
        private DataGridView DGV_Autos;
        private Label label9;
        private TextBox TXT_Precio;
        private Label label10;
        private DataGridView DGV_AUTOS_PERSONA;
        private Label label11;
        private Button button1;
        private DataGridView DGV_Autos_Con_Dueño;
        private Label label12;
        private Button BTN_Eliminar_Persona;
        private Button BTN_Eliminar_Auto;
        private Button BTN_Modificar_Persona;
        private Button BTN_Modificar_Auto;
    }
}
