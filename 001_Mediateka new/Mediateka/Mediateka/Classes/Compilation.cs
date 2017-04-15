using Mediateka.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mediateka.Classes
{
    public class Compilation
    {
        public List<ICompilation> ListCompilation { get; private set; }
        int counter = 12;  //obj in compil
        public Compilation()
        {
            ListCompilation = new List<ICompilation>();
        }

        public Compilation(List<ICompilation> listCompilation)
        {
            ListCompilation = listCompilation;
        }
        public void AddToCompil(ICompilation listCompilation)
        {
            if (ListCompilation.Count < counter)
            {
                ListCompilation.Add(listCompilation);
                Console.WriteLine("On compil {0} obj.", ListCompilation.Count);
            }
            else Console.WriteLine("The compil is full, capacity {0} obj.!", counter);
        }
        public void DelFromCompil(ICompilation listCompilation)
        {
            ListCompilation.Remove(listCompilation);
        }

        public bool PrintAll()
        {
            return ListCompilation.Aggregate<ICompilation, string>
                (null, (current, ev) => current +
                 ("элемент : " + ev.Name + " --> " + ev.Url + "\n"));

            
        }
    }
}
