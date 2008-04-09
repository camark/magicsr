using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MagicSR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                tb_Path.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lsb_SearchResult.Items.Clear();
            lv_SearchFiles.Items.Clear();

            FindArgument findArgu = new FindArgument();
            findArgu.Path = tb_Path.Text;
            findArgu.FileFilter = cbb_FileMatch.Text;
            findArgu.SearchStr = cbb_Query.Text;
            findArgu.CountListBox = lsb_SearchResult;
            findArgu.CountListView = lv_SearchFiles;

            lsb_SearchResult.Enabled = false;
            lv_SearchFiles.Enabled = false;
            bgw_Find.RunWorkerAsync(findArgu);
            
            //SearchPath(tb_Path.Text, cbb_FileMatch.Text, cbb_Query.Text,lv_SearchFiles,lsb_SearchResult);

            //if (lv_SearchFiles.Items.Count == 0)
            //    MessageBox.Show("Find Nothing");
        }

        private void SearchPath(string Path, string fileExt, string findStr,ListView lv_Result,ListBox lsb_Result)
        {
            
            string[] files=Directory.GetFiles(Path,fileExt);

            foreach (string file in files)
            {
                int findCount=0;
                if (SearchFile(file, findStr, ref findCount,lsb_Result))
                {
                    AddFileinformation(file, findCount,lv_Result);                    
                }
            }

            string[] dirs = Directory.GetDirectories(Path);
            foreach (string dir in dirs)
                SearchPath(dir, fileExt, findStr,lv_Result,lsb_Result);
        }

        private void AddFileinformation(string fileName, int findCount,ListView lv_Result)
        {
            FileInfo fi = new FileInfo(fileName);

            string fileName_short = Path.GetFileName(fileName);
            ListViewItem lvi = new ListViewItem();
            lvi.Text = fileName_short;
            lvi.SubItems.Add(fileName);
            lvi.SubItems.Add(findCount.ToString());

            lv_Result.Items.Add(lvi);
        }

        private bool SearchFile(string fileName, string findStr,ref int findCount,ListBox lsb_Result)
        {
            bgw_Find.ReportProgress(0, fileName);
            StreamReader sr = new StreamReader(fileName);

            string line;
            bool bfind = false;
            int i = 1, j = 0;
            bool bAddFileName = false;
            string line1;
            while ((line = sr.ReadLine()) != null)
            {
                if (chk_Case.Checked)
                    line1 = line.ToLower();
                else
                    line1 = line;

                if (line1.IndexOf(findStr)!=-1)
                {
                    bfind = true;
                    if (!bAddFileName)
                    {
                        lsb_Result.Items.Add(fileName);
                        bAddFileName = true;
                    }
                    lsb_Result.Items.Add("--line" + i + ":" + line);
                    j++;
                }
                i++;
            }

            findCount = j;

            return bfind;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_Path.Text = Environment.GetFolderPath(
                Environment.SpecialFolder.Personal);

            cbb_FileMatch.Text = "*.txt";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lsb_SearchResult_DrawItem(object sender, DrawItemEventArgs e)
        {           
            DrawItemState state = e.State;
            string strFind = cbb_Query.Text;

            e.DrawBackground();
            e.DrawFocusRectangle();
            string text = lsb_SearchResult.Items[e.Index].ToString();
            string[] finds = GetStringsBySplit(text, strFind);

            int left = e.Bounds.Left;
            if (finds.Length > 0)
            {
                foreach (string keyword in finds)
                {
                    if (keyword == strFind)
                    {
                        e.Graphics.DrawString(keyword, Font, new SolidBrush(Color.Blue), new PointF(left, e.Bounds.Top));
                    }
                    else
                    {
                        e.Graphics.DrawString(keyword, Font, new SolidBrush(Color.Black), new PointF(left, e.Bounds.Top));
                    }

                    int width=e.Graphics.MeasureString(keyword, Font).ToSize().Width;
                    if (width == 1)
                        width = 0;
                    left += width-e.Graphics.MeasureString("c",Font).ToSize().Width+5;
                }
            }
            else
                e.Graphics.DrawString(text, Font,new SolidBrush(Color.DeepSkyBlue), new Point(e.Bounds.Left, e.Bounds.Top));
        }

        private string[] GetStringsBySplit(string SRC, string strSplit)
        {
            List<string> strs = new List<string>();

            int pos = 0;
            pos = SRC.IndexOf(strSplit);

            if (pos == -1)
                return strs.ToArray();
            string nextStr = String.Empty;
            int iLen = 0;
            if (pos == 0)
            {
                string temp = SRC.Substring(0, strSplit.Length);
                iLen = SRC.Length - strSplit.Length;
                nextStr = SRC.Substring(strSplit.Length, iLen);
                strs.Add(temp);
            }
            else
            {
                string temp = SRC.Substring(0, pos);
                iLen = SRC.Length - pos - strSplit.Length;
                nextStr = SRC.Substring(pos + strSplit.Length, iLen);
                strs.Add(temp);
                strs.Add(strSplit);
            }


            if (nextStr.IndexOf(strSplit) != -1 && nextStr.Length > 0)
            {
                string[] nextfinds = GetStringsBySplit(nextStr, strSplit);

                foreach (string str in nextfinds)
                    strs.Add(str);
            }
            else
                strs.Add(nextStr);
            return strs.ToArray();
        }

        private void lsb_SearchResult_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 13;
        }

        private void rb_Modify_Replace_CheckedChanged(object sender, EventArgs e)
        {
            tb_SR_Replace.Enabled = !rb_Modify_None.Checked;
            lbl_TxtReplace.Enabled = !rb_Modify_None.Checked;
            btn_SR_Replace.Enabled = !rb_Modify_None.Checked;
        }

        private void btn_SR_Search_Click(object sender, EventArgs e)
        {
            lv_SR_SearchResult.Items.Clear();
            lsb_SearchResult.Items.Clear();

            SearchPath(tb_Path.Text, cbb_FileMatch.Text, tb_SR_Search.Text,lv_SR_SearchResult,lsb_SR_FileList);
        }

        private void btn_SR_Replace_Click(object sender, EventArgs e)
        {
            lsb_SR_FileList.Items.Clear();

            string txtReplace = tb_SR_Replace.Text;

            if (txtReplace.Trim().Length == 0 || lv_SR_SearchResult.Items.Count==0)
                return;

            foreach (ListViewItem item in lv_SR_SearchResult.Items)
            {
                string fileName = item.SubItems[1].Text;

                ReplaceStringInFile(fileName, tb_SR_Search.Text, tb_SR_Replace.Text);
            }

            MessageBox.Show(this, "Replace Success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ReplaceStringInFile(string FileName, string srcSrc, string strReplace)
        {
            List<string> lines = new List<string>();
            using (StreamReader sr = new StreamReader(FileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                    lines.Add(line);
            }

            List<string> DestLines = new List<string>();
            foreach (string line in lines)
            {
                string destLine = line.Replace(srcSrc, strReplace);
                DestLines.Add(destLine);
            }

            using (StreamWriter sw = new StreamWriter(FileName))
            {
                foreach (string line in DestLines)
                    sw.WriteLine(line);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            FindArgument findArgu = e.Argument as FindArgument;

            SearchPath(findArgu.Path, findArgu.FileFilter, findArgu.SearchStr, findArgu.CountListView, findArgu.CountListBox);
            e.Result = "Succed";

            tssStatus.Text = "Find,Please Waiting....";
        }

        private void bgw_Find_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string Msg = e.UserState as string;
            tssStatus.Text = Msg;
        }

        private void bgw_Find_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Result=="Succed")
                tssStatus.Text = "Find finished";

            if (e.Cancelled)
                tssStatus.Text = "Cancelled";

            lsb_SearchResult.Enabled = true;
            lv_SearchFiles.Enabled = true;

            toolStripStatusLabel1.Text = "Find " + lv_SearchFiles.Items.Count + " Files";
        }

        private void btn_CancelFind_Click(object sender, EventArgs e)
        {
            if(bgw_Find.CancellationPending)
                bgw_Find.CancelAsync();
        }
    }
}