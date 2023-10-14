using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ConsoleApp8
{
    internal class Programm2
    {
        static void Main()
        {

            int osh2 = 0;
            int kol2 = 0;
            int hp = 0;
            int summa = 0;
            int vabor = 0;
            int numb = 0;
            int osh = 0;
            int sovpad = 0;
            int var = 0;
            int x = 0;
            int x1 = 0;
            int y1 = 0;
            int y = 0;
            bool vrag = true;
            bool vrag1 = false;
            int fight = 0;
            Console.WriteLine("Введите количество персонажей в игре.");
            int kol = 0;
            kol = Convert.ToInt32(Console.ReadLine());
            Class1[] avatar = new Class1[kol];
            Console.WriteLine("Добро пожаловать в игру!");
            osh = 0;
            if (kol <= 0)
            {
                Console.WriteLine("Вы ввели число, которое <= 0, поэтому персонажи не будут созданы.");
                osh++;
                osh2++;
            }
            else if (kol == 1)
            {
                avatar[0] = new Class1();
                avatar[0].info();
                avatar[0].lager1();
            }
            else
            {
                avatar[0] = new Class1();
                avatar[0].info();
                avatar[0].lager1();
                for (int i = 1; i < avatar.Length; i++)
                {
                    do
                    {
                        osh = 0;
                        avatar[i] = new Class1();
                        avatar[i].info();
                        avatar[i].lager1();
                        if (avatar[i].nam() == avatar[i - 1].nam())
                        {
                            osh++;
                            Console.WriteLine("Такое имя уже есть.");
                        }
                    } while (osh == 1);
                }
            }
            while (osh2 == 0)
            {
                osh = 0;
                Console.WriteLine("Введите, за какого персонажа вы хотите играть (от 1 до 10).");
                vabor = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (vabor > avatar.Length)
                {
                    osh++;
                }
                numb = vabor - 1;
                while (osh == 0)
                {
                    sovpad = 0;
                    fight = 0;
                    vrag = avatar[numb].lager3();
                    x = avatar[numb].kor_x();
                    y = avatar[numb].kor_y();
                    for (int i = 0; i < avatar.Length; i++)
                    {
                        x1 = avatar[i].kor_x();
                        y1 = avatar[i].kor_y();
                        vrag1 = avatar[i].lager3();
                        if (x1 == x && y1 == y)
                        {
                            sovpad++;
                            if (vrag != vrag1)
                            {
                                fight++;
                            }
                        }
                    }
                    sovpad -= 1;
                    Console.WriteLine("Количество повторов" + sovpad + " Количествоврагов: " + fight);
                    Console.WriteLine();
                    Console.WriteLine("Выберите, что вы хотите сделать:");
                    Console.WriteLine("Если вы хотите сменить персонажа, то нажмите 1.");
                    Console.WriteLine("Если вы хотите вывести по нему информацию, то нажмите 2.");
                    Console.WriteLine("Если вы хотите изменить положение персонажа по оси x, то нажмите 3.");
                    Console.WriteLine("Если вы хотите изменить положение персонажа по оси y, то нажмите 4.");
                    Console.WriteLine("Если вы хотите уничтожить персонажа, то нажмите 5.");
                    Console.WriteLine("Если вы хотите нанести урон персонажу, то нажмите 6.");
                    Console.WriteLine("Если вы хотите полечить персонажа, то нажмите 7.");
                    Console.WriteLine("Если вы хотите полностью восстановить хп персонажа, то нажмите 8.");
                    Console.WriteLine("Если вы хотите поменять пренадлежность к лагерю, то нажмите 9.");
                    hp = avatar[numb].hp111();
                    var = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (var == 1)
                    {
                        osh++;
                    }
                    else if (var == 2)
                    {
                        avatar[numb].out_info();
                    }
                    else if (var == 3)
                    {
                        if (hp > 0)
                        {
                            avatar[numb].dvigx();
                        }
                        else
                        {
                            Console.WriteLine("Персонаж мертв.");
                        }
                    }
                    else if (var == 4)
                    {
                        if (hp > 0)
                        {
                            avatar[numb].dvigy();
                        }
                        else
                        {
                            Console.WriteLine("Персонаж мертв.");
                        }
                    }
                    else if (var == 5)
                    {
                        avatar[numb].ynichtog();
                    }
                    /*Бой*/
                    else if (var == 6)
                    {
                        if (hp > 0)
                        {
                            if (fight > 0)
                            {
                                for (int i = 0; i < avatar.Length; i++)
                                {
                                    x1 = avatar[i].kor_x();
                                    y1 = avatar[i].kor_y();
                                    vrag1 = avatar[i].lager3();
                                    if (x1 == x && y1 == y)
                                    {
                                        if (vrag == vrag1)
                                        {
                                            avatar[i].srva();
                                        }
                                    }
                                }
                                for (int i = 0; i < avatar.Length; i++)
                                {
                                    x1 = avatar[i].kor_x();
                                    y1 = avatar[i].kor_y();
                                    vrag1 = avatar[i].lager3();
                                    if (x1 == x && y1 == y && vrag != vrag1 && avatar[i].hp111() > 0)
                                    {
                                        avatar[i].damage();
                                        avatar[i].srva();
                                    }
                                }
                                for (int i = 0; i < avatar.Length; i++)
                                {
                                    x1 = avatar[i].kor_x();
                                    y1 = avatar[i].kor_y();
                                    vrag1 = avatar[i].lager3();
                                    if (x1 == x && y1 == y && vrag == vrag1)
                                    {
                                        avatar[i].damage();
                                    }
                                }
                            }
                            else if (fight == 0)
                            {
                                Console.WriteLine("В этом месте не с кем сражаться.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Персонаж мертв."); 
                        }
                    }
                    else if (var == 7)
                    {
                        if (fight > 0)
                        {
                            avatar[numb].lech(50);
                            for (int i = 0; i < avatar.Length; i++)
                            {
                                x1 = avatar[i].kor_x();
                                y1 = avatar[i].kor_y();
                                vrag1 = avatar[i].lager3();
                                if (x1 == x && y1 == y && vrag == vrag1 && avatar[i].hp111() > 0)
                                {
                                    avatar[i].srva();
                                }
                            }
                            for (int i = 0; i < avatar.Length; i++)
                            {
                                x1 = avatar[i].kor_x();
                                y1 = avatar[i].kor_y();
                                vrag1 = avatar[i].lager3();
                                if (x1 == x && y1 == y && vrag == vrag1)
                                {
                                    avatar[i].damage();
                                }
                            }
                        }
                        else if (fight == 0)
                        {
                            avatar[numb].lech(50);
                        }
                    }
                    /*конец боя*/
                    else if (var == 8)
                    {
                        if (fight > 0)
                        {
                            for (int i = 0; i < avatar.Length; i++)
                            {
                                x1 = avatar[i].kor_x();
                                y1 = avatar[i].kor_y();
                                vrag1 = avatar[i].lager3();
                                if (x1 == x && y1 == y && vrag == vrag1)
                                {
                                    if (avatar[i].hp111() > 0)
                                    {
                                        avatar[i].srva();
                                    }
                                }
                            }
                            for (int i = 0; i < avatar.Length; i++)
                            {
                                x1 = avatar[i].kor_x();
                                y1 = avatar[i].kor_y();
                                vrag1 = avatar[i].lager3();
                                if (x1 == x && y1 == y && vrag == vrag1)
                                {
                                    avatar[i].damage();
                                }
                            }
                            avatar[numb].vost();
                        }
                        else if (fight == 0)
                        {
                            avatar[numb].vost();
                        }
                    }
                    else if (var == 9)
                    {
                        avatar[numb].lager2();
                    }

                }
            }
        }
    }
}