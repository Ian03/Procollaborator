namespace Procollaborator
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
            buttonSave = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            buttonInsert = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonExit = new Button();
            panelStatus = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSave.BackColor = Color.FromArgb(49, 49, 166);
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = SystemColors.Info;
            buttonSave.Location = new Point(12, 425);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(180, 38);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Salvar";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(22, 25, 28);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 257);
            dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(13, 30);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(13, 63);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(13, 93);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Matricula";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(76, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(76, 90);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(120, 23);
            textBox3.TabIndex = 7;
            // 
            // buttonInsert
            // 
            buttonInsert.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInsert.BackColor = Color.FromArgb(49, 49, 166);
            buttonInsert.FlatAppearance.BorderSize = 0;
            buttonInsert.FlatStyle = FlatStyle.Flat;
            buttonInsert.ForeColor = SystemColors.Info;
            buttonInsert.Location = new Point(669, 11);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(119, 34);
            buttonInsert.TabIndex = 8;
            buttonInsert.Text = "Inserir";
            buttonInsert.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonUpdate.BackColor = Color.FromArgb(49, 49, 166);
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.ForeColor = SystemColors.Info;
            buttonUpdate.Location = new Point(669, 53);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(119, 34);
            buttonUpdate.TabIndex = 9;
            buttonUpdate.Text = "Atualizar";
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDelete.BackColor = Color.FromArgb(49, 49, 166);
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.ForeColor = SystemColors.Info;
            buttonDelete.Location = new Point(669, 93);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(119, 34);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Deletar";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            buttonExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonExit.BackColor = Color.Firebrick;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.ForeColor = SystemColors.Info;
            buttonExit.Location = new Point(608, 425);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(180, 38);
            buttonExit.TabIndex = 12;
            buttonExit.Text = "Sair";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click_1;
            // 
            // panelStatus
            // 
            panelStatus.BackColor = Color.FromArgb(49, 49, 166);
            panelStatus.Dock = DockStyle.Bottom;
            panelStatus.Location = new Point(0, 481);
            panelStatus.Name = "panelStatus";
            panelStatus.Size = new Size(800, 19);
            panelStatus.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 39, 43);
            ClientSize = new Size(800, 500);
            ControlBox = false;
            Controls.Add(panelStatus);
            Controls.Add(buttonExit);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonInsert);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(buttonSave);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pro Colaborador";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button buttonInsert;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonExit;
        private Panel panelStatus;
    }
}
