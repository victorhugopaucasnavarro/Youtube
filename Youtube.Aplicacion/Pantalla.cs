using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using VideoLibrary;
using YoutubeExtractor;

namespace Youtube.Aplicacion
{
    public partial class Pantalla : Form
    {
        string Directorio;
        string Enlace;
        string Archivo;

        public Pantalla()
        {
            InitializeComponent();
        }

        private void Pantalla_Load(object sender, EventArgs e)
        {
            cboArchivo.SelectedIndex = 1;
            cboArchivo.Enabled = false;
            lblProgreso.Visible = false;
            pgbProgreso.Visible = false;
            //this.Size = new System.Drawing.Size(750, 302);
            //this.Size = new System.Drawing.Size(750, 250);
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtRuta.Text = folderBrowserDialog.SelectedPath;
                Directorio = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    FormatearProgreso();
                    var youTube = YouTube.Default;
                    var video = youTube.GetVideo(Enlace);
                    File.WriteAllBytes(Path.Combine(Directorio, video.FullName), video.GetBytes());
                    MessageBox.Show("Se descargó el video correctamente.", "Youtube", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al buscar enlace, verifique que el enlace exista.", "Youtube", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //try
                //{
                //    Enlace = txtEnlace.Text;
                //    Archivo = cboArchivo.Text;
                //    IEnumerable<VideoInfo> videoInfo = DownloadUrlResolver.GetDownloadUrls(Enlace);

                //    switch (Archivo)
                //    {
                //        case "Audio": DescargarAudio(videoInfo); break;
                //        case "Video": DescargarVideo(videoInfo); break;
                //    }
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Error al buscar enlace, verifique que el enlace exista.", "Youtube", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }

        private void DescargarVideo(IEnumerable<VideoInfo> videoInfo)
        {
            VideoInfo video = videoInfo.First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);

            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            var videoDownloader = new VideoDownloader(video, Path.Combine(Directorio, video.Title + video.AudioExtension));

            videoDownloader.DownloadProgressChanged += VideoDownloader_DownloadProgressChanged; FormatearProgreso();

            Thread thread = new Thread(() => { videoDownloader.Execute(); }) { IsBackground = true };
            thread.Start();
        }

        private void VideoDownloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                pgbProgreso.Value = Convert.ToInt32(e.ProgressPercentage);
                lblProgreso.Text = "Descargando ... " + Convert.ToString(e.ProgressPercentage) + " %";
                pgbProgreso.Update();
            }));
        }

        private void DescargarAudio(IEnumerable<VideoInfo> videoInfo)
        {
            VideoInfo video = videoInfo.Where(info => info.CanExtractAudio).OrderByDescending(info => info.AudioBitrate).First();

            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            var audioDownloader = new AudioDownloader(video, Path.Combine(Directorio, video.Title + video.AudioExtension));

            audioDownloader.DownloadProgressChanged += (sender, args) => Console.WriteLine(args.ProgressPercentage * 0.85);
            audioDownloader.AudioExtractionProgressChanged += (sender, args) => Console.WriteLine(85 + args.ProgressPercentage * 0.15);

            audioDownloader.DownloadProgressChanged += AudioDownloader_DownloadProgressChanged; FormatearProgreso();
            audioDownloader.AudioExtractionProgressChanged += AudioDownloader_AudioExtractionProgressChanged; FormatearProgreso();

            Thread thread = new Thread(() => { audioDownloader.Execute(); }) { IsBackground = true };
            thread.Start();
        }

        private void AudioDownloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                pgbProgreso.Value = Convert.ToInt32(e.ProgressPercentage);
                lblProgreso.Text = "Descargando ... " + Convert.ToString(e.ProgressPercentage) + " %";
                pgbProgreso.Update();
            }));
        }

        private void AudioDownloader_AudioExtractionProgressChanged(object sender, ProgressEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                pgbProgreso.Value = Convert.ToInt32(e.ProgressPercentage);
                lblProgreso.Text = "Convirtiendo ... " + Convert.ToString(e.ProgressPercentage) + " %";
                pgbProgreso.Update();
            }));
        }

        private void FormatearProgreso()
        {
            pgbProgreso.Visible = true;
            pgbProgreso.Minimum = 1;
            pgbProgreso.Maximum = 100;
            pgbProgreso.Value = 1;
            pgbProgreso.Step = 1;
        }

        private bool ValidarCampos()
        {
            if (txtRuta.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Falta seleccionar la ruta de descarga.", "Youtube", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtEnlace.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Falta ingresar el enlace.", "Youtube", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void tsmAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Paucas Navarro, Victor Hugo \nCorreo: vhpaucas@gmail.com \nRepositorio: www.github.com/victorpaucas", "Youtube", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
