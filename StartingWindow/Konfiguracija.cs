using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace StartingWindow
{
    [Serializable]
    public class Konfiguracija
    {
        private int rows;
        private int cols;
        private int imageCount;
        private int emptyCount;

        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }
        public int Cols
        {
            get { return cols; }
            set { cols = value; }
        }
        public int ImageCount
        {
            get { return imageCount; }
            set { imageCount = value; }
        }
        public int EmptyCount
        {
            get { return emptyCount; }
            set { emptyCount = value; }
        }

        public Konfiguracija(int rows, int cols, int imageCount, int emptyCount)
        {
            this.rows = rows;
            this.cols = cols;
            this.imageCount = imageCount;
            this.emptyCount = emptyCount;
        }

        public Konfiguracija() {}

        public void Sacuvaj(string fileName)
        {
            XmlTextWriter wr = null;

            try
            {
                wr = new XmlTextWriter(fileName, System.Text.Encoding.Unicode);

                XmlSerializer sr = new XmlSerializer(typeof(Konfiguracija));

                sr.Serialize(wr, this);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                wr.Close();
            }
        }

        public static Konfiguracija Ucitaj(string fileName)
        {
            StreamReader rd =  null;
            Konfiguracija config = null;

            try
            {
                rd = new StreamReader(fileName);

                XmlSerializer sr = new XmlSerializer(typeof(Konfiguracija));

                config = sr.Deserialize(rd) as Konfiguracija;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                if (rd != null)
                    rd.Close();
            }

            return config;
        }
    }
}
