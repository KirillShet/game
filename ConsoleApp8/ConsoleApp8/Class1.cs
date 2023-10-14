using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Class1
    {
        public string name;
        public int koordinate_x;
        public int koordinate_y;
        public int hp;
        public int hp1;
        public int kol;
        public int sr_znach;
        public int max_hp;
        public bool lager;
        public int dvig;
        public int naprav;
        public int raspr;
        public int osh;
        public int x;
        public int y;
        public int du;

        public void info()
        {
            Console.WriteLine("Введите имя вашего персонажа.");
            name = Console.ReadLine();
            do 
            {
                Console.WriteLine("Введите положение вашего персонажа по оси x (всего от -500 до 500):");
                osh = 0;
                koordinate_x = Convert.ToInt32(Console.ReadLine());
                if (koordinate_x > 500 || koordinate_x < -500)
                {
                    Console.WriteLine("Вы вышли за границы карты.");
                    osh++;
                }
            } while (osh == 1);
            do
            {
                osh = 0;
                Console.WriteLine("Введите положение вашего персонажа по оси y (всего от -500 до 500):");
                koordinate_y = Convert.ToInt32(Console.ReadLine());
                if (koordinate_y > 500 || koordinate_y < -500)
                {
                    Console.WriteLine("Вы вышли за границы карты.");
                    osh++;
                }
            } while (osh == 1);
            Console.WriteLine("Введите количество жизней персонажа: ");
            hp = Convert.ToInt32(Console.ReadLine());
            max_hp = hp;
            hp1 = hp;
            Console.Clear();
        }
        public string nam()
        {
            return name;
        }
        public int kor_x()
        {
            return koordinate_x;
        }
        public void kor_x1()
        {
            x = koordinate_x;
        }
        public int kor_y()
        {
            return koordinate_y;
        }
        public void lager1()
        {
            Random rand = new Random();
            int log = 0;
            Console.WriteLine("Принадлежность к лагерю будет автоматически рандомиться");
            log = rand.Next(1, 11);
            if (log <= 5)
            {
                lager = true;
            }
            else if (log > 5) 
            {
                lager = false;
            }
        }
        public bool lager3()
        {
            return lager;
        }
        public void out_info()
        {
            Console.WriteLine("Вашего персонажа зовут: " + name);
            Console.WriteLine("Ваш персонаж находится в: " + koordinate_x + " по оси x");
            Console.WriteLine("Ваш персонаж находится в: " + koordinate_y + " по оси y");
            Console.WriteLine("Ваш персонаж пренадлежит: " + lager);
            Console.WriteLine("Количество жизней вашего персонажа: " + hp);
        }
        public void dvigx()
        {
            Console.WriteLine("В каком направлении вы хотите сдвинуть своего персонажа?");
            do
            {
                osh = 0;
                Console.WriteLine("Если вы хотите пойти вперед, то введите цифру 1, если назад, то цифру 2.");
                naprav = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (naprav <= 0 || naprav > 2)
                {
                    Console.WriteLine("Вы ввели не то число, которое просили, поэтому персонаж останется на месте.");
                    osh++;
                }
                else
                {
                    Console.WriteLine("На сколько вы хотите сдвинуть своего персонажа по оси x?");
                    dvig = Convert.ToInt32(Console.ReadLine());
                    if (naprav == 1)
                    {
                        if (dvig > 0)
                        {
                            if ((koordinate_x + dvig) <= 500)
                            {
                                Console.WriteLine("Вы решили сдвинуть персонажа вперед на: " + dvig);
                                koordinate_x += dvig;
                            }
                            else
                            {
                                Console.WriteLine("Вы вышли за пределы поля.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Персонаж никуда не идет.");
                        }
                    }
                    else if (naprav == 2)
                    {
                        if (dvig > 0)
                        {
                            if ((koordinate_x + dvig) >= -500)
                            {
                                Console.WriteLine("Вы решили сдвинуть персонажа назад на: " + dvig);
                                koordinate_x -= dvig;
                            }
                            else
                            {
                                Console.WriteLine("Вы вышли за пределы поля.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Персонаж никуда не идет.");
                        }
                    }
                }
            } while (osh == 1);
        }
        public void dvigy()
        {
            Console.WriteLine("В каком направлении вы хотите сдвинуть своего персонажа?");
            do
            {
                osh = 0;
                Console.WriteLine("Если вы хотите пойти вверх, то введите цифру 1, если вниз, то цифру 2.");
                naprav = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (naprav <= 0 || naprav > 2)
                {
                    Console.WriteLine("Вы ввели не то число, которое просили, поэтому персонаж останется на месте.");
                    osh++;
                }
                else
                {
                    Console.WriteLine("На сколько вы хотите сдвинуть своего персонажа по оси y?");
                    dvig = Convert.ToInt32(Console.ReadLine());
                    if (naprav == 1)
                    {
                        if (dvig > 0)
                        {
                            if ((koordinate_y + dvig) <= 500)
                            {
                                Console.WriteLine("Вы решили сдвинуть персонажа вверх на: " + dvig);
                                koordinate_y += dvig;
                            }
                            else
                            {
                                Console.WriteLine("Вы вышли за пределы поля.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Персонаж никуда не идет.");
                        }
                    }
                    else if (naprav == 2)
                    {
                        if (dvig > 0)
                        {
                            if ((koordinate_y + dvig) >= -500)
                            {
                                Console.WriteLine("Вы решили сдвинуть персонажа вниз на: " + dvig);
                                koordinate_y -= dvig;
                            }
                            else
                            {
                                Console.WriteLine("Вы вышли за пределы поля.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Персонаж никуда не идет.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не то число, которое просили, поэтому персонаж останется на месте.");
                    }
                }
            } while (osh == 1);
        }
        public void ynichtog()
        {
            Console.WriteLine("Персонаж был уничтожен.");
            name = null;
            hp = 0;
            koordinate_x = -1000; 
            koordinate_y = -1000;
            out_info();
        }
        public void vost()
        {
            if (hp > 0)
            {
                Console.WriteLine("Ваш персонаж был полностью восстановлен.");
                hp = max_hp;
                out_info();
            }
            else
            {
                Console.WriteLine("Персонаж мертв или был уничтожен, поэтому количество хп нельзя изменить.");
            }
        }

        public int hp111()
        {
            return hp;
        }
        public void damage1()
        {
            Random rand = new Random();
            du = rand.Next(1, 50);
        }
        public void srva()
        {
            damage1();
            sr_znach += du;
            kol++;
            sr_znach = sr_znach / kol;
        }
        public void damage()
        {
            if (hp > 0 && hp > sr_znach)
            {
                hp -= sr_znach;
                sr_znach = 0;
                kol = 0;
                Console.WriteLine("У персонажа осталось: " + hp + " хп");
            }
            else if (hp > 0 && hp < sr_znach)
            {
                hp = 0;
                sr_znach = 0;
                kol = 0;
                Console.WriteLine("Персонаж был убит.");
            }
            else if (hp > 0 && hp == sr_znach)
            {
                hp = 0;
                sr_znach = 0;
                kol = 0;
                Console.WriteLine("Персонаж был убит.");
            }
            else if (hp == 0)
            {
                kol = 0;
                sr_znach = 0;
                Console.WriteLine("Этот персонаж уже мертв, поэтому вы не можете атаковать его.");
            }
            else if (sr_znach < 0 || sr_znach == 0)
            {
                kol = 0;
                sr_znach = 0;
                Console.WriteLine("Персонажу не нанесен урон.");
            }
        }
        public int ver()
        {
            return sr_znach;
        }
        public int game()
        {
            return du;
        }
        public void lager2()
        {
            if (hp <= 0)
            {
                Console.WriteLine("Персонаж был убит, поэтому нельзя поменять его лагерь.");
            }
            else
            {
                Console.WriteLine("Вы сменили лагерь персонажа.");
                if (lager == true)
                {
                    lager = false;
                }
                else
                {
                    lager = true;
                }
                out_info();
            }
        }
        public void lech(int lec)
        {
            Console.WriteLine("Количество хп будет рандомно восстанавливаться от 1 до 100.");
            Random rand = new Random();
            lec = rand.Next(1, 100);
            if (lec > max_hp)
            {
                Console.WriteLine("Количество хп было повышено до максимального.");
                hp = max_hp;
            }
            else if (lec > 0 && hp > 0)
            {
                if ((hp + lec) < max_hp)
                {
                    hp += lec;
                    Console.WriteLine("Количество хп персонажа было повышено на " + lec + " и теперь у персонажа всего:" + hp + " хп");
                }
                else if ((hp + lec) >= max_hp)
                {
                    hp = max_hp;
                    Console.WriteLine("Количество хп было повышено до максимального.");
                }
            }
            else if (lec < 0 || lec == 0)
            {
                Console.WriteLine("Количество хп у вашего персонажа не уизменилось.");
            }
            out_info();
        }
    }
}