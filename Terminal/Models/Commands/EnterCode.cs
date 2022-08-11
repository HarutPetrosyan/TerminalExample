using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Terminal.Models.Commands
{
    internal class EnterCode : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async   void Execute(object parameter)
        {
            await Task.Delay(10);
            new Wait.WaitPage(true);
            await Task.Delay(10);
            var PaymentResult  = new API.BackServer.PaymentAskByVisitCode().Api(Statics.SelectedCulture, Statics.PatientVisitCode);
            Statics.PaymentAsk = PaymentResult.Item1;

            

            if (PaymentResult.Item2)
            {
                
                if(PaymentResult.Item1.isExist)
                {
                    float TotalPayed = 0;
                    foreach (var item in PaymentResult.Item1.visitPayments)
                    {
                        TotalPayed = TotalPayed + item.payed;
                    }
                    Statics.PaymentAsk.PaidTotal = TotalPayed.ToString();
                    Statics.MustPaymentSumm = float.Parse(Statics.PaymentAsk.mustBePaidTotal) - TotalPayed;
                    MainWindow.MainWindowcontentBody.Content = new Views.Pages.PatientClinicInfoPage.PatientClinicInfoPage().Content;
                }
                else
                {
                    new Wait.WaitPage(false);
                    MainWindow.MainWindowcontentBody.Content = new Views.Pages.ErrorPage.ErrorPage().Content;
                    await Task.Delay(3000);
                    MainWindow.MainWindowcontentBody.Content = new Views.Pages.CodeActivatePage.CodeActivatePage().Content;
                }
               
            }
            else
            {
                new Wait.WaitPage(false);
                MainWindow.MainWindowcontentBody.Content = new Views.Pages.ErrorPage.ErrorPage().Content;
                await Task.Delay(3000);
                MainWindow.MainWindowcontentBody.Content = new Views.Pages.CodeActivatePage.CodeActivatePage().Content;
            }
                

            new Wait.WaitPage(false);
        }
    }
}
