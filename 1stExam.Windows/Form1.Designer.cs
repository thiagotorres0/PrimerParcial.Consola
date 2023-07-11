namespace _1stExam.Windows
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
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            btn_Ok = new Button();
            btnCancelar = new Button();
            txtArea = new TextBox();
            txtAltura = new TextBox();
            dataGridView1 = new DataGridView();
            colAltura = new DataGridViewTextBoxColumn();
            colBase = new DataGridViewTextBoxColumn();
            colArea = new DataGridViewTextBoxColumn();
            colVolumen = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 91);
            label1.Name = "label1";
            label1.Size = new Size(210, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el area de la piramide:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 146);
            label2.Name = "label2";
            label2.Size = new Size(227, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingerese la altura de la piramide:";
            // 
            // btn_Ok
            // 
            btn_Ok.Location = new Point(206, 209);
            btn_Ok.Name = "btn_Ok";
            btn_Ok.Size = new Size(94, 29);
            btn_Ok.TabIndex = 2;
            btn_Ok.Text = "Ok";
            btn_Ok.UseVisualStyleBackColor = true;
            btn_Ok.Click += btn_Ok_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(488, 209);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button1_Click;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(457, 88);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(125, 27);
            txtArea.TabIndex = 4;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(457, 143);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(125, 27);
            txtAltura.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colAltura, colBase, colArea, colVolumen });
            dataGridView1.Location = new Point(135, 244);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(515, 184);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colAltura
            // 
            colAltura.HeaderText = "Altura";
            colAltura.MinimumWidth = 6;
            colAltura.Name = "colAltura";
            colAltura.ReadOnly = true;
            colAltura.Width = 125;
            // 
            // colBase
            // 
            colBase.HeaderText = "Base";
            colBase.MinimumWidth = 6;
            colBase.Name = "colBase";
            colBase.ReadOnly = true;
            colBase.Width = 125;
            // 
            // colArea
            // 
            colArea.HeaderText = "Area";
            colArea.MinimumWidth = 6;
            colArea.Name = "colArea";
            colArea.ReadOnly = true;
            colArea.Width = 125;
            // 
            // colVolumen
            // 
            colVolumen.HeaderText = "Volumen";
            colVolumen.MinimumWidth = 6;
            colVolumen.Name = "colVolumen";
            colVolumen.ReadOnly = true;
            colVolumen.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 488);
            Controls.Add(dataGridView1);
            Controls.Add(txtAltura);
            Controls.Add(txtArea);
            Controls.Add(btnCancelar);
            Controls.Add(btn_Ok);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private Label label1;
        private Button btnCancelar;
        private Button btn_Ok;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox txtAltura;
        private TextBox txtArea;
        private DataGridViewTextBoxColumn colAltura;
        private DataGridViewTextBoxColumn colBase;
        private DataGridViewTextBoxColumn colArea;
        private DataGridViewTextBoxColumn colVolumen;
    }
}