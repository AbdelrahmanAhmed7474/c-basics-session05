using System;

enum Genre
{
    Fiction,
    NonFiction,
    Science
}

class Book
{
    private string password = "secret";
    internal int copiesInStock = 5;
    public string Title;

    public Genre Genre { get; set; }
}

class Program
{
    static void Main()
    {
        Book book = new Book();

        
        

        // 2) 
        Console.WriteLine(book.copiesInStock); 

        // 3) 
        book.Title = "C# Basics";
        Console.WriteLine(book.Title);

        // 4) 
        book.Genre = Genre.Science;
        Console.WriteLine(book.Genre);

        // 5) 
        Console.WriteLine((int)Genre.Fiction);    // 0
        Console.WriteLine((int)Genre.NonFiction); // 1
        Console.WriteLine((int)Genre.Science);    // 2

        // 6) 
        int genreNumber = 1;
        Genre convertedGenre = (Genre)genreNumber;
        Console.WriteLine(convertedGenre); // NonFiction

        // 7) 
        Genre genre = Genre.Fiction;
        string genreString = genre.ToString();
        Console.WriteLine(genreString); // Fiction

        // 8) 
        string genreText = "Science";
        Genre parsedGenre = (Genre)Enum.Parse(typeof(Genre), genreText);
        Console.WriteLine(parsedGenre); // Science

        // 9) 
        genreText = "Mystery";

        if (Enum.TryParse(genreText, out Genre tryParsedGenre))
        {
            Console.WriteLine(tryParsedGenre);
        }
        else
        {
            Console.WriteLine("Unknown genre");
        }
    }
}