using MetadataExtractor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageMetaTag
{
    class Program
    {
        static void Main(string[] args)
        {
            Image image = new Bitmap(@"C:\Users\Public\Pictures\Sample Pictures\Chrysanthemum.jpg");



            IEnumerable<Directory> directories = ImageMetadataReader.ReadMetadata(@"C:\Users\Public\Pictures\Sample Pictures\Chrysanthemum.jpg");


            foreach (var directory in directories)
            {
                foreach (var tag in directory.Tags)
                Console.WriteLine(tag);
            }
            //// Get the PropertyItems property from image.
            //PropertyItem[] propItems = image.PropertyItems;

            //// Set up the display.
            //Font font = new Font("Arial", 12);
            //SolidBrush blackBrush = new SolidBrush(Color.Black);
            //int X = 0;
            //int Y = 0;

            //// For each PropertyItem in the array, display the ID, type, and 
            //// length.
            //int count = 0;
            //foreach (PropertyItem propItem in propItems)
            //{

            //}
            //// Convert the value of the second property to a string, and display 
            //// it.
            //System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            //string manufacturer = encoding.GetString(propItems[1].Value);

        }
    }
}
