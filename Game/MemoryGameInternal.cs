using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using Game.Slicice;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace StartingWindow
{
    public enum CELL_STATE
    {
        HIDDEN,
        VISIBLE,
        SELECTED
    }

    [Serializable]
    public class GameCell
    {
        private CELL_STATE state;
        private int posX;
        private int posY;
        private string imagePath;
        public int PosX
        {
            get { return posX; }
            set { posX = value; }
        }

        public int PosY
        {
            get { return posY; }
            set { posY = value; }
        }

        public CELL_STATE State
        {
            get { return state; }
            set { state = value; }
        }

        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }

        public GameCell(int xPos, int yPos, string image = "C:\\Users\\Dimitrije\\source\\repos\\MemoryGame(OOPROJ_LV5)\\Game\\Resources\\emptyIcon.png")
        {
            posX = xPos;
            posY = yPos;
            imagePath = image;
        }

        public GameCell()
        { }
    }

    [Serializable]
    public class GameCellListWrapper
    {
        private List<GameCell> cells;

        public List<GameCell> Cells
        {
            get { return cells; } set { cells = value; }
        }

        public GameCellListWrapper(List<GameCell> cells)
        {
            this.cells = cells;
        }

        public GameCellListWrapper() {}

        public GameCell GetCell(int i)
        {
            return cells[i];
        }

        public void setCell(GameCell celija, int i)
        {
            cells[i] = celija;
        }

    }

    [Serializable]
    public class MemoryGameInternal
    {
        private int rows;
        private int cols;
        private int emptyCellCount;
        private int imageCount;
        private List<GameCellListWrapper> cells;

        private List<List<GameCell>> list;

        private Random mRandomGenerator;

        private static string[] ImagePaths = {

        "C:\\Users\\Dimitrije\\source\\repos\\MemoryGame(OOPROJ_LV5)\\Game\\Resources\\cpuIcon.png",
        "C:\\Users\\Dimitrije\\source\\repos\\MemoryGame(OOPROJ_LV5)\\Game\\Resources\\gpuIcon.png",
        "C:\\Users\\Dimitrije\\source\\repos\\MemoryGame(OOPROJ_LV5)\\Game\\Resources\\ramIcon.png",
        "C:\\Users\\Dimitrije\\source\\repos\\MemoryGame(OOPROJ_LV5)\\Game\\Resources\\ssdIcon.png",
        "C:\\Users\\Dimitrije\\source\\repos\\MemoryGame(OOPROJ_LV5)\\Game\\Resources\\hddIcon.png",
        "C:\\Users\\Dimitrije\\source\\repos\\MemoryGame(OOPROJ_LV5)\\Game\\Resources\\keyboardIcon.png",
        "C:\\Users\\Dimitrije\\source\\repos\\MemoryGame(OOPROJ_LV5)\\Game\\Resources\\monitorIcon.png",
        "C:\\Users\\Dimitrije\\source\\repos\\MemoryGame(OOPROJ_LV5)\\Game\\Resources\\fanIcon.png",
        "C:\\Users\\Dimitrije\\source\\repos\\MemoryGame(OOPROJ_LV5)\\Game\\Resources\\psuIcon.png",
        "C:\\Users\\Dimitrije\\source\\repos\\MemoryGame(OOPROJ_LV5)\\Game\\Resources\\mouseIcon.png",
        "C:\\Users\\Dimitrije\\source\\repos\\MemoryGame(OOPROJ_LV5)\\Game\\Resources\\headphonesIcon.png"

        };

        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }
        public int Columns
        {
            get { return cols; }
            set { cols = value; }
        }
        public int EmptyCellCount
        {
            get { return emptyCellCount; }
            set { emptyCellCount = value; }
        }

        public int ImageCount
        {
            get { return imageCount; }
            set { imageCount = value; }
        }

        public List<GameCellListWrapper> Cells
        {
            get { return cells;  } 
            set { cells = value; }
        }

        public MemoryGameInternal(int rows = 0, int cols = 0, int emptyCellCount = 0, int imageCount = 0)
        {
            this.rows = rows;
            this.cols = cols;
            this.emptyCellCount = emptyCellCount;
            this.imageCount = imageCount;
            mRandomGenerator = new Random(DateTime.Now.Second);
        }

        public MemoryGameInternal() 
        {
            mRandomGenerator = new Random(DateTime.Now.Second);
            cells = new List<GameCellListWrapper>();
        }

        public void GenerisiRandomIgru()
        {
            if ((rows * cols - emptyCellCount) % 2 != 0)
            {
                emptyCellCount++;
            }

            cells = new List<GameCellListWrapper>(rows);
            for (int i = 0; i < rows; i++)
            {
                List<GameCell> vrsta = new List<GameCell>();
                for (int k = 0; k < cols; k++)
                {
                    vrsta.Add(null);
                }

                cells.Add(new GameCellListWrapper(vrsta));
            }

            for (int i = 0; i < emptyCellCount; i++)
            {
                int indexI = mRandomGenerator.Next(0, rows);
                int indexJ = mRandomGenerator.Next(0, cols);

                while (cells[indexI].GetCell(indexJ) != null)
                {
                    indexI = mRandomGenerator.Next(0, rows);
                    indexJ = mRandomGenerator.Next(0, cols);
                }

                cells[indexI].setCell(new GameCell(indexI, indexJ), indexJ); // prazna celija
            }

            List<string> slike = new List<string>();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (cells[i].GetCell(j) != null)
                        continue;

                    if (slike.Count == 0)
                    {
                        for (int k = 0; k < imageCount; k++)
                        {
                            slike.Add(ImagePaths[k]);
                        }

                        slike = Promesaj(slike);
                    }

                    string imagePath = slike.Last();
                    slike.RemoveAt(slike.Count - 1);

                    if (slike.Count > 0)
                        slike.RemoveAt(slike.Count - 1);

                    cells[i].setCell(new GameCell(i, j, imagePath), j);

                    int indexI = mRandomGenerator.Next(0, rows);
                    int indexJ = mRandomGenerator.Next(0, cols);

                    while (cells[indexI].GetCell(indexJ) != null)
                    {
                        indexI = mRandomGenerator.Next(0, rows);
                        indexJ = mRandomGenerator.Next(0, cols);
                    }

                    cells[indexI].setCell(new GameCell(indexI, indexJ, imagePath), indexJ);
                }
            }

        }
        public GameCell GetCell(int row, int col)
        {
            if (row < 0 || row >= rows)
                return null;

            if (col < 0 || col >= cols)
                return null;

            return cells[row].GetCell(col);
        }

        private List<string> Promesaj(List<string> images)
        {
            int len = images.Count;
            int k = len;

            while (k > 0) 
            {
                int i = mRandomGenerator.Next(len);
                int j = mRandomGenerator.Next(len);

                string pom = images[i];
                images[i] = images[j];
                images[j] = pom;

                k--;
            }

            return images;
        }

        public void Sacuvaj(string fileName)
        {
            XmlTextWriter wr = null;

            try
            {
                wr = new XmlTextWriter(fileName, System.Text.Encoding.Unicode);
                XmlSerializer sr = new XmlSerializer(typeof(MemoryGameInternal));

                sr.Serialize(wr, this);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                wr.Close();
            }
        }

        public static MemoryGameInternal Ucitaj(string fileName) 
        {
            StreamReader rd = null;
            MemoryGameInternal igra = null;
        
            try
            {
                rd = new StreamReader(fileName);

                XmlSerializer sr = new XmlSerializer(typeof(MemoryGameInternal));

                igra = sr.Deserialize(rd) as MemoryGameInternal;
            }
            catch (Exception e) 
            {
                Console.WriteLine (e.ToString());
            }
            finally 
            {
                rd.Close();
            }

            return igra;
        }

    }
}
