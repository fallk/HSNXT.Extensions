using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Cheaturu.Compare.Precalc
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            foreach (var f in Directory.EnumerateFiles("../Cheaturu/poke_out/poke"))
            {
                Console.WriteLine(f);
                var hash = new ImgHash();
                hash.GenerateFromPath(f);
                File.WriteAllText("./data/" + Path.GetFileNameWithoutExtension(f) + ".txt", string.Join(",", hash.HashData));
            }
        }
    }
    public class ImgHash
    {
        public readonly int HashSide;

        public bool[] HashData { get; private set; }

        public ImgHash(int hashSideSize = 16)
        {
            HashSide = hashSideSize;

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

        private void GenerateFromImage(Image img)
        {
            var lResult = new List<bool>();

            //resize img to 16x16px (by default) or with configured size 
            var bmpMin = new Bitmap(img, new Size(HashSide, HashSide));
            
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