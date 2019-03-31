using System;
using System.Threading;
using Cognex.VisionPro;
using Cognex.VisionPro.PMAlign;
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

        /// <summary>
        ///     Read trigger signal from IO card. This function only works within a while loop
        /// </summary>
        /// <param name="cardNumber">The index of current connected IO card</param>
        /// <param name="portNumber">The index of port to read from the IO card </param>
        /// <param name="triggerState">Specify the activate signal of the incoming signal</param>
        /// <param name="initialState">
        ///     Specify the initial state of of incoming signal, this param should not be modified from
        ///     outside
        /// </param>
        /// <returns>true for triggered, false for not triggered</returns>
        public static bool read_IOC0640_step(ushort cardNumber, ushort portNumber, int triggerState,
            ref int initialState)
        {
            var stateRead = IOC0640.ioc_read_inbit(cardNumber, portNumber);
            if (stateRead == initialState) return false;
            initialState = stateRead;
            return stateRead == triggerState;
        }

        public static void Listen_for_IOSignals()
        {
            Resources.TreadListen = new Thread(portNum =>
            {
                var initialState = 1;
                while (true)
                {
                    var triggered = read_IOC0640_step(0, 1, 0, ref initialState);
                    if (!triggered) continue;
                    RunResult runResult = runToolBlock_and_refreshImage();
                    updateLights(runResult);
                }
            });
        }
        
        private static void flash(RunResult result)
        {
            switch (result)
            {
                case RunResult.Missing: Resources.mainWindow.label_emptyLight.Visible = true;
                    Resources.mainWindow.label_passLight.Visible = false;
                    Resources.mainWindow.label_rejectLight.Visible = false;
                    break;
                case RunResult.OK: Resources.mainWindow.label_emptyLight.Visible = false;
                    Resources.mainWindow.label_passLight.Visible = true;
                    Resources.mainWindow.label_rejectLight.Visible = false;
                    break;
                default:
                    Resources.mainWindow.label_emptyLight.Visible = false;
                    Resources.mainWindow.label_passLight.Visible = false;
                    Resources.mainWindow.label_rejectLight.Visible = true;
                    break;
            }
        }

        /// <summary>
        ///     Show flashlight in the MainWindow to indicate the run result
        ///     1. If all passed, green light on
        ///     2. If product missing, yellow light on
        ///     3. If defects detected, red light on
        /// </summary>
        private static void updateLights(RunResult runResult)
        {
            Resources.mainWindow.Invoke(new del_flash(flash), runResult);
        }

        /// <summary>
        /// Run the "CogToolBlock1" within the EditWindow and refresh the image shown in the MainWindow
        /// </summary>
        /// <returns>NG for defects detected, Missing for no product, OK for all test passed</returns>
        private static RunResult runToolBlock_and_refreshImage()
        {
            Resources.ToolBlock.Run();

            // Refresh image in the MainWindow
            // Discard previous image in the MainWindow
            Resources.mainWindow.cogRecordDisplay1.StaticGraphics.Clear();
            Resources.mainWindow.cogRecordDisplay1.InteractiveGraphics.Clear();
            Resources.mainWindow.cogRecordDisplay1.Image = null;
            // Update image from "CogToolBlock1"
            var runRecordFromToolBlock = Resources.ToolBlock.CreateLastRunRecord();
            Resources.mainWindow.cogRecordDisplay1.Record = runRecordFromToolBlock.SubRecords["CogIPOneImageTool1.OutputImage"];
            Resources.mainWindow.cogRecordDisplay1.AutoFit = true;

            // Analysis run result
            if (Resources.ToolBlock.RunStatus.Result == CogToolResultConstants.Accept)
                return RunResult.OK;

            return ((CogPMAlignTool) Resources.ToolBlock.Tools["CogPMAlignTool1"]).Results.Count == 0 ? RunResult.Missing : RunResult.NG;
        }

        private delegate void del_flash(RunResult result);
    }
}