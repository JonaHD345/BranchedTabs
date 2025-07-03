namespace BranchedTabs
{
    public enum TabRestoreMode
    {
        RestoreOnly,              // Just open saved tabs, don't close any
        ReplaceAndKeepUnsaved,    // Close all except unsaved, then open saved
        ReplaceAllAndSaveUnsaved  // Save all, close all, then open saved
    }
}
