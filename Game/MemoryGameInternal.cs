using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Game.Slicice;
using System.Xml.XPath;
using System.Reflection;

namespace StartingWindow
{
    enum CELL_STATE
    {
        HIDDEN,
        VISIBLE,
        SELECTED
    }

    internal class GameCell
    {
        private CELL_STATE mState;
        private Image mContent;

        private int mXpos;
        private int mYpos;
        
        public CELL_STATE State { get { return mState; } set { mState = value; } }
        public Image Content { get { return mContent; } }

        public int Xpos { get { return mXpos; } }
        public int Ypos { get { return mYpos; } }

        public GameCell(int xPos, int yPos, Image content = null)
        {
            mXpos = xPos;
            mYpos = yPos;

            if (content == null)
                mContent = emptyIcon.Icon;
            else
                mContent = content;
        }
    }

    internal class MemoryGameInternal
    {
        private int mRows;
        private int mCols;
        private GameCell[][] mCells;
        private Random mRandomGenerator;

        private static Image[] Images = {cpuIcon.Icon, gpuIcon.Icon, ramIcon.Icon,
                                  hddIcon.Icon, ssdIcon.Icon, psuIcon.Icon,
                                  mouseIcon.Icon, monitorIcon.Icon, keyboardIcon.Icon,
                                  fanIcon.Icon, headphoneIcon.Icon};

        public MemoryGameInternal(int rows, int cols, int emptyCells, int images)
        {
            mRows = rows;
            mCols = cols;
            mRandomGenerator = new Random(10);

            // Osiguravamo da je broj preostalih nepraznih celija paran
            if ((rows * cols - emptyCells) % 2 != 0)
            {
                emptyCells = emptyCells + 1;
            }

            mCells = new GameCell[rows][];
            for (int i = 0; i < rows; i++)
            {
                mCells[i] = new GameCell[cols];
            }
            
            for (int i = 0; i < emptyCells; i++)
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

            for (int i = 0; i < mRows; i++)
            {
                for (int j = 0; j < mCols; j++)
                {
                    if (mCells[i][j] != null)
                        continue;

                    int imadeIndex = mRandomGenerator.Next(0, images);

                    Image icon = Images[imadeIndex];

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




    }
}
