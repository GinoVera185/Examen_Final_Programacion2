namespace Examen_Final_Programacion2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            lbl_Pais = new Label();
            txt_pais = new TextBox();
            bt_Guardar = new Button();
            bt_Cancelar = new Button();
            nUD_CodigoPais = new NumericUpDown();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)nUD_CodigoPais).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // lbl_Pais
            // 
            resources.ApplyResources(lbl_Pais, "lbl_Pais");
            lbl_Pais.Name = "lbl_Pais";
            // 
            // txt_pais
            // 
            resources.ApplyResources(txt_pais, "txt_pais");
            txt_pais.Name = "txt_pais";
            txt_pais.TextChanged += txt_pais_TextChanged;
            // 
            // bt_Guardar
            // 
            resources.ApplyResources(bt_Guardar, "bt_Guardar");
            bt_Guardar.Name = "bt_Guardar";
            bt_Guardar.UseVisualStyleBackColor = true;
            bt_Guardar.Click += bt_Guardar_Click;
            // 
            // bt_Cancelar
            // 
            resources.ApplyResources(bt_Cancelar, "bt_Cancelar");
            bt_Cancelar.Name = "bt_Cancelar";
            bt_Cancelar.UseVisualStyleBackColor = true;
            bt_Cancelar.Click += bt_Cancelar_Click;
            // 
            // nUD_CodigoPais
            // 
            resources.ApplyResources(nUD_CodigoPais, "nUD_CodigoPais");
            nUD_CodigoPais.Name = "nUD_CodigoPais";
            nUD_CodigoPais.ValueChanged += nUD_CodigoPais_ValueChanged;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // Form2
            // 
            AcceptButton = bt_Guardar;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = bt_Cancelar;
            Controls.Add(label6);
            Controls.Add(nUD_CodigoPais);
            Controls.Add(bt_Cancelar);
            Controls.Add(bt_Guardar);
            Controls.Add(txt_pais);
            Controls.Add(lbl_Pais);
            Controls.Add(label1);
            Name = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)nUD_CodigoPais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_Pais;
        private TextBox txt_pais;
        private Button bt_Guardar;
        private Button bt_Cancelar;
        private NumericUpDown nUD_CodigoPais;
        private Label label6;
    }
}