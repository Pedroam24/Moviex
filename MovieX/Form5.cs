using System;
using System.Windows.Forms;

namespace MovieX
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form5_Load); // Adiciona o evento Load
        }

        public static string VideoPath { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de Vídeo|*.mp4;*.avi;*.mkv;*.wmv"; // Filtro para tipos de vídeo
                openFileDialog.Title = "Selecione um arquivo de vídeo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    VideoPath = openFileDialog.FileName; // Armazena o caminho do vídeo
                    axWindowsMediaPlayer1.URL = VideoPath; // Carrega o vídeo no player
                    axWindowsMediaPlayer1.Ctlcontrols.play(); // Inicia a reprodução
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form3 = new Form4();
            form3.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Verifica se VideoPath não está vazio e carrega o vídeo
            if (!string.IsNullOrEmpty(VideoPath))
            {
                axWindowsMediaPlayer1.URL = VideoPath; // Carrega o vídeo no player
                axWindowsMediaPlayer1.Ctlcontrols.play(); // Inicia a reprodução
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}