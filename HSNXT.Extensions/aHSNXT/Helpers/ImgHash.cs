using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace HSNXT
{
    internal class ImgHash
    {
        private readonly int _hashSide;

        public bool[] HashData { get; private set; }

        public ImgHash(int hashSideSize = 16)
        {
            _hashSide = hashSideSize;

            HashData = new bool[hashSideSize * hashSideSize];
        }

        /// <summary>
        /// Method to compare 2 image hashes
        /// </summary>
        /// <returns>% of similarity</returns>
        public double CompareWith(ImgHash compareWith)
        {
            if (HashData.Length != compareWith.HashData.Length)
            {
                throw new Exception("Cannot compare hashes with different sizes");
            }

            var differenceCounter = HashData.Where((t, i) => t != compareWith.HashData[i]).Count();

            return 100 - differenceCounter/100.0 * HashData.Length / 2.0;
        }

        public void GenerateFromPath(string path)
        {
            var image = (Bitmap)Image.FromFile(path, true);

            GenerateFromImage(image);

            image.Dispose();
        }

        public void GenerateFromImage(Image img)
        {
            var lResult = new List<bool>();

            //resize img to 16x16px (by default) or with configured size 
            var bmpMin = new Bitmap(img, new Size(_hashSide, _hashSide));
            
            for (var j = 0; j < bmpMin.Height; j++)
            {
                for (var i = 0; i < bmpMin.Width; i++)
                {
                    //reduce colors to true and false
                    lResult.Add(bmpMin.GetPixel(i, j).GetBrightness() < 0.5f);
                }
            }

            HashData = lResult.ToArray();

            bmpMin.Dispose();
        }
    }
}