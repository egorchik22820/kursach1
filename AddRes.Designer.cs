namespace kursach
{
    partial class AddRes
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
            Res_dataGridView = new DataGridView();
            label1 = new Label();
            Name_textBox = new TextBox();
            label2 = new Label();
            Add_button = new Button();
            label3 = new Label();
            Unit_textBox = new TextBox();
            label4 = new Label();
            Cost_textBox = new TextBox();
            Delete_button = new Button();
            Search_textBox = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)Res_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // Res_dataGridView
            // 
            Res_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Res_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            Res_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Res_dataGridView.Location = new Point(12, 40);
            Res_dataGridView.Name = "Res_dataGridView";
            Res_dataGridView.RowHeadersWidth = 51;
            Res_dataGridView.Size = new Size(505, 322);
            Res_dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "Ресурсы:";
            // 
            // Name_textBox
            // 
            Name_textBox.Location = new Point(523, 40);
            Name_textBox.Name = "Name_textBox";
            Name_textBox.Size = new Size(181, 27);
            Name_textBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(523, 17);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 3;
            label2.Text = "Название:";
            // 
            // Add_button
            // 
            Add_button.Location = new Point(710, 73);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(119, 29);
            Add_button.TabIndex = 4;
            Add_button.Text = "Добавить";
            Add_button.UseVisualStyleBackColor = true;
            Add_button.Click += Add_button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(710, 20);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 6;
            label3.Text = "Ед. изм.:";
            // 
            // Unit_textBox
            // 
            Unit_textBox.Location = new Point(710, 40);
            Unit_textBox.Name = "Unit_textBox";
            Unit_textBox.Size = new Size(127, 27);
            Unit_textBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(843, 20);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 8;
            label4.Text = "Цена за ед.:";
            // 
            // Cost_textBox
            // 
            Cost_textBox.Location = new Point(843, 40);
            Cost_textBox.Name = "Cost_textBox";
            Cost_textBox.Size = new Size(136, 27);
            Cost_textBox.TabIndex = 7;
            // 
            // Delete_button
            // 
            Delete_button.Location = new Point(12, 370);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(94, 29);
            Delete_button.TabIndex = 9;
            Delete_button.Text = "Удалить";
            Delete_button.UseVisualStyleBackColor = true;
            Delete_button.Click += Delete_button_Click;
            // 
            // Search_textBox
            // 
            Search_textBox.Location = new Point(647, 232);
            Search_textBox.Name = "Search_textBox";
            Search_textBox.Size = new Size(247, 27);
            Search_textBox.TabIndex = 10;
            Search_textBox.TextChanged += Search_textBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(647, 209);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 11;
            label5.Text = "Поиск:";
            // 
            // AddRes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 411);
            Controls.Add(label5);
            Controls.Add(Search_textBox);
            Controls.Add(Delete_button);
            Controls.Add(label4);
            Controls.Add(Cost_textBox);
            Controls.Add(label3);
            Controls.Add(Unit_textBox);
            Controls.Add(Add_button);
            Controls.Add(label2);
            Controls.Add(Name_textBox);
            Controls.Add(label1);
            Controls.Add(Res_dataGridView);
            Name = "AddRes";
            Text = "AddRes";
            Activated += AddRes_Activated;
            ((System.ComponentModel.ISupportInitialize)Res_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Res_dataGridView;
        private Label label1;
        private TextBox Name_textBox;
        private Label label2;
        private Button Add_button;
        private Label label3;
        private TextBox Unit_textBox;
        private Label label4;
        private TextBox Cost_textBox;
        private Button Delete_button;
        private TextBox Search_textBox;
        private Label label5;
    }
}