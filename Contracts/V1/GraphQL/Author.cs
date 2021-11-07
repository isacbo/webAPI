//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Contracts.V1.GraphQL
//{
//    namespace Demo
//    {
//        public class Author
//        {
//            public string Name { get; set; }
//        }

//        public class Book
//        {
//            public string Title { get; set; }

//            public Author Author { get; set; }
//        }

//        public class Query
//        {
//            public Book GetBook() =>
//               new Book
//               {
//                   Title = "C# in depth.",
//                   Author = new Author
//                   {
//                       Name = "Jon Skeet"
//                   }
//               };
//        }

//    }
//}
