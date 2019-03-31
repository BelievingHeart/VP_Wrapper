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
        public static Thread ThreadListen;
        public static MainWindow mainWindow;
        public const ushort OK_port = 10, NG_port = 11, Empty_port = 12, inSignal_port = 1;
        public const ushort cardIndex = 0;
        public const int startSignal = 0, endSignal = 1;
        public const int signalWidth = 100;
        public static bool loggedIn = false;
        public const string password = "world", user = "hello";
    }
}
