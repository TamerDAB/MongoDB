
namespace Hospital.Forms
{
    partial class FormTreatment
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
            this.btn_AddMedicineForPatient = new System.Windows.Forms.Button();
            this.dataGridView_PatientTable = new System.Windows.Forms.DataGridView();
            this.dataGridView_MedicinesTable = new System.Windows.Forms.DataGridView();
            this.dataGridView_PatientTreatment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PatientTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MedicinesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PatientTreatment)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddMedicineForPatient
            // 
            this.btn_AddMedicineForPatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AddMedicineForPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.btn_AddMedicineForPatient.FlatAppearance.BorderSize = 0;
            this.btn_AddMedicineForPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddMedicineForPatient.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.btn_AddMedicineForPatient.ForeColor = System.Drawing.Color.Ivory;
            this.btn_AddMedicineForPatient.Location = new System.Drawing.Point(484, 394);
            this.btn_AddMedicineForPatient.Name = "btn_AddMedicineForPatient";
            this.btn_AddMedicineForPatient.Size = new System.Drawing.Size(324, 48);
            this.btn_AddMedicineForPatient.TabIndex = 49;
            this.btn_AddMedicineForPatient.Text = "Add Medicine For Patient";
            this.btn_AddMedicineForPatient.UseVisualStyleBackColor = false;
            this.btn_AddMedicineForPatient.Click += new System.EventHandler(this.btn_AddMedicineForPatient_Click);
            // 
            // dataGridView_PatientTable
            // 
            this.dataGridView_PatientTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_PatientTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_PatientTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_PatientTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PatientTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.dataGridView_PatientTable.Location = new System.Drawing.Point(60, 12);
            this.dataGridView_PatientTable.Name = "dataGridView_PatientTable";
            this.dataGridView_PatientTable.ReadOnly = true;
            this.dataGridView_PatientTable.RowHeadersWidth = 51;
            this.dataGridView_PatientTable.RowTemplate.Height = 24;
            this.dataGridView_PatientTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_PatientTable.Size = new System.Drawing.Size(1156, 179);
            this.dataGridView_PatientTable.TabIndex = 50;
            // 
            // dataGridView_MedicinesTable
            // 
            this.dataGridView_MedicinesTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_MedicinesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_MedicinesTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_MedicinesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MedicinesTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.dataGridView_MedicinesTable.Location = new System.Drawing.Point(60, 209);
            this.dataGridView_MedicinesTable.Name = "dataGridView_MedicinesTable";
            this.dataGridView_MedicinesTable.ReadOnly = true;
            this.dataGridView_MedicinesTable.RowHeadersWidth = 51;
            this.dataGridView_MedicinesTable.RowTemplate.Height = 24;
            this.dataGridView_MedicinesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_MedicinesTable.Size = new System.Drawing.Size(1156, 179);
            this.dataGridView_MedicinesTable.TabIndex = 51;
            // 
            // dataGridView_PatientTreatment
            // 
            this.dataGridView_PatientTreatment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_PatientTreatment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_PatientTreatment.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_PatientTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PatientTreatment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.dataGridView_PatientTreatment.Location = new System.Drawing.Point(60, 459);
            this.dataGridView_PatientTreatment.Name = "dataGridView_PatientTreatment";
            this.dataGridView_PatientTreatment.ReadOnly = true;
            this.dataGridView_PatientTreatment.RowHeadersWidth = 51;
            this.dataGridView_PatientTreatment.RowTemplate.Height = 24;
            this.dataGridView_PatientTreatment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_PatientTreatment.Size = new System.Drawing.Size(1156, 179);
            this.dataGridView_PatientTreatment.TabIndex = 52;
            this.dataGridView_PatientTreatment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVew_OpenTreatmentDetails);
            // 
            // FormTreatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1294, 671);
            this.Controls.Add(this.dataGridView_PatientTreatment);
            this.Controls.Add(this.dataGridView_MedicinesTable);
            this.Controls.Add(this.dataGridView_PatientTable);
            this.Controls.Add(this.btn_AddMedicineForPatient);
            this.DoubleBuffered = true;
            this.Name = "FormTreatment";
            this.Text = "PATIENT AND TREATMENTS";
            this.Load += new System.EventHandler(this.FormTreatment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PatientTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MedicinesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PatientTreatment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_AddMedicineForPatient;
        private System.Windows.Forms.DataGridView dataGridView_MedicinesTable;
        public System.Windows.Forms.DataGridView dataGridView_PatientTable;
        public System.Windows.Forms.DataGridView dataGridView_PatientTreatment;
    }
}