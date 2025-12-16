namespace Examen_Final_Programacion2
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
            bt_consultar = new Button();
            bt_Ingresar = new Button();
            bt_salir = new Button();
            SuspendLayout();
            // 
            // bt_consultar
            // 
            bt_consultar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_consultar.Location = new Point(45, 94);
            bt_consultar.Name = "bt_consultar";
            bt_consultar.Size = new Size(179, 55);
            bt_consultar.TabIndex = 0;
            bt_consultar.Text = "Consultar";
            bt_consultar.UseVisualStyleBackColor = true;
            // 
            // bt_Ingresar
            // 
            bt_Ingresar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_Ingresar.Location = new Point(45, 33);
            bt_Ingresar.Name = "bt_Ingresar";
            bt_Ingresar.Size = new Size(179, 55);
            bt_Ingresar.TabIndex = 1;
            bt_Ingresar.Text = "Ingresar";
            bt_Ingresar.UseVisualStyleBackColor = true;
            // 
            // bt_salir
            // 
            bt_salir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_salir.Location = new Point(45, 155);
            bt_salir.Name = "bt_salir";
            bt_salir.Size = new Size(179, 55);
            bt_salir.TabIndex = 2;
            bt_salir.Text = "Salir";
            bt_salir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 248);
            Controls.Add(bt_salir);
            Controls.Add(bt_Ingresar);
            Controls.Add(bt_consultar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button bt_consultar;
        private Button bt_Ingresar;
        private Button bt_salir;
    }
}
