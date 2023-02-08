using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HIDTester
{
  public class LEDkey : UserControl
  {
    private IContainer components;
    private Button KEY_LEDMode0;
    private Button KEY_LEDMode1;
    private Button KEY_LEDMode2;
    private Button KEY_LEDMode3;
    private Button KEY_LEDMode4;
    private Button KEY_LEDMode5;
    private Button button_Red;
    private Button button_Orange;
    private Button button_Yellow;
    private Button button_Green;
    private Button button_Cyan;
    private Button button_Blue;
    private Button button_Purple;

    public LEDkey()
    {
      this.InitializeComponent();
      this.KEY_Colour_Init();
    }

    private void KEY_Colour_Init()
    {
      int red1 = 152;
      int green1 = 251;
      int blue1 = 152;
      int red2 = 135;
      int green2 = 206;
      int blue2 = 235;
      this.KEY_LEDMode0.BackColor = Color.FromArgb(red1, green1, blue1);
      this.KEY_LEDMode1.BackColor = Color.FromArgb(red1, green1, blue1);
      this.KEY_LEDMode2.BackColor = Color.FromArgb(red1, green1, blue1);
      this.KEY_LEDMode3.BackColor = Color.FromArgb(red1, green1, blue1);
      this.KEY_LEDMode4.BackColor = Color.FromArgb(red1, green1, blue1);
      this.KEY_LEDMode5.BackColor = Color.FromArgb(red1, green1, blue1);
      this.button_Red.BackColor = Color.FromArgb(red2, green2, blue2);
      this.button_Orange.BackColor = Color.FromArgb(red2, green2, blue2);
      this.button_Yellow.BackColor = Color.FromArgb(red2, green2, blue2);
      this.button_Green.BackColor = Color.FromArgb(red2, green2, blue2);
      this.button_Cyan.BackColor = Color.FromArgb(red2, green2, blue2);
      this.button_Blue.BackColor = Color.FromArgb(red2, green2, blue2);
      this.button_Purple.BackColor = Color.FromArgb(red2, green2, blue2);
    }

    private void KEY_Colour_Init_Mode()
    {
      int red = 152;
      int green = 251;
      int blue = 152;
      this.KEY_LEDMode0.BackColor = Color.FromArgb(red, green, blue);
      this.KEY_LEDMode1.BackColor = Color.FromArgb(red, green, blue);
      this.KEY_LEDMode2.BackColor = Color.FromArgb(red, green, blue);
      this.KEY_LEDMode3.BackColor = Color.FromArgb(red, green, blue);
      this.KEY_LEDMode4.BackColor = Color.FromArgb(red, green, blue);
      this.KEY_LEDMode5.BackColor = Color.FromArgb(red, green, blue);
    }

    private void KEY_Colour_Init_Color()
    {
      int red = 135;
      int green = 206;
      int blue = 235;
      this.button_Red.BackColor = Color.FromArgb(red, green, blue);
      this.button_Orange.BackColor = Color.FromArgb(red, green, blue);
      this.button_Yellow.BackColor = Color.FromArgb(red, green, blue);
      this.button_Green.BackColor = Color.FromArgb(red, green, blue);
      this.button_Cyan.BackColor = Color.FromArgb(red, green, blue);
      this.button_Blue.BackColor = Color.FromArgb(red, green, blue);
      this.button_Purple.BackColor = Color.FromArgb(red, green, blue);
    }

    private void LEDGeneral_Char_Set()
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyType_Num] |= (byte) 8;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum] = (byte) 176;
    }

    private void KEY_LEDMode0_Click(object sender, EventArgs e)
    {
      if (FormMain.KeyParam.Sd_Protocol_Type == (byte) 1)
      {
        this.LEDGeneral_Char_Set();
        FormMain.KeyParam.Data_Send_Buff[4] = FormMain.KeyParam.KEY_Cur_Layer;
        FormMain.KeyParam.Data_Send_Buff[5] &= (byte) 240;
        FormMain.KeyParam.Data_Send_Buff[5] |= (byte) 0;
      }
      else
      {
        this.LEDGeneral_Char_Set();
        FormMain.KeyParam.Data_Send_Buff[2] = (byte) 0;
      }
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5 + 6] = this.KEY_LEDMode0.Text;
      this.KEY_Colour_Init_Mode();
      this.KEY_LEDMode0.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void KEY_LEDMode1_Click(object sender, EventArgs e)
    {
      if (FormMain.KeyParam.Sd_Protocol_Type == (byte) 1)
      {
        this.LEDGeneral_Char_Set();
        FormMain.KeyParam.Data_Send_Buff[4] = FormMain.KeyParam.KEY_Cur_Layer;
        FormMain.KeyParam.Data_Send_Buff[5] &= (byte) 240;
        FormMain.KeyParam.Data_Send_Buff[5] |= (byte) 1;
      }
      else
      {
        this.LEDGeneral_Char_Set();
        FormMain.KeyParam.Data_Send_Buff[2] = (byte) 1;
      }
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5 + 6] = this.KEY_LEDMode1.Text;
      this.KEY_Colour_Init_Mode();
      this.KEY_LEDMode1.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void KEY_LEDMode2_Click(object sender, EventArgs e)
    {
      if (FormMain.KeyParam.Sd_Protocol_Type == (byte) 1)
      {
        this.LEDGeneral_Char_Set();
        FormMain.KeyParam.Data_Send_Buff[4] = FormMain.KeyParam.KEY_Cur_Layer;
        FormMain.KeyParam.Data_Send_Buff[5] &= (byte) 240;
        FormMain.KeyParam.Data_Send_Buff[5] |= (byte) 2;
      }
      else
      {
        this.LEDGeneral_Char_Set();
        FormMain.KeyParam.Data_Send_Buff[2] = (byte) 2;
      }
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5 + 6] = this.KEY_LEDMode2.Text;
      this.KEY_Colour_Init_Mode();
      this.KEY_LEDMode2.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void KEY_LEDMode3_Click(object sender, EventArgs e)
    {
      this.LEDGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[4] = FormMain.KeyParam.KEY_Cur_Layer;
      FormMain.KeyParam.Data_Send_Buff[5] &= (byte) 240;
      FormMain.KeyParam.Data_Send_Buff[5] |= (byte) 3;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5 + 6] = this.KEY_LEDMode3.Text;
      this.KEY_Colour_Init_Mode();
      this.KEY_LEDMode3.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void KEY_LEDMode4_Click(object sender, EventArgs e)
    {
      this.LEDGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[4] = FormMain.KeyParam.KEY_Cur_Layer;
      FormMain.KeyParam.Data_Send_Buff[5] &= (byte) 240;
      FormMain.KeyParam.Data_Send_Buff[5] |= (byte) 4;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5 + 6] = this.KEY_LEDMode4.Text;
      this.KEY_Colour_Init_Mode();
      this.KEY_LEDMode4.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void KEY_LEDMode5_Click(object sender, EventArgs e)
    {
      this.LEDGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[4] = FormMain.KeyParam.KEY_Cur_Layer;
      FormMain.KeyParam.Data_Send_Buff[5] &= (byte) 240;
      FormMain.KeyParam.Data_Send_Buff[5] |= (byte) 5;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5 + 6] = this.KEY_LEDMode5.Text;
      this.KEY_Colour_Init_Mode();
      this.KEY_LEDMode5.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void button_Red_Click(object sender, EventArgs e)
    {
      this.LEDGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[4] = FormMain.KeyParam.KEY_Cur_Layer;
      FormMain.KeyParam.Data_Send_Buff[5] &= (byte) 15;
      FormMain.KeyParam.Data_Send_Buff[5] |= (byte) 16;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.button_Red.Text;
      this.KEY_Colour_Init_Color();
      this.button_Red.BackColor = Color.FromArgb((int) byte.MaxValue, 99, 71);
    }

    private void button_Orange_Click(object sender, EventArgs e)
    {
      this.LEDGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[4] = FormMain.KeyParam.KEY_Cur_Layer;
      FormMain.KeyParam.Data_Send_Buff[5] &= (byte) 15;
      FormMain.KeyParam.Data_Send_Buff[5] |= (byte) 32;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.button_Orange.Text;
      this.KEY_Colour_Init_Color();
      this.button_Orange.BackColor = Color.FromArgb((int) byte.MaxValue, 99, 71);
    }

    private void button_Yellow_Click(object sender, EventArgs e)
    {
      this.LEDGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[4] = FormMain.KeyParam.KEY_Cur_Layer;
      FormMain.KeyParam.Data_Send_Buff[5] &= (byte) 15;
      FormMain.KeyParam.Data_Send_Buff[5] |= (byte) 48;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.button_Yellow.Text;
      this.KEY_Colour_Init_Color();
      this.button_Yellow.BackColor = Color.FromArgb((int) byte.MaxValue, 99, 71);
    }

    private void button_Green_Click(object sender, EventArgs e)
    {
      this.LEDGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[4] = FormMain.KeyParam.KEY_Cur_Layer;
      FormMain.KeyParam.Data_Send_Buff[5] &= (byte) 15;
      FormMain.KeyParam.Data_Send_Buff[5] |= (byte) 64;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.button_Green.Text;
      this.KEY_Colour_Init_Color();
      this.button_Green.BackColor = Color.FromArgb((int) byte.MaxValue, 99, 71);
    }

    private void button_Cyan_Click(object sender, EventArgs e)
    {
      this.LEDGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[4] = FormMain.KeyParam.KEY_Cur_Layer;
      FormMain.KeyParam.Data_Send_Buff[5] &= (byte) 15;
      FormMain.KeyParam.Data_Send_Buff[5] |= (byte) 80;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.button_Cyan.Text;
      this.KEY_Colour_Init_Color();
      this.button_Cyan.BackColor = Color.FromArgb((int) byte.MaxValue, 99, 71);
    }

    private void button_Blue_Click(object sender, EventArgs e)
    {
      this.LEDGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[4] = FormMain.KeyParam.KEY_Cur_Layer;
      FormMain.KeyParam.Data_Send_Buff[5] &= (byte) 15;
      FormMain.KeyParam.Data_Send_Buff[5] |= (byte) 96;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.button_Blue.Text;
      this.KEY_Colour_Init_Color();
      this.button_Blue.BackColor = Color.FromArgb((int) byte.MaxValue, 99, 71);
    }

    private void button_Purple_Click(object sender, EventArgs e)
    {
      this.LEDGeneral_Char_Set();
      FormMain.KeyParam.Data_Send_Buff[4] = FormMain.KeyParam.KEY_Cur_Layer;
      FormMain.KeyParam.Data_Send_Buff[5] &= (byte) 15;
      FormMain.KeyParam.Data_Send_Buff[5] |= (byte) 112;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.button_Purple.Text;
      this.KEY_Colour_Init_Color();
      this.button_Purple.BackColor = Color.FromArgb((int) byte.MaxValue, 99, 71);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (LEDkey));
      this.KEY_LEDMode0 = new Button();
      this.KEY_LEDMode1 = new Button();
      this.KEY_LEDMode2 = new Button();
      this.KEY_LEDMode3 = new Button();
      this.KEY_LEDMode4 = new Button();
      this.KEY_LEDMode5 = new Button();
      this.button_Red = new Button();
      this.button_Orange = new Button();
      this.button_Yellow = new Button();
      this.button_Green = new Button();
      this.button_Cyan = new Button();
      this.button_Blue = new Button();
      this.button_Purple = new Button();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.KEY_LEDMode0, "KEY_LEDMode0");
      this.KEY_LEDMode0.Name = "KEY_LEDMode0";
      this.KEY_LEDMode0.UseVisualStyleBackColor = true;
      this.KEY_LEDMode0.Click += new EventHandler(this.KEY_LEDMode0_Click);
      componentResourceManager.ApplyResources((object) this.KEY_LEDMode1, "KEY_LEDMode1");
      this.KEY_LEDMode1.Name = "KEY_LEDMode1";
      this.KEY_LEDMode1.UseVisualStyleBackColor = true;
      this.KEY_LEDMode1.Click += new EventHandler(this.KEY_LEDMode1_Click);
      componentResourceManager.ApplyResources((object) this.KEY_LEDMode2, "KEY_LEDMode2");
      this.KEY_LEDMode2.Name = "KEY_LEDMode2";
      this.KEY_LEDMode2.UseVisualStyleBackColor = true;
      this.KEY_LEDMode2.Click += new EventHandler(this.KEY_LEDMode2_Click);
      componentResourceManager.ApplyResources((object) this.KEY_LEDMode3, "KEY_LEDMode3");
      this.KEY_LEDMode3.Name = "KEY_LEDMode3";
      this.KEY_LEDMode3.UseVisualStyleBackColor = true;
      this.KEY_LEDMode3.Click += new EventHandler(this.KEY_LEDMode3_Click);
      componentResourceManager.ApplyResources((object) this.KEY_LEDMode4, "KEY_LEDMode4");
      this.KEY_LEDMode4.Name = "KEY_LEDMode4";
      this.KEY_LEDMode4.UseVisualStyleBackColor = true;
      this.KEY_LEDMode4.Click += new EventHandler(this.KEY_LEDMode4_Click);
      componentResourceManager.ApplyResources((object) this.KEY_LEDMode5, "KEY_LEDMode5");
      this.KEY_LEDMode5.Name = "KEY_LEDMode5";
      this.KEY_LEDMode5.UseVisualStyleBackColor = true;
      this.KEY_LEDMode5.Click += new EventHandler(this.KEY_LEDMode5_Click);
      componentResourceManager.ApplyResources((object) this.button_Red, "button_Red");
      this.button_Red.Name = "button_Red";
      this.button_Red.UseVisualStyleBackColor = true;
      this.button_Red.Click += new EventHandler(this.button_Red_Click);
      componentResourceManager.ApplyResources((object) this.button_Orange, "button_Orange");
      this.button_Orange.Name = "button_Orange";
      this.button_Orange.UseVisualStyleBackColor = true;
      this.button_Orange.Click += new EventHandler(this.button_Orange_Click);
      componentResourceManager.ApplyResources((object) this.button_Yellow, "button_Yellow");
      this.button_Yellow.Name = "button_Yellow";
      this.button_Yellow.UseVisualStyleBackColor = true;
      this.button_Yellow.Click += new EventHandler(this.button_Yellow_Click);
      componentResourceManager.ApplyResources((object) this.button_Green, "button_Green");
      this.button_Green.Name = "button_Green";
      this.button_Green.UseVisualStyleBackColor = true;
      this.button_Green.Click += new EventHandler(this.button_Green_Click);
      componentResourceManager.ApplyResources((object) this.button_Cyan, "button_Cyan");
      this.button_Cyan.Name = "button_Cyan";
      this.button_Cyan.UseVisualStyleBackColor = true;
      this.button_Cyan.Click += new EventHandler(this.button_Cyan_Click);
      componentResourceManager.ApplyResources((object) this.button_Blue, "button_Blue");
      this.button_Blue.Name = "button_Blue";
      this.button_Blue.UseVisualStyleBackColor = true;
      this.button_Blue.Click += new EventHandler(this.button_Blue_Click);
      componentResourceManager.ApplyResources((object) this.button_Purple, "button_Purple");
      this.button_Purple.Name = "button_Purple";
      this.button_Purple.UseVisualStyleBackColor = true;
      this.button_Purple.Click += new EventHandler(this.button_Purple_Click);
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.button_Purple);
      this.Controls.Add((Control) this.button_Blue);
      this.Controls.Add((Control) this.button_Cyan);
      this.Controls.Add((Control) this.button_Green);
      this.Controls.Add((Control) this.button_Yellow);
      this.Controls.Add((Control) this.button_Orange);
      this.Controls.Add((Control) this.button_Red);
      this.Controls.Add((Control) this.KEY_LEDMode5);
      this.Controls.Add((Control) this.KEY_LEDMode4);
      this.Controls.Add((Control) this.KEY_LEDMode3);
      this.Controls.Add((Control) this.KEY_LEDMode2);
      this.Controls.Add((Control) this.KEY_LEDMode1);
      this.Controls.Add((Control) this.KEY_LEDMode0);
      this.Name = nameof (LEDkey);
      this.ResumeLayout(false);
    }
  }
}
