
namespace WindowsFormsClient
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
      this.components = new System.ComponentModel.Container();
      this.SendButton = new System.Windows.Forms.Button();
      this.MessagesLB = new System.Windows.Forms.ListBox();
      this.UserNameTB = new System.Windows.Forms.TextBox();
      this.MessagesTB = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // SendButton
      // 
      this.SendButton.Location = new System.Drawing.Point(647, 376);
      this.SendButton.Name = "SendButton";
      this.SendButton.Size = new System.Drawing.Size(141, 62);
      this.SendButton.TabIndex = 0;
      this.SendButton.Text = "Отправить";
      this.SendButton.UseVisualStyleBackColor = true;
      this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
      // 
      // MessagesLB
      // 
      this.MessagesLB.FormattingEnabled = true;
      this.MessagesLB.Location = new System.Drawing.Point(12, 12);
      this.MessagesLB.Name = "MessagesLB";
      this.MessagesLB.Size = new System.Drawing.Size(776, 329);
      this.MessagesLB.TabIndex = 1;
      // 
      // UserNameTB
      // 
      this.UserNameTB.Location = new System.Drawing.Point(12, 376);
      this.UserNameTB.Name = "UserNameTB";
      this.UserNameTB.Size = new System.Drawing.Size(394, 20);
      this.UserNameTB.TabIndex = 2;
      // 
      // MessagesTB
      // 
      this.MessagesTB.Location = new System.Drawing.Point(12, 418);
      this.MessagesTB.Name = "MessagesTB";
      this.MessagesTB.Size = new System.Drawing.Size(468, 20);
      this.MessagesTB.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 360);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "label1";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 402);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "label2";
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.MessagesTB);
      this.Controls.Add(this.UserNameTB);
      this.Controls.Add(this.MessagesLB);
      this.Controls.Add(this.SendButton);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button SendButton;
    private System.Windows.Forms.ListBox MessagesLB;
    private System.Windows.Forms.TextBox UserNameTB;
    private System.Windows.Forms.TextBox MessagesTB;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Timer timer1;
  }
}

