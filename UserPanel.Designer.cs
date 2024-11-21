namespace kursach
{
    partial class UserPanel
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
            infoEmployee_dataGridView = new DataGridView();
            infoUser_dataGridView = new DataGridView();
            infoProj_dataGridView = new DataGridView();
            infoTeams_dataGridView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)infoEmployee_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)infoUser_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)infoProj_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)infoTeams_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // infoEmployee_dataGridView
            // 
            infoEmployee_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            infoEmployee_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            infoEmployee_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            infoEmployee_dataGridView.Location = new Point(27, 59);
            infoEmployee_dataGridView.Name = "infoEmployee_dataGridView";
            infoEmployee_dataGridView.RowHeadersWidth = 51;
            infoEmployee_dataGridView.Size = new Size(407, 118);
            infoEmployee_dataGridView.TabIndex = 0;
            // 
            // infoUser_dataGridView
            // 
            infoUser_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            infoUser_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            infoUser_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            infoUser_dataGridView.Location = new Point(484, 59);
            infoUser_dataGridView.Name = "infoUser_dataGridView";
            infoUser_dataGridView.RowHeadersWidth = 51;
            infoUser_dataGridView.Size = new Size(427, 118);
            infoUser_dataGridView.TabIndex = 1;
            // 
            // infoProj_dataGridView
            // 
            infoProj_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            infoProj_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            infoProj_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            infoProj_dataGridView.Location = new Point(27, 216);
            infoProj_dataGridView.Name = "infoProj_dataGridView";
            infoProj_dataGridView.RowHeadersWidth = 51;
            infoProj_dataGridView.Size = new Size(650, 108);
            infoProj_dataGridView.TabIndex = 2;
            // 
            // infoTeams_dataGridView
            // 
            infoTeams_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            infoTeams_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            infoTeams_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            infoTeams_dataGridView.Location = new Point(27, 357);
            infoTeams_dataGridView.Name = "infoTeams_dataGridView";
            infoTeams_dataGridView.RowHeadersWidth = 51;
            infoTeams_dataGridView.Size = new Size(407, 96);
            infoTeams_dataGridView.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 36);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 4;
            label1.Text = "Общая информация:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(484, 36);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 5;
            label2.Text = "Учетная запись:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 193);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 6;
            label3.Text = "Проекты и задачи:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 334);
            label4.Name = "label4";
            label4.Size = new Size(157, 20);
            label4.TabIndex = 7;
            label4.Text = "Членство в бригадах:";
            // 
            // UserPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 479);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(infoTeams_dataGridView);
            Controls.Add(infoProj_dataGridView);
            Controls.Add(infoUser_dataGridView);
            Controls.Add(infoEmployee_dataGridView);
            Name = "UserPanel";
            Text = "UserPanel";
            WindowState = FormWindowState.Maximized;
            Activated += UserPanel_Activated;
            ((System.ComponentModel.ISupportInitialize)infoEmployee_dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)infoUser_dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)infoProj_dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)infoTeams_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView infoEmployee_dataGridView;
        private DataGridView infoUser_dataGridView;
        private DataGridView infoProj_dataGridView;
        private DataGridView infoTeams_dataGridView;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}