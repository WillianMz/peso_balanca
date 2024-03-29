namespace PesoBal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private static string GerarCodigoBarras(string codigo)
        {
            decimal soma = 0;
            int[] digitos;
            digitos = new int[13];
            digitos[0] = 0;//nao utilizado

            //adiciona ao array os digitos do codigo informado, ignorando a posicao 0
            for (int i = 0; i < codigo.Length; i++)
            {
                var digito = codigo.Substring(i, 1);
                digitos[i+1] = Convert.ToInt16(digito);
            }

            decimal somaImpar = 0;
            decimal somaPar = 0;

            for (int i = 1; i < 13; i++)
            {
                if ((i % 2) == 0)
                    somaPar += digitos[i] * 3;//par
                else
                    somaImpar += digitos[i] * 1;//impar
            }

            soma += somaPar + somaImpar;
            //O valor total da soma das multiplicações deve ser dividido por 10
            //Transforme o resultado em inteiro, "arredondando" o número para baixo
            var resultado = Math.Floor(soma / 10);
            int resto = (int)(resultado + 1);//Some 1 ao resultado da divisão
            resto *= 10;//Multiplique o resultado dessa soma por 10
            resto = (int)(resto - soma);//Subtraia desse resultado o valor da soma inicial das multiplicações

            //Se o resultado for um múltiplo de 10, o dígito verificador será 0
            if (resto % 10 == 0)
                return "0";
            else
                return resto.ToString();
        }

        public void LerCodigo(bool etiquetaComPeso)
        {
            try
            {
                string codigo = TxtCodigoBarras.Text;
                int prefixo = 2;//digito inicial que identifica um codigo de barras gerado pela balanca.
                int numeroDigitosBalanca = 4;//tamanho do codigo do produto configurado na balança

                if (prefixo == 2)
                {
                    var novoCodigo = codigo.Substring(1, 11);//elimina o prefixo 2 e a ultima posicao que é o digito verificador
                    var codigoProduto = novoCodigo.Substring(0, numeroDigitosBalanca);
                    codigoProduto = codigoProduto.TrimStart('0');//remove os zeros a esquerda

                    //calcular o valor
                    if(etiquetaComPeso)
                    {
                        var valor = novoCodigo.Substring(6, 5);
                        decimal valorProduto = Convert.ToDecimal(valor);
                        valorProduto = valorProduto / 100;

                        //procurar produto na lista e obter o valor do kilo para poder calcular o peso da etiqueta


                        TxtItens.Text += $"{valorProduto}\r\n";
                    }
                    else
                    {
                        //etiqueta com valor total
                        //deve obter o produto e consultar na listao preço do KG
                        //caso nao tenha o valor do KG solicitar ao usuario
                        var peso = novoCodigo.Substring(6, 5);
                        decimal pesoProduto = Convert.ToDecimal(peso);
                        pesoProduto = pesoProduto / 1000;
                        TxtItens.Text += $"{pesoProduto}\r\n";
                    }
                }
                else
                    MessageBox.Show($"Etiqueta não é de balança!");
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro: {ex.Message}");
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            //LerCodigo(TxtCodigoBarras.Text);
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            //teste
            var x = GerarCodigoBarras(TxtCodigoBarras.Text);
            TxtItens.Text += $"Digito verificador: {x}\r\n";
            TxtItens.Text += $"Código: {TxtCodigoBarras.Text+x}\r\n";
        }
    }
}
