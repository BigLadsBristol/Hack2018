using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hack2018
{
    class Bmp
    {
        int[,,] img;

        public int Height;
        public int Width;

        public int this[int y, int x, int c]
        {
            get { return img[y, x, c]; }
            set { img[y, x, c] = value; }
        }

        public Bmp(int Width, int Height)
        {
            this.Height = Height;
            this.Width = Width;
            img = new int[Height, Width, 3];
        }

        public Bmp(Bitmap source)
        {
            this.Height = source.Height;
            this.Width = source.Width;
            img = new int[Height, Width, 3];

            for (int y = 0; y < Height; ++y)
            {
                for (int x = 0; x < Width; ++x)
                {
                    Color col = source.GetPixel(x, y);
                    img[y, x, 0] = col.R;
                    img[y, x, 1] = col.G;
                    img[y, x, 2] = col.B;
                }
            }
        }

        public Bitmap ToBitmap()
        {
            Bitmap bmp = new Bitmap(Width, Height);

            for (int y = 0; y < Height; ++y)
            {
                for (int x = 0; x < Width; ++x)
                {
                    Color col = Color.FromArgb(
                      img[y, x, 0],
                      img[y, x, 1],
                      img[y, x, 2]);
                    bmp.SetPixel(x, y, col);
                }
            }

            return bmp;
        }

        static public Bmp FromBmp(Bmp source, int Height, int Width, int posY, int posX)
        {
            Bmp result = new Bmp(Height, Width);
            for (int y = 0; y < Width; ++y)
            {
                for (int x = 0; x < Height; ++x)
                {
                    for (int c = 0; c < 3; ++c)
                        result[y, x, c] = source[posY + y, posX + x, c];
                }
            }

            return result;
        }

        public void FillColor(int Height, int Width, int posY, int posX, int R, int G, int B)
        {
            for (int y = 0; y < Width; ++y)
            {
                for (int x = 0; x < Height; ++x)
                {
                    img[posY + y, posX + x, 0] = R;
                    img[posY + y, posX + x, 1] = G;
                    img[posY + y, posX + x, 2] = B;
                }
            }
        }

        public void FillImage(Bmp source, int posY, int posX)
        {
            int Height = source.Height;
            int Width = source.Width;
            for (int y = 0; y < Height; ++y)
            {
                for (int x = 0; x < Width; ++x)
                {
                    for (int c = 0; c < 3; ++c)
                        img[posY + y, posX + x, c] = source[y, x, c];
                }
            }
        }
    }
}
