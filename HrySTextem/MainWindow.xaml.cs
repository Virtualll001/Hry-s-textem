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

namespace HrySTextem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Stringy stringy;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            stringy = new Stringy(zadejTextBox.Text, vyhledejTextBox.Text);

            xKratTextBlock.Text = stringy.NajdiHledane();
            velkaTextBlock.Text = zadejTextBox.Text.ToString().ToUpper();
            malaTextBlock.Text = zadejTextBox.Text.ToString().ToLower();
            prevracenaTextBlock.Text = stringy.MalaNaVelka();
            otocSlovaTextBlock.Text = stringy.OtocenaSlova();
            otocPismenaTextBlock.Text = stringy.OtocenaPismena();
            otocVetaTextBlock.Text = stringy.OtocenaVeta();
            prvniZnakVetaTextBlock.Text = zadejTextBox.Text[0].ToString();
            posledniZnakVetaTextBlock.Text = zadejTextBox.Text[zadejTextBox.Text.Length - 1].ToString();
            pocetSlovTextBlock.Text = stringy.PocetSlov();
            pocetZnakuTextBlock.Text = stringy.PocetZnaku();
            nejdelsiTextBlock.Text = stringy.Nejdelsi();
            samohlaskyTextBlock.Text = stringy.Analyzuj()[0];
            dlouhSamohlTextBlock.Text = stringy.Analyzuj()[1];
            souhlaskyTextBlock.Text = stringy.Analyzuj()[2];
            tvrdeSouhlTextBlock.Text = stringy.Analyzuj()[3];
            mekkeSouhlTextBlock.Text = stringy.Analyzuj()[4];
            dalsiTextBlock.Text = stringy.Analyzuj()[5];
            cislaTextBlock.Text = stringy.Analyzuj()[6];
            zavorkyTextBlock.Text = stringy.Analyzuj()[7];
            znakyTextBlock.Text = stringy.Analyzuj()[8];
            morseTextBlock.Text = stringy.Morseovka();
        }
    }
}
