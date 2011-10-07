using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class rotator
    {
        void poczatek() { w_typ = 0; w_miejsce = 0; }
        void ustaw_typ(int po) { if ((po <= 9) & (po >= 1)) { w_typ = po-1; } else { Console.WriteLine("Nieprawidłowy typ Rotatora"); }}
        void przekrec() { if (w_typ == 24) { w_typ = 0; } else { w_typ += 1; } }
        void ustaw(int c) { if ((c <= 25) & (c >= 1)) { w_miejsce = c-1; } else { Console.WriteLine("Nieprawidłowe ustawienie Rotatora"); } }


        private string[,] typ = { { "I", "EKMFLGDQVZNTOWYHXUSPAIBRCJ" }, { "II", "AJDKSIRUXBLHWTMCQGZNPYFVOE" }, { "III", "BDFHJLCPRTXVZNYEIWGAKMUSQO" }, { "IV", "ESOVPZJAYQUIRHXLNFTGKDCMWB" }, { "V", "VZBRGITYUPSDNHLXAWMJQOFECK" }, { "VI", "JPGVOUMFYQBENHZRDKASXLICTW" }, { "VII", "NZJHGRCXMYSWBOUFAIVLPEKQDT" }, { "VIII", "FKQHTLXOCBJSPDZRAMEWNIUYGV" } };
        private int w_typ = 0;
        private int w_miejsce = 0;

    }

    class reflektor
    {
        void poczatek() { w_typ = 0; w_miejsce = 0; }
        void ustaw_typ(int po) { if ((po <= 2) & (po >= 1)) { w_typ = po - 1; } else { Console.WriteLine("Nieprawidłowy typ Reflektora"); } }

        private string[,] typ = { { "UKW B", "AY BR CU DH EQ FS GL IP JX KN MO TZ VW" }, { "UKW C", "AF BV CP DJ EI GO HY KR LZ MX NW QT SU" } };
        private int w_typ = 0;
        private int w_miejsce = 0;
    }

    class przelacznica
    {
    }

    class enigma
    {
    }
}
