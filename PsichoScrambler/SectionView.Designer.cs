namespace PsichoScrambler
{
    partial class SectionView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.TextBox textBox7;
        public System.Windows.Forms.TextBox textBox8;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();

            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();

            this.SuspendLayout();

            // SectionView Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 600);
            this.Text = "Section View";
            this.Name = "SectionView";
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // TableLayoutPanel
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Padding = new Padding(30);
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.RowStyles.Clear();

            var textBoxes = new[]
            {
        textBox1, textBox2, textBox3, textBox4,
        textBox5, textBox6, textBox7, textBox8
    };

            for (int i = 0; i < 8; i++)
            {
                // Create uniform rows
                this.tableLayoutPanel1.RowStyles.Add(
                    new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F)
                );

                var tb = textBoxes[i];
                tb.ReadOnly = true;
                tb.Enabled = false;
                tb.Dock = DockStyle.Fill;
                tb.Margin = new Padding(5);
                tb.Font = new System.Drawing.Font("Segoe UI", 12F);
                tb.TextAlign = HorizontalAlignment.Center;
                tb.BackColor = System.Drawing.Color.FromArgb(235, 243, 255);  // soft blue
                tb.BorderStyle = BorderStyle.FixedSingle;
                tb.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
                this.tableLayoutPanel1.Controls.Add(tb, 0, i);
            }

            // Final layout
            this.Controls.Add(this.tableLayoutPanel1);
            this.ResumeLayout(false);
        }
    }
}