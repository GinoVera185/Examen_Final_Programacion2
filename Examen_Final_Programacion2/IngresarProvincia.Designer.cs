namespace Examen_Final_Programacion2
{
    partial class IngresarProvincia
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
            cmb_pais = new ComboBox();
            txt_Provincia = new TextBox();
            bt_Cancelar = new Button();
            bt_Guardar = new Button();
            nUD_CodigoProv = new NumericUpDown();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)nUD_CodigoProv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 51);
            label1.Name = "label1";
            label1.Size = new Size(61, 28);
            label1.TabIndex = 0;
            label1.Text = "Pais: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 98);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 1;
            label2.Text = "Código: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 136);
            label3.Name = "label3";
            label3.Size = new Size(111, 28);
            label3.TabIndex = 2;
            label3.Text = "Provincia: ";
            // 
            // cmb_pais
            // 
            cmb_pais.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_pais.FormattingEnabled = true;
            cmb_pais.Location = new Point(122, 54);
            cmb_pais.Name = "cmb_pais";
            cmb_pais.Size = new Size(191, 36);
            cmb_pais.TabIndex = 3;
            cmb_pais.SelectedIndexChanged += cmb_pais_SelectedIndexChanged;
            // 
            // txt_Provincia
            // 
            txt_Provincia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Provincia.Location = new Point(122, 136);
            txt_Provincia.MaxLength = 20;
            txt_Provincia.Name = "txt_Provincia";
            txt_Provincia.Size = new Size(191, 34);
            txt_Provincia.TabIndex = 5;
            txt_Provincia.TextChanged += txt_Provincia_TextChanged;
            // 
            // bt_Cancelar
            // 
            bt_Cancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_Cancelar.Location = new Point(211, 176);
            bt_Cancelar.Name = "bt_Cancelar";
            bt_Cancelar.Size = new Size(102, 37);
            bt_Cancelar.TabIndex = 9;
            bt_Cancelar.Text = "Cancelar";
            bt_Cancelar.UseVisualStyleBackColor = true;
            bt_Cancelar.Click += bt_Cancelar_Click;
            // 
            // bt_Guardar
            // 
            bt_Guardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_Guardar.Location = new Point(90, 176);
            bt_Guardar.Name = "bt_Guardar";
            bt_Guardar.Size = new Size(102, 37);
            bt_Guardar.TabIndex = 8;
            bt_Guardar.Text = "Guardar";
            bt_Guardar.UseVisualStyleBackColor = true;
            bt_Guardar.Click += bt_Guardar_Click;
            // 
            // nUD_CodigoProv
            // 
            nUD_CodigoProv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nUD_CodigoProv.Location = new Point(122, 96);
            nUD_CodigoProv.Name = "nUD_CodigoProv";
            nUD_CodigoProv.Size = new Size(191, 34);
            nUD_CodigoProv.TabIndex = 10;
            nUD_CodigoProv.ValueChanged += nUD_CodigoProv_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(61, 9);
            label6.Name = "label6";
            label6.Size = new Size(213, 31);
            label6.TabIndex = 19;
            label6.Text = "Ingresar provincia:";
            // 
            // IngresarProvincia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 240);
            Controls.Add(label6);
            Controls.Add(nUD_CodigoProv);
            Controls.Add(bt_Cancelar);
            Controls.Add(bt_Guardar);
            Controls.Add(txt_Provincia);
            Controls.Add(cmb_pais);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "IngresarProvincia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingresar Provincia";
            Load += IngresarProvincia_Load;
            ((System.ComponentModel.ISupportInitialize)nUD_CodigoProv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmb_pais;
        private TextBox txt_Provincia;
        private Button bt_Cancelar;
        private Button bt_Guardar;
        private NumericUpDown nUD_CodigoProv;
        private Label label6;
    }
}