namespace WinFormsApp2
{
    partial class FormDialogAddSearchTerms
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
            checkBox = new CheckBox();
            labelSearchTerm = new Label();
            buttonClearTerms = new Button();
            buttonRemoveTerms = new Button();
            buttonAddTerms = new Button();
            listBoxTerms = new ListBox();
            label1 = new Label();
            label2 = new Label();
            toolTipCheckBox = new ToolTip(components);
            buttonNextTerm = new Button();
            label3 = new Label();
            label4 = new Label();
            labelSection = new Label();
            label5 = new Label();
            toolTipAdd = new ToolTip(components);
            toolTipRemove = new ToolTip(components);
            toolTipClear = new ToolTip(components);
            label8 = new Label();
            labelTypeFormat = new Label();
            buttonBuffer = new Button();
            SuspendLayout();
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.CheckAlign = ContentAlignment.MiddleRight;
            checkBox.Location = new Point(12, 144);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(188, 24);
            checkBox.TabIndex = 51;
            checkBox.Text = "Наличие обязательно:";
            checkBox.UseVisualStyleBackColor = true;
            // 
            // labelSearchTerm
            // 
            labelSearchTerm.AutoEllipsis = true;
            labelSearchTerm.AutoSize = true;
            labelSearchTerm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearchTerm.Location = new Point(186, 111);
            labelSearchTerm.Name = "labelSearchTerm";
            labelSearchTerm.Size = new Size(124, 20);
            labelSearchTerm.TabIndex = 50;
            labelSearchTerm.Text = "labelSearchTerm";
            // 
            // buttonClearTerms
            // 
            buttonClearTerms.Location = new Point(442, 343);
            buttonClearTerms.Name = "buttonClearTerms";
            buttonClearTerms.Size = new Size(123, 50);
            buttonClearTerms.TabIndex = 49;
            buttonClearTerms.Text = "Очистить список";
            buttonClearTerms.UseVisualStyleBackColor = true;
            buttonClearTerms.Click += buttonClearTerms_Click;
            // 
            // buttonRemoveTerms
            // 
            buttonRemoveTerms.Location = new Point(442, 280);
            buttonRemoveTerms.Name = "buttonRemoveTerms";
            buttonRemoveTerms.Size = new Size(123, 50);
            buttonRemoveTerms.TabIndex = 48;
            buttonRemoveTerms.Text = "Удалить выбранный";
            buttonRemoveTerms.UseVisualStyleBackColor = true;
            buttonRemoveTerms.Click += buttonRemoveTerms_Click;
            // 
            // buttonAddTerms
            // 
            buttonAddTerms.Location = new Point(442, 217);
            buttonAddTerms.Name = "buttonAddTerms";
            buttonAddTerms.Size = new Size(123, 50);
            buttonAddTerms.TabIndex = 47;
            buttonAddTerms.Text = "Добавить";
            buttonAddTerms.UseVisualStyleBackColor = true;
            buttonAddTerms.Click += buttonAddTerms_Click;
            // 
            // listBoxTerms
            // 
            listBoxTerms.FormattingEnabled = true;
            listBoxTerms.ItemHeight = 20;
            listBoxTerms.Location = new Point(143, 217);
            listBoxTerms.Name = "listBoxTerms";
            listBoxTerms.Size = new Size(293, 244);
            listBoxTerms.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 111);
            label1.Name = "label1";
            label1.Size = new Size(168, 20);
            label1.TabIndex = 52;
            label1.Text = "Заполняемый атрибут:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 217);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 53;
            label2.Text = "Искомые слова:";
            // 
            // toolTipCheckBox
            // 
            toolTipCheckBox.ToolTipIcon = ToolTipIcon.Info;
            toolTipCheckBox.ToolTipTitle = "Подсказка";
            toolTipCheckBox.UseAnimation = false;
            toolTipCheckBox.UseFading = false;
            // 
            // buttonNextTerm
            // 
            buttonNextTerm.Location = new Point(710, 466);
            buttonNextTerm.Name = "buttonNextTerm";
            buttonNextTerm.Size = new Size(108, 29);
            buttonNextTerm.TabIndex = 54;
            buttonNextTerm.Text = "Продолжить";
            buttonNextTerm.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(543, 35);
            label3.TabIndex = 55;
            label3.Text = "Заполните информацию о искомом атрибуте";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 78);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 56;
            label4.Text = "Раздел атрибута:";
            // 
            // labelSection
            // 
            labelSection.AutoSize = true;
            labelSection.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSection.Location = new Point(143, 78);
            labelSection.Name = "labelSection";
            labelSection.Size = new Size(51, 20);
            labelSection.TabIndex = 57;
            labelSection.Text = "label5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 478);
            label5.Name = "label5";
            label5.Size = new Size(379, 20);
            label5.TabIndex = 58;
            label5.Text = "ℹ️ Для получение подсказки наведитесь на элемент\r\n";
            label5.TextAlign = ContentAlignment.MiddleCenter;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 181);
            label8.Name = "label8";
            label8.Size = new Size(119, 20);
            label8.TabIndex = 59;
            label8.Text = "Формат записи:";
            // 
            // labelTypeFormat
            // 
            labelTypeFormat.AutoSize = true;
            labelTypeFormat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTypeFormat.Location = new Point(137, 181);
            labelTypeFormat.Name = "labelTypeFormat";
            labelTypeFormat.Size = new Size(126, 20);
            labelTypeFormat.TabIndex = 60;
            labelTypeFormat.Text = "labelTypeFormat";
            // 
            // buttonBuffer
            // 
            buttonBuffer.Location = new Point(442, 411);
            buttonBuffer.Name = "buttonBuffer";
            buttonBuffer.Size = new Size(123, 50);
            buttonBuffer.TabIndex = 61;
            buttonBuffer.Text = "Добавить из буфера";
            buttonBuffer.UseVisualStyleBackColor = true;
            buttonBuffer.Click += buttonBuffer_Click;
            // 
            // FormDialogAddSearchTerms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 507);
            ControlBox = false;
            Controls.Add(buttonBuffer);
            Controls.Add(labelTypeFormat);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(labelSection);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonNextTerm);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox);
            Controls.Add(labelSearchTerm);
            Controls.Add(buttonClearTerms);
            Controls.Add(buttonRemoveTerms);
            Controls.Add(buttonAddTerms);
            Controls.Add(listBoxTerms);
            Name = "FormDialogAddSearchTerms";
            Text = "Форма добавления ключевого поля";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox;
        private Label labelSearchTerm;
        private Button buttonClearTerms;
        private Button buttonRemoveTerms;
        private Button buttonAddTerms;
        private ListBox listBoxTerms;
        private Label label1;
        private Label label2;
        private ToolTip toolTipCheckBox;
        private Button buttonNextTerm;
        private Label label3;
        private Label label4;
        private Label labelSection;
        private Label label5;
        private ToolTip toolTipAdd;
        private ToolTip toolTipRemove;
        private ToolTip toolTipClear;
        private Label label8;
        private Label labelTypeFormat;
        private Button buttonBuffer;
    }
}