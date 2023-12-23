
namespace Hospital
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_FilterMedicines = new System.Windows.Forms.Button();
            this.btn_FilterPatients = new System.Windows.Forms.Button();
            this.btn_PatientTreatments = new System.Windows.Forms.Button();
            this.btn_MedicinePage = new System.Windows.Forms.Button();
            this.btn_PatientPage = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lbl_UITitle = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btn_MinimizeWindow = new System.Windows.Forms.Button();
            this.btn_MaximizeWindow = new System.Windows.Forms.Button();
            this.btn_CloseWindow = new System.Windows.Forms.Button();
            this.btn_GoToHomePage = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panelDeskTopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDeskTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btn_FilterMedicines);
            this.panelMenu.Controls.Add(this.btn_FilterPatients);
            this.panelMenu.Controls.Add(this.btn_PatientTreatments);
            this.panelMenu.Controls.Add(this.btn_MedicinePage);
            this.panelMenu.Controls.Add(this.btn_PatientPage);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(275, 801);
            this.panelMenu.TabIndex = 0;
            // 
            // btn_FilterMedicines
            // 
            this.btn_FilterMedicines.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_FilterMedicines.FlatAppearance.BorderSize = 0;
            this.btn_FilterMedicines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FilterMedicines.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FilterMedicines.ForeColor = System.Drawing.Color.Ivory;
            this.btn_FilterMedicines.Image = global::Hospital.Properties.Resources.filter_icon;
            this.btn_FilterMedicines.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FilterMedicines.Location = new System.Drawing.Point(0, 605);
            this.btn_FilterMedicines.Margin = new System.Windows.Forms.Padding(4);
            this.btn_FilterMedicines.Name = "btn_FilterMedicines";
            this.btn_FilterMedicines.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_FilterMedicines.Size = new System.Drawing.Size(275, 120);
            this.btn_FilterMedicines.TabIndex = 5;
            this.btn_FilterMedicines.Text = "Filter Medicines";
            this.btn_FilterMedicines.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_FilterMedicines.UseVisualStyleBackColor = true;
            this.btn_FilterMedicines.Click += new System.EventHandler(this.btn_FilterMedicines_Click);
            // 
            // btn_FilterPatients
            // 
            this.btn_FilterPatients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_FilterPatients.FlatAppearance.BorderSize = 0;
            this.btn_FilterPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FilterPatients.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FilterPatients.ForeColor = System.Drawing.Color.Ivory;
            this.btn_FilterPatients.Image = global::Hospital.Properties.Resources.filter_icon;
            this.btn_FilterPatients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FilterPatients.Location = new System.Drawing.Point(0, 485);
            this.btn_FilterPatients.Margin = new System.Windows.Forms.Padding(4);
            this.btn_FilterPatients.Name = "btn_FilterPatients";
            this.btn_FilterPatients.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_FilterPatients.Size = new System.Drawing.Size(275, 120);
            this.btn_FilterPatients.TabIndex = 4;
            this.btn_FilterPatients.Text = "Filter Patients";
            this.btn_FilterPatients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_FilterPatients.UseVisualStyleBackColor = true;
            this.btn_FilterPatients.Click += new System.EventHandler(this.btn_FilterPatients_Click);
            // 
            // btn_PatientTreatments
            // 
            this.btn_PatientTreatments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PatientTreatments.FlatAppearance.BorderSize = 0;
            this.btn_PatientTreatments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PatientTreatments.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PatientTreatments.ForeColor = System.Drawing.Color.Ivory;
            this.btn_PatientTreatments.Image = global::Hospital.Properties.Resources.icon_treatment_64;
            this.btn_PatientTreatments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PatientTreatments.Location = new System.Drawing.Point(0, 365);
            this.btn_PatientTreatments.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PatientTreatments.Name = "btn_PatientTreatments";
            this.btn_PatientTreatments.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_PatientTreatments.Size = new System.Drawing.Size(275, 120);
            this.btn_PatientTreatments.TabIndex = 3;
            this.btn_PatientTreatments.Text = "Patient Treatments";
            this.btn_PatientTreatments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_PatientTreatments.UseVisualStyleBackColor = true;
            this.btn_PatientTreatments.Click += new System.EventHandler(this.btn_PatientTreatments_Click);
            // 
            // btn_MedicinePage
            // 
            this.btn_MedicinePage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MedicinePage.FlatAppearance.BorderSize = 0;
            this.btn_MedicinePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MedicinePage.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MedicinePage.ForeColor = System.Drawing.Color.Ivory;
            this.btn_MedicinePage.Image = global::Hospital.Properties.Resources.Medicine_icon_1;
            this.btn_MedicinePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MedicinePage.Location = new System.Drawing.Point(0, 245);
            this.btn_MedicinePage.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MedicinePage.Name = "btn_MedicinePage";
            this.btn_MedicinePage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_MedicinePage.Size = new System.Drawing.Size(275, 120);
            this.btn_MedicinePage.TabIndex = 2;
            this.btn_MedicinePage.Text = "Medicine";
            this.btn_MedicinePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_MedicinePage.UseVisualStyleBackColor = true;
            this.btn_MedicinePage.Click += new System.EventHandler(this.btn_MedicinePage_Click);
            // 
            // btn_PatientPage
            // 
            this.btn_PatientPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_PatientPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PatientPage.FlatAppearance.BorderSize = 0;
            this.btn_PatientPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PatientPage.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PatientPage.ForeColor = System.Drawing.Color.Ivory;
            this.btn_PatientPage.Image = global::Hospital.Properties.Resources.person_icon_4;
            this.btn_PatientPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PatientPage.Location = new System.Drawing.Point(0, 125);
            this.btn_PatientPage.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PatientPage.Name = "btn_PatientPage";
            this.btn_PatientPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_PatientPage.Size = new System.Drawing.Size(275, 120);
            this.btn_PatientPage.TabIndex = 0;
            this.btn_PatientPage.Text = "Patient";
            this.btn_PatientPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_PatientPage.UseVisualStyleBackColor = false;
            this.btn_PatientPage.Click += new System.EventHandler(this.btn_PatientPage_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLogo.Controls.Add(this.lbl_UITitle);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(275, 125);
            this.panelLogo.TabIndex = 1;
            // 
            // lbl_UITitle
            // 
            this.lbl_UITitle.AutoSize = true;
            this.lbl_UITitle.Font = new System.Drawing.Font("Niagara Engraved", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UITitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_UITitle.Location = new System.Drawing.Point(51, 45);
            this.lbl_UITitle.Name = "lbl_UITitle";
            this.lbl_UITitle.Size = new System.Drawing.Size(162, 47);
            this.lbl_UITitle.TabIndex = 0;
            this.lbl_UITitle.Text = "MEDICAL ZONE";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(138)))));
            this.panelTitleBar.Controls.Add(this.btn_MinimizeWindow);
            this.panelTitleBar.Controls.Add(this.btn_MaximizeWindow);
            this.panelTitleBar.Controls.Add(this.btn_CloseWindow);
            this.panelTitleBar.Controls.Add(this.btn_GoToHomePage);
            this.panelTitleBar.Controls.Add(this.lbl_Title);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(275, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1222, 125);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btn_MinimizeWindow
            // 
            this.btn_MinimizeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MinimizeWindow.FlatAppearance.BorderSize = 0;
            this.btn_MinimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MinimizeWindow.Image = global::Hospital.Properties.Resources.Icon_Close;
            this.btn_MinimizeWindow.Location = new System.Drawing.Point(1102, 12);
            this.btn_MinimizeWindow.Name = "btn_MinimizeWindow";
            this.btn_MinimizeWindow.Size = new System.Drawing.Size(35, 35);
            this.btn_MinimizeWindow.TabIndex = 4;
            this.btn_MinimizeWindow.UseVisualStyleBackColor = true;
            this.btn_MinimizeWindow.Click += new System.EventHandler(this.btn_MinimizeWindow_Click);
            // 
            // btn_MaximizeWindow
            // 
            this.btn_MaximizeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MaximizeWindow.FlatAppearance.BorderSize = 0;
            this.btn_MaximizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MaximizeWindow.Image = global::Hospital.Properties.Resources.Maximise_Icon;
            this.btn_MaximizeWindow.Location = new System.Drawing.Point(1143, 3);
            this.btn_MaximizeWindow.Name = "btn_MaximizeWindow";
            this.btn_MaximizeWindow.Size = new System.Drawing.Size(35, 35);
            this.btn_MaximizeWindow.TabIndex = 3;
            this.btn_MaximizeWindow.UseVisualStyleBackColor = true;
            this.btn_MaximizeWindow.Click += new System.EventHandler(this.btn_MaximizeWindow_Click);
            // 
            // btn_CloseWindow
            // 
            this.btn_CloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CloseWindow.FlatAppearance.BorderSize = 0;
            this.btn_CloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CloseWindow.Image = global::Hospital.Properties.Resources.cross_out_icon;
            this.btn_CloseWindow.Location = new System.Drawing.Point(1184, 3);
            this.btn_CloseWindow.Name = "btn_CloseWindow";
            this.btn_CloseWindow.Size = new System.Drawing.Size(35, 35);
            this.btn_CloseWindow.TabIndex = 2;
            this.btn_CloseWindow.UseVisualStyleBackColor = true;
            this.btn_CloseWindow.Click += new System.EventHandler(this.btn_CloseWindow_Click);
            // 
            // btn_GoToHomePage
            // 
            this.btn_GoToHomePage.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_GoToHomePage.FlatAppearance.BorderSize = 0;
            this.btn_GoToHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GoToHomePage.Image = global::Hospital.Properties.Resources.Home_Icon;
            this.btn_GoToHomePage.Location = new System.Drawing.Point(0, 0);
            this.btn_GoToHomePage.Name = "btn_GoToHomePage";
            this.btn_GoToHomePage.Size = new System.Drawing.Size(75, 125);
            this.btn_GoToHomePage.TabIndex = 1;
            this.btn_GoToHomePage.UseVisualStyleBackColor = true;
            this.btn_GoToHomePage.Click += new System.EventHandler(this.btn_GoToHomePage_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(544, 45);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(100, 32);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "HOME";
            // 
            // panelDeskTopPanel
            // 
            this.panelDeskTopPanel.Controls.Add(this.pictureBox1);
            this.panelDeskTopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeskTopPanel.Location = new System.Drawing.Point(275, 125);
            this.panelDeskTopPanel.Name = "panelDeskTopPanel";
            this.panelDeskTopPanel.Size = new System.Drawing.Size(1222, 676);
            this.panelDeskTopPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::Hospital.Properties.Resources.Logo2;
            this.pictureBox1.Location = new System.Drawing.Point(125, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 543);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1497, 801);
            this.Controls.Add(this.panelDeskTopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMainMenu";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDeskTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_PatientPage;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btn_MedicinePage;
        private System.Windows.Forms.Button btn_FilterPatients;
        private System.Windows.Forms.Button btn_PatientTreatments;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_UITitle;
        private System.Windows.Forms.Panel panelDeskTopPanel;
        private System.Windows.Forms.Button btn_GoToHomePage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_MaximizeWindow;
        private System.Windows.Forms.Button btn_CloseWindow;
        private System.Windows.Forms.Button btn_MinimizeWindow;
        private System.Windows.Forms.Button btn_FilterMedicines;
    }
}

