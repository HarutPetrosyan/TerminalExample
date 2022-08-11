using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Models.Wait
{
    internal class WaitPage
    {
        public WaitPage(bool visibility)
        {
            if (visibility)
            {
                MainWindow.WaitPage.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                MainWindow.WaitPage.Visibility = System.Windows.Visibility.Hidden;
            }
            
        }
    }
}
