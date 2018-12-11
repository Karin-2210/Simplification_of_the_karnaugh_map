using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplification_of_the_karnaugh_map
{
    //表示用のビューとプログラムの中核です．
    
    public partial class View : Form
    {
        private static View _ViewInstance;
        public static View ViewInstance { get => _ViewInstance; set => _ViewInstance = value; }
        internal int[,] truth_table_array = new int[4, 4];
        public int test;
        public View()
        {
            _ViewInstance = this;
            InitializeComponent();
        }

       
    }
}
