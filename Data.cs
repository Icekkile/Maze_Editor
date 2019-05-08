using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseData;

namespace Labirint_Editor
{
    public class EditorMob : Mob
    {
        public string color;
    }

    public class EditorBiome : Biome
    {
        public string forColor;
        public string backColor;
    }
}
