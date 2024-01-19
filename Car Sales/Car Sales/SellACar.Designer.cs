namespace Car_Sales
{
    partial class SellACar
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
            components = new System.ComponentModel.Container();
            RemoveAccessoryButton = new Button();
            AddAccessoriesButton = new Button();
            gbAccessories = new GroupBox();
            lbAddedAccessories = new ListBox();
            clbSelectedAccessories = new CheckedListBox();
            tbSelectedCarForSale = new TextBox();
            BackToCatalogueButton = new Button();
            gbBuyersCredentials = new GroupBox();
            tbCity = new TextBox();
            tbZipCode = new TextBox();
            tbAdress = new TextBox();
            tbPhoneNumber = new TextBox();
            tbLastName = new TextBox();
            tbFirstName = new TextBox();
            CityLabel = new Label();
            ZipCodeLabel = new Label();
            AdressLabel = new Label();
            PhoneNumberLabel = new Label();
            LastNameLabel = new Label();
            firstNameLabel = new Label();
            CurrentTimeLabel = new Label();
            Timer = new System.Windows.Forms.Timer(components);
            SellCarButton = new Button();
            gbAccessories.SuspendLayout();
            gbBuyersCredentials.SuspendLayout();
            SuspendLayout();
            // 
            // RemoveAccessoryButton
            // 
            RemoveAccessoryButton.BackColor = Color.FromArgb(255, 111, 97);
            RemoveAccessoryButton.Location = new Point(877, 629);
            RemoveAccessoryButton.Name = "RemoveAccessoryButton";
            RemoveAccessoryButton.Size = new Size(246, 46);
            RemoveAccessoryButton.TabIndex = 520;
            RemoveAccessoryButton.Text = "Remove";
            RemoveAccessoryButton.UseVisualStyleBackColor = false;
            RemoveAccessoryButton.Click += RemoveAccessoryButton_Click;
            // 
            // AddAccessoriesButton
            // 
            AddAccessoriesButton.BackColor = Color.FromArgb(143, 219, 132);
            AddAccessoriesButton.Location = new Point(589, 629);
            AddAccessoriesButton.Name = "AddAccessoriesButton";
            AddAccessoriesButton.Size = new Size(253, 46);
            AddAccessoriesButton.TabIndex = 519;
            AddAccessoriesButton.Text = "Add Accessories";
            AddAccessoriesButton.UseVisualStyleBackColor = false;
            AddAccessoriesButton.Click += AddAccessoriesButton_Click;
            // 
            // gbAccessories
            // 
            gbAccessories.Controls.Add(lbAddedAccessories);
            gbAccessories.Controls.Add(clbSelectedAccessories);
            gbAccessories.Location = new Point(583, 43);
            gbAccessories.Name = "gbAccessories";
            gbAccessories.Size = new Size(559, 568);
            gbAccessories.TabIndex = 518;
            gbAccessories.TabStop = false;
            gbAccessories.Text = "Accessories";
            // 
            // lbAddedAccessories
            // 
            lbAddedAccessories.FormattingEnabled = true;
            lbAddedAccessories.Location = new Point(294, 38);
            lbAddedAccessories.Name = "lbAddedAccessories";
            lbAddedAccessories.Size = new Size(246, 484);
            lbAddedAccessories.TabIndex = 1;
            lbAddedAccessories.SelectedIndexChanged += lbAddedAccessories_SelectedIndexChanged;
            // 
            // clbSelectedAccessories
            // 
            clbSelectedAccessories.ColumnWidth = 250;
            clbSelectedAccessories.FormattingEnabled = true;
            clbSelectedAccessories.Location = new Point(6, 38);
            clbSelectedAccessories.MultiColumn = true;
            clbSelectedAccessories.Name = "clbSelectedAccessories";
            clbSelectedAccessories.Size = new Size(253, 508);
            clbSelectedAccessories.TabIndex = 0;
            // 
            // tbSelectedCarForSale
            // 
            tbSelectedCarForSale.BackColor = Color.LightSkyBlue;
            tbSelectedCarForSale.Cursor = Cursors.No;
            tbSelectedCarForSale.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbSelectedCarForSale.Location = new Point(50, 143);
            tbSelectedCarForSale.Multiline = true;
            tbSelectedCarForSale.Name = "tbSelectedCarForSale";
            tbSelectedCarForSale.ReadOnly = true;
            tbSelectedCarForSale.Size = new Size(466, 241);
            tbSelectedCarForSale.TabIndex = 517;
            tbSelectedCarForSale.Text = "Select a car";
            tbSelectedCarForSale.TextAlign = HorizontalAlignment.Center;
            // 
            // BackToCatalogueButton
            // 
            BackToCatalogueButton.Location = new Point(18, 26);
            BackToCatalogueButton.Name = "BackToCatalogueButton";
            BackToCatalogueButton.Size = new Size(238, 46);
            BackToCatalogueButton.TabIndex = 521;
            BackToCatalogueButton.Text = "Back to Catalogue";
            BackToCatalogueButton.UseVisualStyleBackColor = true;
            BackToCatalogueButton.Click += BackToCatalogueButton_Click;
            // 
            // gbBuyersCredentials
            // 
            gbBuyersCredentials.Controls.Add(tbCity);
            gbBuyersCredentials.Controls.Add(tbZipCode);
            gbBuyersCredentials.Controls.Add(tbAdress);
            gbBuyersCredentials.Controls.Add(tbPhoneNumber);
            gbBuyersCredentials.Controls.Add(tbLastName);
            gbBuyersCredentials.Controls.Add(tbFirstName);
            gbBuyersCredentials.Controls.Add(CityLabel);
            gbBuyersCredentials.Controls.Add(ZipCodeLabel);
            gbBuyersCredentials.Controls.Add(AdressLabel);
            gbBuyersCredentials.Controls.Add(PhoneNumberLabel);
            gbBuyersCredentials.Controls.Add(LastNameLabel);
            gbBuyersCredentials.Controls.Add(firstNameLabel);
            gbBuyersCredentials.Location = new Point(12, 422);
            gbBuyersCredentials.Name = "gbBuyersCredentials";
            gbBuyersCredentials.Size = new Size(554, 577);
            gbBuyersCredentials.TabIndex = 522;
            gbBuyersCredentials.TabStop = false;
            gbBuyersCredentials.Text = "Buyers Credentials";
            // 
            // tbCity
            // 
            tbCity.Location = new Point(199, 394);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(200, 39);
            tbCity.TabIndex = 11;
            // 
            // tbZipCode
            // 
            tbZipCode.Location = new Point(199, 334);
            tbZipCode.Name = "tbZipCode";
            tbZipCode.Size = new Size(200, 39);
            tbZipCode.TabIndex = 10;
            // 
            // tbAdress
            // 
            tbAdress.Location = new Point(199, 274);
            tbAdress.Name = "tbAdress";
            tbAdress.Size = new Size(200, 39);
            tbAdress.TabIndex = 9;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(227, 214);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(200, 39);
            tbPhoneNumber.TabIndex = 8;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(199, 154);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(200, 39);
            tbLastName.TabIndex = 7;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(199, 96);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(200, 39);
            tbFirstName.TabIndex = 6;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold);
            CityLabel.Location = new Point(6, 396);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(86, 37);
            CityLabel.TabIndex = 5;
            CityLabel.Text = "City:  ";
            // 
            // ZipCodeLabel
            // 
            ZipCodeLabel.AutoSize = true;
            ZipCodeLabel.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold);
            ZipCodeLabel.Location = new Point(6, 334);
            ZipCodeLabel.Name = "ZipCodeLabel";
            ZipCodeLabel.Size = new Size(140, 37);
            ZipCodeLabel.TabIndex = 4;
            ZipCodeLabel.Text = "Zip Code: ";
            // 
            // AdressLabel
            // 
            AdressLabel.AutoSize = true;
            AdressLabel.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold);
            AdressLabel.Location = new Point(6, 274);
            AdressLabel.Name = "AdressLabel";
            AdressLabel.Size = new Size(113, 37);
            AdressLabel.TabIndex = 3;
            AdressLabel.Text = "Adress: ";
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold);
            PhoneNumberLabel.Location = new Point(6, 214);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(218, 37);
            PhoneNumberLabel.TabIndex = 2;
            PhoneNumberLabel.Text = "Phone Number: ";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold);
            LastNameLabel.Location = new Point(6, 157);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(160, 37);
            LastNameLabel.TabIndex = 1;
            LastNameLabel.Text = "Last Name: ";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold);
            firstNameLabel.Location = new Point(6, 96);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(164, 37);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name: ";
            // 
            // CurrentTimeLabel
            // 
            CurrentTimeLabel.AutoSize = true;
            CurrentTimeLabel.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CurrentTimeLabel.Location = new Point(50, 91);
            CurrentTimeLabel.Name = "CurrentTimeLabel";
            CurrentTimeLabel.Size = new Size(198, 40);
            CurrentTimeLabel.TabIndex = 523;
            CurrentTimeLabel.Text = "Current Time";
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick;
            // 
            // SellCarButton
            // 
            SellCarButton.Location = new Point(598, 937);
            SellCarButton.Name = "SellCarButton";
            SellCarButton.Size = new Size(208, 62);
            SellCarButton.TabIndex = 12;
            SellCarButton.Text = "Sell Car";
            SellCarButton.UseVisualStyleBackColor = true;
            SellCarButton.Click += SellCarButton_Click;
            // 
            // SellACar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(91, 176, 255);
            ClientSize = new Size(1188, 1011);
            Controls.Add(SellCarButton);
            Controls.Add(CurrentTimeLabel);
            Controls.Add(gbBuyersCredentials);
            Controls.Add(BackToCatalogueButton);
            Controls.Add(RemoveAccessoryButton);
            Controls.Add(AddAccessoriesButton);
            Controls.Add(gbAccessories);
            Controls.Add(tbSelectedCarForSale);
            Name = "SellACar";
            Text = "SellACar";
            gbAccessories.ResumeLayout(false);
            gbBuyersCredentials.ResumeLayout(false);
            gbBuyersCredentials.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RemoveAccessoryButton;
        private Button AddAccessoriesButton;
        private GroupBox gbAccessories;
        private ListBox lbAddedAccessories;
        private CheckedListBox clbSelectedAccessories;
        private TextBox tbSelectedCarForSale;
        private Button BackToCatalogueButton;
        private GroupBox gbBuyersCredentials;
        private Label firstNameLabel;
        private Label LastNameLabel;
        private Label PhoneNumberLabel;
        private Label AdressLabel;
        private Label ZipCodeLabel;
        private Label CityLabel;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private TextBox tbPhoneNumber;
        private TextBox tbAdress;
        private TextBox tbZipCode;
        private TextBox tbCity;
        private Label CurrentTimeLabel;
        private System.Windows.Forms.Timer Timer;
        private Button SellCarButton;
    }
}