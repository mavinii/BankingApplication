using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankingApplication.Models
{
    class TextAnimation
    {
        public static void AnimationTyping(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(300);
            }
        }

        //public static void Blink(string text, int blinkCount = 5, int onTime = 500, int offTime = 200)
        //{
        //    CursorVisible = false;
        //    for (int i = 0; i < blinkCount; i++)
        //    {
        //        Console.WriteLine(text);
        //        Thread.Sleep(onTime);
        //        Clear();
        //        Thread.Sleep(offTime);
        //    }
        //    Console.WriteLine(text);
        //    CursorVisible = true;
        //}
    }
}
