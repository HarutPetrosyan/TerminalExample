using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Terminal.ViewModels
{
    internal class MainPageViewModel : INotifyPropertyChanged
    {

        public MainPageViewModel()
        {
            RefreshUI();
            MustChanging();
        }

        public static bool MustPropertyesChanging;

        private async void MustChanging()
        {
            if (MustPropertyesChanging)
            {
                OnPropertyChanged("ClientVariables"); // Refacktoring
            }
            MustPropertyesChanging = false;
            await Task.Delay(10);
            MustChanging();
        }
       

        private async void RefreshUI()
        {
            await Task.Factory.StartNew(async () => {

                
                if (Models.Commands.SelectKeyboardLanguage.LanguageChangingStatement || Models.Commands.CapsLock.CapsLockCondition)
                {
                    await Task.Delay(50);
                    OnPropertyChanged("KeyBoard");
                    Models.Commands.SelectKeyboardLanguage.LanguageChangingStatement = false;
                    Models.Commands.CapsLock.CapsLockCondition = false;
                }
                OnPropertyChanged(nameof(PatientPhoneNumberInput));
                 OnPropertyChanged(nameof(CapsLock));
                 OnPropertyChanged(nameof(PatientVisitCodeInput));

                OnPropertyChanged(nameof(CDeletLastVisibility));

                // Translations
                OnPropertyChanged(nameof(PayByCode));
                OnPropertyChanged(nameof(PatientVariables));

                OnPropertyChanged(nameof(Departments));
                OnPropertyChanged(nameof( SelectedServices));

                if (Models.Statics.PatientVisitCode.Length>0)
                {
                    _CDeletLastVisibility = Visibility.Visible;
                }
                else
                {
                    _CDeletLastVisibility = Visibility.Hidden;
                }

            });



            // Translations

            OnPropertyChanged(nameof(PatientName));
            OnPropertyChanged(nameof(VisitDateTime));
             OnPropertyChanged(nameof(VisitCode));
            OnPropertyChanged(nameof(Services));
            OnPropertyChanged(nameof(Total));
            OnPropertyChanged(nameof(Payments));
            OnPropertyChanged(nameof(Pay));
            OnPropertyChanged(nameof(ToBePaid));
            


            await Task.Delay(10);
            RefreshUI();
        }

       

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        //prop

        public Models.Clients.ClientVariables ClientVariables { get => new Models.Clients.ClientVariables(); }
        public Models.Patients.PatientVariables PatientVariables { get => new Models.Patients.PatientVariables(); }

        private Visibility _CDeletLastVisibility = Visibility.Hidden;


        public Visibility CDeletLastVisibility { get => _CDeletLastVisibility; }




        public Models.KeyboardModels.Keyboard KeyBoard { get => new Models.KeyboardModels.Keyboard(Models.Commands.SelectKeyboardLanguage.SelectedLanguage,Models.Commands.CapsLock.CapsLockStatement); }

        //Commands

       public ICommand PayToPhoneNumber
       {
           get => new Models.Commands.PayToPhoneNumberCommand();
       }
        public ICommand InfoToPhoneNUmberCommand
        {
            get => new Models.Commands.InfoToPhoneNUmberCommand();
        }
        public ICommand PatientClinicInfoBackCommand
        {
            get => new Models.Commands.PatientCinicBackCommand();
        }
        public static ICommand CodeActivatePageSelect { get => new Views.UIComponents.CodeActivate.CodeActivateCommand(); }
        public static ICommand ContentPage1Next
        {
            get => new Models.Commands.HomePageNextCommand();
        }
        public static ICommand ContentPage2Back
        {
            get => new Models.Commands.HomePageBackCommand();
        }
       
        //public static ICommand ContentPage3Back { get => new Views.UIComponents.Arrows.ContentPage3BackArrow.ContentPage3BackCommand(); }
        public ICommand HomePageBackCommand {get => new Models.Commands.HomePageBackCommand();}
        public ICommand EnterCode { get => new Models.Commands.EnterCode(); }
        public ICommand PatientClinicNextArrow { get => new Models.Commands.PhoneNumberPageNextArrowCommand(); }
        public ICommand PatientClinicPayBackArrow { get => new Models.Commands.PatientPayCommand(); }
        public ICommand CapsLock { get => new Models.Commands.CapsLock(); }

        public ICommand PatientPayFinal { get =>new  Models.Commands.PatientPayFinalCommand(); }
        public ICommand SelectLanguage { get => new Models.Commands.SelectLanguage();  }

        public ICommand SelectKeyboardLanguage { get => new Models.Commands.SelectKeyboardLanguage();  }

        public ICommand InputKey { get =>new Models.Commands.InputPatientVisitCodeKey(); }

        public ICommand InputPatientDelete { get => new Models.Commands.InputPatientVisitCodeKeyDelete(); }

        public ICommand InputPatientDeleteLast { get => new Models.Commands.InputPatientVisitCodeKeyDeleteLast(); }
        public ICommand InputPatientPhoneNumberCommand
        {
            get => new Models.Commands.PatientPhoneNumberCommand();
        }
        public ICommand DeletePatientNumberCommand
        {
            get => new Models.Commands.PatientPhoneNumberDelete();
        }
        public ICommand DeleteLastPatientNumberCommand
        {
            get => new Models.Commands.PatientPhoneNumberDeleteLast();
        }
        // Translations

        public string PayByCode { get => Properties.Translations.PayByCode; }

        // inputs

        public string PatientVisitCodeInput { get => Models.Statics.PatientVisitCode; }
        public string PatientPhoneNumberInput
        {
            get => Models.Statics.PatientPhoneNumber;
        }


        // Service Provided 
        public Models.Clients.Serializable.Departments Departments { get => new Models.Clients.Departments(Models.Statics.SelectedCulture).Get(); }
        public List< Models.Clients.Serializable.Service> SelectedServices { get => Models.Statics.SelectedServices; }

        // PaymentAsk

        public Models.API.Serializable.PaymentAsk PaymentAsk { get => Models.Statics.PaymentAsk; }
        public float MustPaymentSumm { get=> Models.Statics.MustPaymentSumm; }


        // Translations  
        public string PatientName { get => Properties.Translations.PatientName; }
        public string VisitDateTime { get => Properties.Translations.VisitDateTime; }
        public string VisitCode { get => Properties.Translations.VisitCode; }
        public string Services { get => Properties.Translations.Services; }
        public string Total { get => Properties.Translations.Total; }
        public string Payments { get => Properties.Translations.Payments; }
        public string Pay { get => Properties.Translations.Pay; }
        public string ToBePaid { get => Properties.Translations.ToBePaid; }



        //








    }

   
    
}
