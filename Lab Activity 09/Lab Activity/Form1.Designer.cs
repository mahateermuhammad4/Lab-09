namespace Lab_Activity
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
            this.Customer_Name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.GroupBox();
            this.checkBox_female = new System.Windows.Forms.CheckBox();
            this.checkBox_Male = new System.Windows.Forms.CheckBox();
            this.Country = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_reading = new System.Windows.Forms.CheckBox();
            this.checkBox_Painting = new System.Windows.Forms.CheckBox();
            this.Status = new System.Windows.Forms.GroupBox();
            this.checkBox_Unmarried = new System.Windows.Forms.CheckBox();
            this.checkBox_Married = new System.Windows.Forms.CheckBox();
            this.Preview = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Gender.SuspendLayout();
            this.Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Customer_Name
            // 
            this.Customer_Name.AutoSize = true;
            this.Customer_Name.Location = new System.Drawing.Point(45, 19);
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.Size = new System.Drawing.Size(94, 15);
            this.Customer_Name.TabIndex = 0;
            this.Customer_Name.Text = "Customer Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // Gender
            // 
            this.Gender.Controls.Add(this.checkBox_female);
            this.Gender.Controls.Add(this.checkBox_Male);
            this.Gender.Location = new System.Drawing.Point(45, 89);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(439, 71);
            this.Gender.TabIndex = 2;
            this.Gender.TabStop = false;
            this.Gender.Text = "Gender";
            // 
            // checkBox_female
            // 
            this.checkBox_female.AutoSize = true;
            this.checkBox_female.Location = new System.Drawing.Point(64, 22);
            this.checkBox_female.Name = "checkBox_female";
            this.checkBox_female.Size = new System.Drawing.Size(64, 19);
            this.checkBox_female.TabIndex = 1;
            this.checkBox_female.Text = "Female";
            this.checkBox_female.UseVisualStyleBackColor = true;
            // 
            // checkBox_Male
            // 
            this.checkBox_Male.AutoSize = true;
            this.checkBox_Male.Location = new System.Drawing.Point(6, 22);
            this.checkBox_Male.Name = "checkBox_Male";
            this.checkBox_Male.Size = new System.Drawing.Size(52, 19);
            this.checkBox_Male.TabIndex = 0;
            this.checkBox_Male.Text = "Male";
            this.checkBox_Male.UseVisualStyleBackColor = true;
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(45, 68);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(50, 15);
            this.Country.TabIndex = 3;
            this.Country.Text = "Country";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hobbies";
            // 
            // checkBox_reading
            // 
            this.checkBox_reading.AutoSize = true;
            this.checkBox_reading.Location = new System.Drawing.Point(112, 166);
            this.checkBox_reading.Name = "checkBox_reading";
            this.checkBox_reading.Size = new System.Drawing.Size(69, 19);
            this.checkBox_reading.TabIndex = 6;
            this.checkBox_reading.Text = "Football";
            this.checkBox_reading.UseVisualStyleBackColor = true;
            // 
            // checkBox_Painting
            // 
            this.checkBox_Painting.AutoSize = true;
            this.checkBox_Painting.Location = new System.Drawing.Point(201, 166);
            this.checkBox_Painting.Name = "checkBox_Painting";
            this.checkBox_Painting.Size = new System.Drawing.Size(64, 19);
            this.checkBox_Painting.TabIndex = 7;
            this.checkBox_Painting.Text = "Driving";
            this.checkBox_Painting.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            this.Status.Controls.Add(this.checkBox_Unmarried);
            this.Status.Controls.Add(this.checkBox_Married);
            this.Status.Location = new System.Drawing.Point(49, 193);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(435, 100);
            this.Status.TabIndex = 8;
            this.Status.TabStop = false;
            this.Status.Text = "status";
            // 
            // checkBox_Unmarried
            // 
            this.checkBox_Unmarried.AutoSize = true;
            this.checkBox_Unmarried.Location = new System.Drawing.Point(152, 22);
            this.checkBox_Unmarried.Name = "checkBox_Unmarried";
            this.checkBox_Unmarried.Size = new System.Drawing.Size(82, 19);
            this.checkBox_Unmarried.TabIndex = 9;
            this.checkBox_Unmarried.Text = "Unmarried";
            this.checkBox_Unmarried.UseVisualStyleBackColor = true;
            // 
            // checkBox_Married
            // 
            this.checkBox_Married.AutoSize = true;
            this.checkBox_Married.Location = new System.Drawing.Point(63, 22);
            this.checkBox_Married.Name = "checkBox_Married";
            this.checkBox_Married.Size = new System.Drawing.Size(67, 19);
            this.checkBox_Married.TabIndex = 8;
            this.checkBox_Married.Text = "Married";
            this.checkBox_Married.UseVisualStyleBackColor = true;
            // 
            // Preview
            // 
            this.Preview.Location = new System.Drawing.Point(174, 330);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(75, 23);
            this.Preview.TabIndex = 9;
            this.Preview.Text = "Preview";
            this.Preview.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(575, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(596, 332);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 650);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Preview);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.checkBox_Painting);
            this.Controls.Add(this.checkBox_reading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Customer_Name);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Gender.ResumeLayout(false);
            this.Gender.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Customer_Name;
        private TextBox textBox1;
        private GroupBox Gender;
        private CheckBox checkBox_female;
        private CheckBox checkBox_Male;
        private Label Country;
        private ComboBox comboBox1;
        private Label label1;
        private CheckBox checkBox_reading;
        private CheckBox checkBox_Painting;
        private GroupBox Status;
        private CheckBox checkBox_Unmarried;
        private CheckBox checkBox_Married;
        private Button Preview;
        private DataGridView dataGridView1;
    }
}