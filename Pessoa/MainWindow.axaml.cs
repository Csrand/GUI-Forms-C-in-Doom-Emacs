using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace MeuFormulario
{
    public partial class MainWindow : Window
    {
        private Pessoa? pessoa1;
        private Pessoa? pessoa2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (pessoa1 == null)
                {
                    pessoa1 = new Pessoa(
                        NomeBox.Text!,
                        int.Parse(IdadeBox.Text!)
                    );
                    Resultado.Text = "Primeira pessoa cadastrada! Digite a segunda.";
                }
                else if (pessoa2 == null)
                {
                    // Segundo pessoa: construtor padrão + setters
                    pessoa2 = new Pessoa();
                    pessoa2.SetNome(NomeBox.Text!);
                    pessoa2.SetIdade(int.Parse(IdadeBox.Text!));
                    Resultado.Text = "Segunda pessoa cadastrada!";
                }
                else
                {
                    Resultado.Text = "Os dois pessoas já foram cadastrados!";
                    return;
                }

                // Limpar campos
                NomeBox.Text = "";
                IdadeBox.Text = "";
                NomeBox.Focus();
            }
            catch (FormatException)
            {
                Resultado.Text = "Digite números válidos para as idades das pessoas";
            }
        }

        private void BtnImprimir_Click(object sender, RoutedEventArgs e)
        {
            if (pessoa1 == null || pessoa2 == null)
            {
                Resultado.Text = "Cadastre as duas pessoas primeiro!";
                return;
            }

            string maisVelho;
            if (pessoa1.GetIdade() > pessoa2.GetIdade())
                maisVelho = pessoa1.GetNome();
            else if
                (pessoa2.GetIdade() > pessoa1.GetIdade())
                maisVelho = pessoa2.GetNome();
            else
                maisVelho = "As duas pessoas tem a mesma idade";

            Resultado.Text =
                $"Pessoa 1:\n{pessoa1.Imprimir()}\n\n" +
                $"Pessoa 2:\n{pessoa2.Imprimir()}\n\n"+
                $"Resultado Sobre quem e mais velho:\n{maisVelho}";
        }
    }
}
