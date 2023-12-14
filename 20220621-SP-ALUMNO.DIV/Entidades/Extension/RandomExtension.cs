using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Extension
{
    public static class RandomExtension
    {
        public static int GetRandom(this Random value, int hasta)
        { 
            return value.Next(1,hasta);
        }
    }
}
