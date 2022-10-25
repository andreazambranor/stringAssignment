using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //THIS IS A CONCATNATION OF 3 STRINGS AND ONE UF THEM IS CONVERTED TO UPPERCASE
            string movie = "Start Wars ";
            string sequel = "Episode 1 ";
            string title = "The Phantom Menace";

            sequel = sequel.ToUpper();
                       
            Console.WriteLine(movie + sequel + title);
            Console.ReadLine();


            //THIS CREATES A STRING BUILDER AND BUILDS A PARAGRAPH
            StringBuilder sb = new StringBuilder();
            sb.Append("This movie was release in 1999.");
            sb.AppendLine(" This movie was the 4th movie of the sequel to be recorded.");
            sb.AppendLine(" It was written and directed by George Lucas.");
            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}
