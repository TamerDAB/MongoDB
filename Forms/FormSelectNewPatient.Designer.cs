
namespace Hospital.Forms
{
    partial class FormSelectNewPatient
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
            this.dataGridView_SelectPatient = new System.Windows.Forms.DataGridView();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btn_searchPatientID = new System.Windows.Forms.Button();
            this.textBox_SelectNewPatientSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SelectPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_SelectPatient
            // 
            this.dataGridView_SelectPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SelectPatient.Location = new System.Drawing.Point(101, 139);
            this.dataGridView_SelectPatient.Name = "dataGridView_SelectPatient";
            this.dataGridView_SelectPatient.ReadOnly = true;
            this.dataGridView_SelectPatient.RowHeadersWidth = 51;
            this.dataGridView_SelectPatient.RowTemplate.Height = 24;
            this.dataGridView_SelectPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_SelectPatient.Size = new System.Drawing.Size(1156, 272);
            this.dataGridView_SelectPatient.TabIndex = 1;
            this.dataGridView_SelectPatient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_SelectNewPatient);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox1.BackColor = System.Drawing.Color.White;
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.maskedTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.maskedTextBox1.Location = new System.Drawing.Point(595, 28);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(211, 25);
            this.maskedTextBox1.TabIndex = 52;
            this.maskedTextBox1.Text = "Select New Patient";
            // 
            // btn_searchPatientID
            // 
            this.btn_searchPatientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_searchPatientID.BackColor = System.Drawing.SystemColors.Control;
            this.btn_searchPatientID.FlatAppearance.BorderSize = 0;
            this.btn_searchPatientID.Location = new System.Drawing.Point(753, 92);
            this.btn_searchPatientID.Name = "btn_searchPatientID";
            this.btn_searchPatientID.Size = new System.Drawing.Size(96, 30);
            this.btn_searchPatientID.TabIndex = 51;
            this.btn_searchPatientID.Text = "Search";
            this.btn_searchPatientID.UseVisualStyleBackColor = false;
            this.btn_searchPatientID.Click += new System.EventHandler(this.btn_searchPatientID_Click);
            // 
            // textBox_SelectNewPatientSearch
            // 
            this.textBox_SelectNewPatientSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_SelectNewPatientSearch.Location = new System.Drawing.Point(620, 96);
            this.textBox_SelectNewPatientSearch.Name = "textBox_SelectNewPatientSearch";
            this.textBox_SelectNewPatientSearch.Size = new System.Drawing.Size(112, 22);
            this.textBox_SelectNewPatientSearch.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(484, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 49;
            this.label2.Text = "Patient ID :";
            // 
            // FormSelectNewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1330, 450);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btn_searchPatientID);
            this.Controls.Add(this.textBox_SelectNewPatientSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_SelectPatient);
            this.DoubleBuffered = true;
            this.Name = "FormSelectNewPatient";
            this.Text = "FormSelectNewPatient";
            this.Load += new System.EventHandler(this.FormSelectNewPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SelectPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_SelectPatient;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btn_searchPatientID;
        private System.Windows.Forms.TextBox textBox_SelectNewPatientSearch;
        private System.Windows.Forms.Label label2;
    }
}