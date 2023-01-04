using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_extension
{
    public class Action: IMovie
    {
        ArrayList lib = new ArrayList();
        public void Delete(string Mname)
        {
            lib.Remove(Mname);
        }

        public void Display()
        {
            foreach (var item in lib)
            {
                Console.WriteLine(item);
            }
        }

        public void Insert(string Mname)
        {
            lib.Add(Mname);
        }
    }
}
