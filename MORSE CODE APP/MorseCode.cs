using Microsoft.VisualBasic.Devices;
using System.Globalization;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace MORSE_CODE_APP
{
    public partial class MorseCode : Form
    {
        public MorseCode()
        {
            InitializeComponent();
        }

        // Event handler for the "Translate to Words" button click
        private void wordsBtn_Click(object sender, EventArgs e)
        {
            // Morse code representations of letters and symbols
            char[] morseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890?!.,;:+-/= ".ToCharArray();
            string[] morseCodes = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.", "-----", "..--..", "-.-.--", ".-.-.-", "--..--", "-.-.-.", "---...", ".-.-.", "-....-", "-..-.", "-...-", "|" };

            translatedTBox.Text = string.Empty;
            string morse = messageTBox.Text;
            morse = morse.TrimEnd(' ');

            string[] morseArray = morse.Split(' ');

            // Translate each Morse code element to a letter or symbol
            for (int i = 0; i < morseArray.Length; i++)
                try
                {
                    // Translates Morse code element (morseArray[i]) to its corresponding letter or symbol.
                    translatedTBox.Text += morseLetters[Array.IndexOf(morseCodes, morseArray[i])];
                }
                catch
                {
                    translatedTBox.Text += "#"; // If Morse code is invalid, display a "#".
                }
        }

        // Event handler for the "Translate to Morse Code" button click
        private void morseCodeBtn_Click(object sender, EventArgs e)
        {
            // Morse code representations of letters and symbols
            char[] morseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890?!.,;:+-/= ".ToCharArray();
            string[] morseCodes = { ".- ", "-... ", "-.-. ", "-.. ", ". ", "..-. ", "--. ", ".... ", ".. ", ".--- ", "-.- ", ".-.. ", "-- ", "-. ", "--- ", ".--. ", "--.- ", ".-. ", "... ", "- ", "..- ", "...- ", ".-- ", "-..- ", "-.-- ", "--.. ", ".---- ", "..--- ", "...-- ", "....- ", "..... ", "-.... ", "--... ", "---.. ", "----. ", "----- ", "..--.. ", "-.-.-- ", ".-.-.- ", "--..-- ", "-.-.-. ", "---... ", ".-.-. ", "-....- ", "-..-. ", "-...- ", "| " };

            translatedTBox.Text = string.Empty;
            string letters = messageTBox.Text.ToUpper();

            // Translate each letter to Morse code
            for (int i = 0; i < letters.Length; i++)
                try
                {
                    // Translates the letter or symbol (letters[i]) to its corresponding Morse code element.
                    translatedTBox.Text += morseCodes[Array.IndexOf(morseLetters, letters[i])];
                }
                catch
                {
                    translatedTBox.Text += "#"; // If letter is invalid, display a "#"
                }
        }

        // Event handler for the "Copy" button click
        private void copyBtn_Click(object sender, EventArgs e) => Clipboard.SetText(translatedTBox.Text);

        // Event handler for the "Paste" button click
        private void pasteBtn_Click(object sender, EventArgs e) => messageTBox.Text = Clipboard.GetText();

        // Event handler for the "Clear" button click
        private void clearBtn_Click(object sender, EventArgs e) => messageTBox.Text = string.Empty;

        // Event handler for the "Exit" button click
        private void exitBtn_Click(object sender, EventArgs e) => Application.Exit();
    }
}