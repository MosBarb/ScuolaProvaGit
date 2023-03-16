using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ScuolaRecuperoGit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnCercaAlunno_Click(object sender, RoutedEventArgs e)
        {
            Alunno a = new Alunno();

           int eta =  Convert.ToInt32( txboxEtàCercare.Text);

            for (int i = 0; i < Alunni.lenght; i++)
            {
                if (eta == a.età)
                {
                    studente_trovato.Text = a.Nome; 
                }
            }
        }

        private void btnAggiungiAlunno_Click(object sender, RoutedEventArgs e)
        {
            Alunno a = new Alunno();

            a.Nome = txboxNomeAlunno.Text;
            a.Cognome = txboxCognomeAlunno.Text;
            a.Età = Convert.ToInt32(txboxetàAlunno.Text);
            a.Città = txboxCittàAlunno.Text;

            //aggiungere l'allunno alla lista degli studenti quando sarà disponibile

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Alunno a = new Alunno();
            a.Classi();

        }
    }
}
