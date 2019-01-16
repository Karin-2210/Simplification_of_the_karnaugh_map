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
        public static Algorithm _Algorithm;
        internal int[,] truth_table_array = new int[4, 4];
        private System.Windows.Forms.TextBox[,] truth_table_outputs;
        public View()
        {
            _ViewInstance = this;
            _TruthtableInstance = new Truth_table();
            _Algorithm = new Algorithm();
            
            InitializeComponent();
        }

        private void Run_Button_Click(object sender, EventArgs e)
        {
            int i,p,q;//ループ用変数
            int ofset_X = -10;
            int ofset_Y = -10;
            this.truth_table_outputs = new System.Windows.Forms.TextBox[4, 4];
            this.truth_table_outputs[0, 0] = this.truth_table_output_00;
            this.truth_table_outputs[0, 1] = this.truth_table_output_01;
            this.truth_table_outputs[0, 2] = this.truth_table_output_02;
            this.truth_table_outputs[0, 3] = this.truth_table_output_03;
            this.truth_table_outputs[1, 0] = this.truth_table_output_10;
            this.truth_table_outputs[1, 1] = this.truth_table_output_11;
            this.truth_table_outputs[1, 2] = this.truth_table_output_12;
            this.truth_table_outputs[1, 3] = this.truth_table_output_13;
            this.truth_table_outputs[2, 0] = this.truth_table_output_20;
            this.truth_table_outputs[2, 1] = this.truth_table_output_21;
            this.truth_table_outputs[2, 2] = this.truth_table_output_22;
            this.truth_table_outputs[2, 3] = this.truth_table_output_23;
            this.truth_table_outputs[3, 0] = this.truth_table_output_30;
            this.truth_table_outputs[3, 1] = this.truth_table_output_31;
            this.truth_table_outputs[3, 2] = this.truth_table_output_32;
            this.truth_table_outputs[3, 3] = this.truth_table_output_33;
            Array.Clear(truth_table_array, 1, truth_table_array.Length - 1);//Item[0,0]以外をクリア
            Array.Clear(truth_table_array, 0, truth_table_array.Length);//全ての要素をクリア
            _TruthtableInstance.Make_Truth_table();
            _Algorithm.mainAlgorithm();
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
            for (i = 0; i <= 3; i++) {
                for (p = 0; p <= 3; p++)
                {
                    truth_table_outputs[i, p].BackColor = Color.White;
                }
            }
            //レガシーな表示形式(丸で囲うタイプ)
            Bitmap canvas = new Bitmap(Simplified_Draw.Width, Simplified_Draw.Height);
            Graphics graphics = Graphics.FromImage(canvas);
            Pen pen = new Pen(Color.Black, 1);
            for (i = 0; i < _Algorithm.groupOfVariable.Count; i++)
            {
                if (_Algorithm.groupOfVariable[i][0] != _Algorithm.groupOfVariable[i][2] && _Algorithm.groupOfVariable[i][1] != _Algorithm.groupOfVariable[i][3])
                {
                    if (_Algorithm.groupOfVariable[i][2] - _Algorithm.groupOfVariable[i][0] == 1)
                    {
                        graphics.DrawEllipse(pen, (truth_table_outputs[_Algorithm.groupOfVariable[i][0], _Algorithm.groupOfVariable[i][1]].Location.X) + ofset_X, (truth_table_outputs[_Algorithm.groupOfVariable[i][0], _Algorithm.groupOfVariable[i][1]].Location.Y) + ofset_Y, 76, 70);
                    }
                    else
                    {
                        graphics.DrawEllipse(pen, (truth_table_outputs[_Algorithm.groupOfVariable[i][0], _Algorithm.groupOfVariable[i][1]].Location.X) + ofset_X, (truth_table_outputs[_Algorithm.groupOfVariable[i][0], _Algorithm.groupOfVariable[i][1]].Location.Y) + ofset_Y, 152, 140);
                    }
                }
                else if (_Algorithm.groupOfVariable[i][0] == _Algorithm.groupOfVariable[i][2])
                {
                    if (_Algorithm.groupOfVariable[i][3] - _Algorithm.groupOfVariable[i][1] == 1)
                    {
                        graphics.DrawEllipse(pen, (truth_table_outputs[_Algorithm.groupOfVariable[i][0], _Algorithm.groupOfVariable[i][1]].Location.X) + ofset_X, (truth_table_outputs[_Algorithm.groupOfVariable[i][0], _Algorithm.groupOfVariable[i][1]].Location.Y) + ofset_Y, 76, 35);
                    }
                    else
                    {
                        graphics.DrawEllipse(pen, (truth_table_outputs[_Algorithm.groupOfVariable[i][0], _Algorithm.groupOfVariable[i][1]].Location.X) + ofset_X, (truth_table_outputs[_Algorithm.groupOfVariable[i][0], _Algorithm.groupOfVariable[i][1]].Location.Y) + ofset_Y, 152, 35);
                    }

                }
                else
                {
                    if (_Algorithm.groupOfVariable[i][2] - _Algorithm.groupOfVariable[i][0] == 1)
                    {
                        graphics.DrawEllipse(pen, (truth_table_outputs[_Algorithm.groupOfVariable[i][0], _Algorithm.groupOfVariable[i][1]].Location.X) + ofset_X, (truth_table_outputs[_Algorithm.groupOfVariable[i][0], _Algorithm.groupOfVariable[i][1]].Location.Y) + ofset_Y, 38, 70);
                    }
                    else {
                        graphics.DrawEllipse(pen, (truth_table_outputs[_Algorithm.groupOfVariable[i][0], _Algorithm.groupOfVariable[i][1]].Location.X) + ofset_X, (truth_table_outputs[_Algorithm.groupOfVariable[i][0], _Algorithm.groupOfVariable[i][1]].Location.Y) + ofset_Y, 38, 140);
                    }
                }
            }
            graphics.Dispose();
            Simplified_Draw.Image = canvas;

            //新表示タイプ(セルの色変化による表示)
            Random rand = new Random();
            int color_red;
            int color_blue;
            int color_green;
            for (i = 0; i < _Algorithm.groupOfVariable.Count; i++)
            {
                if (!(_Algorithm.groupOfVariable[i][0] == _Algorithm.groupOfVariable[i][2] && _Algorithm.groupOfVariable[i][1] == _Algorithm.groupOfVariable[i][3]))
                {
                    color_red = rand.Next(256);
                    color_blue = rand.Next(256);
                    color_green = rand.Next(256);
                    if (_Algorithm.groupOfVariable[i][2] - _Algorithm.groupOfVariable[i][0] < 0)
                    {
                        for (q = _Algorithm.groupOfVariable[i][1]; q <= _Algorithm.groupOfVariable[i][3]; q++)
                        {
                            this.truth_table_outputs[_Algorithm.groupOfVariable[i][0], q].BackColor = Color.FromArgb(color_red, color_blue, color_green);
                            this.truth_table_outputs[_Algorithm.groupOfVariable[i][2], q].BackColor = Color.FromArgb(color_red, color_blue, color_green);
                        }
                    }
                    else if (_Algorithm.groupOfVariable[i][3] - _Algorithm.groupOfVariable[i][1] < 0)
                    {
                        for (p = _Algorithm.groupOfVariable[i][0]; p <= _Algorithm.groupOfVariable[i][2]; p++)
                        {
                            this.truth_table_outputs[p, _Algorithm.groupOfVariable[i][1]].BackColor = Color.FromArgb(color_red, color_blue, color_green);
                            this.truth_table_outputs[p, _Algorithm.groupOfVariable[i][3]].BackColor = Color.FromArgb(color_red, color_blue, color_green);
                        }
                    }
                    else
                    {
                        for (p = _Algorithm.groupOfVariable[i][0]; p <= _Algorithm.groupOfVariable[i][2]; p++)
                        {
                            for (q = _Algorithm.groupOfVariable[i][1]; q <= _Algorithm.groupOfVariable[i][3]; q++)
                            {
                                this.truth_table_outputs[p, q].BackColor = Color.FromArgb(color_red, color_blue, color_green);
                            }
                        }
                    }
                }
            }
        }

        private void Formula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 'A' && e.KeyChar != 'B'&&e.KeyChar != 'C' && e.KeyChar != 'D' && e.KeyChar != '/' && e.KeyChar != '\b' && e.KeyChar != '+')
            {
                e.Handled = true;
            }
        }
    }
}
