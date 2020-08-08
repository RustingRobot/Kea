using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kea
{
    public partial class Main : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public List<string> chapterLinks, chapterNames;
        public List<string[]> ToonChapters, ToonChapterNames;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Main()
        {
            InitializeComponent();
            QueueGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        }

        private void HandleBar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)  //allow moving of the window
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e) { Application.Exit(); } //c'mon man, isn't this obvious
        private void exitBtn_MouseEnter(object sender, EventArgs e) { exitBtn.BackColor = Color.FromArgb(255, 38, 38, 38); }
        private void exitBtn_MouseLeave(object sender, EventArgs e) { exitBtn.BackColor = Color.FromArgb(255, 64, 64, 64); }

        private void minimizeBtn_Click(object sender, EventArgs e) { WindowState = FormWindowState.Minimized; } //c'mon man, isn't this obvious
        private void minimizeBtn_MouseEnter(object sender, EventArgs e) { minimizeBtn.BackColor = Color.FromArgb(255, 38, 38, 38); }
        private void minimizeBtn_MouseLeave(object sender, EventArgs e) { minimizeBtn.BackColor = Color.FromArgb(255, 64, 64, 64); }

        private void addToQueueBtn_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            lines.AddRange(URLTextbox.Text.Split('\n'));
            foreach (var line in lines)
            {
                int nameEnd = 0;
                int nameStart = 0;
                if (!line.Contains("https://www.webtoons.com/") || !line.Contains("/list?title_no=")) { continue; }
                try
                {
                    for (int i = 0; i < 6; i++)
                    {
                        nameStart = nameEnd;
                        while (line[nameEnd] != '/') nameEnd++;
                        nameEnd++;
                    }
                }
                catch { continue; }
                if (QueueTextbox.Text.Contains($"/{line.Substring(nameStart, nameEnd - nameStart - 1)}/")) { continue; }
                QueueTextbox.Text += (QueueTextbox.Text == "") ? line: "\n" + line;
                QueueGrid.Rows.Add(line.Substring(nameStart, nameEnd - nameStart - 1), "#1", "(end)");
            }
            URLTextbox.Text = "";
        }

        private async void startBtn_Click(object sender, EventArgs e)
        {
            await DownloadQueueAsync();
        }

        private async Task DownloadQueueAsync()
        {
            chapterLinks = new List<string>();
            chapterNames = new List<string>();
            ToonChapters = new List<string[]>();
            ToonChapterNames = new List<string[]>();
            if (!savepathTB.Text.Contains('\\'))
            {
                savepathTB.Text = "please select a directory for saving";
                return;
            }

            if (QueueTextbox.Text == "") return;

            List<string> lines = new List<string>();
            lines.AddRange(QueueTextbox.Text.Split('\n'));
            foreach (string line in lines)  //get all chapter links
            {
                await Task.Run(() => GetChapter(line));
            }
            for (int t = 0; t < ToonChapters.Count; t++)    //for each comic in queue...
            {
                await Task.Run(() => downloadComic(t));
            }
            processInfo.Text = "done!";
        }

        private void GetChapter(string line)
        {
            if (line == "") return;
            chapterLinks.RemoveRange(0, chapterLinks.Count);
            int urlEnd = (line.IndexOf('&') == -1) ? line.Length : line.IndexOf('&');
            using (WebClient client = new WebClient())
            {
                int i = 0;
                string firstLink = "Thanks for looking through my source code lol";
                bool checkedForLink, foundEnd = false;
                while (true)
                {
                    i++;
                    string html = client.DownloadString(line.Substring(0, urlEnd) + "&page=" + i);
                    var doc = new HtmlAgilityPack.HtmlDocument();   //HtmlAgility magic
                    doc.LoadHtml(html);
                    var div = doc.GetElementbyId("_listUl");
                    HtmlNodeCollection childNodes = div.ChildNodes;
                    checkedForLink = false;
                    for (int j = 0; j < childNodes.Count; j++)
                    {
                        if (childNodes[j].HasChildNodes)
                        {
                            if (!checkedForLink && firstLink != childNodes[j].ChildNodes[1].Attributes["href"].Value)   //stop if no higher page count could be found
                            {
                                firstLink = childNodes[j].ChildNodes[1].Attributes["href"].Value;
                                checkedForLink = true;
                            }
                            else if (!checkedForLink) { foundEnd = true; break; }
                            chapterLinks.Add(childNodes[j].ChildNodes[1].Attributes["href"].Value); //lunk of the chapter
                            chapterNames.Add(childNodes[j].ChildNodes[1].ChildNodes[3].ChildNodes[0].InnerHtml); //name of the chapter
                        }
                    }
                    if (foundEnd) break;
                }
            }
            chapterLinks.Reverse();
            // add all chapter links and the chapter names of the just scrapped site to the full list of the comic
            string[] tempChapterLinks = new string[chapterLinks.Count];
            for (int i = 0; i < chapterLinks.Count; i++) tempChapterLinks[i] = chapterLinks[i];
            ToonChapters.Add(tempChapterLinks);
            chapterNames.Reverse();
            string[] tempChapterNames = new string[chapterNames.Count];
            for (int i = 0; i < chapterNames.Count; i++) tempChapterNames[i] = chapterNames[i];
            ToonChapterNames.Add(tempChapterNames);
        }

        private void downloadComic(int t)
        {
            string savePath = savepathTB.Text + @"\";
            string curName = QueueGrid.Rows[t].Cells[0].Value.ToString();
            if (cartoonFoldersCB.Checked) { Directory.CreateDirectory(savePath + curName); savePath += curName; }
            for (int i = 0; i < ToonChapters[t].Length; i++)    //...and for each chapter in that comic...
            {
                processInfo.Text = $"grabbing the html of {ToonChapters[t][i]}";
                using (WebClient client = new WebClient())
                {
                    string html = client.DownloadString(ToonChapters[t][i]);
                    var doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(html);
                    var div = doc.GetElementbyId("_imageList");
                    HtmlNodeCollection childNodes = div.ChildNodes;
                    if (chapterFoldersCB.Checked) { Directory.CreateDirectory(savePath + @"\" + ToonChapterNames[t][i]); }
                    for (int j = 0; j < childNodes.Count; j++)  //...download all images!
                    {
                        if (childNodes[j].NodeType == HtmlNodeType.Element)
                        {
                            processInfo.Text = $"downloading image {j / 2} of chapter {i + 1} of the comic \"{curName}\"!";
                            client.Headers.Add("Referer", ToonChapters[t][i]);    //refresh the referer for each request!
                            string imgName = $"{curName} Ch{i + 1}.{j / 2}";
                            if (chapterFoldersCB.Checked) { client.DownloadFile(new Uri(childNodes[j].Attributes["data-url"].Value), $"{savePath}\\{ToonChapterNames[t][i]}\\{imgName}.jpg"); }
                            else { client.DownloadFile(new Uri(childNodes[j].Attributes["data-url"].Value), $"{savePath}\\{imgName}.jpg"); }
                            System.Threading.Thread.Sleep(1000);
                        }
                    }
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)    //debugging for now
        {
            for (int i = 0; i < 20; i++)
            {
                WindowState = FormWindowState.Minimized;
                WindowState = FormWindowState.Normal;
            }
        }

        private void selectFolderBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.ValidateNames = false;
            ofile.CheckFileExists = false;
            ofile.CheckPathExists = true;
            ofile.FileName = "Folder Selection";
            if (DialogResult.OK == ofile.ShowDialog())
            {
                savepathTB.Text = Path.GetDirectoryName(ofile.FileName);
            }
        }

        private void PDFcb_Click(object sender, EventArgs e)
        {
            Imagescb.Checked = false;
            PDFcb.Checked = true;
        }

        private void Imagescb_Click(object sender, EventArgs e)
        {
            PDFcb.Checked = false;
            Imagescb.Checked = true;
        }

        private void removeAllBtn_Click(object sender, EventArgs e)
        {
            QueueTextbox.Text = "";
            QueueGrid.Rows.Clear();
        }

        private void removeSelectedBtn_Click(object sender, EventArgs e)
        {
            if (QueueGrid.Rows.Count == 0) return;
            List<string> lines = new List<string>();
            lines.AddRange(QueueTextbox.Text.Split('\n'));
            QueueTextbox.Text = "";
            string name = QueueGrid.SelectedRows[0].Cells[0].Value.ToString();
            QueueGrid.Rows.RemoveAt(QueueGrid.SelectedRows[0].Index);
            foreach (var line in lines)
            {
                if (!line.Contains($"/{name}/")) { QueueTextbox.Text += line + "\n"; }
            }
        }
    }
}
