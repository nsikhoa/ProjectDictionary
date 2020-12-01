namespace ProjectDictionary
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSpeakEnglish = new System.Windows.Forms.Button();
            this.cbWord = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtExplaination = new System.Windows.Forms.TextBox();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSpeakEnglish);
            this.panel1.Controls.Add(this.cbWord);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 426);
            this.panel1.TabIndex = 0;
            // 
            // btnSpeakEnglish
            // 
            this.btnSpeakEnglish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSpeakEnglish.BackgroundImage")));
            this.btnSpeakEnglish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpeakEnglish.Location = new System.Drawing.Point(224, 3);
            this.btnSpeakEnglish.Name = "btnSpeakEnglish";
            this.btnSpeakEnglish.Size = new System.Drawing.Size(35, 34);
            this.btnSpeakEnglish.TabIndex = 4;
            this.btnSpeakEnglish.UseVisualStyleBackColor = true;
            this.btnSpeakEnglish.Click += new System.EventHandler(this.btnSpeakEnglish_Click);
            // 
            // cbWord
            // 
            this.cbWord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbWord.FormattingEnabled = true;
            this.cbWord.Location = new System.Drawing.Point(3, 3);
            this.cbWord.Name = "cbWord";
            this.cbWord.Size = new System.Drawing.Size(215, 410);
            this.cbWord.TabIndex = 0;
            this.cbWord.SelectedIndexChanged += new System.EventHandler(this.cbWord_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtExplaination);
            this.panel2.Controls.Add(this.txtMeaning);
            this.panel2.Location = new System.Drawing.Point(301, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 426);
            this.panel2.TabIndex = 1;
            // 
            // txtExplaination
            // 
            this.txtExplaination.Location = new System.Drawing.Point(12, 29);
            this.txtExplaination.Multiline = true;
            this.txtExplaination.Name = "txtExplaination";
            this.txtExplaination.Size = new System.Drawing.Size(429, 384);
            this.txtExplaination.TabIndex = 1;
            // 
            // txtMeaning
            // 
            this.txtMeaning.Location = new System.Drawing.Point(12, 3);
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(429, 20);
            this.txtMeaning.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 452);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dictionary English - Vietnamese";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSpeakEnglish;
        private System.Windows.Forms.ComboBox cbWord;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtExplaination;
        private System.Windows.Forms.TextBox txtMeaning;
    }
}

