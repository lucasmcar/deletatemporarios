using System;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Security.Principal;

namespace DeleteTemp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        String[] arquivos;
        String path;
        String name = Environment.UserName;
        FolderBrowserDialog folder = new FolderBrowserDialog();

        private void btVerificar_Click(object sender, EventArgs e)
        {
            VerificaRadioButton();

            lbTotArquivos.Text = String.Format("{0} arquivos encontrados", arquivos.Count().ToString());

            //calcula o tamanho do arquivo selecionado

            double avg = arquivos.Select(file => new FileInfo(file).Length).Average();
            //calcula o tamanho médio dos arquivos da pasta
            lbMedFile.Text = FormataExibicaoTamanhoArquivo((long)Math.Round(avg / 10, 1));

            //calcula o tamanho total da pasta e subpastas
            DirectoryInfo infoDiretorio = new DirectoryInfo(folder.SelectedPath);
            long tamanhoDoDiretorio = TamanhoTotalDiretorio(infoDiretorio, true);
            lbFolderSize.Text = FormataExibicaoTamanhoArquivo(tamanhoDoDiretorio);

            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;

        }

        private void VerificaRadioButton()
        {
            if (rbTmpU.Checked)
            {

                path = String.Format("C:\\Users\\{0}\\AppData\\Local\\Temp", name);
                lbNomeDir.Text = path;
                lblInfo.Text = "";
                VerificaTempUser(path);
                pnInfo.Visible = true;

            }

            if (rbTmpW.Checked)
            {

                path = "C:\\Windows\\Temp";
                lbNomeDir.Text = path;
                lblInfo.Text = "*Essa pasta precisa de permisssão \n do Administrador";
                VerificaTempWin(path);
                pnInfo.Visible = true;
            }

            if (rbPrefetch.Checked)
            {

                path = "C:\\Windows\\Prefetch";
                lbNomeDir.Text = path;
                lblInfo.Text = "*Essa pasta precisa de permisssão \n do Administrador";
                VerificaPrefetch(path);
                pnInfo.Visible = true;


            }
        }


        private void VerificaTempUser(String path)
        {
            path = String.Format("C:\\Users\\{0}\\AppData\\Local\\Temp", name);

            folder.SelectedPath = path;

            try
            {
                arquivos = Directory.GetFiles(folder.SelectedPath);
                foreach (string f in Directory.GetFiles(folder.SelectedPath))
                {
                    this.lstFiles.Items.Add(f);
                }

            }
            catch
            {

            }
        }

        private void VerificaTempWin(String path)
        {

            folder.SelectedPath = path;

            try
            {
                arquivos = Directory.GetFiles(folder.SelectedPath);


                foreach (string f in Directory.GetFiles(folder.SelectedPath))
                {
                    this.lstFiles.Items.Add(f);
                }
            }
            catch
            {
                throw;
            }
        }

        private void VerificaPrefetch(String path)
        {

            folder.SelectedPath = path;

            try
            {
                arquivos = Directory.GetFiles(folder.SelectedPath);
                foreach (string f in Directory.GetFiles(folder.SelectedPath))
                {
                    this.lstFiles.Items.Add(f);
                }
            }
            catch
            {
                throw;
            }
        }

        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Retorna o tamanho do arquivo para um tamanho
        // O formato padrão é "0.### XB", Ex: "4.2 KB" ou "1.434 GB"
        public string FormataExibicaoTamanhoArquivo(long i)
        {
            // Obtém o valor absoluto
            long i_absoluto = (i < 0 ? -i : i);
            // Determina o sufixo e o valor
            string sufixo;
            double leitura;
            if (i_absoluto >= 0x1000000000000000) // Exabyte
            {
                sufixo = "EB";
                leitura = (i >> 50);
            }
            else if (i_absoluto >= 0x4000000000000) // Petabyte
            {
                sufixo = "PB";
                leitura = (i >> 40);
            }
            else if (i_absoluto >= 0x10000000000) // Terabyte
            {
                sufixo = "TB";
                leitura = (i >> 30);
            }
            else if (i_absoluto >= 0x40000000) // Gigabyte
            {
                sufixo = "GB";
                leitura = (i >> 20);
            }
            else if (i_absoluto >= 0x100000) // Megabyte
            {
                sufixo = "MB";
                leitura = (i >> 10);
            }
            else if (i_absoluto >= 0x400) // Kilobyte
            {
                sufixo = "KB";
                leitura = i;
            }
            else
            {
                return i.ToString("0 bytes"); // Byte
            }
            // Divide por 1024 para obter o valor fracionário
            leitura = (leitura / 1024);
            // retorna o número formatado com sufixo
            return leitura.ToString("0.### ") + sufixo;
        }

        private long TamanhoTotalDiretorio(DirectoryInfo dInfo, bool includeSubDir)
        {
            long tamanhoTotal = dInfo.EnumerateFiles().Sum(file => file.Length);
            if (includeSubDir)
            {
                tamanhoTotal += dInfo.EnumerateDirectories().Sum(dir => TamanhoTotalDiretorio(dir, true));
            }
            return tamanhoTotal;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (rbTmpU.Checked)
            {
                path = String.Format("C:\\Users\\{0}\\AppData\\Local\\Temp", name);
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, true);
                    
                }
            }

            if (rbTmpW.Checked)
            {
                path = "C:\\Windows\\Temp";
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, true);

                }
                Directory.CreateDirectory(path);
            }

            if (rbPrefetch.Checked)
            {
                path = "C:\\Windows\\Prefetch";
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, true);

                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                arquivos = Directory.GetFiles(folder.SelectedPath);
                foreach (string f in Directory.GetFiles(folder.SelectedPath))
                {
                    this.lstFiles.Items.Remove(f);
                }

                lbNomeDir.Text = "";
                lbFolderSize.Text = "";
                lbMedFile.Text = "";
                lbTotArquivos.Text = "";
            }
            catch
            {
                throw;
            }

            
        }
    }
}