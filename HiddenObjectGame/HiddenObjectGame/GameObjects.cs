using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HiddenObjectGame
{
    public class GameObjects
    {
        public List<HiddenObject> lista;

        public GameObjects(int n)
        {
            lista=new List<HiddenObject>();
            switch (n)
            {
                case 1:
                    lista.Add(new HiddenObject(22, 258, 45, 45));  //spider
                    lista.Add(new HiddenObject(10,415, 65, 45));  //stones
                    lista.Add(new HiddenObject(120, 490, 37, 49)); //pinecone
                    lista.Add(new HiddenObject(675, 473, 60, 70));  //bucket
                    lista.Add(new HiddenObject(531, 183, 39, 72));  //phone
                    lista.Add(new HiddenObject(625, 60, 42, 65));  //skull
                    lista.Add(new HiddenObject(228, 241, 32, 72));  //brush
                    lista.Add(new HiddenObject(465, 145, 30, 100));  //skrew
                    lista.Add(new HiddenObject(128, 20, 30, 100));  //knife
                    lista.Add(new HiddenObject(347, 89, 30, 75));  //Golden Bell
                    break;
                case 2:
                    lista.Add(new HiddenObject(60, 550, 37, 37)); //seashell
                    lista.Add(new HiddenObject(150, 330, 55, 39)); //turtle
                    lista.Add(new HiddenObject(558, 15, 30, 39)); //lightbulb
                    lista.Add(new HiddenObject(725, 530, 17, 63)); //cactus
                    lista.Add(new HiddenObject(603, 462, 37, 50)); //jar of pennies
                    lista.Add(new HiddenObject(53, 85, 40, 40)); //donut
                    lista.Add(new HiddenObject(0, 255, 32, 35)); //toy boxes
                    lista.Add(new HiddenObject(505, 390, 40, 30)); // military helm
                    lista.Add(new HiddenObject(370, 388, 30, 80)); //trumpet
                    lista.Add(new HiddenObject(388, 300, 35, 70)); //candles
                    break;
                case 3:
                    lista.Add(new HiddenObject(362, 165, 28, 35)); //pepper
                    lista.Add(new HiddenObject(295, 353, 28, 36)); //salt
                    lista.Add(new HiddenObject(758, 345, 30, 45)); //crayons
                    lista.Add(new HiddenObject(620, 465, 60, 45)); //tiger
                    lista.Add(new HiddenObject(470, 476, 38, 38)); //shrimp
                    lista.Add(new HiddenObject(38, 430, 42, 42)); //clock
                    lista.Add(new HiddenObject(100, 370, 40, 40)); //apple
                    lista.Add(new HiddenObject(630, 220, 70, 45)); //mailbox
                    lista.Add(new HiddenObject(275, 120, 55, 80)); //ship in bottle
                    lista.Add(new HiddenObject(43, 520, 50, 60)); //grey glove
                    break;
            }
        }
    }
}
