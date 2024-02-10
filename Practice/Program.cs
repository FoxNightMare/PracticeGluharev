using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        //Opposite number (Math-Task). Вариант 1
        //Описание задачи: Дано некоторое целое число n, нужно вывести его же, но с положительным или отрицательным знаком
        //Вводные данные: int num
        //Задача: Нужно вывести число с противоположным знаком n
        static int OppositeNumber(int num)
        {
            return -num;
        }

        //Uppercase letter(Fundametals-Task) и Name (Fundametals-Task)
        //Описание задачи: Дан текст, где написаны ФИО людей строчными буквами.Вам следует исправить текст
        //Вводные данные: string name
        //Задача: Нужно вывести то же ФИО, но с прописными буквами
        //Например: "иванов иван иванович" → "Иванов Иван Иванович" "петров дмитрий владимирович" → "Петров Дмитрий Владимирович"
        static string UppercaseLetter(string name)
        {
            string TitleCase = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
            return TitleCase;
        }

        //Rock Paper Scissors! (Game-Task)
        //Описание задачи: Два игрока играют в камень, ножницы, бумагу. Изначально первый и второй игрок могут вывести или камень или ножницы или бумагу.
        //Вводные данные: string playerOne, string playerTwo
        //Задача: Нужно вывести текст для игрока, который победит «Игрок 1 победил!» или «Игрок 2 победил!», в ином случае написать «Ничья».
        //Например:	
        //"камень", "ножницы" --> "Игрок 1 победил!"
        //"ножницы", "бумага" --> "Игрок 1 победил!"
        //"бумага", "камень" --> "Игрок 1 победил!"

        //"ножницы", "камень" --> "Игрок 2 победил!"
        //"бумага", "ножницы" --> "Игрок 2 победил!"
        //"камень", "бумага" --> "Игрок 2 победил!"

        //"бумага", "бумага" --> "Ничья!"
        //"ножницы", "ножницы" --> "Ничья!"
        //"камень", "камень" --> "Ничья!"
        static string RockPapperScissors(string playerOne, string playerTwo)
        {
            if (playerOne == playerTwo)
            {
                return "Ничья!";
            }
            else if ((playerOne == "камень" && playerTwo == "ножницы") || (playerOne == "ножницы" && playerTwo == "бумага") || (playerOne == "бумага" && playerTwo == "камень"))
            {
                return "Игрок 1 победил!";
            }
            else
                return "Игрок 2 победил!";
        }

        //Rabbits (Algorithmic-Task)
        //Описание задачи:	Бесконечное число полок расположены одна над другой в шахматном порядке.
        //Кролик может перепрыгнуть либо на одну, либо на три полки за раз: с полки i на полку i+1 или i+3 (кролик не может забраться на полку, расположенную прямо над его головой), в соответствии с рисунком:
        //https://ibb.co/4ZLvX6R
        //Начальные и конечные числа полок(всегда положительные целые числа, конечное число не меньше начального)
        //Вводные данные: int start, int finish
        //Задача:	Найдите минимальное количество прыжков, чтобы пройти путь от старта до финиша
        //Например:	testing(Rabbits(1, 5) --> 2) testing(Rabbits(2, 5) --> 1)
        static int Rabbits(int start, int finish)
        {
            int[] dp = new int[finish + 1];
            dp[start] = 1;
            for (int i = start + 1; i <= finish; i++)
            {
                dp[i] = dp[i - 1];
                if (i >= 3)
                {
                    dp[i] = Math.Min(dp[i], dp[i - 3]);
                }
                dp[i]++;
            }
            return dp[finish] - 1;
        }

        //Reverse list(Fundametals-Task). Вариант 2
        //Описание задачи:	Дается массив из целых чисел
        //Вводные данные:	int[] array
        //Задача:	Нужно вывести его же, но наоборот
        //Например: "3,2,1" → "1,2,3"
        static int[] ReverseArray(int[] array)
        {
            int[] reversedArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[i] = array[array.Length - 1 - i];
            }

            return reversedArray;
        }

        //Bonus? (Math-Task).
        //Описание задачи:	Даны два типа значений - зарплата и премия.Зарплата будет целым числом, а премия - булевой функцией.
        //Вводные данные:	int salary, bool bonus
        //Задача:	Если премия истина, то зарплата должна быть умножена на 10.
        //Если премия ложна, то вывод будет только зарплаты.
        //Итоговая сумма должна быть со знаком «$»
        //Например:	Bonus? (10000, true) → "$100000"; Bonus? (10000, false) → "$10000";
        static string Bonus(int salary, bool bonus)
        {
            int totalSalary = bonus ? salary * 10 : salary;
            return $"${totalSalary}";
        }

        //Drawing the pyramid(Algorithmic-Task).
        //Описание задачи: Представьте что вы художник и у вас стоит задача нарисовать пирамиду.Чтобы ее нарисовать следует использовать символы * и _.
        //Вводные данные: int row
        //Задача: Нужно «нарисовать» пирамиду, где row > 0.
        //В первой строке всегда лишь один символ *
        //В последней строке всегда все символы *
        //При row = 3
        //    __* __
        //    _*** _
        //    *****
        static void DrawingThePyramid(int row)
        {
            if (row <= 0)
            {
                Console.WriteLine("Число строк должно быть больше 0!");
                return;
            }

            for (int i = 0; i < row; i++)
            {
                string spaces = new string('_', row - i - 1);
                string stars = new string('*', 2 * i + 1);

                Console.WriteLine(spaces + stars + spaces);
            }
        }

        //Battle of the characters(Game-Task).
        //Описание задачи:	Группы персонажей решили устроить битву.
        //Правила:
        //У каждого персонажа своя сила: A = 1, B = 2, ... Y = 25, Z = 26
        //Строки состоят только из заглавных букв.
        //В поединке могут участвовать только две группы.
        //Побеждает та группа, чья общая сила (A + B + C + ...) больше.
        //Если силы равны, то это ничья.
        //Вводные данные:	string x, string y
        //Задача:	Помогите им выяснить, какая группа сильнее и выведете ее
        //Например:	battle("ONE", "TWO") --> "TWO - сильнее".
        //battle("FOUR", "FIVE") --> "FOUR - сильнее".
        //battle("ONE", "NEO") --> "Ничья!"
        static string BattleOfTheCharacters(string x, string y)
        {
            int totalPowerX = 0;
            int totalPowerY = 0;

            foreach (char c in x)
            {
                totalPowerX += c - 'A' + 1;
            }

            foreach (char c in y)
            {
                totalPowerY += c - 'A' + 1;
            }

            if (totalPowerX > totalPowerY)
            {
                return $"{x} - сильнее";
            }
            else if (totalPowerY > totalPowerX)
            {
                return $"{y} - сильнее";
            }
            else
            {
                return "Ничья!";
            }
        }

        //Bullets and dragons(Game-Task). Вариант 3
        //Описание задачи: Герой направляется в замок, чтобы выполнить свою миссию.Однако ему сообщили, что замок окружен парой мощных драконов! Для победы над каждым драконом требуется 2 пули, и наш герой не знает, сколько пуль он должен иметь при себе.
        //Вводные данные: int bullets, int dragons
        //Задача:	Выживет ли герой если возьмет заданное количество пуль при?
        //Написать ответ «да» или «нет»
        //Например:	(10, 5) → да
        //(100, 40) → да
        //(4, 5) → нет
        //(1500, 751) → нет
        static string CBulletsAndDragons(int bullets, int dragons)
        {
            // Проверяем, хватит ли пуль у героя для победы над драконами
            int bulletsNeeded = dragons * 2; // Количество пуль, необходимых для всех драконов

            if (bullets >= bulletsNeeded)
            {
                return "да";
            }
            else
            {
                return "нет";
            }
        }

        //Empty(Algorithmic-Task).
        //Описание задачи:	Даны два целых числа, где а<b.
        //Вводные данные:	int a, int b
        //Задача: Выведите через запятую все числа, которые расположены в этом промежутке.Если таких цифр нет, то вывести empty
        //Например:	(1, 5) → 2, 3, 4
        //(10, 11) → «empty»
        static void Empty(int a, int b)
        {
            if (a >= b)
            {
                Console.WriteLine("Ошабка: Первое число больше либо равно второму");
                return;
            }

            bool hasNumbers = false;
            for (int i = a + 1; i < b; i++)
            {
                if (hasNumbers)
                {
                    Console.Write(", ");
                }
                else
                {
                    hasNumbers = true;
                }
                Console.Write(i);
            }

            if (!hasNumbers)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine();
            }
        }

        //Red square(Math-Task).
        //Описание задачи: Завершите функцию, которая вычисляет площадь красного квадрата, если в качестве вводных данных задана длина дуги окружности A.
        //https://ibb.co/3CHk6cp
        //Вводные данные:	double a
        //Задача:	Получите результат, округленный до двух десятичных дробей.
        //Например:	new double[] (2, 1.62),
        //new double[] (0, 0),
        //new double[] (14.05, 80)
        //new double[] (14.05, 80)
        static double RedSquare(double a)
        {
            double side = a / (2 * Math.PI);
            double area = Math.Round(side * side, 2);

            return area;
        }

        //Anagram(Fundametals-Task).
        //Описание задачи:	Анаграмма - это результат перестановки букв слова для получения нового слова
        //Вводные данные:	string test, string original
        //Задача:	*Примечание: анаграммы нечувствительны к регистру.
        //Напишите код, который проверяет являются ли две строки анаграммами друг друга.Ответ вывести как true/false
        //Например:	(mama, amam) → true
        //(jock, lock) → false
        //(Twoo, Woot) → true
        public static bool Anagram(string test, string original)
        {
            if (test == null || original == null || test.Length != original.Length)
            {
                return false;
            }

            string testLower = test.ToLower();
            string originalLower = original.ToLower();

            char[] testArray = testLower.ToCharArray();
            char[] originalArray = originalLower.ToCharArray();

            Array.Sort(testArray);
            Array.Sort(originalArray);

            for (int i = 0; i < testArray.Length; i++)
            {
                if (testArray[i] != originalArray[i])
                {
                    return false;
                }
            }

            return true;
        }

        //PluxOne(Algorithmic-Task). Вариант 4
        //Описание задачи:	Все значения из массива, где а<b
        //Вводные данные:	int x, int y
        //Задача:	Напишите код, который выводит все числа из от a до b и прибавляет к каждому последующему числу 1. Добавьте запятые и пробелы
        //Например:	(1, 5) → "1, 3, 5, 7, 9"
        public static string PluxOne(int a, int b)
        {
            if (a >= b)
            {
                return "No numbers match the criteria.";
            }

            string result = "";
            for (int i = a; i <= b; i++)
            {
                if (i % 2 != 0)
                {
                    result += i + ", ";
                }
            }
            if (!string.IsNullOrEmpty(result))
            {
                result = result.Remove(result.Length - 2);
            }

            return result;
        }

        //Empty(Game-Task).
        //Описание задачи:	Представьте, что вы создаете игру, в которой пользователь должен угадать правильное число.Существует ограничение на количество угадываний, которое может сделать пользователь.
        //Правила:
        //Если пользователь попытается угадать больше, чем указано в лимите, то должно выдать «game over!»
        //Если пользователь угадал правильно, то должно выдать «win!»
        //Если пользователь угадал неправильно, то нужно вывести «wrong!»
        //Вводные данные:	int number, int lives
        //Задача: Написать код под все правила игры
        public static void EmptyGame(int number, int lives)
        {
            int guesses = 0;

            while (guesses < lives)
            {
                Console.Write("Угадайте число: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("win!");
                    return;
                }
                else
                {
                    Console.WriteLine("wrong!");
                    guesses++;
                }
            }

            Console.WriteLine("game over!");
        }

        //Heron's formula (Math-Task).
        //Описание задачи:	Напишите код, который вычисляет площадь треугольника со сторонами a, b и c по формуле:

        //Корень из s*(s-a)*(s-b)*(s-c) и s=(a+b+c)/2, где

        //Вводные данные:	double a, double b, double c
        //Задача:	Напишите код, который вычисляет площадь треугольника по формуле Герона
        //Например:	(3, 4, 5) →6.0 (6, 8, 10)→24.0
        static double HeronsFormula(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double answer = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return answer;
        }



        static void Main(string[] args)
        {
            while (true)
            {
                int variant;
                Console.WriteLine("Выберите вариант от 1 до 4");
                int.TryParse(Console.ReadLine(), out variant);
                if (variant > 4 || variant < 1)
                {
                    Console.WriteLine("Вы не выбрали ни один из вариантов, попробуйте снова");
                }
                else if (variant == 1)
                {
                    Console.WriteLine("Выберите задание от 1 до 4");
                    int Task;
                    int.TryParse(Console.ReadLine(), out Task);
                    if (Task < 1 || Task > 4)
                    {
                        Console.WriteLine("Вы не выбрали ни один из вариантов, попробуйте снова");
                    }
                    else
                    {
                        if (Task == 1)
                        {
                            //Задание 1
                            int n;
                            Console.WriteLine("Задание 1 Opposite number (Math-Task)");
                            Console.Write("Напишите любое число: ");
                            int.TryParse(Console.ReadLine(), out n);
                            int ReversedNum = OppositeNumber(n);
                            Console.WriteLine($"{ReversedNum}");
                        }
                        else if (Task == 2)
                        {
                            //Задание 2
                            bool validInput = false;
                            string name;
                            Console.WriteLine("Задание 2 Uppercase letter (Fundametals-Task)");
                            while (!validInput)
                            {
                                Console.Write("Напишите Фамилию, Имя и Отчетсво: ");
                                name = Console.ReadLine();
                                if (int.TryParse(name, out _))
                                {
                                    Console.WriteLine("Введите ФИО!");
                                    validInput = false;
                                }
                                else
                                {
                                    validInput = true;
                                    string UppLetter = UppercaseLetter(name);
                                    Console.WriteLine(UppLetter);
                                }
                            }
                        }
                        else if (Task == 3)
                        {
                            //Задание 3
                            string playerOne, playerTwo;
                            Console.WriteLine("Задание 3 Rock Paper Scissors! (Game-Task)");
                            Console.Write("Игрок 1, выбирайте камень, ножницы или бумагу: ");
                            bool PlayerOneValidInput = false;
                            bool PlayerTwoValidInput = false;
                            playerOne = Console.ReadLine();
                            while (!PlayerOneValidInput)
                            {
                                if (int.TryParse(playerOne, out _))
                                {
                                    Console.WriteLine("Выбор может быть только камень либо ножницы либо бумага!");
                                    PlayerOneValidInput = false;
                                }
                                else
                                {
                                    PlayerOneValidInput = true;
                                    while (!PlayerTwoValidInput)
                                    {
                                        Console.Write("Игрок 2, выбирайте камень, ножницы или бумагу: ");
                                        playerTwo = Console.ReadLine();
                                        if (int.TryParse(playerTwo, out _))
                                        {
                                            Console.WriteLine("Выбор может быть только камень либо ножницы либо бумага!");
                                        }
                                        else
                                        {
                                            PlayerTwoValidInput = true;
                                            String Winner = RockPapperScissors(playerOne, playerTwo);
                                            Console.WriteLine(Winner);
                                        }
                                    }
                                }
                            }
                        }
                        else if (Task == 4)
                        {
                            //Задание 4
                            bool startValidInput = false;
                            bool finishValidInput = false;
                            int start, finish;
                            Console.WriteLine("Задание 4 Rabbits (Algorithmic-Task)");
                            Console.WriteLine("Добро пожаловать в игру КРОЛИК!");
                            Console.Write("Введите start: ");
                            while (!startValidInput)
                            {
                                if (int.TryParse(Console.ReadLine(), out start))
                                {
                                    while (!finishValidInput)
                                    {
                                        startValidInput = true;
                                        Console.Write("Введите finish: ");
                                        if (int.TryParse(Console.ReadLine(), out finish))
                                        {
                                            finishValidInput = true;
                                            int finne = Rabbits(start, finish);
                                            Console.WriteLine("Вывод: " + finne);
                                        }
                                        else
                                        {
                                            finishValidInput = false;
                                            Console.WriteLine("Неправильный ввод, попробуйте снова!");
                                        }
                                    }
                                }
                                else
                                {
                                    startValidInput = false;
                                    Console.WriteLine("Неправильный ввод, попробуйте снова!");
                                }
                            }
                        }
                    }
                }
                else if (variant == 2)
                {
                    Console.WriteLine("Выберите задание от 1 до 4");
                    int Task;
                    int.TryParse(Console.ReadLine(), out Task);
                    if (Task < 1 || Task > 4)
                    {
                        Console.WriteLine("Вы не выбрали ни один из вариантов, попробуйте снова");
                    }
                    else
                    {
                        if (Task == 1)
                        {
                            //Задание 1
                            Console.WriteLine("Задание 1 Reverse list(Fundametals-Task)");
                            Console.WriteLine("Введите размер массива:");
                            int size = int.Parse(Console.ReadLine());

                            int[] array = new int[size];

                            Console.WriteLine($"Введите {size} чисел через пробел:");

                            string input = Console.ReadLine();
                            string[] numbers = input.Split(' ');

                            for (int i = 0; i < size; i++)
                            {
                                array[i] = int.Parse(numbers[i]);
                            }

                            int[] reversedArray = ReverseArray(array);

                            Console.WriteLine(string.Join(",", reversedArray));
                        }
                        else if (Task == 2)
                        {
                            //Задание 2
                            int salary;
                            bool hasBonus;
                            string choise;
                            bool validInput = false;
                            Console.WriteLine("Задание 2 Bonus? (Math-Task)");
                            Console.Write("Какую вы предпочитаете зарплату?: ");
                            int.TryParse(Console.ReadLine(), out salary);
                            while (!validInput)
                            {
                                Console.Write("Есть ли у вас бонус? - да, - нет: ");
                                choise = Console.ReadLine();
                                if (int.TryParse(choise, out _))
                                {
                                    Console.WriteLine("Необходим только односложный ответ без большой буквы - да, - нет");
                                    validInput = false;
                                }
                                else if (choise == "да")
                                {
                                    validInput = true;
                                    hasBonus = true;
                                    Console.WriteLine($"Bonus? ({salary}, {hasBonus}) → {Bonus(salary, hasBonus)}");

                                }
                                else if (choise == "нет")
                                {
                                    validInput = true;
                                    hasBonus = false;
                                    Console.WriteLine($"Bonus? ({salary}, {hasBonus}) → {Bonus(salary, hasBonus)}");
                                }
                            }
                        }
                        else if (Task == 3)
                        {
                            //Задание 3
                            int row;
                            int.TryParse(Console.ReadLine(), out row);
                            DrawingThePyramid(row);
                        }
                        else if (Task == 4)
                        {
                            //Задание 4
                            Console.WriteLine("Введите первую группу: ");
                            string groupX = Console.ReadLine();

                            Console.WriteLine("Введите вторую группу: ");
                            string groupY = Console.ReadLine();

                            Console.WriteLine(BattleOfTheCharacters(groupX, groupY));
                        }
                    }
                }
                else if (variant == 3)
                {
                    Console.WriteLine("Выберите задание от 1 до 4");
                    int Task;
                    int.TryParse(Console.ReadLine(), out Task);
                    if (Task < 1 || Task > 4)
                    {
                        Console.WriteLine("Вы не выбрали ни один из вариантов, попробуйте снова");
                    }
                    else
                    {
                        if (Task == 1)
                        {
                            //Задание 1
                            Console.WriteLine("Задание 1 Bullets and dragons(Game-Task)");
                            Console.WriteLine("Введите количество пуль и количество драконов через пробел:");
                            string input = Console.ReadLine();

                            string[] inputs = input.Split(' ');
                            int bullets = int.Parse(inputs[0]);
                            int dragons = int.Parse(inputs[1]);

                            Console.WriteLine(CBulletsAndDragons(bullets, dragons));
                        }
                        else if (Task == 2)
                        {
                            //Задание 2
                            Console.WriteLine("Задание 2 Empty(Algorithmic-Task)");
                            Console.WriteLine("Введите значение a:");
                            int a = int.Parse(Console.ReadLine());

                            Console.WriteLine("Введите значение b:");
                            int b = int.Parse(Console.ReadLine());

                            Empty(a, b);

                        }
                        else if (Task == 3)
                        {
                            //Задание 3
                            Console.WriteLine("Задание 3 Red square(Math-Task)");
                            Console.WriteLine("Введите длину дуги окружности A:");
                            if (double.TryParse(Console.ReadLine(), out double a))
                            {
                                double redSquare = RedSquare(a);
                                Console.WriteLine($"Площадь красного квадрата: {redSquare}");
                            }
                            else
                            {
                                Console.WriteLine("Ошибка ввода. Пожалуйста, введите числовое значение.");
                            }
                        }
                        else if (Task == 4)
                        {
                            //Задание 4
                            Console.WriteLine("Задание 4 Anagram(Fundametals-Task)");
                            Console.WriteLine("Введите первую строку:");
                            string str1 = Console.ReadLine();

                            Console.WriteLine("Введите вторую строку:");
                            string str2 = Console.ReadLine();

                            bool result = Anagram(str1, str2);
                            Console.WriteLine($"({str1}, {str2}) → {result}");

                        }
                    }
                }
                else if (variant == 4)
                {
                    Console.WriteLine("Выберите задание от 1 до 4");
                    int Task;
                    int.TryParse(Console.ReadLine(), out Task);
                    if (Task < 1 || Task > 4)
                    {
                        Console.WriteLine("Вы не выбрали ни один из вариантов, попробуйте снова");
                    }
                    else
                    {
                        if (Task == 1)
                        {
                            //Задание 1
                            Console.WriteLine("Задание 1 PluxOne (Algorithmic-Task)");
                            Console.Write("Введите значение x: ");
                            int x = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Введите значение y: ");
                            int y = Convert.ToInt32(Console.ReadLine());

                            string output = PluxOne(x, y);

                            Console.WriteLine(output);
                        }
                        else if (Task == 2)
                        {
                            //Задание 2
                            Console.WriteLine("Задание 2 Empty(Game-Task)");
                            Random random = new Random();
                            int secretNumber = random.Next(1, 51);
                            int maxLives;

                            Console.WriteLine("Добро пожаловать в игру \"Угадай число\"!");
                            Console.Write("Компьютер загадал число от 1 до 50. Сколько вам необходимо попыток чтобы угадать число?: ");
                            int.TryParse(Console.ReadLine(), out maxLives);
                            Console.WriteLine("Игра началась, удачи!");

                            EmptyGame(secretNumber, maxLives);
                        }
                        else if (Task == 3)
                        {
                            //Задание 3
                            Console.WriteLine("Задание 3 Name (Fundametals-Task)");
                            bool validInput = false;
                            string name;
                            while (!validInput)
                            {
                                Console.Write("Напишите Фамилию, Имя и Отчетсво: ");
                                name = Console.ReadLine();
                                if (int.TryParse(name, out _))
                                {
                                    Console.WriteLine("Введите ФИО!");
                                    validInput = false;
                                }
                                else
                                {
                                    validInput = true;
                                    string UppLetter = UppercaseLetter(name);
                                    Console.WriteLine(UppLetter);
                                }
                            }
                        }
                        else if (Task == 4)
                        {
                            //Задание 4
                            double a, b, c;
                            bool validInputA = false;
                            bool validInputB = false;
                            bool validInputC = false;
                            Console.WriteLine("Задание 4 Heron's formula (Math-Task)");
                            while(!validInputA)
                            {
                                Console.WriteLine("Введите число а:");
                                if (!double.TryParse(Console.ReadLine(), out a))
                                {
                                    Console.WriteLine("Введите число!");
                                }
                                else
                                {
                                    validInputA = true;
                                    while (!validInputB)
                                    {
                                        Console.WriteLine("Введите число b:");
                                        if (!double.TryParse(Console.ReadLine(), out b))
                                        {
                                            Console.WriteLine("Введите число!");
                                        }
                                        else
                                        {
                                            validInputB = true;
                                            while (!validInputC)
                                            {
                                                Console.WriteLine("Введите число c:");
                                                if (!double.TryParse(Console.ReadLine(), out c))
                                                {
                                                    Console.WriteLine("Введите число!");
                                                }
                                                else
                                                {
                                                    validInputC = true;
                                                    Console.WriteLine(HeronsFormula(a, b, c));
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
