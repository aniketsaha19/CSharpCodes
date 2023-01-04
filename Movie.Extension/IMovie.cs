using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_extension
{
    interface IMovie
    {
        void Insert(String Mname);
        void Delete(String Mname);
        void Display();
    }
}
