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
            label1 = new Label();
            txt_codigo = new TextBox();
            lbl_Pais = new Label();
            txt_pais = new TextBox();
            bt_Guardar = new Button();
            bt_Cancelar = new Button();
            dgv_pais = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colPais = new DataGridViewTextBoxColumn();
            bt_Agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_pais).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 29);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // txt_codigo
            // 
            txt_codigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_codigo.Location = new Point(124, 23);
            txt_codigo.MaxLength = 20;
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(124, 34);
            txt_codigo.TabIndex = 1;
            // 
            // lbl_Pais
            // 
            lbl_Pais.AutoSize = true;
            lbl_Pais.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Pais.Location = new Point(25, 74);
            lbl_Pais.Name = "lbl_Pais";
            lbl_Pais.Size = new Size(55, 28);
            lbl_Pais.TabIndex = 2;
            lbl_Pais.Text = "Pais:";
            // 
            // txt_pais
            // 
            txt_pais.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_pais.Location = new Point(86, 74);
            txt_pais.MaxLength = 20;
            txt_pais.Name = "txt_pais";
            txt_pais.Size = new Size(162, 34);
            txt_pais.TabIndex = 3;
            // 
            // bt_Guardar
            // 
            bt_Guardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_Guardar.Location = new Point(139, 300);
            bt_Guardar.Name = "bt_Guardar";
            bt_Guardar.Size = new Size(102, 37);
            bt_Guardar.TabIndex = 4;
            bt_Guardar.Text = "Guardar";
            bt_Guardar.UseVisualStyleBackColor = true;
            bt_Guardar.Click += bt_Guardar_Click;
            // 
            // bt_Cancelar
            // 
            bt_Cancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_Cancelar.Location = new Point(260, 300);
            bt_Cancelar.Name = "bt_Cancelar";
            bt_Cancelar.Size = new Size(102, 37);
            bt_Cancelar.TabIndex = 5;
            bt_Cancelar.Text = "Cancelar";
            bt_Cancelar.UseVisualStyleBackColor = true;
            // 
            // dgv_pais
            // 
            dgv_pais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_pais.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colPais });
            dgv_pais.Location = new Point(14, 129);
            dgv_pais.Name = "dgv_pais";
            dgv_pais.RowHeadersWidth = 51;
            dgv_pais.Size = new Size(348, 156);
            dgv_pais.TabIndex = 6;
            // 
            // colCodigo
            // 
            colCodigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCodigo.HeaderText = "Código";
            colCodigo.MinimumWidth = 6;
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colPais
            // 
            colPais.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPais.HeaderText = "País";
            colPais.MinimumWidth = 6;
            colPais.Name = "colPais";
            colPais.ReadOnly = true;
            // 
            // bt_Agregar
            // 
            bt_Agregar.Location = new Point(264, 74);
            bt_Agregar.Name = "bt_Agregar";
            bt_Agregar.Size = new Size(98, 34);
            bt_Agregar.TabIndex = 7;
            bt_Agregar.Text = "Agregar";
            bt_Agregar.UseVisualStyleBackColor = true;
            bt_Agregar.Click += bt_Agregar_Click;
            // 
            // Form2
            // 
            AcceptButton = bt_Guardar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CancelButton = bt_Cancelar;
            ClientSize = new Size(374, 356);
            Controls.Add(bt_Agregar);
            Controls.Add(dgv_pais);
            Controls.Add(bt_Cancelar);
            Controls.Add(bt_Guardar);
            Controls.Add(txt_pais);
            Controls.Add(lbl_Pais);
            Controls.Add(txt_codigo);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgv_pais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_codigo;
        private Label lbl_Pais;
        private TextBox txt_pais;
        private Button bt_Guardar;
        private Button bt_Cancelar;
        private DataGridView dgv_pais;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colPais;
        private Button bt_Agregar;
    }
}