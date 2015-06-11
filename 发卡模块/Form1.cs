namespace 发卡模块
{
    using DAL;
    using DevExpress.LookAndFeel;
    using DevExpress.Utils;
    using DevExpress.XtraEditors;
    using DevExpress.XtraEditors.Controls;
    using DevExpress.XtraGrid;
    using DevExpress.XtraGrid.Columns;
    using DevExpress.XtraGrid.Views.Grid;
    using DevExpress.XtraGrid.Views.Base;
    using KAD_DX.BaseClass;
    using KAD_DX.EquManage;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.OleDb;
    using System.Diagnostics;
    using System.Drawing;
    using System.Globalization;
    using System.IO.Ports;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Timers;
    using System.Windows.Forms;
    using System.Xml;

    public class Form1 : Form
    {
        private BaseOperate boperate;
        private Button btnAddEqu;
        private Button btnBeginRead;
        private Button btnBlacklist;
        private Button btnNumber;
        private Button btnReadCard;
        public Button btnreadCard1;
        private Button btnselalmred;
        private Button btnSelect;
        public Button btnsendcard1;
        public Button btnSentCard;
        private Button btnserach;
        private Button btnSerchSerial;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button buttonOpenClose;
        private byte[] byAddrCount;
        private byte[] byReadbuf;
        private byte byValid;
        private string cardserial;
        public System.Windows.Forms.ComboBox cbxSerialport;
        public System.Windows.Forms.ComboBox cbxsex;
        public CheckBox checkBox1;
        public CheckBox checkBox2;
        private CheckBox chkSelectAll;
        private GridColumn colAlmCard;
        private GridColumn colAlmLocation;
        private GridColumn colAlmRemark;
        private GridColumn colAlmTime;
        public System.Windows.Forms.ComboBox comboBox1;
        public static SerialPort comm = new SerialPort();
        private IContainer components;
        private DateEdit dataBegin;
        private byte[] databuffer;
        private DateEdit dateEnd;
        public DateTimePicker dateTimePicker1;
        public DateTimePicker dateTimePicker2;
        private DefaultLookAndFeel defaultLookAndFeel1;
        private GridView dgvAlarm;
        private GridView dgvExecute;
        private Button Family;
        public static bool FamilyButtonStateCache = false;
        private int flag;
        private int flag1;
        private int flagreadcount;
        private GroupBox gbxInformation;
        private GridControl gridControl1;
        private GridControl gridControl2;
        private GridControl gridControl3;
        private GridView gridView1;
        private GroupBox groupBox1;
        private ToolStripMenuItem iC卡操作ToolStripMenuItem;
        private ImageCollection imageCollection1;
        private ImageCollection imageCollection2;
        private ImageListBoxControl imgList;
        public Label label1;
        public Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        public Label label14;
        public Label label2;
        public Label label3;
        public Label label4;
        public Label label5;
        public Label label6;
        public Label label7;
        public Label label8;
        public Label label9;
        private LabelControl labelControl1;
        private LabelControl labelControl2;
        private Label lblName;
        private Label lblRead;
        private Label lblRecords;
        private Label lblSum;
        private long logRecord;
        private int M_int_upptr;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private int nAddrMonitoring;
        private int[] nMoniPtr;
        private int nMonitoring;
        private GridColumn NoteArea;
        private GridColumn NoteArea4;
        private GridColumn NoteBuild;
        private GridColumn NoteBuild5;
        private GridColumn NoteCard;
        private GridColumn NoteCard7;
        private GridColumn NoteID;
        private GridColumn NoteID1;
        private GridColumn NoteInOut;
        private GridColumn NoteInOut10;
        private GridColumn NoteName;
        private GridColumn NoteName2;
        private GridColumn NotePass;
        private GridColumn NotePass11;
        private GridColumn NotePosition;
        private GridColumn NotePosition9;
        private GridColumn NoteRemark;
        private GridColumn NoteRemark12;
        private GridColumn NoteRoomNum;
        private GridColumn NoteRoomNum6;
        private GridColumn NoteSex;
        private GridColumn NoteSex3;
        private GridColumn NoteTime;
        private GridColumn NoteTime8;
        private int nPtr;
        private int nReadLen;
        private int nReadRecords;
        private int nRecordTotal;
        private int nSend;
        private int nToltal;
        private OperateAndValidate opAndvalidate;
        private OperateComm opComm;
        private Button OpenDoor_Button;
        private Panel panel1;
        private Panel panel2;
        private ProgressBarControl pbarData;
        private bool ReadedCard;
        private Button selCardNote;
        private string[] strAddCount;
        private string[] strAddMonitoring;
        private string[] strAddress;
        private string strAlmMaxID;
        private string strEquAddress;
        private string strEquCmd;
        private string strEquCount;
        private string strEquPosition;
        private string[] strLocation;
        private string strMaxID;
        private string[] strPosition;
        private string strPositionMonitoring;
        private System.Timers.Timer sysTime;
        private TabControl tabControl1;
        private TabControl tabControl2;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Thread threadMonitoring;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timeReceive;
        private ToolTip toolTip1;
        public TreeView treeView1;
        public TextBox txtAreaName;
        public TextBox txtBuildingNo;
        public TextBox txtCardNumber;
        public TextBox txtCount;
        public TextBox txtName;
        public TextBox txtRemarks;
        public TextBox txtRoomNumber;
        private TextBox txtUserID;
        private int userinfoID;
        private string UserPermissionType;
        private ToolStripMenuItem 安装USB驱动ToolStripMenuItem;
        private ToolStripMenuItem 备份数据库ToolStripMenuItem;
        private ToolStripMenuItem 备份数据库ToolStripMenuItem1;
        private ToolStripMenuItem 查询ToolStripMenuItem;
        private ToolStripMenuItem 读卡ToolStripMenuItem;
        public ToolStripMenuItem 发卡ToolStripMenuItem;
        private ToolStripMenuItem 发卡记录ToolStripMenuItem;
        private ToolStripMenuItem 关于ToolStripMenuItem;
        private ToolStripMenuItem 还原数据库ToolStripMenuItem;
        private ToolStripMenuItem 还原数据库ToolStripMenuItem1;
        private ToolStripMenuItem 黑名单ToolStripMenuItem;
        private ToolStripMenuItem 联系我们ToolStripMenuItem;
        private ToolStripMenuItem 权限管理ToolStripMenuItem;
        private ToolStripMenuItem 权限管理ToolStripMenuItem1;
        private ToolStripMenuItem 数据清理ToolStripMenuItem;
        private ToolStripMenuItem 系统维护ToolStripMenuItem;
        private ToolStripMenuItem 系统维护ToolStripMenuItem1;
        private ToolStripMenuItem 用户管理ToolStripMenuItem;
        private ToolStripMenuItem 用户管理ToolStripMenuItem1;

        public Form1()
        {
            this.components = null;
            this.ReadedCard = false;
            this.UserPermissionType = string.Empty;
            this.boperate = new BaseOperate();
            this.opAndvalidate = new OperateAndValidate();
            this.opComm = new OperateComm();
            this.strAddress = new string[0x3e7];
            this.strLocation = new string[0x3e7];
            this.strAddCount = new string[0x3e7];
            this.txtUserID = new TextBox();
            this.M_int_upptr = 0;
            this.logRecord = 0x2710L;
            this.flagreadcount = 0;
            this.sysTime = new System.Timers.Timer(500.0);
            this.nSend = 0;
            this.flag = 0;
            this.flag1 = 0;
            this.InitializeComponent();
        }

        public Form1(int userid)
        {
            this.components = null;
            this.ReadedCard = false;
            this.UserPermissionType = string.Empty;
            this.boperate = new BaseOperate();
            this.opAndvalidate = new OperateAndValidate();
            this.opComm = new OperateComm();
            this.strAddress = new string[0x3e7];
            this.strLocation = new string[0x3e7];
            this.strAddCount = new string[0x3e7];
            this.txtUserID = new TextBox();
            this.M_int_upptr = 0;
            this.logRecord = 0x2710L;
            this.flagreadcount = 0;
            this.sysTime = new System.Timers.Timer(500.0);
            this.nSend = 0;
            this.flag = 0;
            this.flag1 = 0;
            try
            {
                this.userinfoID = userid;
                string sql = "select UserPermission from UserInfo where ID = @ID  ";
                try
                {
                    OleDbParameter[] values = new OleDbParameter[] { new OleDbParameter("@ID", this.userinfoID) };
                    OleDbDataReader reader = DBHelper.GetReader(sql, values);
                    if (reader.Read())
                    {
                        string str2 = string.Empty;
                        str2 = (reader[0] == DBNull.Value) ? string.Empty : reader.GetString(0);
                        if (!string.IsNullOrEmpty(str2))
                        {
                            if (reader.GetString(0).Contains("超级用户"))
                            {
                                this.UserPermissionType = "Admin";
                            }
                            else
                            {
                                this.UserPermissionType = "Guest";
                            }
                        }
                        else
                        {
                            this.UserPermissionType = "Admin";
                        }
                    }
                    else
                    {
                        this.UserPermissionType = "Admin";
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    throw exception;
                }
                this.InitializeComponent();
                this.sysTime.Elapsed += new ElapsedEventHandler(this.sysTime_Elapsed);
            }
            catch (Exception exception2)
            {
                MessageBox.Show(exception2.Message.ToString());
                Console.WriteLine(exception2.ToString());
            }
        }

        private void btnAddEqu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(((this.OpenDoor_Button.Enabled && this.button2.Enabled) && this.btnBeginRead.Enabled) && this.btnserach.Enabled))
                {
                    MessageBox.Show("请先停止当前操作，或等待当前操作完成后继续。", "错误!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    frmAddEqu equ = new frmAddEqu();
                    equ.ShowDialog();
                    if (equ.DialogResult == DialogResult.OK)
                    {
                        string str = "select EquID,EquAddress,EquCount,EquFloor,EquLocation from tb_Equ";
                        this.imgList.Items.Clear();
                        OleDbDataReader reader = this.boperate.getread(str);
                        this.nToltal = 0;
                        while (reader.Read())
                        {
                            this.strLocation[this.nToltal] = reader["EquLocation"].ToString().Trim();
                            this.strAddress[this.nToltal] = reader["EquAddress"].ToString().Trim();
                            this.strAddCount[this.nToltal] = reader["EquCount"].ToString().Trim();
                            this.imgList.Items.Add(this.strLocation[this.nToltal]);
                            this.imgList.Items[this.nToltal].ImageIndex = 0;
                            this.nToltal++;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void btnBeginRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(((this.OpenDoor_Button.Enabled && this.button2.Enabled) && this.btnBeginRead.Enabled) && this.btnserach.Enabled))
                {
                    MessageBox.Show("请先停止当前操作，或等待当前操作完成后继续。", "错误!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    this.tabControl2.SelectedTab = this.tabPage5;
                    this.ReadData("Records");
                    string str = "select top 50 * from tb_Note order by NoteTime desc";
                    DataSet set = this.boperate.getds(str, "tb_Note");
                    this.gridControl2.DataSource = set.Tables[0];
                    this.dgvExecute.FocusedRowHandle = set.Tables[0].Rows.Count - 1;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void btnBlacklist_Click(object sender, EventArgs e)
        {
            try
            {
                new Form5(this.cbxSerialport.Text) { Owner = this }.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void btnNumber_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                this.toolTip1.SetToolTip(this.btnNumber, "编辑设备管理资料");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void btnReadCard_Click(object sender, EventArgs e)
        {
            try
            {
                this.SetButtonState(false);
                if (this.cbxSerialport.Items.Count == 0)
                {
                    MessageBox.Show("没有找到设备,请检查设备是否连接");
                    this.SetButtonState(true);
                }
                else
                {
                    this.OpenSerialPort();
                    byte[] password = new byte[] { 0xbd, 6, 0xb5, 0, 0, 0, 0, 0, 120 };
                    int num2 = this.readsanqu();
                    password[7] = (byte) num2;
                    byte num3 = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        num3 = (byte) (num3 + password[i]);
                    }
                    password[8] = num3;
                    if (num2 == 11)
                    {
                        MessageBox.Show("读取扇区错误");
                        comm.Close();
                        this.SetButtonState(true);
                    }
                    else
                    {
                        bool isloaddefaultpassword = true;
                        bool isExecutionconinue = false;
                        for (int j = 0; j < 1; j++)
                        {
                            int num8;
                            byte[] buffer3;
                            byte num9;
                            int num10;
                            int sector = num2;
                            this.LoadEquipmentPasswrod(sector);
                            this.stop();
                            if (!this.SearchCard())
                            {
                                comm.Close();
                                this.readTrue();
                                this.SetButtonState(true);
                                return;
                            }
                            this.readFalse();
                            byte[] buffer = new byte[] { 0xbd, 5, 0xb3, 0, 0, 0, 0, 0x75 };
                            comm.DiscardInBuffer();
                            comm.Write(buffer, 0, 8);
                            Array.Clear(buffer, 0, 8);
                            int num7 = 0;
                            while (num7 < 3)
                            {
                                try
                                {
                                    num8 = this.Receive();
                                    if (num8 == 11)
                                    {
                                        buffer3 = new byte[num8];
                                        comm.Read(buffer3, 0, num8);
                                        if ((buffer3[0] == 0xbd) && (buffer3[1] == 8))
                                        {
                                            num9 = 0;
                                            num10 = 0;
                                            while (num10 < 10)
                                            {
                                                num9 = (byte) (num9 + buffer3[num10]);
                                                num10++;
                                            }
                                            if (num9 != buffer3[10])
                                            {
                                                MessageBox.Show("数据接收不完整");
                                                comm.Close();
                                                this.readTrue();
                                            }
                                            else
                                            {
                                                string s = "";
                                                num10 = 3;
                                                while (num10 > 0)
                                                {
                                                    s = s + buffer3[num10 + 5].ToString("X2");
                                                    num10--;
                                                }
                                                int num11 = int.Parse(s, NumberStyles.HexNumber);
                                                string sql = "select * from CardSerial where CardNumber = @CardNumber";
                                                try
                                                {
                                                    OleDbParameter[] values = new OleDbParameter[] { new OleDbParameter("@CardNumber", num11.ToString("00000000")) };
                                                    DataTable dataSet = DBHelper.GetDataSet(sql, values);
                                                    if (dataSet.Rows.Count != 0)
                                                    {
                                                        foreach (DataRow row in dataSet.Rows)
                                                        {
                                                            this.txtCardNumber.Text = num11.ToString("00000000");
                                                            this.txtName.Text = (string) row["UserName"];
                                                            this.cbxsex.Text = (string) row["Sex"];
                                                            this.txtAreaName.Text = (string) row["AreaName"];
                                                            this.txtBuildingNo.Text = (string) row["BuildingNo"];
                                                            this.txtRoomNumber.Text = (string) row["RoomNumber"];
                                                            this.txtRemarks.Text = (string) row["Remark"];
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("查无此卡数据");
                                                        comm.Close();
                                                        this.SetButtonState(true);
                                                        this.readTrue();
                                                        return;
                                                    }
                                                }
                                                catch (Exception)
                                                {
                                                }
                                            }
                                            break;
                                        }
                                    }
                                }
                                catch (Exception)
                                {
                                    comm.DiscardInBuffer();
                                    comm.Close();
                                    this.readTrue();
                                }
                                if (num7 == 3)
                                {
                                    MessageBox.Show("接收数据失败！", "提示", MessageBoxButtons.OK);
                                }
                                num7++;
                            }
                            if (!this.VerificationPassword(ref isloaddefaultpassword, ref isExecutionconinue, ref j, password, sector))
                            {
                                comm.Close();
                                MessageBox.Show("非法卡");
                                this.SetButtonState(true);
                                this.readTrue();
                                this.ReadedCard = false;
                                return;
                            }
                            byte[] buffer4 = new byte[] { 0xbd, 6, 0xb7, 0, 0, 0, 0, 1, 0x7b };
                            buffer4[7] = (byte) ((num2 * 4) + 1);
                            byte num12 = 0;
                            int index = 0;
                            while (index < 8)
                            {
                                num12 = (byte) (num12 + buffer4[index]);
                                index++;
                            }
                            buffer4[8] = num12;
                            comm.DiscardInBuffer();
                            comm.Write(buffer4, 0, 9);
                            for (num7 = 0; num7 < 3; num7++)
                            {
                                try
                                {
                                    num8 = this.Receive1(0x7d0);
                                    if (num8 == 0x16)
                                    {
                                        buffer3 = new byte[num8];
                                        comm.Read(buffer3, 0, num8);
                                        if ((buffer3[0] == 0xbd) && (buffer3[1] == 0x13))
                                        {
                                            num9 = 0;
                                            for (num10 = 0; num10 < 0x15; num10++)
                                            {
                                                num9 = (byte) (num9 + buffer3[num10]);
                                            }
                                            if (num9 != buffer3[0x15])
                                            {
                                                MessageBox.Show("数据接收不完整");
                                                comm.Close();
                                                this.readTrue();
                                                this.SetButtonState(true);
                                            }
                                            else
                                            {
                                                switch (int.Parse(buffer3[0x10].ToString("X2"), NumberStyles.HexNumber))
                                                {
                                                    case 0:
                                                        this.comboBox1.SelectedIndex = 0;
                                                        break;

                                                    case 1:
                                                        this.comboBox1.SelectedIndex = 1;
                                                        break;

                                                    case 2:
                                                        this.comboBox1.SelectedIndex = 2;
                                                        break;

                                                    case 3:
                                                        this.comboBox1.SelectedIndex = 3;
                                                        break;

                                                    case 4:
                                                        this.comboBox1.SelectedIndex = 4;
                                                        break;
                                                }
                                                int num15 = int.Parse(buffer3[0x11].ToString("X2"), NumberStyles.HexNumber);
                                                if (num15 == 0xff)
                                                {
                                                    this.checkBox2.Checked = false;
                                                    this.txtCount.Text = "无限制";
                                                }
                                                else if (num15 == 0)
                                                {
                                                    this.txtCount.Text = num15.ToString();
                                                    this.checkBox2.Checked = true;
                                                }
                                                else
                                                {
                                                    this.txtCount.Text = num15.ToString();
                                                }
                                                string str3 = "20";
                                                index = 0;
                                                while (index < 3)
                                                {
                                                    if (index != 2)
                                                    {
                                                        str3 = str3 + buffer3[13 + index].ToString("X2") + "-";
                                                    }
                                                    else
                                                    {
                                                        str3 = str3 + buffer3[13 + index].ToString("X2");
                                                    }
                                                    index++;
                                                }
                                                string str4 = "20";
                                                for (index = 0; index < 3; index++)
                                                {
                                                    if (index != 2)
                                                    {
                                                        str4 = str4 + buffer3[0x12 + index].ToString("X2") + "-";
                                                    }
                                                    else
                                                    {
                                                        str4 = str4 + buffer3[0x12 + index].ToString("X2");
                                                    }
                                                }
                                                this.dateTimePicker2.Text = str3;
                                                this.dateTimePicker1.Text = str4;
                                            }
                                            break;
                                        }
                                    }
                                }
                                catch (Exception)
                                {
                                }
                                if (num7 == 3)
                                {
                                    MessageBox.Show("接收数据失败！", "提示", MessageBoxButtons.OK);
                                    comm.Close();
                                    this.readTrue();
                                }
                            }
                            isloaddefaultpassword = true;
                        }
                        Function.GetCardDeviceNumber(comm, this.cbxSerialport.Text, this.treeView1);
                        MessageBox.Show("读卡成功");
                        this.Family.Enabled = true;
                        comm.Close();
                        this.readTrue();
                        this.SetButtonState(true);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Console.WriteLine(exception.ToString());
                this.SetButtonState(true);
                this.readTrue();
                comm.Close();
            }
            finally
            {
                this.SetButtonState(true);
                this.readTrue();
            }
        }

        private void btnreadCard1_Click(object sender, EventArgs e)
        {
            try
            {
                this.ReadedCard = true;
                this.btnReadCard_Click(sender, e);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void btnselalmred_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "";
                string str2 = "";
                string str3 = "";
                str = this.dataBegin.DateTime.ToShortDateString();
                str2 = this.dateEnd.DateTime.ToShortDateString();
                if ((str == "0001-01-01") && (str2 == "0001-01-01"))
                {
                    str3 = "select * from tb_Alm";
                }
                else if ((str != "0001-01-01") && (str2 == "0001-01-01"))
                {
                    str3 = "select * from tb_Alm where cdate(left(AlmTime,10))>='" + str + "'";
                }
                else if ((str == "0001-01-01") && (str2 != "0001-01-01"))
                {
                    str3 = "select * from tb_Alm where cdate(left(AlmTime,10))<='" + str2 + "'";
                }
                else
                {
                    str3 = "select * from tb_Alm where cdate(left(AlmTime,10))>='" + str + "' and cdate(left(AlmTime,10))<='" + str2 + "'";
                }
                DataSet set = this.boperate.getds(str3, "tb_Alm");
                this.gridControl3.DataSource = set.Tables[0];
                this.tabControl2.SelectedTab = this.tabPage3;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                new Form4(this.UserPermissionType) { Owner = this }.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void btnsendcard1_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnSentCard_Click(sender, e);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void btnSentCard_Click(object sender, EventArgs e)
        {
            Exception exception;
            try
            {
                int num2;
                byte num5;
                byte num6;
                byte num7;
                byte num8;
                byte num9;
                byte num10;
                byte num11;
                this.SetButtonState(false);
                if (this.cbxSerialport.Items.Count == 0)
                {
                    MessageBox.Show("没有找到设备,请检查设备是否连接");
                    this.SetButtonState(true);
                    return;
                }
                this.buttonOpenClose_Click(sender, e);
                //int num = 0;
                //if (this.treeView1.Nodes.Count != 0)
                //{
                //    foreach (TreeNode node in this.treeView1.Nodes)
                //    {
                //        num2 = 0;
                //        while (num2 < node.Nodes.Count)
                //        {
                //            if (node.Nodes[num2].Checked)
                //            {
                //                num++;
                //            }
                //            num2++;
                //        }
                //    }
                //}
                //if (num == 0)
                //{
                //    MessageBox.Show("请至少选择一个设备编码");
                //    comm.Close();
                //    this.SetButtonState(true);
                //    return;
                //}
                if (this.txtName.Text.Trim().ToString().Equals(""))
                {
                    MessageBox.Show("姓名不能为空");
                    comm.Close();
                    this.SetButtonState(true);
                    return;
                }
                if (this.txtBuildingNo.Text.Trim().ToString().Equals(""))
                {
                    MessageBox.Show("楼号不能为空");
                    comm.Close();
                    this.SetButtonState(true);
                    return;
                }
                if (this.txtCount.Enabled)
                {
                    if (!(Regex.IsMatch(this.txtCount.Text.Trim(), "^[0-9]*[1-9][0-9]*$") && !this.txtCount.Text.Equals("")))
                    {
                        MessageBox.Show("请输入正确次数");
                        this.txtCount.Focus();
                        comm.Close();
                        this.SetButtonState(true);
                        return;
                    }
                    if (int.Parse(this.txtCount.Text.Trim().ToString()) > 250)
                    {
                        MessageBox.Show("次数最大值为250");
                        this.txtCount.Text = "250";
                        comm.Close();
                        this.SetButtonState(true);
                        return;
                    }
                }
                else
                {
                    this.txtCount.Text = "无限制";
                }
                if (this.dateTimePicker1.Value.Subtract(this.dateTimePicker2.Value).Days < 0)
                {
                    MessageBox.Show("有效期的结束日期不能比开始日期早");
                    comm.Close();
                    this.SetButtonState(true);
                    return;
                }
                this.SendFalse();
                this.ClearSector();
                string str8 = this.comboBox1.SelectedItem.ToString();
                if (str8 == null)
                {
                    goto Label_039D;
                }
                if (!(str8 == "无限制"))
                {
                    if (str8 == "时间段1")
                    {
                        goto Label_0389;
                    }
                    if (str8 == "时间段2")
                    {
                        goto Label_038E;
                    }
                    if (str8 == "时间段3")
                    {
                        goto Label_0393;
                    }
                    if (str8 == "时间段4")
                    {
                        goto Label_0398;
                    }
                    goto Label_039D;
                }
                byte timeFragment = 0;
                goto Label_03A2;
            Label_0389:
                timeFragment = 1;
                goto Label_03A2;
            Label_038E:
                timeFragment = 2;
                goto Label_03A2;
            Label_0393:
                timeFragment = 3;
                goto Label_03A2;
            Label_0398:
                timeFragment = 4;
                goto Label_03A2;
            Label_039D:
                timeFragment = 0;
            Label_03A2:
                if (this.checkBox2.Checked)
                {
                    num5 = (byte) int.Parse(this.txtCount.Text.Trim());
                }
                else
                {
                    num5 = 0xff;
                }
                if (this.checkBox1.Checked)
                {
                    num6 = Function.Dex2Hex(this.dateTimePicker2.Value.ToString("yyyy-MM-dd").Split(new char[] { '-' })[0].Substring(2, 2));
                    num7 = Function.Dex2Hex(this.dateTimePicker2.Value.ToString("yyy-MM-dd").Split(new char[] { '-' })[1]);
                    num8 = Function.Dex2Hex(this.dateTimePicker2.Value.ToString("yyy-MM-dd").Split(new char[] { '-' })[2]);
                    num9 = Function.Dex2Hex(this.dateTimePicker1.Value.ToString("yyyy-MM-dd").Split(new char[] { '-' })[0].Substring(2, 2));
                    num10 = Function.Dex2Hex(this.dateTimePicker1.Value.ToString("yyy-MM-dd").Split(new char[] { '-' })[1]);
                    num11 = Function.Dex2Hex(this.dateTimePicker1.Value.ToString("yyy-MM-dd").Split(new char[] { '-' })[2]);
                }
                else
                {
                    num6 = 0;
                    num7 = 0;
                    num8 = 0;
                    num9 = 0;
                    num10 = 0;
                    num11 = 0;
                }
                Console.WriteLine("TimeFragment = 0x{7:x},UseCount = 0x{0:x}, Start_Year = 0x{1:x}, Start_Mon = 0x{2:x}, Start_Day = 0x{3:x}, End_Year = 0x{4:x}, End_Mon = 0x{5:x}, End_Day = 0x{6:x}", new object[] { num5, num6, num7, num8, num9, num10, num11, timeFragment });
                this.cardserial = Function.SendCard(comm, this.cbxSerialport.Text, num5, num6, num7, num8, num9, num10, num11, timeFragment, this.treeView1);
                this.SerachSerialport();
                MessageBox.Show("发卡成功");
                string sql = "select * from building where BuildingNo = @BuildingNo";
                try
                {
                    OleDbParameter[] values = new OleDbParameter[] { new OleDbParameter("@BuildingNo", this.txtBuildingNo.Text.Trim().ToString()) };
                    if (DBHelper.GetDataSet(sql, values).Rows.Count == 0)
                    {
                        string str2 = "INSERT into Building (BuildingNo) VALUES (@BuildingNo)";
                        try
                        {
                            OleDbParameter[] parameterArray2 = new OleDbParameter[] { new OleDbParameter("@BuildingNo", this.txtBuildingNo.Text.Trim().ToString()) };
                            DBHelper.ExecuteCommand(str2, parameterArray2);
                        }
                        catch (Exception exception1)
                        {
                            Console.WriteLine(exception1.ToString());
                        }
                    }
                }
                catch (Exception exception2)
                {
                    Console.WriteLine(exception2.ToString());
                }
                string str3 = "insert into CardNumber (CardNumber,UserName,BuildingNo,SendCardTime,Remarks)values (@CardNumber,@UserName,@BuildingNo,@SendCardTime,@Remarks) ";
                try
                {
                    OleDbParameter[] parameterArray3 = new OleDbParameter[] { new OleDbParameter("@CarNumber", this.cardserial), new OleDbParameter("@UserName", this.txtName.Text), new OleDbParameter("@BuildingNo", this.txtBuildingNo.Text), new OleDbParameter("@SendCardTime", DateTime.Now.Date), new OleDbParameter("@Remarks", this.txtRemarks.Text) };
                    DBHelper.ExecuteCommand(str3, parameterArray3);
                }
                catch (Exception exception3)
                {
                    exception = exception3;
                    Console.WriteLine(exception.ToString());
                }
                int scalar = DBHelper.GetScalar("SELECT @@IDENTITY from CardNumber");
                foreach (TreeNode node in this.treeView1.Nodes)
                {
                    for (num2 = 0; num2 < node.Nodes.Count; num2++)
                    {
                        if (node.Nodes[num2].Checked)
                        {
                            string str4 = "insert into NickNameRecord (Nickname,CardNumberID) values (@Nickname,@CardNumberID)";
                            try
                            {
                                string[] strArray = node.Nodes[num2].Text.Split(new char[] { '(' });
                                OleDbParameter[] parameterArray4 = new OleDbParameter[] { new OleDbParameter("@Nickname", strArray[0]), new OleDbParameter("@CardNumberID", scalar) };
                                DBHelper.ExecuteCommand(str4, parameterArray4);
                            }
                            catch (Exception exception4)
                            {
                                exception = exception4;
                                MessageBox.Show(exception.Message.ToString());
                                Console.WriteLine(exception.ToString());
                            }
                        }
                    }
                }
                string str5 = "select * from CardSerial where CardNumber = @CardNumber";
                try
                {
                    OleDbParameter[] parameterArray5 = new OleDbParameter[] { new OleDbParameter("@CardNumber", this.cardserial) };
                    if (DBHelper.GetDataSet(str5, parameterArray5).Rows.Count == 0)
                    {
                        string str6 = "INSERT INTO CardSerial(CardNumber,UserName,Sex,AreaName,BuildingNo,RoomNumber,[Count],StartPeriod,Period,Remark) VALUES(@CardNumber,@UserName,@Sex,@AreaName,@BuildingNo,@RoomNumber,@Count,@StartPeriod,@Period,@Remark)";
                        try
                        {
                            OleDbParameter[] parameterArray6 = new OleDbParameter[] { new OleDbParameter("@CardNumber", this.cardserial), new OleDbParameter("@UserName", this.txtName.Text), new OleDbParameter("@Sex", this.cbxsex.Text), new OleDbParameter("@AreaName", this.txtAreaName.Text), new OleDbParameter("@BuildingNo", this.txtBuildingNo.Text), new OleDbParameter("@RoomNumber", this.txtRoomNumber.Text), new OleDbParameter("@Count", this.txtCount.Text.ToString()), new OleDbParameter("@StartPeriod", this.dateTimePicker2.Value.Date), new OleDbParameter("@Period", this.dateTimePicker1.Value.Date), new OleDbParameter("@Remark", this.txtRemarks.Text) };
                            DBHelper.ExecuteCommand(str6, parameterArray6);
                        }
                        catch (Exception exception5)
                        {
                            exception = exception5;
                            MessageBox.Show(exception.Message.ToString());
                            Console.WriteLine(exception.ToString());
                        }
                    }
                    else
                    {
                        string str7 = "UPDATE CardSerial SET UserName = @UserName,Sex = @Sex,AreaName = @AreaName,BuildingNo = @BuildingNo,RoomNumber = @RoomNumber,[Count] = @Count,StartPeriod = @StartPeriod,Period = @Period,Blacklist =@Blacklist,Remark = @Remark WHERE CardNumber = @CardNumber";
                        try
                        {
                            OleDbParameter[] parameterArray7 = new OleDbParameter[] { new OleDbParameter("@UserName", this.txtName.Text), new OleDbParameter("@Sex", this.cbxsex.Text), new OleDbParameter("@AreaName", this.txtAreaName.Text), new OleDbParameter("@BuildingNo", this.txtBuildingNo.Text), new OleDbParameter("@RoomNumber", this.txtRoomNumber.Text), new OleDbParameter("@Count", this.txtCount.Text.ToString()), new OleDbParameter("@StartPeriod", this.dateTimePicker2.Value.Date), new OleDbParameter("@Period", this.dateTimePicker1.Value.Date), new OleDbParameter("@Blacklist", "允许开门"), new OleDbParameter("@Remark", this.txtRemarks.Text), new OleDbParameter("@CardNumber", this.cardserial) };
                            DBHelper.ExecuteCommand(str7, parameterArray7);
                        }
                        catch (Exception exception6)
                        {
                            exception = exception6;
                            MessageBox.Show(exception.Message.ToString());
                            Console.WriteLine(exception.ToString());
                        }
                    }
                }
                catch (Exception exception7)
                {
                    exception = exception7;
                    MessageBox.Show(exception.Message.ToString());
                    Console.WriteLine(exception.ToString());
                }
                comm.Close();
                this.SendTrue();
                this.SetButtonState(true);
            }
            catch (Exception exception8)
            {
                exception = exception8;
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
                this.SetButtonState(true);
            }
            finally
            {
                comm.Close();
                this.SendTrue();
                this.SetButtonState(true);
            }
        }

        private void btnserach_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(((this.OpenDoor_Button.Enabled && this.button2.Enabled) && this.btnBeginRead.Enabled) && this.btnserach.Enabled))
                {
                    MessageBox.Show("请先停止当前操作，或等待当前操作完成后继续。", "错误!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (!(((this.OpenDoor_Button.Enabled && this.button2.Enabled) && this.btnBeginRead.Enabled) && this.btnserach.Enabled))
                {
                    MessageBox.Show("请先停止当前操作，或等待当前操作完成后继续。", "错误!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (this.imgList.ItemCount == 0)
                {
                    MessageBox.Show("没有可以使用的设备!!!!", "错误", MessageBoxButtons.OK);
                }
                else
                {
                    if (((Button) sender).Text.Contains("远程开门"))
                    {
                        ((Button) sender).Text = "执行中..";
                        ((Button) sender).Enabled = false;
                    }
                    else if (((Button) sender).Text.Contains("检测设备"))
                    {
                        ((Button) sender).Text = "检测中..";
                        ((Button) sender).Enabled = false;
                    }
                    string[] portNames = SerialPort.GetPortNames();
                    int num = 0;
                    for (int i = 0; i < 2; i++)
                    {
                        if (i == 0)
                        {
                            OperateComm.P_str_baud = "9600";
                        }
                        else
                        {
                            OperateComm.P_str_baud = "4800";
                        }
                        for (int j = 0; j < portNames.Length; j++)
                        {
                            byte[] buf = new byte[] { 0xbd, 5, 240, 0, 0, 0x10, 0, 0xc2 };
                            OperateComm.P_str_com = portNames[j];
                            if (!this.opComm.OpenComm())
                            {
                                MessageBox.Show("没发现此串口或串口已经在使用", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                return;
                            }
                            this.opComm.SendData(buf, 8);
                            for (int k = 0; k < 10; k++)
                            {
                                try
                                {
                                    int nlen = this.opComm.Receive(this.timer1, 50);
                                    if (nlen == 7)
                                    {
                                        byte[] buffer2 = new byte[nlen];
                                        buffer2 = this.opComm.ReadData(nlen);
                                        if ((buffer2[0] == 0xbd) && (buffer2[1] == 4))
                                        {
                                            byte num6 = 0;
                                            for (int m = 0; m < 6; m++)
                                            {
                                                num6 = (byte) (num6 + buffer2[m]);
                                            }
                                            if (num6 != buffer2[6])
                                            {
                                                MessageBox.Show("数据接收不完整");
                                            }
                                            else
                                            {
                                                if (buffer2[5] != 0)
                                                {
                                                    goto Label_0303;
                                                }
                                                if (((Button) sender).Text.Contains("检测中"))
                                                {
                                                    MessageBox.Show("找到设备");
                                                    ((Button) sender).Text = "检测设备";
                                                    ((Button) sender).Enabled = true;
                                                }
                                                num = 1;
                                            }
                                            break;
                                        }
                                    }
                                }
                                catch (Exception)
                                {
                                }
                            Label_0303:
                                if (k == 10)
                                {
                                    MessageBox.Show("接收数据失败！", "提示", MessageBoxButtons.OK);
                                }
                            }
                            this.opComm.CloseComm();
                            if (num == 1)
                            {
                                break;
                            }
                        }
                        if (num == 1)
                        {
                            if (((Button) sender).Text.Contains("执行中"))
                            {
                                try
                                {
                                    Open_BaudRatePort(int.Parse(OperateComm.P_str_com.Replace("COM", "")), int.Parse(OperateComm.P_str_baud));
                                    if (OpenDoor(int.Parse(OperateComm.P_str_com.Replace("COM", "")), (short) int.Parse(this.strAddress[this.imgList.SelectedIndex]), 1) == 1)
                                    {
                                        MessageBox.Show("远程开门成功!", "提示", MessageBoxButtons.OK);
                                        ((Button) sender).Text = "远程开门";
                                        ((Button) sender).Enabled = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("远程开门失败!", "提示", MessageBoxButtons.OK);
                                        ((Button) sender).Text = "远程开门";
                                        ((Button) sender).Enabled = true;
                                    }
                                    Close_Port(int.Parse(OperateComm.P_str_com.Replace("COM", "")));
                                }
                                catch (Exception exception)
                                {
                                    Console.WriteLine(exception.ToString());
                                }
                            }
                            break;
                        }
                    }
                    if (num == 0)
                    {
                        MessageBox.Show("没有找到设备");
                        if (((Button) sender).Text.Contains("检测中"))
                        {
                            ((Button) sender).Text = "检测设备";
                        }
                        else
                        {
                            ((Button) sender).Text = "远程开门 ";
                        }
                        ((Button) sender).Enabled = true;
                    }
                }
            }
            catch (Exception exception2)
            {
                MessageBox.Show(exception2.Message.ToString());
                Console.WriteLine(exception2.ToString());
            }
        }

        private void btnSerchSerial_Click(object sender, EventArgs e)
        {
            try
            {
                this.cbxSerialport.Items.Clear();
                string[] portNames = SerialPort.GetPortNames();
                for (int i = 0; i < portNames.Length; i++)
                {
                    byte[] buffer = new byte[] { 0xbd, 5, 240, 0, 0, 0, 0, 0xb2 };
                    comm.PortName = portNames[i];
                    comm.BaudRate = 0x2580;
                    comm.Open();
                    comm.DiscardInBuffer();
                    comm.Write(buffer, 0, 8);
                    for (int j = 0; j < 10; j++)
                    {
                        try
                        {
                            int count = this.Receive();
                            if (count == 7)
                            {
                                byte[] buffer2 = new byte[count];
                                comm.Read(buffer2, 0, count);
                                if ((buffer2[0] == 0xbd) && (buffer2[1] == 4))
                                {
                                    byte num4 = 0;
                                    for (int k = 0; k < 6; k++)
                                    {
                                        num4 = (byte) (num4 + buffer2[k]);
                                    }
                                    if (num4 != buffer2[6])
                                    {
                                        MessageBox.Show("数据接收不完整");
                                        break;
                                    }
                                    if (buffer2[5] == 0)
                                    {
                                        try
                                        {
                                            this.cbxSerialport.Items.Add(portNames[i]);
                                            this.cbxSerialport.SelectedIndex = (this.cbxSerialport.Items.Count > 0) ? 0 : -1;
                                        }
                                        catch
                                        {
                                            MessageBox.Show("没有找到设备");
                                            return;
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception)
                        {
                        }
                        if (j == 10)
                        {
                            MessageBox.Show("接收数据失败！", "提示", MessageBoxButtons.OK);
                        }
                    }
                    comm.Close();
                }
                if (this.cbxSerialport.Items.Count == 0)
                {
                    MessageBox.Show("没有找到设备");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void btnSerchSerial_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.cbxSerialport.Items.Clear();
                this.cbxSerialport.Text = string.Empty;
                this.cbxSerialport.Items.Clear();
                this.SetButtonState(false);
                string[] portNames = SerialPort.GetPortNames();
                for (int i = 0; i < portNames.Length; i++)
                {
                    //    byte[] buffer = new byte[] { 0xbd, 5, 240, 0, 0, 0, 0, 0xb2 };
                    //    try
                    //    {
                    //        comm.PortName = portNames[i];
                    //        comm.BaudRate = 0x2580;
                    //        comm.Open();
                    //        comm.DiscardInBuffer();
                    //        comm.Write(buffer, 0, 8);
                    //    }
                    //    catch
                    //    {
                    //    }
                    //    for (int j = 0; j < 10; j++)
                    //    {
                    //        try
                    //        {
                    //            int count = this.Receive();
                    //            if (count == 7)
                    //            {
                    //                byte[] buffer2 = new byte[count];
                    //                comm.Read(buffer2, 0, count);
                    //                if ((buffer2[0] == 0xbd) && (buffer2[1] == 4))
                    //                {
                    //                    byte num4 = 0;
                    //                    for (int k = 0; k < 6; k++)
                    //                    {
                    //                        num4 = (byte) (num4 + buffer2[k]);
                    //                    }
                    //                    if (num4 != buffer2[6])
                    //                    {
                    //                        MessageBox.Show("数据接收不完整");
                    //                        break;
                    //                    }
                    //                    if (buffer2[5] == 0)
                    //                    {
                    this.cbxSerialport.Items.Add(portNames[i]);
                    this.cbxSerialport.Text = portNames[i];
                    //                        break;
                    //                    }
                    //                }
                    //            }
                    //        }
                    //        catch (Exception)
                    //        {
                    //        }
                    //        if (j == 10)
                    //        {
                    //            MessageBox.Show("接收数据失败！", "提示", MessageBoxButtons.OK);
                    //        }
                    //    }
                    //    comm.Close();
                    //    if (this.cbxSerialport.Items.Count != 0)
                    //    {
                    //        break;
                    //    }
                }
                if (this.cbxSerialport.Items.Count == 0)
                {
                    MessageBox.Show("没有找到设备,请检查设备是否连接");
                }
                this.SetButtonState(true);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
                this.SetButtonState(true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.UserPermissionType.Contains("Admin"))
                {
                    new Form2 { Owner = this }.ShowDialog();
                }
                else
                {
                    MessageBox.Show("权限不足", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                new OperatorUserManagement { Owner = this }.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(((this.OpenDoor_Button.Enabled && this.button2.Enabled) && this.btnBeginRead.Enabled) && this.btnserach.Enabled))
                {
                    MessageBox.Show("请先停止当前操作，或等待当前操作完成后继续。", "错误!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    this.tabControl2.SelectedTab = this.tabPage4;
                    this.opAndvalidate.autoNum("select max(NoteID) from tb_Note", "tb_Note", "NoteID", "No", "1000001", this.txtUserID);
                    this.strMaxID = this.txtUserID.Text.Trim();
                    this.strMaxID = this.strMaxID.Substring(2, 7);
                    this.opAndvalidate.autoNum("select max(AlmID) from tb_Alm", "tb_Alm", "AlmID", "Al", "1000001", this.txtUserID);
                    this.strAlmMaxID = this.txtUserID.Text.Trim();
                    this.strAlmMaxID = this.strAlmMaxID.Substring(2, 7);
                    this.flag1 = 0;
                    this.flag = 0;
                    string[] strArray = new string[this.nToltal];
                    this.strAddMonitoring = new string[this.nToltal];
                    this.nMoniPtr = new int[this.nToltal];
                    this.strPosition = new string[this.imgList.SelectedItems.Count];
                    string[] strArray2 = new string[this.imgList.SelectedItems.Count];
                    this.byAddrCount = new byte[this.imgList.SelectedItems.Count];
                    for (int i = 0; i < this.imgList.SelectedItems.Count; i++)
                    {
                        strArray[i] = this.imgList.SelectedItems[i].ToString();
                        for (int j = 0; j < this.nToltal; j++)
                        {
                            if (strArray[i] == this.strLocation[j])
                            {
                                this.strAddMonitoring[i] = this.strAddress[j];
                                strArray2[i] = this.strAddCount[j];
                                if (strArray2[i] == "1号门")
                                {
                                    this.byAddrCount[i] = 1;
                                }
                                else if (strArray2[i] == "2号门")
                                {
                                    this.byAddrCount[i] = 2;
                                }
                                else if (strArray2[i] == "3号门")
                                {
                                    this.byAddrCount[i] = 3;
                                }
                                else if (strArray2[i] == "4号门")
                                {
                                    this.byAddrCount[i] = 4;
                                }
                                this.strPosition[i] = this.strLocation[j];
                                this.nMoniPtr[i] = j;
                                break;
                            }
                        }
                    }
                    this.nAddrMonitoring = this.imgList.SelectedItems.Count;
                    if (!this.opComm.OpenComm())
                    {
                        MessageBox.Show("没发现此串口或串口已经在使用", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else if (this.imgList.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("请选择设备", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        this.StartPolling();
                        this.threadMonitoring = new Thread(new ThreadStart(this.multi_comm_send_thread_func));
                        this.threadMonitoring.IsBackground = true;
                        this.threadMonitoring.Start();
                        this.button2.Enabled = false;
                        this.button3.Enabled = true;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.button2.Enabled = true;
                this.button3.Enabled = false;
                this.timer1.Enabled = false;
                this.CloseThreadCOM();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(((this.OpenDoor_Button.Enabled && this.button2.Enabled) && this.btnBeginRead.Enabled) && this.btnserach.Enabled))
                {
                    MessageBox.Show("请先停止当前操作，或等待当前操作完成后继续。", "错误!!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    new frmEquTimeD().Show();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        public void buttonOpenClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (comm.IsOpen)
                {
                    comm.Close();
                }
                else
                {
                    comm.PortName = this.cbxSerialport.Text;
                    comm.BaudRate = 0x2580;
                    try
                    {
                        comm.Open();
                    }
                    catch (Exception exception)
                    {
                        comm = new SerialPort();
                        MessageBox.Show(exception.Message);
                    }
                }
            }
            catch (Exception exception2)
            {
                MessageBox.Show(exception2.Message.ToString());
                Console.WriteLine(exception2.ToString());
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.checkBox1.Checked)
                {
                    this.dateTimePicker1.Enabled = true;
                    this.dateTimePicker2.Enabled = true;
                }
                else
                {
                    this.dateTimePicker1.Enabled = false;
                    this.dateTimePicker2.Enabled = false;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.checkBox2.Checked)
                {
                    this.txtCount.Enabled = true;
                }
                else
                {
                    this.txtCount.Enabled = false;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (((CheckBox) sender).Checked)
            {
                this.txtCount.Enabled = true;
            }
            else
            {
                this.txtCount.Enabled = false;
            }
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int num;
                if (this.chkSelectAll.Checked)
                {
                    if (this.treeView1.Nodes.Count != 0)
                    {
                        foreach (TreeNode node in this.treeView1.Nodes)
                        {
                            num = 0;
                            while (num < node.Nodes.Count)
                            {
                                node.Nodes[num].Checked = true;
                                num++;
                            }
                        }
                    }
                }
                else if (this.treeView1.Nodes.Count != 0)
                {
                    foreach (TreeNode node in this.treeView1.Nodes)
                    {
                        for (num = 0; num < node.Nodes.Count; num++)
                        {
                            node.Nodes[num].Checked = false;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private bool ClearSector()
        {
            try
            {
                int num2 = GetDataTable().Rows.Count / 8;
                num2 /= 0x10;
                int num3 = (num2 / 3) + 1;
                string blockNumber = Convert.ToString(num3, 0x10);
                ArrayList list = IntoByte(num3, blockNumber);
                byte[] buffer3 = new byte[] { 0xbd, 6, 160, 0, 0, 0, 0, 0, 0 };
                buffer3[7] = (byte) list[0];
                byte[] buffer = buffer3;
                byte num4 = 0;
                int index = 0;
                while (index < 8)
                {
                    num4 = (byte) (num4 + buffer[index]);
                    index++;
                }
                buffer[8] = num4;
                comm.ReadTimeout = 0xbb8;
                comm.DiscardInBuffer();
                comm.Write(buffer, 0, 9);
                bool flag = false;
                string text = "清空扇区失败";
                for (int i = 0; i < 30; i++)
                {
                    try
                    {
                        int count = this.Receive();
                        if (count == 7)
                        {
                            byte[] buffer2 = new byte[count];
                            comm.Read(buffer2, 0, count);
                            if ((buffer2[0] != 0xbd) || (buffer2[1] != 4))
                            {
                                goto Label_018B;
                            }
                            byte num8 = 0;
                            for (index = 0; index < 6; index++)
                            {
                                num8 = (byte) (num8 + buffer2[index]);
                            }
                            if (num8 != buffer2[6])
                            {
                            }
                            if (buffer2[5] == 0)
                            {
                                flag = true;
                            }
                            else
                            {
                                MessageBox.Show(text);
                            }
                            break;
                        }
                        Thread.Sleep(100);
                    }
                    catch (Exception)
                    {
                    }
                Label_018B:
                    if (i == 15)
                    {
                        MessageBox.Show("接收数据失败！", "提示", MessageBoxButtons.OK);
                    }
                }
                return flag;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
                return false;
            }
        }

        [DllImport("KADCOMDoor.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
        public static extern int Close_Port(int PortIndex);
        private void CloseThreadCOM()
        {
            try
            {
                this.opComm.CloseComm();
                if (this.threadMonitoring != null)
                {
                    try
                    {
                        this.threadMonitoring.Abort();
                    }
                    catch (Exception exception1)
                    {
                        Console.WriteLine(exception1.ToString());
                    }
                }
            }
            catch (Exception exception2)
            {
                Exception exception = exception2;
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private static ArrayList DadeTimeIntoByte(int _datetime)
        {
            try
            {
                MatchCollection matchs;
                ArrayList list = new ArrayList();
                if (_datetime > 9)
                {
                    matchs = Regex.Matches(_datetime.ToString(), @"\S\S", RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);
                }
                else
                {
                    matchs = Regex.Matches("0" + _datetime, @"\S\S", RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);
                }
                list.Add(Convert.ToByte(matchs[0].ToString(), 0x10));
                return list;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
                return new ArrayList();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Family_Click(object sender, EventArgs e)
        {
            发卡模块.Family family = new 发卡模块.Family(this, this.cbxSerialport.Text);
            if (family.ShowDialog() == DialogResult.OK)
            {
            }
            family.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.CloseThreadCOM();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.dgvExecute.OptionsBehavior.Editable = false;
                this.dgvExecute.OptionsView.ShowGroupPanel = false;
                this.gridView1.OptionsBehavior.Editable = false;
                this.gridView1.OptionsView.ShowGroupPanel = false;
                this.cbxSerialport.SelectedIndex = (this.cbxSerialport.Items.Count > 0) ? 0 : -1;
                this.cbxsex.SelectedIndex = (this.cbxsex.Items.Count > 0) ? 0 : -1;
                this.comboBox1.SelectedIndex = (this.comboBox1.Items.Count > 0) ? 0 : -1;
                this.checkBox1.Checked = true;
                this.checkBox2.Checked = false;
                this.txtCount.Enabled = false;
                this.dateTimePicker1.Value = this.dateTimePicker1.Value.AddYears(50);
                string safeSql = "select * from Building";
                DataTable dataSet = DBHelper.GetDataSet(safeSql);
                foreach (DataRow row in dataSet.Rows)
                {
                    this.txtBuildingNo.Text = (string) row["BuildingNo"];
                    this.txtBuildingNo.AutoCompleteCustomSource.Add((string) row["BuildingNo"]);
                }
                if (this.userinfoID == 1)
                {
                    this.用户管理ToolStripMenuItem.Enabled = true;
                }
                else
                {
                    this.用户管理ToolStripMenuItem.Enabled = false;
                }
                this.load();
                try
                {
                    string str2 = "select EquID,EquAddress,EquCount,EquFloor,EquLocation from tb_Equ";
                    this.imgList.Items.Clear();
                    OleDbDataReader reader = this.boperate.getread(str2);
                    this.nToltal = 0;
                    while (reader.Read())
                    {
                        this.strLocation[this.nToltal] = reader["EquLocation"].ToString().Trim();
                        this.strAddress[this.nToltal] = reader["EquAddress"].ToString().Trim();
                        this.strAddCount[this.nToltal] = reader["EquCount"].ToString().Trim();
                        this.imgList.Items.Add(this.strLocation[this.nToltal]);
                        this.imgList.Items[this.nToltal].ImageIndex = 0;
                        this.nToltal++;
                    }
                }
                catch
                {
                    try
                    {
                        string str3 = "create table tb_Equ (EquID varchar(255) primary key,EquAddress varchar(10),EquLocation varchar(255),EquFloor varchar(255),EquIsAllot varchar(5),EquCount varchar(10))";
                        DBHelper.ExecuteCommand(str3);
                    }
                    catch
                    {
                    }
                    try
                    {
                        string str4 = "create table tb_Alm (AlmID varchar(20) primary key,AlmEqu varchar(10),AlmLocation varchar(255),AlmRemark varchar(255),AlmTime varchar(20),AlmCount varchar(20),AlmPass varchar(10),AlmCard varchar(20))";
                        DBHelper.ExecuteCommand(str4);
                    }
                    catch
                    {
                    }
                    try
                    {
                        string str5 = "create table tb_Execute (ExID varchar(255) primary key,ExTime varchar(30),ExCmd varchar(255),ExTarget varchar(255),ExResult varchar(255))";
                        DBHelper.ExecuteCommand(str5);
                    }
                    catch
                    {
                    }
                    try
                    {
                        string str6 = "create table tb_Note (NoteID varchar(50) primary key,NoteName varchar(255),NoteSex varchar(255),NoteArea varchar(20),NoteBuild varchar(255),NoteRoomNum varchar(255),NoteCard varchar(255),NoteTime varchar(30),NotePosition varchar(255),NoteInOut varchar(4),NotePass varchar(10),NoteRemark varchar(255))";
                        DBHelper.ExecuteCommand(str6);
                    }
                    catch
                    {
                    }
                    try
                    {
                        string str7 = "create table tb_TimeD (TimeID varchar(20) primary key,TimeStart1 varchar(100),TimeEnd1 varchar(100),TimeStart2 varchar(100),TimeEnd2 varchar(100),TimeStart3 varchar(100),TimeEnd3 varchar(100),TimeStart4 varchar(100),TimeEnd4 varchar(100),TimeMon varchar(5),TimeTues varchar(5),TimeWed varchar(5),TimeThurs varchar(5),TimeFri varchar(5),TimeSat varchar(5),TimeSun varchar(5),TimeName varchar(5))";
                        DBHelper.ExecuteCommand(str7);
                    }
                    catch
                    {
                    }
                    MessageBox.Show("数据库修复完成,请重新登陆");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private IList<ArrayList> GetBytes()
        {
            try
            {
                IList<ArrayList> sectorByNunber = this.GetSectorByNunber();
                IList<ArrayList> list2 = new List<ArrayList>();
                ArrayList item = new ArrayList();
                ArrayList list4 = new ArrayList();
                List<byte> list5 = new List<byte>(0x1000);
                byte num = 0;
                byte num2 = 0;
                byte[] buffer5 = new byte[] { 
                    0xbd, 0x16, 0xb9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
                    0, 0, 0, 0, 0, 0, 0, 0, 0
                 };
                buffer5[0x18] = num;
                byte[] collection = buffer5;
                buffer5 = new byte[] { 0xbd, 6, 0xb5, 0, 0, 0, 0, 0, 0 };
                buffer5[8] = num2;
                byte[] buffer2 = buffer5;
                for (int i = 0; i < sectorByNunber.Count; i++)
                {
                    byte[] buffer3;
                    byte[] buffer4;
                    int num6;
                    int num7;
                    int num8;
                    ArrayList list10;
                    ArrayList list11;
                    int num9;
                    ArrayList list6 = sectorByNunber[i];
                    int num4 = int.Parse(list6[1].ToString());
                    int num5 = int.Parse(list6[0].ToString());
                    string blockNumber = Convert.ToString(num4, 0x10);
                    string str2 = Convert.ToString(num5, 0x10);
                    ArrayList list7 = IntoByte(num4, blockNumber);
                    ArrayList list8 = IntoByte(num5, str2);
                    buffer2[7] = (byte) list8[0];
                    ArrayList list9 = new ArrayList();
                    if (i == 0)
                    {
                        list9 = sectorByNunber[0];
                    }
                    else
                    {
                        list9 = sectorByNunber[i - 1];
                    }
                    if (list6[0].ToString() == list9[0].ToString())
                    {
                        collection[7] = (byte) list7[0];
                        if (list6[1].ToString() == list9[1].ToString())
                        {
                            buffer3 = new byte[0x19];
                            buffer4 = new byte[9];
                            num6 = int.Parse(list6[2].ToString());
                            num7 = int.Parse(list6[3].ToString());
                            num8 = int.Parse(Convert.ToString(collection[num6 + 8], 10)) | (((int) 0x80) >> num7);
                            collection[num6 + 8] = (byte) num8;
                            list10 = new ArrayList();
                            list11 = sectorByNunber[sectorByNunber.Count - 1];
                            if (list6 == list11)
                            {
                                list10 = list11;
                            }
                            else
                            {
                                list10 = sectorByNunber[i + 1];
                            }
                            if ((list6[1].ToString() != list10[1].ToString()) && (list6 != list11))
                            {
                                num = 0;
                                num9 = 0;
                                while (num9 < 0x18)
                                {
                                    num = (byte) (num + collection[num9]);
                                    num9++;
                                }
                                collection[0x18] = num;
                                list5.AddRange(collection);
                                list5.CopyTo(0, buffer3, 0, 0x19);
                                item.Add(buffer3);
                                num9 = 0;
                                while (num9 < 0x12)
                                {
                                    collection[num9 + 7] = 0;
                                    num9++;
                                }
                                list5.RemoveRange(0, 0x19);
                            }
                            else if (list6 == list11)
                            {
                                num = 0;
                                num9 = 0;
                                while (num9 < 0x18)
                                {
                                    num = (byte) (num + collection[num9]);
                                    num9++;
                                }
                                collection[0x18] = num;
                                list5.AddRange(collection);
                                list5.CopyTo(0, buffer3, 0, 0x19);
                                item.Add(buffer3);
                                num9 = 0;
                                while (num9 < 0x12)
                                {
                                    collection[num9 + 7] = 0;
                                    num9++;
                                }
                                list5.RemoveRange(0, 0x19);
                                num2 = 0;
                                num9 = 0;
                                while (num9 < 8)
                                {
                                    num2 = (byte) (num2 + buffer2[num9]);
                                    num9++;
                                }
                                buffer2[8] = num2;
                                list5.AddRange(buffer2);
                                list5.CopyTo(0, buffer4, 0, 9);
                                list4.Add(buffer4);
                                buffer2[7] = 0;
                                buffer2[8] = 0;
                                list5.RemoveRange(0, 9);
                            }
                            if (list6[0].ToString() != list10[0].ToString())
                            {
                                num2 = 0;
                                num9 = 0;
                                while (num9 < 8)
                                {
                                    num2 = (byte) (num2 + buffer2[num9]);
                                    num9++;
                                }
                                buffer2[8] = num2;
                                list5.AddRange(buffer2);
                                list5.CopyTo(0, buffer4, 0, 9);
                                list4.Add(buffer4);
                                buffer2[7] = 0;
                                buffer2[8] = 0;
                                list5.RemoveRange(0, 9);
                            }
                        }
                        else
                        {
                            buffer3 = new byte[0x19];
                            buffer4 = new byte[9];
                            num6 = int.Parse(list6[2].ToString());
                            num7 = int.Parse(list6[3].ToString());
                            num8 = int.Parse(Convert.ToString(collection[num6 + 8], 10)) | (((int) 0x80) >> num7);
                            collection[num6 + 8] = (byte) num8;
                            list10 = new ArrayList();
                            list11 = sectorByNunber[sectorByNunber.Count - 1];
                            if (list6[1].ToString() == list11[1].ToString())
                            {
                                list10 = list11;
                            }
                            else
                            {
                                list10 = sectorByNunber[i + 1];
                            }
                            if ((list6[1].ToString() != list10[1].ToString()) && (list6 != list11))
                            {
                                num = 0;
                                num9 = 0;
                                while (num9 < 0x18)
                                {
                                    num = (byte) (num + collection[num9]);
                                    num9++;
                                }
                                collection[0x18] = num;
                                list5.AddRange(collection);
                                list5.CopyTo(0, buffer3, 0, 0x19);
                                item.Add(buffer3);
                                num9 = 0;
                                while (num9 < 0x12)
                                {
                                    collection[num9 + 7] = 0;
                                    num9++;
                                }
                                list5.RemoveRange(0, 0x19);
                            }
                            else if (list6 == list11)
                            {
                                num = 0;
                                num9 = 0;
                                while (num9 < 0x18)
                                {
                                    num = (byte) (num + collection[num9]);
                                    num9++;
                                }
                                collection[0x18] = num;
                                list5.AddRange(collection);
                                list5.CopyTo(0, buffer3, 0, 0x19);
                                item.Add(buffer3);
                                num9 = 0;
                                while (num9 < 0x12)
                                {
                                    collection[num9 + 7] = 0;
                                    num9++;
                                }
                                list5.RemoveRange(0, 0x19);
                                num2 = 0;
                                num9 = 0;
                                while (num9 < 8)
                                {
                                    num2 = (byte) (num2 + buffer2[num9]);
                                    num9++;
                                }
                                buffer2[8] = num2;
                                list5.AddRange(buffer2);
                                list5.CopyTo(0, buffer4, 0, 9);
                                list4.Add(buffer4);
                                buffer2[7] = 0;
                                buffer2[8] = 0;
                                list5.RemoveRange(0, 9);
                            }
                            if (list6[0].ToString() != list10[0].ToString())
                            {
                                num2 = 0;
                                num9 = 0;
                                while (num9 < 8)
                                {
                                    num2 = (byte) (num2 + buffer2[num9]);
                                    num9++;
                                }
                                buffer2[8] = num2;
                                list5.AddRange(buffer2);
                                list5.CopyTo(0, buffer4, 0, 9);
                                list4.Add(buffer4);
                                buffer2[7] = 0;
                                buffer2[8] = 0;
                                list5.RemoveRange(0, 9);
                            }
                        }
                    }
                    else
                    {
                        collection[7] = (byte) list7[0];
                        if (list6[1].ToString() == list9[1].ToString())
                        {
                            buffer3 = new byte[0x19];
                            buffer4 = new byte[9];
                            num6 = int.Parse(list6[2].ToString());
                            num7 = int.Parse(list6[3].ToString());
                            num8 = int.Parse(Convert.ToString(collection[num6 + 8], 10)) | (((int) 0x80) >> num7);
                            collection[num6 + 8] = (byte) num8;
                            list10 = new ArrayList();
                            list11 = sectorByNunber[sectorByNunber.Count - 1];
                            if (list6 == list11)
                            {
                                list10 = list11;
                            }
                            else
                            {
                                list10 = sectorByNunber[i + 1];
                            }
                            if ((list6[1].ToString() != list10[1].ToString()) && (list6 != list11))
                            {
                                num = 0;
                                num9 = 0;
                                while (num9 < 0x18)
                                {
                                    num = (byte) (num + collection[num9]);
                                    num9++;
                                }
                                collection[0x18] = num;
                                list5.AddRange(collection);
                                list5.CopyTo(0, buffer3, 0, 0x19);
                                item.Add(buffer3);
                                num9 = 0;
                                while (num9 < 0x12)
                                {
                                    collection[num9 + 7] = 0;
                                    num9++;
                                }
                                list5.RemoveRange(0, 0x19);
                            }
                            else if (list6 == list11)
                            {
                                num = 0;
                                num9 = 0;
                                while (num9 < 0x18)
                                {
                                    num = (byte) (num + collection[num9]);
                                    num9++;
                                }
                                collection[0x18] = num;
                                list5.AddRange(collection);
                                list5.CopyTo(0, buffer3, 0, 0x19);
                                item.Add(buffer3);
                                num9 = 0;
                                while (num9 < 0x12)
                                {
                                    collection[num9 + 7] = 0;
                                    num9++;
                                }
                                list5.RemoveRange(0, 0x19);
                            }
                            if (list6[0].ToString() != list10[0].ToString())
                            {
                                num2 = 0;
                                num9 = 0;
                                while (num9 < 8)
                                {
                                    num2 = (byte) (num2 + buffer2[num9]);
                                    num9++;
                                }
                                buffer2[8] = num2;
                                list5.AddRange(buffer2);
                                list5.CopyTo(0, buffer4, 0, 9);
                                list4.Add(buffer4);
                                buffer2[7] = 0;
                                buffer2[8] = 0;
                                list5.RemoveRange(0, 9);
                            }
                        }
                        else
                        {
                            buffer3 = new byte[0x19];
                            buffer4 = new byte[9];
                            num6 = int.Parse(list6[2].ToString());
                            num7 = int.Parse(list6[3].ToString());
                            num8 = int.Parse(Convert.ToString(collection[num6 + 8], 10)) | (((int) 0x80) >> num7);
                            collection[num6 + 8] = (byte) num8;
                            list10 = new ArrayList();
                            list11 = sectorByNunber[sectorByNunber.Count - 1];
                            if (list6[1].ToString() == list11[1].ToString())
                            {
                                list10 = list11;
                            }
                            else
                            {
                                list10 = sectorByNunber[i + 1];
                            }
                            if ((list6[1].ToString() != list10[1].ToString()) && (list6 != list11))
                            {
                                num = 0;
                                num9 = 0;
                                while (num9 < 0x18)
                                {
                                    num = (byte) (num + collection[num9]);
                                    num9++;
                                }
                                collection[0x18] = num;
                                list5.AddRange(collection);
                                list5.CopyTo(0, buffer3, 0, 0x19);
                                item.Add(buffer3);
                                num9 = 0;
                                while (num9 < 0x12)
                                {
                                    collection[num9 + 7] = 0;
                                    num9++;
                                }
                                list5.RemoveRange(0, 0x19);
                            }
                            else if (list6 == list11)
                            {
                                num = 0;
                                num9 = 0;
                                while (num9 < 0x18)
                                {
                                    num = (byte) (num + collection[num9]);
                                    num9++;
                                }
                                collection[0x18] = num;
                                list5.AddRange(collection);
                                list5.CopyTo(0, buffer3, 0, 0x19);
                                item.Add(buffer3);
                                num9 = 0;
                                while (num9 < 0x12)
                                {
                                    collection[num9 + 7] = 0;
                                    num9++;
                                }
                                list5.RemoveRange(0, 0x19);
                                num2 = 0;
                                num9 = 0;
                                while (num9 < 8)
                                {
                                    num2 = (byte) (num2 + buffer2[num9]);
                                    num9++;
                                }
                                buffer2[8] = num2;
                                list5.AddRange(buffer2);
                                list5.CopyTo(0, buffer4, 0, 9);
                                list4.Add(buffer4);
                                buffer2[7] = 0;
                                buffer2[8] = 0;
                                list5.RemoveRange(0, 9);
                            }
                            if (list6[0].ToString() != list10[0].ToString())
                            {
                                num2 = 0;
                                for (num9 = 0; num9 < 8; num9++)
                                {
                                    num2 = (byte) (num2 + buffer2[num9]);
                                }
                                buffer2[8] = num2;
                                list5.AddRange(buffer2);
                                list5.CopyTo(0, buffer4, 0, 9);
                                list4.Add(buffer4);
                                buffer2[7] = 0;
                                buffer2[8] = 0;
                                list5.RemoveRange(0, 9);
                            }
                        }
                    }
                }
                list2.Add(list4);
                list2.Add(item);
                return list2;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
                return new List<ArrayList>();
            }
        }

        public bool GetCardNumber()
        {
            try
            {
                byte[] buffer = new byte[] { 0xbd, 5, 0xb3, 0, 0, 0, 0, 0x75 };
                comm.DiscardInBuffer();
                comm.Write(buffer, 0, 8);
                Array.Clear(buffer, 0, 8);
                bool flag = false;
                for (int i = 0; i < 3; i++)
                {
                    try
                    {
                        int count = this.Receive();
                        if (count == 11)
                        {
                            byte[] buffer2 = new byte[count];
                            comm.Read(buffer2, 0, count);
                            if ((buffer2[0] == 0xbd) && (buffer2[1] == 8))
                            {
                                byte num3 = 0;
                                int index = 0;
                                while (index < 10)
                                {
                                    num3 = (byte) (num3 + buffer2[index]);
                                    index++;
                                }
                                if (num3 != buffer2[10])
                                {
                                    flag = false;
                                }
                                else
                                {
                                    string s = "";
                                    for (index = 3; index > 0; index--)
                                    {
                                        s = s + buffer2[index + 5].ToString("X2");
                                    }
                                    this.cardserial = int.Parse(s, NumberStyles.HexNumber).ToString("00000000");
                                    flag = true;
                                    break;
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        comm.DiscardInBuffer();
                    }
                    if (i == 3)
                    {
                        MessageBox.Show("接收数据失败！", "提示", MessageBoxButtons.OK);
                        flag = false;
                    }
                }
                return flag;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
                return false;
            }
        }

        public static DataTable GetDataTable()
        {
            try
            {
                XmlDocument document = new XmlDocument();
                document.Load(Application.StartupPath + @"\address.xml");
                XmlNodeList childNodes = document.SelectSingleNode("NewXML").ChildNodes;
                DataTable table = new DataTable();
                for (int i = 0; i < childNodes.Count; i++)
                {
                    DataRow row = table.NewRow();
                    XmlElement element = (XmlElement) childNodes.Item(i);
                    int index = 0;
                    while (index < element.Attributes.Count)
                    {
                        if (!table.Columns.Contains(element.Attributes[index].Name))
                        {
                            table.Columns.Add(element.Attributes[index].Name);
                        }
                        row[element.Attributes[index].Name] = element.Attributes[index].Value;
                        index++;
                    }
                    for (index = 0; index < element.ChildNodes.Count; index++)
                    {
                        if (!table.Columns.Contains(element.ChildNodes.Item(index).Name))
                        {
                            table.Columns.Add(element.ChildNodes.Item(index).Name);
                        }
                        row[element.ChildNodes.Item(index).Name] = element.ChildNodes.Item(index).InnerText;
                    }
                    table.Rows.Add(row);
                }
                return table;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
                return new DataTable();
            }
        }

        private IList<ArrayList> GetSectorByNunber()
        {
            try
            {
                IList<ArrayList> list = new List<ArrayList>();
                if (this.treeView1.Nodes.Count != 0)
                {
                    foreach (TreeNode node in this.treeView1.Nodes)
                    {
                        for (int i = 0; i < node.Nodes.Count; i++)
                        {
                            if (node.Nodes[i].Checked)
                            {
                                string sql = "select * from EquipmentCode where Nickname = @Nickname";
                                try
                                {
                                    string[] strArray = node.Nodes[i].Text.Split(new char[] { '(' });
                                    OleDbParameter[] values = new OleDbParameter[] { new OleDbParameter("@Nickname", strArray[0]) };
                                    DataTable dataSet = DBHelper.GetDataSet(sql, values);
                                    ArrayList item = new ArrayList();
                                    foreach (DataRow row in dataSet.Rows)
                                    {
                                        item.Add((int) row["Sector"]);
                                        item.Add((int) row["Block"]);
                                        item.Add((int) row["_byte"]);
                                        item.Add((int) row["_bit"]);
                                    }
                                    list.Add(item);
                                }
                                catch (Exception exception)
                                {
                                    Console.Write(exception.Message);
                                }
                            }
                        }
                    }
                }
                return list;
            }
            catch (Exception exception2)
            {
                MessageBox.Show(exception2.Message.ToString());
                Console.WriteLine(exception2.ToString());
                return new List<ArrayList>();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSerchSerial = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Family = new System.Windows.Forms.Button();
            this.btnsendcard1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.btnBlacklist = new System.Windows.Forms.Button();
            this.btnReadCard = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.gbxInformation = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxsex = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtAreaName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnreadCard1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtBuildingNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpenClose = new System.Windows.Forms.Button();
            this.cbxSerialport = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSentCard = new System.Windows.Forms.Button();
            this.btnNumber = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iC卡操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发卡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读卡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.安装USB驱动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发卡记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.黑名单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.权限管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备份数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还原数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.联系我们ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblRead = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pbarData = new DevExpress.XtraEditors.ProgressBarControl();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dgvExecute = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NoteID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoteName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoteSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoteArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoteBuild = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoteRoomNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoteCard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoteTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NotePosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoteInOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NotePass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoteRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.dgvAlarm = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAlmCard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlmTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlmLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlmRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NoteID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoteName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoteSex3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoteArea4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoteBuild5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoteRoomNum6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoteCard7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoteTime8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NotePosition9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoteInOut10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NotePass11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoteRemark12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OpenDoor_Button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.selCardNote = new System.Windows.Forms.Button();
            this.dateEnd = new DevExpress.XtraEditors.DateEdit();
            this.dataBegin = new DevExpress.XtraEditors.DateEdit();
            this.btnselalmred = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnserach = new System.Windows.Forms.Button();
            this.btnAddEqu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBeginRead = new System.Windows.Forms.Button();
            this.imgList = new DevExpress.XtraEditors.ImageListBoxControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.timeReceive = new System.Windows.Forms.Timer(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.权限管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.系统维护ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.备份数据库ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.还原数据库ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.数据清理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxInformation.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbarData.Properties)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExecute)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarm)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBegin.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // btnSerchSerial
            // 
            this.btnSerchSerial.Location = new System.Drawing.Point(29, 100);
            this.btnSerchSerial.Name = "btnSerchSerial";
            this.btnSerchSerial.Size = new System.Drawing.Size(110, 23);
            this.btnSerchSerial.TabIndex = 15;
            this.btnSerchSerial.Text = "自动检测设备";
            this.toolTip1.SetToolTip(this.btnSerchSerial, "检测是否有连接的设备");
            this.btnSerchSerial.UseVisualStyleBackColor = true;
            this.btnSerchSerial.Click += new System.EventHandler(this.btnSerchSerial_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(848, 512);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnSerchSerial);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnBlacklist);
            this.tabPage1.Controls.Add(this.btnReadCard);
            this.tabPage1.Controls.Add(this.btnSelect);
            this.tabPage1.Controls.Add(this.gbxInformation);
            this.tabPage1.Controls.Add(this.buttonOpenClose);
            this.tabPage1.Controls.Add(this.cbxSerialport);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Controls.Add(this.btnSentCard);
            this.tabPage1.Controls.Add(this.btnNumber);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(840, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " 发 卡 器";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "用户管理";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Family);
            this.groupBox1.Controls.Add(this.btnsendcard1);
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Controls.Add(this.chkSelectAll);
            this.groupBox1.Location = new System.Drawing.Point(176, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 422);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设备编码信息";
            // 
            // Family
            // 
            this.Family.Location = new System.Drawing.Point(148, 391);
            this.Family.Name = "Family";
            this.Family.Size = new System.Drawing.Size(137, 23);
            this.Family.TabIndex = 13;
            this.Family.Text = "延长有效期及家庭成员 ";
            this.Family.UseVisualStyleBackColor = true;
            this.Family.Visible = false;
            this.Family.Click += new System.EventHandler(this.Family_Click);
            // 
            // btnsendcard1
            // 
            this.btnsendcard1.Location = new System.Drawing.Point(66, 391);
            this.btnsendcard1.Name = "btnsendcard1";
            this.btnsendcard1.Size = new System.Drawing.Size(75, 23);
            this.btnsendcard1.TabIndex = 12;
            this.btnsendcard1.Text = "发  卡";
            this.btnsendcard1.UseVisualStyleBackColor = true;
            this.btnsendcard1.Visible = false;
            this.btnsendcard1.Click += new System.EventHandler(this.btnsendcard1_Click);
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(10, 17);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(275, 368);
            this.treeView1.TabIndex = 10;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(12, 395);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(48, 16);
            this.chkSelectAll.TabIndex = 7;
            this.chkSelectAll.Text = "全选";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.Click += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // btnBlacklist
            // 
            this.btnBlacklist.Location = new System.Drawing.Point(29, 405);
            this.btnBlacklist.Name = "btnBlacklist";
            this.btnBlacklist.Size = new System.Drawing.Size(110, 23);
            this.btnBlacklist.TabIndex = 25;
            this.btnBlacklist.Text = "住户管理";
            this.btnBlacklist.UseVisualStyleBackColor = true;
            this.btnBlacklist.Click += new System.EventHandler(this.btnBlacklist_Click);
            // 
            // btnReadCard
            // 
            this.btnReadCard.Location = new System.Drawing.Point(29, 283);
            this.btnReadCard.Name = "btnReadCard";
            this.btnReadCard.Size = new System.Drawing.Size(110, 23);
            this.btnReadCard.TabIndex = 23;
            this.btnReadCard.Text = "读  卡";
            this.btnReadCard.UseVisualStyleBackColor = true;
            this.btnReadCard.Click += new System.EventHandler(this.btnReadCard_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(29, 344);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(110, 23);
            this.btnSelect.TabIndex = 22;
            this.btnSelect.Text = "发卡记录";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // gbxInformation
            // 
            this.gbxInformation.Controls.Add(this.label14);
            this.gbxInformation.Controls.Add(this.comboBox1);
            this.gbxInformation.Controls.Add(this.dateTimePicker2);
            this.gbxInformation.Controls.Add(this.label10);
            this.gbxInformation.Controls.Add(this.txtRoomNumber);
            this.gbxInformation.Controls.Add(this.label9);
            this.gbxInformation.Controls.Add(this.cbxsex);
            this.gbxInformation.Controls.Add(this.label8);
            this.gbxInformation.Controls.Add(this.checkBox1);
            this.gbxInformation.Controls.Add(this.txtAreaName);
            this.gbxInformation.Controls.Add(this.label7);
            this.gbxInformation.Controls.Add(this.btnreadCard1);
            this.gbxInformation.Controls.Add(this.dateTimePicker1);
            this.gbxInformation.Controls.Add(this.checkBox2);
            this.gbxInformation.Controls.Add(this.label5);
            this.gbxInformation.Controls.Add(this.txtCardNumber);
            this.gbxInformation.Controls.Add(this.label6);
            this.gbxInformation.Controls.Add(this.txtCount);
            this.gbxInformation.Controls.Add(this.label4);
            this.gbxInformation.Controls.Add(this.txtRemarks);
            this.gbxInformation.Controls.Add(this.txtBuildingNo);
            this.gbxInformation.Controls.Add(this.txtName);
            this.gbxInformation.Controls.Add(this.label3);
            this.gbxInformation.Controls.Add(this.label2);
            this.gbxInformation.Controls.Add(this.label1);
            this.gbxInformation.Location = new System.Drawing.Point(497, 48);
            this.gbxInformation.Name = "gbxInformation";
            this.gbxInformation.Size = new System.Drawing.Size(244, 422);
            this.gbxInformation.TabIndex = 21;
            this.gbxInformation.TabStop = false;
            this.gbxInformation.Text = "基本信息";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 220);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 22;
            this.label14.Text = "时间段";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "无限制",
            "时间段1",
            "时间段2",
            "时间段3",
            "时间段4"});
            this.comboBox1.Location = new System.Drawing.Point(65, 217);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 20);
            this.comboBox1.TabIndex = 21;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(63, 282);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(151, 21);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "开始日期";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtRoomNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRoomNumber.Location = new System.Drawing.Point(65, 184);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(153, 21);
            this.txtRoomNumber.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "房  号";
            // 
            // cbxsex
            // 
            this.cbxsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxsex.FormattingEnabled = true;
            this.cbxsex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbxsex.Location = new System.Drawing.Point(65, 86);
            this.cbxsex.Name = "cbxsex";
            this.cbxsex.Size = new System.Drawing.Size(153, 20);
            this.cbxsex.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "性  别";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(222, 320);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtAreaName
            // 
            this.txtAreaName.Location = new System.Drawing.Point(65, 118);
            this.txtAreaName.Name = "txtAreaName";
            this.txtAreaName.Size = new System.Drawing.Size(153, 21);
            this.txtAreaName.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "小区名称";
            // 
            // btnreadCard1
            // 
            this.btnreadCard1.Location = new System.Drawing.Point(63, 391);
            this.btnreadCard1.Name = "btnreadCard1";
            this.btnreadCard1.Size = new System.Drawing.Size(75, 23);
            this.btnreadCard1.TabIndex = 12;
            this.btnreadCard1.Text = "读  卡";
            this.btnreadCard1.UseVisualStyleBackColor = true;
            this.btnreadCard1.Click += new System.EventHandler(this.btnreadCard1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(65, 315);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 21);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(222, 254);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkBox2_CheckedChanged);
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "结束日期";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Enabled = false;
            this.txtCardNumber.Location = new System.Drawing.Point(64, 20);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(153, 21);
            this.txtCardNumber.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "卡  号";
            // 
            // txtCount
            // 
            this.txtCount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCount.Location = new System.Drawing.Point(64, 249);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(153, 21);
            this.txtCount.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "次  数";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(65, 348);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(173, 35);
            this.txtRemarks.TabIndex = 11;
            this.txtRemarks.Visible = false;
            // 
            // txtBuildingNo
            // 
            this.txtBuildingNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBuildingNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBuildingNo.Location = new System.Drawing.Point(65, 151);
            this.txtBuildingNo.Name = "txtBuildingNo";
            this.txtBuildingNo.Size = new System.Drawing.Size(153, 21);
            this.txtBuildingNo.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(64, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 21);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "备  注";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "楼  号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓  名";
            // 
            // buttonOpenClose
            // 
            this.buttonOpenClose.Location = new System.Drawing.Point(29, 71);
            this.buttonOpenClose.Name = "buttonOpenClose";
            this.buttonOpenClose.Size = new System.Drawing.Size(50, 23);
            this.buttonOpenClose.TabIndex = 20;
            this.buttonOpenClose.Text = "打 开";
            this.buttonOpenClose.UseVisualStyleBackColor = true;
            this.buttonOpenClose.Visible = false;
            // 
            // cbxSerialport
            // 
            this.cbxSerialport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSerialport.FormattingEnabled = true;
            this.cbxSerialport.Location = new System.Drawing.Point(68, 51);
            this.cbxSerialport.Name = "cbxSerialport";
            this.cbxSerialport.Size = new System.Drawing.Size(71, 20);
            this.cbxSerialport.TabIndex = 19;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "串口号";
            // 
            // btnSentCard
            // 
            this.btnSentCard.Location = new System.Drawing.Point(29, 222);
            this.btnSentCard.Name = "btnSentCard";
            this.btnSentCard.Size = new System.Drawing.Size(110, 23);
            this.btnSentCard.TabIndex = 16;
            this.btnSentCard.Text = "发  卡";
            this.btnSentCard.UseVisualStyleBackColor = true;
            this.btnSentCard.Click += new System.EventHandler(this.btnSentCard_Click);
            // 
            // btnNumber
            // 
            this.btnNumber.Location = new System.Drawing.Point(29, 161);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(110, 23);
            this.btnNumber.TabIndex = 17;
            this.btnNumber.Text = "设备管理";
            this.btnNumber.UseVisualStyleBackColor = true;
            this.btnNumber.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iC卡操作ToolStripMenuItem,
            this.查询ToolStripMenuItem,
            this.权限管理ToolStripMenuItem,
            this.系统维护ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 25);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iC卡操作ToolStripMenuItem
            // 
            this.iC卡操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.发卡ToolStripMenuItem,
            this.读卡ToolStripMenuItem,
            this.安装USB驱动ToolStripMenuItem});
            this.iC卡操作ToolStripMenuItem.Name = "iC卡操作ToolStripMenuItem";
            this.iC卡操作ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.iC卡操作ToolStripMenuItem.Text = "操作";
            // 
            // 发卡ToolStripMenuItem
            // 
            this.发卡ToolStripMenuItem.Name = "发卡ToolStripMenuItem";
            this.发卡ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.发卡ToolStripMenuItem.Text = "发卡";
            this.发卡ToolStripMenuItem.Click += new System.EventHandler(this.发卡ToolStripMenuItem_Click);
            // 
            // 读卡ToolStripMenuItem
            // 
            this.读卡ToolStripMenuItem.Name = "读卡ToolStripMenuItem";
            this.读卡ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.读卡ToolStripMenuItem.Text = "读卡";
            this.读卡ToolStripMenuItem.Click += new System.EventHandler(this.读卡ToolStripMenuItem_Click);
            // 
            // 安装USB驱动ToolStripMenuItem
            // 
            this.安装USB驱动ToolStripMenuItem.Name = "安装USB驱动ToolStripMenuItem";
            this.安装USB驱动ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.安装USB驱动ToolStripMenuItem.Text = "安装USB驱动";
            this.安装USB驱动ToolStripMenuItem.Click += new System.EventHandler(this.安装USB驱动ToolStripMenuItem_Click);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.发卡记录ToolStripMenuItem,
            this.黑名单ToolStripMenuItem});
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.查询ToolStripMenuItem.Text = "查询";
            // 
            // 发卡记录ToolStripMenuItem
            // 
            this.发卡记录ToolStripMenuItem.Name = "发卡记录ToolStripMenuItem";
            this.发卡记录ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.发卡记录ToolStripMenuItem.Text = "发卡记录";
            this.发卡记录ToolStripMenuItem.Click += new System.EventHandler(this.发卡记录ToolStripMenuItem_Click);
            // 
            // 黑名单ToolStripMenuItem
            // 
            this.黑名单ToolStripMenuItem.Name = "黑名单ToolStripMenuItem";
            this.黑名单ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.黑名单ToolStripMenuItem.Text = "住户管理";
            this.黑名单ToolStripMenuItem.Click += new System.EventHandler(this.黑名单ToolStripMenuItem_Click);
            // 
            // 权限管理ToolStripMenuItem
            // 
            this.权限管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem});
            this.权限管理ToolStripMenuItem.Name = "权限管理ToolStripMenuItem";
            this.权限管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.权限管理ToolStripMenuItem.Text = "权限管理";
            this.权限管理ToolStripMenuItem.Visible = false;
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            this.用户管理ToolStripMenuItem.Click += new System.EventHandler(this.用户管理ToolStripMenuItem_Click);
            // 
            // 系统维护ToolStripMenuItem
            // 
            this.系统维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.备份数据库ToolStripMenuItem,
            this.还原数据库ToolStripMenuItem});
            this.系统维护ToolStripMenuItem.Name = "系统维护ToolStripMenuItem";
            this.系统维护ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统维护ToolStripMenuItem.Text = "系统维护";
            this.系统维护ToolStripMenuItem.Visible = false;
            // 
            // 备份数据库ToolStripMenuItem
            // 
            this.备份数据库ToolStripMenuItem.Name = "备份数据库ToolStripMenuItem";
            this.备份数据库ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.备份数据库ToolStripMenuItem.Text = "备份数据库";
            this.备份数据库ToolStripMenuItem.Click += new System.EventHandler(this.备份数据库ToolStripMenuItem_Click);
            // 
            // 还原数据库ToolStripMenuItem
            // 
            this.还原数据库ToolStripMenuItem.Name = "还原数据库ToolStripMenuItem";
            this.还原数据库ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.还原数据库ToolStripMenuItem.Text = "还原数据库";
            this.还原数据库ToolStripMenuItem.Click += new System.EventHandler(this.还原数据库ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.联系我们ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "帮助";
            this.关于ToolStripMenuItem.Visible = false;
            // 
            // 联系我们ToolStripMenuItem
            // 
            this.联系我们ToolStripMenuItem.Name = "联系我们ToolStripMenuItem";
            this.联系我们ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.联系我们ToolStripMenuItem.Text = "关于";
            this.联系我们ToolStripMenuItem.Click += new System.EventHandler(this.联系我们ToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.pbarData);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.imgList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(840, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " 门 禁";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.lblRecords);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblRead);
            this.panel2.Controls.Add(this.lblSum);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(3, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 30);
            this.panel2.TabIndex = 14;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Tomato;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(4, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(148, 14);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "一次最多只能采2600条记录";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Location = new System.Drawing.Point(179, 11);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(0, 12);
            this.lblRecords.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(631, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "进度：";
            // 
            // lblRead
            // 
            this.lblRead.AutoSize = true;
            this.lblRead.Location = new System.Drawing.Point(453, 11);
            this.lblRead.Name = "lblRead";
            this.lblRead.Size = new System.Drawing.Size(11, 12);
            this.lblRead.TabIndex = 3;
            this.lblRead.Text = "0";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSum.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblSum.Location = new System.Drawing.Point(678, 8);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(16, 15);
            this.lblSum.TabIndex = 1;
            this.lblSum.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(367, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "已采集到：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(133, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "总记录：";
            this.label13.Visible = false;
            // 
            // pbarData
            // 
            this.pbarData.Location = new System.Drawing.Point(0, 164);
            this.pbarData.Name = "pbarData";
            this.pbarData.Size = new System.Drawing.Size(839, 36);
            this.pbarData.TabIndex = 13;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(0, 202);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(843, 281);
            this.tabControl2.TabIndex = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gridControl1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(835, 255);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "实时监控";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(3, 0);
            this.gridControl1.MainView = this.dgvExecute;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(832, 287);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvExecute});
            // 
            // dgvExecute
            // 
            this.dgvExecute.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NoteID,
            this.NoteName,
            this.NoteSex,
            this.NoteArea,
            this.NoteBuild,
            this.NoteRoomNum,
            this.NoteCard,
            this.NoteTime,
            this.NotePosition,
            this.NoteInOut,
            this.NotePass,
            this.NoteRemark});
            this.dgvExecute.GridControl = this.gridControl1;
            this.dgvExecute.Name = "dgvExecute";
            // 
            // NoteID
            // 
            this.NoteID.Caption = "NoteID";
            this.NoteID.FieldName = "NoteID";
            this.NoteID.Name = "NoteID";
            // 
            // NoteName
            // 
            this.NoteName.Caption = "姓名";
            this.NoteName.FieldName = "NoteName";
            this.NoteName.Name = "NoteName";
            this.NoteName.Visible = true;
            this.NoteName.VisibleIndex = 0;
            // 
            // NoteSex
            // 
            this.NoteSex.Caption = "性别";
            this.NoteSex.FieldName = "NoteSex";
            this.NoteSex.Name = "NoteSex";
            this.NoteSex.Visible = true;
            this.NoteSex.VisibleIndex = 1;
            // 
            // NoteArea
            // 
            this.NoteArea.Caption = "小区";
            this.NoteArea.FieldName = "NoteArea";
            this.NoteArea.Name = "NoteArea";
            this.NoteArea.Visible = true;
            this.NoteArea.VisibleIndex = 2;
            // 
            // NoteBuild
            // 
            this.NoteBuild.Caption = "楼号";
            this.NoteBuild.FieldName = "NoteBuild";
            this.NoteBuild.Name = "NoteBuild";
            this.NoteBuild.Visible = true;
            this.NoteBuild.VisibleIndex = 3;
            // 
            // NoteRoomNum
            // 
            this.NoteRoomNum.Caption = "房号";
            this.NoteRoomNum.FieldName = "NoteRoomNum";
            this.NoteRoomNum.Name = "NoteRoomNum";
            this.NoteRoomNum.Visible = true;
            this.NoteRoomNum.VisibleIndex = 4;
            // 
            // NoteCard
            // 
            this.NoteCard.Caption = "卡号";
            this.NoteCard.FieldName = "NoteCard";
            this.NoteCard.Name = "NoteCard";
            this.NoteCard.Visible = true;
            this.NoteCard.VisibleIndex = 5;
            // 
            // NoteTime
            // 
            this.NoteTime.Caption = "刷卡时间";
            this.NoteTime.FieldName = "NoteTime";
            this.NoteTime.Name = "NoteTime";
            this.NoteTime.Visible = true;
            this.NoteTime.VisibleIndex = 6;
            // 
            // NotePosition
            // 
            this.NotePosition.Caption = "门名称";
            this.NotePosition.FieldName = "NotePosition";
            this.NotePosition.Name = "NotePosition";
            this.NotePosition.Visible = true;
            this.NotePosition.VisibleIndex = 7;
            // 
            // NoteInOut
            // 
            this.NoteInOut.Caption = "进出";
            this.NoteInOut.FieldName = "NoteInOut";
            this.NoteInOut.Name = "NoteInOut";
            this.NoteInOut.Visible = true;
            this.NoteInOut.VisibleIndex = 8;
            // 
            // NotePass
            // 
            this.NotePass.Caption = "通过状态";
            this.NotePass.FieldName = "NotePass";
            this.NotePass.Name = "NotePass";
            this.NotePass.Visible = true;
            this.NotePass.VisibleIndex = 9;
            // 
            // NoteRemark
            // 
            this.NoteRemark.Caption = "备注";
            this.NoteRemark.FieldName = "NoteRemark";
            this.NoteRemark.Name = "NoteRemark";
            this.NoteRemark.Visible = true;
            this.NoteRemark.VisibleIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gridControl3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(835, 255);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "报警记录";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gridControl3
            // 
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.EmbeddedNavigator.Name = "";
            this.gridControl3.Location = new System.Drawing.Point(3, 3);
            this.gridControl3.MainView = this.dgvAlarm;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(829, 249);
            this.gridControl3.TabIndex = 2;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvAlarm});
            // 
            // dgvAlarm
            // 
            this.dgvAlarm.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAlmCard,
            this.colAlmTime,
            this.colAlmLocation,
            this.colAlmRemark});
            this.dgvAlarm.GridControl = this.gridControl3;
            this.dgvAlarm.Name = "dgvAlarm";
            this.dgvAlarm.OptionsBehavior.Editable = false;
            this.dgvAlarm.OptionsView.ShowGroupPanel = false;
            // 
            // colAlmCard
            // 
            this.colAlmCard.Caption = "卡号";
            this.colAlmCard.FieldName = "AlmCard";
            this.colAlmCard.Name = "colAlmCard";
            this.colAlmCard.Visible = true;
            this.colAlmCard.VisibleIndex = 0;
            // 
            // colAlmTime
            // 
            this.colAlmTime.Caption = "时间";
            this.colAlmTime.FieldName = "AlmTime";
            this.colAlmTime.Name = "colAlmTime";
            this.colAlmTime.Visible = true;
            this.colAlmTime.VisibleIndex = 1;
            // 
            // colAlmLocation
            // 
            this.colAlmLocation.Caption = "门名称";
            this.colAlmLocation.FieldName = "AlmLocation";
            this.colAlmLocation.Name = "colAlmLocation";
            this.colAlmLocation.Visible = true;
            this.colAlmLocation.VisibleIndex = 2;
            // 
            // colAlmRemark
            // 
            this.colAlmRemark.Caption = "报警原因";
            this.colAlmRemark.FieldName = "AlmRemark";
            this.colAlmRemark.Name = "colAlmRemark";
            this.colAlmRemark.Visible = true;
            this.colAlmRemark.VisibleIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.gridControl2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(835, 255);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "刷卡记录";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.EmbeddedNavigator.Name = "";
            this.gridControl2.Location = new System.Drawing.Point(3, 3);
            this.gridControl2.MainView = this.gridView1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(829, 249);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NoteID1,
            this.NoteName2,
            this.NoteSex3,
            this.NoteArea4,
            this.NoteBuild5,
            this.NoteRoomNum6,
            this.NoteCard7,
            this.NoteTime8,
            this.NotePosition9,
            this.NoteInOut10,
            this.NotePass11,
            this.NoteRemark12});
            this.gridView1.GridControl = this.gridControl2;
            this.gridView1.Name = "gridView1";
            // 
            // NoteID1
            // 
            this.NoteID1.Caption = "NoteID1";
            this.NoteID1.FieldName = "NoteID";
            this.NoteID1.Name = "NoteID1";
            // 
            // NoteName2
            // 
            this.NoteName2.Caption = "姓名";
            this.NoteName2.FieldName = "NoteName";
            this.NoteName2.Name = "NoteName2";
            this.NoteName2.Visible = true;
            this.NoteName2.VisibleIndex = 0;
            // 
            // NoteSex3
            // 
            this.NoteSex3.Caption = "性别";
            this.NoteSex3.FieldName = "NoteSex";
            this.NoteSex3.Name = "NoteSex3";
            this.NoteSex3.Visible = true;
            this.NoteSex3.VisibleIndex = 1;
            // 
            // NoteArea4
            // 
            this.NoteArea4.Caption = "小区";
            this.NoteArea4.FieldName = "NoteArea";
            this.NoteArea4.Name = "NoteArea4";
            this.NoteArea4.Visible = true;
            this.NoteArea4.VisibleIndex = 2;
            // 
            // NoteBuild5
            // 
            this.NoteBuild5.Caption = "楼号";
            this.NoteBuild5.FieldName = "NoteBuild";
            this.NoteBuild5.Name = "NoteBuild5";
            this.NoteBuild5.Visible = true;
            this.NoteBuild5.VisibleIndex = 3;
            // 
            // NoteRoomNum6
            // 
            this.NoteRoomNum6.Caption = "房号";
            this.NoteRoomNum6.FieldName = "NoteRoomNum";
            this.NoteRoomNum6.Name = "NoteRoomNum6";
            this.NoteRoomNum6.Visible = true;
            this.NoteRoomNum6.VisibleIndex = 4;
            // 
            // NoteCard7
            // 
            this.NoteCard7.Caption = "卡号";
            this.NoteCard7.FieldName = "NoteCard";
            this.NoteCard7.Name = "NoteCard7";
            this.NoteCard7.Visible = true;
            this.NoteCard7.VisibleIndex = 5;
            // 
            // NoteTime8
            // 
            this.NoteTime8.Caption = "刷卡时间";
            this.NoteTime8.FieldName = "NoteTime";
            this.NoteTime8.Name = "NoteTime8";
            this.NoteTime8.Visible = true;
            this.NoteTime8.VisibleIndex = 6;
            // 
            // NotePosition9
            // 
            this.NotePosition9.Caption = "门名称";
            this.NotePosition9.FieldName = "NotePosition";
            this.NotePosition9.Name = "NotePosition9";
            this.NotePosition9.Visible = true;
            this.NotePosition9.VisibleIndex = 7;
            // 
            // NoteInOut10
            // 
            this.NoteInOut10.Caption = "进出";
            this.NoteInOut10.FieldName = "NoteInOut";
            this.NoteInOut10.Name = "NoteInOut10";
            this.NoteInOut10.Visible = true;
            this.NoteInOut10.VisibleIndex = 8;
            // 
            // NotePass11
            // 
            this.NotePass11.Caption = "通过状态";
            this.NotePass11.FieldName = "NotePass";
            this.NotePass11.Name = "NotePass11";
            this.NotePass11.Visible = true;
            this.NotePass11.VisibleIndex = 9;
            // 
            // NoteRemark12
            // 
            this.NoteRemark12.Caption = "备注";
            this.NoteRemark12.FieldName = "NoteRemark";
            this.NoteRemark12.Name = "NoteRemark12";
            this.NoteRemark12.Visible = true;
            this.NoteRemark12.VisibleIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OpenDoor_Button);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.selCardNote);
            this.panel1.Controls.Add(this.dateEnd);
            this.panel1.Controls.Add(this.dataBegin);
            this.panel1.Controls.Add(this.btnselalmred);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnserach);
            this.panel1.Controls.Add(this.btnAddEqu);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnBeginRead);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 39);
            this.panel1.TabIndex = 7;
            // 
            // OpenDoor_Button
            // 
            this.OpenDoor_Button.Location = new System.Drawing.Point(67, 7);
            this.OpenDoor_Button.Name = "OpenDoor_Button";
            this.OpenDoor_Button.Size = new System.Drawing.Size(61, 23);
            this.OpenDoor_Button.TabIndex = 29;
            this.OpenDoor_Button.Text = "远程开门";
            this.OpenDoor_Button.UseVisualStyleBackColor = true;
            this.OpenDoor_Button.Click += new System.EventHandler(this.btnserach_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(383, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "时间段";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(434, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 14);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "选择日期:";
            // 
            // selCardNote
            // 
            this.selCardNote.Location = new System.Drawing.Point(664, 7);
            this.selCardNote.Name = "selCardNote";
            this.selCardNote.Size = new System.Drawing.Size(85, 23);
            this.selCardNote.TabIndex = 26;
            this.selCardNote.Text = "查询刷卡记录";
            this.selCardNote.UseVisualStyleBackColor = true;
            this.selCardNote.Click += new System.EventHandler(this.selCardNote_Click);
            // 
            // dateEnd
            // 
            this.dateEnd.EditValue = null;
            this.dateEnd.Location = new System.Drawing.Point(577, 8);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEnd.Size = new System.Drawing.Size(85, 21);
            this.dateEnd.TabIndex = 25;
            // 
            // dataBegin
            // 
            this.dataBegin.EditValue = null;
            this.dataBegin.Location = new System.Drawing.Point(488, 8);
            this.dataBegin.Name = "dataBegin";
            this.dataBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataBegin.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dataBegin.Size = new System.Drawing.Size(85, 21);
            this.dataBegin.TabIndex = 24;
            // 
            // btnselalmred
            // 
            this.btnselalmred.Location = new System.Drawing.Point(750, 7);
            this.btnselalmred.Name = "btnselalmred";
            this.btnselalmred.Size = new System.Drawing.Size(85, 23);
            this.btnselalmred.TabIndex = 23;
            this.btnselalmred.Text = "查询报警记录";
            this.btnselalmred.UseVisualStyleBackColor = true;
            this.btnselalmred.Click += new System.EventHandler(this.btnselalmred_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(192, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "停止监控";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnserach
            // 
            this.btnserach.Location = new System.Drawing.Point(320, 7);
            this.btnserach.Name = "btnserach";
            this.btnserach.Size = new System.Drawing.Size(61, 23);
            this.btnserach.TabIndex = 21;
            this.btnserach.Text = "检测设备";
            this.btnserach.UseVisualStyleBackColor = true;
            this.btnserach.Click += new System.EventHandler(this.btnserach_Click);
            // 
            // btnAddEqu
            // 
            this.btnAddEqu.Location = new System.Drawing.Point(4, 7);
            this.btnAddEqu.Name = "btnAddEqu";
            this.btnAddEqu.Size = new System.Drawing.Size(61, 23);
            this.btnAddEqu.TabIndex = 2;
            this.btnAddEqu.Text = "添加设备";
            this.btnAddEqu.UseVisualStyleBackColor = true;
            this.btnAddEqu.Click += new System.EventHandler(this.btnAddEqu_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "实时监控";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBeginRead
            // 
            this.btnBeginRead.Location = new System.Drawing.Point(256, 7);
            this.btnBeginRead.Name = "btnBeginRead";
            this.btnBeginRead.Size = new System.Drawing.Size(61, 23);
            this.btnBeginRead.TabIndex = 0;
            this.btnBeginRead.Text = "采集记录";
            this.btnBeginRead.UseVisualStyleBackColor = true;
            this.btnBeginRead.Click += new System.EventHandler(this.btnBeginRead_Click);
            // 
            // imgList
            // 
            this.imgList.ImageList = this.imageCollection1;
            this.imgList.Location = new System.Drawing.Point(3, 41);
            this.imgList.MultiColumn = true;
            this.imgList.Name = "imgList";
            this.imgList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.imgList.Size = new System.Drawing.Size(836, 88);
            this.imgList.TabIndex = 6;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            // 
            // timeReceive
            // 
            this.timeReceive.Tick += new System.EventHandler(this.timeReceive_Tick);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Black";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.权限管理ToolStripMenuItem1,
            this.系统维护ToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(848, 25);
            this.menuStrip2.TabIndex = 16;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 权限管理ToolStripMenuItem1
            // 
            this.权限管理ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem1});
            this.权限管理ToolStripMenuItem1.Name = "权限管理ToolStripMenuItem1";
            this.权限管理ToolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.权限管理ToolStripMenuItem1.Text = "权限管理";
            // 
            // 用户管理ToolStripMenuItem1
            // 
            this.用户管理ToolStripMenuItem1.Name = "用户管理ToolStripMenuItem1";
            this.用户管理ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.用户管理ToolStripMenuItem1.Text = "用户管理";
            this.用户管理ToolStripMenuItem1.Click += new System.EventHandler(this.用户管理ToolStripMenuItem1_Click);
            // 
            // 系统维护ToolStripMenuItem1
            // 
            this.系统维护ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.备份数据库ToolStripMenuItem1,
            this.还原数据库ToolStripMenuItem1,
            this.数据清理ToolStripMenuItem});
            this.系统维护ToolStripMenuItem1.Name = "系统维护ToolStripMenuItem1";
            this.系统维护ToolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.系统维护ToolStripMenuItem1.Text = "系统维护";
            // 
            // 备份数据库ToolStripMenuItem1
            // 
            this.备份数据库ToolStripMenuItem1.Name = "备份数据库ToolStripMenuItem1";
            this.备份数据库ToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.备份数据库ToolStripMenuItem1.Text = "备份数据库";
            this.备份数据库ToolStripMenuItem1.Click += new System.EventHandler(this.备份数据库ToolStripMenuItem1_Click);
            // 
            // 还原数据库ToolStripMenuItem1
            // 
            this.还原数据库ToolStripMenuItem1.Name = "还原数据库ToolStripMenuItem1";
            this.还原数据库ToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.还原数据库ToolStripMenuItem1.Text = "还原数据库";
            this.还原数据库ToolStripMenuItem1.Click += new System.EventHandler(this.还原数据库ToolStripMenuItem1_Click);
            // 
            // 数据清理ToolStripMenuItem
            // 
            this.数据清理ToolStripMenuItem.Name = "数据清理ToolStripMenuItem";
            this.数据清理ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.数据清理ToolStripMenuItem.Text = "数据清理";
            this.数据清理ToolStripMenuItem.Click += new System.EventHandler(this.数据清理ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 537);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "智能门禁脱机管理系统-用户版V1.71";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxInformation.ResumeLayout(false);
            this.gbxInformation.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbarData.Properties)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExecute)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarm)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBegin.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public static ArrayList IntoByte(int number, string blockNumber)
        {
            try
            {
                MatchCollection matchs;
                ArrayList list = new ArrayList();
                if (number > 15)
                {
                    matchs = Regex.Matches(blockNumber, @"\S\S", RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);
                }
                else
                {
                    matchs = Regex.Matches("0" + blockNumber, @"\S\S", RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);
                }
                list.Add(Convert.ToByte(matchs[0].ToString(), 0x10));
                return list;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
                return new ArrayList();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        public void load()
        {
            try
            {
                int count = GetDataTable().Rows.Count;
                this.treeView1.Nodes.Clear();
                string safeSql = "select * from Groups order by GroupID desc ";
                DataTable dataSet = DBHelper.GetDataSet(safeSql);
                foreach (DataRow row in dataSet.Rows)
                {
                    this.treeView1.Nodes.Add((string) row["GroupName"]);
                }
                DataTable table3 = DBHelper.GetDataSet(string.Format("select * from EquipmentCode where EquipmentCode Between 0 and {0} ", count));
                foreach (DataRow row in table3.Rows)
                {
                    for (int j = 0; j < dataSet.Rows.Count; j++)
                    {
                        if (this.treeView1.Nodes[j].Text.Equals((string) row["_Groups"]))
                        {
                            this.treeView1.Nodes[j].Nodes.Add(((string) row["Nickname"]) + "(设备编码:" + row["EquipmentCode"].ToString() + ")");
                        }
                    }
                }
                for (int i = 0; i < this.treeView1.Nodes.Count; i++)
                {
                    if ((i != (this.treeView1.Nodes.Count - 1)) || (this.treeView1.Nodes.Count == 1))
                    {
                        this.treeView1.Nodes[i].Expand();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        public void LoadDefaultpassored(int lnghex1)
        {
            try
            {
                byte[] buffer = new byte[] { 0xbd, 6, 0xcb, 0, 0, 0, 0, 0, 0 };
                string blockNumber = Convert.ToString(lnghex1, 0x10);
                ArrayList list = IntoByte(lnghex1, blockNumber);
                buffer[7] = (byte) list[0];
                byte num = 0;
                for (int i = 0; i < 8; i++)
                {
                    num = (byte) (num + buffer[i]);
                }
                buffer[8] = num;
                comm.DiscardInBuffer();
                comm.Write(buffer, 0, 9);
                for (int j = 0; j < 3; j++)
                {
                    try
                    {
                        int count = this.Receive();
                        if (count == 7)
                        {
                            byte[] buffer2 = new byte[count];
                            comm.Read(buffer2, 0, count);
                            if ((buffer2[0] == 0xbd) && (buffer2[1] == 4))
                            {
                                byte num5 = 0;
                                for (int k = 0; k < 6; k++)
                                {
                                    num5 = (byte) (num5 + buffer2[k]);
                                }
                                if (num5 != buffer2[6])
                                {
                                }
                                if (buffer2[5] != 0)
                                {
                                    MessageBox.Show("初始密码失败");
                                }
                                return;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    if (j == 3)
                    {
                        MessageBox.Show("接收数据失败！", "提示", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        public int LoadEquipmentPasswrod(int sector)
        {
            try
            {
                byte[] buffer = new byte[] { 0xbd, 6, 0xca, 0, 0, 0, 0, 0, 0 };
                string blockNumber = Convert.ToString(sector, 0x10);
                ArrayList list = IntoByte(sector, blockNumber);
                buffer[7] = (byte) list[0];
                byte num = 0;
                int index = 0;
                while (index < 8)
                {
                    num = (byte) (num + buffer[index]);
                    index++;
                }
                buffer[8] = num;
                comm.DiscardInBuffer();
                comm.Write(buffer, 0, 9);
                int num3 = 0;
                for (int i = 0; i < 3; i++)
                {
                    try
                    {
                        int count = this.Receive();
                        if (count == 7)
                        {
                            byte[] buffer2 = new byte[count];
                            comm.Read(buffer2, 0, count);
                            if ((buffer2[0] == 0xbd) && (buffer2[1] == 4))
                            {
                                byte num6 = 0;
                                for (index = 0; index < 6; index++)
                                {
                                    num6 = (byte) (num6 + buffer2[index]);
                                }
                                if (num6 != buffer2[6])
                                {
                                    MessageBox.Show("接收数据不完整");
                                    num3 = 0;
                                }
                                if (buffer2[5] == 0)
                                {
                                    num3 = 1;
                                }
                                else
                                {
                                    num3 = 0;
                                }
                                break;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    if (i == 3)
                    {
                        MessageBox.Show("接收数据失败！", "提示", MessageBoxButtons.OK);
                        num3 = 0;
                    }
                }
                return num3;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
                return 0;
            }
        }

        public void multi_comm_send_thread_func()
        {
            try
            {
                int num;
                bool flag2;
                byte num2 = 0;
                byte[] buf = new byte[20];
                byte[] buffer2 = new byte[20];
                int nlen = 0;
                goto Label_02AE;
            Label_001C:
                num = 0;
                while (num < this.nAddrMonitoring)
                {
                    rxd_call_back _back;
                    if (this.flag == 1)
                    {
                        this.threadMonitoring.Join(0xbb8);
                    }
                    buf[0] = 0xbd;
                    buf[1] = 7;
                    buf[2] = 1;
                    buf[3] = 0;
                    buf[4] = 0;
                    this.strAddMonitoring[num] = this.strAddMonitoring[num].PadLeft(4, '0');
                    buf[5] = this.opAndvalidate.DexToHex(this.strAddMonitoring[num].Substring(0, 2));
                    buf[6] = this.opAndvalidate.DexToHex(this.strAddMonitoring[num].Substring(2, 2));
                    buf[7] = this.byAddrCount[num];
                    buf[8] = 2;
                    num2 = 0;
                    int index = 0;
                    while (index < 9)
                    {
                        num2 = (byte) (num2 + buf[index]);
                        index++;
                    }
                    buf[9] = num2;
                    this.opComm.SendData(buf, 10);
                    nlen = this.opComm.Receive2(this.sysTime, 0xbb8);
                    bool flag = false;
                    if (nlen >= 7)
                    {
                        this.nPtr = this.nMoniPtr[num];
                        this.nMonitoring = num;
                        buffer2 = this.opComm.ReadData(nlen);
                        if (buffer2 == null)
                        {
                            buffer2 = new byte[20];
                        }
                        if ((buffer2[1] + 3) == nlen)
                        {
                            num2 = 0;
                            for (index = 0; index < (buffer2[1] + 2); index++)
                            {
                                num2 = (byte) (num2 + buffer2[index]);
                            }
                            if (num2 == buffer2[buffer2[1] + 2])
                            {
                                flag = true;
                                if (nlen > 7)
                                {
                                    this.nReadLen = nlen;
                                    this.byReadbuf = buffer2;
                                    this.strPositionMonitoring = this.strPosition[num];
                                    _back = new rxd_call_back(this.RecSucc);
                                    try
                                    {
                                        base.Invoke(_back);
                                    }
                                    catch (Exception)
                                    {
                                    }
                                }
                                else if ((nlen == 7) && (this.flag1 < this.nAddrMonitoring))
                                {
                                    if (buffer2[5] != 0)
                                    {
                                        this.flag = 1;
                                    }
                                    this.flag1++;
                                }
                            }
                        }
                    }
                    if (!flag)
                    {
                        this.nPtr = this.nMoniPtr[num];
                        _back = new rxd_call_back(this.RevShow);
                        try
                        {
                            base.Invoke(_back);
                        }
                        catch
                        {
                        }
                    }
                    Thread.Sleep(600);
                    num++;
                }
            Label_02AE:
                flag2 = true;
                goto Label_001C;
            }
            catch (Exception exception2)
            {
                if (exception2.Message != "正在终止线程。")
                {
                    Console.WriteLine(exception2.ToString());
                }
            }
        }

        [DllImport("KADCOMDoor.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
        public static extern int Open_BaudRatePort(int PortIndex, int BaudRate);
        [DllImport("KADCOMDoor.dll", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Ansi)]
        public static extern int OpenDoor(int PortIndex, short DeviceAddress, short DoorNumber);
        private void OpenSerialPort()
        {
            try
            {
                if (!comm.IsOpen)
                {
                    comm.PortName = this.cbxSerialport.Text;
                    comm.BaudRate = 0x2580;
                    try
                    {
                        comm.Open();
                    }
                    catch (Exception exception)
                    {
                        comm = new SerialPort();
                        MessageBox.Show(exception.Message);
                    }
                }
            }
            catch (Exception exception2)
            {
                MessageBox.Show(exception2.Message.ToString());
                Console.WriteLine(exception2.ToString());
            }
        }

        private void ReadData(string cmd)
        {
            try
            {
                int num4;
                byte num = 0;
                byte[] buf = new byte[20];
                byte[] buffer2 = new byte[20];
                string[] strArray = new string[this.nToltal];
                string[] strArray2 = new string[this.nToltal];
                string[] strArray3 = new string[this.imgList.SelectedItems.Count];
                string[] strArray4 = new string[this.imgList.SelectedItems.Count];
                byte[] buffer3 = new byte[this.imgList.SelectedItems.Count];
                string str3 = "检测不到设备";
                if ((cmd != "Detection") && (cmd == "Records"))
                {
                    this.strEquCmd = "读取刷卡记录";
                }
                int index = 0;
                while (index < this.imgList.SelectedItems.Count)
                {
                    strArray[index] = this.imgList.SelectedItems[index].ToString();
                    num4 = 0;
                    while (num4 < this.nToltal)
                    {
                        if (strArray[index] == this.strLocation[num4])
                        {
                            strArray2[index] = this.strAddress[num4];
                            strArray3[index] = this.strLocation[num4];
                            strArray4[index] = this.strAddCount[num4];
                            if (this.strAddCount[num4] == "1号门")
                            {
                                buffer3[index] = 1;
                            }
                            else if (this.strAddCount[num4] == "2号门")
                            {
                                buffer3[index] = 2;
                            }
                            else if (this.strAddCount[num4] == "3号门")
                            {
                                buffer3[index] = 3;
                            }
                            else if (this.strAddCount[num4] == "4号门")
                            {
                                buffer3[index] = 4;
                            }
                            break;
                        }
                        num4++;
                    }
                    index++;
                }
                if (!this.opComm.OpenComm())
                {
                    MessageBox.Show("没发现此串口或串口已经在使用", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (this.imgList.SelectedItems.Count == 0)
                {
                    MessageBox.Show("请选择设备", "提示", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    for (index = 0; index < this.imgList.SelectedItems.Count; index++)
                    {
                        buf[0] = 0xbd;
                        if (cmd == "Detection")
                        {
                            buf[1] = 5;
                            buf[2] = 0x12;
                        }
                        else if (cmd == "Records")
                        {
                            this.lblRead.Text = "0条";
                            buf[1] = 7;
                            buf[2] = 0x18;
                            buf[7] = buffer3[index];
                            buf[8] = 1;
                        }
                        buf[3] = 0;
                        buf[4] = 0;
                        strArray2[index] = strArray2[index].PadLeft(4, '0');
                        buf[5] = this.opAndvalidate.DexToHex(strArray2[index].Substring(0, 2));
                        buf[6] = this.opAndvalidate.DexToHex(strArray2[index].Substring(2, 2));
                        num = 0;
                        if (cmd == "Detection")
                        {
                            num4 = 0;
                            while (num4 <= 6)
                            {
                                num = (byte) (num + buf[num4]);
                                num4++;
                            }
                            buf[7] = num;
                            this.opComm.SendData(buf, 8);
                        }
                        else if (cmd == "Records")
                        {
                            num4 = 0;
                            while (num4 <= 8)
                            {
                                num = (byte) (num + buf[num4]);
                                num4++;
                            }
                            buf[9] = num;
                            this.opComm.SendData(buf, 10);
                        }
                        int nlen = this.opComm.Receive(this.timeReceive, 0x7d0);
                        if (nlen >= 7)
                        {
                            buffer2 = this.opComm.ReadData(nlen);
                            num = 0;
                            for (num4 = 0; num4 <= (nlen - 2); num4++)
                            {
                                num = (byte) (num + buffer2[num4]);
                            }
                            if ((num == buffer2[nlen - 1]) && ((buffer2[0] == 0xbd) && (buffer2[2] == 0)))
                            {
                                if (cmd == "Detection")
                                {
                                    string str4 = Convert.ToString(buffer2[5], 0x10);
                                    str4 = "V" + str4.Substring(0, 1) + "." + str4.Substring(1, 1);
                                    str3 = "设备运行正常，版本为" + str4;
                                }
                                else if (cmd == "Records")
                                {
                                    this.logRecord = (((buffer2[5] << 0x18) + (buffer2[6] << 0x10)) + (buffer2[7] << 8)) + buffer2[8];
                                    this.databuffer = new byte[this.logRecord];
                                    this.nRecordTotal = (buffer2[10] << 8) + buffer2[11];
                                    byte[] byAddr = new byte[] { buf[5], buf[6], buf[7] };
                                    this.byValid = buffer2[9];
                                    this.strEquAddress = strArray2[index];
                                    this.strEquPosition = strArray3[index];
                                    this.strEquCount = strArray4[index];
                                    if (this.ReadRecords(byAddr))
                                    {
                                        str3 = "成功读取记录" + Convert.ToString(this.nReadRecords) + "条，并删除设备数据";
                                    }
                                    else
                                    {
                                        str3 = "读取失败";
                                        this.flagreadcount = 0;
                                    }
                                }
                            }
                        }
                        else
                        {
                            str3 = "检测不到设备";
                            this.flagreadcount = 0;
                            MessageBox.Show("该版本不技能此功能或设备没有正常连接");
                        }
                        string str = DateTime.Now.ToLongTimeString();
                    }
                    if (this.flagreadcount == 200)
                    {
                        this.btnBeginRead_Click(null, null);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void readFalse()
        {
            try
            {
                this.btnReadCard.Enabled = false;
                this.btnReadCard.Text = "正在读卡......";
                this.btnreadCard1.Enabled = false;
                this.btnreadCard1.Text = "正在读卡.....";
                this.读卡ToolStripMenuItem.Enabled = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private bool ReadRecords(byte[] byAddr)
        {
            try
            {
                string str13;
                int num9;
                string str14;
                byte num = 0;
                byte[] buf = new byte[50];
                byte[] buffer2 = new byte[150];
                byte[] buffer3 = new byte[this.logRecord + 130L];
                string str = "";
                string str2 = "";
                string str3 = "";
                string str4 = "";
                string str5 = "";
                string str6 = "";
                string str7 = "";
                string str8 = "";
                string str9 = "";
                string str10 = "";
                string str12 = "";
                for (long i = 0L; i < this.logRecord; i += 1L)
                {
                    buffer3[(int) ((IntPtr) i)] = 0xff;
                }
                buf[0] = 0xbd;
                buf[1] = 9;
                buf[2] = 0x18;
                buf[3] = 0;
                buf[4] = 0;
                buf[5] = byAddr[0];
                buf[6] = byAddr[1];
                buf[7] = byAddr[2];
                buf[8] = 2;
                int num8 = ((int) this.logRecord) / this.byValid;
                if (((ulong)this.logRecord % ((ulong) this.byValid)) != 0L)
                {
                    num8++;
                }
                this.flagreadcount = num8;
                this.pbarData.Properties.Minimum = 0;
                this.pbarData.Position = 0;
                this.pbarData.Properties.Maximum = num8;
                this.pbarData.Properties.Step = 1;
                this.pbarData.Properties.ProgressViewStyle = ProgressViewStyle.Solid;
                int num2 = 0;
                this.M_int_upptr = 0;
                for (num9 = this.M_int_upptr; num9 < num8; num9++)
                {
                    buf[9] = (byte) (num9 >> 8);
                    buf[10] = (byte) num9;
                    num = 0;
                    int index = 0;
                    while (index <= 10)
                    {
                        num = (byte) (num + buf[index]);
                        index++;
                    }
                    buf[11] = num;
                    int num5 = 0;
                    while (num5 < 3)
                    {
                        try
                        {
                            this.opComm.SendData(buf, 12);
                            int nlen = this.opComm.Receive(this.timeReceive, 0x7d0);
                            if (nlen >= (this.byValid + 3))
                            {
                                buffer2 = this.opComm.ReadData(nlen);
                                if (buffer2[0] == 0xbd)
                                {
                                    for (index = 0; index < this.byValid; index++)
                                    {
                                        buffer3[(num9 * this.byValid) + index] = buffer2[5 + index];
                                    }
                                    break;
                                }
                            }
                        }
                        catch (Exception)
                        {
                        }
                        num5++;
                    }
                    if (num5 == 3)
                    {
                        this.M_int_upptr = num9;
                        return false;
                    }
                    this.pbarData.Position = num9 + 1;
                    str13 = Math.Round((decimal) (((num9 + 1) * 100) / num8), 2).ToString();
                    switch (str13.IndexOf('.'))
                    {
                        case 1:
                            str13 = "0" + str13;
                            break;

                        case -1:
                            str13 = str13 + ".00";
                            break;
                    }
                    if ((str13 != "100") && (str13.Length == 4))
                    {
                        str13 = str13.Insert(3, "0");
                    }
                    this.lblSum.Text = str13 + "%";
                    num2++;
                }
                if (num2 == num8)
                {
                    str14 = "读取成功，正在处理数据......";
                }
                else
                {
                    return false;
                }
                str10 = DateTime.Now.ToLongTimeString();
                this.lblRecords.Text = str14;
                int num11 = 0;
                if (num2 == num8)
                {
                    this.pbarData.Properties.Maximum = num8;
                    this.pbarData.Position = 0;
                    for (num9 = 0; num9 < num8; num9++)
                    {
                        for (int j = 0; j < this.byValid; j += 10)
                        {
                            if (buffer3[(num9 * this.byValid) + j] != 0xff)
                            {
                                long num6;
                                num11++;
                                bool flag = true;
                                if ((buffer3[(num9 * this.byValid) + j] & 0x40) == 0)
                                {
                                    if ((buffer3[(num9 * this.byValid) + j] & 3) == 1)
                                    {
                                        num6 = ((buffer3[((num9 * this.byValid) + j) + 7] * 0x10000) + (buffer3[((num9 * this.byValid) + j) + 8] * 0x100)) + buffer3[((num9 * this.byValid) + j) + 9];
                                        str = Convert.ToString(num6).PadLeft(8, '0');
                                        str8 = "通过";
                                        str9 = "有效员工";
                                    }
                                    else if ((buffer3[(num9 * this.byValid) + j] & 3) == 2)
                                    {
                                        str = "";
                                        str8 = "通过";
                                        str9 = "有效员工";
                                    }
                                    else if ((buffer3[(num9 * this.byValid) + j] & 3) == 3)
                                    {
                                        num6 = ((buffer3[((num9 * this.byValid) + 7) + j] * 0x10000) + (buffer3[((num9 * this.byValid) + j) + 8] * 0x100)) + buffer3[((num9 * this.byValid) + j) + 9];
                                        str = Convert.ToString(num6).PadLeft(8, '0');
                                        str8 = "禁止通过";
                                        str9 = "无效卡或者不在有效时段";
                                    }
                                    else if ((buffer3[(num9 * this.byValid) + j] & 4) == 4)
                                    {
                                        str8 = "通过";
                                        flag = true;
                                        str2 = "无";
                                        str12 = "无";
                                        str = "无";
                                        str9 = "内部开门";
                                    }
                                    if ((buffer3[(num9 * this.byValid) + j] & 8) == 8)
                                    {
                                        str7 = "出门";
                                    }
                                    else
                                    {
                                        str7 = "进门";
                                    }
                                    if (((((buffer3[((num9 * this.byValid) + j) + 1] > 0x99) || (buffer3[((num9 * this.byValid) + j) + 2] > 0x12)) || ((buffer3[((num9 * this.byValid) + j) + 3] > 0x33) || (buffer3[((num9 * this.byValid) + j) + 4] > 0x24))) || (buffer3[((num9 * this.byValid) + j) + 5] > 0x60)) || (buffer3[((num9 * this.byValid) + j) + 6] > 0x60))
                                    {
                                        str10 = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                                    }
                                    else
                                    {
                                        str13 = Convert.ToString(buffer3[((num9 * this.byValid) + j) + 1], 0x10).PadLeft(2, '0');
                                        str10 = "20" + str13 + "-";
                                        str13 = Convert.ToString(buffer3[((num9 * this.byValid) + j) + 2], 0x10).PadLeft(2, '0');
                                        str10 = str10 + str13 + "-";
                                        str13 = Convert.ToString(buffer3[((num9 * this.byValid) + j) + 3], 0x10).PadLeft(2, '0');
                                        str10 = str10 + str13 + " ";
                                        str13 = Convert.ToString(buffer3[((num9 * this.byValid) + j) + 4], 0x10).PadLeft(2, '0');
                                        str10 = str10 + str13 + ":";
                                        str13 = Convert.ToString(buffer3[((num9 * this.byValid) + j) + 5], 0x10).PadLeft(2, '0');
                                        str10 = str10 + str13 + ":";
                                        str13 = Convert.ToString(buffer3[((num9 * this.byValid) + j) + 6], 0x10).PadLeft(2, '0');
                                        str10 = str10 + str13;
                                    }
                                    string str15 = "select * from CardSerial where CardNumber = '" + str + "'";
                                    OleDbDataReader reader = this.boperate.getread(str15);
                                    if (reader.HasRows)
                                    {
                                        reader.Read();
                                        str2 = reader["UserName"].ToString().Trim();
                                        str3 = reader["Sex"].ToString().Trim();
                                        str4 = reader["AreaName"].ToString().Trim();
                                        str5 = reader["BuildingNo"].ToString().Trim();
                                        str6 = reader["RoomNumber"].ToString().Trim();
                                    }
                                    if (flag)
                                    {
                                        this.opAndvalidate.autoNum("select max(NoteID) from tb_Note", "tb_Note", "NoteID", "No", "1000001", this.txtUserID);
                                        this.boperate.getcom("insert into tb_Note(NoteID,NoteName,NoteSex,NoteArea,NoteBuild,NoteRoomNum,NoteCard,NoteTime,NotePosition,NoteInOut,NotePass,NoteRemark) values('" + this.txtUserID.Text.Trim() + "','" + str2 + "','" + str3 + "','" + str4 + "','" + str5 + "','" + str6 + "','" + str + "','" + str10 + "','" + this.strEquPosition + "','" + str7 + "','" + str8 + "','" + str9 + "')");
                                    }
                                    reader.Dispose();
                                }
                                else
                                {
                                    if ((buffer3[(num9 * this.byValid) + j] & 7) == 1)
                                    {
                                        str9 = "忘关门报警";
                                        str = "无";
                                    }
                                    else if ((buffer3[(num9 * this.byValid) + j] & 7) == 2)
                                    {
                                        str9 = "撬门报警";
                                        str = "无";
                                    }
                                    else if ((buffer3[(num9 * this.byValid) + j] & 7) == 3)
                                    {
                                        num6 = ((buffer3[((num9 * this.byValid) + 7) + j] * 0x10000) + (buffer3[((num9 * this.byValid) + j) + 8] * 0x100)) + buffer3[((num9 * this.byValid) + j) + 9];
                                        str = Convert.ToString(num6).PadLeft(8, '0');
                                        str8 = "禁止通过";
                                        str9 = "无效卡或者不在有效时段";
                                    }
                                    str13 = Convert.ToString(buffer3[((num9 * this.byValid) + j) + 1], 0x10).PadLeft(2, '0');
                                    str10 = "20" + str13 + "-";
                                    str13 = Convert.ToString(buffer3[((num9 * this.byValid) + j) + 2], 0x10).PadLeft(2, '0');
                                    str10 = str10 + str13 + "-";
                                    str13 = Convert.ToString(buffer3[((num9 * this.byValid) + j) + 3], 0x10).PadLeft(2, '0');
                                    str10 = str10 + str13 + " ";
                                    str13 = Convert.ToString(buffer3[((num9 * this.byValid) + j) + 4], 0x10).PadLeft(2, '0');
                                    str10 = str10 + str13 + ":";
                                    str13 = Convert.ToString(buffer3[((num9 * this.byValid) + j) + 5], 0x10).PadLeft(2, '0');
                                    str10 = str10 + str13 + ":";
                                    str13 = Convert.ToString(buffer3[((num9 * this.byValid) + j) + 6], 0x10).PadLeft(2, '0');
                                    str10 = str10 + str13;
                                    this.opAndvalidate.autoNum("select max(AlmID) from tb_Alm", "tb_Alm", "AlmID", "Al", "1000001", this.txtUserID);
                                    this.boperate.getcom("insert into tb_Alm(AlmID,AlmLocation,AlmCard,AlmTime,AlmRemark) values('" + this.txtUserID.Text.Trim() + "','" + this.strEquPosition + "','" + str + "','" + str10 + "','" + str9 + "')");
                                }
                            }
                        }
                        this.timeReceive.Interval = 10;
                        this.timeReceive.Enabled = true;
                        while (this.timeReceive.Enabled)
                        {
                            Application.DoEvents();
                        }
                        this.pbarData.Position = num9 + 1;
                        str13 = Math.Round((decimal) (((num9 + 1) * 100) / num8), 2).ToString();
                        switch (str13.IndexOf('.'))
                        {
                            case 1:
                                str13 = "0" + str13;
                                break;

                            case -1:
                                str13 = str13 + ".00";
                                break;
                        }
                        if ((str13 != "100") && (str13.Length == 4))
                        {
                            str13 = str13.Insert(3, "0");
                        }
                        this.lblSum.Text = str13 + "%";
                    }
                }
                this.nReadRecords = num11;
                this.lblRead.Text = Convert.ToString(num11) + "条";
                this.lblRecords.Text = "数据处理完成";
                return true;
            }
            catch (Exception exception2)
            {
                MessageBox.Show(exception2.Message.ToString());
                Console.WriteLine(exception2.ToString());
                return false;
            }
        }

        public int readsanqu()
        {
            try
            {
                int num = 11;
                byte[] buffer = new byte[] { 0xbd, 5, 0xcf, 0, 0, 0x10, 0, 0xa1 };
                byte[] buffer2 = new byte[11];
                comm.Write(buffer, 0, 8);
                for (int i = 0; i < 3; i++)
                {
                    if (this.Receive() == 11)
                    {
                        comm.Read(buffer2, 0, 11);
                        if ((buffer2[0] == 0xbd) && (buffer2[1] == 8))
                        {
                            byte num4 = 0;
                            for (int j = 0; j < 10; j++)
                            {
                                num4 = (byte) (num4 + buffer2[j]);
                            }
                            if (num4 != buffer2[10])
                            {
                                MessageBox.Show("验证出错，可能是数据没发完整");
                                comm.Close();
                            }
                            else
                            {
                                num = buffer2[9];
                            }
                            break;
                        }
                    }
                }
                return num;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
                return 0;
            }
        }

        private void readTrue()
        {
            try
            {
                this.btnReadCard.Enabled = true;
                this.btnReadCard.Text = "读  卡";
                this.btnreadCard1.Enabled = true;
                this.btnreadCard1.Text = "读  卡";
                this.读卡ToolStripMenuItem.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        public int Receive()
        {
            try
            {
                int bytesToRead = 0;
                this.timer1.Interval = 50;
                this.timer1.Enabled = true;
                while (this.timer1.Enabled)
                {
                    if (comm.BytesToRead > bytesToRead)
                    {
                        bytesToRead = comm.BytesToRead;
                        this.timer1.Enabled = false;
                        this.timer1.Interval = 10;
                        this.timer1.Enabled = true;
                    }
                    else
                    {
                        Application.DoEvents();
                    }
                }
                return bytesToRead;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                return 0;
            }
        }

        public int Receive1(int _time)
        {
            try
            {
                int bytesToRead = 0;
                this.timer1.Interval = _time;
                this.timer1.Enabled = true;
                while (this.timer1.Enabled)
                {
                    if (comm.BytesToRead > bytesToRead)
                    {
                        bytesToRead = comm.BytesToRead;
                        this.timer1.Enabled = false;
                        this.timer1.Interval = 10;
                        this.timer1.Enabled = true;
                    }
                    else
                    {
                        Application.DoEvents();
                    }
                }
                return bytesToRead;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
                return 0;
            }
        }

        private void RecSucc()
        {
            try
            {
                string str = "";
                string str2 = "";
                string str3 = "";
                string str4 = "";
                string str5 = "";
                string str6 = "";
                string str7 = "";
                string str8 = "";
                string str9 = "";
                string str10 = "";
                string str11 = "";
                bool flag = false;
                this.nSend++;
                if ((this.byReadbuf != null) && (this.nReadLen == 0x10))
                {
                    string str14;
                    long num2;
                    DataSet set;
                    byte num = this.byReadbuf[5];
                    if ((num & 0x40) == 0)
                    {
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                    }
                    if (!flag)
                    {
                        if ((num & 7) == 1)
                        {
                            str = "有效卡";
                            str9 = "通过";
                            str10 = "有效员工";
                        }
                        else if ((num & 7) == 3)
                        {
                            str = "无效卡";
                            str9 = "禁止通过";
                            str10 = "无效卡或者不在有效时段内";
                        }
                        else if ((num & 7) == 4)
                        {
                            str = "内部开门";
                            str9 = "通过";
                            str10 = "";
                        }
                        if ((num & 8) == 8)
                        {
                            str8 = "出门";
                        }
                        else
                        {
                            str8 = "进门";
                        }
                        if (((((this.byReadbuf[6] > 0x99) || (this.byReadbuf[7] > 0x12)) || ((this.byReadbuf[8] > 0x33) || (this.byReadbuf[9] > 0x24))) || (this.byReadbuf[10] > 0x60)) || (this.byReadbuf[12] > 0x60))
                        {
                            str11 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        }
                        else
                        {
                            str11 = "20";
                            str11 = (((((str11 + Convert.ToString(this.byReadbuf[6], 0x10).PadLeft(2, '0') + "-") + Convert.ToString(this.byReadbuf[7], 0x10).PadLeft(2, '0') + "-") + Convert.ToString(this.byReadbuf[8], 0x10).PadLeft(2, '0') + " ") + Convert.ToString(this.byReadbuf[9], 0x10).PadLeft(2, '0') + ":") + Convert.ToString(this.byReadbuf[10], 0x10).PadLeft(2, '0') + ":") + Convert.ToString(this.byReadbuf[11], 0x10).PadLeft(2, '0');
                        }
                        bool flag2 = true;
                        switch (str)
                        {
                            case "有效卡":
                            {
                                num2 = ((this.byReadbuf[12] << 0x10) + (this.byReadbuf[13] << 8)) + this.byReadbuf[14];
                                str2 = Convert.ToString(num2).PadLeft(8, '0');
                                string str15 = "select * from CardSerial where CardNumber = '" + str2 + "'";
                                OleDbDataReader reader = this.boperate.getread(str15);
                                if (reader.HasRows)
                                {
                                    reader.Read();
                                    str3 = reader["UserName"].ToString().Trim();
                                    str4 = reader["Sex"].ToString().Trim();
                                    str5 = reader["AreaName"].ToString().Trim();
                                    str6 = reader["BuildingNo"].ToString().Trim();
                                    str7 = reader["RoomNumber"].ToString().Trim();
                                    flag2 = true;
                                }
                                reader.Dispose();
                                break;
                            }
                            case "内部开门":
                                flag2 = true;
                                str3 = "无";
                                str4 = "无";
                                str5 = "无";
                                str6 = "无";
                                str7 = "无";
                                break;
                        }
                        if (flag2)
                        {
                            this.opAndvalidate.autoNum("select max(NoteID) from tb_Note", "tb_Note", "NoteID", "No", "1000001", this.txtUserID);
                            this.boperate.getcom("insert into tb_Note(NoteID,NoteName,NoteSex,NoteArea,NoteBuild,NoteRoomNum,NoteCard,NoteTime,NotePosition,NoteInOut,NotePass,NoteRemark) values('" + this.txtUserID.Text.Trim() + "','" + str3 + "','" + str4 + "','" + str5 + "','" + str6 + "','" + str7 + "','" + str2 + "','" + str11 + "','" + this.strPositionMonitoring + "','" + str8 + "','" + str9 + "','" + str10 + "')");
                            str14 = "select * from tb_Note where clng(right(NoteID,7)) >= '" + this.strMaxID + "'";
                            set = this.boperate.getds(str14, "tb_Note");
                            this.gridControl1.DataSource = set.Tables[0];
                            this.dgvExecute.FocusedRowHandle = set.Tables[0].Rows.Count - 1;
                        }
                    }
                    else
                    {
                        if (((((this.byReadbuf[6] > 0x99) || (this.byReadbuf[7] > 0x12)) || ((this.byReadbuf[8] > 0x33) || (this.byReadbuf[9] > 0x24))) || (this.byReadbuf[10] > 0x60)) || (this.byReadbuf[12] > 0x60))
                        {
                            str11 = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                        }
                        else
                        {
                            str11 = "20";
                            str11 = (((((str11 + Convert.ToString(this.byReadbuf[6], 0x10).PadLeft(2, '0') + "-") + Convert.ToString(this.byReadbuf[7], 0x10).PadLeft(2, '0') + "-") + Convert.ToString(this.byReadbuf[8], 0x10).PadLeft(2, '0') + " ") + Convert.ToString(this.byReadbuf[9], 0x10).PadLeft(2, '0') + ":") + Convert.ToString(this.byReadbuf[10], 0x10).PadLeft(2, '0') + ":") + Convert.ToString(this.byReadbuf[11], 0x10).PadLeft(2, '0');
                        }
                        if ((num & 7) == 1)
                        {
                            str10 = "忘关门报警";
                            str2 = "无";
                        }
                        else if ((num & 7) == 2)
                        {
                            str10 = "撬门报警";
                            str2 = "无";
                        }
                        else if ((num & 7) == 3)
                        {
                            str10 = "无效卡或者不在有效时段";
                            num2 = ((this.byReadbuf[12] << 0x10) + (this.byReadbuf[13] << 8)) + this.byReadbuf[14];
                            str2 = Convert.ToString(num2).PadLeft(8, '0');
                        }
                        else if ((num & 7) == 4)
                        {
                            str10 = "电池没电报警";
                            str2 = "无";
                        }
                        this.opAndvalidate.autoNum("select max(AlmID) from tb_Alm", "tb_Alm", "AlmID", "Al", "1000001", this.txtUserID);
                        this.boperate.getcom("insert into tb_Alm(AlmID,AlmLocation,AlmCard,AlmTime,AlmRemark) values('" + this.txtUserID.Text.Trim() + "','" + this.strPositionMonitoring + "','" + str2 + "','" + str11 + "','" + str10 + "')");
                        str14 = "select * from tb_Alm where clng(right(AlmID,7)) >= '" + this.strAlmMaxID + "'";
                        set = this.boperate.getds(str14, "tb_Alm");
                        this.gridControl3.DataSource = set.Tables[0];
                        this.dgvAlarm.FocusedRowHandle = set.Tables[0].Rows.Count - 1;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void RevShow()
        {
            try
            {
                this.imgList.Items[this.nPtr].ImageIndex = 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        public bool SearchCard()
        {
            try
            {
                byte[] buffer = new byte[] { 0xbd, 5, 0xb1, 0, 0, 0, 0, 0x73 };
                comm.DiscardInBuffer();
                comm.Write(buffer, 0, 8);
                Array.Clear(buffer, 0, 8);
                bool flag = false;
                for (int i = 0; i < 3; i++)
                {
                    try
                    {
                        int count = this.Receive();
                        if (count == 7)
                        {
                            byte[] buffer2 = new byte[count];
                            comm.Read(buffer2, 0, count);
                            if ((buffer2[0] == 0xbd) && (buffer2[1] == 4))
                            {
                                byte num3 = 0;
                                for (int j = 0; j < 6; j++)
                                {
                                    num3 = (byte) (num3 + buffer2[j]);
                                }
                                if (num3 != buffer2[6])
                                {
                                    MessageBox.Show("数据接收不完整");
                                    flag = false;
                                }
                                if (buffer2[5] == 0)
                                {
                                    flag = true;
                                }
                                else
                                {
                                    MessageBox.Show("没有找到卡");
                                    flag = false;
                                }
                                break;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    if (i == 3)
                    {
                        MessageBox.Show("接收数据失败！", "提示", MessageBoxButtons.OK);
                        flag = false;
                    }
                }
                return flag;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
                return false;
            }
        }

        private void selCardNote_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = true;
                string str = "";
                string str2 = "";
                string str3 = "";
                this.tabControl2.SelectedTab = this.tabPage5;
                str = this.dataBegin.DateTime.ToShortDateString();
                str2 = this.dateEnd.DateTime.ToShortDateString();
                if ((str == "0001-01-01") && (str2 == "0001-01-01"))
                {
                    str3 = "select * from tb_Note";
                }
                else if ((str != "0001-01-01") && (str2 == "0001-01-01"))
                {
                    str3 = "select * from tb_Note where cdate(left(NoteTime,10))>='" + str + "' and ";
                }
                else if ((str == "0001-01-01") && (str2 != "0001-01-01"))
                {
                    str3 = "select * from tb_Note where cdate(left(NoteTime,10))<='" + str2 + "' and ";
                }
                else
                {
                    str3 = "select * from tb_Note where cdate(left(NoteTime,10))>='" + str + "' and cdate(left(NoteTime,10))<='" + str2 + "'";
                }
                DataSet set = this.boperate.getds(str3, "tb_Note");
                if (set.Tables[0].Rows.Count > 0)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
                this.gridControl2.DataSource = set.Tables[0];
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void SendFalse()
        {
            try
            {
                this.btnSentCard.Enabled = false;
                this.btnSentCard.Text = "正在发卡......";
                this.btnsendcard1.Enabled = false;
                this.btnsendcard1.Text = "正在发卡.....";
                this.发卡ToolStripMenuItem.Enabled = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void SendTrue()
        {
            try
            {
                this.btnSentCard.Enabled = true;
                this.btnSentCard.Text = "发  卡";
                this.btnsendcard1.Enabled = true;
                this.btnsendcard1.Text = "发  卡";
                this.发卡ToolStripMenuItem.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        public bool SerachSerialport()
        {
            try
            {
                byte[] buffer = new byte[] { 0xbd, 5, 240, 0, 0, 0, 0, 0xb2 };
                comm.DiscardInBuffer();
                comm.Write(buffer, 0, 8);
                bool flag = false;
                for (int i = 0; i < 3; i++)
                {
                    try
                    {
                        int count = this.Receive();
                        if (count == 7)
                        {
                            byte[] buffer2 = new byte[count];
                            comm.Read(buffer2, 0, count);
                            if ((buffer2[0] == 0xbd) && (buffer2[1] == 4))
                            {
                                byte num3 = 0;
                                for (int j = 0; j < 6; j++)
                                {
                                    num3 = (byte) (num3 + buffer2[j]);
                                }
                                if (num3 != buffer2[6])
                                {
                                    MessageBox.Show("数据接收不完整");
                                    break;
                                }
                                if (buffer2[5] == 0)
                                {
                                    flag = true;
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    if (i == 3)
                    {
                        MessageBox.Show("接收数据失败！", "提示", MessageBoxButtons.OK);
                    }
                }
                return flag;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
                return false;
            }
        }

        private void SetButtonState(bool ButtonState)
        {
            this.btnSerchSerial.Enabled = ButtonState;
            this.btnSentCard.Enabled = ButtonState;
            this.btnReadCard.Enabled = ButtonState;
            this.btnsendcard1.Enabled = ButtonState;
            this.btnreadCard1.Enabled = ButtonState;
            this.btnNumber.Enabled = ButtonState;
            this.btnSelect.Enabled = ButtonState;
            this.btnBlacklist.Enabled = ButtonState;
            if (ButtonState)
            {
                this.Family.Enabled = FamilyButtonStateCache;
                if (this.ReadedCard)
                {
                    this.Family.Enabled = true;
                }
            }
            else
            {
                FamilyButtonStateCache = this.Family.Enabled;
                this.Family.Enabled = false;
            }
        }

        public bool SetEquipment(int lnghex1)
        {
            try
            {
                byte[] buffer = new byte[] { 0xbd, 6, 0xc9, 0, 0, 0, 0, 0, 0 };
                int num = (lnghex1 * 4) + 3;
                string blockNumber = Convert.ToString(num, 0x10);
                ArrayList list = IntoByte(num, blockNumber);
                buffer[7] = (byte) list[0];
                byte num2 = 0;
                for (int i = 0; i < 8; i++)
                {
                    num2 = (byte) (num2 + buffer[i]);
                }
                buffer[8] = num2;
                comm.DiscardInBuffer();
                comm.Write(buffer, 0, 9);
                Array.Clear(buffer, 0, 9);
                bool flag = false;
                for (int j = 0; j < 3; j++)
                {
                    try
                    {
                        int count = this.Receive();
                        if (count == 7)
                        {
                            byte[] buffer2 = new byte[count];
                            comm.Read(buffer2, 0, count);
                            if ((buffer2[0] == 0xbd) && (buffer2[1] == 4))
                            {
                                byte num6 = 0;
                                for (int k = 0; k < 6; k++)
                                {
                                    num6 = (byte) (num6 + buffer2[k]);
                                }
                                if (num6 != buffer2[6])
                                {
                                    MessageBox.Show("接收数据不完整");
                                }
                                if (buffer2[5] == 0)
                                {
                                    flag = true;
                                }
                                else
                                {
                                    MessageBox.Show("修改密码为设备密码失败");
                                }
                                break;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    if (j == 3)
                    {
                        MessageBox.Show("接收数据失败！", "提示", MessageBoxButtons.OK);
                    }
                }
                return flag;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
                return false;
            }
        }

        private void StartPolling()
        {
            try
            {
                byte num = 0;
                byte[] buf = new byte[20];
                byte[] buffer2 = new byte[20];
                buf[0] = 0xbd;
                buf[1] = 7;
                buf[2] = 1;
                buf[3] = 0;
                buf[4] = 0;
                buf[5] = 10;
                buf[6] = 10;
                buf[7] = 1;
                buf[8] = 1;
                num = 0;
                for (int i = 0; i < 9; i++)
                {
                    num = (byte) (num + buf[i]);
                }
                buf[9] = num;
                this.opComm.SendData(buf, 10);
                this.timeReceive.Interval = 100;
                this.timeReceive.Enabled = true;
                while (this.timeReceive.Enabled)
                {
                    Application.DoEvents();
                }
                this.nSend = 0;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void stop()
        {
            try
            {
                byte[] buffer = new byte[] { 0xbd, 5, 0xbb, 0, 0, 0, 0, 0x7d };
                comm.DiscardInBuffer();
                comm.Write(buffer, 0, 8);
                Array.Clear(buffer, 0, 8);
                for (int i = 0; i < 3; i++)
                {
                    try
                    {
                        int count = this.Receive();
                        if (count == 7)
                        {
                            byte[] buffer2 = new byte[count];
                            comm.Read(buffer2, 0, count);
                            if ((buffer2[0] == 0xbd) && (buffer2[1] == 4))
                            {
                                byte num3 = 0;
                                for (int j = 0; j < 6; j++)
                                {
                                    num3 = (byte) (num3 + buffer2[j]);
                                }
                                if (num3 != buffer2[6])
                                {
                                    MessageBox.Show("数据接收不完整");
                                }
                                return;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    if (i == 3)
                    {
                        MessageBox.Show("接收数据失败！", "提示", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void sysTime_Elapsed(object source, ElapsedEventArgs e)
        {
            try
            {
                this.sysTime.Enabled = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                this.timer1.Enabled = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void timeReceive_Tick(object sender, EventArgs e)
        {
            try
            {
                this.timeReceive.Enabled = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node.Checked)
                {
                    if ((e.Action != TreeViewAction.Unknown) && (e.Node.Nodes.Count != 0))
                    {
                        foreach (TreeNode node in e.Node.Nodes)
                        {
                            node.Checked = true;
                        }
                    }
                }
                else if ((e.Action != TreeViewAction.Unknown) && (e.Node.Nodes.Count != 0))
                {
                    foreach (TreeNode node in e.Node.Nodes)
                    {
                        node.Checked = false;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void treeView1_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
        }

        public bool VerificationPassword(ref bool isloaddefaultpassword, ref bool isExecutionconinue, ref int s, byte[] password, int lnghex1)
        {
            try
            {
                byte num = 0;
                for (int i = 0; i < 8; i++)
                {
                    num = (byte) (num + password[i]);
                }
                password[8] = num;
                comm.DiscardInBuffer();
                comm.Write(password, 0, 9);
                bool flag = false;
                for (int j = 0; j < 3; j++)
                {
                    try
                    {
                        int count = this.Receive();
                        if (count == 7)
                        {
                            byte[] buffer = new byte[count];
                            comm.Read(buffer, 0, count);
                            if ((buffer[0] == 0xbd) && (buffer[1] == 4))
                            {
                                byte num5 = 0;
                                for (int k = 0; k < 6; k++)
                                {
                                    num5 = (byte) (num5 + buffer[k]);
                                }
                                if (num5 != buffer[6])
                                {
                                    MessageBox.Show("数据接收不完整");
                                }
                                if (buffer[5] == 0)
                                {
                                    flag = true;
                                }
                                break;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    if (j == 3)
                    {
                        MessageBox.Show("接收数据失败！", "提示", MessageBoxButtons.OK);
                    }
                }
                return flag;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
                return false;
            }
        }

        private void 安装USB驱动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("是否安装USB接口驱动", "提示", MessageBoxButtons.OKCancel).Equals(DialogResult.OK))
                {
                    Process.Start(@".\ftdi_ft232_drive.exe");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void 备份数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new frmDataStore { Owner = this }.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void 备份数据库ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                new frmDataStore { Owner = this }.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void 读卡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnReadCard_Click(sender, e);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void 发卡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnSentCard_Click(sender, e);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void 发卡记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Form4(this.UserPermissionType) { Owner = this }.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void 还原数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new frmDataRevert { Owner = this }.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void 还原数据库ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmDataRevert revert = new frmDataRevert {
                    Owner = this
                };
                if (revert.ShowDialog() == DialogResult.Yes)
                {
                    try
                    {
                        string safeSql = "create table tb_Equ (EquID varchar(255) primary key,EquAddress varchar(10),EquLocation varchar(255),EquFloor varchar(255),EquIsAllot varchar(5),EquCount varchar(10))";
                        DBHelper.ExecuteCommand(safeSql);
                    }
                    catch
                    {
                    }
                    try
                    {
                        string str2 = "create table tb_Alm (AlmID varchar(20) primary key,AlmEqu varchar(10),AlmLocation varchar(255),AlmRemark varchar(255),AlmTime varchar(20),AlmCount varchar(20),AlmPass varchar(10),AlmCard varchar(20))";
                        DBHelper.ExecuteCommand(str2);
                    }
                    catch
                    {
                    }
                    try
                    {
                        string str3 = "create table tb_Execute (ExID varchar(255) primary key,ExTime varchar(30),ExCmd varchar(255),ExTarget varchar(255),ExResult varchar(255))";
                        DBHelper.ExecuteCommand(str3);
                    }
                    catch
                    {
                    }
                    try
                    {
                        string str4 = "create table tb_Note (NoteID varchar(50) primary key,NoteName varchar(255),NoteSex varchar(255),NoteArea varchar(20),NoteBuild varchar(255),NoteRoomNum varchar(255),NoteCard varchar(255),NoteTime varchar(30),NotePosition varchar(255),NoteInOut varchar(4),NotePass varchar(10),NoteRemark varchar(255))";
                        DBHelper.ExecuteCommand(str4);
                    }
                    catch
                    {
                    }
                    try
                    {
                        string str5 = "create table tb_TimeD (TimeID varchar(20) primary key,TimeStart1 varchar(100),TimeEnd1 varchar(100),TimeStart2 varchar(100),TimeEnd2 varchar(100),TimeStart3 varchar(100),TimeEnd3 varchar(100),TimeStart4 varchar(100),TimeEnd4 varchar(100),TimeMon varchar(5),TimeTues varchar(5),TimeWed varchar(5),TimeThurs varchar(5),TimeFri varchar(5),TimeSat varchar(5),TimeSun varchar(5),TimeName varchar(5))";
                        DBHelper.ExecuteCommand(str5);
                    }
                    catch
                    {
                    }
                    MessageBox.Show("数据库还原完成,请重新登陆");
                    new Command().RunProgram("DoorsController.Core.RestartSelf.exe");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void 黑名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 联系我们ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 数据清理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("清理数据会删除所有的刷卡记录和报警记录,确定清理?", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    string str = "delete * from tb_Alm";
                    this.boperate.getcom(str);
                    string str2 = "delete * from tb_Note";
                    this.boperate.getcom(str2);
                    MessageBox.Show("数据清理成功");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 用户管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.UserPermissionType.Contains("Admin"))
                {
                    new OperatorUserManagement { Owner = this }.ShowDialog();
                }
                else
                {
                    MessageBox.Show("权限不足", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
                Console.WriteLine(exception.ToString());
            }
        }

        private delegate void rxd_call_back();
    }
}

