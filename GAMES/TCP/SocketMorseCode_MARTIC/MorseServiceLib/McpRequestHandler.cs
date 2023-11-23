using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseServiceLib
{
   public class McpRequestHandler
    {
        #region Fields and Properties
        Dictionary<string, string> text2Morse;
        private string request;
        Dictionary<string, string> morse2Text;
        #endregion

        #region Methods
        public string Translate2MC()
        {
            string response = " ";
            
            char[] requestArray = request.ToUpper().ToCharArray();

            for (int i = 0; i < requestArray.Length; i++)
            {
                if (requestArray[i] < 'A' && requestArray[i] > 'Z'  || requestArray[i] < '0' && requestArray[i] > '9') 
                {
                    return "invalid request";
                }

            }

            for (int i = 0; i < requestArray.Length; i++)
            {
                if (requestArray[i] >= 'A' && requestArray[i] <= 'Z' || requestArray[i] >= '0' && requestArray[i] <= '9')
                {
                    response += text2Morse[requestArray[i].ToString().ToUpper()] + " ";
                }
            }
            return response.Trim('\0');
        }

        public string Translate2Latin()
        {
            string response = "";
            string[] requestReverse = request.Split(' ');
            string requestPart = "";


            for (int i = 0; i < requestReverse.Length; i++)
            {
                requestPart = requestReverse[i];
                if (morse2Text.ContainsKey(requestPart)==false)
                {
                    return "invalid request";
                }
            }


            for (int i = 0; i < requestReverse.Length; i++)
            {
                requestPart = requestReverse[i];
                
                response += morse2Text[requestPart] + " ";
            }
            return response.Trim('\0');
        }

        #endregion

        #region Constructors
        public McpRequestHandler(string request)
        {
            this.request = request;
            text2Morse = new Dictionary<string, string>();
            morse2Text = new Dictionary<string, string>();
            morse2Text.Add(".-","A");
            morse2Text.Add("-...","B");
            morse2Text.Add( "-.-.","C");
            morse2Text.Add("-..","D");
            morse2Text.Add( ".","E");
            morse2Text.Add( "..-.","F");
            morse2Text.Add("--.","G");
            morse2Text.Add( "....","H");
            morse2Text.Add( "..","I");
            morse2Text.Add(".---","J");
            morse2Text.Add("-.-","K");
            morse2Text.Add(".-..","L");
            morse2Text.Add( "--","M");
            morse2Text.Add("-.","N");
            morse2Text.Add("---","O");
            morse2Text.Add(".--.","P");
            morse2Text.Add("--.-","Q");
            morse2Text.Add(".-.","R");
            morse2Text.Add("...", "S");
            morse2Text.Add("-","T");
            morse2Text.Add( "..-","U");
            morse2Text.Add( "...-","V");
            morse2Text.Add(".--","W");
            morse2Text.Add("-..-","X");
            morse2Text.Add( "-.--","Y");
            morse2Text.Add( "--..","Z");

            morse2Text.Add(".----","1");
            morse2Text.Add( "..---","2");
            morse2Text.Add( "...--","3");
            morse2Text.Add("....-","4");
            morse2Text.Add(".....","5");
            morse2Text.Add("-....","6");
            morse2Text.Add("--...","7");
            morse2Text.Add("---..","8");
            morse2Text.Add("----.","9");
            morse2Text.Add("-----","0");


            text2Morse.Add("A", ".-");
            text2Morse.Add("B", "-...");
            text2Morse.Add("C", "-.-.");
            text2Morse.Add("D", "-..");
            text2Morse.Add("E", ".");
            text2Morse.Add("F", "..-.");
            text2Morse.Add("G", "--.");
            text2Morse.Add("H", "....");
            text2Morse.Add("I", "..");
            text2Morse.Add("J", ".---");
            text2Morse.Add("K", "-.-");
            text2Morse.Add("L", ".-..");
            text2Morse.Add("M", "--");
            text2Morse.Add("N", "-.");
            text2Morse.Add("O", "---");
            text2Morse.Add("P", ".--.");
            text2Morse.Add("Q", "--.-");
            text2Morse.Add("R", ".-.");
            text2Morse.Add("S", "...");
            text2Morse.Add("T", "-");
            text2Morse.Add("U", "..-");
            text2Morse.Add("V", "...-");
            text2Morse.Add("W", ".--");
            text2Morse.Add("X", "-..-");
            text2Morse.Add("Y", "-.--");
            text2Morse.Add("Z", "--..");

            text2Morse.Add("1", ".----");
            text2Morse.Add("2", "..---");
            text2Morse.Add("3", "...--");
            text2Morse.Add("4", "....-");
            text2Morse.Add("5", ".....");
            text2Morse.Add("6", "-....");
            text2Morse.Add("7", "--...");
            text2Morse.Add("8", "---..");
            text2Morse.Add("9", "----.");
            text2Morse.Add("0", "-----");
        }
        #endregion
    }
}
