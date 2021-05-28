using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoStudio ps = new PhotoStudio();
            List<Image> list = new List<Image>()
            {
                new Jpeg(),
                new Jpeg(),
                new Jpeg(),
                new Jpeg(),
                new Jpeg(),
                new Jpeg(),
                new Jpeg()
            };
            ps.PlaceOrder(list, PhotoType.Jpeg);
            var v = ps.GetGrayScaleAlbum();
            foreach (var temp in v)
                Console.WriteLine(temp.GetType());
            Console.ReadLine();
        }
    }

    enum PhotoType { Jpeg, Png };
    class Image { }
    class Jpeg : Image { } /* represents a JPEG file */
    class Png : Image { } /* represents a PNG file */
    abstract class Filter
    {
        public abstract Image GrayScale(Image img);
    }
    class JpegFilter : Filter
    {
        public override Image GrayScale(Image jpeg)
        {
            /*convert to grayscale*/
            Console.WriteLine("jpg");
            return jpeg;
        }
    }
    class PngFilter : Filter
    {
        public override Image GrayScale(Image png)
        {
            /*convert to grayscale*/
            Console.WriteLine("png");
            return png;
        }
    }

    class PhotoStudio
    {
        private Filter filter;
        private List<Image> images;
        public void PlaceOrder(List<Image> photos, PhotoType image)
        {
            switch (image)
            {
                case PhotoType.Jpeg:
                    filter = new JpegFilter();
                    break;
                case PhotoType.Png:
                    filter = new PngFilter();
                    break;
            }
            images = photos;
        }
        public List<Image> GetGrayScaleAlbum()
        {
            List<Image> album = new List<Image>();
            foreach (var photo in images)
                album.Add(filter.GrayScale(photo));
            return album;
        }
    }
}
