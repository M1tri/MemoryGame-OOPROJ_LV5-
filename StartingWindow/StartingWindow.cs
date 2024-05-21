using Game;
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
    public partial class StartingWindow : Form
    {
        public StartingWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int rows = (int)NumericRows.Value;
            int columns = (int)NumericColumns.Value;
            int emptys = (int)NumericEmptys.Value;

            GameWindow Igra = new GameWindow(rows, columns, emptys);
            Igra.Show();
        }
    }
}
