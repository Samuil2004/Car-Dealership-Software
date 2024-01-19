namespace Car_Sales
{
    partial class Catalogue
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
            SellCarButton = new Button();
            tbSelectedCarInfo = new TextBox();
            lbAvailableCars = new ListBox();
            gbSearchBox = new GroupBox();
            rbAllPrices = new RadioButton();
            BrandLabel = new Label();
            MaxPriceLabel = new Label();
            SelectedPriceLabel = new Label();
            TrackBarPrice = new TrackBar();
            SearchButton = new Button();
            tbBrand = new TextBox();
            ModelLabel = new Label();
            tbModel = new TextBox();
            rbPriceRange = new RadioButton();
            gbSearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrackBarPrice).BeginInit();
            SuspendLayout();
            // 
            // SellCarButton
            // 
            SellCarButton.Location = new Point(813, 687);
            SellCarButton.Name = "SellCarButton";
            SellCarButton.Size = new Size(245, 67);
            SellCarButton.TabIndex = 517;
            SellCarButton.Text = "Sell Car";
            SellCarButton.UseVisualStyleBackColor = true;
            SellCarButton.Click += SellCarButton_Click_1;
            // 
            // tbSelectedCarInfo
            // 
            tbSelectedCarInfo.BackColor = Color.LightSkyBlue;
            tbSelectedCarInfo.Cursor = Cursors.No;
            tbSelectedCarInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbSelectedCarInfo.Location = new Point(678, 384);
            tbSelectedCarInfo.Multiline = true;
            tbSelectedCarInfo.Name = "tbSelectedCarInfo";
            tbSelectedCarInfo.ReadOnly = true;
            tbSelectedCarInfo.Size = new Size(466, 241);
            tbSelectedCarInfo.TabIndex = 516;
            tbSelectedCarInfo.Text = "Select a car";
            tbSelectedCarInfo.TextAlign = HorizontalAlignment.Center;
            // 
            // lbAvailableCars
            // 
            lbAvailableCars.FormattingEnabled = true;
            lbAvailableCars.Location = new Point(23, 302);
            lbAvailableCars.Name = "lbAvailableCars";
            lbAvailableCars.Size = new Size(518, 452);
            lbAvailableCars.TabIndex = 515;
            lbAvailableCars.SelectedIndexChanged += lbAvailableCars_SelectedIndexChanged_1;
            // 
            // gbSearchBox
            // 
            gbSearchBox.Controls.Add(rbAllPrices);
            gbSearchBox.Controls.Add(BrandLabel);
            gbSearchBox.Controls.Add(MaxPriceLabel);
            gbSearchBox.Controls.Add(SelectedPriceLabel);
            gbSearchBox.Controls.Add(TrackBarPrice);
            gbSearchBox.Controls.Add(SearchButton);
            gbSearchBox.Controls.Add(tbBrand);
            gbSearchBox.Controls.Add(ModelLabel);
            gbSearchBox.Controls.Add(tbModel);
            gbSearchBox.Controls.Add(rbPriceRange);
            gbSearchBox.Location = new Point(23, 24);
            gbSearchBox.Name = "gbSearchBox";
            gbSearchBox.Size = new Size(1127, 212);
            gbSearchBox.TabIndex = 514;
            gbSearchBox.TabStop = false;
            gbSearchBox.Text = "Search Box";
            // 
            // rbAllPrices
            // 
            rbAllPrices.AutoSize = true;
            rbAllPrices.Location = new Point(16, 164);
            rbAllPrices.Name = "rbAllPrices";
            rbAllPrices.Size = new Size(140, 36);
            rbAllPrices.TabIndex = 510;
            rbAllPrices.TabStop = true;
            rbAllPrices.Text = "All Prices";
            rbAllPrices.UseVisualStyleBackColor = true;
            rbAllPrices.CheckedChanged += rbAllPrices_CheckedChanged;
            // 
            // BrandLabel
            // 
            BrandLabel.AutoSize = true;
            BrandLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BrandLabel.Location = new Point(16, 51);
            BrandLabel.Name = "BrandLabel";
            BrandLabel.Size = new Size(100, 37);
            BrandLabel.TabIndex = 501;
            BrandLabel.Text = "Brand:";
            // 
            // MaxPriceLabel
            // 
            MaxPriceLabel.AutoSize = true;
            MaxPriceLabel.Location = new Point(971, 117);
            MaxPriceLabel.Name = "MaxPriceLabel";
            MaxPriceLabel.Size = new Size(64, 32);
            MaxPriceLabel.TabIndex = 506;
            MaxPriceLabel.Text = "Max:";
            // 
            // SelectedPriceLabel
            // 
            SelectedPriceLabel.AutoSize = true;
            SelectedPriceLabel.Location = new Point(971, 162);
            SelectedPriceLabel.Name = "SelectedPriceLabel";
            SelectedPriceLabel.Size = new Size(79, 32);
            SelectedPriceLabel.TabIndex = 508;
            SelectedPriceLabel.Text = "€1000";
            // 
            // TrackBarPrice
            // 
            TrackBarPrice.LargeChange = 2500;
            TrackBarPrice.Location = new Point(227, 110);
            TrackBarPrice.Maximum = 100000;
            TrackBarPrice.Minimum = 1000;
            TrackBarPrice.Name = "TrackBarPrice";
            TrackBarPrice.Size = new Size(724, 90);
            TrackBarPrice.SmallChange = 2500;
            TrackBarPrice.TabIndex = 2500;
            TrackBarPrice.Value = 1000;
            TrackBarPrice.Scroll += TrackBarPrice_Scroll;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(971, 37);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(150, 46);
            SearchButton.TabIndex = 509;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click_1;
            // 
            // tbBrand
            // 
            tbBrand.Location = new Point(131, 48);
            tbBrand.Name = "tbBrand";
            tbBrand.Size = new Size(200, 39);
            tbBrand.TabIndex = 503;
            // 
            // ModelLabel
            // 
            ModelLabel.AutoSize = true;
            ModelLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ModelLabel.Location = new Point(419, 51);
            ModelLabel.Name = "ModelLabel";
            ModelLabel.Size = new Size(107, 37);
            ModelLabel.TabIndex = 502;
            ModelLabel.Text = "Model:";
            // 
            // tbModel
            // 
            tbModel.Location = new Point(552, 48);
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(200, 39);
            tbModel.TabIndex = 504;
            // 
            // rbPriceRange
            // 
            rbPriceRange.AutoSize = true;
            rbPriceRange.Location = new Point(16, 117);
            rbPriceRange.Name = "rbPriceRange";
            rbPriceRange.Size = new Size(189, 36);
            rbPriceRange.TabIndex = 505;
            rbPriceRange.TabStop = true;
            rbPriceRange.Text = "Set Max Price";
            rbPriceRange.UseVisualStyleBackColor = true;
            rbPriceRange.CheckedChanged += rbPriceRange_CheckedChanged_1;
            // 
            // Catalogue
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(91, 176, 255);
            ClientSize = new Size(1188, 866);
            Controls.Add(SellCarButton);
            Controls.Add(tbSelectedCarInfo);
            Controls.Add(lbAvailableCars);
            Controls.Add(gbSearchBox);
            Name = "Catalogue";
            Text = "Form1";
            gbSearchBox.ResumeLayout(false);
            gbSearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrackBarPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SellCarButton;
        private TextBox tbSelectedCarInfo;
        private ListBox lbAvailableCars;
        private GroupBox gbSearchBox;
        private Label BrandLabel;
        private Label MaxPriceLabel;
        private Label SelectedPriceLabel;
        private Button SearchButton;
        private TextBox tbBrand;
        private Label ModelLabel;
        private TrackBar TrackBarPrice;
        private TextBox tbModel;
        private RadioButton rbPriceRange;
        private RadioButton rbAllPrices;
    }
}
