using Game.Slicice;
using Game.Zvuci;
using StartingWindow;
using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class MainWindow : Form
    {
        private Button[][] mButtons;
        private MemoryGameInternal mGameInternal;
        private GameCell Selected = null;

        private SoundPlayer mPogodakZvuk;
        private SoundPlayer mPromasajZvuk;
        private SoundPlayer mKrajIgreZvuk;

        public MainWindow(int emptyCount = 0, int imageCount = 7)
        {
            InitializeComponent();

            mPogodakZvuk = new SoundPlayer(PogodakZvuk.correctSoundEf);
            mPromasajZvuk = new SoundPlayer(PromasajZvuk.incorrectSoundEf);
            mKrajIgreZvuk = new SoundPlayer(KrajIgreZvuk.gameEndedSoundEf_wav);
        }

        private void PokreniIgru(int rows, int cols, int emptyCount, int imageCount)
        {
            mGameInternal = new MemoryGameInternal(rows, cols, emptyCount, imageCount, LabelaTajmer);
            mGameInternal.GenerisiRandomIgru();

            PanelDugmica.Controls.Clear();
            PostaviDugmice(rows, cols);
        }

        private void PostaviDugmice(int rows, int cols)
        {
            mButtons = new Button[rows][];
            for (int i = 0; i < rows; i++)
            {
                mButtons[i] = new Button[cols];
            }

            int sirina = 100;
            int visina = 50;
            int razmak = 10;

            PanelDugmica.Controls.Clear();  
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Button btn = new Button();
                    btn.Width = sirina;
                    btn.Height = visina;
                    btn.Top = (i * (sirina + razmak));
                    btn.Left = (j * (sirina + visina));
                    btn.Image = Image.FromFile("C:\\Users\\Dimitrije\\Source\\Repos\\M1tri\\MemoryGame-OOPROJ_LV5-\\Game\\Resources\\unkownIcon.png");
                    btn.Click += DugmeStisnuto;
                    
                    btn.Tag = new Tuple<int, int>(i, j);

                    mButtons[i][j] = btn;
                    PanelDugmica.Controls.Add(btn);
                }
            }
        }
        private async void DugmeStisnuto(object sender, EventArgs e)
        {
            Button dugme = sender as Button;
            if (dugme == null)
                return;

            Tuple<int, int> indeksi = dugme.Tag as Tuple<int, int>;
            if (indeksi == null) 
                return;

            int row = indeksi.Item1;
            int col = indeksi.Item2;

            GameCell celija = mGameInternal.GetCell(row, col);

            if (celija == null)
                return;

            if (celija == Selected)
                return;

            if (celija.State == CELL_STATE.HIDDEN)
            {
                celija.State = CELL_STATE.VISIBLE;
                dugme.Image = Image.FromFile(celija.ImagePath);
                OtkrijDugme(dugme, celija);



                if (celija.ImagePath == "C:\\Users\\Dimitrije\\Source\\Repos\\M1tri\\MemoryGame-OOPROJ_LV5-\\Game\\Resources\\emptyIcon.png")
                    return;

                await Task.Delay(500);

                if (Selected == null)
                {
                    Selected = celija;
                }
                else
                {
                    if (Selected.ImagePath != celija.ImagePath)
                    {
                        SakrijDugme(mButtons[Selected.PosX][Selected.PosY], Selected);

                        SakrijDugme(dugme, celija);

                        mPromasajZvuk.Play();
                    }
                    else
                    {
                        mPogodakZvuk.Play();
                    }

                    Selected = null;
                }
            }
        }
        private void OtkrijDugme(Button dugme, GameCell celija)
        {
            celija.State = CELL_STATE.VISIBLE;
            dugme.Image = Image.FromFile(celija.ImagePath);
        }

        private void SakrijDugme(Button dugme, GameCell celija)
        {
            celija.State = CELL_STATE.HIDDEN;
            dugme.Image = Image.FromFile("C:\\Users\\Dimitrije\\Source\\Repos\\M1tri\\MemoryGame-OOPROJ_LV5-\\Game\\Resources\\unkownIcon.png");
        }

        private void novaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KreatorKonfiguracije kreatorKonfiguracije = new KreatorKonfiguracije();

            kreatorKonfiguracije.Show();
        }

        private void sacuvajTrenutnuIgruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mGameInternal == null)
            {
                return;
            }

            string fileName = null;

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "XML files (*.xml)|*.xml";
            saveFileDialog.DefaultExt = ".xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                mGameInternal.Sacuvaj(fileName);
            }
        }
        private void pokreniSacuvanuIgruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = null;

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "XML files (*.xml)|*.xml";
            ofd.DefaultExt = ".xml";

            if (ofd.ShowDialog() == DialogResult.OK) 
            { 
                fileName = ofd.FileName;
            }
            else
            {
                return;
            }

            mGameInternal = MemoryGameInternal.Ucitaj(fileName);

            PostaviDugmice(mGameInternal.Rows, mGameInternal.Columns);

            for (int i = 0; i < mGameInternal.Rows; i++)
            {
                for (int j = 0; j < mGameInternal.Columns; j++) 
                {
                    GameCell celija = mGameInternal.GetCell(i, j);

                    if (celija.State == CELL_STATE.VISIBLE)
                    {
                        OtkrijDugme(mButtons[celija.PosX][celija.PosY], celija);
                    }
                }
            }

        }
        private void pokreniKonfiguracijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Konfiguracija config = Konfiguracija.Ucitaj("config.xml");

            if (config == null)
            {
                return;
            }

            PokreniIgru(config.Rows, config.Cols, config.EmptyCount, config.ImageCount);
        }
    }
}
