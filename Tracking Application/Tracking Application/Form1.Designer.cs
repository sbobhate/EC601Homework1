namespace Tracking_Application
{
    partial class mainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hueLowTrackBar = new System.Windows.Forms.TrackBar();
            this.saturationLowTrackBar = new System.Windows.Forms.TrackBar();
            this.valueLowTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.hueLowLabel = new System.Windows.Forms.Label();
            this.saturationLowLabel = new System.Windows.Forms.Label();
            this.valueLowLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.valueHighLabel = new System.Windows.Forms.Label();
            this.saturationHighLabel = new System.Windows.Forms.Label();
            this.hueHighLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.valueHighTrackBar = new System.Windows.Forms.TrackBar();
            this.saturationHighTrackBar = new System.Windows.Forms.TrackBar();
            this.hueHighTrackBar = new System.Windows.Forms.TrackBar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueLowTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationLowTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueLowTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueHighTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationHighTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueHighTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 240);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // hueLowTrackBar
            // 
            this.hueLowTrackBar.LargeChange = 50;
            this.hueLowTrackBar.Location = new System.Drawing.Point(97, 258);
            this.hueLowTrackBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.hueLowTrackBar.Maximum = 179;
            this.hueLowTrackBar.Name = "hueLowTrackBar";
            this.hueLowTrackBar.Size = new System.Drawing.Size(165, 45);
            this.hueLowTrackBar.TabIndex = 1;
            this.hueLowTrackBar.Scroll += new System.EventHandler(this.hueLowTrackBar_Scroll);
            this.hueLowTrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hueLowTrackBar_MouseDown);
            // 
            // saturationLowTrackBar
            // 
            this.saturationLowTrackBar.Location = new System.Drawing.Point(97, 309);
            this.saturationLowTrackBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.saturationLowTrackBar.Maximum = 255;
            this.saturationLowTrackBar.Name = "saturationLowTrackBar";
            this.saturationLowTrackBar.Size = new System.Drawing.Size(165, 45);
            this.saturationLowTrackBar.TabIndex = 2;
            this.saturationLowTrackBar.Scroll += new System.EventHandler(this.saturationLowTrackBar_Scroll);
            this.saturationLowTrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.saturationLowTrackBar_MouseDown);
            // 
            // valueLowTrackBar
            // 
            this.valueLowTrackBar.Location = new System.Drawing.Point(97, 360);
            this.valueLowTrackBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.valueLowTrackBar.Maximum = 255;
            this.valueLowTrackBar.Name = "valueLowTrackBar";
            this.valueLowTrackBar.Size = new System.Drawing.Size(165, 45);
            this.valueLowTrackBar.TabIndex = 3;
            this.valueLowTrackBar.Scroll += new System.EventHandler(this.valueLowTrackBar_Scroll);
            this.valueLowTrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.valueLowTrackBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hue (Low)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 318);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Saturation (Low)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 369);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Value (Low)";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(337, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 240);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // hueLowLabel
            // 
            this.hueLowLabel.AutoSize = true;
            this.hueLowLabel.Location = new System.Drawing.Point(266, 269);
            this.hueLowLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hueLowLabel.Name = "hueLowLabel";
            this.hueLowLabel.Size = new System.Drawing.Size(13, 13);
            this.hueLowLabel.TabIndex = 10;
            this.hueLowLabel.Text = "0";
            // 
            // saturationLowLabel
            // 
            this.saturationLowLabel.AutoSize = true;
            this.saturationLowLabel.Location = new System.Drawing.Point(266, 318);
            this.saturationLowLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.saturationLowLabel.Name = "saturationLowLabel";
            this.saturationLowLabel.Size = new System.Drawing.Size(13, 13);
            this.saturationLowLabel.TabIndex = 11;
            this.saturationLowLabel.Text = "0";
            // 
            // valueLowLabel
            // 
            this.valueLowLabel.AutoSize = true;
            this.valueLowLabel.Location = new System.Drawing.Point(266, 369);
            this.valueLowLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valueLowLabel.Name = "valueLowLabel";
            this.valueLowLabel.Size = new System.Drawing.Size(13, 13);
            this.valueLowLabel.TabIndex = 12;
            this.valueLowLabel.Text = "0";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(781, 264);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // valueHighLabel
            // 
            this.valueHighLabel.AutoSize = true;
            this.valueHighLabel.Location = new System.Drawing.Point(598, 369);
            this.valueHighLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valueHighLabel.Name = "valueHighLabel";
            this.valueHighLabel.Size = new System.Drawing.Size(25, 13);
            this.valueHighLabel.TabIndex = 22;
            this.valueHighLabel.Text = "255";
            // 
            // saturationHighLabel
            // 
            this.saturationHighLabel.AutoSize = true;
            this.saturationHighLabel.Location = new System.Drawing.Point(598, 318);
            this.saturationHighLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.saturationHighLabel.Name = "saturationHighLabel";
            this.saturationHighLabel.Size = new System.Drawing.Size(25, 13);
            this.saturationHighLabel.TabIndex = 21;
            this.saturationHighLabel.Text = "255";
            // 
            // hueHighLabel
            // 
            this.hueHighLabel.AutoSize = true;
            this.hueHighLabel.Location = new System.Drawing.Point(598, 269);
            this.hueHighLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hueHighLabel.Name = "hueHighLabel";
            this.hueHighLabel.Size = new System.Drawing.Size(25, 13);
            this.hueHighLabel.TabIndex = 20;
            this.hueHighLabel.Text = "179";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 369);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Value (High)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 318);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Saturation (High)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(343, 269);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Hue (High)";
            // 
            // valueHighTrackBar
            // 
            this.valueHighTrackBar.Location = new System.Drawing.Point(429, 360);
            this.valueHighTrackBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.valueHighTrackBar.Maximum = 255;
            this.valueHighTrackBar.Name = "valueHighTrackBar";
            this.valueHighTrackBar.Size = new System.Drawing.Size(165, 45);
            this.valueHighTrackBar.TabIndex = 16;
            this.valueHighTrackBar.Value = 255;
            this.valueHighTrackBar.Scroll += new System.EventHandler(this.valueHighTrackbBar_Scroll);
            this.valueHighTrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.valueHighTrackbBar_MouseDown);
            // 
            // saturationHighTrackBar
            // 
            this.saturationHighTrackBar.Location = new System.Drawing.Point(429, 309);
            this.saturationHighTrackBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.saturationHighTrackBar.Maximum = 255;
            this.saturationHighTrackBar.Name = "saturationHighTrackBar";
            this.saturationHighTrackBar.Size = new System.Drawing.Size(165, 45);
            this.saturationHighTrackBar.TabIndex = 15;
            this.saturationHighTrackBar.Value = 255;
            this.saturationHighTrackBar.Scroll += new System.EventHandler(this.saturationHighTrackBar_Scroll);
            this.saturationHighTrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.saturationHighTrackBar_MouseDown);
            // 
            // hueHighTrackBar
            // 
            this.hueHighTrackBar.LargeChange = 50;
            this.hueHighTrackBar.Location = new System.Drawing.Point(429, 258);
            this.hueHighTrackBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.hueHighTrackBar.Maximum = 179;
            this.hueHighTrackBar.Name = "hueHighTrackBar";
            this.hueHighTrackBar.Size = new System.Drawing.Size(165, 45);
            this.hueHighTrackBar.TabIndex = 14;
            this.hueHighTrackBar.Value = 179;
            this.hueHighTrackBar.Scroll += new System.EventHandler(this.hueHighTrackBar_Scroll);
            this.hueHighTrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hueHighTrackBar_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(661, 12);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(320, 240);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 401);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.valueHighLabel);
            this.Controls.Add(this.saturationHighLabel);
            this.Controls.Add(this.hueHighLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.valueHighTrackBar);
            this.Controls.Add(this.saturationHighTrackBar);
            this.Controls.Add(this.hueHighTrackBar);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.valueLowLabel);
            this.Controls.Add(this.saturationLowLabel);
            this.Controls.Add(this.hueLowLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valueLowTrackBar);
            this.Controls.Add(this.saturationLowTrackBar);
            this.Controls.Add(this.hueLowTrackBar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "mainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueLowTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationLowTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueLowTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueHighTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturationHighTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueHighTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar hueLowTrackBar;
        private System.Windows.Forms.TrackBar saturationLowTrackBar;
        private System.Windows.Forms.TrackBar valueLowTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label hueLowLabel;
        private System.Windows.Forms.Label saturationLowLabel;
        private System.Windows.Forms.Label valueLowLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label valueHighLabel;
        private System.Windows.Forms.Label saturationHighLabel;
        private System.Windows.Forms.Label hueHighLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar valueHighTrackBar;
        private System.Windows.Forms.TrackBar saturationHighTrackBar;
        private System.Windows.Forms.TrackBar hueHighTrackBar;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

