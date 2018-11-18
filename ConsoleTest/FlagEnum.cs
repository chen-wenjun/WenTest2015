using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public enum FlagEnum
    {
        None = 0,
        [System.ComponentModel.Description("RED COLOR")]
        Red = 1,
        Green = 2,
        Blue = 4,
        Yellow = 8,
        Black = 16
    }
}
