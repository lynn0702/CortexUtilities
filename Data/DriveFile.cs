using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DriveFile
    {
        public string Name { get; set; }
        public string FileId { get; set; }

        // Note: this is important so the select can compare pizzas
        public override bool Equals(object o)
        {
            var other = o as DriveFile;
            return other?.FileId == FileId;
        }

        // Note: this is important so the select can compare pizzas
        public override int GetHashCode() => FileId.GetHashCode();

    }
}
