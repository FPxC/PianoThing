using PianoGameThing.Sounds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace PianoGameThing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SoundPlayer playerC;
        SoundPlayer playerDb;
        SoundPlayer playerD;
        SoundPlayer playerEb;
        SoundPlayer playerE;
        SoundPlayer playerF;
        SoundPlayer playerGb;
        SoundPlayer playerG;
        SoundPlayer playerAb;
        SoundPlayer playerA;
        SoundPlayer playerBb;
        SoundPlayer playerB;

        public MainWindow()
        {
            InitializeComponent();

            playerC = new SoundPlayer(SoundNames.PianoC);
            playerC.Load();
            playerDb = new SoundPlayer(SoundNames.PianoDb);
            playerDb.Load();
            playerD = new SoundPlayer(SoundNames.PianoD);
            playerD.Load();
            playerEb = new SoundPlayer(SoundNames.PianoEb);
            playerEb.Load();
            playerE = new SoundPlayer(SoundNames.PianoE);
            playerE.Load();
            playerF = new SoundPlayer(SoundNames.PianoF);
            playerF.Load();
            playerGb = new SoundPlayer(SoundNames.PianoGb);
            playerGb.Load();
            playerG = new SoundPlayer(SoundNames.PianoG);
            playerG.Load();
            playerAb = new SoundPlayer(SoundNames.PianoAb);
            playerAb.Load();
            playerA = new SoundPlayer(SoundNames.PianoA);
            playerA.Load();
            playerBb = new SoundPlayer(SoundNames.PianoBb);
            playerBb.Load();
            playerB = new SoundPlayer(SoundNames.PianoB);
            playerB.Load();
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            playerC.Play();
        }

        private void Db_Click(object sender, RoutedEventArgs e)
        {
            playerDb.Play();
        }

        private void D_Click(object sender, RoutedEventArgs e)
        {
            playerD.Play();
        }

        private void Eb_Click(object sender, RoutedEventArgs e)
        {
            playerEb.Play();
        }
        private void E_Click(object sender, RoutedEventArgs e)
        {
            playerE.Play();
        }

        private void F_Click(object sender, RoutedEventArgs e)
        {
            playerF.Play();
        }

        private void Gb_Click(object sender, RoutedEventArgs e)
        {
            playerGb.Play();
        }

        private void G_Click(object sender, RoutedEventArgs e)
        {
            playerG.Play();
        }

        private void Ab_Click(object sender, RoutedEventArgs e)
        {
            playerAb.Play();
        }

        private void A_Click(object sender, RoutedEventArgs e)
        {
            playerA.Play();
        }

        private void Bb_Click(object sender, RoutedEventArgs e)
        {
            playerBb.Play();
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            playerB.Play();
        }
    }
}
