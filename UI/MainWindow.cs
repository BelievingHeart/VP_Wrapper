using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cognex.VisionPro;
using Cognex.VisionPro.ToolGroup;

namespace UI
{
    public partial class MainWindow : Form
    {
        private EditWindow _editWindow;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize resources from the MainWindow
            Resources.mainWindow = this;
            Resources.timerFlash = new Timer {Interval = 50};
        }

        private void _btnEdit_Click(object sender, EventArgs e)
        {
            _editWindow = new EditWindow();
            _editWindow.ShowDialog();
        }
    }
}
