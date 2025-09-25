using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace MeuFormulario
{
    public partial class MainWindow : Window
    {
        private Departamento? departamento1;
        private Departamento? departamento2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (departamento1 == null)
                {
                    departamento1 = new Departamento(
                        int.Parse(CodigoBox.Text!),
                        int.Parse(QtdBox.Text!),
                        NomeBox.Text!
                    );
                    Resultado.Text = "Primeiro departamento cadastrado! Digite o segundo.";
                }
                else if (departamento2 == null)
                {
                    // Segundo departamento: construtor padrão + setters
                    departamento2 = new Departamento();
                    departamento2.SetCodigoDptmt(int.Parse(CodigoBox.Text!));
                    departamento2.SetQtdFunc(int.Parse(QtdBox.Text!));
                    departamento2.SetNomeDptmt(NomeBox.Text!);
                    Resultado.Text = "Segundo departamento cadastrado!";
                }
                else
                {
                    Resultado.Text = "Os dois departamentos já foram cadastrados!";
                    return;
                }

                // Limpar campos
                NomeBox.Text = "";
                CodigoBox.Text = "";
                QtdBox.Text = "";
                NomeBox.Focus();
            }
            catch (FormatException)
            {
                Resultado.Text = "Digite números válidos em Código Departamento e Qtd Funcionários!";
            }
        }

        private void BtnImprimir_Click(object sender, RoutedEventArgs e)
        {
            if (departamento1 == null || departamento2 == null)
            {
                Resultado.Text = "Cadastre os dois departamentos primeiro!";
                return;
            }

            string maisFuncionarios;

            if (departamento1.GetQtdFunc() > departamento2.GetQtdFunc())
                maisFuncionarios = departamento1.GetNomeDptmt();
            else if (departamento2.GetQtdFunc() > departamento1.GetQtdFunc())
                maisFuncionarios = departamento2.GetNomeDptmt();
            else
                maisFuncionarios = "Ambas têm o mesmo número de funcionários";

            Resultado.Text =
                $"Departamento 1:\n{departamento1.Imprimir()}\n\n" +
                $"Departamento 2:\n{departamento2.Imprimir()}\n\n" +
                $"Mais Funcionários: {maisFuncionarios}";
        }
    }
}
