//отформатировать строку чтобы было по одному пробелу
class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите строку");
        string n = Console.ReadLine();
        string[] words = n.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string s in words)
        {
            Console.Write(s+" ");
        }
    }
}

//необходимо в строке, состоящей из слов, между которыми по 1 пробелу, выдать все палиндромы
class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите строку");
        string n = Console.ReadLine();
        string[] words = n.Split(new char[] { ' ' });
        
        for (int i = 0; i < words.Length; i++)
        {
            bool exist = true;
            for (int j = 0; j < (words[i].Length/2); j++)
            {
                if (words[i][j] != words[i][words[i].Length -1- j])
                {
                    exist = false;
                    break;
                }  
            }
            if (exist)
            {
                Console.WriteLine(words[i]);
            }
        }
        

    }
}

//Определить является ли строка палиндромом
using System.Security.Cryptography.X509Certificates;

class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите строку");
        string n = Console.ReadLine();
        string[] words = n.Split(new char[] { ' ' });
        string s = words[0];
        for (int i = 1; i < words.Length; i++) 
        {
            s+= words[i];
        }

        bool exist = true;
        for (int i = 0; i < s.Length/2; i++)
        {
            
            if (s[i] != s[s.Length - 1 - i])
            {
                exist = false;
                break;
            }
            
        }
        if (exist)
        {
            Console.WriteLine("строка является палиндромом");
        }
        else
        {
            Console.WriteLine("строка не является палндромом");
        }


    }
}

