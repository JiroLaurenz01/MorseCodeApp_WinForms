using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MORSE_CODE_APP
{
    public partial class MorseCodeForm : Form
    {
        public MorseCodeForm()
        {
            InitializeComponent();
        }

        #region FUNCTION TO CONVERT THE LETTER INTO MORSE CODE.

        private async void toCodeBtn_Click(object sender, EventArgs e)
        {
            // Morse code representations of letters and symbols
            char[] morseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890?!.,;:+-/= ".ToCharArray();
            string[] morseCodes = { ".- ", "-... ", "-.-. ", "-.. ", ". ", "..-. ", "--. ", ".... ", ".. ", ".--- ", "-.- ", ".-.. ", "-- ", "-. ", "--- ", ".--. ", "--.- ", ".-. ", "... ", "- ", "..- ", "...- ", ".-- ", "-..- ", "-.-- ", "--.. ", ".---- ", "..--- ", "...-- ", "....- ", "..... ", "-.... ", "--... ", "---.. ", "----. ", "----- ", "..--.. ", "-.-.-- ", ".-.-.- ", "--..-- ", "-.-.-. ", "---... ", ".-.-. ", "-....- ", "-..-. ", "-...- ", "| " };

            if (!String.IsNullOrEmpty(inputTextBox.Text))
            {
                string letters = inputTextBox.Text.ToUpper();

                // Show the loading screen form on the UI thread
                LoadingScreenForm loadingScreen = new();
                Invoke(new Action(() => loadingScreen.ShowDialog()));

                // Translate each letter to Morse code
                string resultHolder = await Task.Run(() =>
                {
                    StringBuilder result = new StringBuilder();

                    for (int i = 0; i < letters.Length; i++)
                    {
                        try
                        {
                            // Translates the letter or symbol (letters[i]) to its corresponding Morse code element.
                            result.Append(morseCodes[Array.IndexOf(morseLetters, letters[i])]);
                        }
                        catch
                        {
                            result.Append('#'); // If letter is invalid, display a "#"
                        }
                    }

                    return result.ToString();
                });

                // Update the UI with the result
                this.Invoke(new Action(() => inputTextBox.Text = resultHolder));
            }
            else
                MessageBox.Show("Please, input the text first");
        }

        #endregion 

        #region FUNCTION TO CONVERT THE MORSE CODE INTO LETTER.

        private void toLetterBtn_Click(object sender, EventArgs e)
        {
            // Morse code representations of letters and symbols
            char[] morseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890?!.,;:+-/= ".ToCharArray();
            string[] morseCodes = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.", "-----", "..--..", "-.-.--", ".-.-.-", "--..--", "-.-.-.", "---...", ".-.-.", "-....-", "-..-.", "-...-", "|" };

            if (!String.IsNullOrEmpty(inputTextBox.Text))
            {
            string morse = inputTextBox.Text;
            inputTextBox.Text = string.Empty;
            morse = morse.TrimEnd(' ');

            string[] morseArray = morse.Split(' ');

            // Translate each Morse code element to a letter or symbol
            for (int i = 0; i < morseArray.Length; i++)
                try
                {
                    // Translates Morse code element (morseArray[i]) to its corresponding letter or symbol.
                    inputTextBox.Text += morseLetters[Array.IndexOf(morseCodes, morseArray[i])];
                }
                catch
                {
                    inputTextBox.Text += "#"; // If Morse code is invalid, display a "#".
                }
            }
            else
                MessageBox.Show("Please, input the text first");
        }

        #endregion

        #region FUNCTIONS FOR CLEAR, COPY, AND PASTE BUTTONS.

        private void cleatBtn_Click(object sender, EventArgs e) => inputTextBox.Clear();
        private void pasteBtn_Click(object sender, EventArgs e) => inputTextBox.Text = Clipboard.GetText();
        private void copyBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(inputTextBox.Text))
                Clipboard.SetText(inputTextBox.Text);
            else
                MessageBox.Show("Please, input the text first");
        }

        #endregion
    }
}
