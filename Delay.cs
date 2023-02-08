using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HIDTester
{
  public class Delay : UserControl
  {
    private IContainer components;
    private NumericUpDown numericUpDown_Delay;
    private Label label1;
    private Label Key_Delay;

    public Delay()
    {
      this.InitializeComponent();
      this.numericUpDown_Delay.Minimum = 0M;
      this.numericUpDown_Delay.Maximum = 6000M;
    }

    private void DelayGeneral_Char_Set() => FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyType_Num] |= (byte) 5;

    private void numericUpDown_Delay_ValueChanged(object sender, EventArgs e)
    {
      int num = int.Parse(this.numericUpDown_Delay.Value.ToString());
      FormMain.KeyParam.Protocol2_Sd_Buff[4] = (byte) num;
      FormMain.KeyParam.Protocol2_Sd_Buff[5] = (byte) (num >> 8);
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.numericUpDown_Delay.Value.ToString();
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5 + 4] = "M";
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5 + 6] = "S";
      this.DelayGeneral_Char_Set();
    }

    private void numericUpDown_Delay_KeyUp(object sender, KeyEventArgs e)
    {
      int num = int.Parse(this.numericUpDown_Delay.Value.ToString());
      FormMain.KeyParam.Protocol2_Sd_Buff[4] = (byte) num;
      FormMain.KeyParam.Protocol2_Sd_Buff[5] = (byte) (num >> 8);
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.numericUpDown_Delay.Value.ToString();
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5 + 4] = "M";
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5 + 6] = "S";
      this.DelayGeneral_Char_Set();
    }

    private void Key_Delay_Click(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Delay));
      this.numericUpDown_Delay = new NumericUpDown();
      this.label1 = new Label();
      this.Key_Delay = new Label();
      this.numericUpDown_Delay.BeginInit();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.numericUpDown_Delay, "numericUpDown_Delay");
      this.numericUpDown_Delay.Name = "numericUpDown_Delay";
      this.numericUpDown_Delay.ValueChanged += new EventHandler(this.numericUpDown_Delay_ValueChanged);
      this.numericUpDown_Delay.KeyUp += new KeyEventHandler(this.numericUpDown_Delay_KeyUp);
      componentResourceManager.ApplyResources((object) this.label1, "label1");
      this.label1.Name = "label1";
      componentResourceManager.ApplyResources((object) this.Key_Delay, "Key_Delay");
      this.Key_Delay.Name = "Key_Delay";
      this.Key_Delay.Click += new EventHandler(this.Key_Delay_Click);
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.Key_Delay);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.numericUpDown_Delay);
      this.Name = nameof (Delay);
      this.numericUpDown_Delay.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
