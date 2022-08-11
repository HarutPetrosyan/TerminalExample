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

namespace Terminal.Views.Pages.ContentPage2
{
    /// <summary>
    /// Interaction logic for ContentPage2.xaml
    /// </summary>
    public partial class ContentPage2 : Page
    {
        public ContentPage2()
        {
            InitializeComponent();
            CustomerLogoFrame.Content = new UIComponents.CustomerLogo.CustomerLogo().CustomerLogoGrid;
            CustomerContactFrame.Content = new UIComponents.CustomerContacts.CustomerContacts().CustomerContactsGrid;
            
            
           
            InfoFrame.Content = new UIComponents.ServicesProvided.ServicesProvided().ServicesProvidedGrid;
            
        }
        
    }
}
