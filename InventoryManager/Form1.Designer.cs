namespace InventoryManager
{
    partial class InventoryManegmentStudio
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
            priceTextBox = new TextBox();
            inventoryGridView = new DataGridView();
            newButton = new Button();
            saveButton = new Button();
            deleteButton = new Button();
            descriptionTextBox = new TextBox();
            quantityTextBox = new TextBox();
            skuTextBox = new TextBox();
            nameTextBox = new TextBox();
            categoryBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)inventoryGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Myanmar Text", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(941, 75);
            label1.TabIndex = 0;
            label1.Text = "Inventory Management Studio XL Supreme";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(12, 151);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(303, 23);
            priceTextBox.TabIndex = 1;
            priceTextBox.TextChanged += textBox1_TextChanged;
            // 
            // inventoryGridView
            // 
            inventoryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            inventoryGridView.BackgroundColor = Color.White;
            inventoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryGridView.Location = new Point(12, 243);
            inventoryGridView.Name = "inventoryGridView";
            inventoryGridView.RowTemplate.Height = 25;
            inventoryGridView.Size = new Size(941, 372);
            inventoryGridView.TabIndex = 2;
            inventoryGridView.CellDoubleClick += inventoryGridView_CellDoubleClick;
            // 
            // newButton
            // 
            newButton.BackColor = Color.White;
            newButton.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newButton.Location = new Point(12, 180);
            newButton.Name = "newButton";
            newButton.Size = new Size(303, 57);
            newButton.TabIndex = 3;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += newButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.White;
            saveButton.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Location = new Point(333, 180);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(303, 57);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.White;
            deleteButton.Font = new Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.Location = new Point(650, 180);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(303, 57);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(333, 151);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(303, 23);
            descriptionTextBox.TabIndex = 6;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(650, 151);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(303, 23);
            quantityTextBox.TabIndex = 7;
            // 
            // skuTextBox
            // 
            skuTextBox.Location = new Point(12, 103);
            skuTextBox.Name = "skuTextBox";
            skuTextBox.Size = new Size(303, 23);
            skuTextBox.TabIndex = 8;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(333, 103);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(303, 23);
            nameTextBox.TabIndex = 9;
            // 
            // categoryBox
            // 
            categoryBox.FormattingEnabled = true;
            categoryBox.Items.AddRange(new object[] { "Automotive", "Hardware", "Grocery", "Pharmacy " });
            categoryBox.Location = new Point(650, 103);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(303, 23);
            categoryBox.TabIndex = 10;
            // 
            // label2
            // 
            label2.Font = new Font("Myanmar Text", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(303, 23);
            label2.TabIndex = 11;
            label2.Text = "SKU:";
            // 
            // label3
            // 
            label3.Font = new Font("Myanmar Text", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(333, 77);
            label3.Name = "label3";
            label3.Size = new Size(303, 23);
            label3.TabIndex = 12;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.Font = new Font("Myanmar Text", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(650, 77);
            label4.Name = "label4";
            label4.Size = new Size(303, 23);
            label4.TabIndex = 13;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.Font = new Font("Myanmar Text", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(333, 125);
            label5.Name = "label5";
            label5.Size = new Size(303, 23);
            label5.TabIndex = 14;
            label5.Text = "Description:";
            // 
            // label6
            // 
            label6.Font = new Font("Myanmar Text", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 125);
            label6.Name = "label6";
            label6.Size = new Size(303, 23);
            label6.TabIndex = 15;
            label6.Text = "Price:";
            // 
            // label7
            // 
            label7.Font = new Font("Myanmar Text", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(650, 125);
            label7.Name = "label7";
            label7.Size = new Size(303, 23);
            label7.TabIndex = 16;
            label7.Text = "Quantity:";
            // 
            // InventoryManegmentStudio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(965, 627);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(categoryBox);
            Controls.Add(nameTextBox);
            Controls.Add(skuTextBox);
            Controls.Add(quantityTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(deleteButton);
            Controls.Add(saveButton);
            Controls.Add(newButton);
            Controls.Add(inventoryGridView);
            Controls.Add(priceTextBox);
            Controls.Add(label1);
            Name = "InventoryManegmentStudio";
            Text = "Inventory Manegment Studio";
            Load += InventoryManegmentStudio_Load;
            ((System.ComponentModel.ISupportInitialize)inventoryGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox priceTextBox;
        private DataGridView inventoryGridView;
        private Button newButton;
        private Button saveButton;
        private Button deleteButton;
        private TextBox descriptionTextBox;
        private TextBox quantityTextBox;
        private TextBox skuTextBox;
        private TextBox nameTextBox;
        private ComboBox categoryBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}