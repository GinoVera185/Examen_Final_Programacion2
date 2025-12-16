namespace Examen_Final_Programacion2
{
    partial class MenuIngreso
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
            bt_IngresarCiudad = new Button();
            bt_IngresarPais = new Button();
            bt_IngresarProvincia = new Button();
            bt_regresar = new Button();
            SuspendLayout();
            // 
            // bt_IngresarCiudad
            // 
            bt_IngresarCiudad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_IngresarCiudad.Location = new Point(24, 151);
            bt_IngresarCiudad.Name = "bt_IngresarCiudad";
            bt_IngresarCiudad.Size = new Size(179, 55);
            bt_IngresarCiudad.TabIndex = 5;
            bt_IngresarCiudad.Text = "Ciudad";
            bt_IngresarCiudad.UseVisualStyleBackColor = true;
            // 
            // bt_IngresarPais
            // 
            bt_IngresarPais.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_IngresarPais.Location = new Point(24, 29);
            bt_IngresarPais.Name = "bt_IngresarPais";
            bt_IngresarPais.Size = new Size(179, 55);
            bt_IngresarPais.TabIndex = 4;
            bt_IngresarPais.Text = "Pais";
            bt_IngresarPais.UseVisualStyleBackColor = true;
            // 
            // bt_IngresarProvincia
            // 
            bt_IngresarProvincia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_IngresarProvincia.Location = new Point(24, 90);
            bt_IngresarProvincia.Name = "bt_IngresarProvincia";
            bt_IngresarProvincia.Size = new Size(179, 55);
            bt_IngresarProvincia.TabIndex = 3;
            bt_IngresarProvincia.Text = "Provincia";
            bt_IngresarProvincia.UseVisualStyleBackColor = true;
            // 
            // bt_regresar
            // 
            bt_regresar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_regresar.Location = new Point(24, 212);
            bt_regresar.Name = "bt_regresar";
            bt_regresar.Size = new Size(179, 55);
            bt_regresar.TabIndex = 6;
            bt_regresar.Text = "Regresar";
            bt_regresar.UseVisualStyleBackColor = true;
            // 
            // MenuIngreso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 300);
            Controls.Add(bt_regresar);
            Controls.Add(bt_IngresarCiudad);
            Controls.Add(bt_IngresarPais);
            Controls.Add(bt_IngresarProvincia);
            Name = "MenuIngreso";
            Text = "MenuIngreso";
            ResumeLayout(false);
        }

        #endregion

        private Button bt_IngresarCiudad;
        private Button bt_IngresarPais;
        private Button bt_IngresarProvincia;
        private Button bt_regresar;
    }
}