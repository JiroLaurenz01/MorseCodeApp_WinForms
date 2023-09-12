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

        #region FUNCTION TO CONVERT THE LETTER/S TO MORSE CODE/S.

        private void toCodeBtn_Click(object sender, EventArgs e)
        {
            // Morse code representations of letters and symbols
            char[] morseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890?!.,;:+-/= ".ToCharArray();
            string[] morseCodes = { ".- ", "-... ", "-.-. ", "-.. ", ". ", "..-. ", "--. ", ".... ", ".. ", ".--- ", "-.- ", ".-.. ", "-- ", "-. ", "--- ", ".--. ", "--.- ", ".-. ", "... ", "- ", "..- ", "...- ", ".-- ", "-..- ", "-.-- ", "--.. ", ".---- ", "..--- ", "...-- ", "....- ", "..... ", "-.... ", "--... ", "---.. ", "----. ", "----- ", "..--.. ", "-.-.-- ", ".-.-.- ", "--..-- ", "-.-.-. ", "---... ", ".-.-. ", "-....- ", "-..-. ", "-...- ", "| " };

            string letters = inputTextBox.Text.ToUpper();
            inputTextBox.Text = string.Empty;

            // Translate each letter to Morse code
            for (int i = 0; i < letters.Length; i++)
                try
                {
                    // Translates the letter or symbol (letters[i]) to its corresponding Morse code element.
                    inputTextBox.Text += morseCodes[Array.IndexOf(morseLetters, letters[i])];
                }
                catch
                {
                    inputTextBox.Text += "#"; // If letter is invalid, display a "#"
                }
        }

        #endregion 

        private void toLetterBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
