using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineStickerDownloader
{
    public partial class frmMain : Form
    {
        private settings iniFile;
        private string savePath;

        private bool isDraging = false;
        private Point startPoint;

        public frmMain()
        {
            InitializeComponent();
            string iniPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.ini");
            iniFile = new settings(iniPath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbType.Items.Add("Common Sticker");
            cbType.Items.Add("Animated Sticker");
            cbType.SelectedIndex = 0;
            menuStrip1.BackColor = Color.FromArgb(38, 41, 64);
            cbType.Text = "Common Sticker";
            savePath = iniFile.Read("Settings", "FolderPath");

            #region Update Code
            //================================ Remove the comments to enable auto-update =================================//

            //try
            //{
            //    string currentVersion = "1.3.2.1";
            //    string latestVersion = new WebClient().DownloadString("Paste Your Link Latest Version Here");
            //    if (latestVersion != currentVersion)
            //    {
            //        DialogResult result = MessageBox.Show($"A new update is available.\n\n Current Version : {currentVersion}\n Latest Version : {latestVersion}\n\n Do you want to update?", "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //        if (result == DialogResult.Yes)
            //        {
            //            Process p = new Process();
            //            p.StartInfo.FileName = "Updater.exe";
            //            p.Start();
            //            Application.Exit();
            //        }
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Update check failed!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            //============================================================================================================//
            #endregion
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            savePath = iniFile.Read("Settings", "FolderPath");
            string ID = tbID.Text;
            switch (gbDownloadPanel.Text)
            {
                case "Sticker Download":
                    DownloadSticker(savePath, ID); 
                    break;
                case "Emoji Download":
                    DownloadEmoji(savePath, ID);
                    break;
            }
        }

        #region GetIcon
        //================================================ Get Icon Sticker =================================================//

        //Sticker
        private void LoadStickerIcon(string stickerID)
        {
            try
            {
                string url = $"https://stickershop.line-scdn.net/stickershop/v1/product/{stickerID}/LINEStorePC/main.png";

                using (WebClient client = new WebClient())
                {
                    byte[] imageData = client.DownloadData(url);

                    using (var ms = new System.IO.MemoryStream(imageData))
                    {
                        Image stickerImage = Image.FromStream(ms);
                        pbPreviewImg.Image = stickerImage;
                    }
                }
            }
            catch (Exception)
            {
                //pbPreviewImg.Image = default;
                //MessageBox.Show($"Gagal memuat stiker: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Emoji
        private void LoadEmojiIcon(string emojiID)
        {
            try
            {
                string url = $"https://stickershop.line-scdn.net/sticonshop/v1/product/{emojiID}/iPhone/main.png";

                using (WebClient client = new WebClient())
                {
                    byte[] imageData = client.DownloadData(url);

                    using (var ms = new System.IO.MemoryStream(imageData))
                    {
                        Image stickerImage = Image.FromStream(ms);
                        pbPreviewImg.Image = stickerImage;
                    }
                }
            }
            catch (Exception)
            {
                //pbPreviewImg.Image = default;
                //MessageBox.Show($"Gagal memuat stiker: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        //===================================================================================================================//
        #endregion

        #region GetStickerName
        //================================================ Get Sticker Name =================================================//
        private async Task<string> GetHtmlContent(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }

        private string ExtractJsonLd(string htmlContent)
        {
            string patern = @"<script type=""application/ld\+json"">(.*?)</script>";
            Match match = Regex.Match(htmlContent, patern, RegexOptions.Singleline);
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            return null;
        }

        private string GetProductName(string jsonLd)
        {
            JObject jsonObject = JObject.Parse(jsonLd);
            return jsonObject["name"]?.ToString();
        }
        //===================================================================================================================//
        #endregion

        private void tbIDSticker_TextChanged(object sender, EventArgs e)
        {
            pDownload.Value = 0;
            lblLog.Text = "◈ Iddle ◈ ";

            if (string.IsNullOrEmpty(tbID.Text))
            {
                lblTitle.Text = "";
                pbPreviewImg.Image = default;
            }
            else
            {
                switch (gbDownloadPanel.Text)
                {
                    case "Sticker Download":
                        LoadStickerTitle();
                        break;
                    case "Emoji Download":
                        LoadEmojiTitle();
                        break;
                }
            }
        }

        #region LoadTitle
        //================================================ Get Icon Sticker =================================================//

        private async void LoadEmojiTitle()
        {
            string emojiId = tbID.Text;
            string url = $"https://store.line.me/emojishop/product/{emojiId}";

            try
            {
                string htmlContent = await GetHtmlContent(url);
                string jsonLd = ExtractJsonLd(htmlContent);
                if (!string.IsNullOrEmpty(jsonLd))
                {
                    string productName = GetProductName(jsonLd);
                    lblTitle.Text = productName;
                }
                else
                {
                    lblTitle.Text = "Unknown";
                }
            }
            catch (Exception)
            {
                lblTitle.Text = "Unknown";
            }
            LoadEmojiIcon(emojiId);
        }

        private async void LoadStickerTitle()
        {
            string stickerId = tbID.Text;
            string url = $"https://store.line.me/stickershop/product/{stickerId}";

            try
            {
                string htmlContent = await GetHtmlContent(url);
                string jsonLd = ExtractJsonLd(htmlContent);
                if (!string.IsNullOrEmpty(jsonLd))
                {
                    string productName = GetProductName(jsonLd);
                    lblTitle.Text = productName;
                }
                else
                {
                    lblTitle.Text = "Unknown";
                }
            }
            catch (Exception)
            {
                lblTitle.Text = "Unknown";
            }
            LoadStickerIcon(stickerId);
        }

        //===================================================================================================================//
        #endregion

        #region ButtonCode
        //================================================== Button Code ===================================================//

        private void btnEmoji_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
            gbDownloadPanel.Text = "Emoji Download";
            lblID.Text = "Emoji ID :";
            lblType.Text = "Emoji Type :";
            cbType.Items.Clear();
            cbType.Items.Add("Common Emoji");
            cbType.Items.Add("Animated Emoji");
            cbType.SelectedIndex = 0;
            btnEmoji.Visible = false;
            btnSticker.Visible = true;
        }

        private void btnSticker_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
            gbDownloadPanel.Text = "Sticker Download";
            lblID.Text = "Sticker ID :";
            lblType.Text = "Sticker Type :";
            cbType.Items.Clear();
            cbType.Items.Add("Common Sticker");
            cbType.Items.Add("Animated Sticker");
            cbType.SelectedIndex = 0;
            btnEmoji.Visible = true;
            btnSticker.Visible = false;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            pClose.BackColor = Color.Red;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            pClose.BackColor = Color.Transparent;
        }

        private void pClose_MouseEnter(object sender, EventArgs e)
        {
            pClose.BackColor = Color.Red;
        }

        private void pClose_MouseLeave(object sender, EventArgs e)
        {
            pClose.BackColor = Color.Transparent;
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lblMinimize_MouseEnter(object sender, EventArgs e)
        {
            pMinimize.BackColor = Color.WhiteSmoke;
            lblMinimize.ForeColor = Color.DarkGray;
        }

        private void lblMinimize_MouseLeave(object sender, EventArgs e)
        {
            pMinimize.BackColor = Color.Transparent;
            lblMinimize.ForeColor = Color.White;
        }

        private void pMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pMinimize_MouseEnter(object sender, EventArgs e)
        {
            pMinimize.BackColor = Color.WhiteSmoke;
            lblMinimize.ForeColor = Color.DarkGray;
        }

        private void pMinimize_MouseLeave(object sender, EventArgs e)
        {
            pMinimize.BackColor = Color.Transparent;
            lblMinimize.ForeColor = Color.White;
        }

        private void lblHelp2_Click(object sender, EventArgs e)
        {
            frmFindID frmID = new frmFindID();
            frmID.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings setting = new frmSettings();
            setting.ShowDialog();
        }

        private void changeLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeLogs change = new frmChangeLogs();
            change.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I give this ❤️ to you 😊", "❤️", MessageBoxButtons.OK);
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.ShowDialog();
        }

        //==================================================================================================================//
        #endregion

        #region DragControl

        private void lblTitleApp_MouseDown(object sender, MouseEventArgs e)
        {
            isDraging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void lblTitleApp_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                this.Location = new Point(currentScreenPos.X - startPoint.X, currentScreenPos.Y - startPoint.Y);
            }
        }

        private void lblTitleApp_MouseUp(object sender, MouseEventArgs e)
        {
            isDraging = false;
        }

        private void pWindow_MouseDown(object sender, MouseEventArgs e)
        {
            isDraging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void pWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                this.Location = new Point(currentScreenPos.X - startPoint.X, currentScreenPos.Y - startPoint.Y);
            }
        }

        private void pWindow_MouseUp(object sender, MouseEventArgs e)
        {
            isDraging = false;
        }


        #endregion

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            string folderPath = iniFile.Read("Settings", "FolderPath");
            if (Directory.Exists(folderPath))
            {
                Process.Start("explorer.exe", folderPath);
            }
            else
            {
                MessageBox.Show("The folder path does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region DownloadSticker Code
        //================================================ Download Sticker =================================================//

        public async void DownloadSticker(string savePath, string stickerID)
        {
            if (string.IsNullOrEmpty(tbID.Text))
            {
                MessageBox.Show("Enter sticker id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                pDownload.Value = 0;
                lblLog.Text = "Starting download...";

                string baseUrl = "https://stickershop.line-scdn.net/stickershop/v1/product/";
                string urlSuffix = cbType.Text == "Common Sticker" ? "/iphone/stickers@2x.zip" : "/iphone/stickerpack@2x.zip";
                string url = $"{baseUrl}{stickerID}{urlSuffix}";

                using (HttpClient client = new HttpClient())
                {
                    using (var response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var totalBytes = response.Content.Headers.ContentLength ?? -1L;
                            string filePath = Path.Combine(savePath, $"{tbID.Text}.zip");

                            using (var contentStream = await response.Content.ReadAsStreamAsync())
                            using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true))
                            {
                                var buffer = new byte[8192];
                                long totalRead = 0;
                                int bytesRead;

                                while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                                {
                                    await fileStream.WriteAsync(buffer, 0, bytesRead);
                                    totalRead += bytesRead;

                                    if (totalBytes > 0)
                                    {
                                        pDownload.Value = (int)((totalRead * 100) / totalBytes);
                                        if (totalRead < 1048576)
                                        {
                                            lblLog.Text = $"Downloaded {totalRead / 1024.0:F2} KB of {totalBytes / 1024.0:F2} KB...";
                                        }
                                        else
                                        {
                                            lblLog.Text = $"Downloaded {totalRead / 1048576.0:F2} MB of {totalBytes / 1048576.0:F2} MB...";
                                        }
                                    }
                                }
                            }

                            lblLog.Text = "Download completed successfully.";

                            string extractPath = Path.Combine(savePath, tbID.Text);
                            System.IO.Compression.ZipFile.ExtractToDirectory(filePath, extractPath);
                            if (File.Exists(filePath))
                            {
                                File.Delete(filePath);
                            }
                            lblLog.Text = "Extract completed.";
                            lblLog.Text = "Completed.";
                            MessageBox.Show("Sticker has been successfully downloaded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            lblLog.Text = "Sticker not found.";
                            MessageBox.Show("Sticker not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblLog.Text = $"Error: {ex.Message}";
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //===================================================================================================================//
        #endregion

        #region Emoji Download Code
        //================================================ Download Emoji =================================================//

        public async void DownloadEmoji(string savePath, string emojiID)
        {
            if (string.IsNullOrEmpty(tbID.Text))
            {
                MessageBox.Show("Enter emoji id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                pDownload.Value = 0;
                lblLog.Text = "Starting download...";

                string baseUrl = "https://stickershop.line-scdn.net/sticonshop/v1/sticon/";
                string urlSuffix = cbType.Text == "Common Emoji" ? "/iphone/package.zip" : "/iphone/package_animation.zip";
                string url = $"{baseUrl}{emojiID}{urlSuffix}";

                using (HttpClient client = new HttpClient())
                {
                    using (var response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var totalBytes = response.Content.Headers.ContentLength ?? -1L;
                            string filePath = Path.Combine(savePath, $"{tbID.Text}.zip");

                            using (var contentStream = await response.Content.ReadAsStreamAsync())
                            using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true))
                            {
                                var buffer = new byte[8192];
                                long totalRead = 0;
                                int bytesRead;

                                while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                                {
                                    await fileStream.WriteAsync(buffer, 0, bytesRead);
                                    totalRead += bytesRead;

                                    if (totalBytes > 0)
                                    {
                                        pDownload.Value = (int)((totalRead * 100) / totalBytes);
                                        if (totalRead < 1048576)
                                        {
                                            lblLog.Text = $"Downloaded {totalRead / 1024.0:F2} KB of {totalBytes / 1024.0:F2} KB...";
                                        }
                                        else
                                        {
                                            lblLog.Text = $"Downloaded {totalRead / 1048576.0:F2} MB of {totalBytes / 1048576.0:F2} MB...";
                                        }
                                    }
                                }
                            }

                            lblLog.Text = "Download completed successfully.";

                            string extractPath = Path.Combine(savePath, tbID.Text);
                            System.IO.Compression.ZipFile.ExtractToDirectory(filePath, extractPath);
                            if (File.Exists(filePath))
                            {
                                File.Delete(filePath);
                            }
                            lblLog.Text = "Extract completed.";
                            lblLog.Text = "Completed.";
                            MessageBox.Show("Emoji has been successfully downloaded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            lblLog.Text = "Emoji not found.";
                            MessageBox.Show("Emoji not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblLog.Text = $"Error: {ex.Message}";
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //===================================================================================================================//
        #endregion
    }
}
