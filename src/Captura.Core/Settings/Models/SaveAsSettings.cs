using System;
using System.IO;

namespace Captura
{
    public class SaveAsSettings : PropertyStore
    {
        public bool Enabled
        {
            get => Get(true);
            set => Set(value);
        }

        public string SaveAsPath
        {
            get => Get<string>();
            set => Set(value);
        }

        public string GetOutputPath()
        {
            var path = SaveAsPath;

            // If Output Dircetory is not set. Set it to Documents\Captura\
            path = string.IsNullOrWhiteSpace(path)
                ? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), nameof(Captura))
                : path.Replace(ServiceProvider.CapturaPathConstant, ServiceProvider.AppDir);

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            return path;
        }
    }
}
