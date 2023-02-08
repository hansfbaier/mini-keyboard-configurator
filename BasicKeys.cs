using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HIDTester
{
  public class BasicKeys : UserControl
  {
    private IContainer components;
    private Button KEY_A;
    private Button KEY_B;
    private Button KEY_C;
    private Button KEY_D;
    private Button KEY_E;
    private Button KEY_F;
    private Button KEY_G;
    private Button KEY_H;
    private Button KEY_I;
    private Button KEY_J;
    private Button KEY_K;
    private Button KEY_W;
    private Button KEY_V;
    private Button KEY_U;
    private Button KEY_T;
    private Button KEY_S;
    private Button KEY_R;
    private Button KEY_Q;
    private Button KEY_P;
    private Button KEY_O;
    private Button KEY_N;
    private Button KEY_M;
    private Button KEY_L;
    private Button KEY_8;
    private Button KEY_7;
    private Button KEY_6;
    private Button KEY_5;
    private Button KEY_4;
    private Button KEY_3;
    private Button KEY_2;
    private Button KEY_1;
    private Button KEY_9;
    private Button KEY_Z;
    private Button KEY_Y;
    private Button KEY_X;
    private Button KEY_0;
    private Button KEY_F12;
    private Button KEY_F11;
    private Button KEY_F10;
    private Button KEY_F9;
    private Button KEY_F8;
    private Button KEY_F7;
    private Button KEY_F6;
    private Button KEY_F5;
    private Button KEY_F4;
    private Button KEY_F3;
    private Button KEY_F2;
    private Button KEY_F1;
    private Button KEY_ESC;
    private Button KEY_PrtSc;
    private Button KEY_PauseBreak;
    private Button KEY_INS;
    private Button KEY_DEL;
    private Button KEY_HOME;
    private Button KEY_PgUg;
    private Button KEY_PgDn;
    private Button KEY_End;
    private Button KEY_SubSub;
    private Button KEY_ADDADD;
    private Button KEY_BACKSPACE;
    private Button KEY_Tabel;
    private Button KEY_kuohao;
    private Button KEY_kuohao2;
    private Button KEY_shu;
    private Button KEY_fenhao;
    private Button KEY_yinghao;
    private Button KEY_Enter;
    private Button KEY_bolanghao;
    private Button KEY_douhao;
    private Button KEY_juhao;
    private Button KEY_wenhao;
    private Button KEY_jiantou_left;
    private Button KEY_jiantou_Up;
    private Button KEY_jiantou_Down;
    private Button KEY_jiantou_right;
    private Button KEY_add;
    private Button KEY_sub;
    private Button KEY_multiply;
    private Button KEY_DIV;
    private Button KEY_NUM;
    private Button KEY_MIN_0;
    private Button KEY_MIN_9;
    private Button KEY_MIN_8;
    private Button KEY_MIN_7;
    private Button KEY_MIN_6;
    private Button KEY_MIN_5;
    private Button KEY_MIN_4;
    private Button KEY_MIN_3;
    private Button KEY_MIN_2;
    private Button KEY_MIN_1;
    private Button KEY_MIN_Dot;
    private Button KEY_CapsLock;
    private Button KEY_SpaceKey;
    private Button KEY_ScrollLock;
    private Button KEY_Menu;
    private Button Key_Ctrl;
    private Button Key_Shift;
    private Button Key_Alt;
    private Button Key_Win;
    private Button KEY_NILL;

    public BasicKeys() => this.InitializeComponent();

    private void General_Char_Set()
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyType_Num] |= (byte) 1;
      FormMain.KeyParam.KEY_Char_Num += (byte) 2;
      ++FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyGroupCharNum];
    }

    private void KEY_A_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 4;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "A";
      this.General_Char_Set();
    }

    private void KEY_B_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 5;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "B";
      this.General_Char_Set();
    }

    private void KEY_C_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 6;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "C";
      this.General_Char_Set();
    }

    private void KEY_D_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 7;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "D";
      this.General_Char_Set();
    }

    private void KEY_E_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 8;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "E";
      this.General_Char_Set();
    }

    private void KEY_F_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 9;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "F";
      this.General_Char_Set();
    }

    private void KEY_G_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 10;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "G";
      this.General_Char_Set();
    }

    private void KEY_H_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 11;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "H";
      this.General_Char_Set();
    }

    private void KEY_I_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 12;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "I";
      this.General_Char_Set();
    }

    private void KEY_J_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 13;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "J";
      this.General_Char_Set();
    }

    private void KEY_K_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 14;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "K";
      this.General_Char_Set();
    }

    private void KEY_L_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 15;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "L";
      this.General_Char_Set();
    }

    private void KEY_M_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 16;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "M";
      this.General_Char_Set();
    }

    private void KEY_N_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 17;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "N";
      this.General_Char_Set();
    }

    private void KEY_O_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 18;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "O";
      this.General_Char_Set();
    }

    private void KEY_P_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 19;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "P";
      this.General_Char_Set();
    }

    private void KEY_Q_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 20;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "Q";
      this.General_Char_Set();
    }

    private void KEY_R_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 21;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "R";
      this.General_Char_Set();
    }

    private void KEY_S_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 22;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "S";
      this.General_Char_Set();
    }

    private void KEY_T_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 23;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "T";
      this.General_Char_Set();
    }

    private void KEY_U_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 24;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "U";
      this.General_Char_Set();
    }

    private void KEY_V_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 25;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "V";
      this.General_Char_Set();
    }

    private void KEY_W_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 26;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "W";
      this.General_Char_Set();
    }

    private void KEY_X_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 27;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "X";
      this.General_Char_Set();
    }

    private void KEY_Y_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 28;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "Y";
      this.General_Char_Set();
    }

    private void KEY_Z_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 29;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "Z";
      this.General_Char_Set();
    }

    private void KEY_1_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 30;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "!1";
      this.General_Char_Set();
    }

    private void KEY_2_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 31;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "@2";
      this.General_Char_Set();
    }

    private void KEY_3_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 32;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "#3";
      this.General_Char_Set();
    }

    private void KEY_4_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 33;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "$4";
      this.General_Char_Set();
    }

    private void KEY_5_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 34;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "%5";
      this.General_Char_Set();
    }

    private void KEY_6_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 35;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "^6";
      this.General_Char_Set();
    }

    private void KEY_7_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 36;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "&7";
      this.General_Char_Set();
    }

    private void KEY_8_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 37;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "*8";
      this.General_Char_Set();
    }

    private void KEY_9_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 38;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "(9";
      this.General_Char_Set();
    }

    private void KEY_0_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 39;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = ")0";
      this.General_Char_Set();
    }

    private void KEY_Enter_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 40;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "Enter";
      this.General_Char_Set();
    }

    private void KEY_ESC_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 41;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "ESC";
      this.General_Char_Set();
    }

    private void KEY_BACKSPACE_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 42;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "BackSpace";
      this.General_Char_Set();
    }

    private void KEY_Tabel_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 43;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "Tab";
      this.General_Char_Set();
    }

    private void KEY_SpaceKey_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 44;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "Space";
      this.General_Char_Set();
    }

    private void KEY_SubSub_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 45;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "￣－";
      this.General_Char_Set();
    }

    private void KEY_ADDADD_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 46;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "+=";
      this.General_Char_Set();
    }

    private void KEY_kuohao_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 47;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "{[";
      this.General_Char_Set();
    }

    private void KEY_kuohao2_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 48;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "}]";
      this.General_Char_Set();
    }

    private void KEY_shu_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 49;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "|\\";
      this.General_Char_Set();
    }

    private void KEY_bolanghao_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 53;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "~、";
      this.General_Char_Set();
    }

    private void KEY_fenhao_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 51;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = ":;";
      this.General_Char_Set();
    }

    private void KEY_yinghao_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 52;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "\"'";
      this.General_Char_Set();
    }

    private void KEY_douhao_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 54;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "<,";
      this.General_Char_Set();
    }

    private void KEY_juhao_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 55;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = ">.";
      this.General_Char_Set();
    }

    private void KEY_wenhao_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 56;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "?/";
      this.General_Char_Set();
    }

    private void KEY_CapsLock_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 57;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "CapsLock";
      this.General_Char_Set();
    }

    private void KEY_F1_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 58;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "F1";
      this.General_Char_Set();
    }

    private void KEY_F2_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 59;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "F2";
      this.General_Char_Set();
    }

    private void KEY_F3_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 60;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "F3";
      this.General_Char_Set();
    }

    private void KEY_F4_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 61;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "F4";
      this.General_Char_Set();
    }

    private void KEY_F5_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 62;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "F5";
      this.General_Char_Set();
    }

    private void KEY_F6_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 63;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "F6";
      this.General_Char_Set();
    }

    private void KEY_F7_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 64;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "F7";
      this.General_Char_Set();
    }

    private void KEY_F8_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 65;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "F8";
      this.General_Char_Set();
    }

    private void KEY_F9_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 66;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "F9";
      this.General_Char_Set();
    }

    private void KEY_F10_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 67;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "F10";
      this.General_Char_Set();
    }

    private void KEY_F11_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 68;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "F11";
      this.General_Char_Set();
    }

    private void KEY_F12_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 69;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "F12";
      this.General_Char_Set();
    }

    private void KEY_PrtSc_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 70;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "PrtSc";
      this.General_Char_Set();
    }

    private void KEY_ScrollLock_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 71;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "ScLock";
      this.General_Char_Set();
    }

    private void KEY_PauseBreak_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 72;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "PaBk";
      this.General_Char_Set();
    }

    private void KEY_INS_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 73;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "Ins";
      this.General_Char_Set();
    }

    private void KEY_HOME_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 74;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "Home";
      this.General_Char_Set();
    }

    private void KEY_PgUg_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 75;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "PageUp";
      this.General_Char_Set();
    }

    private void KEY_DEL_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 76;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "Delete";
      this.General_Char_Set();
    }

    private void KEY_End_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 77;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "End";
      this.General_Char_Set();
    }

    private void KEY_PgDn_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 78;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "PageDown";
      this.General_Char_Set();
    }

    private void KEY_jiantou_right_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 79;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "→";
      this.General_Char_Set();
    }

    private void KEY_jiantou_left_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 80;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "←";
      this.General_Char_Set();
    }

    private void KEY_jiantou_Down_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 81;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "↓";
      this.General_Char_Set();
    }

    private void KEY_jiantou_Up_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 82;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "↑";
      this.General_Char_Set();
    }

    private void KEY_NUM_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 83;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "NumLock";
      this.General_Char_Set();
    }

    private void KEY_DIV_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 84;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "÷";
      this.General_Char_Set();
    }

    private void KEY_multiply_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 85;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "×";
      this.General_Char_Set();
    }

    private void KEY_sub_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 86;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "－";
      this.General_Char_Set();
    }

    private void KEY_add_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 87;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "＋";
      this.General_Char_Set();
    }

    private void KEY_MIN_1_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 89;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "1";
      this.General_Char_Set();
    }

    private void KEY_MIN_2_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 90;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "2";
      this.General_Char_Set();
    }

    private void KEY_MIN_3_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 91;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "3";
      this.General_Char_Set();
    }

    private void KEY_MIN_4_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 92;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "4";
      this.General_Char_Set();
    }

    private void KEY_MIN_5_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 93;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "5";
      this.General_Char_Set();
    }

    private void KEY_MIN_6_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 94;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "6";
      this.General_Char_Set();
    }

    private void KEY_MIN_7_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 95;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "7";
      this.General_Char_Set();
    }

    private void KEY_MIN_8_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 96;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "8";
      this.General_Char_Set();
    }

    private void KEY_MIN_9_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 97;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "9";
      this.General_Char_Set();
    }

    private void KEY_MIN_0_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 98;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "0";
      this.General_Char_Set();
    }

    private void KEY_MIN_Dot_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 99;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "▪";
      this.General_Char_Set();
    }

    private void KEY_Menu_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 101;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "▤";
      this.General_Char_Set();
    }

    private void Key_Ctrl_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 1;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Ctrl";
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyType_Num] |= (byte) 1;
      ++FormMain.KeyParam.FunKEY_Char_Num;
    }

    private void Key_Shift_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 2;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Shift";
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyType_Num] |= (byte) 1;
      ++FormMain.KeyParam.FunKEY_Char_Num;
    }

    private void Key_Alt_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 4;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Alt";
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyType_Num] |= (byte) 1;
      ++FormMain.KeyParam.FunKEY_Char_Num;
    }

    private void Key_Win_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num - 1] |= (byte) 8;
      FormMain.KeyParam.FunKeyChar[(int) FormMain.KeyParam.FunKEY_Char_Num] = "Win";
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyType_Num] |= (byte) 1;
      ++FormMain.KeyParam.FunKEY_Char_Num;
    }

    private void KEY_NILL_Click(object sender, EventArgs e)
    {
      FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyType_Num] = (byte) 0;
      FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = "NULL";
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.KEY_A = new Button();
      this.KEY_B = new Button();
      this.KEY_C = new Button();
      this.KEY_D = new Button();
      this.KEY_E = new Button();
      this.KEY_F = new Button();
      this.KEY_G = new Button();
      this.KEY_H = new Button();
      this.KEY_I = new Button();
      this.KEY_J = new Button();
      this.KEY_K = new Button();
      this.KEY_W = new Button();
      this.KEY_V = new Button();
      this.KEY_U = new Button();
      this.KEY_T = new Button();
      this.KEY_S = new Button();
      this.KEY_R = new Button();
      this.KEY_Q = new Button();
      this.KEY_P = new Button();
      this.KEY_O = new Button();
      this.KEY_N = new Button();
      this.KEY_M = new Button();
      this.KEY_L = new Button();
      this.KEY_8 = new Button();
      this.KEY_7 = new Button();
      this.KEY_6 = new Button();
      this.KEY_5 = new Button();
      this.KEY_4 = new Button();
      this.KEY_3 = new Button();
      this.KEY_2 = new Button();
      this.KEY_1 = new Button();
      this.KEY_9 = new Button();
      this.KEY_Z = new Button();
      this.KEY_Y = new Button();
      this.KEY_X = new Button();
      this.KEY_0 = new Button();
      this.KEY_F12 = new Button();
      this.KEY_F11 = new Button();
      this.KEY_F10 = new Button();
      this.KEY_F9 = new Button();
      this.KEY_F8 = new Button();
      this.KEY_F7 = new Button();
      this.KEY_F6 = new Button();
      this.KEY_F5 = new Button();
      this.KEY_F4 = new Button();
      this.KEY_F3 = new Button();
      this.KEY_F2 = new Button();
      this.KEY_F1 = new Button();
      this.KEY_ESC = new Button();
      this.KEY_PrtSc = new Button();
      this.KEY_PauseBreak = new Button();
      this.KEY_INS = new Button();
      this.KEY_DEL = new Button();
      this.KEY_HOME = new Button();
      this.KEY_PgUg = new Button();
      this.KEY_PgDn = new Button();
      this.KEY_End = new Button();
      this.KEY_SubSub = new Button();
      this.KEY_ADDADD = new Button();
      this.KEY_BACKSPACE = new Button();
      this.KEY_Tabel = new Button();
      this.KEY_kuohao = new Button();
      this.KEY_kuohao2 = new Button();
      this.KEY_shu = new Button();
      this.KEY_fenhao = new Button();
      this.KEY_yinghao = new Button();
      this.KEY_Enter = new Button();
      this.KEY_bolanghao = new Button();
      this.KEY_douhao = new Button();
      this.KEY_juhao = new Button();
      this.KEY_wenhao = new Button();
      this.KEY_jiantou_left = new Button();
      this.KEY_jiantou_Up = new Button();
      this.KEY_jiantou_Down = new Button();
      this.KEY_jiantou_right = new Button();
      this.KEY_add = new Button();
      this.KEY_sub = new Button();
      this.KEY_multiply = new Button();
      this.KEY_DIV = new Button();
      this.KEY_NUM = new Button();
      this.KEY_MIN_0 = new Button();
      this.KEY_MIN_9 = new Button();
      this.KEY_MIN_8 = new Button();
      this.KEY_MIN_7 = new Button();
      this.KEY_MIN_6 = new Button();
      this.KEY_MIN_5 = new Button();
      this.KEY_MIN_4 = new Button();
      this.KEY_MIN_3 = new Button();
      this.KEY_MIN_2 = new Button();
      this.KEY_MIN_1 = new Button();
      this.KEY_MIN_Dot = new Button();
      this.KEY_CapsLock = new Button();
      this.KEY_SpaceKey = new Button();
      this.KEY_ScrollLock = new Button();
      this.KEY_Menu = new Button();
      this.Key_Ctrl = new Button();
      this.Key_Shift = new Button();
      this.Key_Alt = new Button();
      this.Key_Win = new Button();
      this.KEY_NILL = new Button();
      this.SuspendLayout();
      this.KEY_A.Location = new Point(4, 94);
      this.KEY_A.Name = "KEY_A";
      this.KEY_A.Size = new Size(44, 23);
      this.KEY_A.TabIndex = 0;
      this.KEY_A.Text = "A";
      this.KEY_A.UseVisualStyleBackColor = true;
      this.KEY_A.Click += new EventHandler(this.KEY_A_Click);
      this.KEY_B.Location = new Point(54, 94);
      this.KEY_B.Name = "KEY_B";
      this.KEY_B.Size = new Size(45, 23);
      this.KEY_B.TabIndex = 1;
      this.KEY_B.Text = "B";
      this.KEY_B.UseVisualStyleBackColor = true;
      this.KEY_B.Click += new EventHandler(this.KEY_B_Click);
      this.KEY_C.Location = new Point(105, 94);
      this.KEY_C.Name = "KEY_C";
      this.KEY_C.Size = new Size(45, 23);
      this.KEY_C.TabIndex = 2;
      this.KEY_C.Text = "C";
      this.KEY_C.UseVisualStyleBackColor = true;
      this.KEY_C.Click += new EventHandler(this.KEY_C_Click);
      this.KEY_D.Location = new Point(156, 94);
      this.KEY_D.Name = "KEY_D";
      this.KEY_D.Size = new Size(45, 23);
      this.KEY_D.TabIndex = 3;
      this.KEY_D.Text = "D";
      this.KEY_D.UseVisualStyleBackColor = true;
      this.KEY_D.Click += new EventHandler(this.KEY_D_Click);
      this.KEY_E.Location = new Point(207, 94);
      this.KEY_E.Name = "KEY_E";
      this.KEY_E.Size = new Size(45, 23);
      this.KEY_E.TabIndex = 4;
      this.KEY_E.Text = "E";
      this.KEY_E.UseVisualStyleBackColor = true;
      this.KEY_E.Click += new EventHandler(this.KEY_E_Click);
      this.KEY_F.Location = new Point(258, 94);
      this.KEY_F.Name = "KEY_F";
      this.KEY_F.Size = new Size(45, 23);
      this.KEY_F.TabIndex = 5;
      this.KEY_F.Text = "F";
      this.KEY_F.UseVisualStyleBackColor = true;
      this.KEY_F.Click += new EventHandler(this.KEY_F_Click);
      this.KEY_G.Location = new Point(309, 94);
      this.KEY_G.Name = "KEY_G";
      this.KEY_G.Size = new Size(45, 23);
      this.KEY_G.TabIndex = 7;
      this.KEY_G.Text = "G";
      this.KEY_G.UseVisualStyleBackColor = true;
      this.KEY_G.Click += new EventHandler(this.KEY_G_Click);
      this.KEY_H.Location = new Point(360, 94);
      this.KEY_H.Name = "KEY_H";
      this.KEY_H.Size = new Size(45, 23);
      this.KEY_H.TabIndex = 8;
      this.KEY_H.Text = "H";
      this.KEY_H.UseVisualStyleBackColor = true;
      this.KEY_H.Click += new EventHandler(this.KEY_H_Click);
      this.KEY_I.Location = new Point(411, 94);
      this.KEY_I.Name = "KEY_I";
      this.KEY_I.Size = new Size(45, 23);
      this.KEY_I.TabIndex = 9;
      this.KEY_I.Text = "I";
      this.KEY_I.UseVisualStyleBackColor = true;
      this.KEY_I.Click += new EventHandler(this.KEY_I_Click);
      this.KEY_J.Location = new Point(462, 94);
      this.KEY_J.Name = "KEY_J";
      this.KEY_J.Size = new Size(45, 23);
      this.KEY_J.TabIndex = 10;
      this.KEY_J.Text = "J";
      this.KEY_J.UseVisualStyleBackColor = true;
      this.KEY_J.Click += new EventHandler(this.KEY_J_Click);
      this.KEY_K.Location = new Point(513, 94);
      this.KEY_K.Name = "KEY_K";
      this.KEY_K.Size = new Size(45, 23);
      this.KEY_K.TabIndex = 11;
      this.KEY_K.Text = "K";
      this.KEY_K.UseVisualStyleBackColor = true;
      this.KEY_K.Click += new EventHandler(this.KEY_K_Click);
      this.KEY_W.Location = new Point(464, 123);
      this.KEY_W.Name = "KEY_W";
      this.KEY_W.Size = new Size(45, 23);
      this.KEY_W.TabIndex = 23;
      this.KEY_W.Text = "W";
      this.KEY_W.UseVisualStyleBackColor = true;
      this.KEY_W.Click += new EventHandler(this.KEY_W_Click);
      this.KEY_V.Location = new Point(413, 123);
      this.KEY_V.Name = "KEY_V";
      this.KEY_V.Size = new Size(45, 23);
      this.KEY_V.TabIndex = 22;
      this.KEY_V.Text = "V";
      this.KEY_V.UseVisualStyleBackColor = true;
      this.KEY_V.Click += new EventHandler(this.KEY_V_Click);
      this.KEY_U.Location = new Point(362, 123);
      this.KEY_U.Name = "KEY_U";
      this.KEY_U.Size = new Size(45, 23);
      this.KEY_U.TabIndex = 21;
      this.KEY_U.Text = "U";
      this.KEY_U.UseVisualStyleBackColor = true;
      this.KEY_U.Click += new EventHandler(this.KEY_U_Click);
      this.KEY_T.Location = new Point(309, 123);
      this.KEY_T.Name = "KEY_T";
      this.KEY_T.Size = new Size(47, 23);
      this.KEY_T.TabIndex = 20;
      this.KEY_T.Text = "T";
      this.KEY_T.UseVisualStyleBackColor = true;
      this.KEY_T.Click += new EventHandler(this.KEY_T_Click);
      this.KEY_S.Location = new Point(260, 123);
      this.KEY_S.Name = "KEY_S";
      this.KEY_S.Size = new Size(45, 23);
      this.KEY_S.TabIndex = 19;
      this.KEY_S.Text = "S";
      this.KEY_S.UseVisualStyleBackColor = true;
      this.KEY_S.Click += new EventHandler(this.KEY_S_Click);
      this.KEY_R.Location = new Point(209, 123);
      this.KEY_R.Name = "KEY_R";
      this.KEY_R.Size = new Size(45, 23);
      this.KEY_R.TabIndex = 18;
      this.KEY_R.Text = "R";
      this.KEY_R.UseVisualStyleBackColor = true;
      this.KEY_R.Click += new EventHandler(this.KEY_R_Click);
      this.KEY_Q.Location = new Point(158, 123);
      this.KEY_Q.Name = "KEY_Q";
      this.KEY_Q.Size = new Size(45, 23);
      this.KEY_Q.TabIndex = 17;
      this.KEY_Q.Text = "Q";
      this.KEY_Q.UseVisualStyleBackColor = true;
      this.KEY_Q.Click += new EventHandler(this.KEY_Q_Click);
      this.KEY_P.Location = new Point(105, 123);
      this.KEY_P.Name = "KEY_P";
      this.KEY_P.Size = new Size(47, 23);
      this.KEY_P.TabIndex = 16;
      this.KEY_P.Text = "P";
      this.KEY_P.UseVisualStyleBackColor = true;
      this.KEY_P.Click += new EventHandler(this.KEY_P_Click);
      this.KEY_O.Location = new Point(56, 123);
      this.KEY_O.Name = "KEY_O";
      this.KEY_O.Size = new Size(45, 23);
      this.KEY_O.TabIndex = 15;
      this.KEY_O.Text = "O";
      this.KEY_O.UseVisualStyleBackColor = true;
      this.KEY_O.Click += new EventHandler(this.KEY_O_Click);
      this.KEY_N.Location = new Point(5, 123);
      this.KEY_N.Name = "KEY_N";
      this.KEY_N.Size = new Size(45, 23);
      this.KEY_N.TabIndex = 14;
      this.KEY_N.Text = "N";
      this.KEY_N.UseVisualStyleBackColor = true;
      this.KEY_N.Click += new EventHandler(this.KEY_N_Click);
      this.KEY_M.Location = new Point(616, 94);
      this.KEY_M.Name = "KEY_M";
      this.KEY_M.Size = new Size(46, 23);
      this.KEY_M.TabIndex = 13;
      this.KEY_M.Text = "M";
      this.KEY_M.UseVisualStyleBackColor = true;
      this.KEY_M.Click += new EventHandler(this.KEY_M_Click);
      this.KEY_L.Location = new Point(565, 94);
      this.KEY_L.Name = "KEY_L";
      this.KEY_L.Size = new Size(44, 23);
      this.KEY_L.TabIndex = 12;
      this.KEY_L.Text = "L";
      this.KEY_L.UseVisualStyleBackColor = true;
      this.KEY_L.Click += new EventHandler(this.KEY_L_Click);
      this.KEY_8.Location = new Point(411, 65);
      this.KEY_8.Name = "KEY_8";
      this.KEY_8.Size = new Size(45, 23);
      this.KEY_8.TabIndex = 35;
      this.KEY_8.Text = "* 8";
      this.KEY_8.UseVisualStyleBackColor = true;
      this.KEY_8.Click += new EventHandler(this.KEY_8_Click);
      this.KEY_7.Location = new Point(360, 65);
      this.KEY_7.Name = "KEY_7";
      this.KEY_7.Size = new Size(45, 23);
      this.KEY_7.TabIndex = 34;
      this.KEY_7.Text = "＆ 7";
      this.KEY_7.UseVisualStyleBackColor = true;
      this.KEY_7.Click += new EventHandler(this.KEY_7_Click);
      this.KEY_6.Location = new Point(309, 65);
      this.KEY_6.Name = "KEY_6";
      this.KEY_6.Size = new Size(45, 23);
      this.KEY_6.TabIndex = 33;
      this.KEY_6.Text = "^ 6";
      this.KEY_6.UseVisualStyleBackColor = true;
      this.KEY_6.Click += new EventHandler(this.KEY_6_Click);
      this.KEY_5.Location = new Point(258, 65);
      this.KEY_5.Name = "KEY_5";
      this.KEY_5.Size = new Size(45, 23);
      this.KEY_5.TabIndex = 32;
      this.KEY_5.Text = "% 5";
      this.KEY_5.UseVisualStyleBackColor = true;
      this.KEY_5.Click += new EventHandler(this.KEY_5_Click);
      this.KEY_4.Location = new Point(207, 65);
      this.KEY_4.Name = "KEY_4";
      this.KEY_4.Size = new Size(45, 23);
      this.KEY_4.TabIndex = 31;
      this.KEY_4.Text = "$ 4";
      this.KEY_4.UseVisualStyleBackColor = true;
      this.KEY_4.Click += new EventHandler(this.KEY_4_Click);
      this.KEY_3.Location = new Point(156, 65);
      this.KEY_3.Name = "KEY_3";
      this.KEY_3.Size = new Size(45, 23);
      this.KEY_3.TabIndex = 30;
      this.KEY_3.Text = "# 3";
      this.KEY_3.UseVisualStyleBackColor = true;
      this.KEY_3.Click += new EventHandler(this.KEY_3_Click);
      this.KEY_2.Location = new Point(105, 65);
      this.KEY_2.Name = "KEY_2";
      this.KEY_2.Size = new Size(45, 23);
      this.KEY_2.TabIndex = 29;
      this.KEY_2.Text = "@ 2";
      this.KEY_2.UseVisualStyleBackColor = true;
      this.KEY_2.Click += new EventHandler(this.KEY_2_Click);
      this.KEY_1.Location = new Point(54, 65);
      this.KEY_1.Name = "KEY_1";
      this.KEY_1.Size = new Size(45, 23);
      this.KEY_1.TabIndex = 28;
      this.KEY_1.Text = "! 1";
      this.KEY_1.UseVisualStyleBackColor = true;
      this.KEY_1.Click += new EventHandler(this.KEY_1_Click);
      this.KEY_9.Location = new Point(462, 65);
      this.KEY_9.Name = "KEY_9";
      this.KEY_9.Size = new Size(45, 23);
      this.KEY_9.TabIndex = 27;
      this.KEY_9.Text = "( 9";
      this.KEY_9.UseVisualStyleBackColor = true;
      this.KEY_9.Click += new EventHandler(this.KEY_9_Click);
      this.KEY_Z.Location = new Point(615, 123);
      this.KEY_Z.Name = "KEY_Z";
      this.KEY_Z.Size = new Size(47, 23);
      this.KEY_Z.TabIndex = 26;
      this.KEY_Z.Text = "Z";
      this.KEY_Z.UseVisualStyleBackColor = true;
      this.KEY_Z.Click += new EventHandler(this.KEY_Z_Click);
      this.KEY_Y.Location = new Point(565, 123);
      this.KEY_Y.Name = "KEY_Y";
      this.KEY_Y.Size = new Size(45, 23);
      this.KEY_Y.TabIndex = 25;
      this.KEY_Y.Text = "Y";
      this.KEY_Y.UseVisualStyleBackColor = true;
      this.KEY_Y.Click += new EventHandler(this.KEY_Y_Click);
      this.KEY_X.Location = new Point(515, 123);
      this.KEY_X.Name = "KEY_X";
      this.KEY_X.Size = new Size(44, 23);
      this.KEY_X.TabIndex = 24;
      this.KEY_X.Text = "X";
      this.KEY_X.UseVisualStyleBackColor = true;
      this.KEY_X.Click += new EventHandler(this.KEY_X_Click);
      this.KEY_0.Location = new Point(512, 65);
      this.KEY_0.Name = "KEY_0";
      this.KEY_0.Size = new Size(45, 23);
      this.KEY_0.TabIndex = 36;
      this.KEY_0.Text = ") 0";
      this.KEY_0.UseVisualStyleBackColor = true;
      this.KEY_0.Click += new EventHandler(this.KEY_0_Click);
      this.KEY_F12.Location = new Point(617, 7);
      this.KEY_F12.Name = "KEY_F12";
      this.KEY_F12.Size = new Size(44, 23);
      this.KEY_F12.TabIndex = 48;
      this.KEY_F12.Text = "F12";
      this.KEY_F12.UseVisualStyleBackColor = true;
      this.KEY_F12.Click += new EventHandler(this.KEY_F12_Click);
      this.KEY_F11.Location = new Point(566, 7);
      this.KEY_F11.Name = "KEY_F11";
      this.KEY_F11.Size = new Size(45, 23);
      this.KEY_F11.TabIndex = 47;
      this.KEY_F11.Text = "F11";
      this.KEY_F11.UseVisualStyleBackColor = true;
      this.KEY_F11.Click += new EventHandler(this.KEY_F11_Click);
      this.KEY_F10.Location = new Point(515, 7);
      this.KEY_F10.Name = "KEY_F10";
      this.KEY_F10.Size = new Size(45, 23);
      this.KEY_F10.TabIndex = 46;
      this.KEY_F10.Text = "F10";
      this.KEY_F10.UseVisualStyleBackColor = true;
      this.KEY_F10.Click += new EventHandler(this.KEY_F10_Click);
      this.KEY_F9.Location = new Point(464, 7);
      this.KEY_F9.Name = "KEY_F9";
      this.KEY_F9.Size = new Size(45, 23);
      this.KEY_F9.TabIndex = 45;
      this.KEY_F9.Text = "F9";
      this.KEY_F9.UseVisualStyleBackColor = true;
      this.KEY_F9.Click += new EventHandler(this.KEY_F9_Click);
      this.KEY_F8.Location = new Point(413, 7);
      this.KEY_F8.Name = "KEY_F8";
      this.KEY_F8.Size = new Size(45, 23);
      this.KEY_F8.TabIndex = 44;
      this.KEY_F8.Text = "F8";
      this.KEY_F8.UseVisualStyleBackColor = true;
      this.KEY_F8.Click += new EventHandler(this.KEY_F8_Click);
      this.KEY_F7.Location = new Point(362, 7);
      this.KEY_F7.Name = "KEY_F7";
      this.KEY_F7.Size = new Size(45, 23);
      this.KEY_F7.TabIndex = 43;
      this.KEY_F7.Text = "F7";
      this.KEY_F7.UseVisualStyleBackColor = true;
      this.KEY_F7.Click += new EventHandler(this.KEY_F7_Click);
      this.KEY_F6.Location = new Point(311, 7);
      this.KEY_F6.Name = "KEY_F6";
      this.KEY_F6.Size = new Size(45, 23);
      this.KEY_F6.TabIndex = 42;
      this.KEY_F6.Text = "F6";
      this.KEY_F6.UseVisualStyleBackColor = true;
      this.KEY_F6.Click += new EventHandler(this.KEY_F6_Click);
      this.KEY_F5.Location = new Point(260, 7);
      this.KEY_F5.Name = "KEY_F5";
      this.KEY_F5.Size = new Size(45, 23);
      this.KEY_F5.TabIndex = 41;
      this.KEY_F5.Text = "F5";
      this.KEY_F5.UseVisualStyleBackColor = true;
      this.KEY_F5.Click += new EventHandler(this.KEY_F5_Click);
      this.KEY_F4.Location = new Point(209, 7);
      this.KEY_F4.Name = "KEY_F4";
      this.KEY_F4.Size = new Size(45, 23);
      this.KEY_F4.TabIndex = 40;
      this.KEY_F4.Text = "F4";
      this.KEY_F4.UseVisualStyleBackColor = true;
      this.KEY_F4.Click += new EventHandler(this.KEY_F4_Click);
      this.KEY_F3.Location = new Point(158, 7);
      this.KEY_F3.Name = "KEY_F3";
      this.KEY_F3.Size = new Size(45, 23);
      this.KEY_F3.TabIndex = 39;
      this.KEY_F3.Text = "F3";
      this.KEY_F3.UseVisualStyleBackColor = true;
      this.KEY_F3.Click += new EventHandler(this.KEY_F3_Click);
      this.KEY_F2.Location = new Point(107, 7);
      this.KEY_F2.Name = "KEY_F2";
      this.KEY_F2.Size = new Size(45, 23);
      this.KEY_F2.TabIndex = 38;
      this.KEY_F2.Text = "F2";
      this.KEY_F2.UseVisualStyleBackColor = true;
      this.KEY_F2.Click += new EventHandler(this.KEY_F2_Click);
      this.KEY_F1.Location = new Point(56, 5);
      this.KEY_F1.Name = "KEY_F1";
      this.KEY_F1.Size = new Size(45, 23);
      this.KEY_F1.TabIndex = 37;
      this.KEY_F1.Text = "F1";
      this.KEY_F1.UseVisualStyleBackColor = true;
      this.KEY_F1.Click += new EventHandler(this.KEY_F1_Click);
      this.KEY_ESC.Location = new Point(4, 5);
      this.KEY_ESC.Name = "KEY_ESC";
      this.KEY_ESC.Size = new Size(45, 23);
      this.KEY_ESC.TabIndex = 49;
      this.KEY_ESC.Text = "ESC";
      this.KEY_ESC.UseVisualStyleBackColor = true;
      this.KEY_ESC.Click += new EventHandler(this.KEY_ESC_Click);
      this.KEY_PrtSc.Location = new Point(4, 36);
      this.KEY_PrtSc.Name = "KEY_PrtSc";
      this.KEY_PrtSc.Size = new Size(76, 23);
      this.KEY_PrtSc.TabIndex = 50;
      this.KEY_PrtSc.Text = "PrtScSysRq";
      this.KEY_PrtSc.UseVisualStyleBackColor = true;
      this.KEY_PrtSc.Click += new EventHandler(this.KEY_PrtSc_Click);
      this.KEY_PauseBreak.Location = new Point(173, 36);
      this.KEY_PauseBreak.Name = "KEY_PauseBreak";
      this.KEY_PauseBreak.Size = new Size(90, 23);
      this.KEY_PauseBreak.TabIndex = 51;
      this.KEY_PauseBreak.Text = "PauseBreak";
      this.KEY_PauseBreak.UseVisualStyleBackColor = true;
      this.KEY_PauseBreak.Click += new EventHandler(this.KEY_PauseBreak_Click);
      this.KEY_INS.Location = new Point(269, 36);
      this.KEY_INS.Name = "KEY_INS";
      this.KEY_INS.Size = new Size(54, 23);
      this.KEY_INS.TabIndex = 52;
      this.KEY_INS.Text = "Insert";
      this.KEY_INS.UseVisualStyleBackColor = true;
      this.KEY_INS.Click += new EventHandler(this.KEY_INS_Click);
      this.KEY_DEL.Location = new Point(329, 36);
      this.KEY_DEL.Name = "KEY_DEL";
      this.KEY_DEL.Size = new Size(63, 23);
      this.KEY_DEL.TabIndex = 53;
      this.KEY_DEL.Text = "Delete";
      this.KEY_DEL.UseVisualStyleBackColor = true;
      this.KEY_DEL.Click += new EventHandler(this.KEY_DEL_Click);
      this.KEY_HOME.Location = new Point(398, 36);
      this.KEY_HOME.Name = "KEY_HOME";
      this.KEY_HOME.Size = new Size(58, 23);
      this.KEY_HOME.TabIndex = 54;
      this.KEY_HOME.Text = "Home";
      this.KEY_HOME.UseVisualStyleBackColor = true;
      this.KEY_HOME.Click += new EventHandler(this.KEY_HOME_Click);
      this.KEY_PgUg.Location = new Point(462, 36);
      this.KEY_PgUg.Name = "KEY_PgUg";
      this.KEY_PgUg.Size = new Size(62, 23);
      this.KEY_PgUg.TabIndex = 56;
      this.KEY_PgUg.Text = "Page Up";
      this.KEY_PgUg.UseVisualStyleBackColor = true;
      this.KEY_PgUg.Click += new EventHandler(this.KEY_PgUg_Click);
      this.KEY_PgDn.Location = new Point(532, 36);
      this.KEY_PgDn.Name = "KEY_PgDn";
      this.KEY_PgDn.Size = new Size(70, 23);
      this.KEY_PgDn.TabIndex = 57;
      this.KEY_PgDn.Text = "Page Down";
      this.KEY_PgDn.UseVisualStyleBackColor = true;
      this.KEY_PgDn.Click += new EventHandler(this.KEY_PgDn_Click);
      this.KEY_End.Location = new Point(608, 36);
      this.KEY_End.Name = "KEY_End";
      this.KEY_End.Size = new Size(53, 23);
      this.KEY_End.TabIndex = 58;
      this.KEY_End.Text = "End";
      this.KEY_End.UseVisualStyleBackColor = true;
      this.KEY_End.Click += new EventHandler(this.KEY_End_Click);
      this.KEY_SubSub.Location = new Point(565, 65);
      this.KEY_SubSub.Name = "KEY_SubSub";
      this.KEY_SubSub.Size = new Size(45, 23);
      this.KEY_SubSub.TabIndex = 59;
      this.KEY_SubSub.Text = "￣－";
      this.KEY_SubSub.UseVisualStyleBackColor = true;
      this.KEY_SubSub.Click += new EventHandler(this.KEY_SubSub_Click);
      this.KEY_ADDADD.Location = new Point(617, 65);
      this.KEY_ADDADD.Name = "KEY_ADDADD";
      this.KEY_ADDADD.Size = new Size(45, 23);
      this.KEY_ADDADD.TabIndex = 60;
      this.KEY_ADDADD.Text = "＋=";
      this.KEY_ADDADD.UseVisualStyleBackColor = true;
      this.KEY_ADDADD.Click += new EventHandler(this.KEY_ADDADD_Click);
      this.KEY_BACKSPACE.Location = new Point(372, 181);
      this.KEY_BACKSPACE.Name = "KEY_BACKSPACE";
      this.KEY_BACKSPACE.Size = new Size(92, 23);
      this.KEY_BACKSPACE.TabIndex = 61;
      this.KEY_BACKSPACE.Text = "← Backspace";
      this.KEY_BACKSPACE.UseVisualStyleBackColor = true;
      this.KEY_BACKSPACE.Click += new EventHandler(this.KEY_BACKSPACE_Click);
      this.KEY_Tabel.Location = new Point(4, 152);
      this.KEY_Tabel.Name = "KEY_Tabel";
      this.KEY_Tabel.Size = new Size(97, 23);
      this.KEY_Tabel.TabIndex = 62;
      this.KEY_Tabel.Text = "Tab";
      this.KEY_Tabel.UseVisualStyleBackColor = true;
      this.KEY_Tabel.Click += new EventHandler(this.KEY_Tabel_Click);
      this.KEY_kuohao.Location = new Point(309, 152);
      this.KEY_kuohao.Name = "KEY_kuohao";
      this.KEY_kuohao.Size = new Size(45, 23);
      this.KEY_kuohao.TabIndex = 63;
      this.KEY_kuohao.Text = "{ [";
      this.KEY_kuohao.UseVisualStyleBackColor = true;
      this.KEY_kuohao.Click += new EventHandler(this.KEY_kuohao_Click);
      this.KEY_kuohao2.Location = new Point(362, 152);
      this.KEY_kuohao2.Name = "KEY_kuohao2";
      this.KEY_kuohao2.Size = new Size(45, 23);
      this.KEY_kuohao2.TabIndex = 64;
      this.KEY_kuohao2.Text = "} ]";
      this.KEY_kuohao2.UseVisualStyleBackColor = true;
      this.KEY_kuohao2.Click += new EventHandler(this.KEY_kuohao2_Click);
      this.KEY_shu.Location = new Point(413, 152);
      this.KEY_shu.Name = "KEY_shu";
      this.KEY_shu.Size = new Size(45, 23);
      this.KEY_shu.TabIndex = 65;
      this.KEY_shu.Text = "| \\";
      this.KEY_shu.UseVisualStyleBackColor = true;
      this.KEY_shu.Click += new EventHandler(this.KEY_shu_Click);
      this.KEY_fenhao.Location = new Point(464, 152);
      this.KEY_fenhao.Name = "KEY_fenhao";
      this.KEY_fenhao.Size = new Size(45, 23);
      this.KEY_fenhao.TabIndex = 66;
      this.KEY_fenhao.Text = "： ；";
      this.KEY_fenhao.UseVisualStyleBackColor = true;
      this.KEY_fenhao.Click += new EventHandler(this.KEY_fenhao_Click);
      this.KEY_yinghao.Location = new Point(513, 152);
      this.KEY_yinghao.Name = "KEY_yinghao";
      this.KEY_yinghao.Size = new Size(45, 23);
      this.KEY_yinghao.TabIndex = 67;
      this.KEY_yinghao.Text = "＂ ＇";
      this.KEY_yinghao.UseVisualStyleBackColor = true;
      this.KEY_yinghao.Click += new EventHandler(this.KEY_yinghao_Click);
      this.KEY_Enter.Location = new Point(209, 152);
      this.KEY_Enter.Name = "KEY_Enter";
      this.KEY_Enter.Size = new Size(94, 23);
      this.KEY_Enter.TabIndex = 68;
      this.KEY_Enter.Text = "Enter";
      this.KEY_Enter.UseVisualStyleBackColor = true;
      this.KEY_Enter.Click += new EventHandler(this.KEY_Enter_Click);
      this.KEY_bolanghao.Location = new Point(4, 65);
      this.KEY_bolanghao.Name = "KEY_bolanghao";
      this.KEY_bolanghao.Size = new Size(45, 23);
      this.KEY_bolanghao.TabIndex = 69;
      this.KEY_bolanghao.Text = "~ 、";
      this.KEY_bolanghao.UseVisualStyleBackColor = true;
      this.KEY_bolanghao.Click += new EventHandler(this.KEY_bolanghao_Click);
      this.KEY_douhao.Location = new Point(564, 152);
      this.KEY_douhao.Name = "KEY_douhao";
      this.KEY_douhao.Size = new Size(47, 23);
      this.KEY_douhao.TabIndex = 70;
      this.KEY_douhao.Text = "＜ ，";
      this.KEY_douhao.UseVisualStyleBackColor = true;
      this.KEY_douhao.Click += new EventHandler(this.KEY_douhao_Click);
      this.KEY_juhao.Location = new Point(616, 152);
      this.KEY_juhao.Name = "KEY_juhao";
      this.KEY_juhao.Size = new Size(46, 23);
      this.KEY_juhao.TabIndex = 71;
      this.KEY_juhao.Text = "＞ .";
      this.KEY_juhao.UseVisualStyleBackColor = true;
      this.KEY_juhao.Click += new EventHandler(this.KEY_juhao_Click);
      this.KEY_wenhao.Location = new Point(667, 152);
      this.KEY_wenhao.Name = "KEY_wenhao";
      this.KEY_wenhao.Size = new Size(45, 23);
      this.KEY_wenhao.TabIndex = 72;
      this.KEY_wenhao.Text = "?  /";
      this.KEY_wenhao.UseVisualStyleBackColor = true;
      this.KEY_wenhao.Click += new EventHandler(this.KEY_wenhao_Click);
      this.KEY_jiantou_left.Location = new Point(667, 7);
      this.KEY_jiantou_left.Name = "KEY_jiantou_left";
      this.KEY_jiantou_left.Size = new Size(45, 23);
      this.KEY_jiantou_left.TabIndex = 73;
      this.KEY_jiantou_left.Text = "←";
      this.KEY_jiantou_left.UseVisualStyleBackColor = true;
      this.KEY_jiantou_left.Click += new EventHandler(this.KEY_jiantou_left_Click);
      this.KEY_jiantou_Up.Location = new Point(668, 65);
      this.KEY_jiantou_Up.Name = "KEY_jiantou_Up";
      this.KEY_jiantou_Up.Size = new Size(45, 23);
      this.KEY_jiantou_Up.TabIndex = 74;
      this.KEY_jiantou_Up.Text = "↑";
      this.KEY_jiantou_Up.UseVisualStyleBackColor = true;
      this.KEY_jiantou_Up.Click += new EventHandler(this.KEY_jiantou_Up_Click);
      this.KEY_jiantou_Down.Location = new Point(668, 94);
      this.KEY_jiantou_Down.Name = "KEY_jiantou_Down";
      this.KEY_jiantou_Down.Size = new Size(45, 23);
      this.KEY_jiantou_Down.TabIndex = 75;
      this.KEY_jiantou_Down.Text = "↓";
      this.KEY_jiantou_Down.UseVisualStyleBackColor = true;
      this.KEY_jiantou_Down.Click += new EventHandler(this.KEY_jiantou_Down_Click);
      this.KEY_jiantou_right.Location = new Point(668, 36);
      this.KEY_jiantou_right.Name = "KEY_jiantou_right";
      this.KEY_jiantou_right.Size = new Size(45, 23);
      this.KEY_jiantou_right.TabIndex = 76;
      this.KEY_jiantou_right.Text = "→";
      this.KEY_jiantou_right.UseVisualStyleBackColor = true;
      this.KEY_jiantou_right.Click += new EventHandler(this.KEY_jiantou_right_Click);
      this.KEY_add.Location = new Point(470, 181);
      this.KEY_add.Name = "KEY_add";
      this.KEY_add.Size = new Size(62, 23);
      this.KEY_add.TabIndex = 77;
      this.KEY_add.Text = "＋";
      this.KEY_add.UseVisualStyleBackColor = true;
      this.KEY_add.Click += new EventHandler(this.KEY_add_Click);
      this.KEY_sub.Location = new Point(538, 181);
      this.KEY_sub.Name = "KEY_sub";
      this.KEY_sub.Size = new Size(53, 23);
      this.KEY_sub.TabIndex = 78;
      this.KEY_sub.Text = "－";
      this.KEY_sub.UseVisualStyleBackColor = true;
      this.KEY_sub.Click += new EventHandler(this.KEY_sub_Click);
      this.KEY_multiply.Location = new Point(597, 181);
      this.KEY_multiply.Name = "KEY_multiply";
      this.KEY_multiply.Size = new Size(54, 23);
      this.KEY_multiply.TabIndex = 79;
      this.KEY_multiply.Text = "×";
      this.KEY_multiply.UseVisualStyleBackColor = true;
      this.KEY_multiply.Click += new EventHandler(this.KEY_multiply_Click);
      this.KEY_DIV.Location = new Point(657, 181);
      this.KEY_DIV.Name = "KEY_DIV";
      this.KEY_DIV.Size = new Size(55, 23);
      this.KEY_DIV.TabIndex = 80;
      this.KEY_DIV.Text = "÷";
      this.KEY_DIV.UseVisualStyleBackColor = true;
      this.KEY_DIV.Click += new EventHandler(this.KEY_DIV_Click);
      this.KEY_NUM.Location = new Point(5, 210);
      this.KEY_NUM.Name = "KEY_NUM";
      this.KEY_NUM.Size = new Size(95, 23);
      this.KEY_NUM.TabIndex = 91;
      this.KEY_NUM.Text = "NumLock";
      this.KEY_NUM.UseVisualStyleBackColor = true;
      this.KEY_NUM.Click += new EventHandler(this.KEY_NUM_Click);
      this.KEY_MIN_0.Location = new Point(564, 210);
      this.KEY_MIN_0.Name = "KEY_MIN_0";
      this.KEY_MIN_0.Size = new Size(45, 23);
      this.KEY_MIN_0.TabIndex = 90;
      this.KEY_MIN_0.Text = "0";
      this.KEY_MIN_0.UseVisualStyleBackColor = true;
      this.KEY_MIN_0.Click += new EventHandler(this.KEY_MIN_0_Click);
      this.KEY_MIN_9.Location = new Point(513, 210);
      this.KEY_MIN_9.Name = "KEY_MIN_9";
      this.KEY_MIN_9.Size = new Size(45, 23);
      this.KEY_MIN_9.TabIndex = 89;
      this.KEY_MIN_9.Text = "9";
      this.KEY_MIN_9.UseVisualStyleBackColor = true;
      this.KEY_MIN_9.Click += new EventHandler(this.KEY_MIN_9_Click);
      this.KEY_MIN_8.Location = new Point(462, 210);
      this.KEY_MIN_8.Name = "KEY_MIN_8";
      this.KEY_MIN_8.Size = new Size(45, 23);
      this.KEY_MIN_8.TabIndex = 88;
      this.KEY_MIN_8.Text = "8";
      this.KEY_MIN_8.UseVisualStyleBackColor = true;
      this.KEY_MIN_8.Click += new EventHandler(this.KEY_MIN_8_Click);
      this.KEY_MIN_7.Location = new Point(411, 210);
      this.KEY_MIN_7.Name = "KEY_MIN_7";
      this.KEY_MIN_7.Size = new Size(45, 23);
      this.KEY_MIN_7.TabIndex = 87;
      this.KEY_MIN_7.Text = "7";
      this.KEY_MIN_7.UseVisualStyleBackColor = true;
      this.KEY_MIN_7.Click += new EventHandler(this.KEY_MIN_7_Click);
      this.KEY_MIN_6.Location = new Point(360, 210);
      this.KEY_MIN_6.Name = "KEY_MIN_6";
      this.KEY_MIN_6.Size = new Size(45, 23);
      this.KEY_MIN_6.TabIndex = 86;
      this.KEY_MIN_6.Text = "6";
      this.KEY_MIN_6.UseVisualStyleBackColor = true;
      this.KEY_MIN_6.Click += new EventHandler(this.KEY_MIN_6_Click);
      this.KEY_MIN_5.Location = new Point(309, 210);
      this.KEY_MIN_5.Name = "KEY_MIN_5";
      this.KEY_MIN_5.Size = new Size(45, 23);
      this.KEY_MIN_5.TabIndex = 85;
      this.KEY_MIN_5.Text = "5";
      this.KEY_MIN_5.UseVisualStyleBackColor = true;
      this.KEY_MIN_5.Click += new EventHandler(this.KEY_MIN_5_Click);
      this.KEY_MIN_4.Location = new Point(258, 210);
      this.KEY_MIN_4.Name = "KEY_MIN_4";
      this.KEY_MIN_4.Size = new Size(45, 23);
      this.KEY_MIN_4.TabIndex = 84;
      this.KEY_MIN_4.Text = "4";
      this.KEY_MIN_4.UseVisualStyleBackColor = true;
      this.KEY_MIN_4.Click += new EventHandler(this.KEY_MIN_4_Click);
      this.KEY_MIN_3.Location = new Point(207, 210);
      this.KEY_MIN_3.Name = "KEY_MIN_3";
      this.KEY_MIN_3.Size = new Size(45, 23);
      this.KEY_MIN_3.TabIndex = 83;
      this.KEY_MIN_3.Text = "3";
      this.KEY_MIN_3.UseVisualStyleBackColor = true;
      this.KEY_MIN_3.Click += new EventHandler(this.KEY_MIN_3_Click);
      this.KEY_MIN_2.Location = new Point(156, 210);
      this.KEY_MIN_2.Name = "KEY_MIN_2";
      this.KEY_MIN_2.Size = new Size(45, 23);
      this.KEY_MIN_2.TabIndex = 82;
      this.KEY_MIN_2.Text = "2";
      this.KEY_MIN_2.UseVisualStyleBackColor = true;
      this.KEY_MIN_2.Click += new EventHandler(this.KEY_MIN_2_Click);
      this.KEY_MIN_1.Location = new Point(106, 210);
      this.KEY_MIN_1.Name = "KEY_MIN_1";
      this.KEY_MIN_1.Size = new Size(44, 23);
      this.KEY_MIN_1.TabIndex = 81;
      this.KEY_MIN_1.Text = "1";
      this.KEY_MIN_1.UseVisualStyleBackColor = true;
      this.KEY_MIN_1.Click += new EventHandler(this.KEY_MIN_1_Click);
      this.KEY_MIN_Dot.Location = new Point(614, 210);
      this.KEY_MIN_Dot.Name = "KEY_MIN_Dot";
      this.KEY_MIN_Dot.Size = new Size(45, 23);
      this.KEY_MIN_Dot.TabIndex = 92;
      this.KEY_MIN_Dot.Text = "·";
      this.KEY_MIN_Dot.UseVisualStyleBackColor = true;
      this.KEY_MIN_Dot.Click += new EventHandler(this.KEY_MIN_Dot_Click);
      this.KEY_CapsLock.Location = new Point(105, 152);
      this.KEY_CapsLock.Name = "KEY_CapsLock";
      this.KEY_CapsLock.Size = new Size(98, 23);
      this.KEY_CapsLock.TabIndex = 93;
      this.KEY_CapsLock.Text = "CapsLock";
      this.KEY_CapsLock.UseVisualStyleBackColor = true;
      this.KEY_CapsLock.Click += new EventHandler(this.KEY_CapsLock_Click);
      this.KEY_SpaceKey.Location = new Point(291, 181);
      this.KEY_SpaceKey.Name = "KEY_SpaceKey";
      this.KEY_SpaceKey.Size = new Size(75, 23);
      this.KEY_SpaceKey.TabIndex = 94;
      this.KEY_SpaceKey.Text = "Space";
      this.KEY_SpaceKey.UseVisualStyleBackColor = true;
      this.KEY_SpaceKey.Click += new EventHandler(this.KEY_SpaceKey_Click);
      this.KEY_ScrollLock.Location = new Point(86, 36);
      this.KEY_ScrollLock.Name = "KEY_ScrollLock";
      this.KEY_ScrollLock.Size = new Size(81, 23);
      this.KEY_ScrollLock.TabIndex = 95;
      this.KEY_ScrollLock.Text = "ScrollLock";
      this.KEY_ScrollLock.UseVisualStyleBackColor = true;
      this.KEY_ScrollLock.Click += new EventHandler(this.KEY_ScrollLock_Click);
      this.KEY_Menu.Font = new Font("宋体", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 134);
      this.KEY_Menu.Location = new Point(668, 123);
      this.KEY_Menu.Name = "KEY_Menu";
      this.KEY_Menu.Size = new Size(44, 23);
      this.KEY_Menu.TabIndex = 96;
      this.KEY_Menu.Text = "▤";
      this.KEY_Menu.UseVisualStyleBackColor = true;
      this.KEY_Menu.Click += new EventHandler(this.KEY_Menu_Click);
      this.Key_Ctrl.Location = new Point(5, 181);
      this.Key_Ctrl.Name = "Key_Ctrl";
      this.Key_Ctrl.Size = new Size(62, 23);
      this.Key_Ctrl.TabIndex = 97;
      this.Key_Ctrl.Text = "Ctrl";
      this.Key_Ctrl.UseVisualStyleBackColor = true;
      this.Key_Ctrl.Click += new EventHandler(this.Key_Ctrl_Click);
      this.Key_Shift.Location = new Point(73, 181);
      this.Key_Shift.Name = "Key_Shift";
      this.Key_Shift.Size = new Size(64, 23);
      this.Key_Shift.TabIndex = 98;
      this.Key_Shift.Text = "Shift";
      this.Key_Shift.UseVisualStyleBackColor = true;
      this.Key_Shift.Click += new EventHandler(this.Key_Shift_Click);
      this.Key_Alt.Location = new Point(143, 181);
      this.Key_Alt.Name = "Key_Alt";
      this.Key_Alt.Size = new Size(60, 23);
      this.Key_Alt.TabIndex = 99;
      this.Key_Alt.Text = "Alt";
      this.Key_Alt.UseVisualStyleBackColor = true;
      this.Key_Alt.Click += new EventHandler(this.Key_Alt_Click);
      this.Key_Win.Location = new Point(209, 181);
      this.Key_Win.Name = "Key_Win";
      this.Key_Win.Size = new Size(76, 23);
      this.Key_Win.TabIndex = 100;
      this.Key_Win.Text = "Win";
      this.Key_Win.UseVisualStyleBackColor = true;
      this.Key_Win.Click += new EventHandler(this.Key_Win_Click);
      this.KEY_NILL.Location = new Point(665, 210);
      this.KEY_NILL.Name = "KEY_NILL";
      this.KEY_NILL.Size = new Size(45, 23);
      this.KEY_NILL.TabIndex = 101;
      this.KEY_NILL.Text = "NULL";
      this.KEY_NILL.UseVisualStyleBackColor = true;
      this.KEY_NILL.Click += new EventHandler(this.KEY_NILL_Click);
      this.AutoScaleDimensions = new SizeF(6f, 12f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.KEY_NILL);
      this.Controls.Add((Control) this.Key_Win);
      this.Controls.Add((Control) this.Key_Alt);
      this.Controls.Add((Control) this.Key_Shift);
      this.Controls.Add((Control) this.Key_Ctrl);
      this.Controls.Add((Control) this.KEY_Menu);
      this.Controls.Add((Control) this.KEY_ScrollLock);
      this.Controls.Add((Control) this.KEY_SpaceKey);
      this.Controls.Add((Control) this.KEY_CapsLock);
      this.Controls.Add((Control) this.KEY_MIN_Dot);
      this.Controls.Add((Control) this.KEY_NUM);
      this.Controls.Add((Control) this.KEY_MIN_0);
      this.Controls.Add((Control) this.KEY_MIN_9);
      this.Controls.Add((Control) this.KEY_MIN_8);
      this.Controls.Add((Control) this.KEY_MIN_7);
      this.Controls.Add((Control) this.KEY_MIN_6);
      this.Controls.Add((Control) this.KEY_MIN_5);
      this.Controls.Add((Control) this.KEY_MIN_4);
      this.Controls.Add((Control) this.KEY_MIN_3);
      this.Controls.Add((Control) this.KEY_MIN_2);
      this.Controls.Add((Control) this.KEY_MIN_1);
      this.Controls.Add((Control) this.KEY_DIV);
      this.Controls.Add((Control) this.KEY_multiply);
      this.Controls.Add((Control) this.KEY_sub);
      this.Controls.Add((Control) this.KEY_add);
      this.Controls.Add((Control) this.KEY_jiantou_right);
      this.Controls.Add((Control) this.KEY_jiantou_Down);
      this.Controls.Add((Control) this.KEY_jiantou_Up);
      this.Controls.Add((Control) this.KEY_jiantou_left);
      this.Controls.Add((Control) this.KEY_wenhao);
      this.Controls.Add((Control) this.KEY_juhao);
      this.Controls.Add((Control) this.KEY_douhao);
      this.Controls.Add((Control) this.KEY_bolanghao);
      this.Controls.Add((Control) this.KEY_Enter);
      this.Controls.Add((Control) this.KEY_yinghao);
      this.Controls.Add((Control) this.KEY_fenhao);
      this.Controls.Add((Control) this.KEY_shu);
      this.Controls.Add((Control) this.KEY_kuohao2);
      this.Controls.Add((Control) this.KEY_kuohao);
      this.Controls.Add((Control) this.KEY_Tabel);
      this.Controls.Add((Control) this.KEY_BACKSPACE);
      this.Controls.Add((Control) this.KEY_ADDADD);
      this.Controls.Add((Control) this.KEY_SubSub);
      this.Controls.Add((Control) this.KEY_End);
      this.Controls.Add((Control) this.KEY_PgDn);
      this.Controls.Add((Control) this.KEY_PgUg);
      this.Controls.Add((Control) this.KEY_HOME);
      this.Controls.Add((Control) this.KEY_DEL);
      this.Controls.Add((Control) this.KEY_INS);
      this.Controls.Add((Control) this.KEY_PauseBreak);
      this.Controls.Add((Control) this.KEY_PrtSc);
      this.Controls.Add((Control) this.KEY_ESC);
      this.Controls.Add((Control) this.KEY_F12);
      this.Controls.Add((Control) this.KEY_F11);
      this.Controls.Add((Control) this.KEY_F10);
      this.Controls.Add((Control) this.KEY_F9);
      this.Controls.Add((Control) this.KEY_F8);
      this.Controls.Add((Control) this.KEY_F7);
      this.Controls.Add((Control) this.KEY_F6);
      this.Controls.Add((Control) this.KEY_F5);
      this.Controls.Add((Control) this.KEY_F4);
      this.Controls.Add((Control) this.KEY_F3);
      this.Controls.Add((Control) this.KEY_F2);
      this.Controls.Add((Control) this.KEY_F1);
      this.Controls.Add((Control) this.KEY_0);
      this.Controls.Add((Control) this.KEY_8);
      this.Controls.Add((Control) this.KEY_7);
      this.Controls.Add((Control) this.KEY_6);
      this.Controls.Add((Control) this.KEY_5);
      this.Controls.Add((Control) this.KEY_4);
      this.Controls.Add((Control) this.KEY_3);
      this.Controls.Add((Control) this.KEY_2);
      this.Controls.Add((Control) this.KEY_1);
      this.Controls.Add((Control) this.KEY_9);
      this.Controls.Add((Control) this.KEY_Z);
      this.Controls.Add((Control) this.KEY_Y);
      this.Controls.Add((Control) this.KEY_X);
      this.Controls.Add((Control) this.KEY_W);
      this.Controls.Add((Control) this.KEY_V);
      this.Controls.Add((Control) this.KEY_U);
      this.Controls.Add((Control) this.KEY_T);
      this.Controls.Add((Control) this.KEY_S);
      this.Controls.Add((Control) this.KEY_R);
      this.Controls.Add((Control) this.KEY_Q);
      this.Controls.Add((Control) this.KEY_P);
      this.Controls.Add((Control) this.KEY_O);
      this.Controls.Add((Control) this.KEY_N);
      this.Controls.Add((Control) this.KEY_M);
      this.Controls.Add((Control) this.KEY_L);
      this.Controls.Add((Control) this.KEY_K);
      this.Controls.Add((Control) this.KEY_J);
      this.Controls.Add((Control) this.KEY_I);
      this.Controls.Add((Control) this.KEY_H);
      this.Controls.Add((Control) this.KEY_G);
      this.Controls.Add((Control) this.KEY_F);
      this.Controls.Add((Control) this.KEY_E);
      this.Controls.Add((Control) this.KEY_D);
      this.Controls.Add((Control) this.KEY_C);
      this.Controls.Add((Control) this.KEY_B);
      this.Controls.Add((Control) this.KEY_A);
      this.Name = nameof (BasicKeys);
      this.Size = new Size(760, 385);
      this.ResumeLayout(false);
    }
  }
}
