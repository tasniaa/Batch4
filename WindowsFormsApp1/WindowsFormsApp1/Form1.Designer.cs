namespace WindowsFormsApp1
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
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.showRichTextBox = new System.Windows.Forms.RichTextBox();
            this.uniqueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(287, 66);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(438, 64);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // showRichTextBox
            // 
            this.showRichTextBox.Location = new System.Drawing.Point(287, 108);
            this.showRichTextBox.Name = "showRichTextBox";
            this.showRichTextBox.Size = new System.Drawing.Size(226, 279);
            this.showRichTextBox.TabIndex = 4;
            this.showRichTextBox.Text = "";
            // 
            // uniqueButton
            // 
            this.uniqueButton.Location = new System.Drawing.Point(578, 185);
            this.uniqueButton.Name = "uniqueButton";
            this.uniqueButton.Size = new System.Drawing.Size(75, 23);
            this.uniqueButton.TabIndex = 12;
            this.uniqueButton.Text = "Unique";
            this.uniqueButton.UseVisualStyleBackColor = true;
            this.uniqueButton.Click += new System.EventHandler(this.uniqueButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uniqueButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.showRichTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RichTextBox showRichTextBox;
        private System.Windows.Forms.Button uniqueButton;
    }
}

