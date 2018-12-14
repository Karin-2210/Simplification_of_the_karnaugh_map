using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplification_of_the_karnaugh_map
{
    //このクラスはアルゴリズムモジュールを記述するクラスファイルです．実質的な処理部となります．
    public class Algorithm
    {
        private View _ViewInstance;
        
        // 変数の数
        private const int VAR_NUM = 4;

        // 真理値表
        static int[,] truth_table_array = new int[VAR_NUM, VAR_NUM];

        // 真理値表を全体の変数から持ってくる
        this.truth_tablearray = _ViewInstance.truth_table_array;

        public void calc()
        {
            _ViewInstance = View.ViewInstance;
        }

        // そのマスをグループ化するべきかどうか
        private bool[,] shouldGrouped = new bool[VAR_NUM, VAR_NUM];

        // 変数のグループを保存(グループの左上と右下だけでOK)
        private List<int[]> groupOfVariable = new List<int[]>();

        // グレイ符号(主に描画するときにしか使わないだろうね)
        private String[] grayCode = { "00", "01", "11", "10" };

        // 真理値表，グループ化するべきかどうかの表，どのようにグループ化されたかを描画
        public void printKarnaughMap()
        {
            // 真理値表の描画
            Console.WriteLine("\t\t00\t01\t11\t10");
            for (int i = 0; i < truth_table_array.GetLength(0); i++)
            {
                Console.Write("\t" + grayCode[i]);
                for (int j = 0; j < truth_table_array.GetLength(1); j++)
                {
                    Console.Write("\t" + truth_table_array[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // グループ化するべきかどうかの表を描画
            Console.WriteLine("\t\t00\t01\t11\t10");
            for (int i = 0; i < this.shouldGrouped.GetLength(0); i++)
            {
                Console.Write("\t" + grayCode[i]);
                for (int j = 0; j < this.shouldGrouped.GetLength(1); j++)
                {
                    Console.Write("\t" + this.shouldGrouped[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // どのようにグループ化されたかを描画
            for (int i = 0; i < this.groupOfVariable.Count; i++)
            {
                Console.WriteLine("group[" + i + "] : (" + groupOfVariable[i][0] % VAR_NUM + "," + groupOfVariable[i][1] % VAR_NUM + ")->(" + groupOfVariable[i][2] % VAR_NUM + "," + groupOfVariable[i][3] % VAR_NUM + ").");
            }
        }

        // 手入力で真理値表を作るときに使う
        public void inputtruth_table_array()
        {
            for (int i = 0; i < truth_table_array.GetLength(0); i++)
            {
                for (int j = 0; j < truth_table_array.GetLength(1); j++)
                {
                    int t = int.Parse(Console.ReadLine());
                    truth_table_array[i, j] = t;
                    if (t == 1) this.shouldGrouped[i, j] = true;
                    else this.shouldGrouped[i, j] = false;
                }
            }
        }

        // メインのアルゴリズム
        // とりあえず貪欲的に
        public void mainAlgorithm()
        {
            this.groupOfVariable = new List<int[]>();   // グループ化された値を初期化
            bool isTrue = true;                         // そのマスは1かどうか
            bool whetherGrouped = false;                // すでにグループ化されてるマスだけでまとめるのは意味ないよね
            int size_x = 0, size_y = 0;                 // グループ化するときの大きさ
            int start_x = 0, start_y = 0;               // 探索のスタート位置(左上が基準)
            int diff_x = 0, diff_y = 0;                 // マスを評価するときのイテレータ

            // (4*4 -> 4*2 -> 4*1 -> 2*4 -> 2*1 -> 1*4 -> 1*2 -> 1*1)の順に探していくよ
            for (size_x = VAR_NUM; size_x > 0; size_x /= 2)
            {
                for (size_y = VAR_NUM; size_y > 0; size_y /= 2)
                {
                    // 左上から右下へ
                    for (start_x = 0; start_x < VAR_NUM; start_x++)
                    {
                        for (start_y = 0; start_y < VAR_NUM; start_y++)
                        {
                            // サイズの分だけ探索
                            for (diff_x = 0; diff_x < size_x; diff_x++)
                            {
                                for (diff_y = 0; diff_y < size_y; diff_y++)
                                {
                                    // もし一つでも0ならグループ化できないからフラグを下ろしておく
                                    if (truth_table_array[(start_x + diff_x) % VAR_NUM, (start_y + diff_y) % VAR_NUM] == 0)
                                    {
                                        isTrue = false;
                                    }
                                }
                            }
                            // もし全部1でも他のグループでカバーできていればグループ化は不必要だから確認してみる
                            // 逆に言うと，一つでもグループ化されていないマスがあれば，グループ化しちゃおう
                            if (isTrue)
                            {
                                for (int i = start_x; i < size_x + start_x; i++)
                                {
                                    for (int j = start_y; j < size_y + start_y; j++)
                                    {
                                        if (this.shouldGrouped[(i) % VAR_NUM, (j) % VAR_NUM]) whetherGrouped = true;
                                    }
                                }
                                // グループ化するべき組み合わせならば
                                if (whetherGrouped)
                                {
                                    // グループ化のリストに左上のマスと右下のマスを保存
                                    this.groupOfVariable.Add(new int[4] { start_x, start_y, (start_x + diff_x - 1) % VAR_NUM, (start_y + diff_y - 1) % VAR_NUM });
                                    for (int i = start_x; i < size_x + start_x; i++)
                                    {
                                        // グループ化されたマスたちはもうグループ化しなくてもいいからフラグを下ろしておく
                                        for (int j = start_y; j < size_y + start_y; j++)
                                        {
                                            this.shouldGrouped[(i) % VAR_NUM, (j) % VAR_NUM] = false;
                                        }
                                    }

                                }
                            }
                            // フラグのリセット
                            isTrue = true;
                            whetherGrouped = false;
                        }
                    }
                }
            }
        }
    }
}
