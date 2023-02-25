using CryptographyLib;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Cryptography
{
    public partial class Lab1 : Page
    {
        private CaesarCipher caesarCipher = new CaesarCipher();

        public Lab1()
        {
            InitializeComponent();

            InsertValuesInComboBoxAlphabet();
            TextBoxCustom.Text = CaesarCipher.Languages[Alphabet.Custom];
            SetTextBlockAlphabetLength();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            MakeAction();
        }

        private void TextBoxEncrypted_KeyUp(object sender, KeyEventArgs e)
        {
            DecryptText();
        }

        private void TextBoxDecrypted_KeyUp(object sender, KeyEventArgs e)
        {
            EncryptText();
        }

        private void UpDownControlKey_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (IsLoaded)
                caesarCipher.Key = UpDownControlKey.Value ?? 0;

            MakeAction();
        }

        private void ComboBoxAlphabet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            caesarCipher.SelectedLanguage = (Alphabet)ComboBoxAlphabet.SelectedIndex;

            TextBoxCustom.Visibility = caesarCipher.SelectedLanguage == Alphabet.Custom ? Visibility.Visible : Visibility.Hidden;
            SetTextBlockAlphabetLength();
            MakeAction();
        }

        private void TextBoxCustom_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (IsLoaded)
                CaesarCipher.Languages[Alphabet.Custom] = TextBoxCustom.Text;
            SetTextBlockAlphabetLength();
            MakeAction();
        }
        private void InsertValuesInComboBoxAlphabet()
        {
            foreach (var alphabet in CaesarCipher.Languages.Keys)
                ComboBoxAlphabet.Items.Add(alphabet);
            ComboBoxAlphabet.SelectedIndex = 0;
        }

        private void EncryptText()
        {
            if (IsLoaded)
            {
                caesarCipher.Mode = EncryptorMode.Encrypt;
                TextBoxEncrypted.Text = caesarCipher.Crypt(TextBoxDecrypted.Text);
                ArrowAngle.Angle = 0;
            }
        }

        private void DecryptText()
        {
            if (IsLoaded)
            {
                caesarCipher.Mode = EncryptorMode.Decrypt;
                TextBoxDecrypted.Text = caesarCipher.Crypt(TextBoxEncrypted.Text);
                ArrowAngle.Angle = 180;
            }
        }

        private void SetTextBlockAlphabetLength()
        {
            TextBlockAlphabetLength.Text = CaesarCipher.Languages[caesarCipher.SelectedLanguage].Length.ToString();
        }

        private void MakeAction()
        {
            if (caesarCipher.Mode == EncryptorMode.Encrypt)
                EncryptText();
            else
                DecryptText();
        }
    }
}
