using NAudio.Wave;
using PianoGameThing.Sounds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
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
        /*SoundPlayer playerC;
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
        SoundPlayer playerB;*/

        AudioPlaybackEngine audioEngine;

        CachedSound pianoC;
        CachedSound pianoDb;
        CachedSound pianoD;
        CachedSound pianoEb;
        CachedSound pianoE;
        CachedSound pianoF;
        CachedSound pianoGb;
        CachedSound pianoG;
        CachedSound pianoAb;
        CachedSound pianoA;
        CachedSound pianoBb;
        CachedSound pianoB;

        public MainWindow()
        {
            InitializeComponent();

            audioEngine = new AudioPlaybackEngine();

            pianoC = new CachedSound(SoundNames.PianoC);
            pianoDb = new CachedSound(SoundNames.PianoDb);
            pianoD = new CachedSound(SoundNames.PianoD);
            pianoEb = new CachedSound(SoundNames.PianoEb);
            pianoE = new CachedSound(SoundNames.PianoE);
            pianoF = new CachedSound(SoundNames.PianoF);
            pianoGb = new CachedSound(SoundNames.PianoGb);
            pianoG = new CachedSound(SoundNames.PianoG);
            pianoAb = new CachedSound(SoundNames.PianoAb);
            pianoA = new CachedSound(SoundNames.PianoA);
            pianoBb = new CachedSound(SoundNames.PianoBb);
            pianoB = new CachedSound(SoundNames.PianoB);

            /*playerC = new SoundPlayer(SoundNames.PianoC);
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
            playerB.Load();*/
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            //playerC.Play();

            audioEngine.PlaySound(pianoC);
        }

        private void Db_Click(object sender, RoutedEventArgs e)
        {
            //playerDb.Play();

            audioEngine.PlaySound(pianoDb);
        }

        private void D_Click(object sender, RoutedEventArgs e)
        {
            //playerD.Play();

            audioEngine.PlaySound(pianoD);
        }

        private void Eb_Click(object sender, RoutedEventArgs e)
        {
            //playerEb.Play();

            audioEngine.PlaySound(pianoEb);
        }
        private void E_Click(object sender, RoutedEventArgs e)
        {
            //playerE.Play();

            audioEngine.PlaySound(pianoE);
        }

        private void F_Click(object sender, RoutedEventArgs e)
        {
            //playerF.Play();

            audioEngine.PlaySound(pianoF);
        }

        private void Gb_Click(object sender, RoutedEventArgs e)
        {
            //playerGb.Play();

            audioEngine.PlaySound(pianoGb);
        }

        private void G_Click(object sender, RoutedEventArgs e)
        {
            //playerG.Play();

            audioEngine.PlaySound(pianoG);
        }

        private void Ab_Click(object sender, RoutedEventArgs e)
        {
            //playerAb.Play();

            audioEngine.PlaySound(pianoAb);
        }

        private void A_Click(object sender, RoutedEventArgs e)
        {
            //playerA.Play();

            audioEngine.PlaySound(pianoA);
        }

        private void Bb_Click(object sender, RoutedEventArgs e)
        {
            //playerBb.Play();

            audioEngine.PlaySound(pianoBb);
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            //playerB.Play();

            audioEngine.PlaySound(pianoB);
        }
    }
}
