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
            this.blueTrackBar = new System.Windows.Forms.TrackBar();
            this.greenTrackBar = new System.Windows.Forms.TrackBar();
            this.redTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.blueLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // blueTrackBar
            // 
            this.blueTrackBar.LargeChange = 50;
            this.blueTrackBar.Location = new System.Drawing.Point(97, 258);
            this.blueTrackBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.blueTrackBar.Maximum = 255;
            this.blueTrackBar.Name = "blueTrackBar";
            this.blueTrackBar.Size = new System.Drawing.Size(165, 45);
            this.blueTrackBar.TabIndex = 1;
            this.blueTrackBar.Scroll += new System.EventHandler(this.blueTrackBar_Scroll);
            this.blueTrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blueTrackBar_MouseDown);
            // 
            // greenTrackBar
            // 
            this.greenTrackBar.Location = new System.Drawing.Point(97, 309);
            this.greenTrackBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.greenTrackBar.Maximum = 255;
            this.greenTrackBar.Name = "greenTrackBar";
            this.greenTrackBar.Size = new System.Drawing.Size(165, 45);
            this.greenTrackBar.TabIndex = 2;
            this.greenTrackBar.Scroll += new System.EventHandler(this.greenTrackBar_Scroll);
            this.greenTrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.greenTrackBar_MouseDown);
            // 
            // redTrackBar
            // 
            this.redTrackBar.Location = new System.Drawing.Point(97, 360);
            this.redTrackBar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.redTrackBar.Maximum = 255;
            this.redTrackBar.Name = "redTrackBar";
            this.redTrackBar.Size = new System.Drawing.Size(165, 45);
            this.redTrackBar.TabIndex = 3;
            this.redTrackBar.Scroll += new System.EventHandler(this.redTrackBar_Scroll);
            this.redTrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.redTrackBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 269);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Blue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 318);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 369);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Red";
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
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.Location = new System.Drawing.Point(266, 269);
            this.blueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(13, 13);
            this.blueLabel.TabIndex = 10;
            this.blueLabel.Text = "0";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.Location = new System.Drawing.Point(266, 318);
            this.greenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(13, 13);
            this.greenLabel.TabIndex = 11;
            this.greenLabel.Text = "0";
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.Location = new System.Drawing.Point(266, 369);
            this.redLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(13, 13);
            this.redLabel.TabIndex = 12;
            this.redLabel.Text = "0";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(458, 264);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 404);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.redTrackBar);
            this.Controls.Add(this.greenTrackBar);
            this.Controls.Add(this.blueTrackBar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "mainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar blueTrackBar;
        private System.Windows.Forms.TrackBar greenTrackBar;
        private System.Windows.Forms.TrackBar redTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Button saveButton;
    }
}

