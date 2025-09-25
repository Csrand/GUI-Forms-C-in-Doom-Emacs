namespace MeuFormulario
{
    public class Pessoa
    {
        private int Idade;
        private string Nome;

        public Pessoa() { }

        public Pessoa(string nome,int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
        //get
        public int GetIdade() => this.Idade;

        public string GetNome() => this.Nome;

        //set
        public void SetIdade(int idade) => this.Idade = idade;

        public void SetNome(string nome) => this.Nome = nome;

        //imprimir
        public string Imprimir() => $"Nome: {Nome}, Idade: {Idade}";
    }
}
