namespace FinalProj
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            Destination = new ComboBox();
            label3 = new Label();
            checkedListBox1 = new CheckedListBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label7 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("HP Simplified Hans", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(221, 65);
            label1.Name = "label1";
            label1.Size = new Size(248, 36);
            label1.TabIndex = 0;
            label1.Text = "PLAN YOUR TRIP!";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("HP Simplified Hans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 149);
            label2.Name = "label2";
            label2.Size = new Size(171, 18);
            label2.TabIndex = 1;
            label2.Text = "Select your destination:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Destination
            // 
            Destination.DropDownStyle = ComboBoxStyle.Simple;
            Destination.FormattingEnabled = true;
            Destination.Items.AddRange(new object[] { "Bulgaria", "Japan", "Singapore", "Spain", "France", "New Guinea", "Jamaica", "Taiwan", "Bali" });
            Destination.Location = new Point(47, 183);
            Destination.Name = "Destination";
            Destination.Size = new Size(131, 150);
            Destination.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Font = new Font("HP Simplified Hans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(260, 149);
            label3.Name = "label3";
            label3.Size = new Size(167, 18);
            label3.TabIndex = 4;
            label3.Text = "Choose some activities:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Cursor = Cursors.Hand;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Skydiving", "Sightseeing", "Spa and Relax", "Boat drive", "Hike", "Restaurants and food" });
            checkedListBox1.Location = new Point(260, 185);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(138, 148);
            checkedListBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gainsboro;
            label4.Font = new Font("HP Simplified Hans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(466, 149);
            label4.Name = "label4";
            label4.Size = new Size(211, 18);
            label4.TabIndex = 6;
            label4.Text = "Select the days of your travel:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Cursor = Cursors.Hand;
            dateTimePicker1.Location = new Point(466, 215);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gainsboro;
            label6.Font = new Font("HP Simplified Hans Light", 9.749999F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(466, 188);
            label6.Name = "label6";
            label6.Size = new Size(97, 14);
            label6.TabIndex = 9;
            label6.Text = "Beginning of trip";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gainsboro;
            label5.Font = new Font("HP Simplified Hans Light", 9.749999F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(466, 257);
            label5.Name = "label5";
            label5.Size = new Size(63, 14);
            label5.TabIndex = 10;
            label5.Text = "End of trip";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(466, 291);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gainsboro;
            label7.Font = new Font("HP Simplified Hans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(81, 374);
            label7.Name = "label7";
            label7.Size = new Size(195, 18);
            label7.TabIndex = 12;
            label7.Text = "Enter your budget (in leva):";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(81, 416);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 23);
            textBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(410, 416);
            button1.Name = "button1";
            button1.Size = new Size(168, 32);
            button1.TabIndex = 14;
            button1.Text = "Add trip to profile";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.image_82;
            ClientSize = new Size(700, 519);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(dateTimePicker2);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(checkedListBox1);
            Controls.Add(label3);
            Controls.Add(Destination);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox Destination;
        private Label label3;
        private CheckedListBox checkedListBox1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private Label label7;
        private TextBox textBox1;
        private Button button1;
    }
}