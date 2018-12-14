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
            truth_table_output_00.Text = Convert.ToString(truth_table_array[0, 0]);
            truth_table_output_01.Text = Convert.ToString(truth_table_array[0, 1]);
            truth_table_output_02.Text = Convert.ToString(truth_table_array[0, 2]);
            truth_table_output_03.Text = Convert.ToString(truth_table_array[0, 3]);
            truth_table_output_10.Text = Convert.ToString(truth_table_array[1, 0]);
            truth_table_output_11.Text = Convert.ToString(truth_table_array[1, 1]);
            truth_table_output_12.Text = Convert.ToString(truth_table_array[1, 2]);
            truth_table_output_13.Text = Convert.ToString(truth_table_array[1, 3]);
            truth_table_output_20.Text = Convert.ToString(truth_table_array[2, 0]);
            truth_table_output_21.Text = Convert.ToString(truth_table_array[2, 1]);
            truth_table_output_22.Text = Convert.ToString(truth_table_array[2, 2]);
            truth_table_output_23.Text = Convert.ToString(truth_table_array[2, 3]);
            truth_table_output_30.Text = Convert.ToString(truth_table_array[3, 0]);
            truth_table_output_31.Text = Convert.ToString(truth_table_array[3, 1]);
            truth_table_output_32.Text = Convert.ToString(truth_table_array[3, 2]);
            truth_table_output_33.Text = Convert.ToString(truth_table_array[3, 3]);
        }


    }
}
