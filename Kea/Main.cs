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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kea
{
    public partial class Main : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

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

        private void exitBtn_Click(object sender, EventArgs e) { Application.Exit(); } //c'mon man, isn*t this obvious

        private void addToQueueBtn_Click(object sender, EventArgs e)
        {
            QueueTextbox.Text += (QueueTextbox.Text!= "")? "\n" + URLTextbox.Text : URLTextbox.Text;
            List<string> lines = new List<string>();
            lines.AddRange(URLTextbox.Text.Split('\n'));
            foreach (var line in lines)
            {
                int nameEnd = 0;
                int nameStart = 0;
                for (int i = 0; i < 6; i++)
                {
                    nameStart = nameEnd;
                    while (line[nameEnd] != '/') nameEnd++;
                    nameEnd++;
                }
                QueueGrid.Rows.Add(line.Substring(nameStart, nameEnd-nameStart-1),"#1","(end)");
            }
            URLTextbox.Text = "";
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            lines.AddRange(QueueTextbox.Text.Split('\n'));
            List<string> chapterLinks = new List<string>();
            List<string> chapterNames = new List<string>();
            List<string[]> ToonChapters = new List<string[]>(), ToonChapterNames = new List<string[]>();
            foreach (string line in lines)  //get all chapter links
            {
                chapterLinks.RemoveRange(0,chapterLinks.Count);
                int urlEnd = (line.IndexOf('&') == -1) ? line.Length : line.IndexOf('&');
                using (WebClient client = new WebClient())
                {
                    int i = 0;
                    string firstLink = "Thanks for looking through my source code lol";
                    bool checkedForLink, foundEnd = false;
                    while (true)
                    {
                        i++;
                        string html = client.DownloadString(line.Substring(0,urlEnd) + "&page=" + i);
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
            //debugging ---
            savepathTB.Text = @"D:\Desktop\testing\";
            //string savePath = savepathTB.Text;
            //-------------
            for (int t = 0; t < ToonChapters.Count; t++)    //for each comic in queue...
            {
                string savePath = savepathTB.Text;
                string curName = QueueGrid.Rows[t].Cells[0].Value.ToString();
                if (cartoonFoldersCB.Checked) { Directory.CreateDirectory(savePath + curName); savePath += curName; }
                for (int i = 0; i < ToonChapters[t].Length; i++)    //...and for each chapter in that comic...
                {
                    processInfo.Text = "grabbing the html of " + ToonChapters[t][i];
                    using (WebClient client = new WebClient())
                    {
                        string html = client.DownloadString(ToonChapters[t][i]);
                        var doc = new HtmlAgilityPack.HtmlDocument();
                        doc.LoadHtml(html);
                        var div = doc.GetElementbyId("_imageList");
                        HtmlNodeCollection childNodes = div.ChildNodes;
                        if (chapterFoldersCB.Checked) { Directory.CreateDirectory(savePath + @"\" + ToonChapterNames[t][i]); savePath += @"\" + ToonChapterNames[t][i]; }
                        for (int j = 0; j < childNodes.Count; j++)  //...download all images!
                        {
                            if (childNodes[j].NodeType == HtmlNodeType.Element)
                            {
                                processInfo.Text = "downloading image " + j / 2 + " of chapter " + i + 1 + "of the comic \"" + curName + "\"!";
                                client.Headers.Add("Referer", ToonChapters[t][i]);    //refresh the referer for each request!
                                client.DownloadFile(new Uri(childNodes[j].Attributes["data-url"].Value), savePath + @"\image " + j / 2 + ".jpg");
                                System.Threading.Thread.Sleep(1000);
                            }
                        }
                    }
                }
            }
            processInfo.Text = "done!";
        }

        private void cancelBtn_Click(object sender, EventArgs e)    //debugging for now
        {

        }

        private void selectFolderBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Image|*.bmp;*.jpg;*.png";
            if (DialogResult.OK == ofile.ShowDialog())
            {
                savepathTB.Text = ofile.FileName;
            }
        }
    }
}
