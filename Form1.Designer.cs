namespace CustomerEvidenceApp
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
            textBox_FullName = new TextBox();
            checkBox_GdprAgreement = new CheckBox();
            button_Save = new Button();
            dateTimePicker_Birthday = new DateTimePicker();
            numericUpDown_IQ = new NumericUpDown();
            comboBox_Gender = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_IQ).BeginInit();
            SuspendLayout();
            // 
            // textBox_FullName
            // 
            textBox_FullName.Location = new Point(134, 35);
            textBox_FullName.Name = "textBox_FullName";
            textBox_FullName.Size = new Size(100, 23);
            textBox_FullName.TabIndex = 0;
            // 
            // checkBox_GdprAgreement
            // 
            checkBox_GdprAgreement.AutoSize = true;
            checkBox_GdprAgreement.Location = new Point(133, 151);
            checkBox_GdprAgreement.Name = "checkBox_GdprAgreement";
            checkBox_GdprAgreement.Size = new Size(108, 19);
            checkBox_GdprAgreement.TabIndex = 1;
            checkBox_GdprAgreement.Text = "Souhlas s GDPR";
            checkBox_GdprAgreement.UseVisualStyleBackColor = true;
            // 
            // button_Save
            // 
            button_Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_Save.Location = new Point(134, 193);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(75, 23);
            button_Save.TabIndex = 2;
            button_Save.Text = "Uložit";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button_Save_Click;
            // 
            // dateTimePicker_Birthday
            // 
            dateTimePicker_Birthday.Location = new Point(134, 64);
            dateTimePicker_Birthday.Name = "dateTimePicker_Birthday";
            dateTimePicker_Birthday.Size = new Size(200, 23);
            dateTimePicker_Birthday.TabIndex = 3;
            // 
            // numericUpDown_IQ
            // 
            numericUpDown_IQ.Location = new Point(134, 93);
            numericUpDown_IQ.Name = "numericUpDown_IQ";
            numericUpDown_IQ.Size = new Size(120, 23);
            numericUpDown_IQ.TabIndex = 4;
            // 
            // comboBox_Gender
            // 
            comboBox_Gender.FormattingEnabled = true;
            comboBox_Gender.Items.AddRange(new object[] { "Muž", "Žena" });
            comboBox_Gender.Location = new Point(133, 122);
            comboBox_Gender.Name = "comboBox_Gender";
            comboBox_Gender.Size = new Size(121, 23);
            comboBox_Gender.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 38);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 6;
            label1.Text = "Celé jméno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 70);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 7;
            label2.Text = "Datum narození";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 93);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 125);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 7;
            label4.Text = "Pohlaví";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(109, 95);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 7;
            label5.Text = "IQ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 228);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox_Gender);
            Controls.Add(numericUpDown_IQ);
            Controls.Add(dateTimePicker_Birthday);
            Controls.Add(button_Save);
            Controls.Add(checkBox_GdprAgreement);
            Controls.Add(textBox_FullName);
            MinimumSize = new Size(400, 250);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_IQ).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_FullName;
        private CheckBox checkBox_GdprAgreement;
        private Button button_Save;
        private DateTimePicker dateTimePicker_Birthday;
        private NumericUpDown numericUpDown_IQ;
        private ComboBox comboBox_Gender;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
