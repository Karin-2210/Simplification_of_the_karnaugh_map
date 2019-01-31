using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplification_of_the_karnaugh_map
{
    public class Make_Simplification_Formula
    {
        private View _ViewInstance;
        public void Make_formula(int first_X, int first_Y, int second_X, int second_Y, int option)
        {
            _ViewInstance = View.ViewInstance;
            int i;
            /*option
            1:4つに割れる場合
            0:それ以外
            */
            switch (option)
            {
                case 1:
                    _ViewInstance.Simplification_Formula.Text += "/BD";
                    break;
                case 0:
                    int[,] char_table = new int[4, 2] { { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 } };
                    if ((second_X - first_X == 1 || second_X - first_X == -3) && (second_Y - first_Y == 1 || second_Y - first_Y == -3))//4つの丸
                    {
                        if (first_X == 0)
                        {
                            char_table[0, 0] = 1;
                            char_table[0, 1] = 1;
                        }
                        else if (first_X == 1)
                        {
                            char_table[1, 0] = 1;
                            char_table[1, 1] = 0;
                        }
                        else if (first_X == 2)
                        {
                            char_table[0, 0] = 1;
                            char_table[0, 1] = 0;
                        }
                        else
                        {
                            char_table[1, 0] = 1;
                            char_table[1, 1] = 1;
                        }
                        if (first_Y == 0)
                        {
                            char_table[2, 0] = 1;
                            char_table[2, 1] = 1;
                        }
                        else if (first_Y == 1)
                        {
                            char_table[3, 0] = 1;
                            char_table[3, 1] = 0;
                        }
                        else if (first_Y == 2)
                        {
                            char_table[2, 0] = 1;
                            char_table[2, 1] = 0;
                        }
                        else
                        {
                            char_table[3, 0] = 1;
                            char_table[3, 1] = 1;
                        }
                    }
                    else if (second_X - first_X == 3 && (second_Y - first_Y == 0 || second_Y - first_Y == -3))//横8個の楕円
                    {
                        if (first_Y == 0)
                        {
                            char_table[2, 0] = 1;
                            char_table[2, 1] = 1;
                        }
                        else if (first_Y == 1)
                        {
                            char_table[3, 0] = 1;
                            char_table[3, 1] = 0;
                        }
                        else if (first_Y == 2)
                        {
                            char_table[2, 0] = 1;
                            char_table[2, 1] = 0;
                        }
                        else
                        {
                            char_table[3, 0] = 1;
                            char_table[3, 1] = 1;
                        }
                    }
                    else if (second_Y - first_Y == 3 && (second_X - first_X == 0 || second_X - first_X == -3))//縦8個の楕円
                    {
                        if (first_X == 0)
                        {
                            char_table[0, 0] = 1;
                            char_table[0, 1] = 1;
                        }
                        else if (first_X == 1)
                        {
                            char_table[1, 0] = 1;
                            char_table[1, 1] = 0;
                        }
                        else if (first_X == 2)
                        {
                            char_table[0, 0] = 1;
                            char_table[0, 1] = 0;
                        }
                        else
                        {
                            char_table[1, 0] = 1;
                            char_table[1, 1] = 1;
                        }
                    }
                    else if (second_X - first_X == 3)//横4個の楕円
                    {
                        switch (first_Y)
                        {
                            case 0:
                                char_table[2, 0] = 1;
                                char_table[2, 1] = 1;
                                char_table[3, 0] = 1;
                                char_table[3, 1] = 1;
                                break;
                            case 1:
                                char_table[2, 0] = 1;
                                char_table[2, 1] = 1;
                                char_table[3, 0] = 1;
                                char_table[3, 1] = 0;
                                break;
                            case 2:
                                char_table[2, 0] = 1;
                                char_table[2, 1] = 0;
                                char_table[3, 0] = 1;
                                char_table[3, 1] = 0;
                                break;
                            case 3:
                                char_table[2, 0] = 1;
                                char_table[2, 1] = 0;
                                char_table[3, 0] = 1;
                                char_table[3, 1] = 1;
                                break;
                        }
                    }
                    else if (second_Y - first_Y == 3)//縦4つの楕円
                    {
                        switch (first_X)
                        {
                            case 0:
                                char_table[0, 0] = 1;
                                char_table[0, 1] = 1;
                                char_table[1, 0] = 1;
                                char_table[1, 1] = 1;
                                break;
                            case 1:
                                char_table[0, 0] = 1;
                                char_table[0, 1] = 1;
                                char_table[1, 0] = 1;
                                char_table[1, 1] = 0;
                                break;
                            case 2:
                                char_table[0, 0] = 1;
                                char_table[0, 1] = 0;
                                char_table[1, 0] = 1;
                                char_table[1, 1] = 0;
                                break;
                            case 3:
                                char_table[0, 0] = 1;
                                char_table[0, 1] = 0;
                                char_table[1, 0] = 1;
                                char_table[1, 1] = 1;
                                break;
                        }
                    }
                    else if (first_Y == second_Y && (second_X - first_X == 1 || second_X - first_X == -3))//横2個の楕円
                    {
                        switch (first_Y)
                        {
                            case 0:
                                char_table[2, 0] = 1;
                                char_table[2, 1] = 1;
                                char_table[3, 0] = 1;
                                char_table[3, 1] = 1;
                                break;
                            case 1:
                                char_table[2, 0] = 1;
                                char_table[2, 1] = 1;
                                char_table[3, 0] = 1;
                                char_table[3, 1] = 0;
                                break;
                            case 2:
                                char_table[2, 0] = 1;
                                char_table[2, 1] = 0;
                                char_table[3, 0] = 1;
                                char_table[3, 1] = 0;
                                break;
                            case 3:
                                char_table[2, 0] = 1;
                                char_table[2, 1] = 0;
                                char_table[3, 0] = 1;
                                char_table[3, 1] = 1;
                                break;
                        }
                        if (first_X == 0)
                        {
                            char_table[0, 0] = 1;
                            char_table[0, 1] = 1;
                        }
                        else if (first_X == 1)
                        {
                            char_table[1, 0] = 1;
                            char_table[1, 1] = 0;
                        }
                        else if (first_X == 2)
                        {
                            char_table[0, 0] = 1;
                            char_table[0, 1] = 0;
                        }
                        else
                        {
                            char_table[1, 0] = 1;
                            char_table[1, 1] = 1;
                        }
                    }
                    else if (first_X == second_X && (second_Y - first_Y == 1 || second_Y - first_Y == -3))//縦2個の楕円
                    {
                        switch (first_X)
                        {
                            case 0:
                                char_table[0, 0] = 1;
                                char_table[0, 1] = 1;
                                char_table[1, 0] = 1;
                                char_table[1, 1] = 1;
                                break;
                            case 1:
                                char_table[0, 0] = 1;
                                char_table[0, 1] = 1;
                                char_table[1, 0] = 1;
                                char_table[1, 1] = 0;
                                break;
                            case 2:
                                char_table[0, 0] = 1;
                                char_table[0, 1] = 0;
                                char_table[1, 0] = 1;
                                char_table[1, 1] = 0;
                                break;
                            case 3:
                                char_table[0, 0] = 1;
                                char_table[0, 1] = 0;
                                char_table[1, 0] = 1;
                                char_table[1, 1] = 1;
                                break;
                        }
                        if (first_Y == 0)
                        {
                            char_table[2, 0] = 1;
                            char_table[2, 1] = 1;
                        }
                        else if (first_Y == 1)
                        {
                            char_table[3, 0] = 1;
                            char_table[3, 1] = 0;
                        }
                        else if (first_Y == 2)
                        {
                            char_table[2, 0] = 1;
                            char_table[2, 1] = 0;
                        }
                        else
                        {
                            char_table[3, 0] = 1;
                            char_table[3, 1] = 1;
                        }
                        

                    }
                    for (i = 0; i < 4; i++) {
                        if (char_table[i, 0]==1) {
                            if (char_table[i, 1] == 1) {
                                _ViewInstance.Simplification_Formula.Text += "/";
                            }
                            char temp = Convert.ToChar(65 + i);
                            _ViewInstance.Simplification_Formula.Text += temp;
                        }
                    }
                    _ViewInstance.Simplification_Formula.Text += "+";
                    break;
            }
        }
    }
}
