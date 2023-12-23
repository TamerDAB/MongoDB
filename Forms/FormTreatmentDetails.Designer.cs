
namespace Hospital.Forms
{
    partial class FormTreatmentDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_SelectNewMedicine = new System.Windows.Forms.Button();
            this.textBox_UpdateOrDeleteMedicineExpiratinDate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_UpdateOrDeleteMedicineReleaseDate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_UpdateOrDeleteMedicineQuantity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_UpdateOrDeleteType = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_UpdateOrDeleteMedicineTypeOfDisease = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_UpdateOrDeleteMedicineName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_UpdateOrDeleteMedicineCode = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_SelectNewPatient = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_UpdateOrDeletePatientID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_UpdateOrDeletePatientReleaseDate = new System.Windows.Forms.TextBox();
            this.textBox_UpdateOrDeletePatientFirstName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_UpdateOrDeletePatientDateRecieved = new System.Windows.Forms.TextBox();
            this.textBox_UpdateOrDeletePatientLastName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_UpdateOrDeletePatientTypeOfDisease = new System.Windows.Forms.TextBox();
            this.textBox_UpdateOrDeletePatientAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_UpdateOrDeletePatientCityAddress = new System.Windows.Forms.TextBox();
            this.textBox_UpdateOrDeletePatientGender = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_UpdateOrDeletePatientPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_TreatmentMongoID = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_deleteTreatmnet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.btn_SelectNewMedicine);
            this.groupBox1.Controls.Add(this.textBox_UpdateOrDeleteMedicineExpiratinDate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox_UpdateOrDeleteMedicineReleaseDate);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox_UpdateOrDeleteMedicineQuantity);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox_UpdateOrDeleteType);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBox_UpdateOrDeleteMedicineTypeOfDisease);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBox_UpdateOrDeleteMedicineName);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.textBox_UpdateOrDeleteMedicineCode);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox1.Location = new System.Drawing.Point(32, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 565);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicine Details :";
            // 
            // btn_SelectNewMedicine
            // 
            this.btn_SelectNewMedicine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SelectNewMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.btn_SelectNewMedicine.FlatAppearance.BorderSize = 0;
            this.btn_SelectNewMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectNewMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_SelectNewMedicine.ForeColor = System.Drawing.Color.Ivory;
            this.btn_SelectNewMedicine.Location = new System.Drawing.Point(181, 511);
            this.btn_SelectNewMedicine.Name = "btn_SelectNewMedicine";
            this.btn_SelectNewMedicine.Size = new System.Drawing.Size(220, 48);
            this.btn_SelectNewMedicine.TabIndex = 112;
            this.btn_SelectNewMedicine.Text = "Select New Medicine";
            this.btn_SelectNewMedicine.UseVisualStyleBackColor = false;
            this.btn_SelectNewMedicine.Click += new System.EventHandler(this.btn_SelectNewMedicine_Click);
            // 
            // textBox_UpdateOrDeleteMedicineExpiratinDate
            // 
            this.textBox_UpdateOrDeleteMedicineExpiratinDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_UpdateOrDeleteMedicineExpiratinDate.ForeColor = System.Drawing.Color.Black;
            this.textBox_UpdateOrDeleteMedicineExpiratinDate.Location = new System.Drawing.Point(218, 298);
            this.textBox_UpdateOrDeleteMedicineExpiratinDate.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_UpdateOrDeleteMedicineExpiratinDate.MinimumSize = new System.Drawing.Size(30, 30);
            this.textBox_UpdateOrDeleteMedicineExpiratinDate.Name = "textBox_UpdateOrDeleteMedicineExpiratinDate";
            this.textBox_UpdateOrDeleteMedicineExpiratinDate.ReadOnly = true;
            this.textBox_UpdateOrDeleteMedicineExpiratinDate.Size = new System.Drawing.Size(311, 34);
            this.textBox_UpdateOrDeleteMedicineExpiratinDate.TabIndex = 111;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(21, 293);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.MinimumSize = new System.Drawing.Size(30, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 30);
            this.label11.TabIndex = 110;
            this.label11.Text = "Expiration Date :";
            // 
            // textBox_UpdateOrDeleteMedicineReleaseDate
            // 
            this.textBox_UpdateOrDeleteMedicineReleaseDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_UpdateOrDeleteMedicineReleaseDate.ForeColor = System.Drawing.Color.Black;
            this.textBox_UpdateOrDeleteMedicineReleaseDate.Location = new System.Drawing.Point(197, 258);
            this.textBox_UpdateOrDeleteMedicineReleaseDate.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_UpdateOrDeleteMedicineReleaseDate.MinimumSize = new System.Drawing.Size(30, 30);
            this.textBox_UpdateOrDeleteMedicineReleaseDate.Name = "textBox_UpdateOrDeleteMedicineReleaseDate";
            this.textBox_UpdateOrDeleteMedicineReleaseDate.ReadOnly = true;
            this.textBox_UpdateOrDeleteMedicineReleaseDate.Size = new System.Drawing.Size(311, 34);
            this.textBox_UpdateOrDeleteMedicineReleaseDate.TabIndex = 109;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(21, 258);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.MinimumSize = new System.Drawing.Size(30, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 30);
            this.label12.TabIndex = 108;
            this.label12.Text = "Release Date  :";
            // 
            // textBox_UpdateOrDeleteMedicineQuantity
            // 
            this.textBox_UpdateOrDeleteMedicineQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_UpdateOrDeleteMedicineQuantity.ForeColor = System.Drawing.Color.Black;
            this.textBox_UpdateOrDeleteMedicineQuantity.Location = new System.Drawing.Point(147, 223);
            this.textBox_UpdateOrDeleteMedicineQuantity.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_UpdateOrDeleteMedicineQuantity.MinimumSize = new System.Drawing.Size(30, 30);
            this.textBox_UpdateOrDeleteMedicineQuantity.Name = "textBox_UpdateOrDeleteMedicineQuantity";
            this.textBox_UpdateOrDeleteMedicineQuantity.ReadOnly = true;
            this.textBox_UpdateOrDeleteMedicineQuantity.Size = new System.Drawing.Size(311, 34);
            this.textBox_UpdateOrDeleteMedicineQuantity.TabIndex = 107;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label13.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(21, 223);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.MinimumSize = new System.Drawing.Size(30, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 30);
            this.label13.TabIndex = 106;
            this.label13.Text = "Quantity :";
            // 
            // textBox_UpdateOrDeleteType
            // 
            this.textBox_UpdateOrDeleteType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_UpdateOrDeleteType.ForeColor = System.Drawing.Color.Black;
            this.textBox_UpdateOrDeleteType.Location = new System.Drawing.Point(107, 184);
            this.textBox_UpdateOrDeleteType.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_UpdateOrDeleteType.MinimumSize = new System.Drawing.Size(30, 22);
            this.textBox_UpdateOrDeleteType.Name = "textBox_UpdateOrDeleteType";
            this.textBox_UpdateOrDeleteType.ReadOnly = true;
            this.textBox_UpdateOrDeleteType.Size = new System.Drawing.Size(311, 34);
            this.textBox_UpdateOrDeleteType.TabIndex = 105;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label14.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(21, 179);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.MinimumSize = new System.Drawing.Size(30, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 30);
            this.label14.TabIndex = 104;
            this.label14.Text = "Type :";
            // 
            // textBox_UpdateOrDeleteMedicineTypeOfDisease
            // 
            this.textBox_UpdateOrDeleteMedicineTypeOfDisease.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_UpdateOrDeleteMedicineTypeOfDisease.ForeColor = System.Drawing.Color.Black;
            this.textBox_UpdateOrDeleteMedicineTypeOfDisease.Location = new System.Drawing.Point(221, 140);
            this.textBox_UpdateOrDeleteMedicineTypeOfDisease.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_UpdateOrDeleteMedicineTypeOfDisease.MinimumSize = new System.Drawing.Size(30, 22);
            this.textBox_UpdateOrDeleteMedicineTypeOfDisease.Name = "textBox_UpdateOrDeleteMedicineTypeOfDisease";
            this.textBox_UpdateOrDeleteMedicineTypeOfDisease.ReadOnly = true;
            this.textBox_UpdateOrDeleteMedicineTypeOfDisease.Size = new System.Drawing.Size(311, 34);
            this.textBox_UpdateOrDeleteMedicineTypeOfDisease.TabIndex = 103;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label15.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(21, 140);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.MinimumSize = new System.Drawing.Size(30, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(190, 30);
            this.label15.TabIndex = 102;
            this.label15.Text = "Type Of Disease :";
            // 
            // textBox_UpdateOrDeleteMedicineName
            // 
            this.textBox_UpdateOrDeleteMedicineName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_UpdateOrDeleteMedicineName.ForeColor = System.Drawing.Color.Black;
            this.textBox_UpdateOrDeleteMedicineName.Location = new System.Drawing.Point(212, 100);
            this.textBox_UpdateOrDeleteMedicineName.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_UpdateOrDeleteMedicineName.MinimumSize = new System.Drawing.Size(30, 22);
            this.textBox_UpdateOrDeleteMedicineName.Name = "textBox_UpdateOrDeleteMedicineName";
            this.textBox_UpdateOrDeleteMedicineName.ReadOnly = true;
            this.textBox_UpdateOrDeleteMedicineName.Size = new System.Drawing.Size(311, 34);
            this.textBox_UpdateOrDeleteMedicineName.TabIndex = 101;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label16.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(21, 100);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.MinimumSize = new System.Drawing.Size(30, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(181, 30);
            this.label16.TabIndex = 100;
            this.label16.Text = "Medicine Name :";
            // 
            // textBox_UpdateOrDeleteMedicineCode
            // 
            this.textBox_UpdateOrDeleteMedicineCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_UpdateOrDeleteMedicineCode.ForeColor = System.Drawing.Color.Black;
            this.textBox_UpdateOrDeleteMedicineCode.Location = new System.Drawing.Point(211, 60);
            this.textBox_UpdateOrDeleteMedicineCode.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_UpdateOrDeleteMedicineCode.MinimumSize = new System.Drawing.Size(30, 22);
            this.textBox_UpdateOrDeleteMedicineCode.Name = "textBox_UpdateOrDeleteMedicineCode";
            this.textBox_UpdateOrDeleteMedicineCode.ReadOnly = true;
            this.textBox_UpdateOrDeleteMedicineCode.Size = new System.Drawing.Size(311, 34);
            this.textBox_UpdateOrDeleteMedicineCode.TabIndex = 99;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label17.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(21, 60);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.MinimumSize = new System.Drawing.Size(30, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(180, 30);
            this.label17.TabIndex = 98;
            this.label17.Text = "Medicine Code  :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.btn_SelectNewPatient);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.textBox_UpdateOrDeletePatientID);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.textBox_UpdateOrDeletePatientReleaseDate);
            this.groupBox2.Controls.Add(this.textBox_UpdateOrDeletePatientFirstName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_UpdateOrDeletePatientDateRecieved);
            this.groupBox2.Controls.Add(this.textBox_UpdateOrDeletePatientLastName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_UpdateOrDeletePatientTypeOfDisease);
            this.groupBox2.Controls.Add(this.textBox_UpdateOrDeletePatientAge);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_UpdateOrDeletePatientCityAddress);
            this.groupBox2.Controls.Add(this.textBox_UpdateOrDeletePatientGender);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_UpdateOrDeletePatientPhoneNumber);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox2.Location = new System.Drawing.Point(587, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 565);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient Detailes";
            // 
            // btn_SelectNewPatient
            // 
            this.btn_SelectNewPatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SelectNewPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.btn_SelectNewPatient.FlatAppearance.BorderSize = 0;
            this.btn_SelectNewPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectNewPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_SelectNewPatient.ForeColor = System.Drawing.Color.Ivory;
            this.btn_SelectNewPatient.Location = new System.Drawing.Point(185, 511);
            this.btn_SelectNewPatient.Name = "btn_SelectNewPatient";
            this.btn_SelectNewPatient.Size = new System.Drawing.Size(220, 48);
            this.btn_SelectNewPatient.TabIndex = 113;
            this.btn_SelectNewPatient.Text = "Select New Patient";
            this.btn_SelectNewPatient.UseVisualStyleBackColor = false;
            this.btn_SelectNewPatient.Click += new System.EventHandler(this.btn_SelectNewPatient_Click);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label19.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(24, 60);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.MinimumSize = new System.Drawing.Size(30, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(129, 30);
            this.label19.TabIndex = 116;
            this.label19.Text = "Patient ID :";
            // 
            // textBox_UpdateOrDeletePatientID
            // 
            this.textBox_UpdateOrDeletePatientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_UpdateOrDeletePatientID.ForeColor = System.Drawing.Color.Black;
            this.textBox_UpdateOrDeletePatientID.Location = new System.Drawing.Point(163, 63);
            this.textBox_UpdateOrDeletePatientID.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_UpdateOrDeletePatientID.MinimumSize = new System.Drawing.Size(30, 22);
            this.textBox_UpdateOrDeletePatientID.Name = "textBox_UpdateOrDeletePatientID";
            this.textBox_UpdateOrDeletePatientID.ReadOnly = true;
            this.textBox_UpdateOrDeletePatientID.Size = new System.Drawing.Size(268, 34);
            this.textBox_UpdateOrDeletePatientID.TabIndex = 117;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label18.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(24, 103);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.MinimumSize = new System.Drawing.Size(30, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(138, 30);
            this.label18.TabIndex = 118;
            this.label18.Text = "First Name :";
            // 
            // textBox_UpdateOrDeletePatientReleaseDate
            // 
            this.textBox_UpdateOrDeletePatientReleaseDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_UpdateOrDeletePatientReleaseDate.ForeColor = System.Drawing.Color.Black;
            this.textBox_UpdateOrDeletePatientReleaseDate.Location = new System.Drawing.Point(199, 424);
            this.textBox_UpdateOrDeletePatientReleaseDate.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_UpdateOrDeletePatientReleaseDate.MinimumSize = new System.Drawing.Size(30, 30);
            this.textBox_UpdateOrDeletePatientReleaseDate.Name = "textBox_UpdateOrDeletePatientReleaseDate";
            this.textBox_UpdateOrDeletePatientReleaseDate.ReadOnly = true;
            this.textBox_UpdateOrDeletePatientReleaseDate.Size = new System.Drawing.Size(268, 34);
            this.textBox_UpdateOrDeletePatientReleaseDate.TabIndex = 135;
            // 
            // textBox_UpdateOrDeletePatientFirstName
            // 
            this.textBox_UpdateOrDeletePatientFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_UpdateOrDeletePatientFirstName.ForeColor = System.Drawing.Color.Black;
            this.textBox_UpdateOrDeletePatientFirstName.Location = new System.Drawing.Point(172, 103);
            this.textBox_UpdateOrDeletePatientFirstName.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_UpdateOrDeletePatientFirstName.MinimumSize = new System.Drawing.Size(30, 22);
            this.textBox_UpdateOrDeletePatientFirstName.Name = "textBox_UpdateOrDeletePatientFirstName";
            this.textBox_UpdateOrDeletePatientFirstName.ReadOnly = true;
            this.textBox_UpdateOrDeletePatientFirstName.Size = new System.Drawing.Size(268, 34);
            this.textBox_UpdateOrDeletePatientFirstName.TabIndex = 119;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(29, 426);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.MinimumSize = new System.Drawing.Size(30, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 30);
            this.label10.TabIndex = 134;
            this.label10.Text = "Release Date :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.MinimumSize = new System.Drawing.Size(30, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 30);
            this.label4.TabIndex = 120;
            this.label4.Text = "Last Name :";
            // 
            // textBox_UpdateOrDeletePatientDateRecieved
            // 
            this.textBox_UpdateOrDeletePatientDateRecieved.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_UpdateOrDeletePatientDateRecieved.ForeColor = System.Drawing.Color.Black;
            this.textBox_UpdateOrDeletePatientDateRecieved.Location = new System.Drawing.Point(211, 387);
            this.textBox_UpdateOrDeletePatientDateRecieved.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_UpdateOrDeletePatientDateRecieved.MinimumSize = new System.Drawing.Size(30, 30);
            this.textBox_UpdateOrDeletePatientDateRecieved.Name = "textBox_UpdateOrDeletePatientDateRecieved";
            this.textBox_UpdateOrDeletePatientDateRecieved.ReadOnly = true;
            this.textBox_UpdateOrDeletePatientDateRecieved.Size = new System.Drawing.Size(268, 34);
            this.textBox_UpdateOrDeletePatientDateRecieved.TabIndex = 133;
            // 
            // textBox_UpdateOrDeletePatientLastName
            // 
            this.textBox_UpdateOrDeletePatientLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_UpdateOrDeletePatientLastName.ForeColor = System.Drawing.Color.Black;
            this.textBox_UpdateOrDeletePatientLastName.Location = new System.Drawing.Point(168, 142);
            this.textBox_UpdateOrDeletePatientLastName.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_UpdateOrDeletePatientLastName.MinimumSize = new System.Drawing.Size(30, 22);
            this.textBox_UpdateOrDeletePatientLastName.Name = "textBox_UpdateOrDeletePatientLastName";
            this.textBox_UpdateOrDeletePatientLastName.ReadOnly = true;
            this.textBox_UpdateOrDeletePatientLastName.Size = new System.Drawing.Size(268, 34);
            this.textBox_UpdateOrDeletePatientLastName.TabIndex = 121;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(29, 389);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.MinimumSize = new System.Drawing.Size(30, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 30);
            this.label9.TabIndex = 132;
            this.label9.Text = "Date Recieved :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.MinimumSize = new System.Drawing.Size(30, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 30);
            this.label5.TabIndex = 122;
            this.label5.Text = "Age :";
            // 
            // textBox_UpdateOrDeletePatientTypeOfDisease
            // 
            this.textBox_UpdateOrDeletePatientTypeOfDisease.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_UpdateOrDeletePatientTypeOfDisease.ForeColor = System.Drawing.Color.Black;
            this.textBox_UpdateOrDeletePatientTypeOfDisease.Location = new System.Drawing.Point(224, 343);
            this.textBox_UpdateOrDeletePatientTypeOfDisease.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_UpdateOrDeletePatientTypeOfDisease.MinimumSize = new System.Drawing.Size(30, 30);
            this.textBox_UpdateOrDeletePatientTypeOfDisease.Name = "textBox_UpdateOrDeletePatientTypeOfDisease";
            this.textBox_UpdateOrDeletePatientTypeOfDisease.ReadOnly = true;
            this.textBox_UpdateOrDeletePatientTypeOfDisease.Size = new System.Drawing.Size(268, 34);
            this.textBox_UpdateOrDeletePatientTypeOfDisease.TabIndex = 131;
            // 
            // textBox_UpdateOrDeletePatientAge
            // 
            this.textBox_UpdateOrDeletePatientAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_UpdateOrDeletePatientAge.ForeColor = System.Drawing.Color.Black;
            this.textBox_UpdateOrDeletePatientAge.Location = new System.Drawing.Point(100, 182);
            this.textBox_UpdateOrDeletePatientAge.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_UpdateOrDeletePatientAge.MinimumSize = new System.Drawing.Size(30, 22);
            this.textBox_UpdateOrDeletePatientAge.Name = "textBox_UpdateOrDeletePatientAge";
            this.textBox_UpdateOrDeletePatientAge.ReadOnly = true;
            this.textBox_UpdateOrDeletePatientAge.Size = new System.Drawing.Size(268, 34);
            this.textBox_UpdateOrDeletePatientAge.TabIndex = 123;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 343);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.MinimumSize = new System.Drawing.Size(30, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 30);
            this.label3.TabIndex = 130;
            this.label3.Text = "Type Of Disease :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(24, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.MinimumSize = new System.Drawing.Size(30, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 30);
            this.label6.TabIndex = 124;
            this.label6.Text = "Gender :";
            // 
            // textBox_UpdateOrDeletePatientCityAddress
            // 
            this.textBox_UpdateOrDeletePatientCityAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_UpdateOrDeletePatientCityAddress.ForeColor = System.Drawing.Color.Black;
            this.textBox_UpdateOrDeletePatientCityAddress.Location = new System.Drawing.Point(191, 298);
            this.textBox_UpdateOrDeletePatientCityAddress.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_UpdateOrDeletePatientCityAddress.MinimumSize = new System.Drawing.Size(30, 30);
            this.textBox_UpdateOrDeletePatientCityAddress.Name = "textBox_UpdateOrDeletePatientCityAddress";
            this.textBox_UpdateOrDeletePatientCityAddress.ReadOnly = true;
            this.textBox_UpdateOrDeletePatientCityAddress.Size = new System.Drawing.Size(268, 34);
            this.textBox_UpdateOrDeletePatientCityAddress.TabIndex = 129;
            // 
            // textBox_UpdateOrDeletePatientGender
            // 
            this.textBox_UpdateOrDeletePatientGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_UpdateOrDeletePatientGender.ForeColor = System.Drawing.Color.Black;
            this.textBox_UpdateOrDeletePatientGender.Location = new System.Drawing.Point(136, 221);
            this.textBox_UpdateOrDeletePatientGender.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_UpdateOrDeletePatientGender.MinimumSize = new System.Drawing.Size(30, 22);
            this.textBox_UpdateOrDeletePatientGender.Name = "textBox_UpdateOrDeletePatientGender";
            this.textBox_UpdateOrDeletePatientGender.ReadOnly = true;
            this.textBox_UpdateOrDeletePatientGender.Size = new System.Drawing.Size(268, 34);
            this.textBox_UpdateOrDeletePatientGender.TabIndex = 125;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(24, 305);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.MinimumSize = new System.Drawing.Size(30, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 30);
            this.label8.TabIndex = 128;
            this.label8.Text = "City Address :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(24, 263);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.MinimumSize = new System.Drawing.Size(30, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 30);
            this.label7.TabIndex = 126;
            this.label7.Text = "Phone Number :";
            // 
            // textBox_UpdateOrDeletePatientPhoneNumber
            // 
            this.textBox_UpdateOrDeletePatientPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_UpdateOrDeletePatientPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.textBox_UpdateOrDeletePatientPhoneNumber.Location = new System.Drawing.Point(215, 258);
            this.textBox_UpdateOrDeletePatientPhoneNumber.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_UpdateOrDeletePatientPhoneNumber.MinimumSize = new System.Drawing.Size(30, 30);
            this.textBox_UpdateOrDeletePatientPhoneNumber.Name = "textBox_UpdateOrDeletePatientPhoneNumber";
            this.textBox_UpdateOrDeletePatientPhoneNumber.ReadOnly = true;
            this.textBox_UpdateOrDeletePatientPhoneNumber.Size = new System.Drawing.Size(268, 34);
            this.textBox_UpdateOrDeletePatientPhoneNumber.TabIndex = 127;
            // 
            // textBox_TreatmentMongoID
            // 
            this.textBox_TreatmentMongoID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_TreatmentMongoID.BackColor = System.Drawing.Color.White;
            this.textBox_TreatmentMongoID.ForeColor = System.Drawing.Color.Black;
            this.textBox_TreatmentMongoID.Location = new System.Drawing.Point(547, 36);
            this.textBox_TreatmentMongoID.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_TreatmentMongoID.MinimumSize = new System.Drawing.Size(30, 22);
            this.textBox_TreatmentMongoID.Multiline = true;
            this.textBox_TreatmentMongoID.Name = "textBox_TreatmentMongoID";
            this.textBox_TreatmentMongoID.ReadOnly = true;
            this.textBox_TreatmentMongoID.Size = new System.Drawing.Size(268, 33);
            this.textBox_TreatmentMongoID.TabIndex = 141;
            this.textBox_TreatmentMongoID.Visible = false;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.label20.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(384, 39);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.MinimumSize = new System.Drawing.Size(30, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(153, 30);
            this.label20.TabIndex = 140;
            this.label20.Text = "MongoDB ID :";
            this.label20.Visible = false;
            // 
            // btn_deleteTreatmnet
            // 
            this.btn_deleteTreatmnet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_deleteTreatmnet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_deleteTreatmnet.FlatAppearance.BorderSize = 0;
            this.btn_deleteTreatmnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteTreatmnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_deleteTreatmnet.ForeColor = System.Drawing.Color.Ivory;
            this.btn_deleteTreatmnet.Location = new System.Drawing.Point(474, 654);
            this.btn_deleteTreatmnet.Name = "btn_deleteTreatmnet";
            this.btn_deleteTreatmnet.Size = new System.Drawing.Size(220, 48);
            this.btn_deleteTreatmnet.TabIndex = 142;
            this.btn_deleteTreatmnet.Text = "Delete Treatment";
            this.btn_deleteTreatmnet.UseVisualStyleBackColor = false;
            this.btn_deleteTreatmnet.Click += new System.EventHandler(this.btn_deleteTreatmnet_Click);
            // 
            // FormTreatmentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hospital.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1177, 730);
            this.Controls.Add(this.btn_deleteTreatmnet);
            this.Controls.Add(this.textBox_TreatmentMongoID);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "FormTreatmentDetails";
            this.Text = "FormTreatmentDetails";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox textBox_UpdateOrDeleteMedicineExpiratinDate;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox textBox_UpdateOrDeleteMedicineReleaseDate;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox textBox_UpdateOrDeleteMedicineQuantity;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox textBox_UpdateOrDeleteType;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox textBox_UpdateOrDeleteMedicineTypeOfDisease;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox textBox_UpdateOrDeleteMedicineName;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox textBox_UpdateOrDeleteMedicineCode;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox textBox_UpdateOrDeletePatientID;
        private System.Windows.Forms.Button btn_SelectNewMedicine;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox textBox_UpdateOrDeletePatientReleaseDate;
        public System.Windows.Forms.TextBox textBox_UpdateOrDeletePatientFirstName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_UpdateOrDeletePatientDateRecieved;
        public System.Windows.Forms.TextBox textBox_UpdateOrDeletePatientLastName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBox_UpdateOrDeletePatientTypeOfDisease;
        public System.Windows.Forms.TextBox textBox_UpdateOrDeletePatientAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBox_UpdateOrDeletePatientCityAddress;
        public System.Windows.Forms.TextBox textBox_UpdateOrDeletePatientGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textBox_UpdateOrDeletePatientPhoneNumber;
        private System.Windows.Forms.Button btn_SelectNewPatient;
        public System.Windows.Forms.TextBox textBox_TreatmentMongoID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btn_deleteTreatmnet;
    }
}