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
                // Get the input text from the TextBox and convert it to uppercase
                string letters = inputTextBox.Text.ToUpper();

                // Show the loading screen form on the UI thread
                LoadingScreenForm loadingScreen = new();
                Invoke(new Action(() => loadingScreen.ShowDialog()));

                // Translate each letter to Morse code
                string resultHolder = await Task.Run(() =>
                {
                    // Create a StringBuilder to build the Morse code result
                    StringBuilder result = new();

                    // Iterate through each character in the input text
                    for (int i = 0; i < letters.Length; i++)
                    {
                        try
                        {
                            // Translates the letter or symbol (letters[i]) to its corresponding Morse code element.
                            result.Append(morseCodes[Array.IndexOf(morseLetters, letters[i])]);
                        }
                        catch
                        {
                            // If the letter is invalid, display a "#" in the result
                            result.Append('#');
                        }
                    }

                    // Convert the StringBuilder result to a string and return it
                    return result.ToString();
                });

                // Update the UI with the Morse code result
                this.Invoke(new Action(() => inputTextBox.Text = resultHolder));
                Alert("Successfully Convert", AlertForm.Type.Success);
            }
            else // Display a message box if the input text is empty
                Alert("Input field is empty", AlertForm.Type.Error);
        }

        #endregion 

        #region FUNCTION TO CONVERT THE MORSE CODE INTO LETTER.

        private async void toLetterBtn_Click(object sender, EventArgs e)
        {
            // Morse code representations of letters and symbols
            char[] morseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890?!.,;:+-/= ".ToCharArray();
            string[] morseCodes = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.", "-----", "..--..", "-.-.--", ".-.-.-", "--..--", "-.-.-.", "---...", ".-.-.", "-....-", "-..-.", "-...-", "|" };

            if (!String.IsNullOrEmpty(inputTextBox.Text))
            {
                // Get Morse code from the input TextBox and Trim trailing spaces
                string morse = inputTextBox.Text;
                morse = morse.TrimEnd(' ');

                // Split the Morse code by spaces to get each element
                string[] morseArray = morse.Split(' ');

                // Show the loading screen form on the UI thread
                LoadingScreenForm loadingScreen = new();
                Invoke(new Action(() => loadingScreen.ShowDialog()));

                // Translate each Morse code element back to its corresponding letter or symbol
                string resultHolder = await Task.Run(() =>
                {
                    StringBuilder result = new();

                    for (int i = 0; i < morseArray.Length; i++)
                    {
                        try
                        {
                            // Translate the Morse code element (morseArray[i]) to its corresponding letter or symbol.
                            result.Append(morseLetters[Array.IndexOf(morseCodes, morseArray[i])]);
                        }
                        catch
                        {
                            result.Append('#'); // If the letter is not recognized, display "#"
                        }
                    }

                    return result.ToString();
                });

                // Update the UI with the result
                this.Invoke(new Action(() => inputTextBox.Text = resultHolder));
                Alert("Successfully Convert", AlertForm.Type.Success);
            }
            else
                Alert("Input field is empty", AlertForm.Type.Error);
        }

        #endregion

        #region FUNCTIONS FOR CLEAR, COPY, AND PASTE BUTTONS.

        private void cleatBtn_Click(object sender, EventArgs e) => inputTextBox.Clear();
        private void pasteBtn_Click(object sender, EventArgs e) 
        {
            inputTextBox.Text += Clipboard.GetText();
            Alert("Paste from Clipboard", AlertForm.Type.Info);
        } 
        private void copyBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(inputTextBox.Text))
            {
                Clipboard.SetText(inputTextBox.Text);
                Alert("Copy to Clipboard", AlertForm.Type.Info);
            }
            else
                Alert("Input field is empty", AlertForm.Type.Error);
        }

        #endregion

        #region FUNCTION TO DISPLAY ALERT

        // This method is used to display an alert message using a custom AlertForm.
        public void Alert(string msg, AlertForm.Type type)
        {
            AlertForm alertForm = new AlertForm();

            // Call the ShowAlert method of the AlertForm instance, passing the message and alert type as parameters.
            alertForm.ShowAlert(msg, type);
        }

        #endregion

        #region FUNCTIONS FOR DRAGGING FUNCTIONALITY OF FORM

        private void containerControls_MouseMove(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button is held down (mouse is being dragged).
            if (e.Button == MouseButtons.Left)
            {
                // Calculate the new position of the form based on the mouse movement.
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        Point lastPoint;

        private void containerControls_MouseDown(object sender, MouseEventArgs e) => lastPoint = new Point(e.X, e.Y);

        #endregion
    }
}
