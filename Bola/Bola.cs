namespace MeuFormulario
{
    public class Bola
    {
        private string Cor;
        private float Circunferencia;
        private string Material;

        public Bola() { }

        public Bola(string cor,float circunferencia, string material)
        {
            this.Cor = cor;
            this.Circunferencia = circunferencia;
            this.Material = material;
        }
        //get
        public float GetCircunferencia() => this.Circunferencia;

        public string GetCor() => this.Cor;

        public string GetMaterial() => this.Material;

        //set
        public void SetCircunferencia(float circunferencia) => this.Circunferencia = circunferencia;

        public void SetCor(string cor) => this.Cor = cor;

        public void SetMaterial(string material) => this.Material = material;

        //imprimir
        public string Imprimir() => $"Cor: {Cor}, Circunferencia: {Circunferencia} Material: {Material}";
    }
}
