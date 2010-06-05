using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DersDemo_Win_UserControls.Properties;

namespace DersDemo_Win_UserControls
{
    public class DirectoryTreeView : TreeView
    {
        public DirectoryTreeView()
            : base()
        {
            il = new ImageList();
            il.Images.Add(Resources.dir1616);
            il.Images.Add(Resources.fil1616);
            ImageList = il;
        }

        protected ImageList il;

        public string _startDirectory;

        public string StartDirectory
        {
            get { return _startDirectory; }
            set
            {
                _startDirectory = value;
                DataBind();
            }
        }

        protected void DataBind()
        {
            this.Nodes.Clear();
            this.Nodes.Add(
                GetDirectory(
                    new DirectoryInfo(_startDirectory)));
        }

        private TreeNode GetDirectory(DirectoryInfo di)
        {
            if (di != null && di.Exists)
            {
                TreeNode tn = new TreeNode(di.Name)
                {
                    Tag = di,
                    ImageIndex = 0
                };

                DirectoryInfo[] did = di.GetDirectories();

                if (did != null && did.Length > 0)
                {
                    foreach (var item in did)
                    {
                        tn.Nodes.Add(GetDirectory(item));
                    }
                }

                FileInfo[] fid = di.GetFiles();
                if (fid != null && fid.Length > 0)
                {
                    foreach (var item in fid)
                    {
                        tn.Nodes.Add(
                            new TreeNode(item.Name)
                            {
                                Tag = item,
                                ImageIndex = 1
                            });
                    }
                }
                return tn;
            }
            return null;
        }

    }
}
