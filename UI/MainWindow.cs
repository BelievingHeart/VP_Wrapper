﻿using System;
using System.Windows.Forms;

namespace UI
{
    public partial class MainWindow : Form
    {
        private EditWindow _editWindow;
        private bool OK_lightOn = true, NG_lightOn = true, Missing_lightOn = true;

        public MainWindow()
        {
            InitializeComponent();
            timerFlash.Tick += flash_Missing;
            timerFlash.Tick += flash_NG;
            timerFlash.Tick += flash_OK;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize resources from the MainWindow
            Resources.mainWindow = this;
            // Load vpp file
            Utilities.load_vpp(Resources.VppPath);
            // Init the IO card and begin listening in a background thread
            try
            {
                int initSuccess = IOC0640.ioc_board_init();
                textBox_message.AppendText(initSuccess>0? "IO card init succeeded!\n\r":"IO card init failed!\n\r");
            }
            catch (Exception exception)
            {
                textBox_message.AppendText("IO card init failed: " + exception.Message + "\n\r");
            }
            Utilities.Listen_for_IOSignals_async();
        }
        private void _btnEdit_Click(object sender, EventArgs e)
        {
            if (Resources.loggedIn)
            {
                _editWindow = new EditWindow();
                _editWindow.ShowDialog();
            }
            else
            {
                panel_login.Visible = true;
            }
        }

        // The following 3 functions handle timerFlash.Tick
        private void flash_OK(object sender, EventArgs e)
        {
            OK_lightOn = !OK_lightOn;
            label_passLight.Text = OK_lightOn ? "●" : " ";
        }
        private void flash_NG(object sender, EventArgs e)
        {
            NG_lightOn = !NG_lightOn;
            label_rejectLight.Text = NG_lightOn ? "●" : " ";
        }
        private void flash_Missing(object sender, EventArgs e)
        {
            Missing_lightOn = !Missing_lightOn;
            label_emptyLight.Text = Missing_lightOn ? "●" : " ";
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            Resources.loggedIn = string.Equals(textBox_user.Text, Resources.user, StringComparison.Ordinal) &&
                                 string.Equals(textBox_password.Text, Resources.password,
                                     StringComparison.Ordinal);
            if (!Resources.loggedIn)
                MessageBox.Show("Username or password invalid");
            else
                panel_login.Visible = false;
        }
    }
}