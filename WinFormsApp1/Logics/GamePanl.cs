using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Logics
{
    // این قسمت رو کامل با کمک هوش مصنوعی پیاده سازی کردم برای رفع مشکل چشمک زدن 
    public class GamePanel : Panel
    {
        public GamePanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
        }
    }
}
