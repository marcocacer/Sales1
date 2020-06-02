[assembly: Xamarin.Forms.Dependency(typeof(Sales1.Droid.Implementations.PathService))]

namespace Sales1.Droid.Implementations
{
    using Interfaces;
    using System;
    using System.IO;

    public class PathService : IPathService
    {
        public string GetDatabasePath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, "Sales1.db3");
        }
    }
}