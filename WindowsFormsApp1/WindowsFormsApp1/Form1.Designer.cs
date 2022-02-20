namespace WindowsFormsApp1
{
    partial class GeneralForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            this.toplabel2 = new System.Windows.Forms.Label();
            this.toplabel1 = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.nextb = new System.Windows.Forms.Button();
            this.cancelb = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.licensebox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browsingb = new System.Windows.Forms.Button();
            this.browsingbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sizelabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.backb = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toplabel2
            // 
            this.toplabel2.Location = new System.Drawing.Point(40, 27);
            this.toplabel2.Name = "toplabel2";
            this.toplabel2.Size = new System.Drawing.Size(382, 16);
            this.toplabel2.TabIndex = 1;
            this.toplabel2.Text = "Please read the following important information before continuing.";
            this.toplabel2.Click += new System.EventHandler(this.label2_Click);
            // 
            // toplabel1
            // 
            this.toplabel1.AutoSize = true;
            this.toplabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toplabel1.Location = new System.Drawing.Point(25, 11);
            this.toplabel1.Name = "toplabel1";
            this.toplabel1.Size = new System.Drawing.Size(106, 14);
            this.toplabel1.TabIndex = 1;
            this.toplabel1.Text = "License Agreement";
            this.toplabel1.Click += new System.EventHandler(this.label3_Click);
            // 
            // icon
            // 
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(434, -1);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(57, 53);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 2;
            this.icon.TabStop = false;
            this.icon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nextb
            // 
            this.nextb.Enabled = false;
            this.nextb.Location = new System.Drawing.Point(320, 325);
            this.nextb.Name = "nextb";
            this.nextb.Size = new System.Drawing.Size(75, 23);
            this.nextb.TabIndex = 9;
            this.nextb.Text = "Next";
            this.nextb.UseVisualStyleBackColor = true;
            this.nextb.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelb
            // 
            this.cancelb.Location = new System.Drawing.Point(407, 325);
            this.cancelb.Name = "cancelb";
            this.cancelb.Size = new System.Drawing.Size(75, 23);
            this.cancelb.TabIndex = 10;
            this.cancelb.Text = "Cancel";
            this.cancelb.UseVisualStyleBackColor = true;
            this.cancelb.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(43, 282);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(168, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "I do not accept the agreement";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton1.Location = new System.Drawing.Point(43, 262);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(135, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.Text = "I accept the agreement";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // licensebox
            // 
            this.licensebox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.licensebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.licensebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.licensebox.Location = new System.Drawing.Point(43, 99);
            this.licensebox.Name = "licensebox";
            this.licensebox.ReadOnly = true;
            this.licensebox.Size = new System.Drawing.Size(412, 155);
            this.licensebox.TabIndex = 13;
            this.licensebox.Text = resources.GetString("licensebox.Text");
            this.licensebox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(40, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Please read the following License Agreement. You must accept the terms of this ag" +
    "reement before continuing with the installation.";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // browsingb
            // 
            this.browsingb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.browsingb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.browsingb.Location = new System.Drawing.Point(396, 70);
            this.browsingb.Name = "browsingb";
            this.browsingb.Size = new System.Drawing.Size(75, 23);
            this.browsingb.TabIndex = 20;
            this.browsingb.Text = "Browse...";
            this.browsingb.UseVisualStyleBackColor = false;
            this.browsingb.Visible = false;
            this.browsingb.Click += new System.EventHandler(this.button3_Click);
            // 
            // browsingbox
            // 
            this.browsingbox.Location = new System.Drawing.Point(43, 128);
            this.browsingbox.Name = "browsingbox";
            this.browsingbox.Size = new System.Drawing.Size(334, 20);
            this.browsingbox.TabIndex = 19;
            this.browsingbox.Visible = false;
            this.browsingbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(96, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Setup will install VPN Unlimited into the following folder.";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(40, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "To continue, click Next. If you would like to select a different folder, click Br" +
    "owse.";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label5_Click);
            // 
            // sizelabel
            // 
            this.sizelabel.AutoSize = true;
            this.sizelabel.BackColor = System.Drawing.SystemColors.Control;
            this.sizelabel.Location = new System.Drawing.Point(41, 287);
            this.sizelabel.Name = "sizelabel";
            this.sizelabel.Size = new System.Drawing.Size(232, 13);
            this.sizelabel.TabIndex = 21;
            this.sizelabel.Text = "At least 173,6 MB of free disk space is required.";
            this.sizelabel.Visible = false;
            this.sizelabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(43, 119);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Create a desktop shortcut";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // backb
            // 
            this.backb.Location = new System.Drawing.Point(242, 325);
            this.backb.Name = "backb";
            this.backb.Size = new System.Drawing.Size(75, 23);
            this.backb.TabIndex = 24;
            this.backb.Text = "Back";
            this.backb.UseVisualStyleBackColor = true;
            this.backb.Visible = false;
            this.backb.Click += new System.EventHandler(this.button4_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox2.Location = new System.Drawing.Point(43, 100);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox2.Size = new System.Drawing.Size(412, 199);
            this.richTextBox2.TabIndex = 25;
            this.richTextBox2.Text = "";
            this.richTextBox2.Visible = false;
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "VPN Unlimited";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(43, 99);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(407, 23);
            this.progressBar1.TabIndex = 26;
            this.progressBar1.Visible = false;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.browsingb);
            this.panel1.Location = new System.Drawing.Point(-7, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 258);
            this.panel1.TabIndex = 27;
            // 
            // GeneralForm
            // 
            this.AcceptButton = this.nextb;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.backb;
            this.ClientSize = new System.Drawing.Size(494, 356);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.backb);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.sizelabel);
            this.Controls.Add(this.browsingbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.licensebox);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelb);
            this.Controls.Add(this.nextb);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.toplabel1);
            this.Controls.Add(this.toplabel2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup - VPN Unlimited";
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label toplabel2;
        private System.Windows.Forms.Label toplabel1;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Button nextb;
        private System.Windows.Forms.Button cancelb;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RichTextBox licensebox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox browsingbox;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label sizelabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button backb;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button browsingb;
        private System.Windows.Forms.Panel panel1;
    }
}

