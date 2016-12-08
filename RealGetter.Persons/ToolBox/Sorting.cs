using System;
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
        public void Grouper<T>(IList<T> t, uint groupSize) where T : IGroupNumber
        {
            if (groupSize < 1) throw new IndexOutOfRangeException("variable groupSize is less than 1. There must be at least one group");
            int currentGroupNumber = 1;
            int groupCounter = 0;
            
            for (int i = 0; i < t.Count; i++)
            {
                if (groupCounter >= groupSize)
                {
                    currentGroupNumber += 1;
                    groupCounter = 0;
                }
                                
                    t[i].GroupNumber = currentGroupNumber;
                    groupCounter += 1;
             }
       
            
        }

        public void Grouper<T>(List<T> t, uint groupSize, uint startingGroupNumber) where T : IGroupNumber
        {
            if (groupSize < 1) throw new IndexOutOfRangeException("variable groupSize is less than 1. There must be at least one group");
            int currentGroupNumber = (int)startingGroupNumber;
            int groupCounter = 0;

            for (int i = 0; i < t.Count; i++)
            {
                if (groupCounter >= groupSize)
                {
                    currentGroupNumber += 1;
                    groupCounter = 0;
                }

                t[i].GroupNumber = currentGroupNumber;
                groupCounter += 1;
            }


        }

        //public void Randomizer<T>(IList<T> t) where T : IStudent, IPerson
        //{
        //    IList<T> input = new List<T>(t);
        //    IList<T> output = new List<T>();
        //    int currentIndex;

        //    //int counter = input.Count;
        //    //for (int i = counter; i > 0; i--)
        //    //{
        //    //    currentIndex = new Random().Next(counter);
        //    //    output.Add(input[currentIndex]);
        //    //    input.RemoveAt(currentIndex);
        //    //    counter--;
        //    //    t = output;
        //    //}


        //    while (input.Count > 0)
        //    {
        //        currentIndex = new Random().Next(input.Count);
        //        output.Add(input[currentIndex]);
        //        input.RemoveAt(currentIndex);
        //    }

        //    t = output;

        //}

        public IList<T> Randomizer<T>(IList<T> t) where T : IStudent, IPerson
        {
            IList<T> input = new List<T>(t);
            IList<T> output = new List<T>();
            int currentIndex;

            //int counter = input.Count;
            //for (int i = counter; i > 0; i--)
            //{
            //    currentIndex = new Random().Next(counter);
            //    output.Add(input[currentIndex]);
            //    input.RemoveAt(currentIndex);
            //    counter--;
            //    t = output;
            //}


            while (input.Count > 0)
            {
                currentIndex = new Random().Next(input.Count);
                output.Add(input[currentIndex]);
                input.RemoveAt(currentIndex);
            }

            return output;

        }
    }
}
