using System.Text;

namespace ProjectEditor.Utils
{
    public class ReadString
    {
        public byte[] FiersRead = new byte[0x100];
        public byte[] SecondRead = new byte[0x100];
        public string Descrption;
        public string Name;

        public void Decode()
        {
            int index = 0;
            index = 0;
            while (index < 0x100)
            {
                if (FiersRead[index + 2] == 0 && FiersRead[index] == 0 && FiersRead[index + 1] == 0)
                {
                    index++;
                    break;
                }

                index++;
            }

            string str = Encoding.GetEncoding("EUC-KR").GetString(FiersRead, 0, index);
            Name = str;
            str = "";
            index = 0;
            while (index < 0x100)
            {
                if (SecondRead[index + 2] == 0 && SecondRead[index] == 0 && SecondRead[index + 1] == 0)
                {
                    index++;
                    break;
                }

                index++;
            }

            str = Encoding.Unicode.GetString(SecondRead, 0, index);
            Descrption = str;
        }
    }
}
