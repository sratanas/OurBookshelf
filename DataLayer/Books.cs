using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataLayer
{
    public class Books
    {
        public List<Book> BookList { get; set; }

        /// <summary>
        /// Method to get a list of all the books
        /// </summary>
        /// <returns>List of book objects</returns>
        public List<Book> GetBooks()
        {
            List<Book> BookList = new List<Book>();

            using (SqlConnection connection = DB.GetSqlConnection())
            {
                List<Book> bookList = new List<Book>();

                string query = "SELECT Title FROM Books";
                SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                        var book = new Book();
                        book.Title = reader["Title"].ToString();

                        bookList.Add(book);
                        }


                    }
                

                return bookList;
            }
        }


    }

    /// <summary>
    /// Class for a single book
    /// </summary>
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int YearPublished { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Location { get; set; }


    }
}
