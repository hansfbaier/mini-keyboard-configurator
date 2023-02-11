using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HIDTester
{
  public class FunKey : UserControl
  {
    private IContainer components;
    private Button KEY_Ctrl_left;
    private Button KEY_Shift_left;
    private Button KEY_ALT_Left;
    private Button KEY_ALT_Right;
    private Button KEY_Shift_right;
    private Button KEY_Ctrl_Right;
    private Button KEY_Win_left;
    private Button KEY_Win_Right;
    private Button KEY_ctrl_alt;
    private Button KEY_Ctrl_Shift;
    private Button KEY_Alt_Shift;
    private Button KEY_Ctrl_Shift_Alt;
    private Button KEY_Ctrl_Alt_Win;
    private Button KEY_Shift_Win;
    private Button KEY_Ctrl_Alt_Shift_Win;
    private Button KEY_Shift_And_1;
    private Button KEY_Shift_And_2;
    private Button KEY_Shift_And_3;
    private Button KEY_Shift_And_4;
    private Button KEY_Shift_And_5;
    private Button KEY_Shift_And_6;
    private Button KEY_Shift_And_7;
    private Button KEY_Shift_And_8;
    private Button KEY_Shift_And_9;
    private Button KEY_Shift_And_10;
    private Button KEY_Shift_And_11;
    private Button KEY_Shift_And_12;
    private Button KEY_Shift_And_13;
    private Button KEY_Shift_And_14;
    private Button KEY_Shift_And_15;
    private Button KEY_Shift_And_16;
    private Button KEY_Shift_And_17;
    private Button KEY_Shift_And_18;
    private Button KEY_Shift_And_19;
    private Button KEY_Shift_And_20;
    private Button KEY_Shift_And_21;

    public FunKey() => this.InitializeComponent();

    private void FunGeneral_Char_Set()
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyType_Num] |= (byte) 1;
      ++FormMain.KeyParam.FunKEY_Char_Num;
    }

    private void KEY_Ctrl_left_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 1;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Ctrl";
      this.FunGeneral_Char_Set();
    }

    private void KEY_Shift_left_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 2;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Shift";
      this.FunGeneral_Char_Set();
    }

    private void KEY_ALT_Left_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 4;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Alt";
      this.FunGeneral_Char_Set();
    }

    private void KEY_Win_left_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 8;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Win";
      this.FunGeneral_Char_Set();
    }

    private void KEY_Ctrl_Right_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 16;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Ctrl";
      this.FunGeneral_Char_Set();
    }

    private void KEY_Shift_right_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 32;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Shift";
      this.FunGeneral_Char_Set();
    }

    private void KEY_ALT_Right_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 64;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Alt";
      this.FunGeneral_Char_Set();
    }

    private void KEY_Win_Right_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 128;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Win";
      this.FunGeneral_Char_Set();
    }

    private void KEY_ctrl_alt_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 1;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Ctrl";
      this.FunGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 4;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Alt";
      this.FunGeneral_Char_Set();
    }

    private void KEY_Ctrl_Shift_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 1;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Ctrl";
      this.FunGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 2;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Shift";
      this.FunGeneral_Char_Set();
    }

    private void KEY_Alt_Shift_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 4;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Alt";
      this.FunGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 2;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Shift";
      this.FunGeneral_Char_Set();
    }

    private void KEY_Shift_Win_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 2;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Shift";
      this.FunGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 8;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Win";
      this.FunGeneral_Char_Set();
    }

    private void KEY_Ctrl_Shift_Alt_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 1;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Ctrl";
      this.FunGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 2;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Shift";
      this.FunGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 4;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Alt";
      this.FunGeneral_Char_Set();
    }

    private void KEY_Ctrl_Alt_Win_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 1;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Ctrl";
      this.FunGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 4;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Alt";
      this.FunGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 8;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Win";
      this.FunGeneral_Char_Set();
    }

    private void KEY_Ctrl_Alt_Shift_Win_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 1;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Ctrl";
      this.FunGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 4;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Alt";
      this.FunGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 2;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Shift";
      this.FunGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 8;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Win";
      this.FunGeneral_Char_Set();
    }

    private void ShiftGeneral_Char_Set()
    {
      if (FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] != (byte) 0)
        FormMain.KeyParam.KEY_Char_Num += (byte) 2;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 2;
    }

    private void ShiftGeneral_Char_Set2()
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyType_Num] |= (byte) 1;
      FormMain.KeyParam.KEY_Char_Num += (byte) 2;
      ++FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyGroupCharNum];
      ++FormMain.KeyParam.FunKEY_Char_Num;
    }

    private void KEY_Shift_And_1_Click(object sender, EventArgs e)
    {
      this.ShiftGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 53;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Shift_And_1.Text;
      this.ShiftGeneral_Char_Set2();
    }

    private void KEY_Shift_And_2_Click(object sender, EventArgs e)
    {
      this.ShiftGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 30;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Shift_And_2.Text;
      this.ShiftGeneral_Char_Set2();
    }

    private void KEY_Shift_And_3_Click(object sender, EventArgs e)
    {
      this.ShiftGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 31;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Shift_And_3.Text;
      this.ShiftGeneral_Char_Set2();
    }

    private void KEY_Shift_And_4_Click(object sender, EventArgs e)
    {
      this.ShiftGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 32;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Shift_And_4.Text;
      this.ShiftGeneral_Char_Set2();
    }

    private void KEY_Shift_And_5_Click(object sender, EventArgs e)
    {
      this.ShiftGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 33;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Shift_And_5.Text;
      this.ShiftGeneral_Char_Set2();
    }

    private void KEY_Shift_And_6_Click(object sender, EventArgs e)
    {
      this.ShiftGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 34;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Shift_And_6.Text;
      this.ShiftGeneral_Char_Set2();
    }

    private void KEY_Shift_And_7_Click(object sender, EventArgs e)
    {
      this.ShiftGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 35;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Shift_And_7.Text;
      this.ShiftGeneral_Char_Set2();
    }

    private void KEY_Shift_And_8_Click(object sender, EventArgs e)
    {
      this.ShiftGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 36;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Shift_And_8.Text;
      this.ShiftGeneral_Char_Set2();
    }

    private void KEY_Shift_And_9_Click(object sender, EventArgs e)
    {
      this.ShiftGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 37;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Shift_And_9.Text;
      this.ShiftGeneral_Char_Set2();
    }

    private void KEY_Shift_And_10_Click(object sender, EventArgs e)
    {
      this.ShiftGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 38;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Shift_And_10.Text;
      this.ShiftGeneral_Char_Set2();
    }

    private void KEY_Shift_And_11_Click(object sender, EventArgs e)
    {
      this.ShiftGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 39;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Shift_And_11.Text;
      this.ShiftGeneral_Char_Set2();
    }

    private void KEY_Shift_And_12_Click(object sender, EventArgs e)
    {
      this.ShiftGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 45;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Shift_And_12.Text;
      this.ShiftGeneral_Char_Set2();
    }

    private void KEY_Shift_And_13_Click(object sender, EventArgs e)
    {
      this.ShiftGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 46;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Shift_And_13.Text;
      this.ShiftGeneral_Char_Set2();
    }

    private void KEY_Shift_And_14_Click(object sender, EventArgs e)
    {
      this.ShiftGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 47;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Shift_And_14.Text;
      this.ShiftGeneral_Char_Set2();
    }

    private void KEY_Shift_And_15_Click(object sender, EventArgs e)
    {
      this.ShiftGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 48;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Shift_And_15.Text;
      this.ShiftGeneral_Char_Set2();
    }

    private void KEY_Shift_And_16_Click(object sender, EventArgs e)
    {
      this.ShiftGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 49;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Shift_And_16.Text;
      this.ShiftGeneral_Char_Set2();
    }

    private void KEY_Shift_And_17_Click(object sender, EventArgs e)
    {
      this.ShiftGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 51;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Shift_And_17.Text;
      this.ShiftGeneral_Char_Set2();
    }

    private void KEY_Shift_And_18_Click(object sender, EventArgs e)
    {
      this.ShiftGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 52;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Shift_And_18.Text;
      this.ShiftGeneral_Char_Set2();
    }

    private void KEY_Shift_And_19_Click(object sender, EventArgs e)
    {
      this.ShiftGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 54;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Shift_And_19.Text;
      this.ShiftGeneral_Char_Set2();
    }

    private void KEY_Shift_And_20_Click(object sender, EventArgs e)
    {
      this.ShiftGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 55;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Shift_And_20.Text;
      this.ShiftGeneral_Char_Set2();
    }

    private void KEY_Shift_And_21_Click(object sender, EventArgs e)
    {
      this.ShiftGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 56;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Shift_And_21.Text;
      this.ShiftGeneral_Char_Set2();
    }

    private void FunKey_Load(object sender, EventArgs e)
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
      this.KEY_Ctrl_left = new Button();
      this.KEY_Shift_left = new Button();
      this.KEY_ALT_Left = new Button();
      this.KEY_ALT_Right = new Button();
      this.KEY_Shift_right = new Button();
      this.KEY_Ctrl_Right = new Button();
      this.KEY_Win_left = new Button();
      this.KEY_Win_Right = new Button();
      this.KEY_ctrl_alt = new Button();
      this.KEY_Ctrl_Shift = new Button();
      this.KEY_Alt_Shift = new Button();
      this.KEY_Ctrl_Shift_Alt = new Button();
      this.KEY_Ctrl_Alt_Win = new Button();
      this.KEY_Shift_Win = new Button();
      this.KEY_Ctrl_Alt_Shift_Win = new Button();
      this.KEY_Shift_And_1 = new Button();
      this.KEY_Shift_And_2 = new Button();
      this.KEY_Shift_And_3 = new Button();
      this.KEY_Shift_And_4 = new Button();
      this.KEY_Shift_And_5 = new Button();
      this.KEY_Shift_And_6 = new Button();
      this.KEY_Shift_And_7 = new Button();
      this.KEY_Shift_And_8 = new Button();
      this.KEY_Shift_And_9 = new Button();
      this.KEY_Shift_And_10 = new Button();
      this.KEY_Shift_And_11 = new Button();
      this.KEY_Shift_And_12 = new Button();
      this.KEY_Shift_And_13 = new Button();
      this.KEY_Shift_And_14 = new Button();
      this.KEY_Shift_And_15 = new Button();
      this.KEY_Shift_And_16 = new Button();
      this.KEY_Shift_And_17 = new Button();
      this.KEY_Shift_And_18 = new Button();
      this.KEY_Shift_And_19 = new Button();
      this.KEY_Shift_And_20 = new Button();
      this.KEY_Shift_And_21 = new Button();
      this.SuspendLayout();
      this.KEY_Ctrl_left.Location = new Point(3, 3);
      this.KEY_Ctrl_left.Name = "KEY_Ctrl_left";
      this.KEY_Ctrl_left.Size = new Size(94, 23);
      this.KEY_Ctrl_left.TabIndex = 69;
      this.KEY_Ctrl_left.Text = "Ctrl+";
      this.KEY_Ctrl_left.UseVisualStyleBackColor = true;
      this.KEY_Ctrl_left.Click += new EventHandler(this.KEY_Ctrl_left_Click);
      this.KEY_Shift_left.Location = new Point(206, 3);
      this.KEY_Shift_left.Name = "KEY_Shift_left";
      this.KEY_Shift_left.Size = new Size(97, 23);
      this.KEY_Shift_left.TabIndex = 70;
      this.KEY_Shift_left.Text = "Shift+";
      this.KEY_Shift_left.UseVisualStyleBackColor = true;
      this.KEY_Shift_left.Click += new EventHandler(this.KEY_Shift_left_Click);
      this.KEY_ALT_Left.Location = new Point(103, 3);
      this.KEY_ALT_Left.Name = "KEY_ALT_Left";
      this.KEY_ALT_Left.Size = new Size(97, 23);
      this.KEY_ALT_Left.TabIndex = 71;
      this.KEY_ALT_Left.Text = "Alt+";
      this.KEY_ALT_Left.UseVisualStyleBackColor = true;
      this.KEY_ALT_Left.Click += new EventHandler(this.KEY_ALT_Left_Click);
      this.KEY_ALT_Right.Location = new Point(103, 32);
      this.KEY_ALT_Right.Name = "KEY_ALT_Right";
      this.KEY_ALT_Right.Size = new Size(97, 23);
      this.KEY_ALT_Right.TabIndex = 72;
      this.KEY_ALT_Right.Text = "Right Alt+";
      this.KEY_ALT_Right.UseVisualStyleBackColor = true;
      this.KEY_ALT_Right.Click += new EventHandler(this.KEY_ALT_Right_Click);
      this.KEY_Shift_right.Location = new Point(206, 32);
      this.KEY_Shift_right.Name = "KEY_Shift_right";
      this.KEY_Shift_right.Size = new Size(97, 23);
      this.KEY_Shift_right.TabIndex = 73;
      this.KEY_Shift_right.Text = "Right Shift+";
      this.KEY_Shift_right.UseVisualStyleBackColor = true;
      this.KEY_Shift_right.Click += new EventHandler(this.KEY_Shift_right_Click);
      this.KEY_Ctrl_Right.Location = new Point(3, 32);
      this.KEY_Ctrl_Right.Name = "KEY_Ctrl_Right";
      this.KEY_Ctrl_Right.Size = new Size(94, 23);
      this.KEY_Ctrl_Right.TabIndex = 74;
      this.KEY_Ctrl_Right.Text = "Right  Ctrl+";
      this.KEY_Ctrl_Right.UseVisualStyleBackColor = true;
      this.KEY_Ctrl_Right.Click += new EventHandler(this.KEY_Ctrl_Right_Click);
      this.KEY_Win_left.Location = new Point(309, 3);
      this.KEY_Win_left.Name = "KEY_Win_left";
      this.KEY_Win_left.Size = new Size(88, 23);
      this.KEY_Win_left.TabIndex = 75;
      this.KEY_Win_left.Text = "Win+";
      this.KEY_Win_left.UseVisualStyleBackColor = true;
      this.KEY_Win_left.Click += new EventHandler(this.KEY_Win_left_Click);
      this.KEY_Win_Right.Location = new Point(309, 32);
      this.KEY_Win_Right.Name = "KEY_Win_Right";
      this.KEY_Win_Right.Size = new Size(88, 23);
      this.KEY_Win_Right.TabIndex = 76;
      this.KEY_Win_Right.Text = "Right Win+";
      this.KEY_Win_Right.UseVisualStyleBackColor = true;
      this.KEY_Win_Right.Click += new EventHandler(this.KEY_Win_Right_Click);
      this.KEY_ctrl_alt.Location = new Point(3, 61);
      this.KEY_ctrl_alt.Name = "KEY_ctrl_alt";
      this.KEY_ctrl_alt.Size = new Size(94, 23);
      this.KEY_ctrl_alt.TabIndex = 77;
      this.KEY_ctrl_alt.Text = "Ctrl+Alt+";
      this.KEY_ctrl_alt.UseVisualStyleBackColor = true;
      this.KEY_ctrl_alt.Click += new EventHandler(this.KEY_ctrl_alt_Click);
      this.KEY_Ctrl_Shift.Location = new Point(106, 61);
      this.KEY_Ctrl_Shift.Name = "KEY_Ctrl_Shift";
      this.KEY_Ctrl_Shift.Size = new Size(94, 23);
      this.KEY_Ctrl_Shift.TabIndex = 78;
      this.KEY_Ctrl_Shift.Text = "Ctrl+Shift+";
      this.KEY_Ctrl_Shift.UseVisualStyleBackColor = true;
      this.KEY_Ctrl_Shift.Click += new EventHandler(this.KEY_Ctrl_Shift_Click);
      this.KEY_Alt_Shift.Location = new Point(206, 61);
      this.KEY_Alt_Shift.Name = "KEY_Alt_Shift";
      this.KEY_Alt_Shift.Size = new Size(97, 23);
      this.KEY_Alt_Shift.TabIndex = 79;
      this.KEY_Alt_Shift.Text = "Alt+Shift+";
      this.KEY_Alt_Shift.UseVisualStyleBackColor = true;
      this.KEY_Alt_Shift.Click += new EventHandler(this.KEY_Alt_Shift_Click);
      this.KEY_Ctrl_Shift_Alt.Location = new Point(3, 90);
      this.KEY_Ctrl_Shift_Alt.Name = "KEY_Ctrl_Shift_Alt";
      this.KEY_Ctrl_Shift_Alt.Size = new Size(197, 23);
      this.KEY_Ctrl_Shift_Alt.TabIndex = 80;
      this.KEY_Ctrl_Shift_Alt.Text = "Ctrl+Shift+Alt+";
      this.KEY_Ctrl_Shift_Alt.UseVisualStyleBackColor = true;
      this.KEY_Ctrl_Shift_Alt.Click += new EventHandler(this.KEY_Ctrl_Shift_Alt_Click);
      this.KEY_Ctrl_Alt_Win.Location = new Point(206, 90);
      this.KEY_Ctrl_Alt_Win.Name = "KEY_Ctrl_Alt_Win";
      this.KEY_Ctrl_Alt_Win.Size = new Size(191, 23);
      this.KEY_Ctrl_Alt_Win.TabIndex = 81;
      this.KEY_Ctrl_Alt_Win.Text = "Ctrl+Alt+Win+";
      this.KEY_Ctrl_Alt_Win.UseVisualStyleBackColor = true;
      this.KEY_Ctrl_Alt_Win.Click += new EventHandler(this.KEY_Ctrl_Alt_Win_Click);
      this.KEY_Shift_Win.Location = new Point(309, 61);
      this.KEY_Shift_Win.Name = "KEY_Shift_Win";
      this.KEY_Shift_Win.Size = new Size(88, 23);
      this.KEY_Shift_Win.TabIndex = 82;
      this.KEY_Shift_Win.Text = "Shift+Win+";
      this.KEY_Shift_Win.UseVisualStyleBackColor = true;
      this.KEY_Shift_Win.Click += new EventHandler(this.KEY_Shift_Win_Click);
      this.KEY_Ctrl_Alt_Shift_Win.Location = new Point(3, 119);
      this.KEY_Ctrl_Alt_Shift_Win.Name = "KEY_Ctrl_Alt_Shift_Win";
      this.KEY_Ctrl_Alt_Shift_Win.Size = new Size(394, 23);
      this.KEY_Ctrl_Alt_Shift_Win.TabIndex = 83;
      this.KEY_Ctrl_Alt_Shift_Win.Text = "Ctrl+Alt+Shift+Win+";
      this.KEY_Ctrl_Alt_Shift_Win.UseVisualStyleBackColor = true;
      this.KEY_Ctrl_Alt_Shift_Win.Click += new EventHandler(this.KEY_Ctrl_Alt_Shift_Win_Click);
      this.KEY_Shift_And_1.Location = new Point(423, 3);
      this.KEY_Shift_And_1.Name = "KEY_Shift_And_1";
      this.KEY_Shift_And_1.Size = new Size(41, 23);
      this.KEY_Shift_And_1.TabIndex = 84;
      this.KEY_Shift_And_1.Text = "~";
      this.KEY_Shift_And_1.UseVisualStyleBackColor = true;
      this.KEY_Shift_And_1.Click += new EventHandler(this.KEY_Shift_And_1_Click);
      this.KEY_Shift_And_2.Location = new Point(470, 3);
      this.KEY_Shift_And_2.Name = "KEY_Shift_And_2";
      this.KEY_Shift_And_2.Size = new Size(41, 23);
      this.KEY_Shift_And_2.TabIndex = 85;
      this.KEY_Shift_And_2.Text = "!";
      this.KEY_Shift_And_2.UseVisualStyleBackColor = true;
      this.KEY_Shift_And_2.Click += new EventHandler(this.KEY_Shift_And_2_Click);
      this.KEY_Shift_And_3.Location = new Point(517, 3);
      this.KEY_Shift_And_3.Name = "KEY_Shift_And_3";
      this.KEY_Shift_And_3.Size = new Size(41, 23);
      this.KEY_Shift_And_3.TabIndex = 86;
      this.KEY_Shift_And_3.Text = "@";
      this.KEY_Shift_And_3.UseVisualStyleBackColor = true;
      this.KEY_Shift_And_3.Click += new EventHandler(this.KEY_Shift_And_3_Click);
      this.KEY_Shift_And_4.Location = new Point(564, 3);
      this.KEY_Shift_And_4.Name = "KEY_Shift_And_4";
      this.KEY_Shift_And_4.Size = new Size(41, 23);
      this.KEY_Shift_And_4.TabIndex = 87;
      this.KEY_Shift_And_4.Text = "#";
      this.KEY_Shift_And_4.UseVisualStyleBackColor = true;
      this.KEY_Shift_And_4.Click += new EventHandler(this.KEY_Shift_And_4_Click);
      this.KEY_Shift_And_5.Location = new Point(611, 3);
      this.KEY_Shift_And_5.Name = "KEY_Shift_And_5";
      this.KEY_Shift_And_5.Size = new Size(41, 23);
      this.KEY_Shift_And_5.TabIndex = 88;
      this.KEY_Shift_And_5.Text = "$";
      this.KEY_Shift_And_5.UseVisualStyleBackColor = true;
      this.KEY_Shift_And_5.Click += new EventHandler(this.KEY_Shift_And_5_Click);
      this.KEY_Shift_And_6.Location = new Point(423, 32);
      this.KEY_Shift_And_6.Name = "KEY_Shift_And_6";
      this.KEY_Shift_And_6.Size = new Size(41, 23);
      this.KEY_Shift_And_6.TabIndex = 89;
      this.KEY_Shift_And_6.Text = "%";
      this.KEY_Shift_And_6.UseVisualStyleBackColor = true;
      this.KEY_Shift_And_6.Click += new EventHandler(this.KEY_Shift_And_6_Click);
      this.KEY_Shift_And_7.Location = new Point(470, 32);
      this.KEY_Shift_And_7.Name = "KEY_Shift_And_7";
      this.KEY_Shift_And_7.Size = new Size(41, 23);
      this.KEY_Shift_And_7.TabIndex = 90;
      this.KEY_Shift_And_7.Text = "∧";
      this.KEY_Shift_And_7.UseVisualStyleBackColor = true;
      this.KEY_Shift_And_7.Click += new EventHandler(this.KEY_Shift_And_7_Click);
      this.KEY_Shift_And_8.Location = new Point(517, 32);
      this.KEY_Shift_And_8.Name = "KEY_Shift_And_8";
      this.KEY_Shift_And_8.Size = new Size(41, 23);
      this.KEY_Shift_And_8.TabIndex = 91;
      this.KEY_Shift_And_8.Text = "&&";
      this.KEY_Shift_And_8.UseVisualStyleBackColor = true;
      this.KEY_Shift_And_8.Click += new EventHandler(this.KEY_Shift_And_8_Click);
      this.KEY_Shift_And_9.Location = new Point(564, 32);
      this.KEY_Shift_And_9.Name = "KEY_Shift_And_9";
      this.KEY_Shift_And_9.Size = new Size(41, 23);
      this.KEY_Shift_And_9.TabIndex = 92;
      this.KEY_Shift_And_9.Text = "*";
      this.KEY_Shift_And_9.UseVisualStyleBackColor = true;
      this.KEY_Shift_And_9.Click += new EventHandler(this.KEY_Shift_And_9_Click);
      this.KEY_Shift_And_10.Location = new Point(611, 32);
      this.KEY_Shift_And_10.Name = "KEY_Shift_And_10";
      this.KEY_Shift_And_10.Size = new Size(41, 23);
      this.KEY_Shift_And_10.TabIndex = 93;
      this.KEY_Shift_And_10.Text = "(";
      this.KEY_Shift_And_10.UseVisualStyleBackColor = true;
      this.KEY_Shift_And_10.Click += new EventHandler(this.KEY_Shift_And_10_Click);
      this.KEY_Shift_And_11.Location = new Point(423, 61);
      this.KEY_Shift_And_11.Name = "KEY_Shift_And_11";
      this.KEY_Shift_And_11.Size = new Size(41, 23);
      this.KEY_Shift_And_11.TabIndex = 94;
      this.KEY_Shift_And_11.Text = ")";
      this.KEY_Shift_And_11.UseVisualStyleBackColor = true;
      this.KEY_Shift_And_11.Click += new EventHandler(this.KEY_Shift_And_11_Click);
      this.KEY_Shift_And_12.Location = new Point(470, 61);
      this.KEY_Shift_And_12.Name = "KEY_Shift_And_12";
      this.KEY_Shift_And_12.Size = new Size(41, 23);
      this.KEY_Shift_And_12.TabIndex = 95;
      this.KEY_Shift_And_12.Text = "_";
      this.KEY_Shift_And_12.UseVisualStyleBackColor = true;
      this.KEY_Shift_And_12.Click += new EventHandler(this.KEY_Shift_And_12_Click);
      this.KEY_Shift_And_13.Location = new Point(517, 61);
      this.KEY_Shift_And_13.Name = "KEY_Shift_And_13";
      this.KEY_Shift_And_13.Size = new Size(41, 23);
      this.KEY_Shift_And_13.TabIndex = 96;
      this.KEY_Shift_And_13.Text = "+";
      this.KEY_Shift_And_13.UseVisualStyleBackColor = true;
      this.KEY_Shift_And_13.Click += new EventHandler(this.KEY_Shift_And_13_Click);
      this.KEY_Shift_And_14.Location = new Point(564, 61);
      this.KEY_Shift_And_14.Name = "KEY_Shift_And_14";
      this.KEY_Shift_And_14.Size = new Size(41, 23);
      this.KEY_Shift_And_14.TabIndex = 97;
      this.KEY_Shift_And_14.Text = "{";
      this.KEY_Shift_And_14.UseVisualStyleBackColor = true;
      this.KEY_Shift_And_14.Click += new EventHandler(this.KEY_Shift_And_14_Click);
      this.KEY_Shift_And_15.Location = new Point(611, 61);
      this.KEY_Shift_And_15.Name = "KEY_Shift_And_15";
      this.KEY_Shift_And_15.Size = new Size(41, 23);
      this.KEY_Shift_And_15.TabIndex = 98;
      this.KEY_Shift_And_15.Text = "}";
      this.KEY_Shift_And_15.UseVisualStyleBackColor = true;
      this.KEY_Shift_And_15.Click += new EventHandler(this.KEY_Shift_And_15_Click);
      this.KEY_Shift_And_16.Location = new Point(423, 90);
      this.KEY_Shift_And_16.Name = "KEY_Shift_And_16";
      this.KEY_Shift_And_16.Size = new Size(41, 23);
      this.KEY_Shift_And_16.TabIndex = 99;
      this.KEY_Shift_And_16.Text = "|";
      this.KEY_Shift_And_16.UseVisualStyleBackColor = true;
      this.KEY_Shift_And_16.Click += new EventHandler(this.KEY_Shift_And_16_Click);
      this.KEY_Shift_And_17.Location = new Point(470, 90);
      this.KEY_Shift_And_17.Name = "KEY_Shift_And_17";
      this.KEY_Shift_And_17.Size = new Size(41, 23);
      this.KEY_Shift_And_17.TabIndex = 100;
      this.KEY_Shift_And_17.Text = ":";
      this.KEY_Shift_And_17.UseVisualStyleBackColor = true;
      this.KEY_Shift_And_17.Click += new EventHandler(this.KEY_Shift_And_17_Click);
      this.KEY_Shift_And_18.Location = new Point(517, 90);
      this.KEY_Shift_And_18.Name = "KEY_Shift_And_18";
      this.KEY_Shift_And_18.Size = new Size(41, 23);
      this.KEY_Shift_And_18.TabIndex = 101;
      this.KEY_Shift_And_18.Text = "\"";
      this.KEY_Shift_And_18.UseVisualStyleBackColor = true;
      this.KEY_Shift_And_18.Click += new EventHandler(this.KEY_Shift_And_18_Click);
      this.KEY_Shift_And_19.Location = new Point(564, 90);
      this.KEY_Shift_And_19.Name = "KEY_Shift_And_19";
      this.KEY_Shift_And_19.Size = new Size(41, 23);
      this.KEY_Shift_And_19.TabIndex = 102;
      this.KEY_Shift_And_19.Text = "<";
      this.KEY_Shift_And_19.UseVisualStyleBackColor = true;
      this.KEY_Shift_And_19.Click += new EventHandler(this.KEY_Shift_And_19_Click);
      this.KEY_Shift_And_20.Location = new Point(611, 90);
      this.KEY_Shift_And_20.Name = "KEY_Shift_And_20";
      this.KEY_Shift_And_20.Size = new Size(41, 23);
      this.KEY_Shift_And_20.TabIndex = 103;
      this.KEY_Shift_And_20.Text = ">";
      this.KEY_Shift_And_20.UseVisualStyleBackColor = true;
      this.KEY_Shift_And_20.Click += new EventHandler(this.KEY_Shift_And_20_Click);
      this.KEY_Shift_And_21.Location = new Point(423, 119);
      this.KEY_Shift_And_21.Name = "KEY_Shift_And_21";
      this.KEY_Shift_And_21.Size = new Size(41, 23);
      this.KEY_Shift_And_21.TabIndex = 104;
      this.KEY_Shift_And_21.Text = "?";
      this.KEY_Shift_And_21.UseVisualStyleBackColor = true;
      this.KEY_Shift_And_21.Click += new EventHandler(this.KEY_Shift_And_21_Click);
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.KEY_Shift_And_21);
      this.Controls.Add((Control) this.KEY_Shift_And_20);
      this.Controls.Add((Control) this.KEY_Shift_And_19);
      this.Controls.Add((Control) this.KEY_Shift_And_18);
      this.Controls.Add((Control) this.KEY_Shift_And_17);
      this.Controls.Add((Control) this.KEY_Shift_And_16);
      this.Controls.Add((Control) this.KEY_Shift_And_15);
      this.Controls.Add((Control) this.KEY_Shift_And_14);
      this.Controls.Add((Control) this.KEY_Shift_And_13);
      this.Controls.Add((Control) this.KEY_Shift_And_12);
      this.Controls.Add((Control) this.KEY_Shift_And_11);
      this.Controls.Add((Control) this.KEY_Shift_And_10);
      this.Controls.Add((Control) this.KEY_Shift_And_9);
      this.Controls.Add((Control) this.KEY_Shift_And_8);
      this.Controls.Add((Control) this.KEY_Shift_And_7);
      this.Controls.Add((Control) this.KEY_Shift_And_6);
      this.Controls.Add((Control) this.KEY_Shift_And_5);
      this.Controls.Add((Control) this.KEY_Shift_And_4);
      this.Controls.Add((Control) this.KEY_Shift_And_3);
      this.Controls.Add((Control) this.KEY_Shift_And_2);
      this.Controls.Add((Control) this.KEY_Shift_And_1);
      this.Controls.Add((Control) this.KEY_Ctrl_Alt_Shift_Win);
      this.Controls.Add((Control) this.KEY_Shift_Win);
      this.Controls.Add((Control) this.KEY_Ctrl_Alt_Win);
      this.Controls.Add((Control) this.KEY_Ctrl_Shift_Alt);
      this.Controls.Add((Control) this.KEY_Alt_Shift);
      this.Controls.Add((Control) this.KEY_Ctrl_Shift);
      this.Controls.Add((Control) this.KEY_ctrl_alt);
      this.Controls.Add((Control) this.KEY_Win_Right);
      this.Controls.Add((Control) this.KEY_Win_left);
      this.Controls.Add((Control) this.KEY_Ctrl_Right);
      this.Controls.Add((Control) this.KEY_Shift_right);
      this.Controls.Add((Control) this.KEY_ALT_Right);
      this.Controls.Add((Control) this.KEY_ALT_Left);
      this.Controls.Add((Control) this.KEY_Shift_left);
      this.Controls.Add((Control) this.KEY_Ctrl_left);
      this.Name = nameof (FunKey);
      this.Size = new Size(858, 443);
      this.Load += new EventHandler(this.FunKey_Load);
      this.ResumeLayout(false);
    }
  }
}
