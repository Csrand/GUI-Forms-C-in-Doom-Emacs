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
            // Pega os valores dos campos
            string c1 = this.FindControl<TextBox>("Campo1Box")!.Text!;
            string c2 = this.FindControl<TextBox>("Campo2Box")!.Text!;
            double c3 = double.Parse(this.FindControl<TextBox>("Campo3Box")!.Text!);
            double c4 = double.Parse(this.FindControl<TextBox>("Campo4Box")!.Text!);

            // Cria o objeto da sua classe
            Empregado obj = new Empregado(c1, c2, c3, c4);

            // Mostra os dados
            this.FindControl<TextBlock>("Resultado")!.Text = obj.MostraDados();
        }
    }
}
