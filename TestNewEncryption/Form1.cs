using CzStringMethods;
using System.Security.Cryptography;
using static CzStringMethods.CzEncryption;
using static CzStringMethods.CzRandString;

namespace TestNewEncryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = passwordTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(passwordTextBox.Text))
            {
                PopulateMethod1();
                PopulateMethod2();
                PopulateMethod4();
            }
        }

        private void FalsifyButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.falsePasswordTextBox.Text))
            {
                PopulateFalseMethod1();
                PopulateFalseMethod2();
                PopulateFalseMethod4();
            }
        }

        private void PopulateMethod1()
        //Using the old method - a tad insecure
        //Can be done from code without knowing the password
        {
            //Encrypt----------------------------------------------------------------------------------------------//
            //Generate key
            this.keyOldTextBox.Text = GenerateRandomString(16);
            //encrypt key
            this.KeyEncrOldTextBox.Text = EncryptSs(this.keyOldTextBox.Text);
            //encrypt password
            this.encryOldTextBox.Text = SecureEncrypt(this.passwordTextBox.Text, this.keyOldTextBox.Text);
            //Decrypt----------------------------------------------------------------------------------------------//
            //decrypt key
            this.decryKeyOldTextBox.Text = DecryptSs(this.KeyEncrOldTextBox.Text);
            //decrypt password
            this.decryOldTextBox.Text = SecureDecrypt(this.encryOldTextBox.Text, this.decryKeyOldTextBox.Text);
        }

        private void PopulateMethod2()
        //using the length of the password as key
        //can be done if you know the length of the password
        {
            //Encrypt----------------------------------------------------------------------------------------------//
            //Generate key
            this.keyTwoTextBox.Text = GetKeyPhrase(this.passwordTextBox.Text);
            this.encryTwoTextBox.Text = SecureEncrypt(this.passwordTextBox.Text, this.keyTwoTextBox.Text);
            //Decrypt
            //Get Key (this does not store key as it is generated always)
            this.decryKeyTwoTextBox.Text = GetKeyPhrase(this.passwordTextBox.Text);
            //decrypt password
            this.decryTwoTextBox.Text = SecureDecrypt(this.encryTwoTextBox.Text, this.decryKeyTwoTextBox.Text);
        }

        private void PopulateMethod3()
        {
            //Encrypt----------------------------------------------------------------------------------------------//
            UserPassword userPassword = new UserPassword();

            //Generate key
            this.keyThreeTextBox.Text = GetSecureKeyPhrase(this.passwordTextBox.Text);
            //encrypt password
            this.encryThreeTextBox.Text = SecureEncrypt(this.passwordTextBox.Text, this.keyThreeTextBox.Text);
            this.KeyEncrThreeTextBox.Text = GetSecureKeyPhrase(this.passwordTextBox.Text);
            //Decrypt
            this.decryKeyThreeTextBox.Text = GetSecureKeyPhrase(this.passwordTextBox.Text);
            //Check if valid
            this.decryThreeTextBox.Text = SecureDecrypt(this.encryThreeTextBox.Text, this.keyThreeTextBox.Text);
            //this.decryThreeTextBox.Text = SecureDecrypt(this.encryThreeTextBox.Text, this.keyThreeTextBox.Text);
        }

        private void PopulateMethod4()
        {
            //Encrypt----------------------------------------------------------------------------------------------//
            UserPassword userPassword = GetPasswordHash(this.passwordTextBox.Text);
            //Generate key
            this.keyThreeTextBox.Text = userPassword.Salt;
            //encrypt password
            //MessageBox.Show($"Key length is {this.keyThreeTextBox.Text.Length}");
            this.encryThreeTextBox.Text = userPassword.HashedPassword;
            //Decrypt
            //this.decryKeyThreeTextBox.Text = GetKeyPhraseDterm(this.passwordTextBox.Text);
            this.decryThreeTextBox.Text = VerifyPassword(this.passwordTextBox.Text, userPassword.HashedPassword, userPassword.Salt).ToString();
        }

        private void PopulateFalseMethod1()
        {
            //Encrypt----------------------------------------------------------------------------------------------//
            //Generate key
            this.keyOldTextBox.Text = GenerateRandomString(16);
            //encrypt key
            this.KeyEncrOldTextBox.Text = EncryptSs(this.keyOldTextBox.Text);
            //encrypt password
            this.encryOldTextBox.Text = SecureEncrypt(this.passwordTextBox.Text, this.keyOldTextBox.Text);
            //Decrypt----------------------------------------------------------------------------------------------//
            //decrypt key
            this.decryKeyOldTextBox.Text = DecryptSs(this.KeyEncrOldTextBox.Text);
            //decrypt password
            this.decryOldTextBox.Text = SecureDecrypt(this.encryOldTextBox.Text, this.decryKeyOldTextBox.Text);
        }

        private void PopulateFalseMethod2()
        {
            //Encrypt----------------------------------------------------------------------------------------------//
            //Generate key
            this.keyTwoTextBox.Text = GetKeyPhrase(this.passwordTextBox.Text);
            this.encryTwoTextBox.Text = SecureEncrypt(this.passwordTextBox.Text, this.keyTwoTextBox.Text);
            //Decrypt
            //Get Key
            this.decryKeyTwoTextBox.Text = GetKeyPhrase(this.falsePasswordTextBox.Text);
            //decrypt password
            this.decryTwoTextBox.Text = SecureDecrypt(this.encryTwoTextBox.Text, this.decryKeyTwoTextBox.Text);
        }

        private void PopulateFalseMethod3()
        {
            //Encrypt----------------------------------------------------------------------------------------------//
            UserPassword userPassword = new UserPassword();

            //Generate key
            this.keyThreeTextBox.Text = GetKeyPhraseDterm(this.passwordTextBox.Text);
            //encrypt password
            this.encryThreeTextBox.Text = SecureEncrypt(this.passwordTextBox.Text, this.keyThreeTextBox.Text);
            //Decrypt
            this.decryKeyThreeTextBox.Text = GetKeyPhraseDterm(this.falsePasswordTextBox.Text);
            //Check if valid
            this.decryThreeTextBox.Text = (this.decryKeyThreeTextBox.Text == this.keyThreeTextBox.Text) ? true.ToString() : false.ToString();
        }

        private void PopulateFalseMethod4()
        {
            //Encrypt----------------------------------------------------------------------------------------------//
            UserPassword userPassword = GetPasswordHash(this.passwordTextBox.Text);
            //Generate key
            this.keyThreeTextBox.Text = userPassword.Salt;
            //encrypt password
            //MessageBox.Show($"Key length is {this.keyThreeTextBox.Text.Length}");
            this.encryThreeTextBox.Text = userPassword.HashedPassword;
            //Decrypt
            //this.decryKeyThreeTextBox.Text = GetKeyPhraseDterm(this.passwordTextBox.Text);
            this.decryThreeTextBox.Text = VerifyPassword(this.falsePasswordTextBox.Text, userPassword.HashedPassword, userPassword.Salt).ToString();

        }
    }
}
