using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cognex.VisionPro.ToolGroup;

namespace UI
{
    public class Resources
    {
        public static CogToolGroup ToolGroup;

        public Resources()
        {
            ToolGroup = new CogToolGroup();
        }
    }
}
