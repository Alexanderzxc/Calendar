namespace WinFormsApp4
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
            DayBox = new ComboBox();
            MonthBox = new ComboBox();
            YearBox = new ComboBox();
            FirstLabel = new Label();
            NextBut = new Button();
            SuspendLayout();
            // 
            // DayBox
            // 
            DayBox.FormattingEnabled = true;
            DayBox.Location = new Point(161, 136);
            DayBox.Name = "DayBox";
            DayBox.Size = new Size(121, 23);
            DayBox.TabIndex = 0;
            DayBox.SelectedIndexChanged += DayBox_SelectedIndexChanged;
            // 
            // MonthBox
            // 
            MonthBox.FormattingEnabled = true;
            MonthBox.Location = new Point(299, 136);
            MonthBox.Name = "MonthBox";
            MonthBox.Size = new Size(121, 23);
            MonthBox.TabIndex = 1;
            MonthBox.SelectedIndexChanged += MonthBox_SelectedIndexChanged;
            // 
            // YearBox
            // 
            YearBox.FormattingEnabled = true;
            YearBox.Location = new Point(438, 136);
            YearBox.Name = "YearBox";
            YearBox.Size = new Size(121, 23);
            YearBox.TabIndex = 2;
            YearBox.SelectedIndexChanged += YearBox_SelectedIndexChanged;
            // 
            // FirstLabel
            // 
            FirstLabel.AutoSize = true;
            FirstLabel.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            FirstLabel.Location = new Point(269, 53);
            FirstLabel.Name = "FirstLabel";
            FirstLabel.Size = new Size(0, 36);
            FirstLabel.TabIndex = 3;
            // 
            // NextBut
            // 
            NextBut.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            NextBut.Location = new Point(207, 213);
            NextBut.Name = "NextBut";
            NextBut.Size = new Size(299, 55);
            NextBut.TabIndex = 4;
            NextBut.Text = "Следующий день";
            NextBut.UseVisualStyleBackColor = true;
            NextBut.Click += NextBut_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NextBut);
            Controls.Add(FirstLabel);
            Controls.Add(YearBox);
            Controls.Add(MonthBox);
            Controls.Add(DayBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox DayBox;
        private ComboBox MonthBox;
        private ComboBox YearBox;
        private Label FirstLabel;
        private Button NextBut;
    }
}