namespace Examen_Final_Programacion2
{
    partial class IngresarCiudad
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
            cmb_pais = new ComboBox();
            label1 = new Label();
            cmb_provincia = new ComboBox();
            label2 = new Label();
            nUD_CodigoCiudad = new NumericUpDown();
            label3 = new Label();
            txt_Ciudad = new TextBox();
            label4 = new Label();
            bt_Cancelar = new Button();
            bt_Guardar = new Button();
            nUD_Habitantes = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)nUD_CodigoCiudad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUD_Habitantes).BeginInit();
            SuspendLayout();
            // 
            // cmb_pais
            // 
            cmb_pais.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_pais.FormattingEnabled = true;
            cmb_pais.Location = new Point(138, 73);
            cmb_pais.Name = "cmb_pais";
            cmb_pais.Size = new Size(202, 36);
            cmb_pais.TabIndex = 1;
            cmb_pais.SelectedIndexChanged += cmb_pais_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 73);
            label1.Name = "label1";
            label1.Size = new Size(61, 28);
            label1.TabIndex = 4;
            label1.Text = "Pais: ";
            // 
            // cmb_provincia
            // 
            cmb_provincia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_provincia.FormattingEnabled = true;
            cmb_provincia.Location = new Point(138, 122);
            cmb_provincia.Name = "cmb_provincia";
            cmb_provincia.Size = new Size(202, 36);
            cmb_provincia.TabIndex = 2;
            cmb_provincia.SelectedIndexChanged += cmb_provincia_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 125);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 6;
            label2.Text = "Provincia: ";
            // 
            // nUD_CodigoCiudad
            // 
            nUD_CodigoCiudad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nUD_CodigoCiudad.Location = new Point(136, 167);
            nUD_CodigoCiudad.Name = "nUD_CodigoCiudad";
            nUD_CodigoCiudad.Size = new Size(204, 34);
            nUD_CodigoCiudad.TabIndex = 3;
            nUD_CodigoCiudad.ValueChanged += nUD_CodigoCiudad_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 169);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 11;
            label3.Text = "Código: ";
            // 
            // txt_Ciudad
            // 
            txt_Ciudad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Ciudad.Location = new Point(136, 216);
            txt_Ciudad.MaxLength = 20;
            txt_Ciudad.Name = "txt_Ciudad";
            txt_Ciudad.Size = new Size(204, 34);
            txt_Ciudad.TabIndex = 4;
            txt_Ciudad.TextChanged += txt_Ciudad_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 216);
            label4.Name = "label4";
            label4.Size = new Size(88, 28);
            label4.TabIndex = 13;
            label4.Text = "Ciudad: ";
            // 
            // bt_Cancelar
            // 
            bt_Cancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_Cancelar.Location = new Point(238, 330);
            bt_Cancelar.Name = "bt_Cancelar";
            bt_Cancelar.Size = new Size(102, 37);
            bt_Cancelar.TabIndex = 7;
            bt_Cancelar.Text = "Cancelar";
            bt_Cancelar.UseVisualStyleBackColor = true;
            bt_Cancelar.Click += bt_Cancelar_Click;
            // 
            // bt_Guardar
            // 
            bt_Guardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_Guardar.Location = new Point(130, 330);
            bt_Guardar.Name = "bt_Guardar";
            bt_Guardar.Size = new Size(102, 37);
            bt_Guardar.TabIndex = 6;
            bt_Guardar.Text = "Guardar";
            bt_Guardar.UseVisualStyleBackColor = true;
            bt_Guardar.Click += bt_Guardar_Click;
            // 
            // nUD_Habitantes
            // 
            nUD_Habitantes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nUD_Habitantes.Location = new Point(136, 271);
            nUD_Habitantes.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nUD_Habitantes.Name = "nUD_Habitantes";
            nUD_Habitantes.Size = new Size(204, 34);
            nUD_Habitantes.TabIndex = 5;
            nUD_Habitantes.ValueChanged += nUD_Habitantes_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 271);
            label5.Name = "label5";
            label5.Size = new Size(126, 28);
            label5.TabIndex = 17;
            label5.Text = "Habitantes: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(73, 9);
            label6.Name = "label6";
            label6.Size = new Size(188, 31);
            label6.TabIndex = 18;
            label6.Text = "Ingresar Ciudad:";
            // 
            // IngresarCiudad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 379);
            Controls.Add(label6);
            Controls.Add(nUD_Habitantes);
            Controls.Add(label5);
            Controls.Add(bt_Cancelar);
            Controls.Add(bt_Guardar);
            Controls.Add(txt_Ciudad);
            Controls.Add(label4);
            Controls.Add(nUD_CodigoCiudad);
            Controls.Add(label3);
            Controls.Add(cmb_provincia);
            Controls.Add(label2);
            Controls.Add(cmb_pais);
            Controls.Add(label1);
            Name = "IngresarCiudad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingresar Ciudad";
            Load += IngresarCiudad_Load;
            ((System.ComponentModel.ISupportInitialize)nUD_CodigoCiudad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUD_Habitantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_pais;
        private Label label1;
        private ComboBox cmb_provincia;
        private Label label2;
        private NumericUpDown nUD_CodigoCiudad;
        private Label label3;
        private TextBox txt_Ciudad;
        private Label label4;
        private Button bt_Cancelar;
        private Button bt_Guardar;
        private NumericUpDown nUD_Habitantes;
        private Label label5;
        private Label label6;
    }
}