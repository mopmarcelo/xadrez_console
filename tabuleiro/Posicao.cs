namespace tabuleiro
{
    public class Posicao
    {
        public int linha { get; set; }
        public int coluna { get; set; }

        public Posicao(int _linha, int _coluna)
        {
            linha = _linha;
            coluna = _coluna;
        }

        public void definirValores(int _linha, int _coluna)
        {
            linha = _linha;
            coluna = _coluna;
        }

        public override string ToString() => linha + ", " + coluna;
    }
}
