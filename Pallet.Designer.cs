namespace DrawApp
{
    partial class Pallet
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
            this.button3 = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.penSizeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Circle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CircleButtonClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 78);
            this.button2.TabIndex = 1;
            this.button2.Text = "Rectangle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RectButtonClicked);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(231, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 78);
            this.button3.TabIndex = 2;
            this.button3.Text = "Line";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.LineButtonClicked);
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.SystemColors.WindowText;
            this.colorButton.Location = new System.Drawing.Point(329, 38);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(32, 32);
            this.colorButton.TabIndex = 3;
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.ColorButtonClicked);
            // 
            // penSizeBox
            // 
            this.penSizeBox.Location = new System.Drawing.Point(329, 85);
            this.penSizeBox.Name = "penSizeBox";
            this.penSizeBox.Size = new System.Drawing.Size(87, 19);
            this.penSizeBox.TabIndex = 4;
            this.penSizeBox.Text = "3";
            // 
            // Pallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 133);
            this.Controls.Add(this.penSizeBox);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Pallet";
            this.Text = "Pallet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.TextBox penSizeBox;
    }
}