using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using Game.Slicice;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

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
        private System.Drawing.Image content;
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

        public string Content { 

            get 
            {
                if (content == null)
                    return null;

                using (MemoryStream ms = new MemoryStream())
                {
                    content.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return Convert.ToBase64String(ms.ToArray());
                }
            } 

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    content = null;
                    return;
                }

                byte[] bytes = Convert.FromBase64String(value);
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    content = System.Drawing.Image.FromStream(ms);
                }
            }
        }

        public GameCell(int xPos, int yPos, System.Drawing.Image content = null)
        {
            posX = xPos;
            posY = yPos;

            if (content == null)
                this.content = emptyIcon.Icon;
            else
                this.content = content;
        }
    }

    [Serializable]
    internal class MemoryGameInternal
    {
        private int mRows;
        private int mCols;
        private int mEmptyCellCount;
        private int mImageCount;
        private GameCell[][] mCells;
        private Random mRandomGenerator;

        private static System.Drawing.Image[] Images = {cpuIcon.Icon, gpuIcon.Icon, ramIcon.Icon,
                                  hddIcon.Icon, ssdIcon.Icon, psuIcon.Icon,
                                  mouseIcon.Icon, monitorIcon.Icon, keyboardIcon.Icon,
                                  fanIcon.Icon, headphoneIcon.Icon};

        public MemoryGameInternal(int rows = 0, int cols = 0, int emptyCellCount = 0, int imageCount = 0)
        {
            mRows = rows;
            mCols = cols;
            mEmptyCellCount = emptyCellCount;
            mImageCount = imageCount;
            mRandomGenerator = new Random(DateTime.Now.Second);
        }

        public void GenerisiRandomIgru()
        {
            if ((mRows * mCols - mEmptyCellCount) % 2 != 0)
            {
                mEmptyCellCount++;
            }

            mCells = new GameCell[mRows][];
            for (int i = 0; i < mRows; i++)
            {
                mCells[i] = new GameCell[mCols];
            }

            for (int i = 0; i < mEmptyCellCount; i++)
            {
                int indexI = mRandomGenerator.Next(0, mRows);
                int indexJ = mRandomGenerator.Next(0, mCols);

                while (mCells[indexI][indexJ] != null)
                {
                    indexI = mRandomGenerator.Next(0, mRows);
                    indexJ = mRandomGenerator.Next(0, mCols);
                }

                mCells[indexI][indexJ] = new GameCell(indexI, indexJ); // prazna celija
            }

            List<System.Drawing.Image> icons = new List<System.Drawing.Image>();

            for (int i = 0; i < mRows; i++)
            {
                for (int j = 0; j < mCols; j++)
                {
                    if (mCells[i][j] != null)
                        continue;

                    if (icons.Count == 0)
                    {
                        for (int k = 0; k < mImageCount; k++)
                        {
                            icons.Add(Images[k]);
                        }

                        icons = Promesaj(icons);
                    }

                    System.Drawing.Image icon = icons.Last();

                    if (icons.Count > 0)
                        icons.RemoveAt(icons.Count - 1);

                    mCells[i][j] = new GameCell(i, j, icon);

                    int indexI = mRandomGenerator.Next(0, mRows);
                    int indexJ = mRandomGenerator.Next(0, mCols);

                    while (mCells[indexI][indexJ] != null)
                    {
                        indexI = mRandomGenerator.Next(0, mRows);
                        indexJ = mRandomGenerator.Next(0, mCols);
                    }

                    mCells[indexI][indexJ] = new GameCell(indexI, indexJ, icon);
                }
            }

        }

        public GameCell GetCell(int row, int col)
        {
            if (row < 0 || row >= mRows)
                return null;

            if (col < 0 || col >= mCols)
                return null;

            return mCells[row][col];
        }

        private List<System.Drawing.Image> Promesaj(List<System.Drawing.Image> images)
        {
            int len = images.Count;
            int k = len;

            while (k > 0) 
            {
                int i = mRandomGenerator.Next(len);
                int j = mRandomGenerator.Next(len);

                System.Drawing.Image pom = images[i];
                images[i] = images[j];
                images[j] = pom;

                k--;
            }

            return images;
        }
    }
}
