using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplification_of_the_karnaugh_map
{
    //真理値表作成モジュールを記述するクラスファイルです．
    public class Truth_table
    {
        
        
        private View _ViewInstance;
        public void Make_Truth_table() {
            string input, variable= System.String.Empty;
            int i,g,j;//ループ用変数
            int[,] Item = new int[4, 2] { { 0, 0 } ,{ 0,0},{ 0,0},{ 0,0} };
            int not_flag=0;//否定判断用変数
            _ViewInstance = View.ViewInstance;
            //Viewの数式入力用テキストボックスからデータを取得
            input = _ViewInstance.Formula.Text;
            input += '\0';
            for (i = 0; i < input.Length; i++)
            {
                if (input[i] == '\0' || input[i] == '+')
                {
                    for (g = 0; g < variable.Length; g++)
                    {
                        if (variable[g] == '/')
                        {
                            not_flag = 1;
                        }
                        else
                        {
                            if (variable[g] == 'A')
                            {
                                Item[0, 0] = 1;
                                Item[0, 1] = not_flag;
                            }
                            else if (variable[g] == 'B')
                            {
                                Item[1, 0] = 1;
                                Item[1, 1] = not_flag;
                            }
                            else if (variable[g] == 'C')
                            {
                                Item[2, 0] = 1;
                                Item[2, 1] = not_flag;
                            }
                            else
                            { 
                                Item[3, 0] = 1;
                                Item[3, 1] = not_flag;
                            }
                            not_flag = 0;
                        }
                    }
                    if (Item[0, 0] == 0)//Aが存在しない場合
                    {
                        if (Item[1, 0] == 0)//A,Bが存在しない場合
                        {
                            if (Item[2, 0] == 0)//A,B,Cが存在しない場合
                            {
                                if (Item[3, 1] == 0)//A,B,Cが存在せず，Dがnotでない場合
                                {
                                    for (j = 0; j < 4; j++)
                                    {
                                        _ViewInstance.truth_table_array[j, 1] = 1;
                                        _ViewInstance.truth_table_array[j, 2] = 1;
                                    }
                                }
                                else//A,B,Cが存在せず，Dがnotの場合
                                {
                                    for (j = 0; j < 4; j++)
                                    {
                                        _ViewInstance.truth_table_array[j, 1] = 1;
                                        _ViewInstance.truth_table_array[j, 2] = 1;
                                    }
                                }
                            }
                            else//A,Bが存在せず，Cが存在する場合
                            {
                                if (Item[2, 1] == 0)//Cがnotではない場合
                                {
                                    if (Item[3, 0] == 0)//Cがnotではない場合でDが存在しない場合
                                    {
                                        for (j = 0; j < 4; j++)
                                        {
                                            _ViewInstance.truth_table_array[j, 2] = 1;
                                            _ViewInstance.truth_table_array[j, 3] = 1;
                                        }
                                    }
                                    else//Cがnotではない場合でDが存在する場合
                                    {
                                        if (Item[3, 1] == 0)//Cがnotではない場合でDがnotでない場合
                                        {
                                            for (j = 0; j < 4; j++)
                                            {
                                                _ViewInstance.truth_table_array[j, 2] = 1;
                                            }
                                        }
                                        else//Cがnotではない場合でDがnot場合
                                        {
                                            for (j = 0; j < 4; j++)
                                            {
                                                _ViewInstance.truth_table_array[j, 3] = 1;
                                            }
                                        }
                                    }

                                }
                                else//Cがnotの場合
                                {
                                    if (Item[3, 0] == 0)//CがnotでDが存在しない場合
                                    {
                                        for (j = 0; j < 4; j++)
                                        {
                                            _ViewInstance.truth_table_array[j, 2] = 1;
                                            _ViewInstance.truth_table_array[j, 3] = 1;
                                        }
                                    }
                                    else//CがnotでDが存在する場合
                                    {
                                        if (Item[3, 1] == 0)//CがnotでDがnotでない場合
                                        {
                                            for (j = 0; j < 4; j++)
                                            {
                                                _ViewInstance.truth_table_array[j, 1] = 1;
                                            }
                                        }
                                        else//CがnotでDもnotの場合
                                        {
                                            for (j = 0; j < 4; j++)
                                            {
                                                _ViewInstance.truth_table_array[j, 0] = 1;
                                            }
                                        }
                                    }
                                }

                            }
                        }
                        else//Aが存在せずBが存在する場合
                        {
                            if (Item[1, 1] == 0)//Bがnotでない場合
                            {
                                if (Item[2, 0] == 0)//Bが存在するがCが存在しない場合
                                {
                                    if (Item[3, 0] == 0)//Bが存在するがCとDが存在しない場合
                                    {
                                        for (j = 0; j < 4; j++)
                                        {
                                            _ViewInstance.truth_table_array[1, j] = 1;
                                            _ViewInstance.truth_table_array[2, j] = 1;
                                        }
                                    }
                                    else//BとDが存在する場合
                                    {
                                        if (Item[3, 1] == 0)//Dがnotでない場合
                                        {
                                            for (j = 1; j < 3; j++)
                                            {
                                                _ViewInstance.truth_table_array[j, 1] = 1;
                                                _ViewInstance.truth_table_array[j, 2] = 1;
                                            }
                                        }
                                        else//Dがnotの場合
                                        {
                                            _ViewInstance.truth_table_array[1, 0] = 1;
                                            _ViewInstance.truth_table_array[2, 0] = 1;
                                            _ViewInstance.truth_table_array[1, 3] = 1;
                                            _ViewInstance.truth_table_array[2, 3] = 1;
                                        }
                                    }
                                    //20181214 10:06
                                }
                                else//BとCが存在する場合
                                {
                                    if (Item[2, 1] == 0)//Cがnotでない場合
                                    {
                                        if (Item[3, 0] == 0)//B,Cが存在し，Dが存在しない場合
                                        {
                                            for (j = 1; j < 3; j++)
                                            {
                                                _ViewInstance.truth_table_array[j, 2] = 1;
                                                _ViewInstance.truth_table_array[j, 3] = 1;
                                            }
                                        }
                                        //20181214 11:42
                                        else//B,C,Dが存在する場合
                                        {
                                            if (Item[3, 1] == 0)//B,Cが存在して，Dがnotでない場合
                                            {
                                                for (j = 1; j < 3; j++)
                                                {
                                                    _ViewInstance.truth_table_array[j, 2] = 1;
                                                }
                                            }
                                            else//B,Cが存在して，Dがnotの場合
                                            {
                                                for (j = 1; j < 3; j++)
                                                {
                                                    _ViewInstance.truth_table_array[j, 3] = 1;
                                                }
                                            }
                                        }

                                    }
                                    else//Cがnotの場合
                                    {
                                        if (Item[3, 0] == 0)//B，notCが存在しDが存在しない場合
                                        {
                                            for (j = 0; j < 2; j++)
                                            {
                                                _ViewInstance.truth_table_array[1, j] = 1;
                                                _ViewInstance.truth_table_array[2, j] = 1;
                                            }
                                        }
                                        else//B，notC,Dが存在する場合
                                        {
                                            if (Item[3, 1] == 0)//Dがnotでない場合
                                            {
                                                for (j = 1; j < 3; j++)
                                                {
                                                    _ViewInstance.truth_table_array[j, 1] = 1;
                                                }
                                            }
                                            else//Dがnotの場合
                                            {
                                                for (j = 1; j < 3; j++)
                                                {
                                                    _ViewInstance.truth_table_array[j, 0] = 1;
                                                }
                                            }
                                        }
                                    }

                                }
                            }
                            else//Bがnotの場合
                            {
                                if (Item[2, 0] == 0)//notBが存在するがCが存在しない場合
                                {
                                    if (Item[3, 0] == 0)//notBが存在するがCとDが存在しない場合
                                    {
                                        for (j = 0; j < 4; j++)
                                        {
                                            _ViewInstance.truth_table_array[0, j] = 1;
                                            _ViewInstance.truth_table_array[3, j] = 1;
                                        }
                                    }
                                    else//notBとDが存在する場合
                                    {
                                        if (Item[3, 1] == 0)//Dがnotでない場合
                                        {
                                            for (j = 1; j < 3; j++)
                                            {
                                                _ViewInstance.truth_table_array[0, j] = 1;
                                                _ViewInstance.truth_table_array[3, j] = 1;
                                            }
                                        }
                                        else//Dがnotの場合
                                        {
                                            _ViewInstance.truth_table_array[0, 0] = 1;
                                            _ViewInstance.truth_table_array[3, 0] = 1;
                                            _ViewInstance.truth_table_array[0, 3] = 1;
                                            _ViewInstance.truth_table_array[3, 3] = 1;

                                        }
                                    }
                                    //20181214 13:03
                                }
                                else//notBとCが存在する場合
                                {
                                    if (Item[2, 1] == 0)//Cがnotでない場合
                                    {
                                        if (Item[3, 0] == 0)//notB,Cが存在し，Dが存在しない場合
                                        {
                                            for (j = 2; j < 4; j++)
                                            {
                                                _ViewInstance.truth_table_array[0, j] = 1;
                                                _ViewInstance.truth_table_array[3, j] = 1;
                                            }
                                        }
                                        else//notB,C,Dが存在する場合
                                        {
                                            if (Item[3, 1] == 0)//notB,Cが存在して，Dがnotでない場合
                                            {
                                                _ViewInstance.truth_table_array[0, 2] = 1;
                                                _ViewInstance.truth_table_array[3, 2] = 1;
                                            }
                                            else//notB,Cが存在して，Dがnotの場合
                                            {
                                                _ViewInstance.truth_table_array[0, 3] = 1;
                                                _ViewInstance.truth_table_array[3, 3] = 1;
                                            }
                                        }

                                    }
                                    else//Cがnotの場合
                                    {
                                        if (Item[3, 0] == 0)//notB，notCが存在しDが存在しない場合
                                        {
                                            for (j = 0; j < 2; j++)
                                            {
                                                _ViewInstance.truth_table_array[0, j] = 1;
                                                _ViewInstance.truth_table_array[3, j] = 1;
                                            }
                                        }
                                        else//notB，notC,Dが存在する場合
                                        {
                                            if (Item[3, 1] == 0)//Dがnotでない場合
                                            {
                                                _ViewInstance.truth_table_array[0, 1] = 1;
                                                _ViewInstance.truth_table_array[3, 1] = 1;
                                            }
                                            else//Dがnotの場合
                                            {
                                                _ViewInstance.truth_table_array[0, 0] = 1;
                                                _ViewInstance.truth_table_array[3, 0] = 1;
                                            }
                                        }
                                    }

                                }
                            }
                        }
                    }
                    else//Aが存在する場合
                    {
                        if (Item[0, 1] == 0)//Aがnotでない場合
                        {
                            if (Item[1, 0] == 0)//Bが存在しない場合
                            {
                                if (Item[2, 0] == 0)//B,Cが存在しない場合
                                {
                                    if (Item[3, 0] == 0)//B,C,Dが存在しない場合
                                    {
                                        for (j = 0; j < 4; j++)
                                        {
                                            _ViewInstance.truth_table_array[2, j] = 1;
                                            _ViewInstance.truth_table_array[3, j] = 1;
                                        }
                                    }
                                    else//A,Dが存在する場合
                                    {
                                        if (Item[3, 1] == 0)//B,Cが存在せず，Dがnotでない場合
                                        {
                                            for (j = 1; j < 3; j++)
                                            {
                                                _ViewInstance.truth_table_array[2, j] = 1;
                                                _ViewInstance.truth_table_array[3, j] = 1;
                                            }
                                        }
                                        else//B,Cが存在せず，Dがnotの場合
                                        {
                                            for (j = 2; j < 4; j++)
                                            {
                                                _ViewInstance.truth_table_array[j, 0] = 1;
                                                _ViewInstance.truth_table_array[j, 3] = 1;
                                            }
                                        }
                                    }
                                }
                                else//Bが存在せず，A,Cが存在する場合
                                {
                                    if (Item[2, 1] == 0)//Cがnotではない場合
                                    {
                                        if (Item[3, 0] == 0)//Cがnotではない場合でDが存在しない場合
                                        {
                                            for (j = 2; j < 4; j++)
                                            {
                                                _ViewInstance.truth_table_array[j, 2] = 1;
                                                _ViewInstance.truth_table_array[j, 3] = 1;
                                            }
                                        }
                                        else//Cがnotではない場合でDが存在する場合
                                        {
                                            if (Item[3, 1] == 0)//Cがnotではない場合でDがnotでない場合
                                            {
                                                for (j = 2; j < 4; j++)
                                                {
                                                    _ViewInstance.truth_table_array[j, 2] = 1;
                                                }
                                            }
                                            else//Cがnotではない場合でDがnot場合
                                            {
                                                for (j = 2; j < 4; j++)
                                                {
                                                    _ViewInstance.truth_table_array[j, 3] = 1;
                                                }
                                            }
                                        }

                                    }
                                    else//Aが存在してCがnotの場合
                                    {
                                        if (Item[3, 0] == 0)//CがnotでDが存在しない場合
                                        {
                                            for (j = 2; j < 4; j++)
                                            {
                                                _ViewInstance.truth_table_array[j, 0] = 1;
                                                _ViewInstance.truth_table_array[j, 1] = 1;
                                            }
                                        }
                                        else//CがnotでDが存在する場合
                                        {
                                            if (Item[3, 1] == 0)//CがnotでDがnotでない場合
                                            {
                                                for (j = 2; j < 4; j++)
                                                {
                                                    _ViewInstance.truth_table_array[j, 1] = 1;
                                                }
                                            }
                                            else//CがnotでDもnotの場合
                                            {
                                                for (j = 2; j < 4; j++)
                                                {
                                                    _ViewInstance.truth_table_array[j, 0] = 1;
                                                }
                                            }
                                        }
                                    }

                                }
                            }
                            else//A,Bが存在する場合
                            {
                                if (Item[1, 1] == 0)//Aが存在しBがnotでない場合
                                {
                                    if (Item[2, 0] == 0)//A,Bが存在するがCが存在しない場合
                                    {
                                        if (Item[3, 0] == 0)//A,Bが存在するがCとDが存在しない場合
                                        {
                                            for (j = 0; j < 4; j++)
                                            {
                                                _ViewInstance.truth_table_array[2, j] = 1;
                                            }
                                        }
                                        else//A,BとDが存在する場合
                                        {
                                            if (Item[3, 1] == 0)//Dがnotでない場合
                                            {
                                                for (j = 1; j < 3; j++)
                                                {
                                                    _ViewInstance.truth_table_array[2, j] = 1;
                                                }
                                            }
                                            else//Dがnotの場合
                                            {
                                                _ViewInstance.truth_table_array[2, 0] = 1;
                                                _ViewInstance.truth_table_array[2, 3] = 1;
                                            }
                                        }
                                        //20181214 14:03
                                    }
                                    else//A,BとCが存在する場合
                                    {
                                        if (Item[2, 1] == 0)//Cがnotでない場合
                                        {
                                            if (Item[3, 0] == 0)//A,B,Cが存在し，Dが存在しない場合
                                            {
                                                for (j = 1; j < 3; j++)
                                                {
                                                    _ViewInstance.truth_table_array[2, j] = 1;
                                                }
                                            }
                                            //20181214 14:06
                                            else//A,B,C,Dが存在する場合
                                            {
                                                if (Item[3, 1] == 0)//A,B,Cが存在して，Dがnotでない場合
                                                {
                                                    _ViewInstance.truth_table_array[2, 2] = 1;
                                                }
                                                else//A,B,Cが存在して，Dがnotの場合
                                                {
                                                    _ViewInstance.truth_table_array[2, 3] = 1;
                                                }
                                            }
                                        }
                                        else//Cがnotの場合
                                        {
                                            if (Item[3, 0] == 0)//A,B，notCが存在しDが存在しない場合
                                            {
                                                for (j = 0; j < 2; j++)
                                                {
                                                    _ViewInstance.truth_table_array[2, j] = 1;
                                                }
                                            }
                                            else//A,B，notC,Dが存在する場合
                                            {
                                                if (Item[3, 1] == 0)//Dがnotでない場合
                                                {
                                                    _ViewInstance.truth_table_array[2, 1] = 1;
                                                }
                                                else//Dがnotの場合
                                                {
                                                    _ViewInstance.truth_table_array[2, 0] = 1;
                                                }
                                            }
                                        }

                                    }
                                }
                                else//Bがnotの場合
                                {
                                    if (Item[2, 0] == 0)//A,notBが存在するがCが存在しない場合
                                    {
                                        if (Item[3, 0] == 0)//A,notBが存在するがCとDが存在しない場合
                                        {
                                            for (j = 0; j < 4; j++)
                                            {
                                                _ViewInstance.truth_table_array[3, j] = 1;
                                            }
                                        }
                                        else//A,notBとDが存在する場合
                                        {
                                            if (Item[3, 1] == 0)//Dがnotでない場合
                                            {
                                                for (j = 1; j < 3; j++)
                                                {
                                                    _ViewInstance.truth_table_array[3, j] = 1;
                                                }
                                            }
                                            else//Dがnotの場合
                                            {
                                                _ViewInstance.truth_table_array[3, 0] = 1;
                                                _ViewInstance.truth_table_array[3, 3] = 1;

                                            }
                                        }
                                        //20181214 14:10
                                    }
                                    else//A,notBとCが存在する場合
                                    {
                                        if (Item[2, 1] == 0)//Cがnotでない場合
                                        {
                                            if (Item[3, 0] == 0)//A,notB,Cが存在し，Dが存在しない場合
                                            {
                                                for (j = 2; j < 4; j++)
                                                {
                                                    _ViewInstance.truth_table_array[3, j] = 1;
                                                }
                                            }
                                            else//A,notB,C,Dが存在する場合
                                            {
                                                if (Item[3, 1] == 0)//A,notB,Cが存在して，Dがnotでない場合
                                                {
                                                    _ViewInstance.truth_table_array[3, 2] = 1;
                                                }
                                                else//notB,Cが存在して，Dがnotの場合
                                                {
                                                    _ViewInstance.truth_table_array[3, 3] = 1;
                                                }
                                            }
                                        }
                                        else//Cがnotの場合
                                        {
                                            if (Item[3, 0] == 0)//A,notB，notCが存在しDが存在しない場合
                                            {
                                                for (j = 0; j < 2; j++)
                                                {
                                                    _ViewInstance.truth_table_array[3, j] = 1;
                                                }
                                            }
                                            else//A,notB，notC,Dが存在する場合
                                            {
                                                if (Item[3, 1] == 0)//Dがnotでない場合
                                                {
                                                    _ViewInstance.truth_table_array[3, 1] = 1;
                                                }
                                                else//Dがnotの場合
                                                {
                                                    _ViewInstance.truth_table_array[3, 0] = 1;
                                                }
                                            }
                                        }

                                    }
                                }
                            }
                        }
                        else//Aがnotの場合
                        {
                            if (Item[1, 0] == 0)//Bが存在しない場合
                            {
                                if (Item[2, 0] == 0)//B,Cが存在しない場合
                                {
                                    if (Item[3, 0] == 0)//notAのみが存在しB,C,Dが存在しない場合
                                    {
                                        for (j = 0; j < 4; j++)
                                        {
                                            _ViewInstance.truth_table_array[0, j] = 1;
                                            _ViewInstance.truth_table_array[1, j] = 1;
                                        }
                                    }
                                    else//notA,Dが存在する場合
                                    {
                                        if (Item[3, 1] == 0)//notAが存在し，B,Cが存在せず，Dがnotでない場合
                                        {
                                            for (j = 1; j < 3; j++)
                                            {
                                                _ViewInstance.truth_table_array[0, j] = 1;
                                                _ViewInstance.truth_table_array[1, j] = 1;
                                            }
                                        }
                                        else//notAが存在し，B,Cが存在せず，Dがnotの場合
                                        {
                                            for (j = 0; j < 2; j++)
                                            {
                                                _ViewInstance.truth_table_array[j, 0] = 1;
                                                _ViewInstance.truth_table_array[j, 3] = 1;
                                            }
                                        }
                                    }
                                }
                                else//Bが存在せず，notA,Cが存在する場合
                                {
                                    if (Item[2, 1] == 0)//notAが存在してCがnotではない場合
                                    {
                                        if (Item[3, 0] == 0)//Cがnotではない場合でDが存在しない場合
                                        {
                                            for (j = 0; j < 2; j++)
                                            {
                                                _ViewInstance.truth_table_array[j, 2] = 1;
                                                _ViewInstance.truth_table_array[j, 3] = 1;
                                            }
                                        }
                                        else//Cがnotではない場合でDが存在する場合(notA,C,D)
                                        {
                                            if (Item[3, 1] == 0)//Cがnotではない場合でDがnotでない場合
                                            {
                                                for (j = 0; j < 2; j++)
                                                {
                                                    _ViewInstance.truth_table_array[j, 2] = 1;
                                                }
                                            }
                                            else//Cがnotではない場合でDがnot場合
                                            {
                                                for (j = 0; j < 2; j++)
                                                {
                                                    _ViewInstance.truth_table_array[j, 3] = 1;
                                                }
                                            }
                                        }

                                    }
                                    else//notAが存在してCがnotの場合
                                    {
                                        if (Item[3, 0] == 0)//CがnotでDが存在しない場合
                                        {
                                            for (j = 0; j < 2; j++)
                                            {
                                                _ViewInstance.truth_table_array[j, 0] = 1;
                                                _ViewInstance.truth_table_array[j, 1] = 1;
                                            }
                                        }
                                        else//CがnotでDが存在する場合
                                        {
                                            if (Item[3, 1] == 0)//CがnotでDがnotでない場合
                                            {
                                                for (j = 0; j < 2; j++)
                                                {
                                                    _ViewInstance.truth_table_array[j, 1] = 1;
                                                }
                                            }
                                            else//CがnotでDもnotの場合
                                            {
                                                for (j = 0; j < 2; j++)
                                                {
                                                    _ViewInstance.truth_table_array[j, 0] = 1;
                                                }
                                            }
                                        }
                                    }

                                }
                            }
                            else//notA,Bが存在する場合
                            {
                                if (Item[1, 1] == 0)//notAが存在しBがnotでない場合
                                {
                                    if (Item[2, 0] == 0)//notA,Bが存在するがCが存在しない場合
                                    {
                                        if (Item[3, 0] == 0)//notA,Bが存在するがCとDが存在しない場合
                                        {
                                            for (j = 0; j < 4; j++)
                                            {
                                                _ViewInstance.truth_table_array[1, j] = 1;
                                            }
                                        }
                                        else//notA,BとDが存在する場合
                                        {
                                            if (Item[3, 1] == 0)//Dがnotでない場合
                                            {
                                                for (j = 1; j < 3; j++)
                                                {
                                                    _ViewInstance.truth_table_array[1, j] = 1;
                                                }
                                            }
                                            else//Dがnotの場合
                                            {
                                                _ViewInstance.truth_table_array[1, 0] = 1;
                                                _ViewInstance.truth_table_array[1, 3] = 1;
                                            }
                                        }
                                        //20181214 14:25
                                    }
                                    else//notA,BとCが存在する場合
                                    {
                                        if (Item[2, 1] == 0)//Cがnotでない場合
                                        {
                                            if (Item[3, 0] == 0)//notA,B,Cが存在し，Dが存在しない場合
                                            {
                                                for (j = 1; j < 3; j++)
                                                {
                                                    _ViewInstance.truth_table_array[1, j] = 1;
                                                }
                                            }
                                            //20181214 14:26
                                            else//A,B,C,Dが存在する場合
                                            {
                                                if (Item[3, 1] == 0)//notA,B,Cが存在して，Dがnotでない場合
                                                {
                                                    _ViewInstance.truth_table_array[1, 2] = 1;
                                                }
                                                else//A,B,Cが存在して，Dがnotの場合
                                                {
                                                    _ViewInstance.truth_table_array[1, 3] = 1;
                                                }
                                            }
                                        }
                                        else//Cがnotの場合
                                        {
                                            if (Item[3, 0] == 0)//notA,B，notCが存在しDが存在しない場合
                                            {
                                                for (j = 0; j < 2; j++)
                                                {
                                                    _ViewInstance.truth_table_array[1, j] = 1;
                                                }
                                            }
                                            else//notA,B，notC,Dが存在する場合
                                            {
                                                if (Item[3, 1] == 0)//Dがnotでない場合
                                                {
                                                    _ViewInstance.truth_table_array[1, 1] = 1;
                                                }
                                                else//Dがnotの場合
                                                {
                                                    _ViewInstance.truth_table_array[1, 0] = 1;
                                                }
                                            }
                                        }

                                    }
                                }
                                else//Bがnotの場合
                                {
                                    if (Item[2, 0] == 0)//notA,notBが存在するがCが存在しない場合
                                    {
                                        if (Item[3, 0] == 0)//notA,notBが存在するがCとDが存在しない場合
                                        {
                                            for (j = 0; j < 4; j++)
                                            {
                                                _ViewInstance.truth_table_array[0, j] = 1;
                                            }
                                        }
                                        else//notA,notBとDが存在する場合
                                        {
                                            if (Item[3, 1] == 0)//Dがnotでない場合
                                            {
                                                for (j = 1; j < 3; j++)
                                                {
                                                    _ViewInstance.truth_table_array[0, j] = 1;
                                                }
                                            }
                                            else//Dがnotの場合
                                            {
                                                _ViewInstance.truth_table_array[0, 0] = 1;
                                                _ViewInstance.truth_table_array[0, 3] = 1;

                                            }
                                        }
                                        //20181214 14:29
                                    }
                                    else//notA,notBとCが存在する場合
                                    {
                                        if (Item[2, 1] == 0)//Cがnotでない場合
                                        {
                                            if (Item[3, 0] == 0)//notA,notB,Cが存在し，Dが存在しない場合
                                            {
                                                for (j = 2; j < 4; j++)
                                                {
                                                    _ViewInstance.truth_table_array[0, j] = 1;
                                                }
                                            }
                                            else//notA,notB,C,Dが存在する場合
                                            {
                                                if (Item[3, 1] == 0)//notA,notB,Cが存在して，Dがnotでない場合
                                                {
                                                    _ViewInstance.truth_table_array[0, 2] = 1;
                                                }
                                                else//notB,Cが存在して，Dがnotの場合
                                                {
                                                    _ViewInstance.truth_table_array[0, 3] = 1;
                                                }
                                            }
                                        }
                                        else//Cがnotの場合
                                        {
                                            if (Item[3, 0] == 0)//notA,notB，notCが存在しDが存在しない場合
                                            {
                                                for (j = 0; j < 2; j++)
                                                {
                                                    _ViewInstance.truth_table_array[0, j] = 1;
                                                }
                                            }
                                            else//notA,notB，notC,Dが存在する場合
                                            {
                                                if (Item[3, 1] == 0)//Dがnotでない場合
                                                {
                                                    _ViewInstance.truth_table_array[0, 1] = 1;
                                                }
                                                else//Dがnotの場合
                                                {
                                                    _ViewInstance.truth_table_array[0, 0] = 1;
                                                }
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }
                    Array.Clear(Item, 1, Item.Length - 1);//Item[0,0]以外をクリア
                    Array.Clear(Item, 0, Item.Length);//全ての要素をクリア
                    variable = System.String.Empty;
                }
                else
                {
                    variable += input[i];
                }

            }
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (_ViewInstance.DontCare_Tables[i, j].Checked == true)
                    {
                        _ViewInstance.truth_table_array[i, j] = 2;
                    }
                }
            }
            for (i = 0; i < 4; i++)
            {
                    Console.WriteLine("{0},{1},{2},{3} ",_ViewInstance.truth_table_array[i,0], _ViewInstance.truth_table_array[i, 1], _ViewInstance.truth_table_array[i, 2], _ViewInstance.truth_table_array[i, 3]);
            }
        }
    }
}
