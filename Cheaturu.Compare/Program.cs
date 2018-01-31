using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace Cheaturu.Compare
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var hashes = new List<(double, ImgHash)>();
            foreach (var (v, h) in GetHashes(GetImgHash("./testimg.png")))
            {
                Console.WriteLine($"|{v:##.00000} {h.FilePath}");
                hashes.Add((v, h));
            }
            foreach (var (v, h) in ClosestTo(hashes, 0))
            {
                Console.WriteLine($"{v:##.00000} {h.FilePath}");
            }
        }

        public static IEnumerable<(double v, ImgHash)> GetHashes(ImgHash img)
        {
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var f in Directory.EnumerateFiles("../Cheaturu/poke_out/poke"))
            {
                var hash = GetImgHash(f);
                yield return (hash.CompareWith(img), hash);
            }
        }

        private static ImgHash GetImgHash(string f)
        {
            var hash = new ImgHash();
            hash.GenerateFromPath(f);
            return hash;
        }

        public static IOrderedEnumerable<(double v, ImgHash)> ClosestTo(IEnumerable<(double v, ImgHash)> list, double number)
        {
            // int closest = list.Aggregate((x,y) => Math.Abs(x-number) < Math.Abs(y-number) ? x : y);
            // list.OrderBy(item => Math.Abs(number - item)).First();
            return list.OrderBy(item => Math.Abs(number - item.v));
        }
    }
    
    public class ImgHash
    {
        private readonly int _hashSide;

        public bool[] HashData { get; private set; }

        public Image Img => Image.FromFile(FilePath);

        public string FilePath { get; private set; }

        public string FileName => Path.GetFileName(FilePath);

        public string FileLocation => Path.GetDirectoryName(FilePath);

        public string ImgSize { get; private set; }

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
            FilePath = path;

            var image = (Bitmap)Image.FromFile(path, true);

            ImgSize = $"{image.Size.Width}x{image.Size.Height}";

            GenerateFromImage(image);

            image.Dispose();
        }

        private void GenerateFromImage(Image img)
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