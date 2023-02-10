using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace HIDTester
{
  public class FormMain : Form
  {
    private ushort WriteMode = 1;
    private byte[] RecDataBuffer = new byte[90];
    private int Display_Dowlaod_Char_TM;
    private readonly Color menuBackColor = Color.FromArgb(200, 200, 169);
    private readonly Color menuMouserOverColor = Color.FromArgb(230, 206, 172);
    private readonly string[] menuStr = new string[6]
    {
      "KEY",
      "Ctrl Shift Alt",
      "Multimedia",
      "LED",
      "Mouse",
      "Delay"
    };
    private Dictionary<string, Form> menuDic = new Dictionary<string, Form>();
    private IContainer components;
    private Label stateLabel;
    private ToolStripMenuItem fdToolStripMenuItem;
    private Button Download;
    private Button KEY1;
    private Button KEY2;
    private Button KEY3;
    private Button KEY4;
    private Button K1_Left;
    private Button K1_Centre;
    private Button K1_Right;
    private TextBox SetText;
    private Button Key_Clear;
    private Button KEY8;
    private Button KEY7;
    private Button KEY6;
    private Button KEY5;
    private Button KEY12;
    private Button KEY11;
    private Button KEY10;
    private Button KEY9;
    private Button KEY16;
    private Button KEY15;
    private Button KEY14;
    private Button KEY13;
    private Button K2_Right;
    private Button K2_Centre;
    private Button K2_Left;
    private SplitContainer splitContainer1;
    private FlowLayoutPanel flowLayoutPanel1;
    private TextBox SetFunText;
    private Button K3_Left;
    private Button K3_Centre;
    private Button K3_Right;
    private FlowLayoutPanel flowLayoutPanel_LayerFun;
    private PictureBox pictureBox1;
    private Label label_Dowload_Dsp;

    public FormMain()
    {
      this.InitializeComponent();
      this.Lanuage_Set_EN();
      this.MenuList();
      this.KEY_Colour_Init();
      this.Time_Display_Text();
      this.Hide_Dowload_Text();
      this.LayerFunList();
      this.Size = new Size(2000, 1000);
      // Console.WriteLine($"==> Size: ({this.Size.Width}, {this.Size.Height})");
    }

    private void MenuList()
    {
      for (int index = 0; index < this.menuStr.Length; ++index)
      {
        Button button = new Button();
        button.Text = this.menuStr[index];
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.MouseOverBackColor = this.menuMouserOverColor;
        button.FlatAppearance.BorderSize = 0;
        button.Width = this.flowLayoutPanel1.Width;
        button.Height = 40;
        button.Margin = new Padding() { All = 0 };
        button.MouseClick += new MouseEventHandler(this.Btn_OnClick);
        this.flowLayoutPanel1.Controls.Add((Control) button);
        this.flowLayoutPanel1.BackColor = this.menuBackColor;
      }
      BasicKeys basicKeys = new BasicKeys();
      basicKeys.Parent = (Control) this.splitContainer1.Panel2;
      basicKeys.Dock = DockStyle.Fill;
      basicKeys.Show();
      FormMain.KeyParam.KEY_Cur_Page = (byte) 1;
    }

    private void LayerFunList()
    {
      LayerFun layerFun = new LayerFun();
      this.flowLayoutPanel_LayerFun.Controls.Add((Control) layerFun);
      layerFun.Show();
    }

    private void Btn_OnClick(object sender, MouseEventArgs e)
    {
      switch ((sender as Button).Text)
      {
        case "KEY":
          this.splitContainer1.Panel2.Controls.Clear();
          BasicKeys basicKeys = new BasicKeys();
          basicKeys.Parent = (Control) this.splitContainer1.Panel2;
          basicKeys.Dock = DockStyle.Fill;
          basicKeys.Show();
          if (FormMain.KeyParam.KEY_Cur_Page != (byte) 2)
            this.Page_change_Clear();
          FormMain.KeyParam.KEY_Cur_Page = (byte) 1;
          break;
        case "Ctrl Shift Alt":
          this.splitContainer1.Panel2.Controls.Clear();
          FunKey funKey = new FunKey();
          funKey.Parent = (Control) this.splitContainer1.Panel2;
          funKey.Dock = DockStyle.Fill;
          funKey.Show();
          if (FormMain.KeyParam.KEY_Cur_Page != (byte) 1)
            this.Page_change_Clear();
          FormMain.KeyParam.KEY_Cur_Page = (byte) 2;
          break;
        case "Multimedia":
          this.splitContainer1.Panel2.Controls.Clear();
          MULKey mulKey = new MULKey();
          mulKey.Parent = (Control) this.splitContainer1.Panel2;
          mulKey.Dock = DockStyle.Fill;
          mulKey.Show();
          this.Page_change_Clear();
          FormMain.KeyParam.KEY_Cur_Page = (byte) 3;
          break;
        case "LED":
          this.splitContainer1.Panel2.Controls.Clear();
          LEDkey leDkey = new LEDkey();
          leDkey.Parent = (Control) this.splitContainer1.Panel2;
          leDkey.Dock = DockStyle.Fill;
          leDkey.Show();
          this.Key_Clear_Fun();
          FormMain.KeyParam.KEY_Cur_Page = (byte) 4;
          break;
        case "Mouse":
          this.splitContainer1.Panel2.Controls.Clear();
          MouseKey mouseKey = new MouseKey();
          mouseKey.Parent = (Control) this.splitContainer1.Panel2;
          mouseKey.Dock = DockStyle.Fill;
          mouseKey.Show();
          this.Page_change_Clear();
          FormMain.KeyParam.KEY_Cur_Page = (byte) 5;
          break;
        case "Delay":
          this.splitContainer1.Panel2.Controls.Clear();
          Delay delay = new Delay();
          delay.Parent = (Control) this.splitContainer1.Panel2;
          delay.Dock = DockStyle.Fill;
          delay.Show();
          this.Page_change_Clear();
          FormMain.KeyParam.KEY_Cur_Page = (byte) 6;
          break;
      }
    }

    private void Show_Dowload_Text()
    {
      this.Display_Dowlaod_Char_TM = 20;
      this.label_Dowload_Dsp.Show();
    }

    private void Hide_Dowload_Text() => this.label_Dowload_Dsp.Hide();

    private void AutoCheckUsb()
    {
        bool opened = true;
        if (opened)
        {
            this.KeyBoardVersion_Check();
            this.stateLabel.Text = "Connected";
            this.stateLabel.BackColor = this.stateLabel.BackColor = Color.Green;
        }
        else
        {
            this.stateLabel.Text = "Not Connected";
            this.stateLabel.BackColor = this.stateLabel.BackColor = Color.Red;
        }
    }

    private void aboutMenu_Click(object sender, EventArgs e) => Process.Start("http://www.cnblogs.com/hebaichuanyeah/p/4504855.html");

    private void Time_Display_Text()
    {
      System.Timers.Timer timer = new System.Timers.Timer();
      timer.Enabled = true;
      timer.Interval = 30.0;
      timer.Start();
      timer.Elapsed += new ElapsedEventHandler(this.Timer1_Elapsed);
    }

    private void Timer1_Elapsed(object sender, ElapsedEventArgs e)
    {
      this.AutoCheckUsb();
      if (FormMain.KeyParam.PageBet_Inte_Cmd != (byte) 0 && FormMain.KeyParam.PageBet_Inte_Cmd == (byte) 1)
      {
        FormMain.KeyParam.PageBet_Inte_Cmd = (byte) 0;
        this.Key_Clear_Fun();
      }
      if (this.Display_Dowlaod_Char_TM-- == 0)
        this.Hide_Dowload_Text();
      if (FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum] != (byte) 0)
      {
        string str1 = "";
        string str2 = "";
        this.SetText.Text = str1 + FormMain.KeyParam.KeyChar[0] + " " + FormMain.KeyParam.KeyChar[2] + " " + FormMain.KeyParam.KeyChar[4] + " " + FormMain.KeyParam.KeyChar[6] + " " + FormMain.KeyParam.KeyChar[8] + " " + FormMain.KeyParam.KeyChar[10] + " " + FormMain.KeyParam.KeyChar[12] + " " + FormMain.KeyParam.KeyChar[14] + " " + FormMain.KeyParam.KeyChar[16] + " " + FormMain.KeyParam.KeyChar[18] + " " + FormMain.KeyParam.KeyChar[20] + " " + FormMain.KeyParam.KeyChar[22] + " " + FormMain.KeyParam.KeyChar[24] + " " + FormMain.KeyParam.KeyChar[26] + " " + FormMain.KeyParam.KeyChar[28] + " " + FormMain.KeyParam.KeyChar[30] + " " + FormMain.KeyParam.KeyChar[32] + " " + FormMain.KeyParam.KeyChar[34];
        this.SetFunText.Text = str2 + FormMain.KeyParam.FunKeyChar[0] + " " + FormMain.KeyParam.FunKeyChar[1] + " " + FormMain.KeyParam.FunKeyChar[2] + " " + FormMain.KeyParam.FunKeyChar[3];
      }
      else
      {
        string str3 = "";
        string str4 = "";
        this.SetText.Text = str3;
        this.SetFunText.Text = str4;
      }
    }

    private void KeyBoardVersion_Check()
    {
      /*
      byte[] arrayBuff = new byte[65];
      FormMain.KeyParam.ReportID = (byte) 0;
      arrayBuff[0] = (byte) 0;
      arrayBuff[1] = (byte) 0;
      if (this.WriteMode == (ushort) 0)
      {
        if ((byte) this.myHid.Write(new report(FormMain.KeyParam.ReportID, arrayBuff)) == (byte) 0)
        {
          FormMain.KeyParam.ReportID = (byte) 0;
        }
        else
        {
          FormMain.KeyParam.ReportID = (byte) 2;
          if ((byte) this.myHid.Write(new report(FormMain.KeyParam.ReportID, arrayBuff)) == (byte) 0)
            FormMain.KeyParam.ReportID = (byte) 2;
          else
            FormMain.KeyParam.ReportID = (byte) 3;
        }
      }
      else
      {
        if (this.WriteMode != (ushort) 1)
          return;
        FormMain.KeyParam.ReportID = (byte) 3;
        if (this.myHidLib.WriteDevice(FormMain.KeyParam.ReportID, arrayBuff))
        {
          FormMain.KeyParam.ReportID = (byte) 3;
        }
        else
        {
          FormMain.KeyParam.ReportID = (byte) 0;
          if (this.myHidLib.WriteDevice(FormMain.KeyParam.ReportID, arrayBuff))
          {
            FormMain.KeyParam.ReportID = (byte) 0;
          }
          else
          {
            FormMain.KeyParam.ReportID = (byte) 2;
            if (!this.myHidLib.WriteDevice(FormMain.KeyParam.ReportID, arrayBuff))
              return;
            FormMain.KeyParam.ReportID = (byte) 2;
          }
        }
      }
      */
    }

    private void Send_WriteFlash_Cmd()
    {
      byte[] arrayBuff = new byte[65];
      arrayBuff[0] = (byte) 170;
      arrayBuff[1] = (byte) 170;
      var bytes = PrintByteArray(arrayBuff);
      Console.WriteLine(bytes);
    }

    private void ReportDownloadResult(bool result)
    {
      if (result)
      {
        switch (FormMain.KeyParam.Language_Set)
        {
          case 0:
            this.label_Dowload_Dsp.Text = "Download success";
            break;
          case 1:
            this.label_Dowload_Dsp.Text = "下载成功";
            break;
        }
        this.label_Dowload_Dsp.BackColor = this.label_Dowload_Dsp.BackColor = Color.Green;
        this.Show_Dowload_Text();
      }
      else
      {
        switch (FormMain.KeyParam.Language_Set)
        {
          case 0:
            this.label_Dowload_Dsp.Text = "Download failed";
            break;
          case 1:
            this.label_Dowload_Dsp.Text = "下载失败";
            break;
        }
        this.label_Dowload_Dsp.BackColor = this.label_Dowload_Dsp.BackColor = Color.Red;
        this.Show_Dowload_Text();
      }
    }

    private void Send_WriteFlashLED_Cmd()
    {
      byte[] arrayBuff = new byte[65];
      arrayBuff[0] = (byte) 170;
      arrayBuff[1] = (byte) 161;
      var bytes = PrintByteArray(arrayBuff);
      Console.WriteLine(bytes);
    }

    private void Send_SwLayer()
    {
      byte[] arrayBuff = new byte[65];
      arrayBuff[0] = (byte) 161;
      arrayBuff[1] = FormMain.KeyParam.KEY_Cur_Layer;
      if (arrayBuff[1] == (byte) 0)
        arrayBuff[1] = (byte) 1;
      var bytes = PrintByteArray(arrayBuff);
      Console.WriteLine(bytes);
    }

    private void SendConfig(byte[] arrayBuff)
    {
        Console.WriteLine(PrintByteArray(arrayBuff));
        //var response = Console.ReadLine();
        ReportDownloadResult(true); // response == "65");
    }

    private void Download_Click(object sender, EventArgs e)
    {
      byte[] arrayBuff = new byte[65];
      Array.Clear((Array) arrayBuff, 0, arrayBuff.Length);
      arrayBuff[0] = FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum];
      if (arrayBuff[0] == (byte) 0) return;

      if (FormMain.KeyParam.Sd_Protocol_Type == (byte) 1)
      {
        arrayBuff[0] = (byte) 254;
        arrayBuff[1] = FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum];
        arrayBuff[2] = FormMain.KeyParam.KEY_Cur_Layer;
        arrayBuff[3] = FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyType_Num];
        arrayBuff[4] = FormMain.KeyParam.Protocol2_Sd_Buff[4];
        arrayBuff[5] = FormMain.KeyParam.Protocol2_Sd_Buff[5];
        arrayBuff[6] = (byte) 0;
        arrayBuff[7] = (byte) 0;
        arrayBuff[8] = (byte) 0;
        arrayBuff[10] = FormMain.KeyParam.Data_Send_Buff[4];
        arrayBuff[11] = FormMain.KeyParam.Data_Send_Buff[5];
        FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyGroupCharNum] = arrayBuff[11] == (byte) 0 ? (byte) 0 : (byte) 1;
        arrayBuff[12] = FormMain.KeyParam.Data_Send_Buff[6];
        arrayBuff[13] = FormMain.KeyParam.Data_Send_Buff[7];
        if (arrayBuff[12] != (byte) 0 || arrayBuff[13] != (byte) 0)
          FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyGroupCharNum] = (byte) 2;
        arrayBuff[14] = FormMain.KeyParam.Data_Send_Buff[8];
        arrayBuff[15] = FormMain.KeyParam.Data_Send_Buff[9];
        if (arrayBuff[14] != (byte) 0 || arrayBuff[15] != (byte) 0)
          FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyGroupCharNum] = (byte) 3;
        arrayBuff[16] = FormMain.KeyParam.Data_Send_Buff[10];
        arrayBuff[17] = FormMain.KeyParam.Data_Send_Buff[11];
        if (arrayBuff[16] != (byte) 0 || arrayBuff[17] != (byte) 0)
          FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyGroupCharNum] = (byte) 4;
        arrayBuff[18] = FormMain.KeyParam.Data_Send_Buff[12];
        arrayBuff[19] = FormMain.KeyParam.Data_Send_Buff[13];
        if (arrayBuff[18] != (byte) 0 || arrayBuff[19] != (byte) 0)
          FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyGroupCharNum] = (byte) 5;
        arrayBuff[20] = FormMain.KeyParam.Data_Send_Buff[14];
        arrayBuff[21] = FormMain.KeyParam.Data_Send_Buff[15];
        if (arrayBuff[20] != (byte) 0 || arrayBuff[21] != (byte) 0)
          FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyGroupCharNum] = (byte) 6;
        arrayBuff[22] = FormMain.KeyParam.Data_Send_Buff[16];
        arrayBuff[23] = FormMain.KeyParam.Data_Send_Buff[17];
        if (arrayBuff[22] != (byte) 0 || arrayBuff[23] != (byte) 0)
          FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyGroupCharNum] = (byte) 7;
        arrayBuff[24] = FormMain.KeyParam.Data_Send_Buff[18];
        arrayBuff[25] = FormMain.KeyParam.Data_Send_Buff[19];
        if (arrayBuff[24] != (byte) 0 || arrayBuff[25] != (byte) 0)
          FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyGroupCharNum] = (byte) 8;
        arrayBuff[26] = FormMain.KeyParam.Data_Send_Buff[20];
        arrayBuff[27] = FormMain.KeyParam.Data_Send_Buff[21];
        if (arrayBuff[26] != (byte) 0 || arrayBuff[27] != (byte) 0)
          FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyGroupCharNum] = (byte) 9;
        arrayBuff[28] = FormMain.KeyParam.Data_Send_Buff[22];
        arrayBuff[29] = FormMain.KeyParam.Data_Send_Buff[23];
        if (arrayBuff[28] != (byte) 0 || arrayBuff[29] != (byte) 0)
          FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyGroupCharNum] = (byte) 10;
        arrayBuff[30] = FormMain.KeyParam.Data_Send_Buff[24];
        arrayBuff[31] = FormMain.KeyParam.Data_Send_Buff[25];
        if (arrayBuff[30] != (byte) 0 || arrayBuff[31] != (byte) 0)
          FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyGroupCharNum] = (byte) 11;
        arrayBuff[32] = FormMain.KeyParam.Data_Send_Buff[26];
        arrayBuff[33] = FormMain.KeyParam.Data_Send_Buff[27];
        if (arrayBuff[32] != (byte) 0 || arrayBuff[33] != (byte) 0)
          FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyGroupCharNum] = (byte) 12;
        arrayBuff[34] = FormMain.KeyParam.Data_Send_Buff[28];
        arrayBuff[35] = FormMain.KeyParam.Data_Send_Buff[29];
        if (arrayBuff[34] != (byte) 0 || arrayBuff[35] != (byte) 0)
          FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyGroupCharNum] = (byte) 13;
        arrayBuff[36] = FormMain.KeyParam.Data_Send_Buff[30];
        arrayBuff[37] = FormMain.KeyParam.Data_Send_Buff[31];
        if (arrayBuff[36] != (byte) 0 || arrayBuff[36] != (byte) 0)
          FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyGroupCharNum] = (byte) 14;
        arrayBuff[38] = FormMain.KeyParam.Data_Send_Buff[32];
        arrayBuff[39] = FormMain.KeyParam.Data_Send_Buff[33];
        if (arrayBuff[38] != (byte) 0 || arrayBuff[39] != (byte) 0)
          FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyGroupCharNum] = (byte) 15;
        arrayBuff[40] = FormMain.KeyParam.Data_Send_Buff[34];
        arrayBuff[41] = FormMain.KeyParam.Data_Send_Buff[35];
        if (arrayBuff[40] != (byte) 0 || arrayBuff[41] != (byte) 0)
          FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyGroupCharNum] = (byte) 16;
        arrayBuff[42] = FormMain.KeyParam.Data_Send_Buff[36];
        arrayBuff[43] = FormMain.KeyParam.Data_Send_Buff[37];
        if (arrayBuff[42] != (byte) 0 || arrayBuff[43] != (byte) 0)
          FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyGroupCharNum] = (byte) 17;
        arrayBuff[44] = FormMain.KeyParam.Data_Send_Buff[38];
        arrayBuff[45] = FormMain.KeyParam.Data_Send_Buff[39];
        if (arrayBuff[44] != (byte) 0 || arrayBuff[45] != (byte) 0)
          FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyGroupCharNum] = (byte) 18;
        arrayBuff[9] = FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyGroupCharNum];

        SendConfig(arrayBuff);
      }
      else
      {
        if (FormMain.KeyParam.ReportID == (byte) 0)
        {
          arrayBuff[1] = (FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyType_Num] &= (byte) 15);
        }
        else
        {
          this.Send_SwLayer();
          arrayBuff[1] = FormMain.KeyParam.KEY_Cur_Layer;
          arrayBuff[1] <<= 4;
          arrayBuff[1] |= FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyType_Num];
        }

        if (((int) FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyType_Num] & 15) == 1 || ((int) FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyType_Num] & 15) == 0)
        {
          arrayBuff[2] = FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyGroupCharNum];
          for (byte index = 0; (int) index <= (int) FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyGroupCharNum]; ++index)
          {
            arrayBuff[3] = index;
            switch (index)
            {
              case 0:
                arrayBuff[4] = FormMain.KeyParam.Data_Send_Buff[4];
                arrayBuff[5] = (byte) 0;
                break;
              case 1:
                arrayBuff[4] = FormMain.KeyParam.Data_Send_Buff[4];
                arrayBuff[5] = FormMain.KeyParam.Data_Send_Buff[5];
                break;
              case 2:
                arrayBuff[4] = FormMain.KeyParam.Data_Send_Buff[6];
                arrayBuff[5] = FormMain.KeyParam.Data_Send_Buff[7];
                break;
              case 3:
                arrayBuff[4] = FormMain.KeyParam.Data_Send_Buff[8];
                arrayBuff[5] = FormMain.KeyParam.Data_Send_Buff[9];
                break;
              case 4:
                arrayBuff[4] = FormMain.KeyParam.Data_Send_Buff[10];
                arrayBuff[5] = FormMain.KeyParam.Data_Send_Buff[11];
                break;
              case 5:
                arrayBuff[4] = FormMain.KeyParam.Data_Send_Buff[12];
                arrayBuff[5] = FormMain.KeyParam.Data_Send_Buff[13];
                break;
            }

            SendConfig(arrayBuff);
          }
          this.Send_WriteFlash_Cmd();
        }
        else if (((int) FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyType_Num] & 15) == 2)
        {
          arrayBuff[2] = FormMain.KeyParam.Data_Send_Buff[5];
          arrayBuff[3] = FormMain.KeyParam.Data_Send_Buff[6];
          SendConfig(arrayBuff);
          Send_WriteFlash_Cmd();
        }
        else if (((int) FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyType_Num] & 15) == 8)
        {
          arrayBuff[2] = FormMain.KeyParam.Data_Send_Buff[2];
          Console.WriteLine(PrintByteArray(arrayBuff));
          SendConfig(arrayBuff);
          Send_WriteFlashLED_Cmd();
        }
        else
        {
          if (((int) FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyType_Num] & 15) != 3)
            return;
          arrayBuff[2] = FormMain.KeyParam.Data_Send_Buff[5];
          arrayBuff[3] = FormMain.KeyParam.Data_Send_Buff[6];
          arrayBuff[4] = FormMain.KeyParam.Data_Send_Buff[7];
          arrayBuff[5] = FormMain.KeyParam.Data_Send_Buff[8];
          arrayBuff[6] = FormMain.KeyParam.Data_Send_Buff[9];
          SendConfig(arrayBuff);
          Send_WriteFlash_Cmd();
        }

      }
    }

    private string PrintByteArray(byte[] bytes)
    {
        var sb = new StringBuilder("[");
        foreach (var b in bytes)
        {
            sb.Append($"0x{b:x2}" + ", ");
        }
        sb.Append("]");
        return sb.ToString();
    }

    private void Key_Clear_Click(object sender, EventArgs e) => this.Key_Clear_Fun();

    private void Key_Clear_Fun()
    {
      this.Clear_Key_Char();
      this.Set_Key_Init();
      this.KEY_Colour_Init();
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum] = (byte) 0;
    }

    private void Page_change_Clear()
    {
      this.Clear_Key_Char();
      this.Set_Key_Init();
    }

    private void Clear_Key_Char()
    {
      for (int index = 0; index < 100; ++index)
      {
        FormMain.KeyParam.KeyChar[index] = (string) null;
        FormMain.KeyParam.FunKeyChar[index] = (string) null;
        FormMain.KeyParam.FunKEY_Char_Num = (byte) 0;
      }
    }

    private void Set_Key_Init()
    {
      FormMain.KeyParam.KEY_Char_Num = (byte) 5;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyType_Num] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyGroupCharNum] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyValNum] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.Key_Fun_Num] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 1] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 2] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 3] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 4] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 5] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 6] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 7] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 8] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 9] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 10] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 11] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 12] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 13] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 14] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 15] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 16] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 17] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 18] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 19] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 20] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 21] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 22] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 23] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 24] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 25] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 26] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 27] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 28] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 29] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 30] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 31] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 32] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 33] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 34] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 35] = (byte) 0;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 36] = (byte) 0;
    }

    private void KEY_Colour_Init()
    {
      int red = 152;
      int green = 251;
      int blue = 152;
      this.KEY1.BackColor = Color.FromArgb(red, green, blue);
      this.KEY2.BackColor = Color.FromArgb(red, green, blue);
      this.KEY3.BackColor = Color.FromArgb(red, green, blue);
      this.KEY4.BackColor = Color.FromArgb(red, green, blue);
      this.KEY5.BackColor = Color.FromArgb(red, green, blue);
      this.KEY6.BackColor = Color.FromArgb(red, green, blue);
      this.KEY7.BackColor = Color.FromArgb(red, green, blue);
      this.KEY8.BackColor = Color.FromArgb(red, green, blue);
      this.KEY9.BackColor = Color.FromArgb(red, green, blue);
      this.KEY10.BackColor = Color.FromArgb(red, green, blue);
      this.KEY11.BackColor = Color.FromArgb(red, green, blue);
      this.KEY12.BackColor = Color.FromArgb(red, green, blue);
      this.KEY13.BackColor = Color.FromArgb(red, green, blue);
      this.KEY14.BackColor = Color.FromArgb(red, green, blue);
      this.KEY15.BackColor = Color.FromArgb(red, green, blue);
      this.KEY16.BackColor = Color.FromArgb(red, green, blue);
      this.K1_Left.BackColor = Color.FromArgb(red, green, blue);
      this.K1_Centre.BackColor = Color.FromArgb(red, green, blue);
      this.K1_Right.BackColor = Color.FromArgb(red, green, blue);
      this.K2_Left.BackColor = Color.FromArgb(red, green, blue);
      this.K2_Centre.BackColor = Color.FromArgb(red, green, blue);
      this.K2_Right.BackColor = Color.FromArgb(red, green, blue);
      this.K3_Left.BackColor = Color.FromArgb(red, green, blue);
      this.K3_Centre.BackColor = Color.FromArgb(red, green, blue);
      this.K3_Right.BackColor = Color.FromArgb(red, green, blue);
    }

    private void KEY1_Click(object sender, EventArgs e)
    {
      if (FormMain.KeyParam.KEY_Cur_Page == (byte) 4)
        return;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum] = (byte) 1;
      this.Set_Key_Init();
      this.Clear_Key_Char();
      this.KEY_Colour_Init();
      this.KEY1.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void KEY2_Click(object sender, EventArgs e)
    {
      if (FormMain.KeyParam.KEY_Cur_Page == (byte) 4)
        return;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum] = (byte) 2;
      this.Set_Key_Init();
      this.Clear_Key_Char();
      this.KEY_Colour_Init();
      this.KEY2.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void KEY3_Click(object sender, EventArgs e)
    {
      if (FormMain.KeyParam.KEY_Cur_Page == (byte) 4)
        return;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum] = (byte) 3;
      this.Set_Key_Init();
      this.Clear_Key_Char();
      this.KEY_Colour_Init();
      this.KEY3.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void KEY4_Click(object sender, EventArgs e)
    {
      if (FormMain.KeyParam.KEY_Cur_Page == (byte) 4)
        return;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum] = (byte) 4;
      this.Set_Key_Init();
      this.Clear_Key_Char();
      this.KEY_Colour_Init();
      this.KEY4.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void KEY5_Click(object sender, EventArgs e)
    {
      if (FormMain.KeyParam.KEY_Cur_Page == (byte) 4)
        return;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum] = (byte) 5;
      this.Set_Key_Init();
      this.Clear_Key_Char();
      this.KEY_Colour_Init();
      this.KEY5.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void KEY6_Click(object sender, EventArgs e)
    {
      if (FormMain.KeyParam.KEY_Cur_Page == (byte) 4)
        return;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum] = (byte) 6;
      this.Set_Key_Init();
      this.Clear_Key_Char();
      this.KEY_Colour_Init();
      this.KEY6.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void KEY7_Click(object sender, EventArgs e)
    {
      if (FormMain.KeyParam.KEY_Cur_Page == (byte) 4)
        return;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum] = (byte) 7;
      this.Set_Key_Init();
      this.Clear_Key_Char();
      this.KEY_Colour_Init();
      this.KEY7.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void KEY8_Click(object sender, EventArgs e)
    {
      if (FormMain.KeyParam.KEY_Cur_Page == (byte) 4)
        return;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum] = (byte) 8;
      this.Set_Key_Init();
      this.Clear_Key_Char();
      this.KEY_Colour_Init();
      this.KEY8.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void KEY9_Click(object sender, EventArgs e)
    {
      if (FormMain.KeyParam.KEY_Cur_Page == (byte) 4)
        return;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum] = (byte) 9;
      this.Set_Key_Init();
      this.Clear_Key_Char();
      this.KEY_Colour_Init();
      this.KEY9.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void KEY10_Click(object sender, EventArgs e)
    {
      if (FormMain.KeyParam.KEY_Cur_Page == (byte) 4)
        return;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum] = (byte) 10;
      this.Set_Key_Init();
      this.Clear_Key_Char();
      this.KEY_Colour_Init();
      this.KEY10.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void KEY11_Click(object sender, EventArgs e)
    {
      if (FormMain.KeyParam.KEY_Cur_Page == (byte) 4)
        return;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum] = (byte) 11;
      this.Set_Key_Init();
      this.Clear_Key_Char();
      this.KEY_Colour_Init();
      this.KEY11.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void KEY12_Click(object sender, EventArgs e)
    {
      if (FormMain.KeyParam.KEY_Cur_Page == (byte) 4)
        return;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum] = (byte) 12;
      this.Set_Key_Init();
      this.Clear_Key_Char();
      this.KEY_Colour_Init();
      this.KEY12.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void K1_Left_Click(object sender, EventArgs e)
    {
      if (FormMain.KeyParam.KEY_Cur_Page == (byte) 4)
        return;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum] = FormMain.KeyParam.New_Mul_Mouse != (byte) 1 ? (byte) 13 : (byte) 16;
      this.Set_Key_Init();
      this.Clear_Key_Char();
      this.KEY_Colour_Init();
      this.K1_Left.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void K1_Centre_Click(object sender, EventArgs e)
    {
      if (FormMain.KeyParam.KEY_Cur_Page == (byte) 4)
        return;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum] = FormMain.KeyParam.New_Mul_Mouse != (byte) 1 ? (byte) 14 : (byte) 17;
      this.Set_Key_Init();
      this.Clear_Key_Char();
      this.KEY_Colour_Init();
      this.K1_Centre.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void K1_Right_Click(object sender, EventArgs e)
    {
      if (FormMain.KeyParam.KEY_Cur_Page == (byte) 4)
        return;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum] = FormMain.KeyParam.New_Mul_Mouse != (byte) 1 ? (byte) 15 : (byte) 18;
      this.Set_Key_Init();
      this.Clear_Key_Char();
      this.KEY_Colour_Init();
      this.K1_Right.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void K2_Left_Click(object sender, EventArgs e)
    {
      if (FormMain.KeyParam.KEY_Cur_Page == (byte) 4)
        return;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum] = FormMain.KeyParam.New_Mul_Mouse != (byte) 1 ? (byte) 16 : (byte) 19;
      this.Set_Key_Init();
      this.Clear_Key_Char();
      this.KEY_Colour_Init();
      this.K2_Left.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void K2_Centre_Click(object sender, EventArgs e)
    {
      if (FormMain.KeyParam.KEY_Cur_Page == (byte) 4)
        return;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum] = FormMain.KeyParam.New_Mul_Mouse != (byte) 1 ? (byte) 17 : (byte) 20;
      this.Set_Key_Init();
      this.Clear_Key_Char();
      this.KEY_Colour_Init();
      this.K2_Centre.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void K2_Right_Click(object sender, EventArgs e)
    {
      if (FormMain.KeyParam.KEY_Cur_Page == (byte) 4)
        return;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum] = FormMain.KeyParam.New_Mul_Mouse != (byte) 1 ? (byte) 18 : (byte) 21;
      this.Set_Key_Init();
      this.Clear_Key_Char();
      this.KEY_Colour_Init();
      this.K2_Right.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void K3_Left_Click(object sender, EventArgs e)
    {
      if (FormMain.KeyParam.KEY_Cur_Page == (byte) 4)
        return;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum] = 0x16;
      this.Set_Key_Init();
      this.Clear_Key_Char();
      this.KEY_Colour_Init();
      this.K3_Left.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void K3_Centre_Click(object sender, EventArgs e)
    {
      if (FormMain.KeyParam.KEY_Cur_Page == (byte) 4)
        return;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum] = 0x17;
      this.Set_Key_Init();
      this.Clear_Key_Char();
      this.KEY_Colour_Init();
      this.K3_Centre.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void K3_Right_Click(object sender, EventArgs e)
    {
      if (FormMain.KeyParam.KEY_Cur_Page == (byte) 4)
        return;
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeySet_KeyNum] = 0x18;
      this.Set_Key_Init();
      this.Clear_Key_Char();
      this.KEY_Colour_Init();
      this.K3_Right.BackColor = Color.FromArgb((int) byte.MaxValue, 48, 48);
    }

    private void Lanuage_Set_ZH()
    {
      Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("zh-CN");
      this.ApplyResource();
    }

    private void Lanuage_Set_EN()
    {
      Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
      this.ApplyResource();
    }

    private void ApplyResource()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormMain));
      foreach (Control control in (ArrangedElementCollection) this.Controls)
        componentResourceManager.ApplyResources((object) control, control.Name);
      this.ResumeLayout(false);
      this.PerformLayout();
      componentResourceManager.ApplyResources((object) this, "$this");
    }

    private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
    {
    }

    private void SetFunText_TextChanged(object sender, EventArgs e)
    {
    }

    private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void pictureBox1_Click(object sender, EventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormMain));
      this.splitContainer1 = new SplitContainer();
      this.flowLayoutPanel1 = new FlowLayoutPanel();
      this.stateLabel = new Label();
      this.fdToolStripMenuItem = new ToolStripMenuItem();
      this.Download = new Button();
      this.KEY1 = new Button();
      this.KEY2 = new Button();
      this.KEY3 = new Button();
      this.KEY4 = new Button();
      this.K1_Left = new Button();
      this.K1_Centre = new Button();
      this.K1_Right = new Button();
      this.SetText = new TextBox();
      this.Key_Clear = new Button();
      this.KEY8 = new Button();
      this.KEY7 = new Button();
      this.KEY6 = new Button();
      this.KEY5 = new Button();
      this.KEY12 = new Button();
      this.KEY11 = new Button();
      this.KEY10 = new Button();
      this.KEY9 = new Button();
      this.KEY16 = new Button();
      this.KEY15 = new Button();
      this.KEY14 = new Button();
      this.KEY13 = new Button();
      this.K2_Right = new Button();
      this.K2_Centre = new Button();
      this.K2_Left = new Button();
      this.SetFunText = new TextBox();
      this.K3_Left = new Button();
      this.K3_Centre = new Button();
      this.K3_Right = new Button();
      this.flowLayoutPanel_LayerFun = new FlowLayoutPanel();
      this.pictureBox1 = new PictureBox();
      this.label_Dowload_Dsp = new Label();
      this.splitContainer1.BeginInit();
      this.splitContainer1.SuspendLayout();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.splitContainer1, "splitContainer1");
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Panel1.Paint += new PaintEventHandler(this.splitContainer1_Panel1_Paint);
      this.splitContainer1.Panel2.Paint += new PaintEventHandler(this.splitContainer1_Panel2_Paint);
      componentResourceManager.ApplyResources((object) this.flowLayoutPanel1, "flowLayoutPanel1");
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      componentResourceManager.ApplyResources((object) this.stateLabel, "stateLabel");
      this.stateLabel.BackColor = SystemColors.ActiveCaption;
      this.stateLabel.Name = "stateLabel";
      this.fdToolStripMenuItem.Name = "fdToolStripMenuItem";
      componentResourceManager.ApplyResources((object) this.fdToolStripMenuItem, "fdToolStripMenuItem");
      componentResourceManager.ApplyResources((object) this.Download, "Download");
      this.Download.Name = "Download";
      this.Download.UseVisualStyleBackColor = true;
      this.Download.Click += new EventHandler(this.Download_Click);
      componentResourceManager.ApplyResources((object) this.KEY1, "KEY1");
      this.KEY1.Name = "KEY1";
      this.KEY1.UseVisualStyleBackColor = true;
      this.KEY1.Click += new EventHandler(this.KEY1_Click);
      componentResourceManager.ApplyResources((object) this.KEY2, "KEY2");
      this.KEY2.Name = "KEY2";
      this.KEY2.UseVisualStyleBackColor = true;
      this.KEY2.Click += new EventHandler(this.KEY2_Click);
      componentResourceManager.ApplyResources((object) this.KEY3, "KEY3");
      this.KEY3.Name = "KEY3";
      this.KEY3.UseVisualStyleBackColor = true;
      this.KEY3.Click += new EventHandler(this.KEY3_Click);
      componentResourceManager.ApplyResources((object) this.KEY4, "KEY4");
      this.KEY4.Name = "KEY4";
      this.KEY4.UseVisualStyleBackColor = true;
      this.KEY4.Click += new EventHandler(this.KEY4_Click);
      componentResourceManager.ApplyResources((object) this.K1_Left, "K1_Left");
      this.K1_Left.Name = "K1_Left";
      this.K1_Left.UseVisualStyleBackColor = true;
      this.K1_Left.Click += new EventHandler(this.K1_Left_Click);
      componentResourceManager.ApplyResources((object) this.K1_Centre, "K1_Centre");
      this.K1_Centre.Name = "K1_Centre";
      this.K1_Centre.UseVisualStyleBackColor = true;
      this.K1_Centre.Click += new EventHandler(this.K1_Centre_Click);
      componentResourceManager.ApplyResources((object) this.K1_Right, "K1_Right");
      this.K1_Right.Name = "K1_Right";
      this.K1_Right.UseVisualStyleBackColor = true;
      this.K1_Right.Click += new EventHandler(this.K1_Right_Click);
      componentResourceManager.ApplyResources((object) this.SetText, "SetText");
      this.SetText.Name = "SetText";
      componentResourceManager.ApplyResources((object) this.Key_Clear, "Key_Clear");
      this.Key_Clear.Name = "Key_Clear";
      this.Key_Clear.UseVisualStyleBackColor = true;
      this.Key_Clear.Click += new EventHandler(this.Key_Clear_Click);
      componentResourceManager.ApplyResources((object) this.KEY8, "KEY8");
      this.KEY8.Name = "KEY8";
      this.KEY8.UseVisualStyleBackColor = true;
      this.KEY8.Click += new EventHandler(this.KEY8_Click);
      componentResourceManager.ApplyResources((object) this.KEY7, "KEY7");
      this.KEY7.Name = "KEY7";
      this.KEY7.UseVisualStyleBackColor = true;
      this.KEY7.Click += new EventHandler(this.KEY7_Click);
      componentResourceManager.ApplyResources((object) this.KEY6, "KEY6");
      this.KEY6.Name = "KEY6";
      this.KEY6.UseVisualStyleBackColor = true;
      this.KEY6.Click += new EventHandler(this.KEY6_Click);
      componentResourceManager.ApplyResources((object) this.KEY5, "KEY5");
      this.KEY5.Name = "KEY5";
      this.KEY5.UseVisualStyleBackColor = true;
      this.KEY5.Click += new EventHandler(this.KEY5_Click);
      componentResourceManager.ApplyResources((object) this.KEY12, "KEY12");
      this.KEY12.Name = "KEY12";
      this.KEY12.UseVisualStyleBackColor = true;
      this.KEY12.Click += new EventHandler(this.KEY12_Click);
      componentResourceManager.ApplyResources((object) this.KEY11, "KEY11");
      this.KEY11.Name = "KEY11";
      this.KEY11.UseVisualStyleBackColor = true;
      this.KEY11.Click += new EventHandler(this.KEY11_Click);
      componentResourceManager.ApplyResources((object) this.KEY10, "KEY10");
      this.KEY10.Name = "KEY10";
      this.KEY10.UseVisualStyleBackColor = true;
      this.KEY10.Click += new EventHandler(this.KEY10_Click);
      componentResourceManager.ApplyResources((object) this.KEY9, "KEY9");
      this.KEY9.Name = "KEY9";
      this.KEY9.UseVisualStyleBackColor = true;
      this.KEY9.Click += new EventHandler(this.KEY9_Click);
      componentResourceManager.ApplyResources((object) this.KEY16, "KEY16");
      this.KEY16.Name = "KEY16";
      this.KEY16.UseVisualStyleBackColor = true;
      componentResourceManager.ApplyResources((object) this.KEY15, "KEY15");
      this.KEY15.Name = "KEY15";
      this.KEY15.UseVisualStyleBackColor = true;
      componentResourceManager.ApplyResources((object) this.KEY14, "KEY14");
      this.KEY14.Name = "KEY14";
      this.KEY14.UseVisualStyleBackColor = true;
      componentResourceManager.ApplyResources((object) this.KEY13, "KEY13");
      this.KEY13.Name = "KEY13";
      this.KEY13.UseVisualStyleBackColor = true;
      componentResourceManager.ApplyResources((object) this.K2_Right, "K2_Right");
      this.K2_Right.Name = "K2_Right";
      this.K2_Right.UseVisualStyleBackColor = true;
      this.K2_Right.Click += new EventHandler(this.K2_Right_Click);
      componentResourceManager.ApplyResources((object) this.K2_Centre, "K2_Centre");
      this.K2_Centre.Name = "K2_Centre";
      this.K2_Centre.UseVisualStyleBackColor = true;
      this.K2_Centre.Click += new EventHandler(this.K2_Centre_Click);
      componentResourceManager.ApplyResources((object) this.K2_Left, "K2_Left");
      this.K2_Left.Name = "K2_Left";
      this.K2_Left.UseVisualStyleBackColor = true;
      this.K2_Left.Click += new EventHandler(this.K2_Left_Click);
      componentResourceManager.ApplyResources((object) this.SetFunText, "SetFunText");
      this.SetFunText.Name = "SetFunText";
      this.SetFunText.TextChanged += new EventHandler(this.SetFunText_TextChanged);
      componentResourceManager.ApplyResources((object) this.K3_Left, "K3_Left");
      this.K3_Left.Name = "K3_Left";
      this.K3_Left.UseVisualStyleBackColor = true;
      this.K3_Left.Click += new EventHandler(this.K3_Left_Click);
      componentResourceManager.ApplyResources((object) this.K3_Centre, "K3_Centre");
      this.K3_Centre.Name = "K3_Centre";
      this.K3_Centre.UseVisualStyleBackColor = true;
      this.K3_Centre.Click += new EventHandler(this.K3_Centre_Click);
      componentResourceManager.ApplyResources((object) this.K3_Right, "K3_Right");
      this.K3_Right.Name = "K3_Right";
      this.K3_Right.UseVisualStyleBackColor = true;
      this.K3_Right.Click += new EventHandler(this.K3_Right_Click);
      componentResourceManager.ApplyResources((object) this.flowLayoutPanel_LayerFun, "flowLayoutPanel_LayerFun");
      this.flowLayoutPanel_LayerFun.Name = "flowLayoutPanel_LayerFun";
      this.pictureBox1.BackColor = Color.FromArgb(192, 192, (int) byte.MaxValue);
      componentResourceManager.ApplyResources((object) this.pictureBox1, "pictureBox1");
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
      componentResourceManager.ApplyResources((object) this.label_Dowload_Dsp, "label_Dowload_Dsp");
      this.label_Dowload_Dsp.Name = "label_Dowload_Dsp";
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.flowLayoutPanel1);
      this.Controls.Add((Control) this.label_Dowload_Dsp);
      this.Controls.Add((Control) this.flowLayoutPanel_LayerFun);
      this.Controls.Add((Control) this.SetFunText);
      this.Controls.Add((Control) this.K3_Right);
      this.Controls.Add((Control) this.K3_Centre);
      this.Controls.Add((Control) this.K3_Left);
      this.Controls.Add((Control) this.K2_Right);
      this.Controls.Add((Control) this.K2_Centre);
      this.Controls.Add((Control) this.K2_Left);
      this.Controls.Add((Control) this.KEY16);
      this.Controls.Add((Control) this.KEY15);
      this.Controls.Add((Control) this.KEY14);
      this.Controls.Add((Control) this.KEY13);
      this.Controls.Add((Control) this.KEY12);
      this.Controls.Add((Control) this.KEY11);
      this.Controls.Add((Control) this.KEY10);
      this.Controls.Add((Control) this.KEY9);
      this.Controls.Add((Control) this.KEY8);
      this.Controls.Add((Control) this.KEY7);
      this.Controls.Add((Control) this.KEY6);
      this.Controls.Add((Control) this.KEY5);
      this.Controls.Add((Control) this.Key_Clear);
      this.Controls.Add((Control) this.SetText);
      this.Controls.Add((Control) this.K1_Right);
      this.Controls.Add((Control) this.K1_Centre);
      this.Controls.Add((Control) this.K1_Left);
      this.Controls.Add((Control) this.KEY4);
      this.Controls.Add((Control) this.KEY3);
      this.Controls.Add((Control) this.KEY2);
      this.Controls.Add((Control) this.KEY1);
      this.Controls.Add((Control) this.Download);
      this.Controls.Add((Control) this.stateLabel);
      this.Controls.Add((Control) this.splitContainer1);
      this.Controls.Add((Control) this.pictureBox1);
      this.Cursor = Cursors.Default;
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.Name = nameof (FormMain);
      this.splitContainer1.EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public class KeyParam
    {
      public static byte[] Data_Send_Buff = new byte[65];
      public static byte[] Protocol2_Sd_Buff = new byte[65];
      public static byte New_Mul_Mouse = 0;
      public static byte Sd_Protocol_Type = 1;
      public static byte KeySet_KeyNum = 0;
      public static byte KeyType_Num = 1;
      public static byte KeyGroupCharNum = 2;
      public static byte KeySet_KeyValNum = 3;
      public static byte Key_Fun_Num = 4;
      public static byte KEY_Char_Num = 5;
      public static byte PageBet_Inte_Cmd = 0;
      public static string[] KeyChar = new string[100];
      public static string[] FunKeyChar = new string[100];
      public static byte FunKEY_Char_Num = 0;
      public static byte ReportID = 0;
      public static byte KEY_Cur_Layer = 1;
      public static byte KEY_Cur_Page = 1;
      public static byte Language_Set = 0;
    }
  }
}
