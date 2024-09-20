namespace Rubik_s_Cube
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
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            button10 = new System.Windows.Forms.Button();
            button11 = new System.Windows.Forms.Button();
            button12 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(69, 12);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(50, 50);
            button1.TabIndex = 0;
            button1.Text = "^";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonUP_left_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(125, 12);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(50, 50);
            button2.TabIndex = 1;
            button2.Text = "^";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonUP_midle_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(181, 12);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(50, 50);
            button3.TabIndex = 2;
            button3.Text = "^";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonUP_right_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(69, 220);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(50, 50);
            button4.TabIndex = 3;
            button4.Text = "v";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonDOWN_left_Click;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(125, 220);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(50, 50);
            button5.TabIndex = 4;
            button5.Text = "v";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonDOWN_midle_Click;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(181, 220);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(50, 50);
            button6.TabIndex = 5;
            button6.Text = "v";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonDOWN_right_Click;
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(13, 62);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(50, 50);
            button7.TabIndex = 6;
            button7.Text = "<";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonLEFT_left_Click;
            // 
            // button8
            // 
            button8.Location = new System.Drawing.Point(13, 118);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(50, 50);
            button8.TabIndex = 7;
            button8.Text = "<";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonLEFT_midle_Click;
            // 
            // button9
            // 
            button9.Location = new System.Drawing.Point(13, 174);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(50, 50);
            button9.TabIndex = 8;
            button9.Text = "<";
            button9.UseVisualStyleBackColor = true;
            button9.Click += buttonLEFT_right_Click;
            // 
            // button10
            // 
            button10.Location = new System.Drawing.Point(237, 118);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(50, 50);
            button10.TabIndex = 9;
            button10.Text = ">";
            button10.UseVisualStyleBackColor = true;
            button10.Click += buttonRIGHT_midle_Click;
            // 
            // button11
            // 
            button11.Location = new System.Drawing.Point(237, 62);
            button11.Name = "button11";
            button11.Size = new System.Drawing.Size(50, 50);
            button11.TabIndex = 10;
            button11.Text = ">";
            button11.UseVisualStyleBackColor = true;
            button11.Click += buttonRIGHT_left_Click;
            // 
            // button12
            // 
            button12.Location = new System.Drawing.Point(237, 174);
            button12.Name = "button12";
            button12.Size = new System.Drawing.Size(50, 50);
            button12.TabIndex = 11;
            button12.Text = ">";
            button12.UseVisualStyleBackColor = true;
            button12.Click += buttonRIGHT_right_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1778, 1294);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}
