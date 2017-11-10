using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace SCHOTT.KL2500LED.Control.Layouts
{
    public static class Layouts
    {
        public static Dictionary<string, Stream> Streams = new Dictionary<string, Stream>();
        public static Dictionary<string, string> ResourceNames = new Dictionary<string, string>();

        public static Stream GetStream(string fileName)
        {
            if (!ResourceNames.ContainsKey(fileName))
                return null;

            var assembly = Assembly.GetExecutingAssembly();
            return assembly.GetManifestResourceStream(ResourceNames[fileName]);
        }

        static Layouts()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var internalResources = assembly.GetManifestResourceNames()
                .Where(s => s.Contains("Layouts."))
                .OrderByDescending(o => o).ToList();

            if (internalResources.Count <= 0)
                return;

            foreach (var name in internalResources)
            {
                var workingString = name.Substring(name.LastIndexOf("Layouts.", StringComparison.Ordinal) + 8);
                Streams.Add(workingString, assembly.GetManifestResourceStream(name));
                ResourceNames.Add(workingString, name);
            }
        }
    }
}
