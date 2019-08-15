using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckMeOut
{
    public partial class Form1 : Form
    {
        public List<FileHashInfo> fileHashes = new List<FileHashInfo>();
        public static Dictionary<string, string> md5Hashes = new Dictionary<string, string>();
        public static Dictionary<string, string> sha1Hashes = new Dictionary<string, string>();

        string[] files = null;

        DataGridViewCellStyle goodStyle = new DataGridViewCellStyle()
        {
            BackColor = Color.GreenYellow
        };

        DataGridViewCellStyle badStyle = new DataGridViewCellStyle()
        {
            BackColor = Color.Orange
        };

        Font panelInactiveFont = null;
        Font panelActiveFont = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);

        public Form1()
        {
            InitializeComponent();
            panel1.AllowDrop = true;
            md5Box.AllowDrop = true;
            panelInactiveFont = dragLbl.Font;

            md5Box.DragEnter += md5_DragEnter;
            md5Box.DragDrop += md5_DragDrop;

            dGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private string GetMD5Hash(byte[] file)
        {
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(file);

            return ToHexString(hash);
        }

        private string GetSHA1Hash(byte[] file)
        {
            SHA1 sha1 = SHA1.Create();
            byte[] hash = sha1.ComputeHash(file);

            return ToHexString(hash);
        }

        private string ToHexString(byte[] hash)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString().ToLower();
        }

        private void RefreshDataGrid(bool clearGrid = false)
        {
            List<FileHashInfo> sortedHashes = new List<FileHashInfo>();

            dGrid.Invoke(new Action(
                () =>
                {
                    if(clearGrid)
                        dGrid.Rows.Clear();

                    if (allRdo.Checked)
                        sortedHashes = fileHashes.OrderBy(i => i.filename).ToList();
                    else if (validRdo.Checked)
                        sortedHashes = fileHashes.Where(i => i.foundHash).ToList<FileHashInfo>().OrderBy(i => i.filename).ToList();
                    else
                        sortedHashes = fileHashes.Where(i => !i.foundHash).ToList<FileHashInfo>().OrderBy(i => i.filename).ToList();

                    foreach (FileHashInfo filehash in sortedHashes)
                    {
                        dGrid.Rows.Add(filehash.filename, filehash.foundHash, filehash.filepath, filehash.md5, filehash.sha1);

                        var row = dGrid.Rows[dGrid.Rows.GetRowCount(DataGridViewElementStates.None) - 1];
                        var md5Cell = row.Cells[3];
                        var sha1Cell = row.Cells[4];

                        if (filehash.md5Found)
                            md5Cell.Style = goodStyle;
                        else
                            md5Cell.Style = badStyle;

                        if (filehash.sha1Found)
                            sha1Cell.Style = goodStyle;
                        else
                            sha1Cell.Style = badStyle;
                    }
                }
            )
            );

            //if (allRdo.Checked)
            //    sortedHashes = fileHashes.OrderBy(i=>i.filename).ToList();
            //else if (validRdo.Checked)
            //    sortedHashes = fileHashes.Where(i => i.foundHash).ToList<FileHashInfo>().OrderBy(i => i.filename).ToList();
            //else
            //    sortedHashes = fileHashes.Where(i => !i.foundHash).ToList<FileHashInfo>().OrderBy(i => i.filename).ToList();

            //foreach (FileHashInfo filehash in sortedHashes)
            //{
            //    dGrid.Rows.Add(filehash.filename, filehash.foundHash, filehash.filepath, filehash.md5, filehash.sha1);

            //    var row = dGrid.Rows[dGrid.Rows.GetRowCount(DataGridViewElementStates.None) - 1];
            //    var md5Cell = row.Cells[3];
            //    var sha1Cell = row.Cells[4];

            //    if (filehash.md5Found)
            //        md5Cell.Style = goodStyle;
            //    else
            //        md5Cell.Style = badStyle;

            //    if (filehash.sha1Found)
            //        sha1Cell.Style = goodStyle;
            //    else
            //        sha1Cell.Style = badStyle;
            //}
        }

        private void md5Box_TextChanged(object sender, EventArgs e)
        {
            md5Hashes.Clear();

            foreach (string hash in md5Box.Text.Trim().Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None))
            {
                md5Hashes[hash] = null;
            }
        }

        private void sha1Box_TextChanged(object sender, EventArgs e)
        {
            sha1Hashes.Clear();

            foreach (string hash in sha1Box.Text.Trim().Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None))
            {
                sha1Hashes[hash] = null;
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            panel1.BackColor = Color.AliceBlue;
            dragLbl.Font = panelActiveFont;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            panel1.BackColor = Color.WhiteSmoke;
            dragLbl.Font = panelInactiveFont;

            fileHashes.Clear();

            files = (string[])e.Data.GetData(DataFormats.FileDrop);

            //foreach (string file in files)
            //{
            //    byte[] data = File.ReadAllBytes(file);

            //    var filehash = new FileHashInfo
            //    {
            //        filename = file.Split('\\')[file.Split('\\').Length - 1],
            //        filepath = file,
            //        md5 = GetMD5Hash(data),
            //        sha1 = GetSHA1Hash(data)
            //    };

            //    fileHashes.Add(filehash);
            //}

            //RefreshDataGrid();

            backgroundWorker1.RunWorkerAsync();
        }

        private void panel1_DragLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.WhiteSmoke;
            dragLbl.Font = panelInactiveFont;
        }

        private void md5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;

        }

        private void md5_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string[] md5s = (string[]) files.Where(i => i.Split('.')[i.Split('.').Length - 1] == "md5").ToArray<string>();

            foreach(string md5 in md5s)
            {
                md5Box.Text += File.ReadAllText(md5).Split(' ')[0] + "\r\n";
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            fileHashes.Clear();
            dGrid.Rows.Clear();
        }

        private void clearMD5_Click(object sender, EventArgs e)
        {
            md5Box.Text = string.Empty;
        }

        private void clearSHA1_Click(object sender, EventArgs e)
        {
            sha1Box.Text = string.Empty;
        }

        private void allRdo_CheckedChanged(object sender, EventArgs e)
        {
            if (allRdo.Checked)
            {
                RefreshDataGrid(true);
            }
        }

        private void validRdo_CheckedChanged(object sender, EventArgs e)
        {
            if (validRdo.Checked)
            {
                RefreshDataGrid(true);
            }
        }

        private void invalidRdo_CheckedChanged(object sender, EventArgs e)
        {
            if (invalidRdo.Checked)
            {
                RefreshDataGrid(true);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            progressBar.Invoke(new Action(
            () =>
            {
                progressBar.Maximum = files.Length;
            }
            )
            );

            for (int i = 0; i < files.Length; i++)
            {
                backgroundWorker1.ReportProgress(i + 1);

                string file = files[i];

                byte[] data = File.ReadAllBytes(file);

                var filehash = new FileHashInfo
                {
                    filename = file.Split('\\')[file.Split('\\').Length - 1],
                    filepath = file,
                    md5 = GetMD5Hash(data),
                    sha1 = GetSHA1Hash(data)
                };

                fileHashes.Add(filehash);
            }

            RefreshDataGrid(true);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Invoke(new Action(
            () =>
            {
                progressBar.Value = e.ProgressPercentage;
            }
            )
            );
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Invoke(new Action(
            () =>
            {
                progressBar.Value = 0;
            }
            )
            );
        }
    }
}
