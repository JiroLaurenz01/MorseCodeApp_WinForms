namespace MORSE_CODE_APP
{
    partial class MorseCode
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MorseCode));
            this.messageTBox = new System.Windows.Forms.TextBox();
            this.translatedTBox = new System.Windows.Forms.TextBox();
            this.wordsBtn = new System.Windows.Forms.Button();
            this.morseCodeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.copyBtn = new System.Windows.Forms.Button();
            this.pasteBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // messageTBox
            // 
            this.messageTBox.BackColor = System.Drawing.Color.LightCoral;
            this.messageTBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.messageTBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageTBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.messageTBox.Location = new System.Drawing.Point(10, 35);
            this.messageTBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.messageTBox.Name = "messageTBox";
            this.messageTBox.Size = new System.Drawing.Size(427, 30);
            this.messageTBox.TabIndex = 0;
            this.messageTBox.Text = "INPUT YOUR MESSAGE HERE";
            this.messageTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // translatedTBox
            // 
            this.translatedTBox.BackColor = System.Drawing.Color.LightCoral;
            this.translatedTBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.translatedTBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.translatedTBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.translatedTBox.Location = new System.Drawing.Point(10, 135);
            this.translatedTBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.translatedTBox.Name = "translatedTBox";
            this.translatedTBox.Size = new System.Drawing.Size(457, 30);
            this.translatedTBox.TabIndex = 1;
            this.translatedTBox.Text = "TRANSLATED INTO";
            this.translatedTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wordsBtn
            // 
            this.wordsBtn.BackColor = System.Drawing.Color.LightCoral;
            this.wordsBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wordsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wordsBtn.Location = new System.Drawing.Point(119, 86);
            this.wordsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wordsBtn.Name = "wordsBtn";
            this.wordsBtn.Size = new System.Drawing.Size(92, 30);
            this.wordsBtn.TabIndex = 2;
            this.wordsBtn.Text = "WORDS";
            this.wordsBtn.UseVisualStyleBackColor = false;
            this.wordsBtn.Click += new System.EventHandler(this.wordsBtn_Click);
            // 
            // morseCodeBtn
            // 
            this.morseCodeBtn.BackColor = System.Drawing.Color.LightCoral;
            this.morseCodeBtn.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.morseCodeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.morseCodeBtn.Location = new System.Drawing.Point(270, 86);
            this.morseCodeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.morseCodeBtn.Name = "morseCodeBtn";
            this.morseCodeBtn.Size = new System.Drawing.Size(92, 30);
            this.morseCodeBtn.TabIndex = 3;
            this.morseCodeBtn.Text = "MORSE CODE";
            this.morseCodeBtn.UseVisualStyleBackColor = false;
            this.morseCodeBtn.Click += new System.EventHandler(this.morseCodeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(154, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "TO";
            // 
            // copyBtn
            // 
            this.copyBtn.BackColor = System.Drawing.Color.LightCoral;
            this.copyBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.copyBtn.Location = new System.Drawing.Point(201, 166);
            this.copyBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(83, 24);
            this.copyBtn.TabIndex = 6;
            this.copyBtn.Text = "COPY";
            this.copyBtn.UseVisualStyleBackColor = false;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // pasteBtn
            // 
            this.pasteBtn.BackColor = System.Drawing.Color.LightCoral;
            this.pasteBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pasteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pasteBtn.Location = new System.Drawing.Point(201, 7);
            this.pasteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.Size = new System.Drawing.Size(83, 24);
            this.pasteBtn.TabIndex = 7;
            this.pasteBtn.Text = "PASTE";
            this.pasteBtn.UseVisualStyleBackColor = false;
            this.pasteBtn.Click += new System.EventHandler(this.pasteBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(303, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "TO";
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.LightCoral;
            this.clearBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearBtn.ForeColor = System.Drawing.Color.Black;
            this.clearBtn.Location = new System.Drawing.Point(434, 35);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(33, 27);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "❌";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.LightCoral;
            this.exitBtn.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitBtn.Location = new System.Drawing.Point(10, 7);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(83, 24);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MorseCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(477, 196);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pasteBtn);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.morseCodeBtn);
            this.Controls.Add(this.wordsBtn);
            this.Controls.Add(this.translatedTBox);
            this.Controls.Add(this.messageTBox);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(493, 235);
            this.MinimumSize = new System.Drawing.Size(493, 235);
            this.Name = "MorseCode";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MorseCode Translator";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox messageTBox;
        private TextBox translatedTBox;
        private Button wordsBtn;
        private Button morseCodeBtn;
        private Label label1;
        private Button copyBtn;
        private Button pasteBtn;
        private Label label2;
        private Button clearBtn;
        private Button exitBtn;
        private ErrorProvider errorProvider1;
    }
}