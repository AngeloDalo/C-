using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipi_di_int
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOME     .NET TYPE     SIZE      RANGE
            /*
             * sbyte   System.SByte    1        -128 a 127
             * byte    System.Byte     1        0 a 255
             * 
             * short   System.Int16    2        -32.768 a 32.767
             * unshort System.UInte16  2        0 a 65.535
             * 
             * int     System.Int32    4        -2.147.483.648 a 2.147.483.647
             * uint    System.UInt32   4        0 a 4.294.976.295
             * 
             * long    System.Int64    8        9.223.372.036.854.774.808 a ...
             * ulong   System.Int64    8        0 a 18.446.744.073.709.551.615
             */
            int x = 0;
            x = int.MaxValue;
            Console.WriteLine(x);
            x = x + 1; //ricomincia dal valore negativo
        }
    }
}
