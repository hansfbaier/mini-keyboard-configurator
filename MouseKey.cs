using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HIDTester
{
  public class MouseKey : UserControl
  {
    private IContainer components;
    private Button KEY_Mouse_Left;
    private Button KEY_Mouse_Right;
    private Button KEY_Mouse_Centre;
    private Button KEY_MOUSE_WHEEL_ADD;
    private Button KEY_MOUSE_WHEEL_SUB;
    private Button Ctrl_Mouse_wheel_Up;
    private Button Ctrl_Mouse_wheel_Down;
    private Button Shift_Mouse_wheel_Up;
    private Button Shift_Mouse_wheel_Down;
    private Button Alt_Mouse_wheel_Up;
    private Button Alt_Mouse_wheel_Down;

    public MouseKey() => this.InitializeComponent();

    private void KEY_Colour_Init()
    {
      int red = 152;
      int green = 251;
      int blue = 152;
      this.KEY_Mouse_Left.BackColor = Color.FromArgb(red, green, blue);
      this.KEY_Mouse_Centre.BackColor = Color.FromArgb(red, green, blue);
      this.KEY_Mouse_Right.BackColor = Color.FromArgb(red, green, blue);
      this.KEY_MOUSE_WHEEL_ADD.BackColor = Color.FromArgb(red, green, blue);
      this.KEY_MOUSE_WHEEL_SUB.BackColor = Color.FromArgb(red, green, blue);
    }

    private void MouseGeneral_Char_Set() => FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyType_Num] |= (byte) 3;

    private void KEY_Mouse_Left_Click(object sender, EventArgs e)
    {
      this.MouseGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 1;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 1] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 2] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 3] = (byte) 0;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Mouse_Left.Text;
    }

    private void KEY_Mouse_Centre_Click(object sender, EventArgs e)
    {
      this.MouseGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 4;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 1] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 2] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 3] = (byte) 0;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Mouse_Centre.Text;
    }

    private void KEY_Mouse_Right_Click(object sender, EventArgs e)
    {
      this.MouseGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 2;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 1] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 2] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 3] = (byte) 0;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Mouse_Right.Text;
    }

    private void KEY_MOUSE_WHEEL_ADD_Click(object sender, EventArgs e)
    {
      this.MouseGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 1] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 2] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 3] = (byte) 1;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_MOUSE_WHEEL_ADD.Text;
    }

    private void KEY_MOUSE_WHEEL_SUB_Click(object sender, EventArgs e)
    {
      this.MouseGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 1] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 2] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 3] = byte.MaxValue;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_MOUSE_WHEEL_SUB.Text;
    }

    private void Ctrl_Mouse_wheel_Up_Click(object sender, EventArgs e)
    {
      this.MouseGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 1] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 2] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 3] = (byte) 1;
      if (FormMain.KeyParam.New_Mul_Mouse == (byte) 1)
        FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] = (byte) 1;
      else
        FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 4] = (byte) 1;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.Ctrl_Mouse_wheel_Up.Text;
    }

    private void Ctrl_Mouse_wheel_Down_Click(object sender, EventArgs e)
    {
      this.MouseGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 1] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 2] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 3] = byte.MaxValue;
      if (FormMain.KeyParam.New_Mul_Mouse == (byte) 1)
        FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] = (byte) 1;
      else
        FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 4] = (byte) 1;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.Ctrl_Mouse_wheel_Down.Text;
    }

    private void Shift_Mouse_wheel_Up_Click(object sender, EventArgs e)
    {
      this.MouseGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 1] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 2] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 3] = (byte) 1;
      if (FormMain.KeyParam.New_Mul_Mouse == (byte) 1)
        FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] = (byte) 2;
      else
        FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 4] = (byte) 2;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.Shift_Mouse_wheel_Up.Text;
    }

    private void Shift_Mouse_wheel_Down_Click(object sender, EventArgs e)
    {
      this.MouseGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 1] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 2] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 3] = byte.MaxValue;
      if (FormMain.KeyParam.New_Mul_Mouse == (byte) 1)
        FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] = (byte) 2;
      else
        FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 4] = (byte) 2;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.Shift_Mouse_wheel_Down.Text;
    }

    private void Alt_Mouse_wheel_Up_Click(object sender, EventArgs e)
    {
      this.MouseGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 1] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 2] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 3] = (byte) 1;
      if (FormMain.KeyParam.New_Mul_Mouse == (byte) 1)
        FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] = (byte) 4;
      else
        FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 4] = (byte) 4;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.Alt_Mouse_wheel_Up.Text;
    }

    private void Alt_Mouse_wheel_Down_Click(object sender, EventArgs e)
    {
      this.MouseGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 1] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 2] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 3] = byte.MaxValue;
      if (FormMain.KeyParam.New_Mul_Mouse == (byte) 1)
        FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] = (byte) 4;
      else
        FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 4] = (byte) 4;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.Alt_Mouse_wheel_Down.Text;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MouseKey));
      this.KEY_Mouse_Left = new Button();
      this.KEY_Mouse_Right = new Button();
      this.KEY_Mouse_Centre = new Button();
      this.KEY_MOUSE_WHEEL_ADD = new Button();
      this.KEY_MOUSE_WHEEL_SUB = new Button();
      this.Ctrl_Mouse_wheel_Up = new Button();
      this.Ctrl_Mouse_wheel_Down = new Button();
      this.Shift_Mouse_wheel_Up = new Button();
      this.Shift_Mouse_wheel_Down = new Button();
      this.Alt_Mouse_wheel_Up = new Button();
      this.Alt_Mouse_wheel_Down = new Button();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.KEY_Mouse_Left, "KEY_Mouse_Left");
      this.KEY_Mouse_Left.Name = "KEY_Mouse_Left";
      this.KEY_Mouse_Left.UseVisualStyleBackColor = true;
      this.KEY_Mouse_Left.Click += new EventHandler(this.KEY_Mouse_Left_Click);
      componentResourceManager.ApplyResources((object) this.KEY_Mouse_Right, "KEY_Mouse_Right");
      this.KEY_Mouse_Right.Name = "KEY_Mouse_Right";
      this.KEY_Mouse_Right.UseVisualStyleBackColor = true;
      this.KEY_Mouse_Right.Click += new EventHandler(this.KEY_Mouse_Right_Click);
      componentResourceManager.ApplyResources((object) this.KEY_Mouse_Centre, "KEY_Mouse_Centre");
      this.KEY_Mouse_Centre.Name = "KEY_Mouse_Centre";
      this.KEY_Mouse_Centre.UseVisualStyleBackColor = true;
      this.KEY_Mouse_Centre.Click += new EventHandler(this.KEY_Mouse_Centre_Click);
      componentResourceManager.ApplyResources((object) this.KEY_MOUSE_WHEEL_ADD, "KEY_MOUSE_WHEEL_ADD");
      this.KEY_MOUSE_WHEEL_ADD.Name = "KEY_MOUSE_WHEEL_ADD";
      this.KEY_MOUSE_WHEEL_ADD.UseVisualStyleBackColor = true;
      this.KEY_MOUSE_WHEEL_ADD.Click += new EventHandler(this.KEY_MOUSE_WHEEL_ADD_Click);
      componentResourceManager.ApplyResources((object) this.KEY_MOUSE_WHEEL_SUB, "KEY_MOUSE_WHEEL_SUB");
      this.KEY_MOUSE_WHEEL_SUB.Name = "KEY_MOUSE_WHEEL_SUB";
      this.KEY_MOUSE_WHEEL_SUB.UseVisualStyleBackColor = true;
      this.KEY_MOUSE_WHEEL_SUB.Click += new EventHandler(this.KEY_MOUSE_WHEEL_SUB_Click);
      componentResourceManager.ApplyResources((object) this.Ctrl_Mouse_wheel_Up, "Ctrl_Mouse_wheel_Up");
      this.Ctrl_Mouse_wheel_Up.Name = "Ctrl_Mouse_wheel_Up";
      this.Ctrl_Mouse_wheel_Up.Click += new EventHandler(this.Ctrl_Mouse_wheel_Up_Click);
      componentResourceManager.ApplyResources((object) this.Ctrl_Mouse_wheel_Down, "Ctrl_Mouse_wheel_Down");
      this.Ctrl_Mouse_wheel_Down.Name = "Ctrl_Mouse_wheel_Down";
      this.Ctrl_Mouse_wheel_Down.Click += new EventHandler(this.Ctrl_Mouse_wheel_Down_Click);
      componentResourceManager.ApplyResources((object) this.Shift_Mouse_wheel_Up, "Shift_Mouse_wheel_Up");
      this.Shift_Mouse_wheel_Up.Name = "Shift_Mouse_wheel_Up";
      this.Shift_Mouse_wheel_Up.Click += new EventHandler(this.Shift_Mouse_wheel_Up_Click);
      componentResourceManager.ApplyResources((object) this.Shift_Mouse_wheel_Down, "Shift_Mouse_wheel_Down");
      this.Shift_Mouse_wheel_Down.Name = "Shift_Mouse_wheel_Down";
      this.Shift_Mouse_wheel_Down.Click += new EventHandler(this.Shift_Mouse_wheel_Down_Click);
      componentResourceManager.ApplyResources((object) this.Alt_Mouse_wheel_Up, "Alt_Mouse_wheel_Up");
      this.Alt_Mouse_wheel_Up.Name = "Alt_Mouse_wheel_Up";
      this.Alt_Mouse_wheel_Up.Click += new EventHandler(this.Alt_Mouse_wheel_Up_Click);
      componentResourceManager.ApplyResources((object) this.Alt_Mouse_wheel_Down, "Alt_Mouse_wheel_Down");
      this.Alt_Mouse_wheel_Down.Name = "Alt_Mouse_wheel_Down";
      this.Alt_Mouse_wheel_Down.Click += new EventHandler(this.Alt_Mouse_wheel_Down_Click);
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.Alt_Mouse_wheel_Down);
      this.Controls.Add((Control) this.Alt_Mouse_wheel_Up);
      this.Controls.Add((Control) this.Shift_Mouse_wheel_Down);
      this.Controls.Add((Control) this.Shift_Mouse_wheel_Up);
      this.Controls.Add((Control) this.Ctrl_Mouse_wheel_Down);
      this.Controls.Add((Control) this.Ctrl_Mouse_wheel_Up);
      this.Controls.Add((Control) this.KEY_MOUSE_WHEEL_SUB);
      this.Controls.Add((Control) this.KEY_MOUSE_WHEEL_ADD);
      this.Controls.Add((Control) this.KEY_Mouse_Centre);
      this.Controls.Add((Control) this.KEY_Mouse_Right);
      this.Controls.Add((Control) this.KEY_Mouse_Left);
      this.Name = nameof (MouseKey);
      this.ResumeLayout(false);
    }
  }
}
