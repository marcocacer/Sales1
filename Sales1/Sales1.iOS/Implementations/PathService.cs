[assembly: Xamarin.Forms.Dependency(typeof(Sales1.iOS.Implementations.PathService))]

namespace Sales1.iOS.Implementations
{
    using Interfaces;
    using System;
    using System.IO;

    public class PathService : IPathService
    {
        public string GetDatabasePath()
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if(!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            return Path.Combine(libFolder, "Sales1.db3");
        }
    }
}