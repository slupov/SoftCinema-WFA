using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Import;

namespace SoftCinema.Test
{
    class StartUp
    {
        static void Main(string[] args)
        {
            
            JSONImport.ImportCategories();
            JSONImport.ImportTowns();
            JSONImport.ImportActors();
        }
    }
}
