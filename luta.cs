namespace poo {
    class Luta {
        private Lutador desafiado;
        private Lutador desafiante;
        private int round;
        private bool aprovada;

    public Luta() {
        desafiado = new Lutador("Desafiado", "Categoria", 0, 0.0f, 0.0f, 0, 0, 0); // Inicialize com valores padrão
        desafiante = new Lutador("Desafiante", "Categoria", 0, 0.0f, 0.0f, 0, 0, 0); // Inicialize com valores padrão
        aprovada = false;
    }

        public void MarcarLuta(Lutador l1, Lutador l2) {
            if(l1.GetCategoria() == l2.GetCategoria() && l1 != l2) {
                SetAprovada(true);
                desafiado = l1;
                desafiante = l2;
                Console.WriteLine("Luta aprovada!");
            } else {
                SetAprovada(false);
                Console.WriteLine("Essa luta não pode acontecer!");
            }
        }

        public void Lutar() {
            if(aprovada) {
                Console.WriteLine("----== Desafiado ==----");
                desafiado.Apresentar();
                Console.WriteLine("----== Desafiante ==----");
                desafiante.Apresentar();

                Random aleatorio = new Random();
                int vencedor = aleatorio.Next(3);

                Console.WriteLine("---====== RESULTADO ======---");
                switch(vencedor) {
                    case 0:
                        Console.WriteLine("Empatou!");
                        desafiado.EmpatarLuta();
                        desafiante.EmpatarLuta();
                    break;
                    case 1:
                        Console.WriteLine("O lutador " + desafiado.GetNome() + " venceu a luta");
                        desafiado.GanharLuta();
                        desafiante.PerderLuta();
                    break;
                    case 2:
                        Console.WriteLine("O lutador " + desafiante.GetNome() + " venceu a luta");
                        desafiante.GanharLuta();
                        desafiado.PerderLuta();
                    break;
                }
                Console.WriteLine("---====== RESULTADO ======---");
            } else {
                Console.WriteLine("Esta luta não pode acontecer.");
            }
        }

        public void SetDesafiado(Lutador desafiado) {
            this.desafiado = desafiado;
        }

        public Lutador GetDesafiado() {
            return this.desafiado;
        }

        public void SetDesafiante(Lutador desafiante) {
            this.desafiante = desafiante;
        }

        public Lutador GetDesafiante() {
            return this.desafiante;
        }

        public void SetRound(int round) {
            this.round = round;
        }

        public int GetRound() {
            return this.round;
        }

        public void SetAprovada(bool aprovada) {
            this.aprovada = aprovada;
        }

        public bool GetAprovada() {
            return this.aprovada;
        }
    }
}