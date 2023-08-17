namespace WinFormsApp2
{
    partial class FormFinishStage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinishStage));
            buttonStart = new Button();
            buttonStop = new Button();
            progressBar1 = new ProgressBar();
            buttonQuit = new Button();
            label1 = new Label();
            label2 = new Label();
            labelCount = new Label();
            buttonBackStage = new Button();
            label3 = new Label();
            label4 = new Label();
            labelFindCount = new Label();
            label5 = new Label();
            labelStatus = new Label();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(427, 196);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(94, 29);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Старт";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(115, 196);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(106, 29);
            buttonStop.TabIndex = 1;
            buttonStop.Text = "Продолжить";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(152, 79);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(223, 29);
            progressBar1.TabIndex = 2;
            // 
            // buttonQuit
            // 
            buttonQuit.Location = new Point(227, 196);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Size = new Size(94, 29);
            buttonQuit.TabIndex = 3;
            buttonQuit.Text = "Завершить";
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(280, 35);
            label1.TabIndex = 4;
            label1.Text = "Этап 3: Работа парсера";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 5;
            label2.Text = "Статус обработки:";
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCount.Location = new Point(381, 88);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(84, 20);
            labelCount.TabIndex = 6;
            labelCount.Text = "labelCount";
            // 
            // buttonBackStage
            // 
            buttonBackStage.Location = new Point(12, 238);
            buttonBackStage.Name = "buttonBackStage";
            buttonBackStage.Size = new Size(94, 29);
            buttonBackStage.TabIndex = 7;
            buttonBackStage.Text = "Назад";
            buttonBackStage.UseVisualStyleBackColor = true;
            buttonBackStage.Click += buttonBackStage_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 200);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 9;
            label3.Text = "Управление:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 127);
            label4.Name = "label4";
            label4.Size = new Size(185, 20);
            label4.TabIndex = 10;
            label4.Text = "Кол-во найденных строк:";
            // 
            // labelFindCount
            // 
            labelFindCount.AutoSize = true;
            labelFindCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelFindCount.Location = new Point(203, 127);
            labelFindCount.Name = "labelFindCount";
            labelFindCount.Size = new Size(84, 20);
            labelFindCount.TabIndex = 11;
            labelFindCount.Text = "labelCount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 163);
            label5.Name = "label5";
            label5.Size = new Size(177, 20);
            label5.TabIndex = 12;
            label5.Text = "Статус работы парсера: ";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelStatus.Location = new Point(195, 163);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(86, 20);
            labelStatus.TabIndex = 13;
            labelStatus.Text = "labelStatus";
            // 
            // FormFinishStage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 279);
            Controls.Add(labelStatus);
            Controls.Add(label5);
            Controls.Add(labelFindCount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonBackStage);
            Controls.Add(labelCount);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonQuit);
            Controls.Add(progressBar1);
            Controls.Add(buttonStop);
            Controls.Add(buttonStart);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormFinishStage";
            Text = "Управление работой парсера";
            FormClosing += FormFinishStage_FormClosing;
            Load += FormFinishStage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private Button buttonStop;
        private ProgressBar progressBar1;
        private Button buttonQuit;
        private Label label1;
        private Label label2;
        private Label labelCount;
        private Button buttonBackStage;
        private Label label3;
        private Label label4;
        private Label labelFindCount;
        private Label label5;
        private Label labelStatus;
    }
}