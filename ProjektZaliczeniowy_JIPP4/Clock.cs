using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektZaliczeniowy_JIPP4
{
    class Clock
    {
        public Timer time = new Timer();
        
        public int WIDTH = 300;
        public int HEIGHT = 300;
        public int secondHand = 140;
        public int minuteHand = 110;
        public int hourHand = 80;

        public int positionX, positionY;

        public Bitmap bitmap;
        public Graphics graphics;

        
        public int[] miunuteCrood(int valueMinute, int rotation)
        {
            int[] crood = new int[2];
            valueMinute *= 6; //obrót co minutę o 6 stopni

            if (valueMinute >= 0 && valueMinute <= 180)
            {
                crood[0] = positionX + (int)(rotation * Math.Sin(Math.PI * valueMinute / 180));
                crood[1] = positionY - (int)(rotation * Math.Cos(Math.PI * valueMinute / 180));
            }
            else
            {
                crood[0] = positionX - (int)(rotation * -Math.Sin(Math.PI * valueMinute / 180));
                crood[1] = positionY - (int)(rotation * Math.Cos(Math.PI * valueMinute / 180));
            }

            return crood;
        }
        
        public int[] hourCrood(int valueHour, int valueMinute, int rotation)
        {
            int[] crood = new int[2];

            //kazda godzina robi obrót o 30 stopni
            //kazda minuta robi obrot o 0.5 stopnia
            int value = (int)((valueHour * 30) + (valueMinute * 0.5));

            if (value >= 0 && value <= 180)
            {
                crood[0] = positionX + (int)(rotation * Math.Sin(Math.PI * value / 180));
                crood[1] = positionY - (int)(rotation * Math.Cos(Math.PI * value / 180));
            }
            else
            {
                crood[0] = positionX - (int)(rotation * -Math.Sin(Math.PI * value / 180));
                crood[1] = positionY - (int)(rotation * Math.Cos(Math.PI * value / 180));
            }

            return crood;
        }
    }

}
