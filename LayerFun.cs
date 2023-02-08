using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HIDTester
{
  public class LayerFun : UserControl
  {
    private IContainer components;
    private RadioButton KEY_Layer1;
    private RadioButton KEY_Layer2;
    private RadioButton KEY_Layer3;
    private RadioButton KEY_FunLayer1;
    private RadioButton KEY_FunLayer2;
    private RadioButton KEY_FunLayer3;

    public LayerFun() => this.InitializeComponent();

    private void KEY_FunLayer1_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.KEY_FunLayer1.Checked)
        return;
      FormMain.KeyParam.KEY_Cur_Layer = (byte) 1;
      FormMain.KeyParam.PageBet_Inte_Cmd = (byte) 1;
    }

    private void KEY_FunLayer2_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.KEY_FunLayer2.Checked)
        return;
      FormMain.KeyParam.KEY_Cur_Layer = (byte) 2;
      FormMain.KeyParam.PageBet_Inte_Cmd = (byte) 1;
    }

    private void KEY_FunLayer3_CheckedChanged(object sender, EventArgs e)
    {
      if (!this.KEY_FunLayer3.Checked)
        return;
      FormMain.KeyParam.KEY_Cur_Layer = (byte) 3;
      FormMain.KeyParam.PageBet_Inte_Cmd = (byte) 1;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (LayerFun));
      this.KEY_Layer1 = new RadioButton();
      this.KEY_Layer2 = new RadioButton();
      this.KEY_Layer3 = new RadioButton();
      this.KEY_FunLayer1 = new RadioButton();
      this.KEY_FunLayer2 = new RadioButton();
      this.KEY_FunLayer3 = new RadioButton();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.KEY_Layer1, "KEY_Layer1");
      this.KEY_Layer1.Name = "KEY_Layer1";
      componentResourceManager.ApplyResources((object) this.KEY_Layer2, "KEY_Layer2");
      this.KEY_Layer2.Name = "KEY_Layer2";
      componentResourceManager.ApplyResources((object) this.KEY_Layer3, "KEY_Layer3");
      this.KEY_Layer3.Name = "KEY_Layer3";
      componentResourceManager.ApplyResources((object) this.KEY_FunLayer1, "KEY_FunLayer1");
      this.KEY_FunLayer1.Checked = true;
      this.KEY_FunLayer1.Name = "KEY_FunLayer1";
      this.KEY_FunLayer1.TabStop = true;
      this.KEY_FunLayer1.UseVisualStyleBackColor = true;
      this.KEY_FunLayer1.CheckedChanged += new EventHandler(this.KEY_FunLayer1_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.KEY_FunLayer2, "KEY_FunLayer2");
      this.KEY_FunLayer2.Name = "KEY_FunLayer2";
      this.KEY_FunLayer2.TabStop = true;
      this.KEY_FunLayer2.UseVisualStyleBackColor = true;
      this.KEY_FunLayer2.CheckedChanged += new EventHandler(this.KEY_FunLayer2_CheckedChanged);
      componentResourceManager.ApplyResources((object) this.KEY_FunLayer3, "KEY_FunLayer3");
      this.KEY_FunLayer3.Name = "KEY_FunLayer3";
      this.KEY_FunLayer3.TabStop = true;
      this.KEY_FunLayer3.UseVisualStyleBackColor = true;
      this.KEY_FunLayer3.CheckedChanged += new EventHandler(this.KEY_FunLayer3_CheckedChanged);
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.KEY_FunLayer3);
      this.Controls.Add((Control) this.KEY_FunLayer2);
      this.Controls.Add((Control) this.KEY_FunLayer1);
      this.ForeColor = SystemColors.InactiveCaptionText;
      this.Name = nameof (LayerFun);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
