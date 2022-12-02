using System;
using System.Text;

while (true)
{
    Console.WriteLine("Введите логин:");
    string login = Console.ReadLine().Trim();
    Console.WriteLine("Введите пароль \n(Должен содержать минимум одну заглавную букву,\n одну цифру и специальные символы, например '_','(' или ')'):");
    string password = Console.ReadLine().Trim();
    if (isLoginSuitable(login))
    {
        Console.WriteLine("Логин подходит");
    }
    else
    {
        Console.WriteLine("Логин не подходит");
    }
    if (isPasswordSuitable(password))
    {
        Console.WriteLine("Пароль подходит");
    }
    else
    {
       Console.WriteLine("Пароль не подходит");
    }
    
}

bool isLoginSuitable(string s)
{
    if (s.Length < 4 && s.Length > 20) return false;
    foreach (var c in s)
    {
        if (c >= 'a' && c <= 'z') continue;
        if (c >= 'A' && c <= 'Z') continue;
        if (c >= '0' && c <= '9') continue;
        if (c is '_' or '(' or ')') continue;
    }
    return true;
}
bool isPasswordSuitable(string s)
{
    if (s.Length < 6 && s.Length > 20) return false;
    var hasdigit = false;
    var hasspecialsymbols = false;
    var hasappercase = false;
    foreach (var c in s)
    {
        if (!hasdigit && c >= 0 && c <= 9) hasdigit = true;
        if (!hasappercase && c.ToString().ToUpper() != c.ToString()) hasappercase = true;
        if (!hasspecialsymbols && c is '_' or '(' or ')' or '!' or '#' or '\\' or '/') hasspecialsymbols = true;
    }
    return true;
}
