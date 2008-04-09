using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MagicSR
{
    class FindArgument
    {
        private string _Path;

        public string Path
        {
            get { return _Path; }
            set { _Path = value; }
        }

        private string _fileFilter;

        public string FileFilter
        {
            get { return _fileFilter; }
            set { _fileFilter = value; }
        }

        private string _searchStr;

        public string SearchStr
        {
            get { return _searchStr; }
            set { _searchStr = value; }
        }

        private ListView _CountListView;

        public ListView CountListView
        {
            get { return _CountListView; }
            set { _CountListView = value; }
        }

        private ListBox _countListBox;

        public ListBox CountListBox
        {
            get { return _countListBox; }
            set { _countListBox = value; }
        }
    }
}
