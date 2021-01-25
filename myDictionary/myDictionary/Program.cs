using System;
using System.Collections.Generic;

namespace myDictionary
{
    //20 ocak dersi
    class Program
    {
        static void Main(string[] args)
        {
          
                myList<string> myDict = new myList<string>();
                myDict.Add("1", "C");
                myDict.Add("2", "C++");
                myDict.Add("3", "Java");
                myDict.Add("4", "Python");
                myDict.Add("5", "C#");
                myDict.Add("6", "HTML");
                Console.WriteLine(myDict.Sayac);
            }
        }
    }

