﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealGetter.Lib.Interfaces;

namespace RealGetter.Lib
{
    public class Sorting
    {
        public Sorting()
        {

        }
        public void Grouper<T>(List<T> t, uint ii) where T : IGroupNumber
        {
            if (ii < 1) throw new IndexOutOfRangeException("There must be at least one group");
            int currentGroupNumber = 1;
            int groupCounter = 0;
            
            for (int i = 0; i < t.Count; i++)
            {
                if (groupCounter >= ii)
                {
                    currentGroupNumber += 1;
                    groupCounter = 0;
                }
                                
                    t[i].GroupNumber = currentGroupNumber;
                    groupCounter += 1;
             }
       
            
        }

        public void Randomizer<T>(IList<T> t) 
        {
            IList<T> input = new List<T>(t);
            IList<T> temp = new List<T>();
            Random rand = new Random();
            int tempint;

            while (input.Count > 0)
            {
                tempint = rand.Next(input.Count);
                temp.Add(input[tempint]);
                input.RemoveAt(tempint);
            }

            t = temp;
            
        }
    }
}
