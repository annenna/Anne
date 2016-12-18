using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.ViewManagement;

namespace Tasks
{
    public class Week13
    {
        public static char GetCharByIndex(int i, params char[] a) // Puzzle 1
        {
            if (!IsArgsCorrect(i, a)) return '\0'; // kui tingimused ei ole täidetud siis kohe välja.
            return a[i];
        }

        private static bool IsArgsCorrect(int i, char[] a)
        {
            if (ReferenceEquals(null, a)) return false;
            if (a.Length < 0) return false;
            if (i > a.Length - 1) return false;
            if (i < 0) return false;
            return true;
        }


        public static void Puzzle13(ref int a)
        {
            a = a*a;
        }

        public static void Puzzle14(int a)
        {
            a = a*a;
        }


        public static void Puzzle15(int a, out int r) // meetod sellepärast void
        {
            r = a*a;
        }

        public static int Puzzle16(int a)
        {
            return a*a;
        }


        public static int Factorial(int i) // funktsioon sellepärast int. // Puzzle 7
        {
            if (i < 2) return 1;
            return i*Factorial(i - 1); // nt 3 nähtamatu  tsükkel:3*2*1=> 2*3=6
            /*
            int r = 1;
            for (; i > 1; i--)// esimest tehet pole i´on kohe olemas aga ; peab jääma
            {
                r = r*i;
            }
            return r;
            */
        }

        public static string Puzzle18(string s)
        {
            var r = string.Empty;
            s = s ?? r; // ?? kontrollib kas s on null, kui on siis saab s väärtuserks r.
            for (var i = s.Length - 1; i >= 0; i--)
            {
                var c = s[i];
                r = r + c;
            }
            return r;
        }


        public static bool Puzzle19(string sona) //Palindrome       
        {
            if (ReferenceEquals(null, sona)) return false;
            if (ReferenceEquals(string.Empty, sona)) return false;
            var reverseSona = string.Empty;

            for (var i = sona.Length - 1; i >= 0; i--)
            {
                var c = sona[i];
                reverseSona = reverseSona + c;
            }
            if (sona == reverseSona) return true;
            return false;
        }




        public static uint Puzzle20(uint i) // Fibonacci number
        {
            if (i < 4) return i;
            return Puzzle20(i - 1) + Puzzle20(i - 2);
        }

        /*
        public static int Puzzle101(int number)// Fibonacci number tee tsükliga
        {
            if (number < 4) return number;
            if (number >= 4){
            {    for(i=number;i >= 144; i++){          
                v = (i - 1) + (i - 2);
                                               
            }
            }
            return k;
        }*/


        public static int Puzzle100(int number) // Fibonacci number tee tsükliga
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < number; i++)
            {
                int ajutine = a;
                a = b;
                b = ajutine + b;
            }
            return a;
        }
    }
}
