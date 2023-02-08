using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HIDTester
{
  public class MULKey : UserControl
  {
    private IContainer components;
    private Button KEY_Play;
    private Button KEY_VolumeAdd;
    private Button KEY_VolumeSub;
    private Button KEY_PreSong;
    private Button KEY_NextSong;
    private Button KEY_Mute;

    public MULKey() => this.InitializeComponent();

    private void MULGeneral_Char_Set() => FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KeyType_Num] |= (byte) 2;

    private void KEY_Play_Click(object sender, EventArgs e)
    {
      switch (FormMain.KeyParam.ReportID)
      {
        case 0:
          if (FormMain.KeyParam.New_Mul_Mouse == (byte) 1)
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.Key_Fun_Num] = (byte) 64;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.Key_Fun_Num - 4] = this.KEY_Play.Text;
          }
          else
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 64;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Play.Text;
          }
          this.MULGeneral_Char_Set();
          break;
        case 2:
          if (FormMain.KeyParam.New_Mul_Mouse == (byte) 1)
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.Key_Fun_Num + 1] = (byte) 4;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.Key_Fun_Num - 4] = this.KEY_Play.Text;
          }
          else
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 1] = (byte) 4;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Play.Text;
          }
          this.MULGeneral_Char_Set();
          break;
        default:
          if (FormMain.KeyParam.New_Mul_Mouse == (byte) 1)
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.Key_Fun_Num] = (byte) 205;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.Key_Fun_Num - 4] = this.KEY_Play.Text;
          }
          else
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 205;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Play.Text;
          }
          this.MULGeneral_Char_Set();
          break;
      }
    }

    private void KEY_PreSong_Click(object sender, EventArgs e)
    {
      switch (FormMain.KeyParam.ReportID)
      {
        case 0:
          if (FormMain.KeyParam.New_Mul_Mouse == (byte) 1)
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.Key_Fun_Num] = (byte) 128;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.Key_Fun_Num - 4] = this.KEY_PreSong.Text;
          }
          else
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 128;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_PreSong.Text;
          }
          this.MULGeneral_Char_Set();
          break;
        case 2:
          if (FormMain.KeyParam.New_Mul_Mouse == (byte) 1)
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.Key_Fun_Num + 1] = (byte) 11;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.Key_Fun_Num - 4] = this.KEY_PreSong.Text;
          }
          else
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 1] = (byte) 11;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_PreSong.Text;
          }
          this.MULGeneral_Char_Set();
          break;
        default:
          if (FormMain.KeyParam.New_Mul_Mouse == (byte) 1)
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.Key_Fun_Num] = (byte) 182;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.Key_Fun_Num - 4] = this.KEY_PreSong.Text;
          }
          else
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 182;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_PreSong.Text;
          }
          this.MULGeneral_Char_Set();
          break;
      }
    }

    private void KEY_NextSong_Click(object sender, EventArgs e)
    {
      switch (FormMain.KeyParam.ReportID)
      {
        case 0:
          if (FormMain.KeyParam.New_Mul_Mouse == (byte) 1)
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.Key_Fun_Num + 1] = (byte) 1;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.Key_Fun_Num - 4] = this.KEY_NextSong.Text;
          }
          else
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 1] = (byte) 1;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_NextSong.Text;
          }
          this.MULGeneral_Char_Set();
          break;
        case 2:
          if (FormMain.KeyParam.New_Mul_Mouse == (byte) 1)
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.Key_Fun_Num + 1] = (byte) 10;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.Key_Fun_Num - 4] = this.KEY_NextSong.Text;
          }
          else
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 1] = (byte) 10;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_NextSong.Text;
          }
          this.MULGeneral_Char_Set();
          break;
        default:
          if (FormMain.KeyParam.New_Mul_Mouse == (byte) 1)
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.Key_Fun_Num] = (byte) 181;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.Key_Fun_Num - 4] = this.KEY_NextSong.Text;
          }
          else
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 181;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_NextSong.Text;
          }
          this.MULGeneral_Char_Set();
          break;
      }
    }

    private void KEY_Mute_Click(object sender, EventArgs e)
    {
      switch (FormMain.KeyParam.ReportID)
      {
        case 0:
          if (FormMain.KeyParam.New_Mul_Mouse == (byte) 1)
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.Key_Fun_Num] = (byte) 4;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.Key_Fun_Num - 4] = this.KEY_Mute.Text;
          }
          else
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 4;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Mute.Text;
          }
          this.MULGeneral_Char_Set();
          break;
        case 2:
          if (FormMain.KeyParam.New_Mul_Mouse == (byte) 1)
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.Key_Fun_Num + 1] = (byte) 1;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.Key_Fun_Num - 4] = this.KEY_Mute.Text;
          }
          else
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num + 1] = (byte) 1;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Mute.Text;
          }
          this.MULGeneral_Char_Set();
          break;
        default:
          if (FormMain.KeyParam.New_Mul_Mouse == (byte) 1)
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.Key_Fun_Num] = (byte) 226;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.Key_Fun_Num - 4] = this.KEY_Mute.Text;
          }
          else
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 226;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_Mute.Text;
          }
          this.MULGeneral_Char_Set();
          break;
      }
    }

    private void KEY_VolumeAdd_Click(object sender, EventArgs e)
    {
      switch (FormMain.KeyParam.ReportID)
      {
        case 0:
          if (FormMain.KeyParam.New_Mul_Mouse == (byte) 1)
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.Key_Fun_Num] = (byte) 2;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.Key_Fun_Num - 4] = this.KEY_VolumeAdd.Text;
          }
          else
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 2;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_VolumeAdd.Text;
          }
          this.MULGeneral_Char_Set();
          break;
        case 2:
          if (FormMain.KeyParam.New_Mul_Mouse == (byte) 1)
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.Key_Fun_Num] = (byte) 64;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.Key_Fun_Num - 4] = this.KEY_VolumeAdd.Text;
          }
          else
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 64;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_VolumeAdd.Text;
          }
          this.MULGeneral_Char_Set();
          break;
        default:
          if (FormMain.KeyParam.New_Mul_Mouse == (byte) 1)
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.Key_Fun_Num] = (byte) 233;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.Key_Fun_Num - 4] = this.KEY_VolumeAdd.Text;
          }
          else
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 233;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_VolumeAdd.Text;
          }
          this.MULGeneral_Char_Set();
          break;
      }
    }

    private void KEY_VolumeSub_Click(object sender, EventArgs e)
    {
      switch (FormMain.KeyParam.ReportID)
      {
        case 0:
          if (FormMain.KeyParam.New_Mul_Mouse == (byte) 1)
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.Key_Fun_Num] = (byte) 1;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.Key_Fun_Num - 4] = this.KEY_VolumeSub.Text;
          }
          else
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 1;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_VolumeSub.Text;
          }
          this.MULGeneral_Char_Set();
          break;
        case 2:
          if (FormMain.KeyParam.New_Mul_Mouse == (byte) 1)
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.Key_Fun_Num] = (byte) 128;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.Key_Fun_Num - 4] = this.KEY_VolumeSub.Text;
          }
          else
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 128;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_VolumeSub.Text;
          }
          this.MULGeneral_Char_Set();
          break;
        default:
          if (FormMain.KeyParam.New_Mul_Mouse == (byte) 1)
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.Key_Fun_Num] = (byte) 234;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.Key_Fun_Num - 4] = this.KEY_VolumeSub.Text;
          }
          else
          {
            FormMain.KeyParam.Data_Send_Buff[(int) FormMain.KeyParam.KEY_Char_Num] = (byte) 234;
            FormMain.KeyParam.KeyChar[(int) FormMain.KeyParam.KEY_Char_Num - 5] = this.KEY_VolumeSub.Text;
          }
          this.MULGeneral_Char_Set();
          break;
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MULKey));
      this.KEY_Play = new Button();
      this.KEY_VolumeAdd = new Button();
      this.KEY_VolumeSub = new Button();
      this.KEY_PreSong = new Button();
      this.KEY_NextSong = new Button();
      this.KEY_Mute = new Button();
      this.SuspendLayout();
      componentResourceManager.ApplyResources((object) this.KEY_Play, "KEY_Play");
      this.KEY_Play.Name = "KEY_Play";
      this.KEY_Play.UseVisualStyleBackColor = true;
      this.KEY_Play.Click += new EventHandler(this.KEY_Play_Click);
      componentResourceManager.ApplyResources((object) this.KEY_VolumeAdd, "KEY_VolumeAdd");
      this.KEY_VolumeAdd.Name = "KEY_VolumeAdd";
      this.KEY_VolumeAdd.UseVisualStyleBackColor = true;
      this.KEY_VolumeAdd.Click += new EventHandler(this.KEY_VolumeAdd_Click);
      componentResourceManager.ApplyResources((object) this.KEY_VolumeSub, "KEY_VolumeSub");
      this.KEY_VolumeSub.Name = "KEY_VolumeSub";
      this.KEY_VolumeSub.UseVisualStyleBackColor = true;
      this.KEY_VolumeSub.Click += new EventHandler(this.KEY_VolumeSub_Click);
      componentResourceManager.ApplyResources((object) this.KEY_PreSong, "KEY_PreSong");
      this.KEY_PreSong.Name = "KEY_PreSong";
      this.KEY_PreSong.UseVisualStyleBackColor = true;
      this.KEY_PreSong.Click += new EventHandler(this.KEY_PreSong_Click);
      componentResourceManager.ApplyResources((object) this.KEY_NextSong, "KEY_NextSong");
      this.KEY_NextSong.Name = "KEY_NextSong";
      this.KEY_NextSong.UseVisualStyleBackColor = true;
      this.KEY_NextSong.Click += new EventHandler(this.KEY_NextSong_Click);
      componentResourceManager.ApplyResources((object) this.KEY_Mute, "KEY_Mute");
      this.KEY_Mute.Name = "KEY_Mute";
      this.KEY_Mute.UseVisualStyleBackColor = true;
      this.KEY_Mute.Click += new EventHandler(this.KEY_Mute_Click);
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.KEY_Mute);
      this.Controls.Add((Control) this.KEY_NextSong);
      this.Controls.Add((Control) this.KEY_PreSong);
      this.Controls.Add((Control) this.KEY_VolumeSub);
      this.Controls.Add((Control) this.KEY_VolumeAdd);
      this.Controls.Add((Control) this.KEY_Play);
      this.Name = nameof (MULKey);
      this.ResumeLayout(false);
    }
  }
}

