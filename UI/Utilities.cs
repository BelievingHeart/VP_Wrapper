using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro.ToolGroup;

namespace UI
{
    public static class Utilities
    {
        // Load the vpp file of a CogBlockTool 
        public static void load_vpp(string vppPath)
        {
            // Resources.ToolGroup == null if not load successfully
            Resources.ToolGroup = CogSerializer.LoadObjectFromFile(vppPath) as CogToolGroup;
            // If load vpp file successful
            if (Resources.ToolGroup != null)
            {
                // If a CogToolBlock is already defined in Resources.ToolGroup
                if (Resources.ToolGroup.Tools.Count > 0)
                {
                    Resources.ToolBlock = Resources.ToolGroup.Tools[0] as CogToolBlock;
                }
                // else create a new toolBlock and let Resources.ToolBlock refer to it
                else
                {
                    Resources.ToolGroup.Tools.Add(new CogToolBlock());
                    Resources.ToolBlock = Resources.ToolGroup.Tools[0] as CogToolBlock;
                }
            }
            // If load vpp file fails, create a new CogToolGroup as well as the CogBlockTool within
            else
            {
                Resources.ToolGroup = new CogToolGroup();
                Resources.ToolGroup.Tools.Add(new CogToolBlock());
                Resources.ToolBlock = Resources.ToolGroup.Tools[0] as CogToolBlock;
            }
          
        }

        private static void Listen_for_IOSignals_impl()
        {
            
        }

        public static void Listen_for_IOSignals()
        {
            Resources.treadListen = new Thread(portNum =>
            {
                // TODO: finish IO api and complete this
            });
        }
    }
}