using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        
        {
            #region salasanan murtaminen //ei wörki
            //tehdään 5 merkkinen salasana
            //md5:lla tiivistetään merkkijonot 32-merkkiseen merkkijonoon
            string salasana = "d39bf219932bbb58212fb4692965f701";
            string tulos = "";
            string merkit = "0123456789abcdefghijlkmnopqrstuvwxyz";
            string tiiviste = "";
            //char on yksittäinen merkki
            //tässä loop hakee merkit muuttujasta ensimmäisen merkin
            foreach (char c1 in merkit)
            {
                foreach(char c2 in merkit)
                {
                    foreach (char c3 in merkit)
                    {
                        foreach (char c4 in merkit)
                        {
                            tulos = "" + c1 + c2 + c3+c4;
                            byte[] encodedPassword = new UTF8Encoding().GetBytes(tulos);
                            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
                            tiiviste = BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
                            if (tiiviste == salasana)
                            {
                                goto Lopetus;
                            }
                        }
                    }

                }
            }
            Lopetus:
            Console.WriteLine(tiiviste);
            #endregion
        }
    }
}
