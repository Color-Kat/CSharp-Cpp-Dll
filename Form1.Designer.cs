namespace ArraySum
{
    partial class Form1
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
            label1 = new Label();
            itemsCountInput = new TextBox();
            generateArrayButton = new Button();
            csharpSumButton = new Button();
            cppSum = new Button();
            xmmSum = new Button();
            label2 = new Label();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 21);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 0;
            label1.Text = "Items Count";
            // 
            // itemsCountInput
            // 
            itemsCountInput.Location = new Point(201, 27);
            itemsCountInput.Name = "itemsCountInput";
            itemsCountInput.Size = new Size(200, 39);
            itemsCountInput.TabIndex = 1;
            itemsCountInput.Text = "1000";
            // 
            // generateArrayButton
            // 
            generateArrayButton.Location = new Point(433, 25);
            generateArrayButton.Name = "generateArrayButton";
            generateArrayButton.Size = new Size(150, 46);
            generateArrayButton.TabIndex = 2;
            generateArrayButton.Text = "Generate Array";
            generateArrayButton.UseVisualStyleBackColor = true;
            generateArrayButton.Click += generateArrayButton_Click;
            // 
            // csharpSumButton
            // 
            csharpSumButton.Location = new Point(19, 135);
            csharpSumButton.Name = "csharpSumButton";
            csharpSumButton.Size = new Size(150, 46);
            csharpSumButton.TabIndex = 3;
            csharpSumButton.Text = "Use C#";
            csharpSumButton.UseVisualStyleBackColor = true;
            csharpSumButton.Click += csharpSumButton_Click;
            // 
            // cppSum
            // 
            cppSum.Location = new Point(19, 205);
            cppSum.Name = "cppSum";
            cppSum.Size = new Size(150, 46);
            cppSum.TabIndex = 4;
            cppSum.Text = "Use C++";
            cppSum.UseVisualStyleBackColor = true;
            cppSum.Click += cppSum_Click;
            // 
            // xmmSum
            // 
            xmmSum.Location = new Point(25, 273);
            xmmSum.Name = "xmmSum";
            xmmSum.Size = new Size(150, 46);
            xmmSum.TabIndex = 5;
            xmmSum.Text = "Use XMM";
            xmmSum.UseVisualStyleBackColor = true;
            xmmSum.Click += xmmSum_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 79);
            label2.Name = "label2";
            label2.Size = new Size(257, 32);
            label2.TabIndex = 6;
            label2.Text = "Summarize array items";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(433, 219);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(78, 32);
            resultLabel.TabIndex = 7;
            resultLabel.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(label2);
            Controls.Add(xmmSum);
            Controls.Add(cppSum);
            Controls.Add(csharpSumButton);
            Controls.Add(generateArrayButton);
            Controls.Add(itemsCountInput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox itemsCountInput;
        private Button generateArrayButton;
        private Button csharpSumButton;
        private Button cppSum;
        private Button xmmSum;
        private Label label2;
        private Label resultLabel;
    }
}
