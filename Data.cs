using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseData;

namespace Labirint_Editor
{
    [Serializable]
    public class EditorMob : Mob
    {
        public int color;
    }

    [Serializable]
    public class EditorBiome : Biome
    {
        public int forColor;
        public int backColor;
    }
}
