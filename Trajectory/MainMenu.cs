using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trajectory
{


    public partial class Form_MainMenu: Form
    {
        public Point mouseLocation;


       
     
            

    //Fields
    private Button currentButton;
        private Random random;
        private int temptIndex;

        //Constructor
        public Form_MainMenu()
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
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
    
              


                private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCREDITS_Click (object sender, EventArgs e)
        {
            {
                ActivateButton(sender);
            }
           


        }




    private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
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
    }
}
