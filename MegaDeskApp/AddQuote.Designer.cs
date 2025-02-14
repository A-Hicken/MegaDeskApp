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

        //private void InitializeComponent()
        //{
        //    InitializeComponent(WidthBox);
        //    InitializeComponent(DepthBox);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            MainMenuBtn = new Button();
            lblDate = new Label();
            lblCustomerName = new Label();
            lblWidth = new Label();
            lblDepth = new Label();
            lblDeskDrawer = new Label();
            lblMaterialType = new Label();
            NameBox = new TextBox();
            WidthBox = new TextBox();
            DepthBox = new TextBox();
            lblDrawerAmount = new Label();
            lblMaterial = new Label();
            lblShippingTimeframe = new Label();
            button2 = new Button();
            DrawerInput = new ComboBox();
            MaterialComboBox = new ComboBox();
            ShippingComboBox = new ComboBox();
            DateLabel = new Label();
            NameErrorProvider = new ErrorProvider(components);
            WidthErrorProvider = new ErrorProvider(components);
            DepthErrorProvider = new ErrorProvider(components);
            DrawerErrorProvider = new ErrorProvider(components);
            ShippingErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)NameErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WidthErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DepthErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DrawerErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShippingErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // MainMenuBtn
            // 
            MainMenuBtn.Location = new Point(10, 361);
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
            lblDate.Size = new Size(113, 25);
            lblDate.TabIndex = 1;
            lblDate.Text = "Today's Date";
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
            lblDeskDrawer.Location = new Point(0, 0);
            lblDeskDrawer.Name = "lblDeskDrawer";
            lblDeskDrawer.Size = new Size(100, 23);
            lblDeskDrawer.TabIndex = 0;
            // 
            // lblMaterialType
            // 
            lblMaterialType.Location = new Point(0, 0);
            lblMaterialType.Name = "lblMaterialType";
            lblMaterialType.Size = new Size(100, 23);
            lblMaterialType.TabIndex = 0;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(229, 55);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(198, 31);
            NameBox.TabIndex = 9;
            NameBox.Validating += NameBox_Validating;
            // 
            // WidthBox
            // 
            WidthBox.Location = new Point(229, 99);
            WidthBox.Name = "WidthBox";
            WidthBox.Size = new Size(198, 31);
            WidthBox.TabIndex = 10;
            WidthBox.Validating += WidthBox_Validating;
            // 
            // DepthBox
            // 
            DepthBox.Location = new Point(229, 154);
            DepthBox.Name = "DepthBox";
            DepthBox.Size = new Size(198, 31);
            DepthBox.TabIndex = 11;
            DepthBox.Validating += DepthBox_Validating;
            // 
            // lblDrawerAmount
            // 
            lblDrawerAmount.AutoSize = true;
            lblDrawerAmount.Location = new Point(22, 219);
            lblDrawerAmount.Name = "lblDrawerAmount";
            lblDrawerAmount.Size = new Size(186, 25);
            lblDrawerAmount.TabIndex = 17;
            lblDrawerAmount.Text = "Desk Drawer Amount:";
            // 
            // lblMaterial
            // 
            lblMaterial.AutoSize = true;
            lblMaterial.Location = new Point(22, 266);
            lblMaterial.Name = "lblMaterial";
            lblMaterial.Size = new Size(121, 25);
            lblMaterial.TabIndex = 18;
            lblMaterial.Text = "Material Type:";
            // 
            // lblShippingTimeframe
            // 
            lblShippingTimeframe.AutoSize = true;
            lblShippingTimeframe.Location = new Point(22, 319);
            lblShippingTimeframe.Name = "lblShippingTimeframe";
            lblShippingTimeframe.Size = new Size(176, 25);
            lblShippingTimeframe.TabIndex = 19;
            lblShippingTimeframe.Text = "Shipping Timeframe:";
            // 
            // button2
            // 
            button2.Location = new Point(229, 361);
            button2.Name = "button2";
            button2.Size = new Size(198, 52);
            button2.TabIndex = 20;
            button2.Text = "Submit Order";
            button2.UseVisualStyleBackColor = true;
            button2.Click += SubmitOrderBtn_Click;
            // 
            // DrawerInput
            // 
            DrawerInput.FormattingEnabled = true;
            DrawerInput.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7" });
            DrawerInput.Location = new Point(229, 216);
            DrawerInput.Name = "DrawerInput";
            DrawerInput.Size = new Size(198, 33);
            DrawerInput.TabIndex = 21;
            DrawerInput.Validating += DrawerInput_Validating;
            // 
            // MaterialComboBox
            // 
            MaterialComboBox.FormattingEnabled = true;
            MaterialComboBox.Items.AddRange(new object[] { "Pine", "Laminate", "Veneer", "Oak", "Rosewood" });
            MaterialComboBox.Location = new Point(229, 263);
            MaterialComboBox.Name = "MaterialComboBox";
            MaterialComboBox.Size = new Size(198, 33);
            MaterialComboBox.TabIndex = 22;
            MaterialComboBox.Validating += MaterialComboBox_Validating;
            // 
            // ShippingComboBox
            // 
            ShippingComboBox.FormattingEnabled = true;
            ShippingComboBox.Items.AddRange(new object[] { "3", "5", "7" });
            ShippingComboBox.Location = new Point(229, 311);
            ShippingComboBox.Name = "ShippingComboBox";
            ShippingComboBox.Size = new Size(198, 33);
            ShippingComboBox.TabIndex = 23;
            ShippingComboBox.Validating += ShippingComboBox_Validating;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(314, 12);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(113, 25);
            DateLabel.TabIndex = 24;
            DateLabel.Text = "Today's Date";
            // 
            // NameErrorProvider
            // 
            NameErrorProvider.ContainerControl = this;
            // 
            // WidthErrorProvider
            // 
            WidthErrorProvider.ContainerControl = this;
            // 
            // DepthErrorProvider
            // 
            DepthErrorProvider.ContainerControl = this;
            // 
            // DrawerErrorProvider
            // 
            DrawerErrorProvider.ContainerControl = this;
            // 
            // ShippingErrorProvider
            // 
            ShippingErrorProvider.ContainerControl = this;
            // 
            // AddQuote
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 425);
            Controls.Add(DateLabel);
            Controls.Add(ShippingComboBox);
            Controls.Add(MaterialComboBox);
            Controls.Add(DrawerInput);
            Controls.Add(button2);
            Controls.Add(lblShippingTimeframe);
            Controls.Add(lblMaterial);
            Controls.Add(lblDrawerAmount);
            Controls.Add(DepthBox);
            Controls.Add(WidthBox);
            Controls.Add(NameBox);
            Controls.Add(lblDepth);
            Controls.Add(lblWidth);
            Controls.Add(lblCustomerName);
            Controls.Add(lblDate);
            Controls.Add(MainMenuBtn);
            Name = "AddQuote";
            Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)NameErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)WidthErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)DepthErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)DrawerErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShippingErrorProvider).EndInit();
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
        private TextBox NameBox;
        private TextBox WidthBox;
        private TextBox DepthBox;
        private Label lblDrawerAmount;
        private Label lblMaterial;
        private Label lblShippingTimeframe;
        private Button button2;
        private ComboBox DrawerInput;
        private ComboBox MaterialComboBox;
        private ComboBox ShippingComboBox;
        private Label DateLabel;
        private ErrorProvider NameErrorProvider;
        private ErrorProvider WidthErrorProvider;
        private ErrorProvider DepthErrorProvider;
        private ErrorProvider DrawerErrorProvider;
        private ErrorProvider ShippingErrorProvider;
    }
}