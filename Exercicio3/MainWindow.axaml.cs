using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace MeuFormulario
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnExecutar(object sender, RoutedEventArgs e)
        {
            try
            {
                // Pega o valor digitado e tenta converter para inteiro
                string texto = this.FindControl<TextBox>("Campo1Box")!.Text!;
                int lado = int.Parse(texto); // pode lançar exceção se não for número

                // Cria o objeto Quadrado e calcula
                Quadrado obj = new Quadrado(lado);

                // Exibe os resultados
                this.FindControl<TextBlock>("Resultado")!.Text =
                    $"Área: {obj.Area}\nPerímetro: {obj.Perimetro}";
            }
            catch (FormatException)
            {
                // Captura erro de conversão
                this.FindControl<TextBlock>("Resultado")!.Text = "Digite um número válido!";
            }
            catch (Exception ex)
            {
                // Captura qualquer outro erro inesperado
                this.FindControl<TextBlock>("Resultado")!.Text = $"Erro: {ex.Message}";
            }
        }
    }
}
