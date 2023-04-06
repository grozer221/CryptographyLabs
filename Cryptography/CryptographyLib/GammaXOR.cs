using System.Collections;
using System.Text;

namespace CryptographyLib
{

    public class GammaXOR
    {
        private string inputText = "";
        public string InputText
        {
            get { return inputText; }
            set
            {
                inputText = value;  
            }
        }

        public BitArray BitInputText { get => StringToBitArray(inputText); }

        public string OutputText
        {
            get
            {
                return BitArrayToString(BitOutputText);
            }
        }

        public BitArray BitOutputText
        {
            get
            {
                return Encode();
            }
        }

        private BitArray gammaKey = new BitArray(0);
        public BitArray GammaKey
        {
            get { return GammaKey; }
            set
            {
                if (BitInputText.Length != value.Length)
                    throw new ArgumentException("Gamma key Length must be equal to input bit array!");
                gammaKey = value;
                
            }
        }

        private BitArray Encode()
        {
            return BitInputText.Xor(gammaKey);
        }

        public static BitArray StringToBitArray(string input) => new BitArray(Encoding.ASCII.GetBytes(input));

        public static string BitArrayToString(BitArray input)
        {
            byte[] strArr = new byte[input.Length / 8];

            ASCIIEncoding encoding = new ASCIIEncoding();

            for (int i = 0; i < input.Length / 8; i++)
            {
                for (int index = i * 8, m = 1; index < i * 8 + 8; index++, m *= 2)
                {
                    strArr[i] += input.Get(index) ? (byte)m : (byte)0;
                }
            }

            return encoding.GetString(strArr);
        }
    }
}