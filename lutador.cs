using System.Reflection.Metadata;

namespace poo {
    class Lutador {
        private string nome;
        private string nacionalidade;
        private int idade;
        private float altura;
        private float peso;
        private string categoria;
        private int vitorias;
        private int derrotas;
        private int empates;

        public Lutador(string no, string na, int id, float al, float pe, int vi, int de, int em)
        {
            nome = no;
            nacionalidade = na;
            idade = id;
            altura = al;
            peso = pe;
            categoria = DetermineCategoria(pe);
            vitorias = vi;
            derrotas = de;
            empates = em;
        }


        public void Apresentar() {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Lutador: " + GetNome());
            Console.WriteLine("Origem: " + GetNacionalidade());
            Console.WriteLine(GetIdade() + " anos");
            Console.WriteLine(GetAltura() + "m de Altura");
            Console.WriteLine("Pesando: " + GetPeso() + "Kg");
            Console.WriteLine("Vitorias: " + GetVitorias());
            Console.WriteLine("Empates: " + GetEmpates());
            Console.WriteLine("Derrotas: " + GetDerrotas());
            Console.WriteLine("------------------------------");
        }

        public void Status() {
            Console.WriteLine("------------------------------");
            Console.WriteLine(GetNome());
            Console.WriteLine("Peso: " + GetCategoria());
            Console.WriteLine("Vitórias: " + GetVitorias());
            Console.WriteLine("Empates: " + GetEmpates());
            Console.WriteLine("Derrotas: " + GetDerrotas());
            Console.WriteLine("------------------------------");
        }

        public void GanharLuta() {
            SetVitorias(GetVitorias() + 1);
        }

        public void PerderLuta() {
            SetDerrotas(GetDerrotas() + 1);
        }

        public void EmpatarLuta() {
            SetEmpates(GetEmpates() + 1);
        }

        public string GetNome() {
            return nome;
        }

        public void SetNome(string value) {
            nome = value;
        }

        public string GetNacionalidade() {
            return nacionalidade;
        }

        public void SetNacionalidade(string value) {
            nacionalidade = value;
        }

        public int GetIdade() {
            return idade;
        }

        public void SetIdade(int value) {
            idade = value;
        }

        public float GetAltura() {
            return altura;
        }

        public void SetAltura(float value) {
            altura = value;
        }

        public float GetPeso() {
            return peso;
        }

        public void SetPeso(float value) {
            peso = value;
        }

        public string GetCategoria() {
            return categoria;
        }

        private string DetermineCategoria(float peso) {
            if (peso < 52.2) {
                return "Inválido";
            } else if (peso <= 70.3) {
                return "Leve";
            } else if (peso <= 83.9) {
                return "Médio";
            } else if (peso <= 120.2) {
                return "Pesado";
            } else {
                return "Inválido";
            }
        }

        public int GetVitorias() {
            return vitorias;
        }

        public void SetVitorias(int value) {
            vitorias = value;
        }

        public int GetDerrotas() {
            return derrotas;
        }

        public void SetDerrotas(int value) {
            derrotas = value;
        }

        public int GetEmpates() {
            return empates;
        }

        public void SetEmpates(int value) {
            empates = value;
        }
    }
}