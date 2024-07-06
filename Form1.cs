using System.IO;

namespace TDE_4
{
    public partial class Form1 : Form
    {
        string caminhoArquivo = "dados.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private bool CPFExistente(string cpf)
        {

            string[] linhas = { };

            try
            {
                linhas = File.ReadAllLines(caminhoArquivo);

            }
            catch (FileNotFoundException)
            {
                return false;
            }

            var linhaEncontrada = linhas.FirstOrDefault(
            linha => linha.Split(";")[1] == cpf);

            if (linhaEncontrada != null)
                return true;
            else
                return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Este m�todo est� vazio e pode ser removido se n�o for utilizado
            load_data();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            // Lendo os valores dos textboxes
            string nome = txtNome.Text;
            string cpf = txtCPF.Text;
            string telefone = txtTelefone.Text;
            string endereco = txtEndere�o.Text;

            if (CPFExistente(cpf))
            {
                MessageBox.Show("CPF ja cadastrado");
                return;
            }

            if (!string.IsNullOrEmpty(nome) &&
                !string.IsNullOrEmpty(telefone) &&
                !string.IsNullOrEmpty(endereco) &&
                !string.IsNullOrEmpty(cpf))
            {
                string linha = $"{nome};{cpf};{telefone};{endereco}";

                File.AppendAllLines(caminhoArquivo, new[] { linha });

                MessageBox.Show("Inserido com sucesso!!!");
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cpf = txtCPF.Text;

            if (File.Exists(caminhoArquivo))
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);

                var linhaEncontrada = linhas.FirstOrDefault(
                    linha => linha.Split(';')[1] == cpf);

                if (linhaEncontrada != null)
                {
                    var dados = linhaEncontrada.Split(';');

                    txtNome.Text = dados[0];
                    txtTelefone.Text = dados[2];
                    txtEndere�o.Text = dados[3]; // Adicionando para preencher o endere�o
                }
                else
                {
                    MessageBox.Show("CPF n�o localizado");
                }
            }
            else
            {
                MessageBox.Show("Arquivo de dados n�o encontrado.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string cpf = txtCPF.Text;

            if (File.Exists(caminhoArquivo))
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);
                var linhasAtualizadas = linhas.Where(linha => linha.Split(';')[1] != cpf).ToArray();

                if (linhas.Length != linhasAtualizadas.Length)
                {
                    File.WriteAllLines(caminhoArquivo, linhasAtualizadas);
                    MessageBox.Show("Cadastro exclu�do com sucesso");

                    txtNome.Clear();
                    txtTelefone.Clear();
                    txtEndere�o.Clear();
                    txtCPF.Clear();
                }
                else
                {
                    MessageBox.Show("CPF n�o localizado");
                }
            }
            else
            {
                MessageBox.Show("Arquivo de dados n�o encontrado.");
            }

        }


    }
}
