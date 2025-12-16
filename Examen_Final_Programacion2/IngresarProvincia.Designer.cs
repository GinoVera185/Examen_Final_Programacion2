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
            txt_codigo = new TextBox();
            txt_Provincia = new TextBox();
            bt_AgregarProvincia = new Button();
            dataGridView1 = new DataGridView();
            ColNombrePais = new DataGridViewTextBoxColumn();
            ColCodigoProvincia = new DataGridViewTextBoxColumn();
            ColProvincia = new DataGridViewTextBoxColumn();
            bt_Cancelar = new Button();
            bt_Guardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(61, 28);
            label1.TabIndex = 0;
            label1.Text = "Pais: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 68);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 1;
            label2.Text = "Código: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 102);
            label3.Name = "label3";
            label3.Size = new Size(111, 28);
            label3.TabIndex = 2;
            label3.Text = "Provincia: ";
            // 
            // cmb_pais
            // 
            cmb_pais.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_pais.FormattingEnabled = true;
            cmb_pais.Location = new Point(86, 23);
            cmb_pais.Name = "cmb_pais";
            cmb_pais.Size = new Size(160, 36);
            cmb_pais.TabIndex = 3;
            // 
            // txt_codigo
            // 
            txt_codigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_codigo.Location = new Point(102, 65);
            txt_codigo.MaxLength = 20;
            txt_codigo.Name = "txt_codigo";
            txt_codigo.Size = new Size(144, 34);
            txt_codigo.TabIndex = 4;
            // 
            // txt_Provincia
            // 
            txt_Provincia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Provincia.Location = new Point(124, 102);
            txt_Provincia.MaxLength = 20;
            txt_Provincia.Name = "txt_Provincia";
            txt_Provincia.Size = new Size(191, 34);
            txt_Provincia.TabIndex = 5;
            // 
            // bt_AgregarProvincia
            // 
            bt_AgregarProvincia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_AgregarProvincia.Location = new Point(321, 102);
            bt_AgregarProvincia.Name = "bt_AgregarProvincia";
            bt_AgregarProvincia.Size = new Size(125, 40);
            bt_AgregarProvincia.TabIndex = 6;
            bt_AgregarProvincia.Text = "Agregar";
            bt_AgregarProvincia.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColNombrePais, ColCodigoProvincia, ColProvincia });
            dataGridView1.Location = new Point(21, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(500, 187);
            dataGridView1.TabIndex = 7;
            // 
            // ColNombrePais
            // 
            ColNombrePais.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColNombrePais.HeaderText = "País";
            ColNombrePais.MinimumWidth = 6;
            ColNombrePais.Name = "ColNombrePais";
            ColNombrePais.ReadOnly = true;
            // 
            // ColCodigoProvincia
            // 
            ColCodigoProvincia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColCodigoProvincia.HeaderText = "Código_Provincia";
            ColCodigoProvincia.MinimumWidth = 6;
            ColCodigoProvincia.Name = "ColCodigoProvincia";
            ColCodigoProvincia.ReadOnly = true;
            // 
            // ColProvincia
            // 
            ColProvincia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColProvincia.HeaderText = "Provincia";
            ColProvincia.MinimumWidth = 6;
            ColProvincia.Name = "ColProvincia";
            ColProvincia.ReadOnly = true;
            // 
            // bt_Cancelar
            // 
            bt_Cancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_Cancelar.Location = new Point(419, 353);
            bt_Cancelar.Name = "bt_Cancelar";
            bt_Cancelar.Size = new Size(102, 37);
            bt_Cancelar.TabIndex = 9;
            bt_Cancelar.Text = "Cancelar";
            bt_Cancelar.UseVisualStyleBackColor = true;
            // 
            // bt_Guardar
            // 
            bt_Guardar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_Guardar.Location = new Point(298, 353);
            bt_Guardar.Name = "bt_Guardar";
            bt_Guardar.Size = new Size(102, 37);
            bt_Guardar.TabIndex = 8;
            bt_Guardar.Text = "Guardar";
            bt_Guardar.UseVisualStyleBackColor = true;
            // 
            // IngresarProvincia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 401);
            Controls.Add(bt_Cancelar);
            Controls.Add(bt_Guardar);
            Controls.Add(dataGridView1);
            Controls.Add(bt_AgregarProvincia);
            Controls.Add(txt_Provincia);
            Controls.Add(txt_codigo);
            Controls.Add(cmb_pais);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "IngresarProvincia";
            Text = "IngresarProvincia";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmb_pais;
        private TextBox txt_codigo;
        private TextBox txt_Provincia;
        private Button bt_AgregarProvincia;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColNombrePais;
        private DataGridViewTextBoxColumn ColCodigoProvincia;
        private DataGridViewTextBoxColumn ColProvincia;
        private Button bt_Cancelar;
        private Button bt_Guardar;
    }
}