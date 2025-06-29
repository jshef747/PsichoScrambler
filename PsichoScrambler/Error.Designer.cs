namespace PsichoScrambler
{
    partial class Error
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
            ErrorText = new TextBox();
            OkButton = new Button();
            SuspendLayout();
            // 
            // ErrorText
            // 
            ErrorText.BorderStyle = BorderStyle.None;
            ErrorText.Enabled = false;
            ErrorText.Location = new Point(2, 25);
            ErrorText.Name = "ErrorText";
            ErrorText.ReadOnly = true;
            ErrorText.Size = new Size(607, 32);
            ErrorText.TabIndex = 0;
            ErrorText.Text = "מספר הפרקים צריך להיות 8";
            ErrorText.TextAlign = HorizontalAlignment.Center;
            // 
            // OkButton
            // 
            OkButton.BackColor = Color.Lime;
            OkButton.ForeColor = Color.Black;
            OkButton.Location = new Point(229, 129);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(150, 46);
            OkButton.TabIndex = 1;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = false;
            OkButton.Click += OkButton_Click;
            // 
            // Error
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 187);
            Controls.Add(OkButton);
            Controls.Add(ErrorText);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Error";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Error";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ErrorText;
        private Button OkButton;
    }
}