using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HrySTextem
{
    public class Stringy
    {
        public string Veta { get; set; }
        public char HledaSe { get; set; }
        public Stringy(string veta, string hledaSe)
        {
            Veta = veta;
            HledaSe = hledaSe[0];
        }

        private string[] Slova
        {
            get { return Veta.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); }
        }

        //private char[] pismena
        //{
        //    get { return Veta.ToCharArray(); }
        //}       

        public string NajdiHledane()
        {
            int x = 0;

            foreach (char znak in Veta)
            {
                if (HledaSe == znak)
                    x++;
            }
            return String.Format($"{x} krát");
        }

        public string MalaNaVelka()
        {
            StringBuilder sb = new StringBuilder(Veta);

            for (int j = 0; j < sb.Length; j++)
            {
                if (Char.IsLower(sb[j]) == true)
                    sb[j] = Char.ToUpper(sb[j]);
                else if (Char.IsUpper(sb[j]) == true)
                    sb[j] = Char.ToLower(sb[j]);
            }
            return sb.ToString();
        }

        public string OtocenaSlova()
        {
            string otocenislov = "";

            for (int i = Slova.Length - 1; i >= 0; i--)
                otocenislov += Slova[i] + " ";

            return otocenislov;
        }
        public string OtocenaPismena()
        {
            string zprava = "";
            foreach (var item in Slova)
            {
                char[] letters = item.ToCharArray();
                Array.Reverse(letters);

                foreach (char pismeno in letters)
                    zprava += pismeno;
                zprava += " ";
            }
            return zprava;
        }

        public string OtocenaVeta()
        {
            string zadani = Veta;
            string opacne = new string(zadani.Reverse().ToArray());

            if (zadani == opacne)
                return opacne + " - PALINDROM!";

            return opacne;
        }

        //public void VsePozpatku()
        //{
        //    string zprava = "";
        //    for (int i = 0; i < Veta.Length; i++)
        //        zprava += (Veta[Veta.Length - i - 1]);
        //}

        public string PocetSlov()
        {
            int pocetSlov = Slova.Length;
            return pocetSlov.ToString();
        }

        public string PocetZnaku()
        {
            int pocetZnaku = 0;
            foreach (var znak in Veta)
            {
                if (znak != ' ')
                    pocetZnaku++;
            }
            return pocetZnaku.ToString();
        }

        public string Nejdelsi()
        {
            string nejSlovo = "";

            foreach (var item in Slova)
            {
                if (item.Length > nejSlovo.Length)
                    nejSlovo = item;
            }
            return nejSlovo;
        }

        public string[] Analyzuj()
        {
            //tahle metoda by šla určitě udělat nějak líp...

            int samohlC = 0, samohlDlC = 0, souhlC = 0, souhlTvrC = 0, souhlMekC = 0, pismC = 0, cislC = 0, zavorC = 0, specZnC = 0;
            string samohlT = "", samohlDlT = "", souhlT = "", souhlTvrT = "", souhlMekT = "", pismT = "", cislT = "", zavorT = "", specZnT = "";

            string samohlasky = "aeiouy";
            string samohlaskyDlouhe = "áéíóúůý";
            string souhlasky = "bflmpsvz";
            string souhlaskyTvrd = "hkrdtn";
            string souhlaskyMekke = "žščřcjďťň";
            string pismena = "gqwx";
            string cisla = "1234567890";
            string zavorky = "<>[]{}()";
            string specZnak = $"\\/|€$ß¤ŁđĐł#&@*“\'\"‘;,:";

            foreach (char znak in Veta.ToLower())
            {
                if (samohlasky.Contains(znak))
                {
                    samohlC++;
                    samohlT += znak + " ";
                }
                if (samohlaskyDlouhe.Contains(znak))
                {
                    samohlDlC++;
                    samohlDlT += znak + " ";
                }
                if (souhlasky.Contains(znak))
                {
                    souhlC++;
                    souhlT += znak + " ";
                }
                if (souhlaskyTvrd.Contains(znak))
                {
                    souhlTvrC++;
                    souhlTvrT += znak + " ";
                }
                if (souhlaskyMekke.Contains(znak))
                {
                    souhlMekC++;
                    souhlMekT += znak + " ";
                }
                if (pismena.Contains(znak))
                {
                    pismC++;
                    pismT += znak + " ";
                }
                if (cisla.Contains(znak))
                {
                    cislC++;
                    cislT += znak + " ";
                }
                if (zavorky.Contains(znak))
                {
                    zavorC++;
                    zavorT += znak + " ";
                }
                if (specZnak.Contains(znak))
                {
                    specZnC++;
                    specZnT += znak + " ";
                }
            }
            string[] vysledky = { $"Celkem: {samohlC}; {samohlT}", $"Celkem: {samohlDlC}; {samohlDlT}", $"Celkem: {souhlC}; {souhlT}",
                $"Celkem: {souhlTvrC}; {souhlTvrT}", $"Celkem: {souhlMekC}; {souhlMekT}", $"Celkem: {pismC}; { pismT}",
                $"Celkem: {cislC}; {cislT}", $"Celkem: {zavorC}; {zavorT}", $"Celkem: {specZnC}; {specZnT}"};

            return vysledky;
        }
        public string Morseovka()
        {
            string text = Veta.Trim().ToLower();
            text = text.Replace("á", "a");
            text = text.Replace("é", "e");
            text = text.Replace("í", "i");
            text = text.Replace("ó", "o");
            text = text.Replace("ú", "u");
            text = text.Replace("ů", "u");
            text = text.Replace("ý", "y");
            text = text.Replace("ž", "z");
            text = text.Replace("š", "s");
            text = text.Replace("č", "c");
            text = text.Replace("ř", "r");
            text = text.Replace("ď", "d");
            text = text.Replace("ť", "t");
            text = text.Replace("ň", "n");

            string sifra = "";
            
            string abecedniZnaky = "abcdefghijklmnopqrstuvwxyz";
            string[] morseovyZnaky = {".-", "-...", "-.-.", "-..",
                ".", "..-.", "--.", "....", "..", ".---", "-.-",
                ".-..", "--", "-.", "---", ".--.", "--.-", ".-.",
                "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."};

            foreach (var item in text)
            {                
                int pozice = abecedniZnaky.IndexOf(item);
                if (pozice >= 0)
                    sifra += morseovyZnaky[pozice] + " | ";
            }     
            return sifra;
        }
    }
}

// TODO : zajistit aby při nevyplnění některého pole vyběhla hláška, ale okno nespadlo
