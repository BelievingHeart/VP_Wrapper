using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro.ToolGroup;

namespace UI
{
    public static class Resources
    {
        public static CogToolGroup ToolGroup;
        public static CogToolBlock ToolBlock;
        public static string vppPath, passwordPath;
        public static string logged_user, logged_password;
        public static Thread treadListen;
    }
}
