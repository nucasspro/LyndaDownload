using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace MainForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Load();
        }

        private IContainer components = null;

        //private Button button1;
        //private Button button2;
        //private Button buttondeldumpfile;

        //private FolderBrowserDialog folderBrowserDialog1;
        //private Label label1;
        //private Label label2;
        //private Label label3;
        //private LinkLabel linkLabel1;
        //private ListBox listBox1;
        //private RichTextBox richTextBoxResult;
        //private TabControl tabControl1;
        //private TabPage tabPage1;
        //private TabPage tabPage3;
        //private TextBox textBoxoptionx;
        //private TextBox textBoxOutput;
        //private TextBox textLink;



        //private void Button2Click(object sender, EventArgs e)
        //{
        //    Environment.GetFolderPath(Environment.SpecialFolder.System);
        //    this.folderBrowserDialog1.SelectedPath = Directory.GetCurrentDirectory();

        //    if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        string selectedPath = this.folderBrowserDialog1.SelectedPath;
        //        this.textBoxOutput.Text = selectedPath;
        //    }
        //}

        private void ButtondeldumpfileClick(object sender, EventArgs e)
        {
            string[] strArray = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.*", SearchOption.AllDirectories);
            foreach (string str2 in strArray)
            {
                if (str2.Contains("dump"))
                {
                    File.Delete(str2);
                }
            }
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (this.components != null))
        //    {
        //        this.components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}


        //Định dạng giao diện
        private new void Load()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form1));
            //this.textLink = new TextBox();
            this.textLink.Location = new Point(6, 0x18);
            this.textLink.Name = "textLink";
            this.textLink.Size = new Size(0x211, 20);
            this.textLink.TabIndex = 0;

            //this.label1 = new Label();
            //this.label1.Location = new Point(5, 4);
            //this.label1.Name = "label1";
            //this.label1.Size = new Size(100, 0x11);
            //this.label1.TabIndex = 1;
            //this.label1.Text = "youtube link";

            //this.richTextBoxResult = new RichTextBox();
            this.richTextBoxResult.Location = new Point(0x232, 0x18);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new Size(410, 0x196);
            this.richTextBoxResult.TabIndex = 2;
            this.richTextBoxResult.Text = "";

            //this.button1 = new Button();
            this.button1.Location = new Point(7, 0xae);
            this.button1.Name = "button1";
            this.button1.Size = new Size(240, 0x17);
            this.button1.TabIndex = 3;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;

            //this.tabControl1 = new TabControl();
            //this.tabControl1.SuspendLayout();
            //this.tabControl1.Controls.Add(this.tabPage1);
            //this.tabControl1.Controls.Add(this.tabPage3);
            //this.tabControl1.Location = new Point(0x16, 12);
            //this.tabControl1.Name = "tabControl1";
            //this.tabControl1.SelectedIndex = 0;
            //this.tabControl1.Size = new Size(0x3da, 0x1c1);
            //this.tabControl1.TabIndex = 4;

            //this.tabPage1 = new TabPage();
            //this.tabPage1.SuspendLayout();
            //this.tabPage1.Controls.Add(this.buttondeldumpfile);
            //this.tabPage1.Controls.Add(this.label3);
            //this.tabPage1.Controls.Add(this.textBoxoptionx);
            //this.tabPage1.Controls.Add(this.button2);
            //this.tabPage1.Controls.Add(this.textBoxOutput);
            //this.tabPage1.Controls.Add(this.label2);
            //this.tabPage1.Controls.Add(this.richTextBoxResult);
            //this.tabPage1.Controls.Add(this.button1);
            //this.tabPage1.Controls.Add(this.textLink);
            //this.tabPage1.Controls.Add(this.label1);
            //this.tabPage1.Location = new Point(4, 0x16);
            //this.tabPage1.Name = "tabPage1";
            //this.tabPage1.Padding = new Padding(3);
            //this.tabPage1.Size = new Size(0x3d2, 0x1a7);
            //this.tabPage1.TabIndex = 0;
            //this.tabPage1.Text = "youtube-dl downloader";
            //this.tabPage1.UseVisualStyleBackColor = true;

            //this.buttondeldumpfile = new Button();
            //this.buttondeldumpfile.Location = new Point(0x126, 0xae);
            //this.buttondeldumpfile.Name = "buttondeldumpfile";
            //this.buttondeldumpfile.Size = new Size(0xf1, 0x17);
            //this.buttondeldumpfile.TabIndex = 9;
            //this.buttondeldumpfile.Text = "Delete dump files";
            //this.buttondeldumpfile.UseVisualStyleBackColor = true;
            //this.buttondeldumpfile.Click += new EventHandler(this.ButtondeldumpfileClick);

            //this.label3 = new Label();
            //this.label3.Location = new Point(7, 0x33);
            //this.label3.Name = "label3";
            //this.label3.Size = new Size(100, 0x11);
            //this.label3.TabIndex = 8;
            //this.label3.Text = "Options add";

            //this.textBoxoptionx = new TextBox();
            this.textBoxoptionx.Location = new Point(7, 0x47);
            this.textBoxoptionx.Name = "textBoxoptionx";
            this.textBoxoptionx.Size = new Size(0x210, 20);
            this.textBoxoptionx.TabIndex = 7;
            this.textBoxoptionx.Text = "--autonumber-start 0";

            //this.button2 = new Button();
            //this.button2.Location = new Point(430, 0x94);
            //this.button2.Name = "button2";
            //this.button2.Size = new Size(0x69, 0x17);
            //this.button2.TabIndex = 6;
            //this.button2.Text = "Browser ..";
            //this.button2.UseVisualStyleBackColor = true;
            //this.button2.Click += new EventHandler(this.Button2Click);

            //this.textBoxOutput = new TextBox();
            this.textBoxOutput.Location = new Point(7, 0x94);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new Size(0x1a1, 20);
            this.textBoxOutput.TabIndex = 4;

            //this.label2 = new Label();
            //this.label2.Location = new Point(6, 0x80);
            //this.label2.Name = "label2";
            //this.label2.Size = new Size(100, 0x11);
            //this.label2.TabIndex = 5;
            //this.label2.Text = "Output";

            //this.tabPage3 = new TabPage();
            //this.tabPage3.Controls.Add(this.listBox1);
            //this.tabPage3.Location = new Point(4, 0x16);
            //this.tabPage3.Name = "tabPage3";
            //this.tabPage3.Padding = new Padding(3);
            //this.tabPage3.Size = new Size(0x3d2, 0x1a7);
            //this.tabPage3.TabIndex = 2;
            //this.tabPage3.Text = "About";
            //this.tabPage3.UseVisualStyleBackColor = true;
            //this.tabPage3.SuspendLayout();

            //this.listBox1 = new ListBox();
            //this.listBox1.FormattingEnabled = true;
            //this.listBox1.Items.AddRange(new object[] { "Base on Udemy.com, Youtube-dl, Chrome cookies.txt(cung cấp bởi shaney.net) and SharpDevelop", "", "Skype/FB: karlmc15", "Website: http://netADX.com" });
            //this.listBox1.Location = new Point(0x13, 0x11);
            //this.listBox1.Name = "listBox1";
            //this.listBox1.Size = new Size(0x3b9, 0x156);
            //this.listBox1.TabIndex = 0;

            //this.linkLabel1 = new LinkLabel();
            //this.linkLabel1.Location = new Point(12, 0x1d0);
            //this.linkLabel1.Name = "linkLabel1";
            //this.linkLabel1.Size = new Size(100, 0x17);
            //this.linkLabel1.TabIndex = 5;
            //this.linkLabel1.TabStop = true;
            //this.linkLabel1.Text = "netADX.com";
            //this.linkLabel1.TextAlign = ContentAlignment.BottomCenter;

            //this.folderBrowserDialog1 = new FolderBrowserDialog();

            //base.SuspendLayout();

            //this.folderBrowserDialog1.RootFolder = Environment.SpecialFolder.DesktopDirectory;
            //base.AutoScaleDimensions = new SizeF(6f, 13f);
            //base.AutoScaleMode = AutoScaleMode.Font;
            //base.ClientSize = new Size(0x3f2, 0x1e6);
            //base.Controls.Add(this.linkLabel1);
            //base.Controls.Add(this.tabControl1);
            //base.Icon = (Icon)manager.GetObject("$this.Icon");
            //base.Name = "MainForm";
            //this.Text = "Youtube downloader - Make with love by Skype: karlmc15";
            base.Load += new EventHandler(this.MainFormLoad);
            //this.tabControl1.ResumeLayout(false);
            //this.tabPage1.ResumeLayout(false);
            //this.tabPage1.PerformLayout();
            //this.tabPage3.ResumeLayout(false);
            base.ResumeLayout(false);
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            string text = "";
            string str2 = this.textBoxoptionx.Text;
            this.richTextBoxResult.Text = "";
            string str3 = this.textBoxOutput.Text;
            //string youtube_dl = @"D:\C#\LyndaDownload\MainForm\MainForm\bin\Debug\youtube-dl";
            //string cookie = @"D:\C#\LyndaDownload\MainForm\MainForm\bin\Debug\cookies.txt";
            //string arguments = "/c " + youtube_dl + " --output \"" + str3 + "/%(autonumber)s-%(title)s.%(ext)s\" --write-pages " + str2 + " --cookies " + cookie + " --all-subs --verbose  --print-traffic --dump-pages " + text;

            for (int i = 0; i< listBox2.Items.Count; i++)
            {
                text = listBox2.Items[i].ToString();
                
                string arguments = "/c youtube-dl --output \"" + str3 + "/%(autonumber)s-%(title)s.%(ext)s\" --write-pages " + str2 + " --cookies cookies.txt --all-subs --verbose  --print-traffic --dump-pages " + text;
                DownLoad(arguments);
            }
            MessageBox.Show("Complete!");
        }

        private void DownLoad(string command)
        {
            this.richTextBoxResult.Text = "CMD:" + command;

            ProcessStartInfo info = new ProcessStartInfo("cmd", command)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = new Process
            {
                StartInfo = info
            };

            process.Start();

            while (!process.StandardOutput.EndOfStream)
            {
                string str5 = process.StandardOutput.ReadLine();
                this.richTextBoxResult.Text = str5 + Environment.NewLine + this.richTextBoxResult.Text;
            }
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            this.textBoxOutput.Text = Directory.GetCurrentDirectory();
        }
    }
}

