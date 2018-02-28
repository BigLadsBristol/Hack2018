using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hack2018
{
    static class Comparator
    {
        public enum Flag
        {
            Forest = (1 << 0),
            Ice = (1 << 1)
        };

        static int squareSize = 2;

        static public Bitmap Compare(Bitmap imgPast, Bitmap imgCur, Flag flag)
        {
            Bmp bmpPast = new Bmp(imgPast);
            Bmp bmpCur  = new Bmp(imgCur);

            Bmp bmpChange = Compare(bmpPast, bmpCur, flag);

            return bmpChange.ToBitmap();
        }

        static public Bmp Compare(Bmp imgPast, Bmp imgCur, Flag flag)
        {
            int height = imgPast.Height;
            int width = imgPast.Width;

            Bmp result = new Bmp(width, height);

            for (int y = 0; y < height - squareSize; y += squareSize)
            {
                for (int x = 0; x < width - squareSize; x += squareSize)
                {
                    Bmp squarePast = Bmp.FromBmp(imgPast, squareSize, squareSize, y, x);
                    Bmp squareCur = Bmp.FromBmp(imgCur, squareSize, squareSize, y, x);

                    bool temp = CompareSmall(squarePast, squareCur, flag);

                    if (temp)
                        result.FillColor(squareSize, squareSize, y, x, 255, 0, 0);
                    else
                        result.FillImage(squareCur, y, x);
                }
            }

            return result;
        }

        static public bool CompareSmall(Bmp imgPast, Bmp imgCur, Flag flag)
        {
            return Verify(imgPast, flag) && !Verify(imgCur, flag);
        }

        static public bool Verify(Bmp img, Flag flag)
        {
            if (flag == Flag.Forest)
                return VerifyForest(img);
            else
                return false;
        }

        static public bool VerifyForest(Bmp img)
        {
            int height = img.Height;
            int width = img.Width;
            int pixelCount = height * width;

            int medR = 0;
            int medG = 0;
            int medB = 0;

            for (int y = 0; y < height; ++y)
            {
                for (int x = 0; x < width; ++x)
                {
                    medR += img[y, x, 0];
                    medG += img[y, x, 1];
                    medB += img[y, x, 2];
                }
            }

            medR /= pixelCount;
            medG /= pixelCount;
            medB /= pixelCount;

            /*bool result =
              medR <= 60 &&
              medG >= 150 &&
              medB <= 60;

            return result;*/

            return ColorsAreClose(
              Color.FromArgb(medR, medG, medB),
              Color.FromArgb(40, 70, 7),
              25);
        }

        static bool ColorsAreClose(Color a, Color z, int threshold)
        {
            int r = (int)a.R - z.R,
                g = (int)a.G - z.G,
                b = (int)a.B - z.B;
            return (r * r + g * g + b * b) <= threshold * threshold;
        }
    }
}
