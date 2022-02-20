using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GeneralForm : Form
    {
        int pagen = 1;
        string setpath;
        string shortpath = "VPN Unlimited";
        Form form2 = new FinishForm();

        void page()
        {
            if (pagen == 1)
            {
                label1.Visible = true;
                licensebox.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                pictureBox1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                checkBox1.Visible = false;
                browsingbox.Visible = false;
                browsingb.Visible = false;
                sizelabel.Visible = false;
                backb.Visible = false;
                richTextBox2.Visible = false;
                toplabel1.Text = "License Agreement";
                toplabel2.Text = "Please read the following important information before continuing.";
                label1.Text = "Please read the following License Agreement. You must accept the terms of this agreement before continuing with the installation.";
                nextb.Text = "Next";
                if (radioButton1.Checked == true) nextb.Enabled = true;
            }
            if (pagen == 2)
            {
                label1.Visible = false;
                licensebox.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                pictureBox1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                checkBox1.Visible = false;
                browsingbox.Visible = true;
                browsingb.Visible = true;
                sizelabel.Visible = true;
                backb.Visible = true;
                richTextBox2.Visible = false;
                pictureBox1.Image = Image.FromFile(@"D:\VPN keepsolid\Folder_Icon.png");
                toplabel1.Text = "Select Destination Location";
                toplabel2.Text = "Where should VPN Unlimited be installed?";
                label2.Text = "Setup will install VPN Unlimited into the following folder.";
                label3.Text = "To continue, click Next. If you would like to select a different folder, click Browse.";
                nextb.Text = "Next";
                if (setpath == null) nextb.Enabled = false;
                browsingbox.Text = setpath;
            }
            if (pagen == 3)
            {
                label1.Visible = false;
                licensebox.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                pictureBox1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                checkBox1.Visible = false;
                browsingbox.Visible = true;
                browsingb.Visible = true;
                sizelabel.Visible = false;
                backb.Visible = true;
                richTextBox2.Visible = false;
                pictureBox1.Image = Image.FromFile(@"D:\VPN keepsolid\icons8-start-menu-96.png");
                toplabel1.Text = "Select Start Menu Folder";
                toplabel2.Text = "Where shuold Setup place the program's shortcuts?";
                label2.Text = "Setup will crate the program's shortcuts in the following Start Menu folder.";
                label3.Text = "To continue, click Next. If you would like to select a different folder, click Browse.";
                nextb.Text = "Next";
                if (shortpath == null) shortpath = browsingbox.Text;
                browsingbox.Text = shortpath;
            }
            if (pagen == 4)
            {
                label1.Visible = true;
                licensebox.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                pictureBox1.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
                checkBox1.Visible = true;
                browsingbox.Visible = false;
                browsingb.Visible = false;
                sizelabel.Visible = false;
                backb.Visible = true;
                richTextBox2.Visible = false;
                toplabel1.Text = "Select Additional Tasks";
                toplabel2.Text = "Which additional tasks should be performed?";
                label1.Text = "Select the additional tasks you would like Setup to perform while installing VPN Unlimited, then click Next.";
                label3.Text = "Additional shortcuts:";
                nextb.Text = "Next";
            }
            if (pagen == 5)
            {
                label1.Visible = true;
                licensebox.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                pictureBox1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                checkBox1.Visible = false;
                browsingbox.Visible = false;
                browsingb.Visible = false;
                sizelabel.Visible = false;
                backb.Visible = true;
                richTextBox2.Visible = true;
                toplabel1.Text = "Ready to install";
                toplabel2.Text = "Setup is now ready to begin installing VPN Unlimited on your computer.";
                label1.Text = "Click Install to continue with the installation, or click Back if you want to review or change any settings.";
                nextb.Text = "Install";
                richTextBox2.Text = "Destination location:\n   " + setpath + "\n\nStart Menu folder:\n   " + shortpath;
                if (checkBox1.Enabled == true) richTextBox2.Text += "\n\nAdditional tasks:\n   Additional shortcuts:\n      Create a desktop shortcut";
            }
            if (pagen == 6)
            {
                label1.Visible = true;
                licensebox.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                pictureBox1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                checkBox1.Visible = false;
                browsingbox.Visible = false;
                browsingb.Visible = false;
                sizelabel.Visible = false;
                backb.Visible = false;
                richTextBox2.Visible = false;
                nextb.Visible = false;
                progressBar1.Visible = true;
                toplabel1.Text = "Installing";
                toplabel2.Text = "Please wait while Setup installs VPN Unlimited on your computer.";
                label1.Text = "Extracting files...";
                progress();
                this.Hide();
                form2.Show();
            }
        }

        void progress()
        {
            while (progressBar1.Value != 100)
            {
                Task.Delay(10).Wait();
                progressBar1.Value++;
            }
        }

        public GeneralForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pagen++;
            page();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nextb.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nextb.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog openFileDlg = new System.Windows.Forms.FolderBrowserDialog();
            var result = openFileDlg.ShowDialog();
            if (result.ToString() != string.Empty)
            {
                nextb.Enabled = true;
                browsingbox.Text = openFileDlg.SelectedPath;
                if (pagen == 2) setpath = openFileDlg.SelectedPath;
                if (pagen == 3) shortpath = openFileDlg.SelectedPath;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pagen--;
            page();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Setup is not complete. If you exit now, the programm will be not installed.\n\nYou may run setup at another time to complete the installiation.\n\nExit setup?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, "Exit Setup", buttons, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
