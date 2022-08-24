using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    internal class Add
    {
        static private List<Add> a = new List<Add>();
        public string name { get; set; }

        public void save()
        {
            a.Add(this);
        }
       static public List<Add> GetAllProducts()
        {
            return a;
        }


    }
}
