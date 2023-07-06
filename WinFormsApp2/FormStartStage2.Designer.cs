namespace WinFormsApp2
{
    partial class FormStartStage2
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
            TreeNode treeNode1 = new TreeNode("Наименование организациии поверителя");
            TreeNode treeNode2 = new TreeNode("Регистрационный номер типа СИ");
            TreeNode treeNode3 = new TreeNode("Наименование типа СИ");
            TreeNode treeNode4 = new TreeNode("Обозначение типа СИ");
            TreeNode treeNode5 = new TreeNode("Модификация СИ");
            TreeNode treeNode6 = new TreeNode("Заводской/серийный номер/буквенно-цифровое обозначение");
            TreeNode treeNode7 = new TreeNode("Действительна до");
            TreeNode treeNode8 = new TreeNode("Номер свидетельства/извещения/выписки");
            TreeNode treeNode9 = new TreeNode("Номер наклейки");
            TreeNode treeNode10 = new TreeNode("Пригодность");
            treeViewTermsURL = new TreeView();
            label8 = new Label();
            label7 = new Label();
            dateTimePickerB = new DateTimePicker();
            dateTimePickerA = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            buttonNextStage = new Button();
            labelSearchTerm = new Label();
            label6 = new Label();
            labelWords = new Label();
            textBoxTerms = new TextBox();
            label3 = new Label();
            labelTypeFormat = new Label();
            checkBoxAnd = new CheckBox();
            checkBoxOR = new CheckBox();
            buttonSave = new Button();
            labelSave = new Label();
            checkBoxTerm = new CheckBox();
            dateTimePickerTerm = new DateTimePicker();
            labelDatePicker = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // treeViewTermsURL
            // 
            treeViewTermsURL.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            treeViewTermsURL.Indent = 19;
            treeViewTermsURL.ItemHeight = 30;
            treeViewTermsURL.Location = new Point(12, 232);
            treeViewTermsURL.Name = "treeViewTermsURL";
            treeNode1.Name = "org_title";
            treeNode1.Tag = "string";
            treeNode1.Text = "Наименование организациии поверителя";
            treeNode2.Name = "mit_number";
            treeNode2.Tag = "string";
            treeNode2.Text = "Регистрационный номер типа СИ";
            treeNode3.Name = "mit_title";
            treeNode3.Tag = "string";
            treeNode3.Text = "Наименование типа СИ";
            treeNode4.Name = "mit_notation";
            treeNode4.Tag = "string";
            treeNode4.Text = "Обозначение типа СИ";
            treeNode5.Name = "mi_modification";
            treeNode5.Tag = "string";
            treeNode5.Text = "Модификация СИ";
            treeNode6.Name = "mi_number";
            treeNode6.Tag = "string";
            treeNode6.Text = "Заводской/серийный номер/буквенно-цифровое обозначение";
            treeNode7.Name = "valid_date";
            treeNode7.Tag = "date";
            treeNode7.Text = "Действительна до";
            treeNode8.Name = "result_docnum";
            treeNode8.Tag = "string";
            treeNode8.Text = "Номер свидетельства/извещения/выписки";
            treeNode9.Name = "sticker_num";
            treeNode9.Tag = "string";
            treeNode9.Text = "Номер наклейки";
            treeNode10.Name = "applicability";
            treeNode10.Tag = "boolean";
            treeNode10.Text = "Пригодность";
            treeViewTermsURL.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4, treeNode5, treeNode6, treeNode7, treeNode8, treeNode9, treeNode10 });
            treeViewTermsURL.Size = new Size(502, 322);
            treeViewTermsURL.TabIndex = 0;
            treeViewTermsURL.AfterCheck += treeViewTermsURL_AfterCheck;
            treeViewTermsURL.AfterSelect += treeViewTermsURL_AfterSelect;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 185);
            label8.Name = "label8";
            label8.Size = new Size(31, 20);
            label8.TabIndex = 70;
            label8.Text = "До:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 126);
            label7.Name = "label7";
            label7.Size = new Size(29, 20);
            label7.TabIndex = 69;
            label7.Text = "От:";
            // 
            // dateTimePickerB
            // 
            dateTimePickerB.CustomFormat = "dd-MM-yyyy";
            dateTimePickerB.Format = DateTimePickerFormat.Custom;
            dateTimePickerB.Location = new Point(56, 180);
            dateTimePickerB.Name = "dateTimePickerB";
            dateTimePickerB.Size = new Size(161, 27);
            dateTimePickerB.TabIndex = 68;
            // 
            // dateTimePickerA
            // 
            dateTimePickerA.CustomFormat = "dd-MM-yyyy";
            dateTimePickerA.Format = DateTimePickerFormat.Custom;
            dateTimePickerA.Location = new Point(56, 121);
            dateTimePickerA.Name = "dateTimePickerA";
            dateTimePickerA.Size = new Size(161, 27);
            dateTimePickerA.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 66;
            label2.Text = "Период поверки";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(483, 35);
            label1.TabIndex = 65;
            label1.Text = "Этап 1: Укажите условия поиска записей";
            // 
            // buttonNextStage
            // 
            buttonNextStage.Location = new Point(378, 560);
            buttonNextStage.Name = "buttonNextStage";
            buttonNextStage.Size = new Size(136, 29);
            buttonNextStage.TabIndex = 76;
            buttonNextStage.Text = "Следующий этап";
            buttonNextStage.UseVisualStyleBackColor = true;
            buttonNextStage.Click += buttonNextStage_Click;
            // 
            // labelSearchTerm
            // 
            labelSearchTerm.AutoEllipsis = true;
            labelSearchTerm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearchTerm.Location = new Point(576, 81);
            labelSearchTerm.Name = "labelSearchTerm";
            labelSearchTerm.Size = new Size(478, 47);
            labelSearchTerm.TabIndex = 81;
            labelSearchTerm.Text = "Заводской/серийный номер /буквенно-цифровое обозначение";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(576, 56);
            label6.Name = "label6";
            label6.Size = new Size(168, 20);
            label6.TabIndex = 82;
            label6.Text = "Заполняемый атрибут:";
            // 
            // labelWords
            // 
            labelWords.AutoSize = true;
            labelWords.Location = new Point(581, 298);
            labelWords.Name = "labelWords";
            labelWords.Size = new Size(120, 20);
            labelWords.TabIndex = 83;
            labelWords.Text = "Искомые слова:";
            // 
            // textBoxTerms
            // 
            textBoxTerms.Location = new Point(581, 321);
            textBoxTerms.Multiline = true;
            textBoxTerms.Name = "textBoxTerms";
            textBoxTerms.Size = new Size(478, 238);
            textBoxTerms.TabIndex = 89;
            textBoxTerms.TextChanged += textBoxTerms_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(576, 121);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 85;
            label3.Text = "Формат записи:";
            // 
            // labelTypeFormat
            // 
            labelTypeFormat.AutoSize = true;
            labelTypeFormat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTypeFormat.Location = new Point(706, 121);
            labelTypeFormat.Name = "labelTypeFormat";
            labelTypeFormat.Size = new Size(126, 20);
            labelTypeFormat.TabIndex = 86;
            labelTypeFormat.Text = "labelTypeFormat";
            // 
            // checkBoxAnd
            // 
            checkBoxAnd.AutoSize = true;
            checkBoxAnd.Location = new Point(581, 255);
            checkBoxAnd.Name = "checkBoxAnd";
            checkBoxAnd.Size = new Size(172, 24);
            checkBoxAnd.TabIndex = 87;
            checkBoxAnd.Text = "Поиск в значении И";
            checkBoxAnd.UseVisualStyleBackColor = true;
            checkBoxAnd.CheckedChanged += checkBoxAnd_CheckedChanged;
            // 
            // checkBoxOR
            // 
            checkBoxOR.AutoSize = true;
            checkBoxOR.Location = new Point(773, 255);
            checkBoxOR.Name = "checkBoxOR";
            checkBoxOR.Size = new Size(193, 24);
            checkBoxOR.TabIndex = 88;
            checkBoxOR.Text = "Поиск в значении ИЛИ";
            checkBoxOR.UseVisualStyleBackColor = true;
            checkBoxOR.CheckedChanged += checkBoxOR_CheckedChanged;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(965, 565);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 90;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelSave
            // 
            labelSave.AutoSize = true;
            labelSave.BackColor = Color.IndianRed;
            labelSave.ForeColor = SystemColors.ControlText;
            labelSave.Location = new Point(706, 569);
            labelSave.Name = "labelSave";
            labelSave.Size = new Size(240, 20);
            labelSave.TabIndex = 91;
            labelSave.Text = "Новые изменения не сохранены";
            // 
            // checkBoxTerm
            // 
            checkBoxTerm.AutoSize = true;
            checkBoxTerm.Location = new Point(581, 210);
            checkBoxTerm.Name = "checkBoxTerm";
            checkBoxTerm.RightToLeft = RightToLeft.No;
            checkBoxTerm.Size = new Size(238, 24);
            checkBoxTerm.TabIndex = 92;
            checkBoxTerm.Text = "Выбор логического значения";
            checkBoxTerm.UseVisualStyleBackColor = true;
            checkBoxTerm.CheckedChanged += checkBoxTerm_CheckedChanged;
            // 
            // dateTimePickerTerm
            // 
            dateTimePickerTerm.CustomFormat = "dd-MM-yyyy";
            dateTimePickerTerm.Format = DateTimePickerFormat.Custom;
            dateTimePickerTerm.Location = new Point(691, 162);
            dateTimePickerTerm.Name = "dateTimePickerTerm";
            dateTimePickerTerm.Size = new Size(161, 27);
            dateTimePickerTerm.TabIndex = 93;
            dateTimePickerTerm.ValueChanged += dateTimePickerTerm_ValueChanged;
            // 
            // labelDatePicker
            // 
            labelDatePicker.AutoSize = true;
            labelDatePicker.Location = new Point(576, 167);
            labelDatePicker.Name = "labelDatePicker";
            labelDatePicker.Size = new Size(96, 20);
            labelDatePicker.TabIndex = 94;
            labelDatePicker.Text = "Выбор даты:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 256);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 95;
            // 
            // FormStartStage2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 606);
            Controls.Add(label4);
            Controls.Add(labelDatePicker);
            Controls.Add(dateTimePickerTerm);
            Controls.Add(checkBoxTerm);
            Controls.Add(labelSave);
            Controls.Add(buttonSave);
            Controls.Add(textBoxTerms);
            Controls.Add(checkBoxOR);
            Controls.Add(checkBoxAnd);
            Controls.Add(labelTypeFormat);
            Controls.Add(label3);
            Controls.Add(labelWords);
            Controls.Add(label6);
            Controls.Add(labelSearchTerm);
            Controls.Add(buttonNextStage);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dateTimePickerB);
            Controls.Add(dateTimePickerA);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(treeViewTermsURL);
            Name = "FormStartStage2";
            Text = "FormStartStage2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeViewTermsURL;
        private Label label8;
        private Label label7;
        private DateTimePicker dateTimePickerB;
        private DateTimePicker dateTimePickerA;
        private Label label2;
        private Label label1;
        private Button buttonNextStage;
        private Label labelSearchTerm;
        private Label label6;
        private Label labelWords;
        private TextBox textBoxTerms;
        private Label label3;
        private Label labelTypeFormat;
        private CheckBox checkBoxAnd;
        private CheckBox checkBoxOR;
        private Button buttonSave;
        private Label labelSave;
        private CheckBox checkBoxTerm;
        private DateTimePicker dateTimePickerTerm;
        private Label labelDatePicker;
        private Label label4;
    }
}