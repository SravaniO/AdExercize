
namespace AdExercize
{
    partial class FormAdDetails
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxAdNumber = new TextBox();
            label4 = new Label();
            textBoxPrice = new TextBox();
            buttonSearch = new Button();
            dataGridViewDetails = new DataGridView();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            label6 = new Label();
            textBoxTitle = new TextBox();
            comboBoxCN = new ComboBox();
            textBoxDescription = new RichTextBox();
            textBoxSearch = new TextBox();
            textBoxCategoryID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetails).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 0;
            label1.Text = "CategoryID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 1;
            label2.Text = "AdNumber";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 229);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // textBoxAdNumber
            // 
            textBoxAdNumber.Location = new Point(168, 97);
            textBoxAdNumber.Name = "textBoxAdNumber";
            textBoxAdNumber.Size = new Size(150, 31);
            textBoxAdNumber.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 330);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 6;
            label4.Text = "Description";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(168, 229);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(150, 31);
            textBoxPrice.TabIndex = 9;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(715, 36);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(112, 34);
            buttonSearch.TabIndex = 12;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // dataGridViewDetails
            // 
            dataGridViewDetails.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetails.GridColor = SystemColors.Info;
            dataGridViewDetails.Location = new Point(540, 244);
            dataGridViewDetails.Name = "dataGridViewDetails";
            dataGridViewDetails.RowHeadersWidth = 62;
            dataGridViewDetails.Size = new Size(360, 225);
            dataGridViewDetails.TabIndex = 13;
            dataGridViewDetails.CellContentClick += dataGridViewDetails_CellContentClick;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(23, 507);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(112, 34);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(206, 507);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(112, 34);
            buttonUpdate.TabIndex = 15;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(392, 507);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(112, 34);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 160);
            label6.Name = "label6";
            label6.Size = new Size(44, 25);
            label6.TabIndex = 17;
            label6.Text = "Title";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(168, 160);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(150, 31);
            textBoxTitle.TabIndex = 18;
            // 
            // comboBoxCN
            // 
            comboBoxCN.FormattingEnabled = true;
            comboBoxCN.Location = new Point(571, 152);
            comboBoxCN.Name = "comboBoxCN";
            comboBoxCN.Size = new Size(182, 33);
            comboBoxCN.TabIndex = 19;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(168, 330);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(237, 90);
            textBoxDescription.TabIndex = 20;
            textBoxDescription.Text = "";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(487, 39);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(182, 31);
            textBoxSearch.TabIndex = 21;
            // 
            // textBoxCategoryID
            // 
            textBoxCategoryID.Location = new Point(168, 30);
            textBoxCategoryID.Name = "textBoxCategoryID";
            textBoxCategoryID.Size = new Size(150, 31);
            textBoxCategoryID.TabIndex = 22;
            // 
            // FormAdDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1069, 597);
            Controls.Add(textBoxCategoryID);
            Controls.Add(textBoxSearch);
            Controls.Add(textBoxDescription);
            Controls.Add(comboBoxCN);
            Controls.Add(textBoxTitle);
            Controls.Add(label6);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewDetails);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxPrice);
            Controls.Add(label4);
            Controls.Add(textBoxAdNumber);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAdDetails";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxAdNumber;
        private Label label4;
        private TextBox textBoxPrice;
        private Button buttonSearch;
        private DataGridView dataGridViewDetails;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Label label6;
        private TextBox textBoxTitle;
        private ComboBox comboBoxCN;
        private RichTextBox textBoxDescription;
        private TextBox textBoxSearch;
        private TextBox textBoxCategoryID;
    }
}
