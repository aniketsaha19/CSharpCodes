using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_extension
{
    public class War : IMovie
    {
        ArrayList lib = new ArrayList();


        public void Delete(String Mname)
        {
            lib.Remove(Mname);
        }

        public void Insert(String Mname)
        {
            lib.Add(Mname);
        }

        public void Display()
        {
            foreach(var item in lib)
            {
                Console.WriteLine(item);
            }
        }
    }
}
