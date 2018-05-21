using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GibberishGenerator
{
    public class Syllables
    {
        private static Random rng = null;

        private static void initRng()
        {
            if (rng == null) {
                rng = new Random((int)DateTime.Now.Ticks);
            }
        }

        private static String[] vowels =
        {
            "",
            "a",
            "e",
            "i",
            "o",
            "u",
            "y",
            "ai",
            "ae",
            "ao",
            "au",
            "aa",
            "ee",
            "ei",
            "ea",
            "eo",
            "eu",
            "ii",
            "ia",
            "ie",
            "iu",
            "io",
            "oo",
            "oi",
            "oa",
            "oe",
            "ou",
            "uu",
            "ua",
            "ui",
            "ue",
            "uo",
            "ya",
            "ay",
            "ye",
            "ey",
            "yi",
            "iy",
            "yu",
            "uy",
            "yo",
            "oy"
        };

        private static String[] consonants =
        {
            "",
            "b",
            "c",
            "d",
            "f",
            "g",
            "h",
            "j",
            "k",
            "l",
            "m",
            "n",
            "p",
            "q",
            "qu",
            "r",
            "s",
            "t",
            "v",
            "w",
            "x",
            "y",
            "z",
            "ck",
            "ch",
            "sh",
            "st",
            "ts",
            "th",
            "sc",
            "ph",
            "sl",
            "nn",
            "mm",
            "ll",
            "ss",
            "bb",
            "dd",
            "rr",
            "pp",
            "tt"
        };

        public static String getVowel()
        {
            initRng();
            int index = rng.Next(0, vowels.Length );
            return vowels[index];
        }

        public static String getConsonant()
        {
            initRng();
            int index = rng.Next(0, consonants.Length );
            return consonants[index];
        }

        public static String getSyllable()
        {
            String vowel = getVowel();
            String consonant = getConsonant();

            String retval;

            int whichFirst = rng.Next(0, 2);
            if(whichFirst == 0)
            {
                retval = vowel + consonant;
            } else
            {
                retval = consonant + vowel;
            }
            return retval;
        }

        public static String getWord()
        {
            initRng();
            String retval = "";

            int syllables = rng.Next(3, 9);
            for (int i = 0; i < syllables; i++)
            {
                retval += getSyllable();
            }

            return retval;
        }
    }
}
