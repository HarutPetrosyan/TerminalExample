using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Terminal.Views.Pages.ATMCheckPage
{
    /// <summary>
    /// Interaction logic for ATMCheckPage.xaml
    /// </summary>
    public partial class ATMCheckPage : Page
    {
        public ATMCheckPage()
        {
            InitializeComponent();
            CustomerLogoFrame.Content = new UIComponents.CustomerLogo.CustomerLogo().CustomerLogoGrid;
            CustomerContactFrame.Content = new UIComponents.CustomerContacts.CustomerContacts().CustomerContactsGrid;
           
            ATMCheckContent.Content = new UIComponents.ATMCheck.ATMCheck().ATMCheckContentGrid;
        }
    }
}
