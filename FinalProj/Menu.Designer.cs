namespace FinalProj
{
    partial class Menu
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("HP Simplified Hans", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(135, 50);
            label1.Name = "label1";
            label1.Size = new Size(411, 36);
            label1.TabIndex = 1;
            label1.Text = "Craft the trip of your dreams";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("HP Simplified Hans", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(85, 50);
            label2.Name = "label2";
            label2.Size = new Size(29, 36);
            label2.TabIndex = 2;
            label2.Text = "*";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("HP Simplified Hans", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(576, 50);
            label3.Name = "label3";
            label3.Size = new Size(29, 36);
            label3.TabIndex = 3;
            label3.Text = "*";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(68, 183);
            button1.Name = "button1";
            button1.Size = new Size(147, 48);
            button1.TabIndex = 4;
            button1.Text = "Trip Planner Page";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(487, 183);
            button2.Name = "button2";
            button2.Size = new Size(165, 48);
            button2.TabIndex = 5;
            button2.Text = "Packing List Page";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(257, 295);
            button3.Name = "button3";
            button3.Size = new Size(165, 48);
            button3.TabIndex = 6;
            button3.Text = "Your Itinerary";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Location = new Point(12, 404);
            button4.Name = "button4";
            button4.Size = new Size(59, 27);
            button4.TabIndex = 7;
            button4.Text = "Log out";
            button4.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.istockphoto_1015542074_612x612;
            pictureBox1.Location = new Point(246, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.image_82;
            ClientSize = new Size(701, 443);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ImageList imageList1;
        private PictureBox pictureBox1;
    }
}