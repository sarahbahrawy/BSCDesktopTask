
namespace BSCWinFormsTask
{
    partial class Visits
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SummaryrichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SalescomboBox = new System.Windows.Forms.ComboBox();
            this.CustomercomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SummaryrichTextBox
            // 
            this.SummaryrichTextBox.Location = new System.Drawing.Point(140, 131);
            this.SummaryrichTextBox.Name = "SummaryrichTextBox";
            this.SummaryrichTextBox.Size = new System.Drawing.Size(448, 96);
            this.SummaryrichTextBox.TabIndex = 2;
            this.SummaryrichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Visit summary";
            // 
            // SalescomboBox
            // 
            this.SalescomboBox.FormattingEnabled = true;
            this.SalescomboBox.Location = new System.Drawing.Point(155, 27);
            this.SalescomboBox.Name = "SalescomboBox";
            this.SalescomboBox.Size = new System.Drawing.Size(207, 24);
            this.SalescomboBox.TabIndex = 4;
            this.SalescomboBox.SelectedIndexChanged += new System.EventHandler(this.SalescomboBox_SelectedIndexChanged);
            // 
            // CustomercomboBox
            // 
            this.CustomercomboBox.FormattingEnabled = true;
            this.CustomercomboBox.Location = new System.Drawing.Point(558, 30);
            this.CustomercomboBox.Name = "CustomercomboBox";
            this.CustomercomboBox.Size = new System.Drawing.Size(202, 24);
            this.CustomercomboBox.TabIndex = 5;
            this.CustomercomboBox.SelectedIndexChanged += new System.EventHandler(this.CustomercomboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select a Sales :-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select a Customer :-";
            // 
            // NewVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomercomboBox);
            this.Controls.Add(this.SalescomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SummaryrichTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "NewVisit";
            this.Text = "NewVisit";
            this.Load += new System.EventHandler(this.NewVisit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox SummaryrichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SalescomboBox;
        private System.Windows.Forms.ComboBox CustomercomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}