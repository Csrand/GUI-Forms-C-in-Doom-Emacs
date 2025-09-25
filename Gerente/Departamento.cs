namespace MeuFormulario
{
    public class Departamento
    {
        private int CodigoDptmt;
        private int QtdFunc;
        private string NomeDptmt;

        public Departamento() { }

        public Departamento(int codigoDptmt, int qtdFunc, string nomeDptmt)
        {
            this.CodigoDptmt = codigoDptmt;
            this.QtdFunc = qtdFunc;
            this.NomeDptmt = nomeDptmt;
        }
        //get
        public int GetCodigoDptmt()=> this.CodigoDptmt;

        public string GetNomeDptmt()=> this.NomeDptmt;



        public int GetQtdFunc() => this.QtdFunc;

        //set
        public void SetCodigoDptmt(int codigoDptmt) => this.CodigoDptmt = codigoDptmt;

        public void SetNomeDptmt(string nomeDptmt) => this.NomeDptmt = nomeDptmt;

        public void SetQtdFunc(int qtdFunc) => this.QtdFunc = qtdFunc;
        //imprimir
        public string Imprimir() => $"Nome: {NomeDptmt}, Código: {CodigoDptmt}, Qtd Funcionários: {QtdFunc}";
    }
}
