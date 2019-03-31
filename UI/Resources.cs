using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Cognex.VisionPro;
using Cognex.VisionPro.Display;
using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro.ToolGroup;
using Timer = System.Windows.Forms.Timer;

namespace UI
{
    public static class Resources
    {
        public static CogToolGroup ToolGroup;
        public static CogToolBlock ToolBlock;
        public static string VppPath, PasswordPath;
        public static string LoggedUser, LoggedPassword;
        public static Thread TreadListen;
        public static MainWindow mainWindow;
    }
}
