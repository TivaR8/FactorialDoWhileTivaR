namespace FactorialDoWhileTivaR
{
    partial class frmFactorialWhile
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
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lstFactorial = new System.Windows.Forms.ListBox();
            this.btnGetAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(180, 196);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(64, 13);
            this.lblAnswer.TabIndex = 0;
            this.lblAnswer.Text = "The Answer";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(156, 52);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 1;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(101, 36);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(96, 13);
            this.lblInstruction.TabIndex = 2;
            this.lblInstruction.Text = "Enter your number:";
            // 
            // lstFactorial
            // 
            this.lstFactorial.FormattingEnabled = true;
            this.lstFactorial.Location = new System.Drawing.Point(156, 78);
            this.lstFactorial.Name = "lstFactorial";
            this.lstFactorial.Size = new System.Drawing.Size(120, 95);
            this.lstFactorial.TabIndex = 3;
            // 
            // btnGetAnswer
            // 
            this.btnGetAnswer.Location = new System.Drawing.Point(175, 220);
            this.btnGetAnswer.Name = "btnGetAnswer";
            this.btnGetAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnGetAnswer.TabIndex = 4;
            this.btnGetAnswer.Text = "Get Answer";
            this.btnGetAnswer.UseVisualStyleBackColor = true;
            this.btnGetAnswer.Click += new System.EventHandler(this.btnGetAnswer_Click);
            // 
            // frmFactorialWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 275);
            this.Controls.Add(this.btnGetAnswer);
            this.Controls.Add(this.lstFactorial);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblAnswer);
            this.Name = "frmFactorialWhile";
            this.Text = "Factorial Do While By Tiva Rait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.ListBox lstFactorial;
        private System.Windows.Forms.Button btnGetAnswer;
    }
}

