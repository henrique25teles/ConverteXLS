using ClosedXML.Excel;
using Syncfusion.XlsIO;
using System.Diagnostics;

namespace ConverteXLS
{
    public partial class ConverteXls : Form
    {
        private Stopwatch stopwatch = new Stopwatch();

        public ConverteXls()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var result = folderBrowserPlanilhas.ShowDialog();

            if (result == DialogResult.OK)
            {
                txt_Path.Text = folderBrowserPlanilhas.SelectedPath;
            }
        }

        private void btn_converter_Click(object sender, EventArgs e)
        {
            try
            {
                BloqueiaCamposDaTela();

                var caminho = txt_Path.Text;

                if (!System.IO.Path.Exists(caminho))
                {
                    throw new Exception("Não existe esse caminho no sistema");
                }

                var caminhosPlanilhas = new Queue<string>();

                BuscaArquivosParaConverter(caminho, caminhosPlanilhas);
                ConvertePlanilhas(caminhosPlanilhas);

                MessageBox.Show("Convertido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                DesbloqueiaCamposDaTela();
                pgBar.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.InnerException?.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                DesbloqueiaCamposDaTela();
                pgBar.Value = 0;
            }
        }

        private void BloqueiaCamposDaTela()
        {
            this.Cursor = Cursors.WaitCursor;
            txt_Path.Enabled = false;
            btnBuscar.Enabled = false;
            btnDeletar.Enabled = false;
            btn_converter.Enabled = false;
            chk_deletaOld.Enabled = false;
        }

        private void DesbloqueiaCamposDaTela()
        {
            this.Cursor = Cursors.Default;
            txt_Path.Enabled = true;
            btnBuscar.Enabled = true;
            btnDeletar.Enabled = true;
            btn_converter.Enabled = true;
            chk_deletaOld.Enabled = false;
        }

        private void BuscaArquivosParaConverter(string path, Queue<string> lista)
        {
            var files = Directory.GetFiles(path).Where(x => x.ToLower().EndsWith("xls"));

            foreach (var file in files)
            {
                lista.Enqueue(file);
            }

            var folders = Directory.GetDirectories(path);

            foreach (var folder in folders)
            {
                BuscaArquivosParaConverter(folder, lista);
            }
        }

        private void BuscaPDFsParaDeletar(string path, Queue<string> lista)
        {
            var files = Directory.GetFiles(path).Where(x => x.ToLower().EndsWith("pdf"));

            foreach (var file in files)
            {
                lista.Enqueue(file);
            }

            var folders = Directory.GetDirectories(path);

            foreach (var folder in folders)
            {
                BuscaPDFsParaDeletar(folder, lista);
            }
        }

        private void BuscaArquivosCriados(string path, Queue<string> lista)
        {
            var files = Directory.GetFiles(path).Where(x => x.ToLower().EndsWith("xlsx"));

            foreach (var file in files)
            {
                var dataCriacao = File.GetCreationTime(file);

                if (dataCriacao > DateTime.Now.Date)
                    lista.Enqueue(file);
            }

            var folders = Directory.GetDirectories(path);

            foreach (var folder in folders)
                BuscaArquivosCriados(folder, lista);
        }

        private void ConvertePlanilhas(Queue<string> lista)
        {
            if (!lista.Any())
            {
                throw new Exception("Nenhum arquivo encontrado");
            }

            pgBar.Maximum = lista.Count;

            while (lista.Any())
            {
                var planilhaPath = lista.Dequeue();

                FileStream inputData = new FileStream(planilhaPath, FileMode.Open, FileAccess.ReadWrite);

                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Xlsx;
                    IWorkbook workbook = application.Workbooks.Open(inputData);
                    IWorksheets worksheets = workbook.Worksheets;

                    workbook.Version = ExcelVersion.Xlsx;

                    var outputDirectory = Path.GetDirectoryName(planilhaPath);
                    var outputFilename = Path.GetFileNameWithoutExtension(planilhaPath) + ".xlsx";
                    var outputFile = Path.Combine(outputDirectory, outputFilename);

                    using var fileStream = new FileStream(outputFile, FileMode.Create, FileAccess.ReadWrite);
                    workbook.SaveAs(fileStream);
                    fileStream.Close();
                    fileStream.Dispose();

                    RemoveMarcasDagua(outputFile);
                }

                if (chk_deletaOld.Checked)
                {
                    File.Delete(planilhaPath);
                }

                pgBar.Value++;
            }
        }

        public void RemoveMarcasDagua(string filePath)
        {
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
            {
                using (var workbook = new XLWorkbook(stream))
                {
                    //remove ultima worksheet criada
                    workbook.Worksheets.Delete(workbook.Worksheets.Count);

                    var workSheet = workbook.Worksheet(1);

                    //Remove ultima linha com link da syncfusion
                    var lastRow = workSheet.Row(workSheet.LastRowUsed().RowNumber());
                    lastRow.Delete();

                    workbook.Save();
                }
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                BloqueiaCamposDaTela();

                var caminho = txt_Path.Text;

                if (!System.IO.Path.Exists(caminho))
                {
                    throw new Exception("Não existe esse caminho no sistema");
                }

                var caminhosPlanilhas = new Queue<string>();

                BuscaArquivosParaConverter(caminho, caminhosPlanilhas);
                DeletaArquivos(caminhosPlanilhas);

                MessageBox.Show("Deletado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                DesbloqueiaCamposDaTela();
                pgBar.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.InnerException?.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                DesbloqueiaCamposDaTela();
                pgBar.Value = 0;
            }
        }

        private void DeletaArquivos(Queue<string> lista)
        {
            if (!lista.Any())
            {
                throw new Exception("Nenhum arquivo encontrado");
            }

            pgBar.Maximum = lista.Count;

            while (lista.Any())
            {
                var planilhaPath = lista.Dequeue();

                File.Delete(planilhaPath);

                pgBar.Value++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_DeletaPdf_Click(object sender, EventArgs e)
        {
            try
            {
                BloqueiaCamposDaTela();

                var caminho = txt_Path.Text;

                if (!System.IO.Path.Exists(caminho))
                {
                    throw new Exception("Não existe esse caminho no sistema");
                }

                var caminhoPdfs = new Queue<string>();

                BuscaPDFsParaDeletar(caminho, caminhoPdfs);
                DeletaArquivos(caminhoPdfs);

                MessageBox.Show("Deletado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                DesbloqueiaCamposDaTela();
                pgBar.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.InnerException?.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                DesbloqueiaCamposDaTela();
                pgBar.Value = 0;
            }
        }
    }
}
