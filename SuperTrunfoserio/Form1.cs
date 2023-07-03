namespace SuperTrunfoserio
{
    public partial class Form1 : Form
    {
        private List<Cartas> Baralho;
        private List<Cartas> cartasjogador;
        private List<Cartas> cartasmaquina;

        public Form1()//construtor
        {
            InitializeComponent();
            cartasmaquina = new List<Cartas>();
            cartasjogador = new List<Cartas>();
            Baralho = new List<Cartas>
            {
                //criando objetos para cada personagem
                new Cartas("Vasco da Gama", 6, 56, 4, 20000, @"F:\Trabalhos\SuperTrunfoserio\IMANGES CARTAS\VASCO.png"),
                new Cartas("Botafogo", 2, 80, 2, 46000, @"F:\Trabalhos\SuperTrunfoserio\IMANGES CARTAS\BOTAFOGO.png"),
                new Cartas("Fluminense", 3, 85, 4, 8000, @"F:\Trabalhos\SuperTrunfoserio\IMANGES CARTAS\FLUMINENSE.png"),
                new Cartas("Flamengo", 21, 90, 8, 4000, @"F:\Trabalhos\SuperTrunfoserio\IMANGES CARTAS\FLAMENGO.png"),
                new Cartas("Palmeiras", 8, 90, 11, 43000, @"F:\Trabalhos\SuperTrunfoserio\IMANGES CARTAS\PALMEIRAS.png"),
                new Cartas("Corinthians", 14, 68, 7, 49000, @"F:\Trabalhos\SuperTrunfoserio\IMANGES CARTAS\CORINTHIANS.png"),
                new Cartas("Santos", 3, 60, 8, 16000, @"F:\Trabalhos\SuperTrunfoserio\IMANGES CARTAS\SANTOS.png"),
                new Cartas("São Paulo", 9, 74, 6, 66000, @"F:\Trabalhos\SuperTrunfoserio\IMANGES CARTAS\SÃO PAULO.png")


            };

            Prxrodada.Visible = false;
            btnComparar.Visible = false;
            qtdjogador.Visible = false;
            qtdmaquina.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;

        }



        public void BtnSortearcartas(object sender, EventArgs e)
        {
            Random random = new Random();
            List<int> igualI = new List<int>();// usado para que não caia a mesma carta nos dois baralhos
            int i = 0;
            while (Baralho.Count > 0)
            {
                int index1 = random.Next(Baralho.Count);
                if (!cartasjogador.Contains(Baralho[index1]) & !igualI.Contains(index1) & cartasjogador.Count != 4)
                {
                    cartasjogador.Add(Baralho[index1]);
                    igualI.Add(index1);
                    if (cartasmaquina.Count == 4 & cartasjogador.Count == 4)
                    {
                        break;
                    }
                    pictureBox2.Image = cartasjogador[i].Imagem;

                    i++;
                }

                index1 = random.Next(Baralho.Count);
                if (!cartasmaquina.Contains(Baralho[index1]) & !igualI.Contains(index1) & cartasmaquina.Count != 4)
                {
                    cartasmaquina.Add(Baralho[index1]);
                    igualI.Add(index1);
                    if (cartasmaquina.Count == 4 & cartasjogador.Count == 4)
                    {
                        break;
                    }
                }

            }
            Prxrodada.Visible = true;
            btnComparar.Visible = true;
            label1.Visible = false;
            Sortearcartas.Visible = false;
            pictureBox1.Visible = true;
            qtdjogador.Visible = true;
            qtdmaquina.Visible = true;
            ProximaRodada(sender, new EventArgs());
        }


        public async void BtnComparar(object sender, EventArgs e)
        {
            // Verifica se há personagens sorteados
            if (pictureBox2.Visible == true)
            {
                MessageBox.Show("Clique em Proxima Rodada antes de comparar.");
                return;
            }

            // tem os índices dos personagens selecionados
            int index1 = (int)pictureBox1.Tag;
            int index2 = (int)pictureBox2.Tag;
            pictureBox2.Visible = true;
            //tem os personagens correspondentes aos índices na lista
            Cartas personagem1 = cartasjogador[index1];
            Cartas personagem2 = cartasmaquina[index2];


            List<RadioButton> listaAtributos = new List<RadioButton>
            {
                Atributo1,
                Atributo2,
                Atributo3,
                Atributo4,
            };


            if (listaAtributos[0].Checked)
            {
                {
                    if (personagem1.Torcida > personagem2.Torcida)
                    {
                        MessageBox.Show("você venceu");
                        cartasjogador.Add(cartasmaquina[index2]);
                        cartasmaquina.Remove(cartasmaquina[index2]);
                    }
                    else if (personagem1.Torcida == personagem2.Torcida)
                    {
                        MessageBox.Show("empate");
                    }
                    else
                    {
                        MessageBox.Show("você perdeu");
                        cartasmaquina.Add(cartasjogador[index1]);
                        cartasjogador.Remove(cartasjogador[index1]);
                    }
                }
            }
            if (listaAtributos[1].Checked)
            {
                {
                    if (personagem1.QualidadeTime > personagem2.QualidadeTime)
                    {
                        MessageBox.Show("você venceu");
                        cartasjogador.Add(cartasmaquina[index2]);
                        cartasmaquina.Remove(cartasmaquina[index2]);
                    }
                    else if (personagem1.QualidadeTime == personagem2.QualidadeTime)
                    {
                        MessageBox.Show("empate");
                    }
                    else
                    {
                        MessageBox.Show("você perdeu");
                        cartasmaquina.Add(cartasjogador[index1]);
                        cartasjogador.Remove(cartasjogador[index1]);
                    }
                }
            }
            if (listaAtributos[2].Checked)
            {
                {
                    if (personagem1.Titulos > personagem2.Titulos)
                    {
                        MessageBox.Show("você venceu");
                        cartasjogador.Add(cartasmaquina[index2]);
                        cartasmaquina.Remove(cartasmaquina[index2]);
                    }
                    else if (personagem1.Titulos == personagem2.Titulos)
                    {
                        MessageBox.Show("empate");
                    }
                    else
                    {
                        MessageBox.Show("você perdeu");
                        cartasmaquina.Add(cartasjogador[index1]);
                        cartasjogador.Remove(cartasjogador[index1]);
                    }
                }
            }
            if (listaAtributos[3].Checked)
            {
                {
                    if (personagem1.Estadio > personagem2.Estadio)
                    {
                        MessageBox.Show("você venceu");
                        cartasjogador.Add(cartasmaquina[index2]);
                        cartasmaquina.Remove(cartasmaquina[index2]);
                    }
                    else if (personagem1.Estadio == personagem2.Estadio)
                    {
                        MessageBox.Show("empate");
                    }
                    else
                    {
                        MessageBox.Show("você perdeu");
                        cartasmaquina.Add(cartasjogador[index1]);
                        cartasjogador.Remove(cartasjogador[index1]);
                    }
                }
            }
            qtdjogador.Text = $"O JOGADOR POSSUI {cartasjogador.Count} CARTAS";
            qtdmaquina.Text = $"A MAQUINA POSSUI {cartasmaquina.Count} CARTAS";
            if (cartasmaquina.Count == 0)
            {
                pictureBox1.Visible = false; pictureBox2.Visible = false;
                Atributo1.Visible = false; Atributo2.Visible = false;
                Atributo3.Visible = false; Atributo4.Visible = false;
                Prxrodada.Visible = false; btnComparar.Visible = false;
                qtdjogador.Visible = false; qtdmaquina.Visible = false;
                MessageBox.Show("Parabens voce venceu o jogo");
                this.Hide();
                Form f = new Form2();
                f.Closed += (s, args) => this.Close();
                f.Show();
            }
            else if (cartasjogador.Count == 0)
            {
                pictureBox1.Visible = false; pictureBox2.Visible = false;
                Atributo1.Visible = false; Atributo2.Visible = false;
                Atributo3.Visible = false; Atributo4.Visible = false;
                Prxrodada.Visible = false; btnComparar.Visible = false;
                qtdjogador.Visible = false; qtdmaquina.Visible = false;
                MessageBox.Show("Infelizmente você perdeu");
                this.Hide();
                Form f = new Form2();
                f.Closed += (s, args) => this.Close();
                f.Show();
            }

        }
        private void Atributo1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void ProximaRodada(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == false)
            {
                MessageBox.Show("Voce nao pode trocar sua carta antes de comparar");
                return;
            }
            Random random = new Random();
            int index1 = random.Next(cartasjogador.Count);
            int index2 = random.Next(cartasmaquina.Count);


            Cartas personagem1 = cartasjogador[index1];
            Cartas personagem2 = cartasmaquina[index2];



            pictureBox1.Image = Image.FromFile(personagem1.CaminhoImagem);
            pictureBox1.Tag = index1;
            pictureBox2.Image = Image.FromFile(personagem2.CaminhoImagem);
            pictureBox2.Tag = index2;// Armazena o índice do personagem em Tag
            pictureBox2.Visible = false;
            // Armazena o índice do personagem em Tag

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Width = 332;
            pictureBox1.Height = 428;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Width = 332;
            pictureBox2.Height = 438;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}