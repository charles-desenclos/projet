using System;
using System.Collections.Generic;
using System.Text;

namespace projet
{
    public class decod
    {
        int[] carte = new int[0];
        bool frontiere_au_nord ;
        bool frontiere_au_sud;
        bool frontiere_a_louest;
        bool frontiere_a_lest;
        int mer;
        int terre;
        string frontiernord;
        string frontieresud;
        string frontiereouest;
        int [] cartenombre = new int [0];

        public decodage()
        {
            int j;
            int i;
            int l;
            int[] lettre = new int[0];

            if
            {
                if (j < 9)
                {
                    frontiereouest(cartenombre[i, j]);

                }
                if (frontiere_au_nord == true && frontiere_au_sud == true && frontiere_a_lest == true && frontiere_a_louest == false)
                {
                    carte[i, j] = lettre[l];
                    frontiere_au_nord = true;
                    frontiere_au_sud = true;
                    frontiere_a_lest = true;
                    frontiere_a_louest = true;
                    l++;

                }
                else if (frontiere_au_nord == true && frontiere_au_sud == true && frontiere_a_lest == true && frontiere_a_louest == false)
                {
                    frontiere_a_lest = true;
                    frontiere_au_nord = true;
                    frontiere_au_sud = true;
                    frontiernord(cartenombre[i, j + 1]);
                    frontieresud(cartenombre[i - 1, j + 1]);
                    if (frontiere_au_sud == false && frontiere_au_nord == true)
                    {
                        carte[i, j + 1] = carte[i - 1, j + 1];
                        frontiere_au_nord = true;
                        frontiere_au_sud = true;
                    }
                    carte[i, j] = carte[i - 1, j - 1];
                }
                else if (frontiere_a_lest == false && frontiere_au_sud == true && frontiere_au_nord == true)
                {
                    carte[i, j] = carte[i, j - 1];
                    frontiere_au_nord = true;
                    frontiere_au_sud = true;
                }
                else if (frontiere_a_lest == true && frontiere_au_sud == false && frontiere_au_nord == false)
                {
                    carte[i, j] = carte[i - 1, j];
                    frontiere_a_lest = true;

                }
                else if (frontiere_a_lest == false && frontiere_au_sud == false && frontiere_au_nord == true)
                {
                    carte[i, j] = carte[i - 1, j];
                    frontiere_au_sud = true;
                    frontiere_au_nord = true;
                }






            }
            else
            {
                if (j < 9)
                {
                    frontiereouest(cartenombre[i, j]);

                }
                if (frontiere_au_nord == true && frontiere_au_sud == true && frontiere_a_lest == true && frontiere_a_louest == false)
                {
                    carte[i, j] = lettre[l];
                    frontiere_au_nord = false;
                    frontiere_au_sud = false;
                    frontiere_a_lest = false;
                    frontiere_a_louest = false;
                    l++;

                }
                else if (frontiere_au_nord == true && frontiere_au_sud == true && frontiere_a_lest == true && frontiere_a_louest == false)
                {
                    frontiere_a_lest = false;
                    frontiere_au_nord = false;
                    frontiere_au_sud = false;
                    frontiernord(cartenombre[i, j + 1]);
                    frontieresud(cartenombre[i - 1, j + 1]);
                    if (frontiere_au_sud == true && frontiere_au_nord == false)
                    {
                        carte[i, j + 1] = carte[i - 1, j + 1];
                        frontiere_au_nord = false;
                        frontiere_au_sud = false;
                    }
                    carte[i, j] = carte[i - 1, j - 1];
                }
                else if (frontiere_a_lest == false && frontiere_au_sud == true && frontiere_au_nord == true)
                {
                    carte[i, j] = carte[i, j - 1];
                    frontiere_au_nord = false;
                    frontiere_au_sud = false;
                }
                else if (frontiere_a_lest == true && frontiere_au_sud == false && frontiere_au_nord == false)
                {
                    carte[i, j] = carte[i - 1, j];
                    frontiere_a_lest = false;

                }
                else if (frontiere_a_lest == false && frontiere_au_sud == false && frontiere_au_nord == true)
                {
                    carte[i, j] = carte[i - 1, j];
                    frontiere_au_sud = false;
                    frontiere_au_nord = false;
                }
            }
        }


       

           

           

            


    }
}
