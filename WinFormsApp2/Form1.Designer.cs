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
            TreeNode treeNode38 = new TreeNode("Статус записи");
            TreeNode treeNode39 = new TreeNode("Сведения о публикации", new TreeNode[] { treeNode38 });
            openFileDialog1 = new OpenFileDialog();
            treeView1 = new TreeView();
            buttonBackStage = new Button();
            label2 = new Label();
            buttonNextStage = new Button();
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
            treeNode1.Tag = "singleMI";
            treeNode1.Text = "Номер в Госреестре утверженного типа СИ";
            treeNode2.Name = "mitypeType";
            treeNode2.Tag = "singleMI";
            treeNode2.Text = "Тип СИ";
            treeNode3.Name = "mitypeTitle";
            treeNode3.Tag = "singleMI";
            treeNode3.Text = "Наименование типа СИ";
            treeNode4.Name = "manufactureNum";
            treeNode4.Tag = "singleMI";
            treeNode4.Text = "Заводской/серийный номер СИ";
            treeNode5.Name = "inventoryNum";
            treeNode5.Tag = "singleMI";
            treeNode5.Text = "Инвентарный номер/буквенно-цифровое обозначение СИ";
            treeNode6.Name = "manufactureYear";
            treeNode6.Tag = "singleMI";
            treeNode6.Text = "Год выпуска СИ";
            treeNode7.Name = "modification";
            treeNode7.Tag = "singleMI";
            treeNode7.Text = "Модификация СИ";
            treeNode8.Name = "not";
            treeNode8.Text = "Сведения о единичном СИ";
            treeNode9.Name = "regNumber";
            treeNode9.Tag = "etaMI";
            treeNode9.Text = "Регистрационный номер СИ в перечне";
            treeNode10.Name = "mitypeNumber";
            treeNode10.Tag = "etaMI";
            treeNode10.Text = "Номер в реестре утвержденного типа СИ";
            treeNode11.Name = "mitypeTitle";
            treeNode11.Tag = "etaMI";
            treeNode11.Text = "Наименование утвержденного типа СИ";
            treeNode12.Name = "mitypeType";
            treeNode12.Tag = "etaMI";
            treeNode12.Text = "Тип СИ";
            treeNode13.Name = "modification";
            treeNode13.Tag = "etaMI";
            treeNode13.Text = "Модификация СИ";
            treeNode14.Name = "manufactureNum";
            treeNode14.Tag = "etaMI";
            treeNode14.Text = "Заводской номер СИ";
            treeNode15.Name = "manufactureYear";
            treeNode15.Tag = "etaMI";
            treeNode15.Text = "Год выпуска СИ";
            treeNode16.Name = "rankCode";
            treeNode16.Tag = "etaMI";
            treeNode16.Text = "Код разряда эталона в ГПС, которому соответсвует СИ";
            treeNode17.Name = "rankTitle";
            treeNode17.Tag = "etaMI";
            treeNode17.Text = "Наименование разряда эталона в ГПС, которому соответсвует СИ";
            treeNode18.Name = "schemaTitle";
            treeNode18.Tag = "etaMI";
            treeNode18.Text = "Наименование поверочной схемы или методики поверки";
            treeNode19.Name = "not";
            treeNode19.Text = "СИ, применяемое в качестве эталона";
            treeNode20.Name = "organization";
            treeNode20.Tag = "vriInfo";
            treeNode20.Text = "Наименование организации поверителя";
            treeNode21.Name = "miOwner";
            treeNode21.Tag = "vriInfo";
            treeNode21.Text = "ЮЛ (ФЛ), передавшее СИ (партию СИ) на проверку";
            treeNode22.Name = "vrfDate";
            treeNode22.Tag = "vriInfo";
            treeNode22.Text = "Дата проверки СИ";
            treeNode23.Name = "validDate";
            treeNode23.Tag = "vriInfo";
            treeNode23.Text = "Поверка действительна до";
            treeNode24.Name = "vriType";
            treeNode24.Tag = "vriInfo";
            treeNode24.Text = "Тип поверки";
            treeNode25.Name = "docTitle";
            treeNode25.Tag = "vriInfo";
            treeNode25.Text = "Наименование документа, на основание которого выполнена поверка";
            treeNode26.Name = "certNum";
            treeNode26.Tag = "vriInfo";
            treeNode26.Text = "Номер свидетельства/выписки";
            treeNode27.Name = "noticeNum";
            treeNode27.Tag = "vriInfo";
            treeNode27.Text = "Номер извещения/выписки";
            treeNode28.Name = "not";
            treeNode28.Text = "Сведения о поверке";
            treeNode29.Name = "structure";
            treeNode29.Tag = "info";
            treeNode29.Text = "Состав СИ, предоставленного на проверку";
            treeNode30.Name = "briefIndicator";
            treeNode30.Tag = "info";
            treeNode30.Text = "Признак сокращенной поверки";
            treeNode31.Name = "briefCharacteristics";
            treeNode31.Tag = "info";
            treeNode31.Text = "Краткая характеристика объёма поверки";
            treeNode32.Name = "ranges";
            treeNode32.Tag = "info";
            treeNode32.Text = "Диапазоны (поддиапазоны), на которых поверено СИ";
            treeNode33.Name = "values";
            treeNode33.Tag = "info";
            treeNode33.Text = "Отдельные величины для которых поверено СИ";
            treeNode34.Name = "channels";
            treeNode34.Tag = "info";
            treeNode34.Text = "Измерительные каналы СИ, прошедшие поверку";
            treeNode35.Name = "blocks";
            treeNode35.Tag = "info";
            treeNode35.Text = "Отдельные автономные блоки из состава СИ, прошедшие поверку";
            treeNode36.Name = "additional_info";
            treeNode36.Tag = "info";
            treeNode36.Text = "Прочие сведения";
            treeNode37.Name = "not";
            treeNode37.Text = "Дополнительные сведения";
            treeNode38.Name = "status";
            treeNode38.Tag = "publication";
            treeNode38.Text = "Статус записи";
            treeNode39.Name = "not";
            treeNode39.Text = "Сведения о публикации";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode8, treeNode19, treeNode28, treeNode37, treeNode39 });
            treeView1.Size = new Size(617, 676);
            treeView1.TabIndex = 54;
            treeView1.AfterCheck += treeView1_AfterCheck;
            // 
            // buttonBackStage
            // 
            buttonBackStage.Location = new Point(12, 744);
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
            buttonNextStage.Location = new Point(524, 744);
            buttonNextStage.Name = "buttonNextStage";
            buttonNextStage.Size = new Size(105, 29);
            buttonNextStage.TabIndex = 58;
            buttonNextStage.Text = "Продолжить";
            buttonNextStage.UseVisualStyleBackColor = true;
            buttonNextStage.Click += buttonNextStage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 785);
            Controls.Add(buttonNextStage);
            Controls.Add(label2);
            Controls.Add(buttonBackStage);
            Controls.Add(treeView1);
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
    }
}