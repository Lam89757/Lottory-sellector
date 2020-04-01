using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace LotteryPro
{
  public partial class FrmMain : Form
  {
    private Selector objSelector = new Selector();//创建选号器对象

    private PrintDocument printDoc = new PrintDocument();

    #region 初始化
    public FrmMain()
    {
      InitializeComponent();

      //禁用相关的按钮
      this.btnSelect.Enabled = false;
      this.btnPrint.Enabled = false;
      this.btnClear.Enabled = false;
      this.btnDel.Enabled = false;

      //关联打印对象的事件
      this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.LotteryPrintPage);
    }

    #endregion

    #region  拖动窗体的实现

    private Point mouseOff;//鼠标移动位置变量
    private bool leftFlag;//标签是否为左键
    private void FrmMain_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        mouseOff = new Point(-e.X, -e.Y); //得到变量的值
        leftFlag = true;                  //点击左键按下时标注为true;
      }
    }
    private void FrmMain_MouseMove(object sender, MouseEventArgs e)
    {
      if (leftFlag)
      {
        Point mouseSet = Control.MousePosition;
        mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
        Location = mouseSet;
      }
    }
    private void FrmMain_MouseUp(object sender, MouseEventArgs e)
    {
      if (leftFlag)
      {
        leftFlag = false;//释放鼠标后标注为false;
      }
    }

    #endregion

    #region 窗体最小化、最大化、关闭
    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }
    private void btnMax_Click(object sender, EventArgs e)
    {
      // this.WindowState = FormWindowState.Maximized;
    }
    private void btnMin_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }

    #endregion

    #region 选号操作
    //手写号码
    private void btnWriteSelf_Click(object sender, EventArgs e)
    {
      //首先验证输入是单个数字
      string[] selectedNum = {
        this.txtNum1.Text,
        this.txtNum2.Text,
        this.txtNum3.Text,
        this.txtNum4.Text,
        this.txtNum5.Text,
        this.txtNum6.Text,
        this.txtNum7.Text,
      };
      objSelector.SelectedNums.Add(selectedNum);
      ShowSeletedNums();
    }

    //启动选号
    private void btnStart_Click(object sender, EventArgs e)
    {
      this.RandomTimer.Start();

      this.btnStart.Enabled = false;
      this.btnSelect.Enabled = true;
    }
    //定时生成随机号码
    private void RandomTimer_Tick(object sender, EventArgs e)
    {
      string[] numList = objSelector.CreateNum();//生成随机号
      this.lblNum1.Text = numList[0];
      this.lblNum2.Text = numList[1];
      this.lblNum3.Text = numList[2];
      this.lblNum4.Text = numList[3];
      this.lblNum5.Text = numList[4];
      this.lblNum6.Text = numList[5];
      this.lblNum7.Text = numList[6];
    }
    //开始选号
    private void btnSelect_Click(object sender, EventArgs e)
    {
      this.RandomTimer.Stop();
      string[] selectedNum = {
        this.lblNum1.Text,
        this.lblNum2.Text,
        this.lblNum3.Text,
        this.lblNum4.Text,
        this.lblNum5.Text,
        this.lblNum6.Text,
        this.lblNum7.Text,
      };
      objSelector.SelectedNums.Add(selectedNum);

      ShowSeletedNums();
    }
    private void ShowSeletedNums()
    {
      this.lbNumberList.Items.Clear();
      this.lbNumberList.Items.AddRange(this.objSelector.GetPrintNums().ToArray());

      this.btnStart.Enabled = true;
      this.btnPrint.Enabled = this.btnClear.Enabled = this.btnDel.Enabled = true;
      this.btnSelect.Enabled = false;
    }

    //生成指定组的号码
    private void btnGroupSelect_Click(object sender, EventArgs e)
    {
      this.RandomTimer.Stop();
      this.objSelector.CreatGroupNums(Convert.ToInt32(this.txtGroup.Text.Trim()));
      this.ShowSeletedNums();
    }

    //删除当前所选
    private void btnDel_Click(object sender, EventArgs e)
    {
      if (this.lbNumberList.Items.Count == 0 || this.lbNumberList.SelectedItem == null) return;

      int index = this.lbNumberList.SelectedIndex;//获取选中的索引
      objSelector.SelectedNums.RemoveAt(index);
      if (objSelector.SelectedNums.Count == 0)
      {
        this.btnClear.Enabled = false;
        this.btnDel.Enabled = false;
        this.btnPrint.Enabled = false;
      }
      ShowSeletedNums();
    }
    //清空选号
    private void btnClear_Click(object sender, EventArgs e)
    {
      this.lbNumberList.Items.Clear();//界面中清楚显示

      this.objSelector.SelectedNums.Clear();

      this.lblNum1.Text = "0";
      this.lblNum2.Text = "0";
      this.lblNum3.Text = "0";
      this.lblNum4.Text = "0";
      this.lblNum5.Text = "0";
      this.lblNum6.Text = "0";
      this.lblNum7.Text = "0";

      this.txtNum1.Text = "0";
      this.txtNum2.Text = "0";
      this.txtNum3.Text = "0";
      this.txtNum4.Text = "0";
      this.txtNum5.Text = "0";
      this.txtNum6.Text = "0";
      this.txtNum7.Text = "0";

      //禁用相关的按钮
      this.btnSelect.Enabled = false;
      this.btnPrint.Enabled = false;
      this.btnSelect.Enabled = false;
      this.btnClear.Enabled = false;
      this.btnDel.Enabled = false;
    } 
    #endregion

    //使用小票打印机打印
    private void btnPrint_Click(object sender, EventArgs e)
    {
      this.printDoc.Print();
    }
    //具体打印实现过程
    private void LotteryPrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      string seriaNum = DateTime.Now.ToString("yyyyMMddHHmmssms");//流水号 生成条码用
      this.objSelector.PrintLottery(e, seriaNum, objSelector.GetPrintNums());//调用打印方法

      btnClear_Click(null, null);//打印完毕清空

    }

    private void lblNum3_Click(object sender, EventArgs e)
    {
      
    }

  }
}
