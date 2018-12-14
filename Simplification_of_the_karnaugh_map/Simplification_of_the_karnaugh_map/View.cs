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
        public static Truth_table _TruthtableInstance;
        internal int[,] truth_table_array = new int[4, 4];
        public View()
        {
            _ViewInstance = this;
            _TruthtableInstance = new Truth_table();
            InitializeComponent();
        }

        private void Run_Button_Click(object sender, EventArgs e)
        {
            Array.Clear(truth_table_array, 1, truth_table_array.Length - 1);//Item[0,0]以外をクリア
            Array.Clear(truth_table_array, 0, truth_table_array.Length);//全ての要素をクリア
            _TruthtableInstance.Make_Truth_table();
        }
    }
}
