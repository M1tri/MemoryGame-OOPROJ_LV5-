using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartingWindow
{
    public partial class KreatorKonfiguracije : Form
    {
        public KreatorKonfiguracije()
        {
            InitializeComponent();
        }

        private void NumericEmptys_ValueChanged_1(object sender, EventArgs e)
        {
            NumericUpDown numeric = sender as NumericUpDown;

            if ((float)numeric.Value > (float)(NumericColumns.Value * NumericRows.Value) * 0.15f) 
            {
                numeric.Value = (decimal)((float)(NumericColumns.Value * NumericRows.Value) * 0.15f);

                MessageBox.Show("Broj praznih polja ne moze biti veci od 15% ukupnog broja polja!",
                    "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SacuvajConfigDugme_Click(object sender, EventArgs e)
        {
            int rows = (int)NumericRows.Value;
            int columns = (int)NumericColumns.Value;
            int emptys = (int)NumericEmptys.Value;
            int images = (int)NumericBrSlika.Value;

            if (emptys > columns * rows * 0.15)
            {
                MessageBox.Show("Broj praznih polja ne moze biti veci od 15% ukupnog broja polja!",
                    "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            Konfiguracija config = new Konfiguracija(rows, columns, images, emptys);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files (*.xml)|*.xml";
            saveFileDialog.DefaultExt = ".xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                config.Sacuvaj(fileName);
            }

        }
    }
}
