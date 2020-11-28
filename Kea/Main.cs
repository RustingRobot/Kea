using HtmlAgilityPack;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = iTextSharp.text.Image;
using Rectangle = iTextSharp.text.Rectangle;

namespace Kea
{
    public partial class Main : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public float absoluteChapterNR;
        public List<string> chapterLinks, chapterNames;
        public List<string[]> ToonChapters, ToonChapterNames;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                // add the drop shadow flag for automatically drawing
                // a drop shadow around the form
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

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
        private void exitBtn_MouseEnter(object sender, EventArgs e) { exitBtn.BackColor = Color.FromArgb(255, 20, 70, 34); }
        private void exitBtn_MouseLeave(object sender, EventArgs e) { exitBtn.BackColor = Color.FromArgb(255, 0, 30, 14); }

        private void minimizeBtn_Click(object sender, EventArgs e) { WindowState = FormWindowState.Minimized; } //c'mon man, isn't this obvious
        private void minimizeBtn_MouseEnter(object sender, EventArgs e) { minimizeBtn.BackColor = Color.FromArgb(255, 20, 70, 34); }
        private void minimizeBtn_MouseLeave(object sender, EventArgs e) { minimizeBtn.BackColor = Color.FromArgb(255, 0, 30, 14); }

        private void addToQueueBtn_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            lines.AddRange(URLTextbox.Text.Split('\n'));
            foreach (var line in lines)
            {
                int nameEnd = 0;
                int nameStart = 0;
                if (!line.Contains("https://www.webtoons.com/") || !line.Contains("/list?title_no=")) { continue; } //doesn't support m.webtoons.com bc it would result in a 400 bad request and i'm too lazy to replace the m with www manually
                if (line.Length - line.Replace("/", "").Length != 6) { continue; }
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
            DisableAllControls(this);
            EnableControls(HandleBar);
            EnableControls(exitBtn);
            EnableControls(minimizeBtn);
            await DownloadQueueAsync();
            EnableAllControls(this);
            if(PDFcb.Checked) chapterFoldersCB.Enabled = false;
        }

        private async Task DownloadQueueAsync()
        {
            absoluteChapterNR = 0;
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
                await Task.Run(() => GetChapterAsync(line));
            }
            for (int t = 0; t < ToonChapters.Count; t++)    //for each comic in queue...
            {
                await Task.Run(() => downloadComic(t));
            }
            processInfo.Text = "done!";
            progressBar.Value = 0;
        }

        private async Task GetChapterAsync(string line)
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
                    string html = await client.DownloadStringTaskAsync(line.Substring(0, urlEnd) + "&page=" + i);
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
                            chapterLinks.Add(childNodes[j].ChildNodes[1].Attributes["href"].Value); //link of the chapter
                            chapterNames.Add(childNodes[j].ChildNodes[1].ChildNodes[3].ChildNodes[0].InnerHtml); //name of the chapter
                        }
                    }
                    if (foundEnd) break;
                }
            }
            chapterLinks.Reverse();
            absoluteChapterNR += chapterLinks.Count;
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
                processInfo.Invoke((MethodInvoker)delegate { processInfo.Text = $"grabbing the html of {ToonChapters[t][i]}"; progressBar.Value = (int)((i + 1) / absoluteChapterNR * 100); Console.WriteLine(progressBar.Value + "   " + i / absoluteChapterNR); }); //run on the UI thread
                using (WebClient client = new WebClient())
                {
                    string html = client.DownloadString(ToonChapters[t][i]);
                    var doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(html);
                    var div = doc.GetElementbyId("_imageList");
                    HtmlNodeCollection childNodes = div.ChildNodes;
                    if (chapterFoldersCB.Checked || PDFcb.Checked) { Directory.CreateDirectory(savePath + @"\" + $"({i+1}) {ToonChapterNames[t][i]}"); }
                    for (int j = 0; j < childNodes.Count; j++)  //...download all images!
                    {
                        if (childNodes[j].NodeType == HtmlNodeType.Element)
                        {
                            processInfo.Invoke((MethodInvoker)delegate { processInfo.Text = $"downloading image {j / 2} of chapter {i + 1} of the comic \"{curName}\"!"; }); //run on the UI thread
                            client.Headers.Add("Referer", ToonChapters[t][i]);    //refresh the referer for each request!
                            string imgName = $"{curName} Ch{i + 1}.{j / 2}";
                            if (chapterFoldersCB.Checked || PDFcb.Checked) { client.DownloadFile(new Uri(childNodes[j].Attributes["data-url"].Value), $"{savePath}\\({i+1}) {ToonChapterNames[t][i]}\\{imgName}.jpg"); }
                            else { client.DownloadFile(new Uri(childNodes[j].Attributes["data-url"].Value), $"{savePath}\\{imgName}.jpg"); }
                        }
                    }
                }
                if (PDFcb.Checked)  //bundle images into PDF
                {
                    DirectoryInfo di = new DirectoryInfo($"{savePath}\\({i + 1}) {ToonChapterNames[t][i]}");
                    FileInfo[] fileInfos = di.GetFiles("*.jpg").OrderBy(fi => fi.CreationTime).ToArray();
                    string[] files = fileInfos.Select(o => o.FullName).ToArray();
                    Document doc = new Document();
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream($"{savePath}\\({i + 1}) {ToonChapterNames[t][i]}.pdf", FileMode.Create));
                        doc.Open();
                        for (int j = 0; j < files.Length; j++)
                        {
                            Image img = Image.GetInstance(files[j]);
                            img.SetAbsolutePosition(0, 0);
                            doc.SetPageSize(new Rectangle(img.Width, img.Height));
                            doc.NewPage();
                            doc.Add(img);
                        }
                    }
                    catch { Console.WriteLine("rip"); }
                    finally { doc.Close(); }
                    Directory.Delete($"{savePath}\\({i + 1}) {ToonChapterNames[t][i]}", true);
                }
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

        private void DisableAllControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                DisableAllControls(c);
            }
            con.Enabled = false;
        }

        private void PDFcb_CheckedChanged(object sender, EventArgs e)
        {
            if (PDFcb.Checked == true) { chapterFoldersCB.Checked = false; chapterFoldersCB.Enabled = false; }
            else { chapterFoldersCB.Enabled = true; chapterFoldersCB.Checked = true; }
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/RustingRobot/Kea#how-to-use");
        }

        private void EnableAllControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                EnableAllControls(c);
            }
            con.Enabled = true;
        }

        private void EnableControls(Control con)
        {
            if (con != null)
            {
                con.Enabled = true;
                EnableControls(con.Parent);
            }
        }
    }
}
