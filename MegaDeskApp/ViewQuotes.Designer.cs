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
            // ViewQuotes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainMenuBtn);
            Name = "ViewQuotes";
            Text = "ViewQuotes";
            Load += ViewQuotes_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button MainMenuBtn;
    }
}