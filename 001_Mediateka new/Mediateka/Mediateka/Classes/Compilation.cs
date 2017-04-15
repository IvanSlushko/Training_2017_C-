using Mediateka.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Mediateka.Classes
{
    public class Compilation//:IEnumerable
    {
        public List<ICompilation> Compilations { get; protected set; }
        // public IEnumerable<ICompilation> Compilations1 { get; protected set; }

        int counter = 10;  //obj in compil

        public Compilation()
        {
            Compilations = new List<ICompilation>();
        }

        public Compilation(List<ICompilation> compilations)
        {
            Compilations = compilations;
            // Compilations1 = compilations;
        }

        public void AddToCompil(ICompilation compilations)
        {
            if (Compilations.Count < counter)
            {
                Compilations.Add(compilations);
                Console.WriteLine("Add to compilation {0} obj. from {1}!", Compilations.Count, counter);
            }
            else Console.WriteLine("The compilation is full, capacity {0} obj.!", counter);
        }

        public void DelFromCompil(ICompilation compilations)
        {
            Compilations.Remove(compilations);
        }

        public string PrintAll()
        {
            return Compilations.Aggregate<ICompilation, string>(null,
                (current, ev) => current +
                ("Компиляция: " + " "
                + ev.GetType().Name
                + "  " + ev.Name + " --> "
                + ev.Url + "\n"));
        }

        //public IEnumerator GetEnumerator()
        //{
        //    return (IEnumerator)GetEnumerator();
        //}


        //public void ChangeElement(ICompilation compilations)
        //{
        //    var list = new List<int> { 1, 2, 3 };
        //    //меняем 1 и 3
        //    var buf = list[0];
        //    list[0] = list[2];
        //    list[2] = buf;
        //    Compilations.Remove(compilations);
        //}
    }
}

