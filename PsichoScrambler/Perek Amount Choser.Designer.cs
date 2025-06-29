namespace PsichoScrambler
{
    partial class PerekAmountChoser
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
            CamotiButton = new Button();
            CamotiAmount = new NumericUpDown();
            HebrewAmount = new NumericUpDown();
            HebrewButton = new Button();
            EnglishAmount = new NumericUpDown();
            EnglishButton = new Button();
            GenerateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)CamotiAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HebrewAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EnglishAmount).BeginInit();
            SuspendLayout();
            // 
            // CamotiButton
            // 
            CamotiButton.BackColor = Color.Yellow;
            CamotiButton.Enabled = false;
            CamotiButton.Location = new Point(177, 55);
            CamotiButton.Name = "CamotiButton";
            CamotiButton.Size = new Size(285, 49);
            CamotiButton.TabIndex = 0;
            CamotiButton.Text = "כמותי";
            CamotiButton.UseVisualStyleBackColor = false;
            // 
            // CamotiAmount
            // 
            CamotiAmount.Location = new Point(483, 61);
            CamotiAmount.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            CamotiAmount.Name = "CamotiAmount";
            CamotiAmount.Size = new Size(86, 39);
            CamotiAmount.TabIndex = 1;
            CamotiAmount.TextAlign = HorizontalAlignment.Center;
            CamotiAmount.ValueChanged += CamotiAmount_ValueChanged;
            // 
            // HebrewAmount
            // 
            HebrewAmount.Location = new Point(483, 162);
            HebrewAmount.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            HebrewAmount.Name = "HebrewAmount";
            HebrewAmount.Size = new Size(86, 39);
            HebrewAmount.TabIndex = 3;
            HebrewAmount.TextAlign = HorizontalAlignment.Center;
            HebrewAmount.ValueChanged += HebrewAmount_ValueChanged;
            // 
            // HebrewButton
            // 
            HebrewButton.BackColor = Color.Yellow;
            HebrewButton.Enabled = false;
            HebrewButton.Location = new Point(177, 156);
            HebrewButton.Name = "HebrewButton";
            HebrewButton.Size = new Size(285, 49);
            HebrewButton.TabIndex = 2;
            HebrewButton.Text = "עברית";
            HebrewButton.UseVisualStyleBackColor = false;
            // 
            // EnglishAmount
            // 
            EnglishAmount.Location = new Point(483, 265);
            EnglishAmount.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            EnglishAmount.Name = "EnglishAmount";
            EnglishAmount.Size = new Size(86, 39);
            EnglishAmount.TabIndex = 5;
            EnglishAmount.TextAlign = HorizontalAlignment.Center;
            EnglishAmount.ValueChanged += EnglishAmount_ValueChanged;
            // 
            // EnglishButton
            // 
            EnglishButton.BackColor = Color.Yellow;
            EnglishButton.Enabled = false;
            EnglishButton.Location = new Point(177, 259);
            EnglishButton.Name = "EnglishButton";
            EnglishButton.Size = new Size(285, 49);
            EnglishButton.TabIndex = 4;
            EnglishButton.Text = "אנגלית";
            EnglishButton.UseVisualStyleBackColor = false;
            // 
            // GenerateButton
            // 
            GenerateButton.BackColor = Color.ForestGreen;
            GenerateButton.Location = new Point(139, 340);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(381, 46);
            GenerateButton.TabIndex = 6;
            GenerateButton.Text = "צור סדר פרקים";
            GenerateButton.UseMnemonic = false;
            GenerateButton.UseVisualStyleBackColor = false;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // PerekAmountChoser
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 398);
            Controls.Add(GenerateButton);
            Controls.Add(EnglishAmount);
            Controls.Add(EnglishButton);
            Controls.Add(HebrewAmount);
            Controls.Add(HebrewButton);
            Controls.Add(CamotiAmount);
            Controls.Add(CamotiButton);
            Name = "PerekAmountChoser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Perek_Amount_Choser";
            ((System.ComponentModel.ISupportInitialize)CamotiAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)HebrewAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)EnglishAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button CamotiButton;
        private NumericUpDown CamotiAmount;
        private NumericUpDown HebrewAmount;
        private Button HebrewButton;
        private NumericUpDown EnglishAmount;
        private Button EnglishButton;
        private Button GenerateButton;
    }
}