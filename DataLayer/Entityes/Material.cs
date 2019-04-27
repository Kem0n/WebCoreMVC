using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entityes
{
    public class Material
    {
        public int DirectoryId { get; set; }
        public Directory Directory { get; set; }
    }
}
