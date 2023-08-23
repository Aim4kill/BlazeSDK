using System.Collections.Generic;

namespace BlazeComponentBaseGenerator.Data
{
    class FileConfig
    {
        public List<string> Usings;
        public string Namespace;
        public List<Component> Components;

        public FileConfig()
        {
            Usings = new List<string>();
            Namespace = string.Empty;
            Components = new List<Component>();
        }
    }
}
