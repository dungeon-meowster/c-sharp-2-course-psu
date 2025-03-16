using System ;
using System.IO ;
using System.Collections.Generic;
using System.Linq ;
using System.Xml.Serialization ;

public class LabTasks
{
    // Задание 1: Удаление после каждого E элемента, если он не E
    public static void RemoveAfterE<T>( List<T> L ,T E) {
        for (int i =0; i < L.Count -1; i++ )
        {
            if ( L[i].Equals(E) && !L[i+1].Equals(E)) L.RemoveAt( i + 1 );
        }
        if (L.Count > 1 && L[L.Count - 1].Equals(E) && ! L[0].Equals(E) ) L.RemoveAt(0) ;
    }

    // Задание 2: Есть ли одинаковые соседние элементы в LinkedList (по кругу)
    public static bool HasEqualNeighbors<T>(LinkedList<T> L ){
        if ( L.Count < 2)return false ;
        var current = L.First;
        while (current.Next != null )
        {
            if(current.Value.Equals(current.Next.Value) )return true;
            current = current.Next;
        }
        if (L.Last.Value.Equals( L.First.Value ) ) return true ;
        return false;
    }

    // Задание 3: Анализ стран для туристов
    public static void AnalyzeCountries(List<string> countries , List<HashSet<string>> tourists){
        HashSet<string> allVisited = new HashSet<string>( countries );
        HashSet<string> someVisited = new HashSet<string>();
        HashSet<string> noneVisited = new HashSet<string> (countries);

        foreach ( var tourist in tourists )
        {
            allVisited.IntersectWith (tourist);
            someVisited.UnionWith(tourist );
        }
        noneVisited.ExceptWith( someVisited );

        Console.WriteLine("Посетили все туристы: " + string.Join(", " , allVisited ));
        Console.WriteLine("Посетили некоторые: " + string.Join( ", ",someVisited));
        Console.WriteLine("Никто не посетил: " + string.Join(", ",noneVisited ));
    }

    // Задание 4: Глухие согласные, не входящие ровно в одно слово
    public static void PrintDeafConsonants( string fileName ){
        string text = File.ReadAllText(fileName );
        string[] words = text.Split(new[] { ' ', '\n' , '\r' , '.' , ',' , '!' , '?' } , StringSplitOptions.RemoveEmptyEntries );
        char[] deaf = { 'к' , 'п' , 'с' , 'т' , 'ф' , 'х' , 'ц' , 'ч' , 'ш' , 'щ' };
        HashSet<char> consonants = new HashSet<char> (deaf);
        Dictionary<char , int> count = new Dictionary<char,int>();

        foreach ( char c in consonants )count[c] = 0;
        foreach (string word in words )
        {
            HashSet<char> wordCons = new HashSet<char>(word.ToLower().Where(c => consonants.Contains(c) ));
            foreach(char c in wordCons ) count[c]++ ;
        }

        var result = count.Where(kv => kv.Value != 1).Select(kv => kv.Key ).OrderBy(c => c );
        Console.WriteLine("Глухие согласные (не в одном слове): " + string.Join( ", " , result));
    }

    // Задание 5: Заполнение файла абитуриентов с XML-сериализацией
    private static void FillApplicantsFile(string fileName , Dictionary<string , (int , int)> applicants ){
        using (StreamWriter writer = new StreamWriter( fileName ))
        {
            foreach(var applicant in applicants )
            {
                string[] nameParts = applicant.Key.Split(' ');
                writer.WriteLine( $"{nameParts[0]} {nameParts[1]} {applicant.Value.Item1} {applicant.Value.Item2}" );
            }
        }
        XmlSerializer serializer = new XmlSerializer( typeof(Dictionary<string,(int,int)>));
        using ( FileStream fs = new FileStream("applicants.xml" , FileMode.Create))
        {
            serializer.Serialize( fs , applicants );
        }
    }

    // Задание 5: Вывод неудачников в алфавитном порядке
    public static void PrintFailedApplicants( string fileName ){
        Dictionary<string , (int,int)> applicants = new Dictionary<string , (int , int)>();
        Console.Write("Введите количество абитуриентов: " );
        int n = int.Parse(Console.ReadLine( ));

        for ( int i = 0 ; i < n ; i++ )
        {
            string[] input = Console.ReadLine().Split(' ');
            string fullName = $"{input[0]} {input[1]}" ;
            int score1 = int.Parse( input[2] );
            int score2 = int.Parse(input[3] );
            applicants[fullName] = ( score1 , score2 );
        }

        FillApplicantsFile( fileName , applicants);
        var failed = applicants.Where(a => a.Value.Item1 < 30 || a.Value.Item2 < 30 )
                              .Select(a => a.Key)
                              .OrderBy(name => name);
        Console.WriteLine("Не допущены к первому потоку:" );
        foreach (var name in failed ) Console.WriteLine( name );
    }
}

class Program
{
    static void Main( string[] args )
    {
        // Задание 1: Ввод списка и элемента E с клавиатуры
        Console.WriteLine("Задание 1: Удаление после элемента" );
        Console.Write("Введите элементы списка через пробел (целые числа): ");
        List<int> list = Console.ReadLine().Split(' ').Select(int.Parse ).ToList( );
        Console.Write("Введите элемент E: " );
        int e = int.Parse( Console.ReadLine());
        Console.WriteLine("До: " + string.Join( ", " , list ));
        LabTasks.RemoveAfterE(list , e );
        Console.WriteLine("После: " + string.Join(", " , list));

        // Задание 2: Ввод LinkedList с клавиатуры
        Console.WriteLine("\nЗадание 2: Одинаковые соседи" );
        Console.Write("Введите элементы списка через пробел (целые числа): " );
        LinkedList<int> linkedList = new LinkedList<int>(Console.ReadLine().Split(' ').Select(int.Parse ));
        Console.WriteLine("Список: " + string.Join(", ",linkedList ));
        Console.WriteLine("Есть одинаковые: " + LabTasks.HasEqualNeighbors(linkedList ));

        // Задание 3: Ввод стран и данных туристов с клавиатуры
        Console.WriteLine("\nЗадание 3: Анализ стран" );
        Console.Write("Введите количество стран: ");
        int countryCount = int.Parse( Console.ReadLine() );
        List<string> countries = new List<string>( );
        Console.WriteLine("Введите страны (по одной на строке):" );
        for (int i = 0 ; i < countryCount ; i++ ) countries.Add(Console.ReadLine( ));
        
        Console.Write("Введите количество туристов: " );
        int touristCount = int.Parse( Console.ReadLine());
        List<HashSet<string>> tourists = new List<HashSet<string>>();
        for (int i = 0; i < touristCount ; i++ )
        {
            Console.Write($"Введите страны, посещённые туристом {i + 1} (через пробел): ");
            tourists.Add(new HashSet<string>(Console.ReadLine().Split(' ' )));
        }
        LabTasks.AnalyzeCountries(countries , tourists );

        // Задание 4: Тестовый файл (ввод текста можно добавить, но по условию — файл)
        Console.WriteLine("\nЗадание 4: Глухие согласные" );
        File.WriteAllText("text.txt" , "кот песок туча" );
        LabTasks.PrintDeafConsonants("text.txt" );

        // Задание 5: Уже с вводом с клавиатуры в методе
        Console.WriteLine("\nЗадание 5: Неудачники тестирования" );
        LabTasks.PrintFailedApplicants("applicants.txt" );
    }
}