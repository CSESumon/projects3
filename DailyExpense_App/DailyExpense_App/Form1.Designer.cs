namespace DailyExpense_App
{
    partial class totalExpenseViewListBox
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
            this.groupBoxEntry = new System.Windows.Forms.GroupBox();
            this.groupBoxSummary = new System.Windows.Forms.GroupBox();
            this.groupBoxView = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.showSummaryViewButton = new System.Windows.Forms.Button();
            this.amountEntryTextBox = new System.Windows.Forms.TextBox();
            this.maximumExpenseViewTextBox = new System.Windows.Forms.TextBox();
            this.particulerEntryTextBox = new System.Windows.Forms.TextBox();
            this.totalSummaryViewTextBox = new System.Windows.Forms.TextBox();
            this.summeryViewListBox = new System.Windows.Forms.ListBox();
            this.categoryEntryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryViewSummaryComboBox = new System.Windows.Forms.ComboBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.totalViewlabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryViewlabel = new System.Windows.Forms.Label();
            this.totalExpenseLabel = new System.Windows.Forms.Label();
            this.particularLabel = new System.Windows.Forms.Label();
            this.maximumExpenseLabel = new System.Windows.Forms.Label();
            this.totalAmountViewlistBox = new System.Windows.Forms.ListBox();
            this.groupBoxEntry.SuspendLayout();
            this.groupBoxSummary.SuspendLayout();
            this.groupBoxView.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEntry
            // 
            this.groupBoxEntry.Controls.Add(this.categoryEntryComboBox);
            this.groupBoxEntry.Controls.Add(this.amountLabel);
            this.groupBoxEntry.Controls.Add(this.particularLabel);
            this.groupBoxEntry.Controls.Add(this.categoryLabel);
            this.groupBoxEntry.Controls.Add(this.saveButton);
            this.groupBoxEntry.Controls.Add(this.amountEntryTextBox);
            this.groupBoxEntry.Controls.Add(this.particulerEntryTextBox);
            this.groupBoxEntry.Location = new System.Drawing.Point(26, 12);
            this.groupBoxEntry.Name = "groupBoxEntry";
            this.groupBoxEntry.Size = new System.Drawing.Size(450, 199);
            this.groupBoxEntry.TabIndex = 0;
            this.groupBoxEntry.TabStop = false;
            this.groupBoxEntry.Text = "Daily Expense Entry";
            // 
            // groupBoxSummary
            // 
            this.groupBoxSummary.Controls.Add(this.totalAmountViewlistBox);
            this.groupBoxSummary.Controls.Add(this.totalExpenseLabel);
            this.groupBoxSummary.Controls.Add(this.maximumExpenseLabel);
            this.groupBoxSummary.Controls.Add(this.maximumExpenseViewTextBox);
            this.groupBoxSummary.Controls.Add(this.showButton);
            this.groupBoxSummary.Location = new System.Drawing.Point(26, 233);
            this.groupBoxSummary.Name = "groupBoxSummary";
            this.groupBoxSummary.Size = new System.Drawing.Size(450, 171);
            this.groupBoxSummary.TabIndex = 0;
            this.groupBoxSummary.TabStop = false;
            this.groupBoxSummary.Text = "View Summary";
            // 
            // groupBoxView
            // 
            this.groupBoxView.Controls.Add(this.showSummaryViewButton);
            this.groupBoxView.Controls.Add(this.categoryViewlabel);
            this.groupBoxView.Controls.Add(this.totalSummaryViewTextBox);
            this.groupBoxView.Controls.Add(this.totalViewlabel);
            this.groupBoxView.Controls.Add(this.categoryViewSummaryComboBox);
            this.groupBoxView.Controls.Add(this.summeryViewListBox);
            this.groupBoxView.Location = new System.Drawing.Point(504, 19);
            this.groupBoxView.Name = "groupBoxView";
            this.groupBoxView.Size = new System.Drawing.Size(285, 385);
            this.groupBoxView.TabIndex = 0;
            this.groupBoxView.TabStop = false;
            this.groupBoxView.Text = "View Summary";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(343, 158);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(343, 127);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // showSummaryViewButton
            // 
            this.showSummaryViewButton.Location = new System.Drawing.Point(186, 74);
            this.showSummaryViewButton.Name = "showSummaryViewButton";
            this.showSummaryViewButton.Size = new System.Drawing.Size(75, 23);
            this.showSummaryViewButton.TabIndex = 2;
            this.showSummaryViewButton.Text = "Show";
            this.showSummaryViewButton.UseVisualStyleBackColor = true;
            this.showSummaryViewButton.Click += new System.EventHandler(this.showSummaryViewButton_Click);
            // 
            // amountEntryTextBox
            // 
            this.amountEntryTextBox.Location = new System.Drawing.Point(138, 19);
            this.amountEntryTextBox.Name = "amountEntryTextBox";
            this.amountEntryTextBox.Size = new System.Drawing.Size(280, 20);
            this.amountEntryTextBox.TabIndex = 4;
            // 
            // maximumExpenseViewTextBox
            // 
            this.maximumExpenseViewTextBox.Location = new System.Drawing.Point(138, 83);
            this.maximumExpenseViewTextBox.Name = "maximumExpenseViewTextBox";
            this.maximumExpenseViewTextBox.Size = new System.Drawing.Size(280, 20);
            this.maximumExpenseViewTextBox.TabIndex = 5;
            // 
            // particulerEntryTextBox
            // 
            this.particulerEntryTextBox.Location = new System.Drawing.Point(138, 113);
            this.particulerEntryTextBox.Name = "particulerEntryTextBox";
            this.particulerEntryTextBox.Size = new System.Drawing.Size(280, 20);
            this.particulerEntryTextBox.TabIndex = 6;
            // 
            // totalSummaryViewTextBox
            // 
            this.totalSummaryViewTextBox.Location = new System.Drawing.Point(85, 341);
            this.totalSummaryViewTextBox.Name = "totalSummaryViewTextBox";
            this.totalSummaryViewTextBox.Size = new System.Drawing.Size(176, 20);
            this.totalSummaryViewTextBox.TabIndex = 7;
            // 
            // summeryViewListBox
            // 
            this.summeryViewListBox.FormattingEnabled = true;
            this.summeryViewListBox.Location = new System.Drawing.Point(85, 113);
            this.summeryViewListBox.Name = "summeryViewListBox";
            this.summeryViewListBox.Size = new System.Drawing.Size(176, 199);
            this.summeryViewListBox.TabIndex = 8;
            // 
            // categoryEntryComboBox
            // 
            this.categoryEntryComboBox.FormattingEnabled = true;
            this.categoryEntryComboBox.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Mise"});
            this.categoryEntryComboBox.Location = new System.Drawing.Point(138, 64);
            this.categoryEntryComboBox.Name = "categoryEntryComboBox";
            this.categoryEntryComboBox.Size = new System.Drawing.Size(280, 21);
            this.categoryEntryComboBox.TabIndex = 9;
            this.categoryEntryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryEntryComboBox_SelectedIndexChanged);
            // 
            // categoryViewSummaryComboBox
            // 
            this.categoryViewSummaryComboBox.FormattingEnabled = true;
            this.categoryViewSummaryComboBox.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Mice"});
            this.categoryViewSummaryComboBox.Location = new System.Drawing.Point(85, 37);
            this.categoryViewSummaryComboBox.Name = "categoryViewSummaryComboBox";
            this.categoryViewSummaryComboBox.Size = new System.Drawing.Size(176, 21);
            this.categoryViewSummaryComboBox.TabIndex = 10;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(85, 22);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 11;
            this.amountLabel.Text = "Amount";
            // 
            // totalViewlabel
            // 
            this.totalViewlabel.AutoSize = true;
            this.totalViewlabel.Location = new System.Drawing.Point(38, 341);
            this.totalViewlabel.Name = "totalViewlabel";
            this.totalViewlabel.Size = new System.Drawing.Size(31, 13);
            this.totalViewlabel.TabIndex = 12;
            this.totalViewlabel.Text = "Total";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(79, 67);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 13;
            this.categoryLabel.Text = "Category";
            // 
            // categoryViewlabel
            // 
            this.categoryViewlabel.AutoSize = true;
            this.categoryViewlabel.Location = new System.Drawing.Point(20, 40);
            this.categoryViewlabel.Name = "categoryViewlabel";
            this.categoryViewlabel.Size = new System.Drawing.Size(49, 13);
            this.categoryViewlabel.TabIndex = 14;
            this.categoryViewlabel.Text = "Category";
            this.categoryViewlabel.Click += new System.EventHandler(this.categoryViewlabel_Click);
            // 
            // totalExpenseLabel
            // 
            this.totalExpenseLabel.AutoSize = true;
            this.totalExpenseLabel.Location = new System.Drawing.Point(53, 37);
            this.totalExpenseLabel.Name = "totalExpenseLabel";
            this.totalExpenseLabel.Size = new System.Drawing.Size(75, 13);
            this.totalExpenseLabel.TabIndex = 15;
            this.totalExpenseLabel.Text = "Total Expense";
            // 
            // particularLabel
            // 
            this.particularLabel.AutoSize = true;
            this.particularLabel.Location = new System.Drawing.Point(77, 116);
            this.particularLabel.Name = "particularLabel";
            this.particularLabel.Size = new System.Drawing.Size(51, 13);
            this.particularLabel.TabIndex = 16;
            this.particularLabel.Text = "Particuler";
            // 
            // maximumExpenseLabel
            // 
            this.maximumExpenseLabel.AutoSize = true;
            this.maximumExpenseLabel.Location = new System.Drawing.Point(33, 85);
            this.maximumExpenseLabel.Name = "maximumExpenseLabel";
            this.maximumExpenseLabel.Size = new System.Drawing.Size(95, 13);
            this.maximumExpenseLabel.TabIndex = 17;
            this.maximumExpenseLabel.Text = "Maximum Expense";
            // 
            // totalAmountViewlistBox
            // 
            this.totalAmountViewlistBox.FormattingEnabled = true;
            this.totalAmountViewlistBox.Location = new System.Drawing.Point(138, 37);
            this.totalAmountViewlistBox.Name = "totalAmountViewlistBox";
            this.totalAmountViewlistBox.Size = new System.Drawing.Size(280, 17);
            this.totalAmountViewlistBox.TabIndex = 18;
            // 
            // totalExpenseViewListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 430);
            this.Controls.Add(this.groupBoxSummary);
            this.Controls.Add(this.groupBoxView);
            this.Controls.Add(this.groupBoxEntry);
            this.Name = "totalExpenseViewListBox";
            this.groupBoxEntry.ResumeLayout(false);
            this.groupBoxEntry.PerformLayout();
            this.groupBoxSummary.ResumeLayout(false);
            this.groupBoxSummary.PerformLayout();
            this.groupBoxView.ResumeLayout(false);
            this.groupBoxView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEntry;
        private System.Windows.Forms.GroupBox groupBoxSummary;
        private System.Windows.Forms.GroupBox groupBoxView;
        private System.Windows.Forms.Label particularLabel;
        private System.Windows.Forms.Label totalExpenseLabel;
        private System.Windows.Forms.TextBox totalSummaryViewTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button showSummaryViewButton;
        private System.Windows.Forms.TextBox amountEntryTextBox;
        private System.Windows.Forms.TextBox maximumExpenseViewTextBox;
        private System.Windows.Forms.TextBox particulerEntryTextBox;
        private System.Windows.Forms.ListBox summeryViewListBox;
        private System.Windows.Forms.ComboBox categoryEntryComboBox;
        private System.Windows.Forms.ComboBox categoryViewSummaryComboBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label totalViewlabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label categoryViewlabel;
        private System.Windows.Forms.Label maximumExpenseLabel;
        private System.Windows.Forms.ListBox totalAmountViewlistBox;
    }
}

