using System;
namespace Assignment_POP_2020
{
    class Tester
    {
        static void Main(string[] args)
        {
            AddNewStudent();
        }
        private static void AddNewStudent()
        {
            Console.Clear();
            Console.WriteLine("----------Create new student----------");
            var firstn = checkingForStrings("First name", 30);
            var lastn = checkingForStrings("Last name", 30);
            var studentnum = $"SN-{checkingForStrings("Student number", 10)}";
            var age = checkingForInt("Age", 1, 100);
            var country = checkingForStrings("Country", 30);
            var city = checkingForStrings("City", 30);
            var streetname = checkingForStrings("Street name", 30);
            var housenum = checkingForStrings("House number", 5);
            var amountofscores = checkingForInt("Amount of scores", 1, 10);
            var score = new int[amountofscores];
            for (int i = 0; i < score.Length; i++)
            {
                score[i] = checkingForInt($"Score {i + 1}", 0, 100);
            }
            var address = new Address(streetname, housenum, city, country);
            var student = new Student(firstn, lastn, studentnum, age, address, score);
            Console.WriteLine("\nPress ENTER to continue...");
            Console.ReadLine();
            DisplayStudent(student);
            Console.WriteLine("\nDisplay ditailed info about student?\n\t\tyes\tno");
            while (true)
            {
                var choise = Console.ReadLine();
                if (choise.ToLower() == "yes")
                {
                    Console.WriteLine($"{student.ToString()}");
                    break;
                }
                else if (choise.ToLower() == "no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please try again");
                }
            }
            Console.WriteLine("\nPress ENTER to finish a program");
            Console.ReadLine();
        }
        private static void DisplayStudent(Student student)
        {
            Console.Clear();
            Console.WriteLine("Created student:");
            Console.WriteLine($"Student {student.FullName(student.FirstName, student.LastName)} score is {student.AverageScore(student.Scores)}");
            Console.WriteLine($"Student {student.FullName(student.FirstName, student.LastName)} is living in {student.Address.City}");
            Console.WriteLine($"Student {student.FullName(student.FirstName, student.LastName)} address is {student.Address}");
        }
        private static string checkingForStrings(string nameofchecking, int maxlength)
        {
            var name = "";
            Console.WriteLine($"Please enter {nameofchecking.ToLower()}: ");
            bool check = true;
            while (check)
            {
                name = Console.ReadLine();
                var namechar = name.ToCharArray();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine($"{nameofchecking} can't be empty! Please try again");
                    continue;
                }
                if (namechar.Length == 1 && nameofchecking != "House number")
                {
                    Console.WriteLine($"{nameofchecking} can't be this short! Please try again");
                    continue;
                }
                int capitalinstart = 0;
                int amount = 0;
                int capitalafterdefis = 0;
                int startorendwithdefis = 0;
                int defi = 0;
                for (int i = 0; i < namechar.Length; i++)
                {
                    if (namechar.Length != 1 && namechar[0] == '-' || namechar[namechar.Length - 1] == '-')
                    {
                        startorendwithdefis++;
                    }
                    if (nameofchecking != "Student number" && nameofchecking != "House number" && char.IsLower(namechar[0]))
                    {
                        capitalinstart++;
                    }
                    if (i >= 1 && char.IsPunctuation(namechar[i - 1]) && char.IsPunctuation(namechar[i]))
                    {
                        defi++;
                    }
                    else if (nameofchecking != "Student number" && nameofchecking != "House number" && namechar[namechar.Length - 1] != '-' && namechar[i] == '-' && char.IsLower(namechar[i + 1]))
                    {
                        capitalafterdefis++;
                    }
                    if (nameofchecking != "Student number" && nameofchecking != "House number" && i != 0 && char.IsUpper(namechar[i]) && namechar[i - 1] != '-')
                    {
                        amount++;
                    }
                }
                if (defi != 0)
                {
                    Console.WriteLine($"{nameofchecking} can't be '{name}'");
                    continue;
                }
                if (startorendwithdefis != 0)
                {
                    Console.WriteLine($"{nameofchecking} can't starts or ends with '-'! Please try again");
                    continue;
                }
                if (capitalinstart != 0)
                {
                    Console.WriteLine($"{nameofchecking} must starts with capital letter! Please try again");
                    continue;
                }
                if (amount != 0)
                {
                    Console.WriteLine($"Capital letter must be only in the start of {nameofchecking.ToLower()} or after '-'! Please try again");
                    continue;
                }
                if (capitalafterdefis != 0)
                {
                    Console.WriteLine($"After '-' must be capital letter! Please try again");
                    continue;
                }

                if (name.Length > maxlength)
                {
                    Console.WriteLine($"{nameofchecking} can't be longer that {maxlength} symbols! Please try again");
                    continue;
                }
                if (nameofchecking != "Student number")
                {
                    int amountofletters = 0;
                    int symb = 0;
                    int def = 0;
                    int numandlet = 0;
                    int line = 0;

                    if (nameofchecking != "House number")
                    {
                        if (IfHavePunctuation(name))
                        {
                            Console.WriteLine($"{nameofchecking} can't contains punctuation or other symbols (except '-')! Please try again");
                            continue;
                        }
                        if (IfHaveNumber(name))
                        {
                            Console.WriteLine($"{nameofchecking} can't contains numbers! Please try again");
                            continue;
                        }
                        break;
                    }
                    else if (nameofchecking == "House number")
                    {
                        if (namechar.Length == 1 && char.IsLetter(namechar[0]))
                        {
                            numandlet++;
                        }
                        if (IfHaveNumber(name))
                        {
                            for (int c = 0; c < namechar.Length; c++)
                            {
                                if (char.IsPunctuation(namechar[c]) || char.IsSymbol(namechar[c]) && namechar[c] != '/')
                                {
                                    symb++;
                                }
                                else
                                {
                                    if (namechar[c] == '/')
                                    {
                                        line++;
                                    }
                                    if (char.IsLetter(namechar[c]))
                                    {
                                        amountofletters++;
                                    }
                                    if (namechar.Length != 1 && c + 1 != namechar.Length && char.IsLetter(namechar[c]) && char.IsNumber(namechar[c + 1]))
                                    {
                                        numandlet++;
                                    }
                                    else if (namechar.Length != 1 && c + 1 != namechar.Length && char.IsLetter(namechar[c]) && !char.IsNumber(namechar[c + 1]))
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                        }
                        else if (!IfHaveNumber(name))
                        {
                            numandlet++;
                        }
                        if (amountofletters > 1)
                        {
                            Console.WriteLine($"{nameofchecking} can't contains more than 1 letter! Please try again");
                            continue;
                        }
                        if (line > 1)
                        {
                            Console.WriteLine($"{nameofchecking} can't contains more than 1 '/'! Please try again");
                            continue;
                        }
                        if (numandlet != 0)
                        {
                            Console.WriteLine($"letters in {nameofchecking.ToLower()} must be after numbers (Example: 11A)! Please try again");
                            continue;
                        }
                        if (def != 0)
                        {
                            Console.WriteLine($"{nameofchecking} can't contains punctuation or other symbols (exept '/')! Please try again");
                            continue;
                        }
                        return name.ToUpper();
                    }
                    break;
                }
                if (nameofchecking == "Student number")
                {
                    if (!IfHaveNumber(name))
                    {
                        Console.WriteLine($"{nameofchecking} must have at least 1 number! Please try again");
                        continue;
                    }
                    return name.ToUpper();
                }

                break;
            }
            return name;
        }
        private static bool IfHaveNumber(string name)
        {
            var namechar = name.ToCharArray();

            foreach (var ch in namechar)
            {
                if (char.IsNumber(ch))
                {
                    return true;
                }
            }
            return false;

        }
        private static bool IfHavePunctuation(string name)
        {
            var namechar = name.ToCharArray();

            foreach (var ch in namechar)
            {
                if (char.IsPunctuation(ch) || char.IsSymbol(ch))
                {
                    if (ch == '-')
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }

                }
            }
            return false;

        }
        private static int checkingForInt(string nameofchecking, int lowbound, int highbound)
        {
            int value = 0;
            Console.WriteLine($"Please enter {nameofchecking.ToLower()} ({lowbound}-{highbound}): ");
            bool check = true;
            while (check)
            {
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    if (value >= lowbound && value <= highbound)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{nameofchecking} must be between {lowbound} and {highbound}! Please try again");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine($"{nameofchecking} must be a number! Please try again");
                    continue;
                }
            }
            return value;
        }

    }
}
