using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace MeuFormulario
{
    public partial class MainWindow : Window
    {
        private Bola? bola1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (bola1 == null)
                {
                    bola1 = new Bola(
                        CorBox.Text!,
                        float.Parse(CircunferenciaBox.Text!),
                        MaterialBox.Text!
                    );
                    Resultado.Text = "Primeira bola cadastrada!";
                }
                else
                {
                    Resultado.Text = " a primeira bola já foi cadastrados!";
                    return;
                }

                // Limpar campos
                CorBox.Text = "";
                CircunferenciaBox.Text = "";
                MaterialBox.Text = "";
                CorBox.Focus();
            }
            catch (FormatException)
            {
                Resultado.Text = "Digite números válidos para as circunferencia da bola";
            }
        }

        private void BtnImprimir_Click(object sender, RoutedEventArgs e)
        {

            Resultado.Text = $"Bola 1:\n{bola1.Imprimir()}\n\n";
        }
    }
}
