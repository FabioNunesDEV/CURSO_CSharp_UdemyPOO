namespace tabuleiro
{
    class Peca
    {
        public Posicao posiao { get; set; }
        public Tabuleiro tabuleiro { get; protected set; }
        public Cor cor { get; protected set; }
        public int gteMovimentos { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            this.posiao = null;
            this.tabuleiro = tabuleiro;
            this.cor = cor;
            this.gteMovimentos = 0;
        }
    }

}
