using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreValidationStudents.Models
{
    // Для взаимодействия с MS SQL Server через Entity Framework необходим пакет 
    // Microsoft.EntityFrameworkCore.SqlServer
    // Для создания БД на основе модели необходим пакет Microsoft.EntityFrameworkCore.Tools

    // Entity Framework Core использует подход Code First, при котором необходимо сначала 
    // определить модели и контекст данных, а затем на основе моделей и класса контекста 
    // будет создаваться БД и все ее таблицы.

    public class StudentsContext : DbContext
    {
        // Каждое свойство DbSet будет соотноситься с отдельной таблицей в базе данных.
        public DbSet<Student> Students { get; set; }
        public DbSet<Book> Books { get; set; }

        public StudentsContext(DbContextOptions<StudentsContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "Alice", Surname = "Johnson", Age = 20, GPA = 3.5, Email = "alice.johnson@example.com" },
                new Student { Id = 2, Name = "Bob", Surname = "Smith", Age = 21, GPA = 3.6, Email = "bob.smith@example.com" },
                new Student { Id = 3, Name = "Charlie", Surname = "Brown", Age = 22, GPA = 3.7, Email = "charlie.brown@example.com" },
                new Student { Id = 4, Name = "David", Surname = "Williams", Age = 23, GPA = 3.8, Email = "david.williams@example.com" },
                new Student { Id = 5, Name = "Eve", Surname = "Jones", Age = 24, GPA = 3.9, Email = "eve.jones@example.com" },
                new Student { Id = 6, Name = "Frank", Surname = "Garcia", Age = 25, GPA = 4.0, Email = "frank.garcia@example.com" },
                new Student { Id = 7, Name = "Grace", Surname = "Martinez", Age = 26, GPA = 4.1, Email = "grace.martinez@example.com" },
                new Student { Id = 8, Name = "Hannah", Surname = "Rodriguez", Age = 27, GPA = 4.2, Email = "hannah.rodriguez@example.com" },
                new Student { Id = 9, Name = "Ian", Surname = "Hernandez", Age = 28, GPA = 4.3, Email = "ian.hernandez@example.com" },
                new Student { Id = 10, Name = "Jack", Surname = "Lopez", Age = 29, GPA = 4.4, Email = "jack.lopez@example.com" },
                new Student { Id = 11, Name = "Karen", Surname = "Gonzalez", Age = 30, GPA = 4.5, Email = "karen.gonzalez@example.com" },
                new Student { Id = 12, Name = "Leo", Surname = "Wilson", Age = 31, GPA = 4.6, Email = "leo.wilson@example.com" },
                new Student { Id = 13, Name = "Mia", Surname = "Anderson", Age = 32, GPA = 4.7, Email = "mia.anderson@example.com" },
                new Student { Id = 14, Name = "Nina", Surname = "Thomas", Age = 33, GPA = 4.8, Email = "nina.thomas@example.com" },
                new Student { Id = 15, Name = "Oscar", Surname = "Taylor", Age = 34, GPA = 4.9, Email = "oscar.taylor@example.com" },
                new Student { Id = 16, Name = "Paul", Surname = "Moore", Age = 35, GPA = 5.0, Email = "paul.moore@example.com" },
                new Student { Id = 17, Name = "Quinn", Surname = "Jackson", Age = 36, GPA = 5.1, Email = "quinn.jackson@example.com" },
                new Student { Id = 18, Name = "Rose", Surname = "Martin", Age = 37, GPA = 5.2, Email = "rose.martin@example.com" },
                new Student { Id = 19, Name = "Sam", Surname = "Lee", Age = 38, GPA = 5.3, Email = "sam.lee@example.com" },
                new Student { Id = 20, Name = "Tina", Surname = "Perez", Age = 39, GPA = 5.4, Email = "tina.perez@example.com" },
                new Student { Id = 21, Name = "Uma", Surname = "Thompson", Age = 40, GPA = 5.5, Email = "uma.thompson@example.com" },
                new Student { Id = 22, Name = "Victor", Surname = "White", Age = 41, GPA = 5.6, Email = "victor.white@example.com" },
                new Student { Id = 23, Name = "Wendy", Surname = "Harris", Age = 42, GPA = 5.7, Email = "wendy.harris@example.com" },
                new Student { Id = 24, Name = "Xander", Surname = "Sanchez", Age = 43, GPA = 5.8, Email = "xander.sanchez@example.com" },
                new Student { Id = 25, Name = "Yara", Surname = "Clark", Age = 44, GPA = 5.9, Email = "yara.clark@example.com" }
            );

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Name = "C# in Depth", Author = "Skeet", Year = 2019 },
                new Book { Id = 2, Name = "Clean Code", Author = "Martin", Year = 2008 },
                new Book { Id = 3, Name = "The Pragmatic Programmer", Author = "Hunt", Year = 1999 },
                new Book { Id = 4, Name = "Code Complete", Author = "McConnell", Year = 2004 },
                new Book { Id = 5, Name = "CLR via C#", Author = "Richter", Year = 2012 },
                new Book { Id = 6, Name = "Dependency Injection in .NET", Author = "Seemann", Year = 2011 },
                new Book { Id = 7, Name = "Domain-Driven Design", Author = "Evans", Year = 2003 },
                new Book { Id = 8, Name = "Refactoring", Author = "Fowler", Year = 1999 },
                new Book { Id = 9, Name = "Patterns of Enterprise Application Architecture", Author = "Fowler", Year = 2002 },
                new Book { Id = 10, Name = "Design Patterns", Author = "Gamma", Year = 1994 },
                new Book { Id = 11, Name = "Head First Design Patterns", Author = "Freeman", Year = 2004 },
                new Book { Id = 12, Name = "Introduction to Algorithms", Author = "Cormen", Year = 2009 },
                new Book { Id = 13, Name = "Artificial Intelligence: A Modern Approach", Author = "Russell", Year = 2010 },
                new Book { Id = 14, Name = "The Mythical Man-Month", Author = "Brooks", Year = 1975 },
                new Book { Id = 15, Name = "The Art of Computer Programming", Author = "Knuth", Year = 1968 },
                new Book { Id = 16, Name = "Structure and Interpretation of Computer Programs", Author = "Abelson", Year = 1996 },
                new Book { Id = 17, Name = "Programming Pearls", Author = "Bentley", Year = 1986 },
                new Book { Id = 18, Name = "The C Programming Language", Author = "Kernighan", Year = 1988 },
                new Book { Id = 19, Name = "Modern Operating Systems", Author = "Tanenbaum", Year = 1992 },
                new Book { Id = 20, Name = "Computer Networks", Author = "Tanenbaum", Year = 1981 },
                new Book { Id = 21, Name = "Compilers: Principles, Techniques, and Tools", Author = "Aho", Year = 2006 },
                new Book { Id = 22, Name = "Concrete Mathematics", Author = "Graham", Year = 1994 },
                new Book { Id = 23, Name = "Grokking Algorithms", Author = "Bhargava", Year = 2016 },
                new Book { Id = 24, Name = "You Don't Know JS", Author = "Simpson", Year = 2015 },
                new Book { Id = 25, Name = "Introduction to the Theory of Computation", Author = "Sipser", Year = 2006 }
            );
        }        
    }

    public class Student
    {
        // Идентификатор студента
        public int Id { get; set; }

        // Имя студента
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Display(Name = "Имя студента")]
        public string? Name { get; set; }

        // Фамилия студента
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Display(Name = "Фамилия студента")]
        public string? Surname { get; set; }

        // Возраст студента
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Display(Name = "Возраст")]
        [Range(15, 60, ErrorMessage = "Недопустимый возраст")]
        public int Age { get; set; }

        // Средний балл
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Range(0.0, 12.0, ErrorMessage = "Недопустимый средний балл")]
        [Display(Name = "Средний балл")]
        public double GPA { get; set; }

        // Электронный адрес
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        [Remote(action: "CheckEmail", controller: "Students", ErrorMessage = "Email уже используется")]
        [Display(Name = "Адрес электронной почты")]
        public string? Email { get; set; }

        /*
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage="Пароли не совпадают")]
        [DataType(DataType.Password)]
        public  string PasswordConfirm { get; set; }

        Currency Отображает текст в виде валюты
        DateTime Отображает дату и время
        Date Отображает только дату, без времени
        Time Отображает только время
        Text Отображает однострочный текст
        MultilineText Отображает многострочный текст (элемент textarea)
        Password Отображает символы с использованием маски
        Url  Отображает строку URL
        EmailAddress Отображает электронный адрес
         * */
    }
}
