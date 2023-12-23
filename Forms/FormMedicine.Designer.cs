
namespace Hospital.Forms
{
    partial class FormMedicine
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
            this.btn_InsertMedicine = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBox_MedicineExpiratinDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_MedicineReleasedDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_MedicineQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_MedicineName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_MedicineCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_MedicinType = new System.Windows.Forms.ComboBox();
            this.comboBox_MedicineTypeOfDisease = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_InsertMedicine
            // 
            this.btn_InsertMedicine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_InsertMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.btn_InsertMedicine.FlatAppearance.BorderSize = 0;
            this.btn_InsertMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InsertMedicine.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.btn_InsertMedicine.ForeColor = System.Drawing.Color.Ivory;
            this.btn_InsertMedicine.Location = new System.Drawing.Point(537, 552);
            this.btn_InsertMedicine.Name = "btn_InsertMedicine";
            this.btn_InsertMedicine.Size = new System.Drawing.Size(157, 48);
            this.btn_InsertMedicine.TabIndex = 48;
            this.btn_InsertMedicine.Text = "Insert";
            this.btn_InsertMedicine.UseVisualStyleBackColor = false;
            this.btn_InsertMedicine.Click += new System.EventHandler(this.btn_InsertMedicine_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox1.BackColor = System.Drawing.Color.White;
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.maskedTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.maskedTextBox1.Location = new System.Drawing.Point(559, 103);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(169, 25);
            this.maskedTextBox1.TabIndex = 47;
            this.maskedTextBox1.Text = "Insert Medicine";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.monthCalendar1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.monthCalendar1.Location = new System.Drawing.Point(938, 33);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.monthCalendar1.TabIndex = 46;
            this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.monthCalendar1.TitleForeColor = System.Drawing.Color.Maroon;
            this.monthCalendar1.TrailingForeColor = System.Drawing.SystemColors.ControlDark;
            // 
            // textBox_MedicineExpiratinDate
            // 
            this.textBox_MedicineExpiratinDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_MedicineExpiratinDate.ForeColor = System.Drawing.Color.Black;
            this.textBox_MedicineExpiratinDate.Location = new System.Drawing.Point(901, 382);
            this.textBox_MedicineExpiratinDate.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_MedicineExpiratinDate.MinimumSize = new System.Drawing.Size(30, 30);
            this.textBox_MedicineExpiratinDate.Name = "textBox_MedicineExpiratinDate";
            this.textBox_MedicineExpiratinDate.Size = new System.Drawing.Size(193, 22);
            this.textBox_MedicineExpiratinDate.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.label10.Location = new System.Drawing.Point(696, 387);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.MinimumSize = new System.Drawing.Size(30, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 30);
            this.label10.TabIndex = 44;
            this.label10.Text = "Expiration Date :";
            // 
            // textBox_MedicineReleasedDate
            // 
            this.textBox_MedicineReleasedDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_MedicineReleasedDate.ForeColor = System.Drawing.Color.Black;
            this.textBox_MedicineReleasedDate.Location = new System.Drawing.Point(898, 320);
            this.textBox_MedicineReleasedDate.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_MedicineReleasedDate.MinimumSize = new System.Drawing.Size(30, 30);
            this.textBox_MedicineReleasedDate.Name = "textBox_MedicineReleasedDate";
            this.textBox_MedicineReleasedDate.Size = new System.Drawing.Size(194, 22);
            this.textBox_MedicineReleasedDate.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.label9.Location = new System.Drawing.Point(706, 320);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.MinimumSize = new System.Drawing.Size(30, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 30);
            this.label9.TabIndex = 42;
            this.label9.Text = "Release Date :";
            // 
            // textBox_MedicineQuantity
            // 
            this.textBox_MedicineQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_MedicineQuantity.ForeColor = System.Drawing.Color.Black;
            this.textBox_MedicineQuantity.Location = new System.Drawing.Point(898, 267);
            this.textBox_MedicineQuantity.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_MedicineQuantity.MinimumSize = new System.Drawing.Size(30, 30);
            this.textBox_MedicineQuantity.Name = "textBox_MedicineQuantity";
            this.textBox_MedicineQuantity.Size = new System.Drawing.Size(194, 22);
            this.textBox_MedicineQuantity.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.label6.Location = new System.Drawing.Point(706, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.MinimumSize = new System.Drawing.Size(30, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 30);
            this.label6.TabIndex = 34;
            this.label6.Text = "Quantity :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.label5.Location = new System.Drawing.Point(179, 448);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.MinimumSize = new System.Drawing.Size(30, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 30);
            this.label5.TabIndex = 32;
            this.label5.Text = "Type :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.label4.Location = new System.Drawing.Point(179, 387);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.MinimumSize = new System.Drawing.Size(30, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 30);
            this.label4.TabIndex = 30;
            this.label4.Text = "Type Of Disease :";
            // 
            // textBox_MedicineName
            // 
            this.textBox_MedicineName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_MedicineName.ForeColor = System.Drawing.Color.Black;
            this.textBox_MedicineName.Location = new System.Drawing.Point(379, 320);
            this.textBox_MedicineName.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_MedicineName.MinimumSize = new System.Drawing.Size(30, 30);
            this.textBox_MedicineName.Name = "textBox_MedicineName";
            this.textBox_MedicineName.Size = new System.Drawing.Size(184, 22);
            this.textBox_MedicineName.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.label3.Location = new System.Drawing.Point(179, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.MinimumSize = new System.Drawing.Size(30, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 30);
            this.label3.TabIndex = 28;
            this.label3.Text = "Medicine Name :";
            // 
            // textBox_MedicineCode
            // 
            this.textBox_MedicineCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_MedicineCode.ForeColor = System.Drawing.Color.Black;
            this.textBox_MedicineCode.Location = new System.Drawing.Point(379, 262);
            this.textBox_MedicineCode.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_MedicineCode.MinimumSize = new System.Drawing.Size(30, 30);
            this.textBox_MedicineCode.Name = "textBox_MedicineCode";
            this.textBox_MedicineCode.Size = new System.Drawing.Size(184, 22);
            this.textBox_MedicineCode.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(179, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.MinimumSize = new System.Drawing.Size(30, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 30);
            this.label2.TabIndex = 26;
            this.label2.Text = "Medicine Code  :";
            // 
            // comboBox_MedicinType
            // 
            this.comboBox_MedicinType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_MedicinType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MedicinType.FormattingEnabled = true;
            this.comboBox_MedicinType.Items.AddRange(new object[] {
            "Capsule",
            "Injection",
            "Liquid",
            "Pills",
            "Pin Dose"});
            this.comboBox_MedicinType.Location = new System.Drawing.Point(379, 454);
            this.comboBox_MedicinType.Name = "comboBox_MedicinType";
            this.comboBox_MedicinType.Size = new System.Drawing.Size(184, 24);
            this.comboBox_MedicinType.Sorted = true;
            this.comboBox_MedicinType.TabIndex = 49;
            // 
            // comboBox_MedicineTypeOfDisease
            // 
            this.comboBox_MedicineTypeOfDisease.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_MedicineTypeOfDisease.AutoCompleteCustomSource.AddRange(new string[] {
            "Aches",
            "ADHD ",
            "Asthma",
            "Bacteria Infections",
            "Blocked artery",
            "Cancer Pain",
            "Coughing",
            "Crohn\'s Disease",
            "Depression",
            "Depression And Anxiety",
            "Eczema",
            "Fevers",
            "Heart Failure",
            "High blood pressure",
            "Inflammatory Conditions",
            "Inflammation",
            "Long lasting pain",
            "Multiple Sclerosis",
            "Narcolepsy",
            "Overweight Issues",
            "Pain in general",
            "Partial seizures",
            "Restless nerve pain",
            "Shingles",
            "UC",
            "Unwanted blood clots",
            "Unstable Blood Sugar",
            "",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.comboBox_MedicineTypeOfDisease.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MedicineTypeOfDisease.FormattingEnabled = true;
            this.comboBox_MedicineTypeOfDisease.Items.AddRange(new object[] {
            " Narcolepsy",
            "Aches",
            "ADHD",
            "Anxiety disorder",
            "Asthma ",
            "Bacteria Infections",
            "Blocked artery",
            "Cancer Pain",
            "Certain types of cancer",
            "Coughing",
            "Crohn\'s disease",
            "Damage of multiple nerves throughout the body",
            "Depression",
            "Eczema",
            "Fevers",
            "Heart failure",
            "High blood pressure",
            "Inflammation",
            "Inflammatory Conditions",
            "Long lasting pain",
            "Multiple sclerosis",
            "Nerve pain",
            "Overweight Issues",
            "Pain in general",
            "Panic disorder",
            "Partial seizures",
            "Restless",
            "Shingles",
            "UC",
            "Unstable Blood Sugar",
            "Unwanted blood clots"});
            this.comboBox_MedicineTypeOfDisease.Location = new System.Drawing.Point(379, 393);
            this.comboBox_MedicineTypeOfDisease.Name = "comboBox_MedicineTypeOfDisease";
            this.comboBox_MedicineTypeOfDisease.Size = new System.Drawing.Size(184, 24);
            this.comboBox_MedicineTypeOfDisease.Sorted = true;
            this.comboBox_MedicineTypeOfDisease.TabIndex = 50;
            // 
            // FormMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 719);
            this.Controls.Add(this.comboBox_MedicineTypeOfDisease);
            this.Controls.Add(this.comboBox_MedicinType);
            this.Controls.Add(this.btn_InsertMedicine);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBox_MedicineExpiratinDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_MedicineReleasedDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_MedicineQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_MedicineName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_MedicineCode);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Name = "FormMedicine";
            this.Text = "MEDICINE";
            this.Load += new System.EventHandler(this.FormMedicine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_InsertMedicine;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBox_MedicineExpiratinDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_MedicineReleasedDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_MedicineQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_MedicineName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_MedicineCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_MedicinType;
        public System.Windows.Forms.ComboBox comboBox_MedicineTypeOfDisease;
    }
}