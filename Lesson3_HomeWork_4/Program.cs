using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_HomeWork_4
{
    internal class Program
    {
        //получение случайного числа в диапазоне
        //nBegin - включается; nEnd - не включается
        static int GetRndNumder(int nBegin, int nEnd)
        {
            Random rnd = new Random();
            return rnd.Next(nBegin, nEnd);
        }

        //установка четырехпалубного корабля
        static void SetShip_Size4(bool bVert, int[,] mtxField)
        {
            bool bResult = false;
            do
            {
                //генерация начальных координат
                Random rnd = new Random();
                int i0 = GetRndNumder(1, 11), j0 = GetRndNumder(1, 11);

                //проверка условий расположения корабля
                if (bVert)  //вертикальное
                {
                    int i1 = i0 + 1, i2 = i0 + 2, i3 = i0 + 3;
                    if (i1 <= 10 && i2 <= 10 && i3 <= 10)
                    {
                        bResult = true;

                        //установка корабля
                        mtxField[i0, j0] = 1; mtxField[i1, j0] = 1; mtxField[i2, j0] = 1; mtxField[i3, j0] = 1;

                        //установка запретной зоны
                        mtxField[i0 - 1, j0 - 1] = 2; mtxField[i0 - 1, j0] = 2; mtxField[i0 - 1, j0 + 1] = 2;
                        mtxField[i0, j0 - 1] = 2; mtxField[i0, j0 + 1] = 2;
                        mtxField[i0 + 1, j0 - 1] = 2; mtxField[i0 + 1, j0 + 1] = 2;
                        mtxField[i0 + 2, j0 - 1] = 2; mtxField[i0 + 2, j0 + 1] = 2;
                        mtxField[i0 + 3, j0 - 1] = 2; mtxField[i0 + 3, j0 + 1] = 2;
                        mtxField[i0 + 4, j0 - 1] = 2; mtxField[i0 + 4, j0] = 2; mtxField[i0 + 4, j0 + 1] = 2;
                    }
                }
                else    //горизонтальное
                {
                    int j1 = j0 + 1, j2 = j0 + 2, j3 = j0 + 3;
                    if (j1 <= 10 && j2 <= 10 && j3 <= 10)
                    {
                        bResult = true;

                        //установка корабля
                        mtxField[i0, j0] = 1; mtxField[i0, j1] = 1; mtxField[i0, j2] = 1; mtxField[i0, j3] = 1;

                        //установка запретной зоны
                        mtxField[i0 - 1, j0 - 1] = 2; mtxField[i0, j0 - 1] = 2; mtxField[i0 + 1, j0 - 1] = 2;
                        mtxField[i0 - 1, j0] = 2; mtxField[i0 + 1, j0] = 2;
                        mtxField[i0 - 1, j0 + 1] = 2; mtxField[i0 + 1, j0 + 1] = 2;
                        mtxField[i0 - 1, j0 + 2] = 2; mtxField[i0 + 1, j0 + 2] = 2;
                        mtxField[i0 - 1, j0 + 3] = 2; mtxField[i0 + 1, j0 + 3] = 2;
                        mtxField[i0 - 1, j0 + 4] = 2; mtxField[i0, j0 + 4] = 2; mtxField[i0 + 1, j0 + 4] = 2;
                    }
                }
            } while (!bResult);
        }

        //установка трехпалубного корабля
        static void SetShip_Size3(bool bVert, int[,] mtxField)
        {
            bool bResult = false;
            do
            {
                //генерация начальных координат
                Random rnd = new Random();
                int i0 = GetRndNumder(1, 11), j0 = GetRndNumder(1, 11);

                //проверка условий расположения корабля
                if (bVert)  //вертикальное
                {
                    int i1 = i0 + 1, i2 = i0 + 2;
                    if (i1 <= 10 && i2 <= 10
                        && mtxField[i0, j0] != 1 && mtxField[i0, j0] != 2
                        && mtxField[i1, j0] != 1 && mtxField[i1, j0] != 2
                        && mtxField[i2, j0] != 1 && mtxField[i2, j0] != 2)
                    {
                        bResult = true;

                        //установка корабля
                        mtxField[i0, j0] = 1; mtxField[i1, j0] = 1; mtxField[i2, j0] = 1;

                        //установка запретной зоны
                        mtxField[i0 - 1, j0 - 1] = 2; mtxField[i0 - 1, j0] = 2; mtxField[i0 - 1, j0 + 1] = 2;
                        mtxField[i0, j0 - 1] = 2; mtxField[i0, j0 + 1] = 2;
                        mtxField[i0 + 1, j0 - 1] = 2; mtxField[i0 + 1, j0 + 1] = 2;
                        mtxField[i0 + 2, j0 - 1] = 2; mtxField[i0 + 2, j0 + 1] = 2;
                        mtxField[i0 + 3, j0 - 1] = 2; mtxField[i0 + 3, j0] = 2; mtxField[i0 + 3, j0 + 1] = 2;
                    }
                }
                else   //горизонтальное
                {
                    int j1 = j0 + 1, j2 = j0 + 2;
                    if (j1 <= 10 && j2 <= 10
                        && mtxField[i0, j0] != 1 && mtxField[i0, j0] != 2
                        && mtxField[i0, j1] != 1 && mtxField[i0, j1] != 2
                        && mtxField[i0, j2] != 1 && mtxField[i0, j2] != 2)
                    {
                        bResult = true;

                        //установка корабля
                        mtxField[i0, j0] = 1; mtxField[i0, j1] = 1; mtxField[i0, j2] = 1;

                        //установка запретной зоны
                        mtxField[i0 - 1, j0 - 1] = 2; mtxField[i0, j0 - 1] = 2; mtxField[i0 + 1, j0 - 1] = 2;
                        mtxField[i0 - 1, j0] = 2; mtxField[i0 + 1, j0] = 2;
                        mtxField[i0 - 1, j0 + 1] = 2; mtxField[i0 + 1, j0 + 1] = 2;
                        mtxField[i0 - 1, j0 + 2] = 2; mtxField[i0 + 1, j0 + 2] = 2;
                        mtxField[i0 - 1, j0 + 3] = 2; mtxField[i0, j0 + 3] = 2; mtxField[i0 + 1, j0 + 3] = 2;
                    }
                }
            } while (!bResult);
        }

        //установка двухпалубного корабля
        static void SetShip_Size2(bool bVert, int[,] mtxField)
        {
            bool bResult = false;
            do
            {
                //генерация начальных координат
                Random rnd = new Random();
                int i0 = GetRndNumder(1, 11), j0 = GetRndNumder(1, 11);

                //проверка условий расположения корабля
                if (bVert) //вертикальное 
                {
                    int i1 = i0 + 1;
                    if (i1 <= 10
                        && mtxField[i0, j0] != 1 && mtxField[i0, j0] != 2
                        && mtxField[i1, j0] != 1 && mtxField[i1, j0] != 2)
                    {
                        bResult = true;

                        //установка корабля
                        mtxField[i0, j0] = 1; mtxField[i1, j0] = 1;

                        //установка запретной зоны
                        mtxField[i0 - 1, j0 - 1] = 2; mtxField[i0 - 1, j0] = 2; mtxField[i0 - 1, j0 + 1] = 2;
                        mtxField[i0, j0 - 1] = 2; mtxField[i0, j0 + 1] = 2;
                        mtxField[i0 + 1, j0 - 1] = 2; mtxField[i0 + 1, j0 + 1] = 2;
                        mtxField[i0 + 2, j0 - 1] = 2; mtxField[i0 + 2, j0] = 2; mtxField[i0 + 2, j0 + 1] = 2;
                    }
                }
                else  //горизонтальное
                {
                    int j1 = j0 + 1;
                    if (j1 <= 10
                        && mtxField[i0, j0] != 1 && mtxField[i0, j0] != 2
                        && mtxField[i0, j1] != 1 && mtxField[i0, j1] != 2)
                    {
                        bResult = true;

                        //установка корабля
                        mtxField[i0, j0] = 1; mtxField[i0, j1] = 1;

                        //установка запретной зоны
                        mtxField[i0 - 1, j0 - 1] = 2; mtxField[i0, j0 - 1] = 2; mtxField[i0 + 1, j0 - 1] = 2;
                        mtxField[i0 - 1, j0] = 2; mtxField[i0 + 1, j0] = 2;
                        mtxField[i0 - 1, j0 + 1] = 2; mtxField[i0 + 1, j0 + 1] = 2;
                        mtxField[i0 - 1, j0 + 2] = 2; mtxField[i0, j0 + 2] = 2; mtxField[i0 + 1, j0 + 2] = 2;
                    }
                }
            } while (!bResult);
        }

        //установка однопалубного корабля
        static void SetShip_Size1(int[,] mtxField)
        {
            bool bResult = false;
            do
            {
                //генерация координат корабля
                Random rnd = new Random();
                int i0 = GetRndNumder(1, 11), j0 = GetRndNumder(1, 11);

                //проверка условий
                if (mtxField[i0, j0] != 1 && mtxField[i0, j0] != 2)
                {
                    bResult = true;

                    //установка корабля
                    mtxField[i0, j0] = 1;

                    //установка запретной зоны
                    mtxField[i0 - 1, j0 - 1] = 2; mtxField[i0 - 1, j0] = 2; mtxField[i0 - 1, j0 + 1] = 2;
                    mtxField[i0, j0 - 1] = 2; mtxField[i0, j0 + 1] = 2;
                    mtxField[i0 + 1, j0 - 1] = 2; mtxField[i0 + 1, j0] = 2; mtxField[i0 + 1, j0 + 1] = 2;
                }
            } while (!bResult);
        }

        //установка всех кораблей на игровое поле
        //1 - 4-х палубный
        //2 - 3-х палубных
        //3 - 2-х палубных
        //4 - 1-о палубных
        static void SetAllShips(int[,] mtxField)
        {
            //установка 4-х палубного корабля
            bool bVert = (GetRndNumder(0, 2) == 0) ? true : false;
            SetShip_Size4(bVert, mtxField);

            //установка 3-х палубных кораблей
            bVert = (GetRndNumder(0, 2) == 0) ? true : false;
            SetShip_Size3(bVert, mtxField);
            bVert = (GetRndNumder(0, 2) == 0) ? true : false;
            SetShip_Size3(bVert, mtxField);

            //установка 2-х палубных кораблей
            bVert = (GetRndNumder(0, 2) == 0) ? true : false;
            SetShip_Size2(bVert, mtxField);
            bVert = (GetRndNumder(0, 2) == 0) ? true : false;
            SetShip_Size2(bVert, mtxField);
            bVert = (GetRndNumder(0, 2) == 0) ? true : false;
            SetShip_Size2(bVert, mtxField);

            //установка 1-о палубных кораблей
            SetShip_Size1(mtxField);
            SetShip_Size1(mtxField);
            SetShip_Size1(mtxField);
            SetShip_Size1(mtxField);
        }

        //вывод заполненного поля
        static void PrintField(int[,] mtxField)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    if (mtxField[i, j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("X ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("O ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Урок 3, домашнее задание № 4");

            //создание игрового поля без кораблей
            int[,] mtxField = new int[12, 12];

            //установка кораблей на игровое поле
            SetAllShips(mtxField);

            //вывод игрового поля с кораблями 
            PrintField(mtxField);

            //
            Console.ReadLine();
        }
    }
}
