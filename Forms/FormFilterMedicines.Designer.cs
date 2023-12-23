
namespace Hospital.Forms
{
    partial class FormFilterMedicines
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
            this.dataGridView_FilterMedicines = new System.Windows.Forms.DataGridView();
            this.btn_FilterMedicine = new System.Windows.Forms.Button();
            this.textBox_FilterMedicineExpiratinDate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_FilterMedicineReleaseDate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_FilterMedicineQuantity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_FilterType = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_FilterMedicineTypeOfDisease = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_FilterMedicineName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_FilterMedicineCode = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FilterMedicines)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_FilterMedicines
            // 
            this.dataGridView_FilterMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_FilterMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_FilterMedicines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.dataGridView_FilterMedicines.Location = new System.Drawing.Point(81, 308);
            this.dataGridView_FilterMedicines.Name = "dataGridView_FilterMedicines";
            this.dataGridView_FilterMedicines.ReadOnly = true;
            this.dataGridView_FilterMedicines.RowHeadersWidth = 51;
            this.dataGridView_FilterMedicines.RowTemplate.Height = 24;
            this.dataGridView_FilterMedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_FilterMedicines.Size = new System.Drawing.Size(1150, 345);
            this.dataGridView_FilterMedicines.TabIndex = 65;
            this.dataGridView_FilterMedicines.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_OpenUpdateOrDeleteMedicine);
            // 
            // btn_FilterMedicine
            // 
            this.btn_FilterMedicine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_FilterMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.btn_FilterMedicine.FlatAppearance.BorderSize = 0;
            this.btn_FilterMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FilterMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_FilterMedicine.ForeColor = System.Drawing.Color.Ivory;
            this.btn_FilterMedicine.Location = new System.Drawing.Point(606, 254);
            this.btn_FilterMedicine.Name = "btn_FilterMedicine";
            this.btn_FilterMedicine.Size = new System.Drawing.Size(145, 48);
            this.btn_FilterMedicine.TabIndex = 64;
            this.btn_FilterMedicine.Text = "Filter";
            this.btn_FilterMedicine.UseVisualStyleBackColor = false;
            this.btn_FilterMedicine.Click += new System.EventHandler(this.btn_FilterMedicine_Click);
            // 
            // textBox_FilterMedicineExpiratinDate
            // 
            this.textBox_FilterMedicineExpiratinDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_FilterMedicineExpiratinDate.ForeColor = System.Drawing.Color.Black;
            this.textBox_FilterMedicineExpiratinDate.Location = new System.Drawing.Point(853, 186);
            this.textBox_FilterMedicineExpiratinDate.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_FilterMedicineExpiratinDate.MinimumSize = new System.Drawing.Size(30, 30);
            this.textBox_FilterMedicineExpiratinDate.Name = "textBox_FilterMedicineExpiratinDate";
            this.textBox_FilterMedicineExpiratinDate.Size = new System.Drawing.Size(232, 30);
            this.textBox_FilterMedicineExpiratinDate.TabIndex = 79;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.label11.Location = new System.Drawing.Point(647, 186);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.MinimumSize = new System.Drawing.Size(30, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 30);
            this.label11.TabIndex = 78;
            this.label11.Text = "Expiration Date :";
            // 
            // textBox_FilterMedicineReleaseDate
            // 
            this.textBox_FilterMedicineReleaseDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_FilterMedicineReleaseDate.ForeColor = System.Drawing.Color.Black;
            this.textBox_FilterMedicineReleaseDate.Location = new System.Drawing.Point(854, 138);
            this.textBox_FilterMedicineReleaseDate.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_FilterMedicineReleaseDate.MinimumSize = new System.Drawing.Size(30, 30);
            this.textBox_FilterMedicineReleaseDate.Name = "textBox_FilterMedicineReleaseDate";
            this.textBox_FilterMedicineReleaseDate.Size = new System.Drawing.Size(232, 30);
            this.textBox_FilterMedicineReleaseDate.TabIndex = 77;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.label12.Location = new System.Drawing.Point(647, 133);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.MinimumSize = new System.Drawing.Size(30, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 30);
            this.label12.TabIndex = 76;
            this.label12.Text = "Release Date  :";
            // 
            // textBox_FilterMedicineQuantity
            // 
            this.textBox_FilterMedicineQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_FilterMedicineQuantity.ForeColor = System.Drawing.Color.Black;
            this.textBox_FilterMedicineQuantity.Location = new System.Drawing.Point(854, 70);
            this.textBox_FilterMedicineQuantity.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_FilterMedicineQuantity.MinimumSize = new System.Drawing.Size(30, 30);
            this.textBox_FilterMedicineQuantity.Name = "textBox_FilterMedicineQuantity";
            this.textBox_FilterMedicineQuantity.Size = new System.Drawing.Size(232, 30);
            this.textBox_FilterMedicineQuantity.TabIndex = 75;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.label13.Location = new System.Drawing.Point(657, 73);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.MinimumSize = new System.Drawing.Size(30, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 30);
            this.label13.TabIndex = 74;
            this.label13.Text = "Quantity :";
            // 
            // textBox_FilterType
            // 
            this.textBox_FilterType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_FilterType.ForeColor = System.Drawing.Color.Black;
            this.textBox_FilterType.Location = new System.Drawing.Point(853, 25);
            this.textBox_FilterType.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_FilterType.MinimumSize = new System.Drawing.Size(30, 22);
            this.textBox_FilterType.Name = "textBox_FilterType";
            this.textBox_FilterType.Size = new System.Drawing.Size(232, 22);
            this.textBox_FilterType.TabIndex = 73;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.label14.Location = new System.Drawing.Point(657, 28);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.MinimumSize = new System.Drawing.Size(30, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 30);
            this.label14.TabIndex = 72;
            this.label14.Text = "Type :";
            // 
            // textBox_FilterMedicineTypeOfDisease
            // 
            this.textBox_FilterMedicineTypeOfDisease.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_FilterMedicineTypeOfDisease.ForeColor = System.Drawing.Color.Black;
            this.textBox_FilterMedicineTypeOfDisease.Location = new System.Drawing.Point(284, 138);
            this.textBox_FilterMedicineTypeOfDisease.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_FilterMedicineTypeOfDisease.MinimumSize = new System.Drawing.Size(30, 22);
            this.textBox_FilterMedicineTypeOfDisease.Name = "textBox_FilterMedicineTypeOfDisease";
            this.textBox_FilterMedicineTypeOfDisease.Size = new System.Drawing.Size(232, 22);
            this.textBox_FilterMedicineTypeOfDisease.TabIndex = 71;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.label15.Location = new System.Drawing.Point(77, 130);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.MinimumSize = new System.Drawing.Size(30, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(190, 30);
            this.label15.TabIndex = 70;
            this.label15.Text = "Type Of Disease :";
            // 
            // textBox_FilterMedicineName
            // 
            this.textBox_FilterMedicineName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_FilterMedicineName.ForeColor = System.Drawing.Color.Black;
            this.textBox_FilterMedicineName.Location = new System.Drawing.Point(284, 81);
            this.textBox_FilterMedicineName.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_FilterMedicineName.MinimumSize = new System.Drawing.Size(30, 22);
            this.textBox_FilterMedicineName.Name = "textBox_FilterMedicineName";
            this.textBox_FilterMedicineName.Size = new System.Drawing.Size(232, 22);
            this.textBox_FilterMedicineName.TabIndex = 69;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.label16.Location = new System.Drawing.Point(76, 76);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.MinimumSize = new System.Drawing.Size(30, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(181, 30);
            this.label16.TabIndex = 68;
            this.label16.Text = "Medicine Name :";
            // 
            // textBox_FilterMedicineCode
            // 
            this.textBox_FilterMedicineCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_FilterMedicineCode.ForeColor = System.Drawing.Color.Black;
            this.textBox_FilterMedicineCode.Location = new System.Drawing.Point(284, 33);
            this.textBox_FilterMedicineCode.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_FilterMedicineCode.MinimumSize = new System.Drawing.Size(30, 22);
            this.textBox_FilterMedicineCode.Name = "textBox_FilterMedicineCode";
            this.textBox_FilterMedicineCode.Size = new System.Drawing.Size(232, 22);
            this.textBox_FilterMedicineCode.TabIndex = 67;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.label17.Location = new System.Drawing.Point(77, 25);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.MinimumSize = new System.Drawing.Size(30, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(180, 30);
            this.label17.TabIndex = 66;
            this.label17.Text = "Medicine Code  :";
            // 
            // FormFilterMedicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 719);
            this.Controls.Add(this.textBox_FilterMedicineExpiratinDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_FilterMedicineReleaseDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_FilterMedicineQuantity);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_FilterType);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox_FilterMedicineTypeOfDisease);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox_FilterMedicineName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox_FilterMedicineCode);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dataGridView_FilterMedicines);
            this.Controls.Add(this.btn_FilterMedicine);
            this.DoubleBuffered = true;
            this.Name = "FormFilterMedicines";
            this.Text = "Filter Medicines";
            this.Load += new System.EventHandler(this.FormFilterMedicines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FilterMedicines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_FilterMedicines;
        private System.Windows.Forms.Button btn_FilterMedicine;
        private System.Windows.Forms.TextBox textBox_FilterMedicineExpiratinDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_FilterMedicineReleaseDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_FilterMedicineQuantity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_FilterType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_FilterMedicineTypeOfDisease;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_FilterMedicineName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_FilterMedicineCode;
        private System.Windows.Forms.Label label17;
    }
}