namespace WinFormsApp2
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
            components = new System.ComponentModel.Container();
            TreeNode treeNode1 = new TreeNode("Номер в Госреестре утверженного типа СИ");
            TreeNode treeNode2 = new TreeNode("Тип СИ");
            TreeNode treeNode3 = new TreeNode("Наименование типа СИ");
            TreeNode treeNode4 = new TreeNode("Заводской/серийный номер СИ");
            TreeNode treeNode5 = new TreeNode("Инвентарный номер/буквенно-цифровое обозначение СИ");
            TreeNode treeNode6 = new TreeNode("Год выпуска СИ");
            TreeNode treeNode7 = new TreeNode("Модификация СИ");
            TreeNode treeNode8 = new TreeNode("Сведения о единичном СИ", new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4, treeNode5, treeNode6, treeNode7 });
            TreeNode treeNode9 = new TreeNode("Регистрационный номер СИ в перечне");
            TreeNode treeNode10 = new TreeNode("Номер в реестре утвержденного типа СИ");
            TreeNode treeNode11 = new TreeNode("Наименование утвержденного типа СИ");
            TreeNode treeNode12 = new TreeNode("Тип СИ");
            TreeNode treeNode13 = new TreeNode("Модификация СИ");
            TreeNode treeNode14 = new TreeNode("Заводской номер СИ");
            TreeNode treeNode15 = new TreeNode("Год выпуска СИ");
            TreeNode treeNode16 = new TreeNode("Код разряда эталона в ГПС, которому соответсвует СИ");
            TreeNode treeNode17 = new TreeNode("Наименование разряда эталона в ГПС, которому соответсвует СИ");
            TreeNode treeNode18 = new TreeNode("Наименование поверочной схемы или методики поверки");
            TreeNode treeNode19 = new TreeNode("СИ, применяемое в качестве эталона", new TreeNode[] { treeNode9, treeNode10, treeNode11, treeNode12, treeNode13, treeNode14, treeNode15, treeNode16, treeNode17, treeNode18 });
            TreeNode treeNode20 = new TreeNode("Наименование организации поверителя");
            TreeNode treeNode21 = new TreeNode("ЮЛ (ФЛ), передавшее СИ (партию СИ) на проверку");
            TreeNode treeNode22 = new TreeNode("Дата проверки СИ");
            TreeNode treeNode23 = new TreeNode("Поверка действительна до");
            TreeNode treeNode24 = new TreeNode("Тип поверки");
            TreeNode treeNode25 = new TreeNode("Наименование документа, на основание которого выполнена поверка");
            TreeNode treeNode26 = new TreeNode("Номер свидетельства/выписки");
            TreeNode treeNode27 = new TreeNode("Номер извещения/выписки");
            TreeNode treeNode28 = new TreeNode("Сведения о поверке", new TreeNode[] { treeNode20, treeNode21, treeNode22, treeNode23, treeNode24, treeNode25, treeNode26, treeNode27 });
            TreeNode treeNode29 = new TreeNode("Состав СИ, предоставленного на проверку");
            TreeNode treeNode30 = new TreeNode("Признак сокращенной поверки");
            TreeNode treeNode31 = new TreeNode("Краткая характеристика объёма поверки");
            TreeNode treeNode32 = new TreeNode("Диапазоны (поддиапазоны), на которых поверено СИ");
            TreeNode treeNode33 = new TreeNode("Отдельные величины для которых поверено СИ");
            TreeNode treeNode34 = new TreeNode("Измерительные каналы СИ, прошедшие поверку");
            TreeNode treeNode35 = new TreeNode("Отдельные автономные блоки из состава СИ, прошедшие поверку");
            TreeNode treeNode36 = new TreeNode("Прочие сведения");
            TreeNode treeNode37 = new TreeNode("Дополнительные сведения", new TreeNode[] { treeNode29, treeNode30, treeNode31, treeNode32, treeNode33, treeNode34, treeNode35, treeNode36 });
            TreeNode treeNode38 = new TreeNode("Государственные первичне эталоны");
            TreeNode treeNode39 = new TreeNode("Узел2");
            TreeNode treeNode40 = new TreeNode("Узел3");
            TreeNode treeNode41 = new TreeNode("Узел4");
            TreeNode treeNode42 = new TreeNode("Узел5");
            TreeNode treeNode43 = new TreeNode("Узел6");
            TreeNode treeNode44 = new TreeNode("Узел7");
            TreeNode treeNode45 = new TreeNode("Средства поверки", new TreeNode[] { treeNode38, treeNode39, treeNode40, treeNode41, treeNode42, treeNode43, treeNode44 });
            TreeNode treeNode46 = new TreeNode("Статус записи");
            TreeNode treeNode47 = new TreeNode("Сведения о публикации", new TreeNode[] { treeNode46 });
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            openFileDialog1 = new OpenFileDialog();
            treeView1 = new TreeView();
            buttonBackStage = new Button();
            label2 = new Label();
            buttonNextStage = new Button();
            labelTypeFormat = new Label();
            label8 = new Label();
            labelSection = new Label();
            label4 = new Label();
            buttonSave = new Button();
            labelWords = new Label();
            label3 = new Label();
            checkBoxMandatory = new CheckBox();
            labelSearchTerm = new Label();
            labelDatePicker = new Label();
            dateTimePickerTerm = new DateTimePicker();
            checkBoxTerm = new CheckBox();
            checkBoxOR = new CheckBox();
            checkBoxAnd = new CheckBox();
            textBoxTerms = new TextBox();
            labelSave = new Label();
            toolTip1 = new ToolTip(components);
            label9 = new Label();
            checkBoxFalse = new CheckBox();
            checkBoxTrue = new CheckBox();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 58);
            treeView1.Name = "treeView1";
            treeNode1.Name = "mitypeNumber";
            treeNode1.Tag = "string";
            treeNode1.Text = "Номер в Госреестре утверженного типа СИ";
            treeNode2.Name = "mitypeType";
            treeNode2.Tag = "string";
            treeNode2.Text = "Тип СИ";
            treeNode3.Name = "mitypeTitle";
            treeNode3.Tag = "string";
            treeNode3.Text = "Наименование типа СИ";
            treeNode4.Name = "manufactureNum";
            treeNode4.Tag = "string";
            treeNode4.Text = "Заводской/серийный номер СИ";
            treeNode5.Name = "inventoryNum";
            treeNode5.Tag = "string";
            treeNode5.Text = "Инвентарный номер/буквенно-цифровое обозначение СИ";
            treeNode6.Name = "manufactureYear";
            treeNode6.Tag = "string";
            treeNode6.Text = "Год выпуска СИ";
            treeNode7.Name = "modification";
            treeNode7.Tag = "string";
            treeNode7.Text = "Модификация СИ";
            treeNode8.Name = "singleMI";
            treeNode8.Tag = "";
            treeNode8.Text = "Сведения о единичном СИ";
            treeNode9.Name = "regNumber";
            treeNode9.Tag = "string";
            treeNode9.Text = "Регистрационный номер СИ в перечне";
            treeNode10.Name = "mitypeNumber";
            treeNode10.Tag = "string";
            treeNode10.Text = "Номер в реестре утвержденного типа СИ";
            treeNode11.Name = "mitypeTitle";
            treeNode11.Tag = "string";
            treeNode11.Text = "Наименование утвержденного типа СИ";
            treeNode12.Name = "mitypeType";
            treeNode12.Tag = "string";
            treeNode12.Text = "Тип СИ";
            treeNode13.Name = "modification";
            treeNode13.Tag = "string";
            treeNode13.Text = "Модификация СИ";
            treeNode14.Name = "manufactureNum";
            treeNode14.Tag = "string";
            treeNode14.Text = "Заводской номер СИ";
            treeNode15.Name = "manufactureYear";
            treeNode15.Tag = "string";
            treeNode15.Text = "Год выпуска СИ";
            treeNode16.Name = "rankCode";
            treeNode16.Tag = "string";
            treeNode16.Text = "Код разряда эталона в ГПС, которому соответсвует СИ";
            treeNode17.Name = "rankTitle";
            treeNode17.Tag = "string";
            treeNode17.Text = "Наименование разряда эталона в ГПС, которому соответсвует СИ";
            treeNode18.Name = "schemaTitle";
            treeNode18.Tag = "string";
            treeNode18.Text = "Наименование поверочной схемы или методики поверки";
            treeNode19.Name = "etaMI";
            treeNode19.Text = "СИ, применяемое в качестве эталона";
            treeNode20.Name = "organization";
            treeNode20.Tag = "string";
            treeNode20.Text = "Наименование организации поверителя";
            treeNode21.Name = "miOwner";
            treeNode21.Tag = "string";
            treeNode21.Text = "ЮЛ (ФЛ), передавшее СИ (партию СИ) на проверку";
            treeNode22.Name = "vrfDate";
            treeNode22.Tag = "date";
            treeNode22.Text = "Дата проверки СИ";
            treeNode23.Name = "validDate";
            treeNode23.Tag = "date";
            treeNode23.Text = "Поверка действительна до";
            treeNode24.Name = "vriType";
            treeNode24.Tag = "string";
            treeNode24.Text = "Тип поверки";
            treeNode25.Name = "docTitle";
            treeNode25.Tag = "string";
            treeNode25.Text = "Наименование документа, на основание которого выполнена поверка";
            treeNode26.Name = "certNum";
            treeNode26.Tag = "string";
            treeNode26.Text = "Номер свидетельства/выписки";
            treeNode27.Name = "noticeNum";
            treeNode27.Tag = "string";
            treeNode27.Text = "Номер извещения/выписки";
            treeNode28.Name = "vriInfo";
            treeNode28.Text = "Сведения о поверке";
            treeNode29.Name = "structure";
            treeNode29.Tag = "string";
            treeNode29.Text = "Состав СИ, предоставленного на проверку";
            treeNode30.Name = "briefIndicator";
            treeNode30.Tag = "boolean";
            treeNode30.Text = "Признак сокращенной поверки";
            treeNode31.Name = "briefCharacteristics";
            treeNode31.Tag = "string";
            treeNode31.Text = "Краткая характеристика объёма поверки";
            treeNode32.Name = "ranges";
            treeNode32.Tag = "string";
            treeNode32.Text = "Диапазоны (поддиапазоны), на которых поверено СИ";
            treeNode33.Name = "values";
            treeNode33.Tag = "string";
            treeNode33.Text = "Отдельные величины для которых поверено СИ";
            treeNode34.Name = "channels";
            treeNode34.Tag = "string";
            treeNode34.Text = "Измерительные каналы СИ, прошедшие поверку";
            treeNode35.Name = "blocks";
            treeNode35.Tag = "string";
            treeNode35.Text = "Отдельные автономные блоки из состава СИ, прошедшие поверку";
            treeNode36.Name = "additional_info";
            treeNode36.Tag = "string";
            treeNode36.Text = "Прочие сведения";
            treeNode37.Name = "info";
            treeNode37.Text = "Дополнительные сведения";
            treeNode38.Name = "Узел1";
            treeNode38.Tag = "string";
            treeNode38.Text = "Государственные первичне эталоны";
            treeNode39.Name = "Узел2";
            treeNode39.Tag = "string";
            treeNode39.Text = "Узел2";
            treeNode40.Name = "Узел3";
            treeNode40.Tag = "string";
            treeNode40.Text = "Узел3";
            treeNode41.Name = "Узел4";
            treeNode41.Tag = "string";
            treeNode41.Text = "Узел4";
            treeNode42.Name = "Узел5";
            treeNode42.Tag = "string";
            treeNode42.Text = "Узел5";
            treeNode43.Name = "Узел6";
            treeNode43.Tag = "string";
            treeNode43.Text = "Узел6";
            treeNode44.Name = "Узел7";
            treeNode44.Tag = "string";
            treeNode44.Text = "Узел7";
            treeNode45.Name = "means";
            treeNode45.Text = "Средства поверки";
            treeNode46.Name = "status";
            treeNode46.Tag = "string";
            treeNode46.Text = "Статус записи";
            treeNode47.Name = "publication";
            treeNode47.Text = "Сведения о публикации";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode8, treeNode19, treeNode28, treeNode37, treeNode45, treeNode47 });
            treeView1.Size = new Size(617, 726);
            treeView1.TabIndex = 54;
            treeView1.AfterCheck += treeView1_AfterCheck;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // buttonBackStage
            // 
            buttonBackStage.Location = new Point(12, 819);
            buttonBackStage.Name = "buttonBackStage";
            buttonBackStage.Size = new Size(94, 29);
            buttonBackStage.TabIndex = 56;
            buttonBackStage.Text = "Назад";
            buttonBackStage.UseVisualStyleBackColor = true;
            buttonBackStage.Click += buttonBackStage_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(561, 35);
            label2.TabIndex = 57;
            label2.Text = "Этап 2: Выберите атрибуты для отбора записей";
            // 
            // buttonNextStage
            // 
            buttonNextStage.Location = new Point(1076, 819);
            buttonNextStage.Name = "buttonNextStage";
            buttonNextStage.Size = new Size(132, 29);
            buttonNextStage.TabIndex = 58;
            buttonNextStage.Text = "Запустить поиск";
            buttonNextStage.UseVisualStyleBackColor = true;
            buttonNextStage.Click += buttonNextStage_Click;
            // 
            // labelTypeFormat
            // 
            labelTypeFormat.AutoSize = true;
            labelTypeFormat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTypeFormat.Location = new Point(673, 187);
            labelTypeFormat.Name = "labelTypeFormat";
            labelTypeFormat.Size = new Size(126, 20);
            labelTypeFormat.TabIndex = 75;
            labelTypeFormat.Text = "labelTypeFormat";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(672, 167);
            label8.Name = "label8";
            label8.Size = new Size(119, 20);
            label8.TabIndex = 74;
            label8.Text = "Формат записи:";
            // 
            // labelSection
            // 
            labelSection.AutoSize = true;
            labelSection.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSection.Location = new Point(672, 78);
            labelSection.Name = "labelSection";
            labelSection.Size = new Size(93, 20);
            labelSection.TabIndex = 72;
            labelSection.Text = "labelSection";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(672, 58);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 71;
            label4.Text = "Раздел атрибута:";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(1091, 755);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(108, 29);
            buttonSave.TabIndex = 70;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelWords
            // 
            labelWords.AutoSize = true;
            labelWords.Location = new Point(672, 394);
            labelWords.Name = "labelWords";
            labelWords.Size = new Size(120, 20);
            labelWords.TabIndex = 69;
            labelWords.Text = "Искомые слова:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(673, 112);
            label3.Name = "label3";
            label3.Size = new Size(168, 20);
            label3.TabIndex = 68;
            label3.Text = "Заполняемый атрибут:";
            // 
            // checkBoxMandatory
            // 
            checkBoxMandatory.AutoSize = true;
            checkBoxMandatory.Location = new Point(678, 314);
            checkBoxMandatory.Name = "checkBoxMandatory";
            checkBoxMandatory.Size = new Size(185, 24);
            checkBoxMandatory.TabIndex = 67;
            checkBoxMandatory.Text = "Наличие обязательно";
            checkBoxMandatory.UseVisualStyleBackColor = true;
            checkBoxMandatory.CheckedChanged += checkBoxMandatory_CheckedChanged;
            // 
            // labelSearchTerm
            // 
            labelSearchTerm.AutoEllipsis = true;
            labelSearchTerm.AutoSize = true;
            labelSearchTerm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearchTerm.Location = new Point(673, 132);
            labelSearchTerm.Name = "labelSearchTerm";
            labelSearchTerm.Size = new Size(124, 20);
            labelSearchTerm.TabIndex = 66;
            labelSearchTerm.Text = "labelSearchTerm";
            // 
            // labelDatePicker
            // 
            labelDatePicker.AutoSize = true;
            labelDatePicker.Location = new Point(673, 230);
            labelDatePicker.Name = "labelDatePicker";
            labelDatePicker.Size = new Size(96, 20);
            labelDatePicker.TabIndex = 99;
            labelDatePicker.Text = "Выбор даты:";
            // 
            // dateTimePickerTerm
            // 
            dateTimePickerTerm.CustomFormat = "dd-MM-yyyy";
            dateTimePickerTerm.Format = DateTimePickerFormat.Custom;
            dateTimePickerTerm.Location = new Point(788, 225);
            dateTimePickerTerm.Name = "dateTimePickerTerm";
            dateTimePickerTerm.Size = new Size(161, 27);
            dateTimePickerTerm.TabIndex = 98;
            dateTimePickerTerm.ValueChanged += dateTimePickerTerm_ValueChanged;
            // 
            // checkBoxTerm
            // 
            checkBoxTerm.AutoSize = true;
            checkBoxTerm.Location = new Point(932, 132);
            checkBoxTerm.Name = "checkBoxTerm";
            checkBoxTerm.RightToLeft = RightToLeft.No;
            checkBoxTerm.Size = new Size(238, 24);
            checkBoxTerm.TabIndex = 97;
            checkBoxTerm.Text = "Выбор логического значения";
            checkBoxTerm.UseVisualStyleBackColor = true;
            checkBoxTerm.CheckedChanged += checkBoxTerm_CheckedChanged;
            // 
            // checkBoxOR
            // 
            checkBoxOR.AutoSize = true;
            checkBoxOR.Location = new Point(870, 354);
            checkBoxOR.Name = "checkBoxOR";
            checkBoxOR.Size = new Size(193, 24);
            checkBoxOR.TabIndex = 96;
            checkBoxOR.Text = "Поиск в значении ИЛИ";
            checkBoxOR.UseVisualStyleBackColor = true;
            checkBoxOR.CheckedChanged += checkBoxOR_CheckedChanged;
            // 
            // checkBoxAnd
            // 
            checkBoxAnd.AutoSize = true;
            checkBoxAnd.Location = new Point(678, 354);
            checkBoxAnd.Name = "checkBoxAnd";
            checkBoxAnd.Size = new Size(172, 24);
            checkBoxAnd.TabIndex = 95;
            checkBoxAnd.Text = "Поиск в значении И";
            checkBoxAnd.UseVisualStyleBackColor = true;
            checkBoxAnd.CheckedChanged += checkBoxAnd_CheckedChanged;
            // 
            // textBoxTerms
            // 
            textBoxTerms.Location = new Point(673, 417);
            textBoxTerms.Multiline = true;
            textBoxTerms.Name = "textBoxTerms";
            textBoxTerms.ScrollBars = ScrollBars.Vertical;
            textBoxTerms.Size = new Size(526, 332);
            textBoxTerms.TabIndex = 100;
            textBoxTerms.TextChanged += textBoxTerms_TextChanged;
            // 
            // labelSave
            // 
            labelSave.AutoSize = true;
            labelSave.BackColor = Color.IndianRed;
            labelSave.ForeColor = SystemColors.ControlText;
            labelSave.Location = new Point(845, 759);
            labelSave.Name = "labelSave";
            labelSave.Size = new Size(240, 20);
            labelSave.TabIndex = 101;
            labelSave.Text = "Новые изменения не сохранены";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Подсказка";
            toolTip1.UseAnimation = false;
            toolTip1.UseFading = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 862);
            label9.Name = "label9";
            label9.Size = new Size(491, 20);
            label9.TabIndex = 102;
            label9.Text = "ℹ️ Для получение подсказки наведитесь на интерактивный элемент\r\n";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkBoxFalse
            // 
            checkBoxFalse.AutoSize = true;
            checkBoxFalse.Location = new Point(870, 274);
            checkBoxFalse.Name = "checkBoxFalse";
            checkBoxFalse.Size = new Size(172, 24);
            checkBoxFalse.TabIndex = 104;
            checkBoxFalse.Text = "Признак отсутствует";
            checkBoxFalse.UseVisualStyleBackColor = true;
            checkBoxFalse.CheckedChanged += checkBoxFalse_CheckedChanged;
            // 
            // checkBoxTrue
            // 
            checkBoxTrue.AutoSize = true;
            checkBoxTrue.Location = new Point(678, 274);
            checkBoxTrue.Name = "checkBoxTrue";
            checkBoxTrue.Size = new Size(184, 24);
            checkBoxTrue.TabIndex = 103;
            checkBoxTrue.Text = "Признак присутствует";
            checkBoxTrue.UseVisualStyleBackColor = true;
            checkBoxTrue.CheckedChanged += checkBoxTrue_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 891);
            Controls.Add(checkBoxFalse);
            Controls.Add(checkBoxTrue);
            Controls.Add(label9);
            Controls.Add(labelSave);
            Controls.Add(textBoxTerms);
            Controls.Add(labelDatePicker);
            Controls.Add(dateTimePickerTerm);
            Controls.Add(checkBoxTerm);
            Controls.Add(checkBoxOR);
            Controls.Add(checkBoxAnd);
            Controls.Add(labelTypeFormat);
            Controls.Add(label8);
            Controls.Add(labelSection);
            Controls.Add(label4);
            Controls.Add(buttonSave);
            Controls.Add(labelWords);
            Controls.Add(label3);
            Controls.Add(checkBoxMandatory);
            Controls.Add(labelSearchTerm);
            Controls.Add(buttonNextStage);
            Controls.Add(label2);
            Controls.Add(buttonBackStage);
            Controls.Add(treeView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Форма заполнения атрибутов отбора";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private TreeView treeView1;
        private Button buttonBackStage;
        private Label label2;
        private Button buttonNextStage;
        private Label labelTypeFormat;
        private Label label8;
        private Label labelSection;
        private Label label4;
        private Button buttonSave;
        private Label labelWords;
        private Label label3;
        private CheckBox checkBoxMandatory;
        private Label labelSearchTerm;
        private Label labelDatePicker;
        private DateTimePicker dateTimePickerTerm;
        private CheckBox checkBoxTerm;
        private CheckBox checkBoxOR;
        private CheckBox checkBoxAnd;
        private TextBox textBoxTerms;
        private Label labelSave;
        private ToolTip toolTip1;
        private Label label9;
        private CheckBox checkBoxFalse;
        private CheckBox checkBoxTrue;
    }
}