namespace Processes {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.bStartEx1 = new System.Windows.Forms.Button();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bKill = new System.Windows.Forms.Button();
            this.cbOperators = new System.Windows.Forms.ComboBox();
            this.nFirst = new System.Windows.Forms.NumericUpDown();
            this.nSecond = new System.Windows.Forms.NumericUpDown();
            this.bCalc = new System.Windows.Forms.Button();
            this.bWordsCounter = new System.Windows.Forms.Button();
            this.lWord = new System.Windows.Forms.Label();
            this.tbWord = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // bStartEx1
            // 
            this.bStartEx1.Location = new System.Drawing.Point(12, 65);
            this.bStartEx1.Name = "bStartEx1";
            this.bStartEx1.Size = new System.Drawing.Size(490, 23);
            this.bStartEx1.TabIndex = 0;
            this.bStartEx1.Text = "Start";
            this.bStartEx1.UseVisualStyleBackColor = true;
            this.bStartEx1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(12, 12);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(776, 20);
            this.tbFileName.TabIndex = 1;
            // 
            // bKill
            // 
            this.bKill.Location = new System.Drawing.Point(608, 65);
            this.bKill.Name = "bKill";
            this.bKill.Size = new System.Drawing.Size(180, 23);
            this.bKill.TabIndex = 0;
            this.bKill.Text = "Kill";
            this.bKill.UseVisualStyleBackColor = true;
            this.bKill.Click += new System.EventHandler(this.bKill_Click);
            // 
            // cbOperators
            // 
            this.cbOperators.FormattingEnabled = true;
            this.cbOperators.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.cbOperators.Location = new System.Drawing.Point(508, 38);
            this.cbOperators.Name = "cbOperators";
            this.cbOperators.Size = new System.Drawing.Size(280, 21);
            this.cbOperators.TabIndex = 2;
            // 
            // nFirst
            // 
            this.nFirst.Location = new System.Drawing.Point(12, 39);
            this.nFirst.Name = "nFirst";
            this.nFirst.Size = new System.Drawing.Size(242, 20);
            this.nFirst.TabIndex = 3;
            // 
            // nSecond
            // 
            this.nSecond.Location = new System.Drawing.Point(260, 39);
            this.nSecond.Name = "nSecond";
            this.nSecond.Size = new System.Drawing.Size(242, 20);
            this.nSecond.TabIndex = 3;
            // 
            // bCalc
            // 
            this.bCalc.Location = new System.Drawing.Point(508, 65);
            this.bCalc.Name = "bCalc";
            this.bCalc.Size = new System.Drawing.Size(94, 23);
            this.bCalc.TabIndex = 0;
            this.bCalc.Text = "Calculate";
            this.bCalc.UseVisualStyleBackColor = true;
            this.bCalc.Click += new System.EventHandler(this.bCalc_Click);
            // 
            // bWordsCounter
            // 
            this.bWordsCounter.Location = new System.Drawing.Point(664, 95);
            this.bWordsCounter.Name = "bWordsCounter";
            this.bWordsCounter.Size = new System.Drawing.Size(124, 23);
            this.bWordsCounter.TabIndex = 0;
            this.bWordsCounter.Text = "Count words";
            this.bWordsCounter.UseVisualStyleBackColor = true;
            this.bWordsCounter.Click += new System.EventHandler(this.bWordsCounter_Click);
            // 
            // lWord
            // 
            this.lWord.AutoSize = true;
            this.lWord.Location = new System.Drawing.Point(13, 100);
            this.lWord.Name = "lWord";
            this.lWord.Size = new System.Drawing.Size(36, 13);
            this.lWord.TabIndex = 4;
            this.lWord.Text = "Word:";
            // 
            // tbWord
            // 
            this.tbWord.Location = new System.Drawing.Point(52, 97);
            this.tbWord.Name = "tbWord";
            this.tbWord.Size = new System.Drawing.Size(606, 20);
            this.tbWord.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 127);
            this.Controls.Add(this.tbWord);
            this.Controls.Add(this.lWord);
            this.Controls.Add(this.nSecond);
            this.Controls.Add(this.nFirst);
            this.Controls.Add(this.cbOperators);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.bWordsCounter);
            this.Controls.Add(this.bCalc);
            this.Controls.Add(this.bKill);
            this.Controls.Add(this.bStartEx1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bStartEx1;
        private System.Windows.Forms.TextBox tbFileName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bKill;
        private System.Windows.Forms.ComboBox cbOperators;
        private System.Windows.Forms.NumericUpDown nFirst;
        private System.Windows.Forms.NumericUpDown nSecond;
        private System.Windows.Forms.Button bCalc;
        private System.Windows.Forms.Button bWordsCounter;
        private System.Windows.Forms.Label lWord;
        private System.Windows.Forms.TextBox tbWord;
    }
}

