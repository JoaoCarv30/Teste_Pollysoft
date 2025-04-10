namespace Maui
{
    public partial class MainPage : ContentPage
    {
        
        private bool emailValid = false;
        private bool emailsValid = false;
        private bool passwordValid = false;
        private bool passwordsValid = false;
        private bool phoneValid = false;
        
        public MainPage()
        {
            InitializeComponent();
            
            EmailEntry.TextChanged += CheckEmail;
            ConfirmEmailEntry.TextChanged += CheckEmails;
            PhoneEntry.TextChanged += CheckPhone;
            PasswordEntry.TextChanged += CheckPassword;
            ConfirmPasswordEntry.TextChanged += CheckPasswords;
            
       
        }
        
       
        private void CheckEmail(object sender, TextChangedEventArgs e)
        {

            if (EmailEntry.Text.Contains("@"))
            {
                EmailErrorLabel.IsVisible = false;
                emailValid = true;

            } else 
            {
                EmailErrorLabel.IsVisible = true;
                emailValid = false;

            }
            
            CheckEmails(null, null);
            EnableButton();

        }

        private void CheckEmails(object sender, TextChangedEventArgs e)
        {

            if (EmailEntry.Text == ConfirmEmailEntry.Text && EmailEntry.Text.Contains("@"))
            {
                ConfirmEmailErrorLabel.IsVisible = false;
                emailsValid = true;

            } else 
            {
                ConfirmEmailErrorLabel.IsVisible = true;
                emailsValid = false;

            }
            
            EnableButton();

        }
        
        private void CheckPassword(object sender, TextChangedEventArgs e)
        {
            if (PasswordEntry.Text.Length >= 8) 
            {
                PasswordErrorLabel.IsVisible = false;
                passwordValid = true;
            } 
            else 
            {
                PasswordErrorLabel.IsVisible = true;
                passwordValid = false;
            }
            CheckPasswords(null, null);
            EnableButton();
        }

        
        private void CheckPasswords(object sender, TextChangedEventArgs e)
        {

            if (PasswordEntry.Text == ConfirmPasswordEntry.Text )
            {
                ConfirmPasswordErrorLabel.IsVisible = false;
                passwordsValid = true;
            } else 
            {
                ConfirmPasswordErrorLabel.IsVisible = true;
                passwordsValid = false;
            }
            
   
            EnableButton();
        }

        private void CheckPhone(object sender, TextChangedEventArgs e)
        {
            if (PhoneEntry.Text.Length == 11 && PhoneEntry.Text.All(char.IsDigit))
            {
                ConfirmPhoneErrorLabel.IsVisible = false;
                phoneValid = true;
            }
            else
            {
                ConfirmPhoneErrorLabel.IsVisible = true;
                phoneValid = false;
            }
            
       
            EnableButton();
        }
        
            
        private void EnableButton()
        {
            if (emailValid && emailsValid && passwordValid && passwordsValid && phoneValid)
            {
                RegisterButton.IsEnabled = true;
                RegisterButton.BackgroundColor = Color.FromHex("#336cff");
            }
            else
            {
                RegisterButton.IsEnabled = false;
                RegisterButton.BackgroundColor = Color.FromHex("#A9BFF8");
                RegisterButton.TextColor = Color.FromHex("#FFFFFF");
            }
        }
        
        
    }
}
