using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace HiddenObjectGame
{
    public class HighScore
    {
        public string[] names;
        public int[] scores;

        public HighScore()
        {
            this.scores = new int[10];
            this.names = new string[10];
        }


        public void sort()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = i+1; j < 10; j++)
                {
                    if (scores[i] < scores[j])
                    {
                        int tmp = scores[i];
                        scores[i] = scores[j];
                        scores[j] = tmp;
                        string s = names[i];
                        names[i] = names[j];
                        names[j] = s;
                    }
                }
            }
        
        }
    }
}
