
namespace Hospital.Forms
{
    partial class FormSpecialFilterPatients
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
            this.dataGridView_SpecialFilterPatient = new System.Windows.Forms.DataGridView();
            this.textBox_SpecialFilterPatientAge = new System.Windows.Forms.TextBox();
            this.textBox_SpecialFilterPatientGender = new System.Windows.Forms.TextBox();
            this.textBox_SpecialFilterPatientTypeOfDisease = new System.Windows.Forms.TextBox();
            this.comboBox_AndOrAgeGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_FilterSpecialFilterPatient = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_AndOrGenderTypeOfDisese = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SpecialFilterPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_SpecialFilterPatient
            // 
            this.dataGridView_SpecialFilterPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SpecialFilterPatient.Location = new System.Drawing.Point(35, 219);
            this.dataGridView_SpecialFilterPatient.Name = "dataGridView_SpecialFilterPatient";
            this.dataGridView_SpecialFilterPatient.RowHeadersWidth = 51;
            this.dataGridView_SpecialFilterPatient.RowTemplate.Height = 24;
            this.dataGridView_SpecialFilterPatient.Size = new System.Drawing.Size(1051, 250);
            this.dataGridView_SpecialFilterPatient.TabIndex = 0;
            // 
            // textBox_SpecialFilterPatientAge
            // 
            this.textBox_SpecialFilterPatientAge.Location = new System.Drawing.Point(232, 37);
            this.textBox_SpecialFilterPatientAge.Name = "textBox_SpecialFilterPatientAge";
            this.textBox_SpecialFilterPatientAge.Size = new System.Drawing.Size(130, 22);
            this.textBox_SpecialFilterPatientAge.TabIndex = 1;
            // 
            // textBox_SpecialFilterPatientGender
            // 
            this.textBox_SpecialFilterPatientGender.Location = new System.Drawing.Point(232, 85);
            this.textBox_SpecialFilterPatientGender.Name = "textBox_SpecialFilterPatientGender";
            this.textBox_SpecialFilterPatientGender.Size = new System.Drawing.Size(130, 22);
            this.textBox_SpecialFilterPatientGender.TabIndex = 2;
            // 
            // textBox_SpecialFilterPatientTypeOfDisease
            // 
            this.textBox_SpecialFilterPatientTypeOfDisease.Location = new System.Drawing.Point(232, 127);
            this.textBox_SpecialFilterPatientTypeOfDisease.Name = "textBox_SpecialFilterPatientTypeOfDisease";
            this.textBox_SpecialFilterPatientTypeOfDisease.Size = new System.Drawing.Size(130, 22);
            this.textBox_SpecialFilterPatientTypeOfDisease.TabIndex = 3;
            // 
            // comboBox_AndOrAgeGender
            // 
            this.comboBox_AndOrAgeGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AndOrAgeGender.FormattingEnabled = true;
            this.comboBox_AndOrAgeGender.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.comboBox_AndOrAgeGender.Location = new System.Drawing.Point(502, 59);
            this.comboBox_AndOrAgeGender.Name = "comboBox_AndOrAgeGender";
            this.comboBox_AndOrAgeGender.Size = new System.Drawing.Size(121, 24);
            this.comboBox_AndOrAgeGender.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Patient Age";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(90, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Patient Gender";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(90, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type Of Disease";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(396, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "And/Or";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_FilterSpecialFilterPatient
            // 
            this.btn_FilterSpecialFilterPatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_FilterSpecialFilterPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.btn_FilterSpecialFilterPatient.FlatAppearance.BorderSize = 0;
            this.btn_FilterSpecialFilterPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FilterSpecialFilterPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_FilterSpecialFilterPatient.ForeColor = System.Drawing.Color.Ivory;
            this.btn_FilterSpecialFilterPatient.Location = new System.Drawing.Point(480, 165);
            this.btn_FilterSpecialFilterPatient.Name = "btn_FilterSpecialFilterPatient";
            this.btn_FilterSpecialFilterPatient.Size = new System.Drawing.Size(145, 48);
            this.btn_FilterSpecialFilterPatient.TabIndex = 65;
            this.btn_FilterSpecialFilterPatient.Text = "Filter";
            this.btn_FilterSpecialFilterPatient.UseVisualStyleBackColor = false;
            this.btn_FilterSpecialFilterPatient.Click += new System.EventHandler(this.btn_FilterSpecialFilterPatient_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(396, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 67;
            this.label5.Text = "And/Or";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_AndOrGenderTypeOfDisese
            // 
            this.comboBox_AndOrGenderTypeOfDisese.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AndOrGenderTypeOfDisese.FormattingEnabled = true;
            this.comboBox_AndOrGenderTypeOfDisese.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.comboBox_AndOrGenderTypeOfDisese.Location = new System.Drawing.Point(502, 112);
            this.comboBox_AndOrGenderTypeOfDisese.Name = "comboBox_AndOrGenderTypeOfDisese";
            this.comboBox_AndOrGenderTypeOfDisese.Size = new System.Drawing.Size(121, 24);
            this.comboBox_AndOrGenderTypeOfDisese.TabIndex = 66;
            // 
            // FormSpecialFilterPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1132, 499);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_AndOrGenderTypeOfDisese);
            this.Controls.Add(this.btn_FilterSpecialFilterPatient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_AndOrAgeGender);
            this.Controls.Add(this.textBox_SpecialFilterPatientTypeOfDisease);
            this.Controls.Add(this.textBox_SpecialFilterPatientGender);
            this.Controls.Add(this.textBox_SpecialFilterPatientAge);
            this.Controls.Add(this.dataGridView_SpecialFilterPatient);
            this.DoubleBuffered = true;
            this.Name = "FormSpecialFilterPatients";
            this.Text = "FormSpecialFilterPatients";
            this.Load += new System.EventHandler(this.FormSpecialFilterPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SpecialFilterPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_SpecialFilterPatient;
        private System.Windows.Forms.TextBox textBox_SpecialFilterPatientAge;
        private System.Windows.Forms.TextBox textBox_SpecialFilterPatientGender;
        private System.Windows.Forms.TextBox textBox_SpecialFilterPatientTypeOfDisease;
        private System.Windows.Forms.ComboBox comboBox_AndOrAgeGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_FilterSpecialFilterPatient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_AndOrGenderTypeOfDisese;
    }
}