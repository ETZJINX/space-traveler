using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.Logics;

namespace WinFormsApp1.Managers
{
    public static class FORMMANAGER
    {
        public static void setbackground(Form current)
        {
            current.BackgroundImage = ShopManager.getequipedbackground();
            current.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public static void setbackground(Panel current)
        {
            current.BackgroundImage = ShopManager.getequipedbackground();
            current.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public static void handleform(Form current , Form next)
        {
            current.Hide();
            try
            {
                next.ShowDialog();
            }
            finally
            {
                next.Dispose();
                setbackground(current);
                current.Show();
            }
            
        }
    }
}
