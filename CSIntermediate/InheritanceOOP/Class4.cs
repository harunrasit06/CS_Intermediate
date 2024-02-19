using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIntermediate.InheritanceOOP
{
    internal class Class4
    {
        static void Main4(string[] args)
        {
            var list = new ArrayList() ;
            list.Add(1) ;
            list.Add("Harun") ;
            list.Add (DateTime.Today) ;

            var number = (int)list[1] ; // Kommt Fehler

            //var anotherList = new List<int>() ;   //Das heißt Type Safety
            //anotherList.Add() ;

            var names = new List<string>() ;
            names.Add("a") ;
        }
    }
}
