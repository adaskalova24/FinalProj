namespace FinalProj
{
    partial class PackingList
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
            checkedListBox1 = new CheckedListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.Cursor = Cursors.Hand;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Camera", "Sunglasses", "Hat", "Raincoat", "Medicine" });
            checkedListBox1.Location = new Point(348, 168);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(138, 148);
            checkedListBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("HP Simplified Hans", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(95, 34);
            label1.Name = "label1";
            label1.Size = new Size(358, 33);
            label1.TabIndex = 7;
            label1.Text = "What do you want to bring?";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("HP Simplified Hans", 14.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(40, 133);
            label2.Name = "label2";
            label2.Size = new Size(71, 22);
            label2.TabIndex = 8;
            label2.Text = "Clothes";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("HP Simplified Hans", 14.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(199, 133);
            label3.Name = "label3";
            label3.Size = new Size(93, 22);
            label3.TabIndex = 9;
            label3.Text = "Cosmetics";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gainsboro;
            label4.Font = new Font("HP Simplified Hans", 14.2499981F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(348, 133);
            label4.Name = "label4";
            label4.Size = new Size(56, 22);
            label4.TabIndex = 10;
            label4.Text = "Other";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // PackingList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.travel_background_613yzbmemikozd151;
            ClientSize = new Size(599, 396);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkedListBox1);
            Name = "PackingList";
            Text = "PackingList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}