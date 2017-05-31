namespace SeleniumTestTask
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
            this.button1 = new System.Windows.Forms.Button();
            this._radioChrome = new System.Windows.Forms.RadioButton();
            this._radioMozilla = new System.Windows.Forms.RadioButton();
            this._logBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go try";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _radioChrome
            // 
            this._radioChrome.AutoSize = true;
            this._radioChrome.Location = new System.Drawing.Point(12, 26);
            this._radioChrome.Name = "_radioChrome";
            this._radioChrome.Size = new System.Drawing.Size(61, 17);
            this._radioChrome.TabIndex = 1;
            this._radioChrome.TabStop = true;
            this._radioChrome.Text = "Chrome";
            this._radioChrome.UseVisualStyleBackColor = true;
            this._radioChrome.CheckedChanged += new System.EventHandler(this._radioChrome_CheckedChanged);
            this._radioChrome.Click += new System.EventHandler(this._radioChrome_Click);
            // 
            // _radioMozilla
            // 
            this._radioMozilla.AutoSize = true;
            this._radioMozilla.Location = new System.Drawing.Point(12, 70);
            this._radioMozilla.Name = "_radioMozilla";
            this._radioMozilla.Size = new System.Drawing.Size(57, 17);
            this._radioMozilla.TabIndex = 2;
            this._radioMozilla.TabStop = true;
            this._radioMozilla.Text = "Mozilla";
            this._radioMozilla.UseVisualStyleBackColor = true;
            this._radioMozilla.CheckedChanged += new System.EventHandler(this._radioMozilla_CheckedChanged);
            this._radioMozilla.Click += new System.EventHandler(this._radioMozilla_Click);
            // 
            // _logBox
            // 
            this._logBox.Location = new System.Drawing.Point(12, 156);
            this._logBox.Multiline = true;
            this._logBox.Name = "_logBox";
            this._logBox.Size = new System.Drawing.Size(578, 126);
            this._logBox.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(515, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Bye!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(443, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Close Browser";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 334);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this._logBox);
            this.Controls.Add(this._radioMozilla);
            this.Controls.Add(this._radioChrome);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Selenium Test Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton _radioChrome;
        private System.Windows.Forms.RadioButton _radioMozilla;
        private System.Windows.Forms.TextBox _logBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

