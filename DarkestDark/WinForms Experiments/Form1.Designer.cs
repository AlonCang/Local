namespace WinForms_Experiments
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
            this.TheTextBox = new System.Windows.Forms.TextBox();
            this.TheLabel = new System.Windows.Forms.Label();
            this.TheButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TheTextBox
            // 
            this.TheTextBox.Location = new System.Drawing.Point(196, 131);
            this.TheTextBox.Name = "TheTextBox";
            this.TheTextBox.Size = new System.Drawing.Size(168, 20);
            this.TheTextBox.TabIndex = 0;
            // 
            // TheLabel
            // 
            this.TheLabel.AutoSize = true;
            this.TheLabel.Location = new System.Drawing.Point(299, 235);
            this.TheLabel.Name = "TheLabel";
            this.TheLabel.Size = new System.Drawing.Size(35, 13);
            this.TheLabel.TabIndex = 1;
            this.TheLabel.Text = "label1";
            // 
            // TheButton
            // 
            this.TheButton.Location = new System.Drawing.Point(502, 236);
            this.TheButton.Name = "TheButton";
            this.TheButton.Size = new System.Drawing.Size(123, 47);
            this.TheButton.TabIndex = 2;
            this.TheButton.Text = "Click me";
            this.TheButton.UseVisualStyleBackColor = true;
            this.TheButton.Click += new System.EventHandler(this.TheButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 584);
            this.Controls.Add(this.TheButton);
            this.Controls.Add(this.TheLabel);
            this.Controls.Add(this.TheTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TheTextBox;
        private System.Windows.Forms.Label TheLabel;
        private System.Windows.Forms.Button TheButton;
    }
}

