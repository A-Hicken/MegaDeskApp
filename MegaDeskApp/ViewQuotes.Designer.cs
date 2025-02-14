namespace MegaDeskApp
{
    partial class ViewQuotes
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
            DateLabel = new Label();
            WidthReq = new Label();
            SuspendLayout();
            // 
            // MainMenuBtn
            // 
            MainMenuBtn.Location = new Point(24, 374);
            MainMenuBtn.Name = "MainMenuBtn";
            MainMenuBtn.Size = new Size(198, 52);
            MainMenuBtn.TabIndex = 1;
            MainMenuBtn.Text = "Go Back";
            MainMenuBtn.UseVisualStyleBackColor = true;
            MainMenuBtn.Click += GoBack_Click;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI", 12.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateLabel.Location = new Point(24, 31);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(70, 35);
            DateLabel.TabIndex = 2;
            DateLabel.Text = "Date";
            // 
            // WidthReq
            // 
            WidthReq.AutoSize = true;
            WidthReq.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WidthReq.Location = new Point(12, 81);
            WidthReq.Name = "WidthReq";
            WidthReq.Size = new Size(49, 25);
            WidthReq.TabIndex = 3;
            WidthReq.Text = "Date";
            // 
            // ViewQuotes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(WidthReq);
            Controls.Add(DateLabel);
            Controls.Add(MainMenuBtn);
            Name = "ViewQuotes";
            Text = "View Quotes";
            Load += ViewQuotes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MainMenuBtn;
        private Label DateLabel;
        private Label WidthReq;
    }
}