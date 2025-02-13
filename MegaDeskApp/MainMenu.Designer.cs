namespace MegaDeskApp
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            NewQuoteBtn = new Button();
            ViewQuotesBtn = new Button();
            SearchQuoteBtn = new Button();
            ExitBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // NewQuoteBtn
            // 
            NewQuoteBtn.Location = new Point(10, 2);
            NewQuoteBtn.Name = "NewQuoteBtn";
            NewQuoteBtn.Size = new Size(198, 52);
            NewQuoteBtn.TabIndex = 0;
            NewQuoteBtn.Text = "Add New Quote";
            NewQuoteBtn.UseVisualStyleBackColor = true;
            NewQuoteBtn.Click += NewQuoteBtn_Click;
            // 
            // ViewQuotesBtn
            // 
            ViewQuotesBtn.Location = new Point(10, 60);
            ViewQuotesBtn.Name = "ViewQuotesBtn";
            ViewQuotesBtn.Size = new Size(198, 52);
            ViewQuotesBtn.TabIndex = 1;
            ViewQuotesBtn.Text = "View Quotes";
            ViewQuotesBtn.UseVisualStyleBackColor = true;
            ViewQuotesBtn.Click += OpenViewQuotes;
            // 
            // SearchQuoteBtn
            // 
            SearchQuoteBtn.Location = new Point(10, 118);
            SearchQuoteBtn.Name = "SearchQuoteBtn";
            SearchQuoteBtn.Size = new Size(198, 52);
            SearchQuoteBtn.TabIndex = 2;
            SearchQuoteBtn.Text = "Search Quotes";
            SearchQuoteBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(10, 176);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(198, 52);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(214, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 230);
            Controls.Add(pictureBox1);
            Controls.Add(ExitBtn);
            Controls.Add(SearchQuoteBtn);
            Controls.Add(ViewQuotesBtn);
            Controls.Add(NewQuoteBtn);
            Name = "MainMenu";
            Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button NewQuoteBtn;
        private Button ViewQuotesBtn;
        private Button SearchQuoteBtn;
        private Button ExitBtn;
        private PictureBox pictureBox1;
    }
}
