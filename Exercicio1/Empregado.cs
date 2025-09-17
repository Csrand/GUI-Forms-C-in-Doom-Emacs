namespace MeuFormulario
{
    public class Empregado
    {
        public string Nome { get; set; }
        public string Departamento { get; set; }
        public double HorasTrabalhadasNoMes { get; set; }
        public double SalarioPorHora { get; set; }

        public Empregado(string nome, string departamento, double horas, double salarioHora)
        {
            Nome = nome;
            Departamento = departamento;
            HorasTrabalhadasNoMes = horas;
            SalarioPorHora = salarioHora;
        }

        public double CalculaSalarioMensal()
        {
            return HorasTrabalhadasNoMes * SalarioPorHora;
        }

        public string MostraDados()
        {
            return $"Nome: {Nome}\nDepartamento: {Departamento}\nSalário: {CalculaSalarioMensal():C}";
        }
    }
}
