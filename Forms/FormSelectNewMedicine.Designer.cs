
namespace Hospital.Forms
{
    partial class FormSelectNewMedicine
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
            this.dataGridView_selectMedicine = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_SelectNewMedicineSearch = new System.Windows.Forms.TextBox();
            this.btn_searchMedicineCode = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_selectMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_selectMedicine
            // 
            this.dataGridView_selectMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_selectMedicine.Location = new System.Drawing.Point(101, 139);
            this.dataGridView_selectMedicine.Name = "dataGridView_selectMedicine";
            this.dataGridView_selectMedicine.ReadOnly = true;
            this.dataGridView_selectMedicine.RowHeadersWidth = 51;
            this.dataGridView_selectMedicine.RowTemplate.Height = 24;
            this.dataGridView_selectMedicine.Size = new System.Drawing.Size(1156, 272);
            this.dataGridView_selectMedicine.TabIndex = 0;
            this.dataGridView_selectMedicine.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_SelectNewMedicine);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(481, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Medicine Code :";
            // 
            // textBox_SelectNewMedicineSearch
            // 
            this.textBox_SelectNewMedicineSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_SelectNewMedicineSearch.Location = new System.Drawing.Point(649, 94);
            this.textBox_SelectNewMedicineSearch.Name = "textBox_SelectNewMedicineSearch";
            this.textBox_SelectNewMedicineSearch.Size = new System.Drawing.Size(112, 22);
            this.textBox_SelectNewMedicineSearch.TabIndex = 3;
            // 
            // btn_searchMedicineCode
            // 
            this.btn_searchMedicineCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_searchMedicineCode.BackColor = System.Drawing.SystemColors.Control;
            this.btn_searchMedicineCode.FlatAppearance.BorderSize = 0;
            this.btn_searchMedicineCode.Location = new System.Drawing.Point(782, 90);
            this.btn_searchMedicineCode.Name = "btn_searchMedicineCode";
            this.btn_searchMedicineCode.Size = new System.Drawing.Size(96, 30);
            this.btn_searchMedicineCode.TabIndex = 4;
            this.btn_searchMedicineCode.Text = "Search";
            this.btn_searchMedicineCode.UseVisualStyleBackColor = false;
            this.btn_searchMedicineCode.Click += new System.EventHandler(this.btn_searchMedicineCode_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox1.BackColor = System.Drawing.Color.White;
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.maskedTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.maskedTextBox1.Location = new System.Drawing.Point(592, 26);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(211, 25);
            this.maskedTextBox1.TabIndex = 48;
            this.maskedTextBox1.Text = "Select New Medicine";
            // 
            // FormSelectNewMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1330, 450);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btn_searchMedicineCode);
            this.Controls.Add(this.textBox_SelectNewMedicineSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_selectMedicine);
            this.DoubleBuffered = true;
            this.Name = "FormSelectNewMedicine";
            this.Text = "FormSelectNewMedicine";
            this.Load += new System.EventHandler(this.FormSelectNewMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_selectMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_selectMedicine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_SelectNewMedicineSearch;
        private System.Windows.Forms.Button btn_searchMedicineCode;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}