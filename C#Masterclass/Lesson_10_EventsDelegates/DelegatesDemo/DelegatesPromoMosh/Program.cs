namespace DelegatesPromoMosh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhotoProcessor processor = new PhotoProcessor();
            PhotoFilters filters = new PhotoFilters();

            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);




            Console.ReadKey();
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply Remove Red Eye");
        }
    }

    public class Photo
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }
        public void Save()
        {

        }
    }

    public class PhotoFilters
    {


        public void ApplyBrightness (Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize photo");
        }
    }

    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path, PhotoFilterHandler photoFilterHandler)
        {
            

            Photo photo = Photo.Load(path);
            photoFilterHandler(photo);


            photo.Save();
        }
    }
}
