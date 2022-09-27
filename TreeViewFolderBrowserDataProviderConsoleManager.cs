using Raccoom.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_manager
{
    class TreeViewFolderBrowserDataProviderConsoleManager : TreeStrategyFolderBrowserProvider
    {
        private string _RootFolderConsoleManager;

        public string RootFolderConsoleManager
        {
            get { return _RootFolderConsoleManager; }
            set { _RootFolderConsoleManager = value; }
        }

        public override void RequestRootNode()
        {
            if (!string.IsNullOrEmpty(_RootFolderConsoleManager))
            {
                AttachSystemImageList(Helper);
                // create root node with specified folder
                this.CreateTreeNode(null, System.IO.Path.GetFileName(_RootFolderConsoleManager), _RootFolderConsoleManager, false, true, false);
            }
        }
    }
}
