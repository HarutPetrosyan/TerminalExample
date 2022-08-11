using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoadingIndicators.WPF;

namespace Terminal.Models.Wait
{
    internal class WaitPageAnimation
    {
        public WaitPageAnimation()
        {
            Animation1();
            Animation2();
        }

        private async void Animation1()
        {
            for (int i = 0; i < 360; i++)
            {
                await Task.Delay(1);
                MainWindow.WaitTransform.Angle = i;
            }
            Animation1();
        }


        private async void Animation2()
        {
            foreach ( System.Windows.Controls.Border button in MainWindow.WaitGrid.Children)
            {
                await Task.Delay(50);
                button.Background = System.Windows.Media.Brushes.Red;
            }
            await Task.Delay(1);
            
            foreach (System.Windows.Controls.Border button in MainWindow.WaitGrid.Children)
            {
                await Task.Delay(100);
                button.Background = System.Windows.Media.Brushes.Aqua;
            }
            await Task.Delay(1);
            foreach (System.Windows.Controls.Border button in MainWindow.WaitGrid.Children)
            {
                await Task.Delay(40);
                button.Background = System.Windows.Media.Brushes.Transparent;
            }
            await Task.Delay(1);
            

            Animation2();
        }

    }
}
