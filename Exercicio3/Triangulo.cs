namespace MeuFormulario
{
    public class Quadrado
    {
        public int Lado { get; set; }
        public int Area { get; private set; }
        public int Perimetro { get; private set; }

        public Quadrado(int lado)
        {
            Lado = lado;
            calcularArea();
            calcularPerimetro();
        }

        public void calcularArea()
        {
            Area = Lado * Lado;
        }

        public void calcularPerimetro()
        {
            Perimetro = Lado * 4;
        }

        public string imprimir()
        {
            return $"Lado: {Lado}\nArea: {Area}\nPerimetro: {Perimetro}";
        }
    }
}
