namespace MegaDeskApp
{
    partial class AddQuote
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
            MainMenuBtn = new Button();
            lblDate = new Label();
            lblCustomerName = new Label();
            lblWidth = new Label();
            lblDepth = new Label();
            lblDeskDrawer = new Label();
            lblMaterialType = new Label();
            lblTimeframe = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            menuStrip1 = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // MainMenuBtn
            // 
            MainMenuBtn.Location = new Point(22, 377);
            MainMenuBtn.Name = "MainMenuBtn";
            MainMenuBtn.Size = new Size(198, 52);
            MainMenuBtn.TabIndex = 0;
            MainMenuBtn.Text = "Go Back";
            MainMenuBtn.UseVisualStyleBackColor = true;
            MainMenuBtn.Click += GoBack;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(20, 12);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(117, 25);
            lblDate.TabIndex = 1;
            lblDate.Text = "Today's Date:";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(21, 58);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(202, 25);
            lblCustomerName.TabIndex = 2;
            lblCustomerName.Text = "Please Enter Your Name:";
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(22, 102);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(108, 25);
            lblWidth.TabIndex = 3;
            lblWidth.Text = "Desk Width:";
            // 
            // lblDepth
            // 
            lblDepth.AutoSize = true;
            lblDepth.Location = new Point(22, 160);
            lblDepth.Name = "lblDepth";
            lblDepth.Size = new Size(109, 25);
            lblDepth.TabIndex = 4;
            lblDepth.Text = "Desk Depth:";
            // 
            // lblDeskDrawer
            // 
            lblDeskDrawer.AutoSize = true;
            lblDeskDrawer.Location = new Point(20, 219);
            lblDeskDrawer.Name = "lblDeskDrawer";
            lblDeskDrawer.Size = new Size(186, 25);
            lblDeskDrawer.TabIndex = 5;
            lblDeskDrawer.Text = "Desk Drawer Amount:";
            // 
            // lblMaterialType
            // 
            lblMaterialType.AutoSize = true;
            lblMaterialType.Location = new Point(22, 263);
            lblMaterialType.Name = "lblMaterialType";
            lblMaterialType.Size = new Size(121, 25);
            lblMaterialType.TabIndex = 6;
            lblMaterialType.Text = "Material Type:";
            lblMaterialType.Click += lblMaterialType_Click;
            // 
            // lblTimeframe
            // 
            lblTimeframe.AutoSize = true;
            lblTimeframe.Location = new Point(32, 313);
            lblTimeframe.Name = "lblTimeframe";
            lblTimeframe.Size = new Size(176, 25);
            lblTimeframe.TabIndex = 7;
            lblTimeframe.Text = "Shipping Timeframe:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(384, 6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(285, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(419, 31);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(285, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(419, 31);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(285, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(419, 31);
            textBox3.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(285, 307);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(419, 31);
            numericUpDown1.TabIndex = 12;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // AddQuote
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblTimeframe);
            Controls.Add(lblMaterialType);
            Controls.Add(lblDeskDrawer);
            Controls.Add(lblDepth);
            Controls.Add(lblWidth);
            Controls.Add(lblCustomerName);
            Controls.Add(lblDate);
            Controls.Add(MainMenuBtn);
            Controls.Add(menuStrip1);
            Name = "AddQuote";
            Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MainMenuBtn;
        private Label lblDate;
        private Label lblCustomerName;
        private Label lblWidth;
        private Label lblDepth;
        private Label lblDeskDrawer;
        private Label lblMaterialType;
        private Label lblTimeframe;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private NumericUpDown numericUpDown1;
        private MenuStrip menuStrip1;
    }
}