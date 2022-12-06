using static System.Console; // Элемент System.Console объявляем статическим. | The System element.Declaring Console static.
// Теперь слово Console не надо нигде писать | Now the word Console does not need to be written anywhere
// Можно также сделать вот так - using Print = System.Console; и теперь вместо Console, можно писть Print - Print.WriteLine();
// You can also do it like this - using Print = System.Console; and now instead of Console, you can put Print - Print.WriteLine();
WriteLine("Кординаты клеток\n");
string[,] table = new string[3, 3]; // Наше игральное поле | Our playing field
int[,] alfa = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; //Поле с координатами | Field with coordinates
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Write($" {alfa[i, j]} ");
    }
    WriteLine(); //Выводим двумерный массив | Output a two-dimensional array
}
WriteLine(); //Делаем отступ | Making an indent
int temp = 1;
int number;
int pres;

while (temp <= 9) // Логика программы | Program logic
{
    if (temp % 2 == 1)
    {
        WriteLine("Ход крестиков");
    }
    else if (temp % 2 == 0)
    {
        WriteLine("Ход ноликов");
    }
    prol();
    CheckTable();
    observ(table);
    check(table);

    temp++;


}

void CheckTable()
{
    if (temp % 2 == 1) // Условие для крестиков | Condition for crosses
    {
        if (pres == 1)
        {
            if (table[0, 0] == null) // Проверяем клетку пустая она или нет | We check the cell whether it is empty or not
            {
                table[0, 0] = "X";

            }
            else
            {
                while (true)
                {
                    WriteLine("Ячейка заполнена"); // Ставим условие если клетка заполнена | We set a condition if the cell is filled
                    prol();
                    if (pres != 1)
                    {
                        break;
                    }
                }
            };
        }
        if (pres == 2)
        {
            if (table[0, 1] == null)
            {
                table[0, 1] = "X";

            }
            else
            {
                while (true)
                {
                    WriteLine("Ячейка заполнена");
                    prol();
                    if (pres != 2)
                    {
                        break;
                    }
                }
            };
        }
        if (pres == 3)
        {
            if (table[0, 2] == null)
            {
                table[0, 2] = "X";

            }
            else
            {
                while (true)
                {
                    WriteLine("Ячейка заполнена");
                    prol();
                    if (pres != 3)
                    {
                        break;
                    }
                }
            };
        }
        if (pres == 4)
        {
            if (table[1, 0] == null)
            {
                table[1, 0] = "X";

            }
            else
            {
                while (true)
                {
                    WriteLine("Ячейка заполнена");
                    prol();
                    if (pres != 4)
                    {
                        break;
                    }
                }
            };
        }
        if (pres == 5)
        {
            if (table[1, 1] == null)
            {
                table[1, 1] = "X";

            }
            else
            {
                while (true)
                {
                    WriteLine("Ячейка заполнена");
                    prol();
                    if (pres != 5)
                    {
                        break;
                    }
                }
            };
        }
        if (pres == 6)
        {
            if (table[1, 2] == null)
            {
                table[1, 2] = "X";

            }
            else
            {
                while (true)
                {
                    WriteLine("Ячейка заполнена");
                    prol();
                    if (pres != 6)
                    {
                        break;
                    }
                }
            };
        }
        if (pres == 7)
        {
            if (table[2, 0] == null)
            {
                table[2, 0] = "X";

            }
            else
            {
                while (true)
                {
                    WriteLine("Ячейка заполнена");
                    prol();
                    if (pres != 7)
                    {
                        break;
                    }
                }
            };
        }
        if (pres == 8)
        {
            if (table[2, 1] == null)
            {
                table[2, 1] = "X";

            }
            else
            {
                while (true)
                {
                    WriteLine("Ячейка заполнена");
                    prol();
                    if (pres != 8)
                    {
                        break;
                    }
                }
            };
        }
        if (pres == 9)
        {
            if (table[2, 2] == null)
            {
                table[2, 2] = "X";

            }
            else
            {
                while (true)
                {
                    WriteLine("Ячейка заполнена");
                    prol();
                    if (pres != 9)
                    {
                        break;
                    }
                }
            };
        }
    }
    if (temp % 2 == 0) // Условие для ноликов | Condition for zeroes
    {
        if (pres == 1)
        {
            if (table[0, 0] == null)
            {
                table[0, 0] = "O";

            }
            else
            {
                while (true)
                {
                    WriteLine("Ячейка заполнена");
                    prol();
                    if (pres != 1)
                    {
                        break;
                    }
                }

            };
        }
        if (pres == 2)
        {
            if (table[0, 1] == null)
            {
                table[0, 1] = "O";

            }
            else
            {
                while (true)
                {
                    WriteLine("Ячейка заполнена");
                    prol();
                    if (pres != 2)
                    {
                        break;
                    }
                }
            };
        }
        if (pres == 3)
        {
            if (table[0, 2] == null)
            {
                table[0, 2] = "O";

            }
            else
            {
                while (true)
                {
                    WriteLine("Ячейка заполнена");
                    prol();
                    if (pres != 3)
                    {
                        break;
                    }
                }
            };
        }
        if (pres == 4)
        {
            if (table[1, 0] == null)
            {
                table[1, 0] = "O";

            }
            else
            {
                while (true)
                {
                    WriteLine("Ячейка заполнена");
                    prol();
                    if (pres != 4)
                    {
                        break;
                    }
                }
            };
        }
        if (pres == 5)
        {
            if (table[1, 1] == null)
            {
                table[1, 1] = "O";

            }
            else
            {
                while (true)
                {
                    WriteLine("Ячейка заполнена");
                    prol();
                    if (pres != 5)
                    {
                        break;
                    }
                }
            };
        }
        if (pres == 6)
        {
            if (table[1, 2] == null)
            {
                table[1, 2] = "O";

            }
            else
            {
                while (true)
                {
                    WriteLine("Ячейка заполнена");
                    prol();
                    if (pres != 6)
                    {
                        break;
                    }
                }
            };
        }
        if (pres == 7)
        {
            if (table[2, 0] == null)
            {
                table[2, 0] = "O";

            }
            else
            {
                while (true)
                {
                    WriteLine("Ячейка заполнена");
                    prol();
                    if (pres != 7)
                    {
                        break;
                    }
                }
            };
        }
        if (pres == 8)
        {
            if (table[2, 1] == null)
            {
                table[2, 1] = "O";

            }
            else
            {
                while (true)
                {
                    WriteLine("Ячейка заполнена");
                    prol();
                    if (pres != 8)
                    {
                        break;
                    }
                }
            };
        }
        if (pres == 9)
        {
            if (table[2, 2] == null)
            {
                table[2, 2] = "O";

            }
            else
            {
                while (true)
                {
                    WriteLine("Ячейка заполнена");
                    prol();
                    if (pres != 9)
                    {
                        break;
                    }
                }
            };
        }
    }
}

void prol() // Ввод координаты | Entering coordinates
{
    vvod();
    PROL();
}

void PROL() // Проверим координату на диапозон | Let's check the coordinate for a range
{
    if (number > 0 && number < 10)
    {
        pres = number;
    }
    else
    {
        WriteLine("Введите кординату ячейки");
        prol();
    }
}
void observ(string[,] a)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Write($" ({a[i, j]}) ");
        }
        WriteLine();

    }
}


void check(string[,] a)
{
    if (a[0, 0] == "X" && a[0, 1] == "X" && a[0, 2] == "X")
    {
        WriteLine("Крестики победили");
        temp = 100;
    }
    else if (a[1, 0] == "X" && a[1, 1] == "X" && a[1, 2] == "X")
    {
        WriteLine("Крестики победили");
        temp = 100;

    }
    else if (a[2, 0] == "X" && a[2, 1] == "X" && a[2, 2] == "X")
    {
        WriteLine("Крестики победили");
        temp = 100;
    }
    else if (a[0, 0] == "X" && a[1, 0] == "X" && a[2, 0] == "X")
    {
        WriteLine("Крестики победили");
        temp = 100;
    }
    else if (a[0, 1] == "X" && a[1, 1] == "X" && a[2, 1] == "X")
    {
        WriteLine("Крестики победили");
        temp = 100;
    }
    else if (a[0, 2] == "X" && a[1, 2] == "X" && a[2, 2] == "X")
    {
        WriteLine("Крестики победили");
        temp = 100;
    }
    else if (a[0, 0] == "X" && a[1, 1] == "X" && a[2, 2] == "X")
    {
        WriteLine("Крестики победили");
        temp = 100;
    }
    else if (a[0, 2] == "X" && a[1, 1] == "X" && a[2, 0] == "X")
    {
        WriteLine("Крестики победили");
        temp = 100;
    }
    else if (a[0, 0] == "O" && a[0, 1] == "O" && a[0, 2] == "O")
    {
        WriteLine("Нолики победили");
        temp = 100;
    }
    else if (a[1, 0] == "O" && a[1, 1] == "O" && a[1, 2] == "O")
    {
        WriteLine("Нолики победили");
        temp = 100;
    }
    else if (a[2, 0] == "O" && a[2, 1] == "O" && a[2, 2] == "O")
    {
        WriteLine("Нолики победили");
        temp = 100;
    }
    else if (a[0, 0] == "O" && a[1, 0] == "O" && a[2, 0] == "O")
    {
        WriteLine("Нолики победили");
        temp = 100;
    }
    else if (a[0, 1] == "O" && a[1, 1] == "O" && a[2, 1] == "O")
    {
        WriteLine("Нолики победили");
        temp = 100;
    }
    else if (a[0, 2] == "O" && a[1, 2] == "O" && a[2, 2] == "O")
    {
        WriteLine("Нолики победили");
        temp = 100;
    }
    else if (a[0, 0] == "O" && a[1, 1] == "O" && a[2, 2] == "O")
    {
        WriteLine("Нолики победили");
        temp = 100;
    }
    else if (a[0, 2] == "O" && a[1, 1] == "O" && a[2, 0] == "O")
    {
        WriteLine("Нолики победили");
        temp = 100;
    }
}

void vvod() // Функция для ввода только целых чисел | Function for entering only integers
{
    while (!int.TryParse(ReadLine(), out number))
    {
        Write("Значение неккоректно");
    }
}


