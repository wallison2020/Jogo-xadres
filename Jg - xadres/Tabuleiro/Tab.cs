namespace tabuleiro{
    class Tabuleiro{
        public int linhas { get; private set; }
        public int colunas { get; private set; }
        private Peca [,] pecas;
        public Tabuleiro(int linhas, int colunas){
            this.linhas = linhas;
            this.colunas = colunas;

            pecas =new Peca[linhas, colunas];
        }


    }
}