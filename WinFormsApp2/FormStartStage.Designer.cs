namespace WinFormsApp2
{
    partial class FormStartStage
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            progressBarCount = new ProgressBar();
            buttonClearTypesSI = new Button();
            buttonRemoveTypesSI = new Button();
            buttonAddTypesSI = new Button();
            listBoxMitTitle = new ListBox();
            label8 = new Label();
            label7 = new Label();
            dateTimePickerB = new DateTimePicker();
            dateTimePickerA = new DateTimePicker();
            label5 = new Label();
            labelCount = new Label();
            label3 = new Label();
            label2 = new Label();
            buttonCheck = new Button();
            buttonNextStage = new Button();
            label4 = new Label();
            toolTipAdd = new ToolTip(components);
            toolTipRemove = new ToolTip(components);
            toolTipClear = new ToolTip(components);
            toolTipFindCount = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(483, 35);
            label1.TabIndex = 0;
            label1.Text = "Этап 1: Укажите условия поиска записей";
            // 
            // progressBarCount
            // 
            progressBarCount.Location = new Point(149, 428);
            progressBarCount.Name = "progressBarCount";
            progressBarCount.Size = new Size(125, 29);
            progressBarCount.TabIndex = 69;
            // 
            // buttonClearTypesSI
            // 
            buttonClearTypesSI.Location = new Point(410, 346);
            buttonClearTypesSI.Name = "buttonClearTypesSI";
            buttonClearTypesSI.Size = new Size(123, 52);
            buttonClearTypesSI.TabIndex = 68;
            buttonClearTypesSI.Text = "Очистить список";
            buttonClearTypesSI.UseVisualStyleBackColor = true;
            buttonClearTypesSI.Click += buttonClearTypesSI_Click;
            // 
            // buttonRemoveTypesSI
            // 
            buttonRemoveTypesSI.Location = new Point(410, 279);
            buttonRemoveTypesSI.Name = "buttonRemoveTypesSI";
            buttonRemoveTypesSI.Size = new Size(123, 52);
            buttonRemoveTypesSI.TabIndex = 67;
            buttonRemoveTypesSI.Text = "Удалить выбранный";
            buttonRemoveTypesSI.UseVisualStyleBackColor = true;
            buttonRemoveTypesSI.Click += buttonRemoveTypesSI_Click;
            // 
            // buttonAddTypesSI
            // 
            buttonAddTypesSI.Location = new Point(410, 212);
            buttonAddTypesSI.Name = "buttonAddTypesSI";
            buttonAddTypesSI.Size = new Size(123, 52);
            buttonAddTypesSI.TabIndex = 66;
            buttonAddTypesSI.Text = "Добавить";
            buttonAddTypesSI.UseVisualStyleBackColor = true;
            buttonAddTypesSI.Click += buttonAddTypesSI_Click;
            // 
            // listBoxMitTitle
            // 
            listBoxMitTitle.FormattingEnabled = true;
            listBoxMitTitle.ItemHeight = 20;
            listBoxMitTitle.Items.AddRange(new object[] { "газ" });
            listBoxMitTitle.Location = new Point(198, 212);
            listBoxMitTitle.Name = "listBoxMitTitle";
            listBoxMitTitle.Size = new Size(206, 184);
            listBoxMitTitle.TabIndex = 65;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(170, 140);
            label8.Name = "label8";
            label8.Size = new Size(31, 20);
            label8.TabIndex = 64;
            label8.Text = "До:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(170, 81);
            label7.Name = "label7";
            label7.Size = new Size(29, 20);
            label7.TabIndex = 63;
            label7.Text = "От:";
            // 
            // dateTimePickerB
            // 
            dateTimePickerB.CustomFormat = "dd-MM-yyyy";
            dateTimePickerB.Format = DateTimePickerFormat.Custom;
            dateTimePickerB.Location = new Point(214, 135);
            dateTimePickerB.Name = "dateTimePickerB";
            dateTimePickerB.Size = new Size(161, 27);
            dateTimePickerB.TabIndex = 62;
            // 
            // dateTimePickerA
            // 
            dateTimePickerA.CustomFormat = "dd-MM-yyyy";
            dateTimePickerA.Format = DateTimePickerFormat.Custom;
            dateTimePickerA.Location = new Point(214, 76);
            dateTimePickerA.Name = "dateTimePickerA";
            dateTimePickerA.Size = new Size(161, 27);
            dateTimePickerA.TabIndex = 61;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 212);
            label5.Name = "label5";
            label5.Size = new Size(176, 20);
            label5.TabIndex = 60;
            label5.Text = "Наименование типа СИ\r\n";
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(456, 432);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(81, 20);
            labelCount.TabIndex = 59;
            labelCount.Text = "labelCount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 432);
            label3.Name = "label3";
            label3.Size = new Size(167, 20);
            label3.TabIndex = 58;
            label3.Text = "Кол-во строк найдено:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 57;
            label2.Text = "Период поверки";
            // 
            // buttonCheck
            // 
            buttonCheck.Location = new Point(12, 426);
            buttonCheck.Margin = new Padding(3, 4, 3, 4);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(117, 31);
            buttonCheck.TabIndex = 56;
            buttonCheck.Text = "Найти записи";
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Click += buttonCheck_Click;
            // 
            // buttonNextStage
            // 
            buttonNextStage.Location = new Point(468, 498);
            buttonNextStage.Name = "buttonNextStage";
            buttonNextStage.Size = new Size(135, 29);
            buttonNextStage.TabIndex = 70;
            buttonNextStage.Text = "Следующий этап";
            buttonNextStage.UseVisualStyleBackColor = true;
            buttonNextStage.Click += buttonNextStage_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 510);
            label4.Name = "label4";
            label4.Size = new Size(379, 20);
            label4.TabIndex = 71;
            label4.Text = "ℹ️ Для получение подсказки наведитесь на элемент\r\n";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toolTipAdd
            // 
            toolTipAdd.ToolTipIcon = ToolTipIcon.Info;
            toolTipAdd.ToolTipTitle = "Подсказка";
            toolTipAdd.UseAnimation = false;
            toolTipAdd.UseFading = false;
            // 
            // toolTipRemove
            // 
            toolTipRemove.ToolTipIcon = ToolTipIcon.Info;
            toolTipRemove.ToolTipTitle = "Подсказка";
            toolTipRemove.UseAnimation = false;
            toolTipRemove.UseFading = false;
            // 
            // toolTipClear
            // 
            toolTipClear.ToolTipIcon = ToolTipIcon.Info;
            toolTipClear.ToolTipTitle = "Подсказка";
            toolTipClear.UseAnimation = false;
            toolTipClear.UseFading = false;
            // 
            // toolTipFindCount
            // 
            toolTipFindCount.ToolTipIcon = ToolTipIcon.Info;
            toolTipFindCount.ToolTipTitle = "Подсказка";
            toolTipFindCount.UseAnimation = false;
            toolTipFindCount.UseFading = false;
            // 
            // FormStartStage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 539);
            Controls.Add(label4);
            Controls.Add(buttonNextStage);
            Controls.Add(progressBarCount);
            Controls.Add(buttonClearTypesSI);
            Controls.Add(buttonRemoveTypesSI);
            Controls.Add(buttonAddTypesSI);
            Controls.Add(listBoxMitTitle);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dateTimePickerB);
            Controls.Add(dateTimePickerA);
            Controls.Add(label5);
            Controls.Add(labelCount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonCheck);
            Controls.Add(label1);
            Name = "FormStartStage";
            Text = "Форма заполнения условий поиска";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar progressBarCount;
        private Button buttonClearTypesSI;
        private Button buttonRemoveTypesSI;
        private Button buttonAddTypesSI;
        private ListBox listBoxMitTitle;
        private Label label8;
        private Label label7;
        private DateTimePicker dateTimePickerB;
        private DateTimePicker dateTimePickerA;
        private Label label5;
        private Label labelCount;
        private Label label3;
        private Label label2;
        private Button buttonCheck;
        private Button buttonNextStage;
        private Label label4;
        private ToolTip toolTipAdd;
        private ToolTip toolTipRemove;
        private ToolTip toolTipClear;
        private ToolTip toolTipFindCount;
    }
}