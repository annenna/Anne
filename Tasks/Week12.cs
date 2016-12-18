using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class Week12
    {
        public static string Puzzle1(string s)
        {
            var r = string.Empty;
            s = s ?? r; // ?? kontrollib kas s on null, kui on siis saab s väärtuserks r.
            // sama mis:  if (s==null) s=r; 
            //if (s==null) return r;
           // if (ReferenceEquals(null, s)) ;

            for (var i = s.Length-1; i >= 0; i--)
            {
                var c = s[i];
                r = r + c;
            }
            return r;
        }


        public static int Puzzle2(int i)
        {
            return i*i;
        }


        public static int Puzzle3(string s)
        {
            var i = 0;
            s = s ?? string.Empty;
            foreach (var c in s)
            {
                i = i + c;         
            }
            return i;
        }


        public static string Puzzle4(string s)
        {
            var r = string.Empty;
            s = s ?? r; 
            for (var i =0; i< s.Length; i++)
            {
                var x = s[i]+3;
                if (x > 'z') x = x - '{' + 'a';
                var c = (char)x;
                r = r + c;
            }
            return r;           
        }


        public static string Puzzle5(string s)
        {
            var r = string.Empty;
            s = s ?? r;
            var l = new List<char>();
            foreach(var c in s)
                {
                if (l.Contains(c)) continue;
                l.Add(c);
                }
            l.Sort();     //sorteerime Listi ära 
            var a = l.ToArray();    // teeme sorteeritud Listist massiivi
            return new string(a);   // tee massiivi elementidest string.
        }


        public static string Puzzle6(string s)
        {
            var i = string.Empty;
            s = s ?? string.Empty;

            foreach (var c in s)
            {
                               
                i = i +((int)c).ToString(); // muuda askii number stringiks.
            }
            return i;
        }


        public static int Puzzle7(params int[] a)
        {
            var sum = 0;
            a = a ?? new int[0];          
            foreach (var c in a)
            {
                sum = sum + c; 
            }
            return sum;
        }


        public static int Puzzle8(params int[] a)
        {
            var sum = 0;
            a = a ?? new int[0];
            foreach (var c in a)
            {
                sum = sum + c;
            }
            return sum;
        }

      public static int Puzzle9(params int[] numbers)
        {
              return numbers.Max();         
        }
        /*
            var max = 0;
            a = a ?? new int[0];
            var l = new List<char>();
            foreach (var c in a)
            {
                if (l.Contains(c)) continue;
                l.Add(c);
            }
            l.Sort();     //sorteerime Listi ära 
            var a = l.ToArray();    // teeme sorteeritud Listist massiivi              
        }

    */
        static int Max(params int[] numbers)
        {
            return numbers.Max();
        }


        public static int Puzzle10(int i)
        {
            return i * -1;
        }
    }
}
