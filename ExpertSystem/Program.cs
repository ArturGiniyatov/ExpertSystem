using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem
{
    
    class Program
    {
        static void Main(string[] args)
        {
            double c240, c250, c260, c290, c490, c590, c640, c650, c690, c010, c050, c240n, c250n, c260n, c290n, c490n, c590n, c640n, c650n, c690n, c010n, c050n, c240k, c250k, c260k, c290k, c490k, c590k, c640k, c650k, c690k, c010k, c050k, Kn, Rn, Sn, k1, k2, k3, k4, k5, k1n, k2n, k3n, k4n, k5n, S, PI;
#region interface
            Console.WriteLine("=====================================");
            Console.WriteLine("||                                 ||");
            Console.WriteLine("||   Прототип экспертной системы   ||");
            Console.WriteLine("||                                 ||");
            Console.WriteLine("=====================================");
            Console.WriteLine("");
            Console.WriteLine("------------press any key------------");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("   Оценка кредитоспособности предприятия  ");
            Console.WriteLine("");
            Console.WriteLine("Меню команд:");
            Console.WriteLine("");
            Console.WriteLine("A - посмотреть готовые варианты");
            Console.WriteLine("B - ввод новых данных");
            Console.WriteLine("C - о программе");
            Console.WriteLine("");
            Console.WriteLine("Z - ВЫХОД");
#endregion
            ConsoleKeyInfo keypress;
#region gotovy variant
            do
            {
                keypress = Console.ReadKey();
                if (keypress.KeyChar == 'A')
                {
                    Console.Clear();
                    Console.WriteLine("ПРОСМОТР ГОТОВЫХ ВАРИАНТОВ");
                    Console.WriteLine("");
                    Console.WriteLine("D - 1 вариант");
                    Console.WriteLine("E - 2 вариант");
                    Console.WriteLine("F - Назад");
                    do
                    {
                        keypress = Console.ReadKey();
                        #region 1 varint
                        if (keypress.KeyChar == 'D')
                        {
                            Console.Clear();
                            c240n = 3497;
                            c240k = 9194;
                            c250n = 0;
                            c250k = 0;
                            c260n = 205;
                            c260k = 746;
                            c290n = 11592;
                            c290k = 17100;
                            c490n = 11757;
                            c490k = 14392;
                            c590n = 5221;
                            c590k = 7547;
                            c640n = 145;
                            c640k = 156;
                            c650n = 376;
                            c650k = 603;
                            c690n = 12675;
                            c690k = 14998;
                            c010n = 45325;
                            c010k = 91456;
                            c050n = 4546;
                            c050k = 8234;
                            Kn = 6;
                            Rn = 29;
                            Sn = 17;
                            k1n = 0;
                            k2n = 0;
                            k3n = 0;
                            k4n = 0;
                            k5n = 0;
                            /////////////////////
                            c240 = c240k - c240n;
                            c250 = c250k - c250n;
                            c260 = c260k - c260n;
                            c290 = c290k - c290n;
                            c490 = c490k - c490n;
                            c590 = c590k - c590n;
                            c640 = c640k - c640n;
                            c650 = c650k - c650n;
                            c690 = c690k - c690n;
                            c010 = c010k - c010n;
                            c050 = c050k - c050n;
                            k1 = c260 / (c690 - c640 - c650);
                            k1 = 0.12;
                            k2 = (c260 + c250 + c240) / (c690 - c640 - 650);
                            k2 = 0.46;
                            k3 = c290 / (c690 - c640 - 650);
                            k3 = 1.5;
                            k4 = c490 / (c590 + c690 - c640 - c650);
                            k4 = 0.83;
                            k5 = c050 / c010;
                            k5 = 0.12;
                            Console.WriteLine("ПРОВОДИМ РАССЧЕТ И АНАЛИЗ КОЭФФИЦИЕНТОВ:");
                            if (k1 >= 0.2)
                            {                                
                                Console.WriteLine("Коэффициент абсолютной ликвидности имеет значение '{0}' и относится к 1 категории", k1);
                                k1n = 1;
                            }
                            if (k1 >= 0.15 && k1 < 0.2)
                            {                              
                                Console.WriteLine("Коэффициент абсолютной ликвидности имеет значение '{0}' и относится ко 2 категории", k1);
                                k1n = 2;
                            }
                            if (k1 < 0.15)
                            {                                
                                Console.WriteLine("Коэффициент абсолютной ликвидности имеет значение '{0}' и относится к 3 категории", k1);
                                k1n = 3;
                            }
                            if (k2 >= 0.8)
                            {                               
                                Console.WriteLine("Коэффициент срочной ликвидности имеет значение '{0}' и относится к 1 категории", k2);
                                k2n = 1;
                            }
                            if (k2 >= 0.5 && k2 < 0.8)
                            {                                
                                Console.WriteLine("Коэффициент срочной ликвидности имеет значение '{0}' и относится ко 2 категории", k2);
                                k2n = 2;
                            }
                            if (k2 < 0.5)
                            {                               
                                Console.WriteLine("Коэффициент срочной ликвидности имеет значение '{0}' и относится к 3 категории", k2);
                                k2n = 3;
                            }
                            if (k3 >= 2)
                            {                                
                                Console.WriteLine("Коэффициент текущей ликвидности имеет значение '{0}' и относится к 1 категории", k3);
                                k3n = 1;
                            }
                            if (k3 >= 1 && k3 < 2)
                            {                                
                                Console.WriteLine("Коэффициент текущей ликвидности имеет значение '{0}' и относится ко 2 категории", k3);
                                k3n = 2;
                            }
                            if (k3 < 1)
                            {                               
                                Console.WriteLine("Коэффициент текущей ликвидности имеет значение '{0}' и относится к 3 категории", k3);
                                k3n = 3;
                            }
                            if (k4 >= 1)
                            {                              
                                Console.WriteLine("Коэффициент соотношения собственных и заемных средств имеет значение '{0}' и относится к 1 категории", k4);
                                k4n = 1;
                            }
                            if (k4 >= 0.7 && k4 < 1)
                            {                                
                                Console.WriteLine("Коэффициент соотношения собственных и заемных средств имеет значение '{0}' и относится ко 2 категории", k4);
                                k4n = 2;
                            }
                            if (k4 < 0.7)
                            {                               
                                Console.WriteLine("Коэффициент соотношения собственных и заемных средств имеет значение '{0}' и относится к 3 категории", k4);
                                k4n = 3;
                            }
                            if (k5 >= 0.15)
                            {                                
                                Console.WriteLine("Рентабельность продукции имеет значение '{0}' и относится к 1 категории", k5);
                                k5n = 1;
                            }
                            if (k5 > 0 && k5 < 0.15)
                            {                              
                                Console.WriteLine("Рентабельность продукции имеет значение '{0}' и относится ко 2 категории", k5);
                                k5n = 2;
                            }
                            if (k5 <= 0)
                            {                                
                                Console.Clear();
                                Console.WriteLine("Рентабельность продукции имеет значение '{0}' и относится к 3 категории", k5);
                                Console.WriteLine("");
                                Console.WriteLine("ПРОДУКЦИЯ ПРЕДПРИЯТИЯ НЕРЕНТАБЕЛЬНА");
                                Console.WriteLine("         В КРЕДИТЕ ОТКАЗАНО");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("РАССЧЕТ ИТОГОВОГО РЕЙТИНГА");
                            S = (0.11 * k1n + 0.05 * k2n + 0.42 * k3n + 0.21 * k4n + 0.21 * k5n);
                            Console.Write("Итоговый рейтинг предприятия = {0}  ———>  ", S);
                            if (S < 1.05)
                            {
                                Console.WriteLine("предприятие относится к 'ПЕРВОМУ КЛАССУ'");
                                S = 987654321;
                            }
                            if (S >= 1.05 & S < 2.42)
                            {
                                Console.WriteLine("предприятие относится ко 'ВТОРОМУ КЛАССУ'");
                                S = 192837465;
                            }
                            else
                            {
                                Console.WriteLine("предприятие относится к 'ТРЕТЬЕМУ КЛАССУ'");
                                S = 123456789;
                            }
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("РАССЧЕТ ПОКАЗАТЕЛЕЙ ПРОЕКТА");
                            PI = 100 / (Kn * (Rn - Sn));
                            PI = 1.1;
                            Console.Write("Итоговый рейтинг проекта = {0}  ———>  ", PI);
                            if (PI >= 1.2)
                            {
                                Console.WriteLine("проект 'РЕНТАБЕЛЬНЫЙ'");
                                PI = 987654321;
                            }
                            if (PI < 1.2 && PI >= 1.0)
                            {
                                Console.WriteLine("проект 'НИЗКОРЕНТАБЕЛЬНЫМ'");
                                PI = 192837465;
                            }
                            if (PI < 1.0)
                            {
                                Console.WriteLine("проект 'НЕРЕНТАБЕЛЬНЫЙ'");
                                Console.Clear();
                                Console.WriteLine("ПРОЕКТ ПРЕДПРИЯТИЯ НЕРЕНТАБЕЛЕН");
                                Console.WriteLine("      В КРЕДИТЕ ОТКАЗАНО");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("ИТОГОВОЕ РЕШЕНИЕ:");
                            if (S == 987654321 && PI == 987654321)
                            {
                                Console.WriteLine("Поздравляем! Кредит одобрен");
                            }
                            if (S == 987654321 && PI == 192837465)
                            {
                                Console.WriteLine("Поздравляем! Кредит одобрен");
                            }
                            if (S == 192837465 && PI == 987654321)
                            {
                                Console.WriteLine("Поздравляем! Кредит одобрен");
                            }
                            if (S == 192837465 && PI == 192837465)
                            {
                                Console.WriteLine("Одобрить с дополнительными условиями");
                            }
                            if (S == 123456789 && PI == 987654321)
                            {
                                Console.WriteLine("Одобрить с дополнительными условиями");
                            }
                            Console.ReadKey();
                        }
                        #endregion
                        #region 2 variant
                        if (keypress.KeyChar == 'E')
                        {
                            Console.Clear();
                            c240n = 3497;
                            c240k = 9194;
                            c250n = 0;
                            c250k = 0;
                            c260n = 205;
                            c260k = 746;
                            c290n = 11592;
                            c290k = 17100;
                            c490n = 11757;
                            c490k = 14392;
                            c590n = 5221;
                            c590k = 7547;
                            c640n = 145;
                            c640k = 156;
                            c650n = 376;
                            c650k = 603;
                            c690n = 12675;
                            c690k = 14998;
                            c010n = 45325;
                            c010k = 91456;
                            c050n = 4546;
                            c050k = 8234;
                            Kn = 6;
                            Rn = 29;
                            Sn = 17;
                            k1n = 0;
                            k2n = 0;
                            k3n = 0;
                            k4n = 0;
                            k5n = 0;
                            /////////////////////
                            c240 = c240k - c240n;
                            c250 = c250k - c250n;
                            c260 = c260k - c260n;
                            c290 = c290k - c290n;
                            c490 = c490k - c490n;
                            c590 = c590k - c590n;
                            c640 = c640k - c640n;
                            c650 = c650k - c650n;
                            c690 = c690k - c690n;
                            c010 = c010k - c010n;
                            c050 = c050k - c050n;
                            k1 = c260 / (c690 - c640 - c650);
                            k2 = (c260 + c250 + c240) / (c690 - c640 - 650);
                            k3 = c290 / (c690 - c640 - 650);
                            k4 = c490 / (c590 + c690 - c640 - c650);
                            k5 = c050 / c010;
                            Console.WriteLine("ПРОВОДИМ РАССЧЕТ И АНАЛИЗ КОЭФФИЦИЕНТОВ:");
                            if (k1 >= 0.2)
                            {
                                Console.WriteLine("Коэффициент абсолютной ликвидности имеет значение '{0}' и относится к 1 категории", k1);
                                k1n = 1;
                            }
                            if (k1 >= 0.15 && k1 < 0.2)
                            {
                                Console.WriteLine("Коэффициент абсолютной ликвидности имеет значение '{0}' и относится ко 2 категории", k1);
                                k1n = 2;
                            }
                            if (k1 < 0.15)
                            {
                                Console.WriteLine("Коэффициент абсолютной ликвидности имеет значение '{0}' и относится к 3 категории", k1);
                                k1n = 3;
                            }
                            if (k2 >= 0.8)
                            {
                                Console.WriteLine("Коэффициент срочной ликвидности имеет значение '{0}' и относится к 1 категории", k2);
                                k2n = 1;
                            }
                            if (k2 >= 0.5 && k2 < 0.8)
                            {
                                Console.WriteLine("Коэффициент срочной ликвидности имеет значение '{0}' и относится ко 2 категории", k2);
                                k2n = 2;
                            }
                            if (k2 < 0.5)
                            {
                                Console.WriteLine("Коэффициент срочной ликвидности имеет значение '{0}' и относится к 3 категории", k2);
                                k2n = 3;
                            }
                            if (k3 >= 2)
                            {
                                Console.WriteLine("Коэффициент текущей ликвидности имеет значение '{0}' и относится к 1 категории", k3);
                                k3n = 1;
                            }
                            if (k3 >= 1 && k3 < 2)
                            {
                                Console.WriteLine("Коэффициент текущей ликвидности имеет значение '{0}' и относится ко 2 категории", k3);
                                k3n = 2;
                            }
                            if (k3 < 1)
                            {
                                Console.WriteLine("Коэффициент текущей ликвидности имеет значение '{0}' и относится к 3 категории", k3);
                                k3n = 3;
                            }
                            if (k4 >= 1)
                            {
                                Console.WriteLine("Коэффициент соотношения собственных и заемных средств имеет значение '{0}' и относится к 1 категории", k4);
                                k4n = 1;
                            }
                            if (k4 >= 0.7 && k4 < 1)
                            {
                                Console.WriteLine("Коэффициент соотношения собственных и заемных средств имеет значение '{0}' и относится ко 2 категории", k4);
                                k4n = 2;
                            }
                            if (k4 < 0.7)
                            {
                                Console.WriteLine("Коэффициент соотношения собственных и заемных средств имеет значение '{0}' и относится к 3 категории", k4);
                                k4n = 3;
                            }
                            if (k5 >= 0.15)
                            {
                                Console.WriteLine("Рентабельность продукции имеет значение '{0}' и относится к 1 категории", k5);
                                k5n = 1;
                            }
                            if (k5 > 0 && k5 < 0.15)
                            {
                                Console.WriteLine("Рентабельность продукции имеет значение '{0}' и относится ко 2 категории", k5);
                                k5n = 2;
                            }
                            if (k5 <= 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Рентабельность продукции имеет значение '{0}' и относится к 3 категории", k5);
                                Console.WriteLine("");
                                Console.WriteLine("ПРОДУКЦИЯ ПРЕДПРИЯТИЯ НЕРЕНТАБЕЛЬНА");
                                Console.WriteLine("         В КРЕДИТЕ ОТКАЗАНО");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("РАССЧЕТ ИТОГОВОГО РЕЙТИНГА");
                            S = (0.11 * k1n + 0.05 * k2n + 0.42 * k3n + 0.21 * k4n + 0.21 * k5n);
                            Console.Write("Итоговый рейтинг предприятия = {0}  ———>  ", S);
                            if (S < 1.05)
                            {
                                Console.WriteLine("предприятие относится к 'ПЕРВОМУ КЛАССУ'");
                                S = 987654321;
                            }
                            if (S >= 1.05 & S < 2.42)
                            {
                                Console.WriteLine("предприятие относится ко 'ВТОРОМУ КЛАССУ'");
                                S = 192837465;
                            }
                            else
                            {
                                Console.WriteLine("предприятие относится к 'ТРЕТЬЕМУ КЛАССУ'");
                                S = 123456789;
                            }
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("РАССЧЕТ ПОКАЗАТЕЛЕЙ ПРОЕКТА");
                            PI = 100 / (Kn * (Rn - Sn));
                            PI = 0.1;
                            Console.Write("Итоговый рейтинг проекта = {0}  ———>  ", PI);
                            if (PI >= 1.2)
                            {
                                Console.WriteLine("проект 'РЕНТАБЕЛЬНЫЙ'");
                                PI = 987654321;
                            }
                            if (PI < 1.2 && PI >= 1.0)
                            {
                                Console.WriteLine("проект 'НИЗКОРЕНТАБЕЛЬНЫМ'");
                                PI = 192837465;
                            }
                            if (PI < 1.0)
                            {
                                Console.WriteLine("проект 'НЕРЕНТАБЕЛЬНЫЙ'");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("ПРОЕКТ ПРЕДПРИЯТИЯ НЕРЕНТАБЕЛЕН");
                                Console.WriteLine("      В КРЕДИТЕ ОТКАЗАНО");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("ИТОГОВОЕ РЕШЕНИЕ:");
                            if (S == 987654321 && PI == 987654321)
                            {
                                Console.WriteLine("Поздравляем! Кредит одобрен");
                            }
                            if (S == 987654321 && PI == 192837465)
                            {
                                Console.WriteLine("Поздравляем! Кредит одобрен");
                            }
                            if (S == 192837465 && PI == 987654321)
                            {
                                Console.WriteLine("Поздравляем! Кредит одобрен");
                            }
                            if (S == 192837465 && PI == 192837465)
                            {
                                Console.WriteLine("Одобрить с дополнительными условиями");
                            }
                            if (S == 123456789 && PI == 987654321)
                            {
                                Console.WriteLine("Одобрить с дополнительными условиями");
                            }
                            Console.ReadKey();
                        }
                        #endregion
                        if (keypress.KeyChar == 'F')
                        {
                            Console.Clear();
                            Console.WriteLine("   Оценка кредитоспособности предприятия  ");
                            Console.WriteLine("");
                            Console.WriteLine("Меню команд:");
                            Console.WriteLine("");
                            Console.WriteLine("A - посмотреть готовые варианты");
                            Console.WriteLine("B - ввод новых данных");
                            Console.WriteLine("C - о программе");
                            Console.WriteLine("");
                            Console.WriteLine("Z - ВЫХОД");
                        }
                    } while (keypress.KeyChar != 'F');
                }
#endregion
#region vvod danyh
                if (keypress.KeyChar == 'B')
                {
                    Console.Clear();
                    Console.WriteLine("ВВОД НОВЫХ ДАННЫХ");
                    Console.WriteLine("");
                    Console.WriteLine("Вы уверены что хотите ввести собственные данные?");
                    Console.WriteLine(">G - Да, ввести данные");
                    Console.WriteLine(">H - Нет, вернуться в предыдущее меню");
                    do
                    {
                        keypress = Console.ReadKey();
                        if (keypress.KeyChar == 'G')
                        {
                            Console.Clear();
#region vvod
                            Console.WriteLine("На основе форма № 1 «Бухгалтерский баланс» заполните следующие данные");
                            Console.WriteLine("");
                            Console.WriteLine("* Введите значение счета №240");
                            Console.Write("На начало отчетного периода — ");
                            c240n = double.Parse(Console.ReadLine());
                            Console.Write("На конец отчетного периода — ");
                            c240k = double.Parse(Console.ReadLine());

                            Console.WriteLine("");
                            Console.WriteLine("* Введите значение счета №250");
                            Console.Write("На начало отчетного периода — ");
                            c250n = double.Parse(Console.ReadLine());
                            Console.Write("На конец отчетного периода — ");
                            c250k = double.Parse(Console.ReadLine());

                            Console.WriteLine("");
                            Console.WriteLine("* Введите значение счета №260");
                            Console.Write("На начало отчетного периода — ");
                            c260n = double.Parse(Console.ReadLine());
                            Console.Write("На конец отчетного периода — ");
                            c260k = double.Parse(Console.ReadLine());

                            Console.WriteLine("");
                            Console.WriteLine("* Введите значение счета №290");
                            Console.Write("На начало отчетного периода — ");
                            c290n = double.Parse(Console.ReadLine());
                            Console.Write("На конец отчетного периода — ");
                            c290k = double.Parse(Console.ReadLine());

                            Console.WriteLine("");
                            Console.WriteLine("* Введите значение счета №490");
                            Console.Write("На начало отчетного периода — ");
                            c490n = double.Parse(Console.ReadLine());
                            Console.Write("На конец отчетного периода — ");
                            c490k = double.Parse(Console.ReadLine());

                            Console.WriteLine("");
                            Console.WriteLine("* Введите значение счета №590");
                            Console.Write("На начало отчетного периода — ");
                            c590n = double.Parse(Console.ReadLine());
                            Console.Write("На конец отчетного периода — ");
                            c590k = double.Parse(Console.ReadLine());

                            Console.WriteLine("");
                            Console.WriteLine("* Введите значение счета №640");
                            Console.Write("На начало отчетного периода — ");
                            c640n = double.Parse(Console.ReadLine());
                            Console.Write("На конец отчетного периода — ");
                            c640k = double.Parse(Console.ReadLine());

                            Console.WriteLine("");
                            Console.WriteLine("* Введите значение счета №650");
                            Console.Write("На начало отчетного периода — ");
                            c650n = double.Parse(Console.ReadLine());
                            Console.Write("На конец отчетного периода — ");
                            c650k = double.Parse(Console.ReadLine());

                            Console.WriteLine("");
                            Console.WriteLine("* Введите значение счета №690");
                            Console.Write("На начало отчетного периода — ");
                            c690n = double.Parse(Console.ReadLine());
                            Console.Write("На конец отчетного периода — ");
                            c690k = double.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("На основе форма № 2 «Отчет о прибылях и убытках» заполните следующие данные");
                            Console.WriteLine("");
                            Console.WriteLine("* Введите значение счета №010");
                            Console.Write("На начало отчетного периода — ");
                            c010n = double.Parse(Console.ReadLine());
                            Console.Write("На конец отчетного периода — ");
                            c010k = double.Parse(Console.ReadLine());

                            Console.WriteLine("");
                            Console.WriteLine("* Введите значение счета №050");
                            Console.Write("На начало отчетного периода — ");
                            c050n = double.Parse(Console.ReadLine());
                            Console.Write("На конец отчетного периода — ");
                            c050k = double.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("На основе показателей проекта заполните следующие данные");                           
                            Console.Write("* Введите размер капитальных вложений в отчетном периоде — ");
                            Kn = double.Parse(Console.ReadLine());
                            Console.Write("* Введите размер дохода за отчетный период — ");
                            Rn = double.Parse(Console.ReadLine());
                            Console.Write("* Введите размер затрат за отчетный период — ");
                            Sn = double.Parse(Console.ReadLine());
                            Console.Clear();
                            k1n = 0;
                            k2n = 0;
                            k3n = 0;
                            k4n = 0;
                            k5n = 0;
                            /////////////////////
                            c240 = c240k - c240n;
                            c250 = c250k - c250n;
                            c260 = c260k - c260n;
                            c290 = c290k - c290n;
                            c490 = c490k - c490n;
                            c590 = c590k - c590n;
                            c640 = c640k - c640n;
                            c650 = c650k - c650n;
                            c690 = c690k - c690n;
                            c010 = c010k - c010n;
                            c050 = c050k - c050n;
                            k1 = c260 / (c690 - c640 - c650);
                            k2 = (c260 + c250 + c240) / (c690 - c640 - 650);
                            k3 = c290 / (c690 - c640 - 650);
                            k4 = c490 / (c590 + c690 - c640 - c650);
                            k5 = c050 / c010;
                            Console.WriteLine("ПРОВОДИМ РАССЧЕТ И АНАЛИЗ КОЭФФИЦИЕНТОВ:");
                            if (k1 >= 0.2)
                            {
                                Console.WriteLine("Коэффициент абсолютной ликвидности имеет значение '{0}' и относится к 1 категории", k1);
                                k1n = 1;
                            }
                            if (k1 >= 0.15 && k1 < 0.2)
                            {
                                Console.WriteLine("Коэффициент абсолютной ликвидности имеет значение '{0}' и относится ко 2 категории", k1);
                                k1n = 2;
                            }
                            if (k1 < 0.15)
                            {
                                Console.WriteLine("Коэффициент абсолютной ликвидности имеет значение '{0}' и относится к 3 категории", k1);
                                k1n = 3;
                            }
                            if (k2 >= 0.8)
                            {
                                Console.WriteLine("Коэффициент срочной ликвидности имеет значение '{0}' и относится к 1 категории", k2);
                                k2n = 1;
                            }
                            if (k2 >= 0.5 && k2 < 0.8)
                            {
                                Console.WriteLine("Коэффициент срочной ликвидности имеет значение '{0}' и относится ко 2 категории", k2);
                                k2n = 2;
                            }
                            if (k2 < 0.5)
                            {
                                Console.WriteLine("Коэффициент срочной ликвидности имеет значение '{0}' и относится к 3 категории", k2);
                                k2n = 3;
                            }
                            if (k3 >= 2)
                            {
                                Console.WriteLine("Коэффициент текущей ликвидности имеет значение '{0}' и относится к 1 категории", k3);
                                k3n = 1;
                            }
                            if (k3 >= 1 && k3 < 2)
                            {
                                Console.WriteLine("Коэффициент текущей ликвидности имеет значение '{0}' и относится ко 2 категории", k3);
                                k3n = 2;
                            }
                            if (k3 < 1)
                            {
                                Console.WriteLine("Коэффициент текущей ликвидности имеет значение '{0}' и относится к 3 категории", k3);
                                k3n = 3;
                            }
                            if (k4 >= 1)
                            {
                                Console.WriteLine("Коэффициент соотношения собственных и заемных средств имеет значение '{0}' и относится к 1 категории", k4);
                                k4n = 1;
                            }
                            if (k4 >= 0.7 && k4 < 1)
                            {
                                Console.WriteLine("Коэффициент соотношения собственных и заемных средств имеет значение '{0}' и относится ко 2 категории", k4);
                                k4n = 2;
                            }
                            if (k4 < 0.7)
                            {
                                Console.WriteLine("Коэффициент соотношения собственных и заемных средств имеет значение '{0}' и относится к 3 категории", k4);
                                k4n = 3;
                            }
                            if (k5 >= 0.15)
                            {
                                Console.WriteLine("Рентабельность продукции имеет значение '{0}' и относится к 1 категории", k5);
                                k5n = 1;
                            }
                            if (k5 > 0 && k5 < 0.15)
                            {
                                Console.WriteLine("Рентабельность продукции имеет значение '{0}' и относится ко 2 категории", k5);
                                k5n = 2;
                            }
                            if (k5 <= 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Рентабельность продукции имеет значение '{0}' и относится к 3 категории", k5);
                                Console.WriteLine("");
                                Console.WriteLine("ПРОДУКЦИЯ ПРЕДПРИЯТИЯ НЕРЕНТАБЕЛЬНА");
                                Console.WriteLine("         В КРЕДИТЕ ОТКАЗАНО");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("РАССЧЕТ ИТОГОВОГО РЕЙТИНГА");
                            S = (0.11 * k1n + 0.05 * k2n + 0.42 * k3n + 0.21 * k4n + 0.21 * k5n);
                            Console.Write("Итоговый рейтинг предприятия = {0}  ———>  ", S);
                            if (S < 1.05)
                            {
                                Console.WriteLine("предприятие относится к 'ПЕРВОМУ КЛАССУ'");
                                S = 987654321;
                            }
                            if (S >= 1.05 & S < 2.42)
                            {
                                Console.WriteLine("предприятие относится ко 'ВТОРОМУ КЛАССУ'");
                                S = 192837465;
                            }
                            else
                            {
                                Console.WriteLine("предприятие относится к 'ТРЕТЬЕМУ КЛАССУ'");
                                S = 123456789;
                            }
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("РАССЧЕТ ПОКАЗАТЕЛЕЙ ПРОЕКТА");
                            PI = 100 / (Kn * (Rn - Sn));
                            Console.Write("Итоговый рейтинг проекта = {0}  ———>  ", PI);
                            if (PI >= 1.2)
                            {
                                Console.WriteLine("проект 'РЕНТАБЕЛЬНЫЙ'");
                                PI = 987654321;
                            }
                            if (PI < 1.2 && PI >= 1.0)
                            {
                                Console.WriteLine("проект 'НИЗКОРЕНТАБЕЛЬНЫМ'");
                                PI = 192837465;
                            }
                            if (PI < 1.0)
                            {
                                Console.WriteLine("проект 'НЕРЕНТАБЕЛЬНЫЙ'");
                                Console.Clear();
                                Console.WriteLine("ПРОЕКТ ПРЕДПРИЯТИЯ НЕРЕНТАБЕЛЕН");
                                Console.WriteLine("      В КРЕДИТЕ ОТКАЗАНО");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("ИТОГОВОЕ РЕШЕНИЕ:");
                            if (S == 987654321 && PI == 987654321)
                            {
                                Console.WriteLine("Поздравляем! Кредит одобрен");
                            }
                            if (S == 987654321 && PI == 192837465)
                            {
                                Console.WriteLine("Поздравляем! Кредит одобрен");
                            }
                            if (S == 192837465 && PI == 987654321)
                            {
                                Console.WriteLine("Поздравляем! Кредит одобрен");
                            }
                            if (S == 192837465 && PI == 192837465)
                            {
                                Console.WriteLine("Одобрить с дополнительными условиями");
                            }
                            if (S == 123456789 && PI == 987654321)
                            {
                                Console.WriteLine("Одобрить с дополнительными условиями");
                            }
                            Console.ReadKey();
                            #endregion
                        }
                        if (keypress.KeyChar == 'H')
                        {
                            Console.Clear();
                            Console.WriteLine("   Оценка кредитоспособности предприятия  ");
                            Console.WriteLine("");
                            Console.WriteLine("Меню команд:");
                            Console.WriteLine("");
                            Console.WriteLine("A - посмотреть готовые варианты");
                            Console.WriteLine("B - ввод новых данных");
                            Console.WriteLine("C - о программе");
                            Console.WriteLine("");
                            Console.WriteLine("Z - ВЫХОД");
                        }
                    } while (keypress.KeyChar != 'H');
                }
                #endregion
#region o programme
                if (keypress.KeyChar == 'C')
                {
                    Console.Clear();
                    Console.WriteLine("О ПРОГРАММЕ");
                    Console.WriteLine("");
                    Console.WriteLine("Целью данной ЭС является выработка непредвзятых экспертных решений по возможности кредитования предприятий");
                    Console.WriteLine("");
                    Console.WriteLine("press J");
                    do
                    {
                        keypress = Console.ReadKey();
                        if (keypress.KeyChar == 'J')
                        {
                            Console.Clear();
                            Console.WriteLine("   Оценка кредитоспособности предприятия  ");
                            Console.WriteLine("");
                            Console.WriteLine("Меню команд:");
                            Console.WriteLine("");
                            Console.WriteLine("A - посмотреть готовые варианты");
                            Console.WriteLine("B - ввод новых данных");
                            Console.WriteLine("C - о программе");
                            Console.WriteLine("");
                            Console.WriteLine("Z - ВЫХОД");
                        }
                    }
                    while (keypress.KeyChar != 'J');
                }
                #endregion
#region exit
                if (keypress.KeyChar == 'Z')
                {
                    Environment.Exit(0);
                }              
            }
            while (keypress.KeyChar != 'Z');
#endregion
        }
    }
}