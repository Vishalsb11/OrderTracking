using ShippingXam.Views;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ShippingXam.Models
{
    public class LoginCredentialsViewModel
    {
        public ObservableCollection<LoginCredentials> loginCredentials { get; set; }
        public LoginCredentials loginProcess { get; set; }
        public ObservableCollection<UserDetails> userDetails { get; set; }
        //public Action DisplayInvalidLoginPrompt;
        //public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public ICommand SubmitCommand { protected set; get; }
        int i = 0;

        public LoginCredentialsViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
             
            loginCredentials = new ObservableCollection<LoginCredentials>()
            {
                new LoginCredentials { Username="vishalsb123", Password= "Vishal123", LoginStatus=false},
                new LoginCredentials { Username = "kannan456", Password="Kannan456", LoginStatus=false}
            };

            userDetails = new ObservableCollection<UserDetails>()
            {
                new UserDetails {Name="Vishal S B", Email="sbvishal.10@gmail.com", PhoneNumber=9663669966, Dob = new DateTime(2000, 08, 11, 0, 0, 0), SetUsername= "vishalsb123", Password="Vishal123", ConfirmPassword="Vishal123"},
                new UserDetails {Name="Kannan S", Email="kannan.s@gmail.com", PhoneNumber=9876543210, Dob = new DateTime(1995, 07, 29, 0, 0, 0), SetUsername= "kannan456", Password="Kannan456", ConfirmPassword="Kannan456"}
            };            
        }

        private void OnSubmit()
        {
            while ((i >= 0) && (i < loginCredentials.Count))
            {
                if (loginProcess.Username == loginCredentials[i].Username && loginProcess.Password == loginCredentials[i].Password)
                {
                    loginProcess.LoginStatus = true;
                    i = loginCredentials.Count;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}

//if (loginCredentials.Contains())
//{
//    loginProcess.LoginStatus = true;
//}
//else
//{
//    loginProcess.LoginStatus=false;
//}