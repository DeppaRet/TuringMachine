namespace TuringMachine
{
  partial class Form1
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
      this.PauseCalc = new System.Windows.Forms.Button();
      this.Output = new System.Windows.Forms.RichTextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.delayBox = new System.Windows.Forms.TextBox();
      this.Reset = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.CurrState = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.StepsCount = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.DoStep = new System.Windows.Forms.Button();
      this.OpenFile = new System.Windows.Forms.Button();
      this.StartProgram = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.BeginStatement = new System.Windows.Forms.TextBox();
      this.Confirm = new System.Windows.Forms.Button();
      this.ProgramText = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // PauseCalc
      // 
      this.PauseCalc.Location = new System.Drawing.Point(563, 355);
      this.PauseCalc.Name = "PauseCalc";
      this.PauseCalc.Size = new System.Drawing.Size(68, 23);
      this.PauseCalc.TabIndex = 35;
      this.PauseCalc.Text = "Пауза";
      this.PauseCalc.UseVisualStyleBackColor = true;
      this.PauseCalc.Click += new System.EventHandler(this.Pause_Click);
      // 
      // Output
      // 
      this.Output.BackColor = System.Drawing.Color.MistyRose;
      this.Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Output.Location = new System.Drawing.Point(13, 7);
      this.Output.Name = "Output";
      this.Output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
      this.Output.Size = new System.Drawing.Size(617, 34);
      this.Output.TabIndex = 34;
      this.Output.Text = "";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(436, 119);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(84, 13);
      this.label1.TabIndex = 33;
      this.label1.Text = "Задержка (мс):";
      // 
      // delayBox
      // 
      this.delayBox.Location = new System.Drawing.Point(573, 115);
      this.delayBox.Name = "delayBox";
      this.delayBox.Size = new System.Drawing.Size(57, 20);
      this.delayBox.TabIndex = 32;
      this.delayBox.Text = "50";
      // 
      // Reset
      // 
      this.Reset.Location = new System.Drawing.Point(563, 413);
      this.Reset.Name = "Reset";
      this.Reset.Size = new System.Drawing.Size(67, 23);
      this.Reset.TabIndex = 31;
      this.Reset.Text = "Сброс";
      this.Reset.UseVisualStyleBackColor = true;
      this.Reset.Click += new System.EventHandler(this.Reset_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(9, 44);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(102, 13);
      this.label5.TabIndex = 30;
      this.label5.Text = "Текст программы:";
      // 
      // CurrState
      // 
      this.CurrState.AutoSize = true;
      this.CurrState.Location = new System.Drawing.Point(437, 397);
      this.CurrState.Name = "CurrState";
      this.CurrState.Size = new System.Drawing.Size(13, 13);
      this.CurrState.TabIndex = 29;
      this.CurrState.Text = "0";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(436, 384);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(102, 13);
      this.label4.TabIndex = 28;
      this.label4.Text = "Текущая команда:";
      // 
      // StepsCount
      // 
      this.StepsCount.AutoSize = true;
      this.StepsCount.Location = new System.Drawing.Point(437, 371);
      this.StepsCount.Name = "StepsCount";
      this.StepsCount.Size = new System.Drawing.Size(13, 13);
      this.StepsCount.TabIndex = 27;
      this.StepsCount.Text = "0";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(436, 358);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(103, 13);
      this.label3.TabIndex = 26;
      this.label3.Text = "Количество шагов:";
      // 
      // DoStep
      // 
      this.DoStep.Location = new System.Drawing.Point(563, 384);
      this.DoStep.Name = "DoStep";
      this.DoStep.Size = new System.Drawing.Size(69, 23);
      this.DoStep.TabIndex = 25;
      this.DoStep.Text = "Шаг";
      this.DoStep.UseVisualStyleBackColor = true;
      this.DoStep.Click += new System.EventHandler(this.Step_Click);
      // 
      // OpenFile
      // 
      this.OpenFile.Location = new System.Drawing.Point(440, 413);
      this.OpenFile.Name = "OpenFile";
      this.OpenFile.Size = new System.Drawing.Size(117, 23);
      this.OpenFile.TabIndex = 24;
      this.OpenFile.Text = "Открыть файл";
      this.OpenFile.UseVisualStyleBackColor = true;
      this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
      // 
      // StartProgram
      // 
      this.StartProgram.Location = new System.Drawing.Point(563, 328);
      this.StartProgram.Name = "StartProgram";
      this.StartProgram.Size = new System.Drawing.Size(67, 23);
      this.StartProgram.TabIndex = 23;
      this.StartProgram.Text = "Запуск";
      this.StartProgram.UseVisualStyleBackColor = true;
      this.StartProgram.Click += new System.EventHandler(this.StartProgram_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(436, 43);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(121, 13);
      this.label2.TabIndex = 22;
      this.label2.Text = "Начальное состояние:";
      // 
      // BeginStatement
      // 
      this.BeginStatement.Location = new System.Drawing.Point(439, 60);
      this.BeginStatement.Name = "BeginStatement";
      this.BeginStatement.Size = new System.Drawing.Size(191, 20);
      this.BeginStatement.TabIndex = 21;
      this.BeginStatement.Text = "11#11111#11#111#11111";
      // 
      // Confirm
      // 
      this.Confirm.Location = new System.Drawing.Point(439, 86);
      this.Confirm.Name = "Confirm";
      this.Confirm.Size = new System.Drawing.Size(191, 23);
      this.Confirm.TabIndex = 20;
      this.Confirm.Text = "Принять";
      this.Confirm.UseVisualStyleBackColor = true;
      this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
      // 
      // ProgramText
      // 
      this.ProgramText.Location = new System.Drawing.Point(12, 60);
      this.ProgramText.Multiline = true;
      this.ProgramText.Name = "ProgramText";
      this.ProgramText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.ProgramText.Size = new System.Drawing.Size(418, 376);
      this.ProgramText.TabIndex = 19;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(642, 444);
      this.Controls.Add(this.PauseCalc);
      this.Controls.Add(this.Output);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.delayBox);
      this.Controls.Add(this.Reset);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.CurrState);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.StepsCount);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.DoStep);
      this.Controls.Add(this.OpenFile);
      this.Controls.Add(this.StartProgram);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.BeginStatement);
      this.Controls.Add(this.Confirm);
      this.Controls.Add(this.ProgramText);
      this.Name = "Form1";
      this.Text = "Turing";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button PauseCalc;
    private System.Windows.Forms.RichTextBox Output;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox delayBox;
    private System.Windows.Forms.Button Reset;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label CurrState;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label StepsCount;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button DoStep;
    private System.Windows.Forms.Button OpenFile;
    private System.Windows.Forms.Button StartProgram;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox BeginStatement;
    private System.Windows.Forms.Button Confirm;
    private System.Windows.Forms.TextBox ProgramText;
  }
}

