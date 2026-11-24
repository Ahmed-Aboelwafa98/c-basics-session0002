namespace ReAssigment_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Qussion 01
            ////Q01--  Create a Book class with a Title(string) and Pages(int). Create a Book object and store it in a
            ////variable of type object.Print i
            //Book book = new Book { title = "The Great Gatsby", pages = 180 };
            ////Console.WriteLine(book);
            #endregion
            #region Qussion 02
            ///Using the Book class above, print the result of calling ToString(), Equals() (compare book with
            ////itself), GetHashCode(), and GetType() on book.
            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());
            #endregion
            #region Qussion 03  
            /// Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.int pages = "464"
            //int pages = "464"; // //compile time error
            //Console.WriteLine(pages);//compile time error 
            //int pages = 464; // fixed
            //int pages = (int).parse("464"); // fixed
            #endregion
            #region Qussion 04
            //Q04--- Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide zero", and then prints "Done" in a finally block.
            //try
            //{
            //    int a = 10;
            //    int b = 0;

            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            #endregion
            #region Qussion 05
            ///Q05. Declare an int pages = 300; then store it in a double variable without using a cast.
            //int pages01 = 300;
            //double Pages02 = pages01;
            //Console.WriteLine(Pages02.GetType());
            #endregion
            #region Qussion 06
            //Q06. Declare a double price = 49.99; then convert it into an int using a cast.
            //double price01 = 49.99;
            //int price02 = (int)price01;
            //Console.WriteLine(price02);
            #endregion
            #region Qussion 07
            //Q07. Given string pagesText = "464";, convert it into an int using the Convert class.
            //string pagesText = "464";
            //int pagesInt = Convert.ToInt32(pagesText);
            //Console.WriteLine(pagesInt);
            #endregion
            #region Qussion 08
            //Q08. Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,
            //use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            //string yearText = "2023";
            //int year = int.Parse(yearText);
            //Console.WriteLine(year);
            //string badText = "abc";
            //if (int.TryParse(badText, out int bad)) {
            //    Console.WriteLine(badText);
            //}
            //else {
            //    Console.WriteLine("Invalid number");
            //}
            #endregion
            #region Qussion 09
            // Q09. Given int pages = 464;, convert it into a string using ToString() and print its type using GetType()
            //to prove it's now a string.
            //int pages = 464;
            //string pagesString = pages.ToString();
            //Console.WriteLine(pagesString);
            //Console.WriteLine(pagesString.GetType());
            #endregion
            #region Qussion 10
            //Q10. Declare int copies = 100;. Box it into an object variable, then unbox it back into a new intvariable, and print both.
            //int copies = 100;
            //object box = copies; // Boxing
            //Console.WriteLine(box);
            //int unbox = (int)box; // Unboxing
            //Console.WriteLine(unbox);
            #endregion
            #region Qussion 11
            //Q11.Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its value.
            //int year;
            //int year = null;
            //Console.WriteLine(year.HasValue);
            //year = 2023;
            //Console.WriteLine(year);
            #endregion
            #region Qussion 12
            //Q12. Declare a string? reviewer = null;. Print whether it is null.
            // string reviewer = null;
            //Console.WriteLine(reviewer == null);
            // Console.WriteLine(reviewer != null);

            #endregion
            #region Qussion 13
            //Q13. Declare a Book? book = null;. Use ?. to safely read book.Title without crashing the program, andprint the result.
            //Book? book01;
            //Console.WriteLine(book?.title);
            #endregion
            #region Qussion 14
            //Q14. Using title from the previous question, use ?? to print "Untitled" if title is null. Then use ??= to
            //assign title the value "Untitled" only if it's still null
            //Book? book = null;
            //string? title = book?.title;
            //Console.WriteLine(title ?? "Untitled");
            //title = title ?? "Untitled";
            //Console.WriteLine(title);                 
            #endregion
            #region Qussion 15
            //Q15. Given string? name = "Ahmed"; (you are sure it's not null here), assign it to a non-nullable string
            //confirmedName using the ! operator.
            //string? name = "Ahmed";
            //string confirmedName = name!;
            //Console.WriteLine(confirmedName);
            //Console.WriteLine(confirmedName);
            //Console.WriteLine(confirmedName);
            #endregion
        }
    }
}
