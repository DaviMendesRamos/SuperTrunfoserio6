using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTrunfoserio
{
    public class Cartas
    {
        public string Nome { get; set; }
        public int Torcida { get; set; }
        public int QualidadeTime { get; set; }
        public int Titulos { get; set; }
        public int Estadio { get; set; }


        public string CaminhoImagem { get; set; }
        public Image Imagem { get; set; }

        public Cartas(string nome, int torcida, int qualidade, int titulos, int estadio, string caminhodaimagem)
        {
            Nome = nome;
            Torcida = torcida;
            QualidadeTime = qualidade;
            Titulos = titulos;
            Estadio = estadio;
            CaminhoImagem = caminhodaimagem;
            Imagem = null;
        }
    }
}
