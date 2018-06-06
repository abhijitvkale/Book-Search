using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cpsm2
{
    class Program
    {
        static void Main(string[] args)
        {

            SearchString search = new SearchString();
            InpFile File1 = new InpFile();
            string FileName, pattern;
            StreamReader myReader;
            int lineNo = 1;
           // int Occourance;
            int matchCount = 0;


            FileName = File1.getInpFile();
            try
            {

                if (File.Exists(FileName))
                {
                   myReader = new StreamReader(FileName);
                   pattern = search.getSearchString();
                   
                   Match m;
                   string line = myReader.ReadLine();
                  do 
                   {
                       
                       
                   //    m = r.Match(line);
                       m = Regex.Match(line, pattern);
                       while (m.Success)
                       {
                           Console.WriteLine("'{0}' found at line {2} position {1}", m.Value, m.Index,lineNo);
                           m = m.NextMatch();
                       }
                      line = myReader.ReadLine();
                      
                           
                               
                           
                       
                       lineNo++;
                   } while (line != null);
                }
                else
                {
                     throw new ArgumentException( "No such file exists" );

                }
            }
            catch (NullReferenceException nre) { }

            catch ( ArgumentException ae )
            {
                Console.WriteLine(ae.Message);
            }
            
            

            



            Console.ReadLine();

        }
    }
}
