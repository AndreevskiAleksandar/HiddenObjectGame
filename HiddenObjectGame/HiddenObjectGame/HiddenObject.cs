using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HiddenObjectGame
{
    public class HiddenObject
    {
        public bool isHit;
        public float x_position;
        public float y_position;
        public float radius_x;
        public float radius_y;

        public HiddenObject(float x, float y, float r_x, float r_y)
        {
            isHit = false;
            x_position = x;
            y_position = y;
            radius_x = r_x;
            radius_y = r_y;
        }

    }
}
