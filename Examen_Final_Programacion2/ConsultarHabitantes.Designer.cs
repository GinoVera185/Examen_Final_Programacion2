namespace Examen_Final_Programacion2
{
    partial class ConsultarHabitantes
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
            cmb_provincia = new ComboBox();
            label2 = new Label();
            cmb_pais = new ComboBox();
            label3 = new Label();
            cmb_ciudad = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_HabitantesPais = new TextBox();
            txt_HabitantesProv = new TextBox();
            txt_HabitantesCiu = new TextBox();
            bt_Regresar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(266, 9);
            label1.Name = "label1";
            label1.Size = new Size(208, 31);
            label1.TabIndex = 0;
            label1.Text = "Menu de Consulta";
            // 
            // cmb_provincia
            // 
            cmb_provincia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_provincia.FormattingEnabled = true;
            cmb_provincia.Location = new Point(129, 110);
            cmb_provincia.MaxDropDownItems = 20;
            cmb_provincia.Name = "cmb_provincia";
            cmb_provincia.Size = new Size(202, 36);
            cmb_provincia.TabIndex = 2;
            cmb_provincia.SelectedIndexChanged += cmb_provincia_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 113);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 10;
            label2.Text = "Provincia: ";
            // 
            // cmb_pais
            // 
            cmb_pais.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_pais.FormattingEnabled = true;
            cmb_pais.Location = new Point(129, 61);
            cmb_pais.MaxDropDownItems = 20;
            cmb_pais.Name = "cmb_pais";
            cmb_pais.Size = new Size(202, 36);
            cmb_pais.TabIndex = 1;
            cmb_pais.SelectedIndexChanged += cmb_pais_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 61);
            label3.Name = "label3";
            label3.Size = new Size(61, 28);
            label3.TabIndex = 9;
            label3.Text = "Pais: ";
            // 
            // cmb_ciudad
            // 
            cmb_ciudad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_ciudad.FormattingEnabled = true;
            cmb_ciudad.Location = new Point(129, 161);
            cmb_ciudad.MaxDropDownItems = 20;
            cmb_ciudad.Name = "cmb_ciudad";
            cmb_ciudad.Size = new Size(202, 36);
            cmb_ciudad.TabIndex = 3;
            cmb_ciudad.SelectedIndexChanged += cmb_ciudad_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 164);
            label4.Name = "label4";
            label4.Size = new Size(82, 28);
            label4.TabIndex = 12;
            label4.Text = "Ciudad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(354, 61);
            label5.Name = "label5";
            label5.Size = new Size(120, 28);
            label5.TabIndex = 13;
            label5.Text = "Habitantes:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(354, 113);
            label6.Name = "label6";
            label6.Size = new Size(120, 28);
            label6.TabIndex = 14;
            label6.Text = "Habitantes:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(354, 164);
            label7.Name = "label7";
            label7.Size = new Size(120, 28);
            label7.TabIndex = 15;
            label7.Text = "Habitantes:";
            // 
            // txt_HabitantesPais
            // 
            txt_HabitantesPais.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_HabitantesPais.Location = new Point(490, 59);
            txt_HabitantesPais.Name = "txt_HabitantesPais";
            txt_HabitantesPais.ReadOnly = true;
            txt_HabitantesPais.Size = new Size(291, 34);
            txt_HabitantesPais.TabIndex = 16;
            // 
            // txt_HabitantesProv
            // 
            txt_HabitantesProv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_HabitantesProv.Location = new Point(490, 117);
            txt_HabitantesProv.Name = "txt_HabitantesProv";
            txt_HabitantesProv.ReadOnly = true;
            txt_HabitantesProv.Size = new Size(291, 34);
            txt_HabitantesProv.TabIndex = 17;
            // 
            // txt_HabitantesCiu
            // 
            txt_HabitantesCiu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_HabitantesCiu.Location = new Point(490, 168);
            txt_HabitantesCiu.Name = "txt_HabitantesCiu";
            txt_HabitantesCiu.ReadOnly = true;
            txt_HabitantesCiu.Size = new Size(291, 34);
            txt_HabitantesCiu.TabIndex = 18;
            // 
            // bt_Regresar
            // 
            bt_Regresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_Regresar.Location = new Point(657, 225);
            bt_Regresar.Name = "bt_Regresar";
            bt_Regresar.Size = new Size(124, 50);
            bt_Regresar.TabIndex = 4;
            bt_Regresar.Text = "Regresar";
            bt_Regresar.UseVisualStyleBackColor = true;
            bt_Regresar.Click += bt_Regresar_Click;
            // 
            // ConsultarHabitantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 287);
            Controls.Add(bt_Regresar);
            Controls.Add(txt_HabitantesCiu);
            Controls.Add(txt_HabitantesProv);
            Controls.Add(txt_HabitantesPais);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cmb_ciudad);
            Controls.Add(label4);
            Controls.Add(cmb_provincia);
            Controls.Add(label2);
            Controls.Add(cmb_pais);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "ConsultarHabitantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultarHabitantes";
            Load += ConsultarHabitantes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmb_provincia;
        private Label label2;
        private ComboBox cmb_pais;
        private Label label3;
        private ComboBox cmb_ciudad;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_HabitantesPais;
        private TextBox txt_HabitantesProv;
        private TextBox txt_HabitantesCiu;
        private Button button1;
        private Button bt_Regresar;
    }
}