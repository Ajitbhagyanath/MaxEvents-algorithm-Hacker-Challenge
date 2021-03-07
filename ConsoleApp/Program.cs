using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrival =  { 1, 3, 3, 4, 5, 7 };
            int[] duration = { 2, 2, 1, 1, 2, 1 };
            Console.WriteLine(maxEvents(arrival, duration));
            int[] arrival1 = { 1, 3, 3, 5, 7, 6, 9 };
            int[] duration1 = { 15, 2, 1, 2, 1, 10, 2 };
            Console.WriteLine(maxEvents(arrival1, duration1));

        }
         interface x
        {

             int a ();
        }
         interface y
        {
             int b ();
        }
        public class c : x, y
        {
            public int a () {
                if (1==1)
                return 0; }

            public int b () { return 0; }
        }
        public static int maxEvents(int[] arrivals, int[] departures)
        {
            int start;
            int end;
            int[,] events = new int[arrivals.Length,2];
            int[,] sortedevents = new int[arrivals.Length, 2];
            int[] sort = new int[arrivals.Length];
            for (int i=0; i< arrivals.Length; i++)
            {
                start = arrivals[i];
                end = start + departures[i];
                events[i,0] = start;
                events[i,1] = end;
                sort[i] = end;
            }
            //todo
            Array.Sort(sort, (a,b)=>a - b );
            for (int i = 0; i < sort.Length; i++)
            {
                int index= CoordinatesOf(events, events[i, 1]);
                
            }
            //todo
            int totalEvents = 1;
            int currentEventEndTime = (int)events[0,1];
            
            for (int i = 1; i < events.GetLength(0) ; i++)
            {
                if (currentEventEndTime <= (int)events[i , 0])
                {
                    currentEventEndTime = (int)events[i , 1];
                    totalEvents++;
                }
            }
            return totalEvents;
        }
        public static int CoordinatesOf(int [,] matrix, int value)
        {
            int w = matrix.GetLength(0); 

            for (int x = 0; x < w; x++)
            {
                if (matrix[x, 1].Equals(value))
                {      return x;
                }
            }

            return -1;
        }
    }
}
