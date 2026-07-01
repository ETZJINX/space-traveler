using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.Managers
{
    public static class FORMMANAGER
    {
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
                current.Show();
            }
            
        }
    }
}
