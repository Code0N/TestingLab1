namespace LakeOfSorrowProduction
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.rectangleTab = new System.Windows.Forms.TabPage();
            this.stringFormatterTab = new System.Windows.Forms.TabPage();
            this.arrayProcessorTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.tbx3 = new System.Windows.Forms.TextBox();
            this.tbx4 = new System.Windows.Forms.TextBox();
            this.tby4 = new System.Windows.Forms.TextBox();
            this.tby3 = new System.Windows.Forms.TextBox();
            this.tby2 = new System.Windows.Forms.TextBox();
            this.tby1 = new System.Windows.Forms.TextBox();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.rButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.pAnswerLabel = new System.Windows.Forms.Label();
            this.doItButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.doIt2Button = new System.Windows.Forms.Button();
            this.resultArLabel = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.rectangleTab.SuspendLayout();
            this.stringFormatterTab.SuspendLayout();
            this.arrayProcessorTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.rectangleTab);
            this.mainTabControl.Controls.Add(this.stringFormatterTab);
            this.mainTabControl.Controls.Add(this.arrayProcessorTab);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(487, 388);
            this.mainTabControl.TabIndex = 0;
            // 
            // rectangleTab
            // 
            this.rectangleTab.Controls.Add(this.rButton);
            this.rectangleTab.Controls.Add(this.AnswerLabel);
            this.rectangleTab.Controls.Add(this.tby4);
            this.rectangleTab.Controls.Add(this.tby3);
            this.rectangleTab.Controls.Add(this.tby2);
            this.rectangleTab.Controls.Add(this.tby1);
            this.rectangleTab.Controls.Add(this.tbx4);
            this.rectangleTab.Controls.Add(this.tbx3);
            this.rectangleTab.Controls.Add(this.tbx2);
            this.rectangleTab.Controls.Add(this.tbx1);
            this.rectangleTab.Controls.Add(this.label2);
            this.rectangleTab.Controls.Add(this.label1);
            this.rectangleTab.Location = new System.Drawing.Point(4, 22);
            this.rectangleTab.Name = "rectangleTab";
            this.rectangleTab.Padding = new System.Windows.Forms.Padding(3);
            this.rectangleTab.Size = new System.Drawing.Size(479, 362);
            this.rectangleTab.TabIndex = 0;
            this.rectangleTab.Text = "Класс Rectangle";
            this.rectangleTab.UseVisualStyleBackColor = true;
            // 
            // stringFormatterTab
            // 
            this.stringFormatterTab.Controls.Add(this.doItButton);
            this.stringFormatterTab.Controls.Add(this.pAnswerLabel);
            this.stringFormatterTab.Controls.Add(this.button1);
            this.stringFormatterTab.Controls.Add(this.label3);
            this.stringFormatterTab.Controls.Add(this.pathTextBox);
            this.stringFormatterTab.Location = new System.Drawing.Point(4, 22);
            this.stringFormatterTab.Name = "stringFormatterTab";
            this.stringFormatterTab.Padding = new System.Windows.Forms.Padding(3);
            this.stringFormatterTab.Size = new System.Drawing.Size(479, 362);
            this.stringFormatterTab.TabIndex = 1;
            this.stringFormatterTab.Text = "Класс StringFormatter";
            this.stringFormatterTab.UseVisualStyleBackColor = true;
            // 
            // arrayProcessorTab
            // 
            this.arrayProcessorTab.Controls.Add(this.resultArLabel);
            this.arrayProcessorTab.Controls.Add(this.doIt2Button);
            this.arrayProcessorTab.Controls.Add(this.label4);
            this.arrayProcessorTab.Location = new System.Drawing.Point(4, 22);
            this.arrayProcessorTab.Name = "arrayProcessorTab";
            this.arrayProcessorTab.Size = new System.Drawing.Size(479, 362);
            this.arrayProcessorTab.TabIndex = 2;
            this.arrayProcessorTab.Text = "Класс ArrayProcessor";
            this.arrayProcessorTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Координаты X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Координаты Y";
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(34, 52);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(100, 20);
            this.tbx1.TabIndex = 2;
            // 
            // tbx2
            // 
            this.tbx2.Location = new System.Drawing.Point(34, 88);
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(100, 20);
            this.tbx2.TabIndex = 3;
            // 
            // tbx3
            // 
            this.tbx3.Location = new System.Drawing.Point(34, 123);
            this.tbx3.Name = "tbx3";
            this.tbx3.Size = new System.Drawing.Size(100, 20);
            this.tbx3.TabIndex = 4;
            // 
            // tbx4
            // 
            this.tbx4.Location = new System.Drawing.Point(34, 159);
            this.tbx4.Name = "tbx4";
            this.tbx4.Size = new System.Drawing.Size(100, 20);
            this.tbx4.TabIndex = 5;
            // 
            // tby4
            // 
            this.tby4.Location = new System.Drawing.Point(297, 159);
            this.tby4.Name = "tby4";
            this.tby4.Size = new System.Drawing.Size(100, 20);
            this.tby4.TabIndex = 9;
            // 
            // tby3
            // 
            this.tby3.Location = new System.Drawing.Point(297, 123);
            this.tby3.Name = "tby3";
            this.tby3.Size = new System.Drawing.Size(100, 20);
            this.tby3.TabIndex = 8;
            // 
            // tby2
            // 
            this.tby2.Location = new System.Drawing.Point(297, 88);
            this.tby2.Name = "tby2";
            this.tby2.Size = new System.Drawing.Size(100, 20);
            this.tby2.TabIndex = 7;
            // 
            // tby1
            // 
            this.tby1.Location = new System.Drawing.Point(297, 52);
            this.tby1.Name = "tby1";
            this.tby1.Size = new System.Drawing.Size(100, 20);
            this.tby1.TabIndex = 6;
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerLabel.Location = new System.Drawing.Point(186, 218);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(89, 25);
            this.AnswerLabel.TabIndex = 10;
            this.AnswerLabel.Text = "Answer";
            // 
            // rButton
            // 
            this.rButton.Location = new System.Drawing.Point(191, 285);
            this.rButton.Name = "rButton";
            this.rButton.Size = new System.Drawing.Size(75, 23);
            this.rButton.TabIndex = 12;
            this.rButton.Text = "Расчитать";
            this.rButton.UseVisualStyleBackColor = true;
            this.rButton.Click += new System.EventHandler(this.rButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(52, 61);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(354, 20);
            this.pathTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Путь";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pAnswerLabel
            // 
            this.pAnswerLabel.AutoSize = true;
            this.pAnswerLabel.Location = new System.Drawing.Point(76, 103);
            this.pAnswerLabel.Name = "pAnswerLabel";
            this.pAnswerLabel.Size = new System.Drawing.Size(29, 13);
            this.pAnswerLabel.TabIndex = 3;
            this.pAnswerLabel.Text = "Path";
            // 
            // doItButton
            // 
            this.doItButton.Location = new System.Drawing.Point(412, 58);
            this.doItButton.Name = "doItButton";
            this.doItButton.Size = new System.Drawing.Size(54, 23);
            this.doItButton.TabIndex = 4;
            this.doItButton.Text = "DO IT!";
            this.doItButton.UseVisualStyleBackColor = true;
            this.doItButton.Click += new System.EventHandler(this.doItButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(469, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ввода пользователем не будет";
            // 
            // doIt2Button
            // 
            this.doIt2Button.Location = new System.Drawing.Point(199, 108);
            this.doIt2Button.Name = "doIt2Button";
            this.doIt2Button.Size = new System.Drawing.Size(75, 23);
            this.doIt2Button.TabIndex = 1;
            this.doIt2Button.Text = "Сделать";
            this.doIt2Button.UseVisualStyleBackColor = true;
            this.doIt2Button.Click += new System.EventHandler(this.doIt2Button_Click);
            // 
            // resultArLabel
            // 
            this.resultArLabel.AutoSize = true;
            this.resultArLabel.Location = new System.Drawing.Point(23, 183);
            this.resultArLabel.Name = "resultArLabel";
            this.resultArLabel.Size = new System.Drawing.Size(59, 13);
            this.resultArLabel.TabIndex = 2;
            this.resultArLabel.Text = "Результат";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 388);
            this.Controls.Add(this.mainTabControl);
            this.Name = "mainForm";
            this.Text = "Лаб. 1 ИВТ-7 Плыско Игорь";
            this.mainTabControl.ResumeLayout(false);
            this.rectangleTab.ResumeLayout(false);
            this.rectangleTab.PerformLayout();
            this.stringFormatterTab.ResumeLayout(false);
            this.stringFormatterTab.PerformLayout();
            this.arrayProcessorTab.ResumeLayout(false);
            this.arrayProcessorTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage rectangleTab;
        private System.Windows.Forms.TabPage stringFormatterTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage arrayProcessorTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tby4;
        private System.Windows.Forms.TextBox tby3;
        private System.Windows.Forms.TextBox tby2;
        private System.Windows.Forms.TextBox tby1;
        private System.Windows.Forms.TextBox tbx4;
        private System.Windows.Forms.TextBox tbx3;
        private System.Windows.Forms.TextBox tbx2;
        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.Button rButton;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button doItButton;
        private System.Windows.Forms.Label pAnswerLabel;
        private System.Windows.Forms.Label resultArLabel;
        private System.Windows.Forms.Button doIt2Button;
        private System.Windows.Forms.Label label4;
    }
}

