using Game.Slicice;
using StartingWindow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class GameWindow : Form
    {
        private int mRows;
        private int mCols;
        private Button[][] mButtons;
        private MemoryGameInternal mGameInternal;
        private GameCell Selected = null;

        public GameWindow(int rows = 6, int columns = 5, int emptys = 0)
        {
            InitializeComponent();
            mRows = rows;
            mCols = columns;

            mButtons = new Button[mRows][];
            for (int i = 0; i < rows; i++) 
            {
                mButtons[i] = new Button[mCols];
            }

            mGameInternal = new MemoryGameInternal(rows, columns, emptys);

            PostaviDugmice();
        }

        private void PostaviDugmice()
        {
            int sirina = 100;
            int visina = 50;
            int razmak = 10;

            for (int i = 0; i < mRows; i++)
            {
                for (int j = 0; j < mCols; j++)
                {
                    Button btn = new Button();
                    btn.Width = sirina;
                    btn.Height = visina;
                    btn.Top = (i * (sirina + razmak));
                    btn.Left = (j * (sirina + visina));
                    btn.Image = unkownIcon.Icon;
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
                dugme.Image = celija.Content;

                if (PorediSlike(emptyIcon.Icon, celija.Content))
                    return;

                await Task.Delay(500);

                if (Selected == null)
                {
                    Selected = celija;
                }
                else
                {
                    if (!PorediSlike(Selected.Content, celija.Content))
                    {
                        Selected.State = CELL_STATE.HIDDEN;
                        mButtons[Selected.Xpos][Selected.Ypos].Image = unkownIcon.Icon;

                        celija.State = CELL_STATE.HIDDEN;
                        mButtons[celija.Xpos][celija.Ypos].Image = unkownIcon.Icon;
                    }

                    Selected = null;
                }
            }

            if (IsOver())
            {
                MessageBox.Show("Kraj igre");
                this.Close();
            }

        }

        public bool IsOver()
        {
            for (int i = 0; i < mRows; i++)
            {
                for (int j = 0; j < mCols; j++) 
                {
                    if (mGameInternal.GetCell(i, j).State == CELL_STATE.HIDDEN)
                        return false;
                }
            }

            return true;
        }

        private static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        
        private static bool PorediSlike(Image slika1, Image slika2)
        {
            byte[] slika1Bajtovi = ImageToByteArray(slika1);
            byte[] slika2Bajtovi = ImageToByteArray(slika2);

            if (slika1Bajtovi.Length != slika2Bajtovi.Length)
                return false;

            for (int i = 0; i < slika1Bajtovi.Length; i++) 
            {
                if (slika1Bajtovi[i] != slika2Bajtovi[i])
                    return false;
            }

            return true;
        }

    }
}
