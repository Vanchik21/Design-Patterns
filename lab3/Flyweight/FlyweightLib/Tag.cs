using CompositeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightLib
{
    public class Tag
    {
        public string TagName { get; }
        public int TagDisplayType { get; }
        public int TagIsPaired { get; }
        public Tag(string tag, int displayType, int isPaired)
        {
            this.TagName = tag;
            this.TagDisplayType = displayType;
            this.TagIsPaired = isPaired;
        }
    }
}