using CryptographyLib;
using System;
using System.Collections;
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

namespace Cryptography.Pages
{
    /// <summary>
    /// Interaction logic for Lab2.xaml
    /// </summary>
    public partial class Lab3 : Page
    {
        public Lab3()
        {
            InitializeComponent();
        }

        private void TextBoxInput_KeyDown(object sender, TextChangedEventArgs e)
        {
            if (!IsLoaded)
                return;
            var input = (TextBox)sender;
            var bitArray = GammaXOR.StringToBitArray(input.Text);
            string result = "";

            foreach (var a in bitArray)
            {
                result += Convert.ToInt32(a);
            }
            TextBoxInputBit.Text = result;
        }

        private void TextBoxInputBit_KeyDown(object sender, TextChangedEventArgs e)
        {
            if (!IsLoaded)
                return;
            var input = (TextBox)sender;
            TextBoxInput.Text = GammaXOR.BitArrayToString(new BitArray(input.Text.Select(c => c == '1').ToArray()));
        }

        private void TextBoxGammaKey_KeyDown(object sender, TextChangedEventArgs e)
        {
            if (!IsLoaded)
                return;
            var bitArray = GammaXOR.StringToBitArray(TextBoxGammaKey.Text);
            string result = "";

            foreach (var a in bitArray)
            {
                result += Convert.ToInt32(a);
            }
            TextBoxGammaKeyBit.Text = result;
        }

        private void TextBoxGammaKeyBit_KeyDown(object sender, TextChangedEventArgs e)
        {
            if (!IsLoaded)
                return;
            TextBoxGammaKey.Text = GammaXOR.BitArrayToString(new BitArray(TextBoxGammaKeyBit.Text.Select(c => c == '1').ToArray()));
        }

        private void TextBoxOutput_KeyDown(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBoxOutputBit_KeyDown(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var gammaXor = new GammaXOR();
                gammaXor.InputText = TextBoxInput.Text;
                gammaXor.GammaKey = new BitArray(TextBoxGammaKeyBit.Text.Select(c => c == '1').ToArray());
                TextBoxOutput.Text = gammaXor.OutputText;

                string result = "";
                foreach (var a in gammaXor.BitOutputText)
                {
                    result += Convert.ToInt32(a);
                }
                TextBoxOutputBit.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!");
            }
        }
    }
}
