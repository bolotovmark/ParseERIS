namespace WinFormsApp2
{
    partial class FormAddTermsURL
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
            labelTypeFormat = new Label();
            label8 = new Label();
            label5 = new Label();
            label3 = new Label();
            buttonNextTerm = new Button();
            label2 = new Label();
            label1 = new Label();
            labelSearchTerm = new Label();
            checkBoxAnd = new CheckBox();
            checkBoxOR = new CheckBox();
            textBoxTerms = new TextBox();
            SuspendLayout();
            // 
            // labelTypeFormat
            // 
            labelTypeFormat.AutoSize = true;
            labelTypeFormat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTypeFormat.Location = new Point(137, 122);
            labelTypeFormat.Name = "labelTypeFormat";
            labelTypeFormat.Size = new Size(126, 20);
            labelTypeFormat.TabIndex = 76;
            labelTypeFormat.Text = "labelTypeFormat";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 122);
            label8.Name = "label8";
            label8.Size = new Size(119, 20);
            label8.TabIndex = 75;
            label8.Text = "Формат записи:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 488);
            label5.Name = "label5";
            label5.Size = new Size(379, 20);
            label5.TabIndex = 74;
            label5.Text = "ℹ️ Для получение подсказки наведитесь на элемент\r\n";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(543, 35);
            label3.TabIndex = 71;
            label3.Text = "Заполните информацию о искомом атрибуте";
            // 
            // buttonNextTerm
            // 
            buttonNextTerm.Location = new Point(442, 476);
            buttonNextTerm.Name = "buttonNextTerm";
            buttonNextTerm.Size = new Size(108, 29);
            buttonNextTerm.TabIndex = 70;
            buttonNextTerm.Text = "Продолжить";
            buttonNextTerm.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 207);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 69;
            label2.Text = "Искомые слова:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 84);
            label1.Name = "label1";
            label1.Size = new Size(168, 20);
            label1.TabIndex = 68;
            label1.Text = "Заполняемый атрибут:";
            // 
            // labelSearchTerm
            // 
            labelSearchTerm.AutoEllipsis = true;
            labelSearchTerm.AutoSize = true;
            labelSearchTerm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearchTerm.Location = new Point(186, 84);
            labelSearchTerm.Name = "labelSearchTerm";
            labelSearchTerm.Size = new Size(124, 20);
            labelSearchTerm.TabIndex = 66;
            labelSearchTerm.Text = "labelSearchTerm";
            // 
            // checkBoxAnd
            // 
            checkBoxAnd.AutoSize = true;
            checkBoxAnd.Location = new Point(12, 164);
            checkBoxAnd.Name = "checkBoxAnd";
            checkBoxAnd.Size = new Size(172, 24);
            checkBoxAnd.TabIndex = 78;
            checkBoxAnd.Text = "Поиск в значении И";
            checkBoxAnd.UseVisualStyleBackColor = true;
            checkBoxAnd.CheckedChanged += checkBoxAnd_CheckedChanged;
            // 
            // checkBoxOR
            // 
            checkBoxOR.AutoSize = true;
            checkBoxOR.Location = new Point(204, 164);
            checkBoxOR.Name = "checkBoxOR";
            checkBoxOR.Size = new Size(193, 24);
            checkBoxOR.TabIndex = 79;
            checkBoxOR.Text = "Поиск в значении ИЛИ";
            checkBoxOR.UseVisualStyleBackColor = true;
            checkBoxOR.CheckedChanged += checkBoxOR_CheckedChanged;
            // 
            // textBoxTerms
            // 
            textBoxTerms.Location = new Point(12, 230);
            textBoxTerms.Multiline = true;
            textBoxTerms.Name = "textBoxTerms";
            textBoxTerms.Size = new Size(397, 238);
            textBoxTerms.TabIndex = 80;
            // 
            // FormAddTermsURL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 517);
            Controls.Add(textBoxTerms);
            Controls.Add(checkBoxOR);
            Controls.Add(checkBoxAnd);
            Controls.Add(labelTypeFormat);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(buttonNextTerm);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelSearchTerm);
            Name = "FormAddTermsURL";
            Text = "FormAddTermsURL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTypeFormat;
        private Label label8;
        private Label label5;
        private Label label3;
        private Button buttonNextTerm;
        private Label label2;
        private Label label1;
        private Label labelSearchTerm;
        private Button buttonRemoveTerms;
        private Button buttonAddTerms;
        private ListBox listBoxTerms;
        private CheckBox checkBoxAnd;
        private CheckBox checkBoxOR;
        private TextBox textBoxTerms;
    }
}