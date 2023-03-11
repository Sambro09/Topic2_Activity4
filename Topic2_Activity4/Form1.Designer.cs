namespace Topic2_Activity4
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
            inputLabel = new TextBox();
            convertButton = new Button();
            instructionLabel = new Label();
            counterLabel = new Label();
            SuspendLayout();
            // 
            // inputLabel
            // 
            inputLabel.Location = new Point(246, 156);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(125, 27);
            inputLabel.TabIndex = 0;
            // 
            // convertButton
            // 
            convertButton.Location = new Point(262, 202);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(94, 29);
            convertButton.TabIndex = 1;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Location = new Point(206, 90);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(224, 20);
            instructionLabel.TabIndex = 2;
            instructionLabel.Text = "Input seconds then press convert";
            // 
            // counterLabel
            // 
            counterLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            counterLabel.Location = new Point(12, 110);
            counterLabel.Name = "counterLabel";
            counterLabel.Size = new Size(601, 34);
            counterLabel.TabIndex = 3;
            counterLabel.Text = "0";
            counterLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 339);
            Controls.Add(counterLabel);
            Controls.Add(instructionLabel);
            Controls.Add(convertButton);
            Controls.Add(inputLabel);
            Name = "Form1";
            Text = "Seconds Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputLabel;
        private Button convertButton;
        private Label instructionLabel;
        private Label counterLabel;
    }
}