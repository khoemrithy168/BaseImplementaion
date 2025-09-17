
using Serilog;
namespace UtilsLayer
{
    public class GeneratorUtils
    {
        public string SecretCode { get; set; }
        private readonly int RandomLength = 10;
        private readonly int RandomOrder = 9;
        private readonly int CheckSumDigit = 2;
        public GeneratorUtils(string secretCode)
        {
            SecretCode = secretCode;
        }
        private string SimpleChecksum(string input)
        {
            int checksum = 0;

            foreach (char c in input)
            {
                checksum += (int)c;
            }

            checksum %= 100; // Limit to 2 digits

            string checksumStr = checksum.ToString().PadLeft(CheckSumDigit, '0');

            return checksumStr;
        }

        private static string GenerateTopUpNumber(int length)
        {
            string characters = "0123456789";
            var random = new Random();
            char[] topUpNumberArray = new char[length];

            for (int i = 0; i < length; i++)
            {
                int randomIndex = random.Next(characters.Length);
                topUpNumberArray[i] = characters[randomIndex];
            }

            string topUpNumber = new(topUpNumberArray);
            return topUpNumber;
        }

        private static string InsertWord(string originalString, string worDTOInsert, int index)
        {
            if (index > originalString.Length)
            {
                return originalString;
            }

            // Insert the word at the specified index
            string modifiedString = originalString.Insert(index, worDTOInsert);

            return modifiedString;
        }

        private string GenerateQR()
        {
            string r = GenerateTopUpNumber(RandomLength);
            var random = new Random();
            int randomIndex = random.Next(RandomOrder);
            string fin = InsertWord(r, SecretCode, randomIndex);
            string x = SimpleChecksum(fin);

            return $"{fin}{randomIndex}{x}";
        }

        private string GenerateQR(HashSet<string> arr)
        {
            var qrString = GenerateQR();
            if (!arr.Contains(qrString))
            {
                return GenerateQR(arr);
            }

            return qrString;
        }

        private static string GetBatchNumber()
        {
            DateTime currentTime = DateTime.Now;

            int lastThreeDigits = currentTime.Millisecond % 1000;
            return lastThreeDigits.ToString();
        }

        public static HashSet<string> Generate(int amount, string secretCode)
        {
            var arrLst = new HashSet<string>();
            for (int i = 0; i < amount; i++)
            {
                var result = new GeneratorUtils(secretCode);
                var qrString = result.GenerateQR();

                var innerI = 1;

                //collision
                while (!arrLst.Add(qrString))
                {
                    qrString = result.GenerateQR();
                    Log.Information(qrString);
                    ++innerI;
                    if (innerI > 100)
                    {
                        break;
                    }
                }
            }

            return arrLst;
        }
        public static string GenerateHashCode()
        {
            // Generate a unique identifier, such as a GUID
            Guid guid = Guid.NewGuid();
            string guidString = guid.ToString("N")[..10];

            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            for (int i = 0; i < 6; i++)
            {
                int index = random.Next(chars.Length);
                guidString += chars[index];
            }

            return guidString;
        }
    }


}