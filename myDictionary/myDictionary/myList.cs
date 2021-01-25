using System;
using System.Collections.Generic;
using System.Text;

namespace myDictionary
{
    class myList<Tip>
    {
      
            Tip[] array;
            Tip[] tempArray;
            public myList() 
            {
               array = new Tip[0];
            }
            public void Add(Tip item, string v)
            {
                tempArray = array;

                array = new Tip[array.Length + 1];

                for (int i = 0; i < tempArray.Length; i++)
                {
                    array[i] = tempArray[i];

                }
                array[array.Length - 1] = item;
            }

            public int Sayac
            {
                get { return array.Length; }
            }

        }
    }
