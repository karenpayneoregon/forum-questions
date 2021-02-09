using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTrayApp.Classes
{
    public sealed class WatchFileContainer
    {
        private static readonly Lazy<WatchFileContainer> Lazy =
            new Lazy<WatchFileContainer>(() => new WatchFileContainer());

        public static WatchFileContainer Instance => Lazy.Value;

        public List<FileContainer> NewFileList { get; set; }
        public List<FileContainer> RenamedFileList { get; set; } 

        private WatchFileContainer()
        {
            NewFileList = new List<FileContainer>();
            RenamedFileList = new List<FileContainer>();
        }
    }
}
