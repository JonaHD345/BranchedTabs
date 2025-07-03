using Microsoft.VisualStudio.Shell;
using System.ComponentModel;

namespace BranchedTabs
{
    public class TabManagerOptions : DialogPage
    {
        [Category("General")]
        [DisplayName("Enable Branch-Based Tabs")]
        [Description("When enabled, open tabs are saved and restored per Git branch.")]
        public bool EnableBranchTabs { get; set; } = true;

        [Category("Behavior")]
        [DisplayName("Restore Mode")]
        [Description("Controls how tabs are restored when switching branches.")]
        public TabRestoreMode RestoreMode { get; set; } = TabRestoreMode.RestoreOnly;
    }
}
