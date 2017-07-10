namespace MainForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;

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
            this.textLink = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.textBoxoptionx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textLink
            // 
            this.textLink.AllowDrop = true;
            this.textLink.Location = new System.Drawing.Point(12, 12);
            this.textLink.Multiline = true;
            this.textLink.Name = "textLink";
            this.textLink.Size = new System.Drawing.Size(475, 53);
            this.textLink.TabIndex = 0;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(12, 277);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(475, 20);
            this.textBoxOutput.TabIndex = 1;
            this.textBoxOutput.Text = "E:\\Phan mem\\karlmc15-share-master\\karlmc15-share-master\\Lynda-downloader";
            // 
            // textBoxoptionx
            // 
            this.textBoxoptionx.Location = new System.Drawing.Point(12, 211);
            this.textBoxoptionx.Name = "textBoxoptionx";
            this.textBoxoptionx.Size = new System.Drawing.Size(475, 20);
            this.textBoxoptionx.TabIndex = 2;
            this.textBoxoptionx.Text = "--autonumber-start 0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(493, 12);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(530, 372);
            this.richTextBoxResult.TabIndex = 4;
            this.richTextBoxResult.Text = "";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "https://www.lynda.com/Blender-tutorials/Welcome/365285/383735-4.html",
            "https://www.lynda.com/Blender-tutorials/Using-exercise-files/365285/383736-4.html" +
                "",
            "https://www.lynda.com/Blender-tutorials/Importing-mesh-setup-scene-environment/36" +
                "5285/383738-4.html",
            "https://www.lynda.com/Blender-tutorials/Creating-root-spine-bones/365285/383739-4" +
                ".html",
            "https://www.lynda.com/Blender-tutorials/Creating-neck-head-leg-bones/365285/38374" +
                "0-4.html",
            "https://www.lynda.com/Blender-tutorials/Creating-leg-IK-inverse-kinematics/365285" +
                "/383741-4.html",
            "https://www.lynda.com/Blender-tutorials/Creating-foot-bones/365285/383743-4.html",
            "https://www.lynda.com/Blender-tutorials/Creating-foot-IK-bones/365285/383744-4.ht" +
                "ml",
            "https://www.lynda.com/Blender-tutorials/Creating-arm-hand-bones/365285/383746-4.h" +
                "tml",
            "https://www.lynda.com/Blender-tutorials/Creating-arm-IK-bones/365285/383747-4.htm" +
                "l",
            "https://www.lynda.com/Blender-tutorials/Creating-controller-shapes-assigning-them" +
                "-bones/365285/383749-4.html",
            "https://www.lynda.com/Blender-tutorials/Modifying-rotation-position-scale-control" +
                "ler-shapes/365285/383750-4.html",
            "https://www.lynda.com/Blender-tutorials/Creating-custom-controller-shapes/365285/" +
                "383751-4.html",
            "https://www.lynda.com/Blender-tutorials/Creating-custom-controller-shapes-foot/36" +
                "5285/383752-4.html",
            "https://www.lynda.com/Blender-tutorials/Duplicating-left-arm-leg-bones-right-side" +
                "-body/365285/383753-4.html",
            "https://www.lynda.com/Blender-tutorials/Initial-weighting-mesh-bones/365285/38375" +
                "5-4.html",
            "https://www.lynda.com/Blender-tutorials/Adjusting-weight-painting-mesh-bones/3652" +
                "85/383756-4.html",
            "https://www.lynda.com/Blender-tutorials/Goodbye/365285/383758-4.html"});
            this.listBox2.Location = new System.Drawing.Point(24, 98);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(463, 56);
            this.listBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 396);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxoptionx);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textLink);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLink;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.TextBox textBoxoptionx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.ListBox listBox2;
    }
}

