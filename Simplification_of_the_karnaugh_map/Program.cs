using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplification_of_the_karnaugh_map
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。プログラムの中核となります．
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View());
        }
    }
}
