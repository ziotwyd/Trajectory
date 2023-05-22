using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trajectory
{


    public partial class MainMenu : Form
    {
        public Point mouseLocation;










        //Fields
        private Button currentButton;
        private Random random;
        private int temptIndex;
        private Form activeForm;

        //Constructor
        public MainMenu()
        {
            InitializeComponent();
        }



        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();

                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }

            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(22, 27, 32);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }








        private void button1_Click(object sender, EventArgs e)
        {
         
            ActivateButton(sender);


            pictureBox1.Visible = true;
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCREDITS_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            FormLauncher launcher = new FormLauncher() { TopLevel = false, TopMost = true };
            launcher.FormBorderStyle = FormBorderStyle.None;
            panel_FORMS.Controls.Add(launcher);
            launcher.Show();



            pictureBox1.Visible = false;
            panel_FORMS.Visible = true;





        }








        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            FormDownloads downloads = new FormDownloads() { TopLevel = false, TopMost = true };
            downloads.FormBorderStyle = FormBorderStyle.None;
            panel_FORMS.Controls.Add(downloads);
            downloads.Show();

            panel_FORMS.Visible = true;
            pictureBox1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
                this.WindowState = FormWindowState.Minimized;
        }

        private void Updates_Button_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            FormUpdates updates = new FormUpdates() { TopLevel = false, TopMost = true };
            updates.FormBorderStyle = FormBorderStyle.None;
            panelUpdates.Controls.Add(updates);
            updates.Show();

            updates.Visible = true;
            panel_FORMS.Visible = false;





        }

        private void Credits_Button_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
