using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
namespace voting
{
    public partial class VoteForm : Form
    {
        public static List<int> arrayOfVotedId=new List<int>();

        public VoteForm()
        {
            InitializeComponent();
        }

        private void VoteForm_Load(object sender, EventArgs e)
        {
            FileStream F = new FileStream("VotedID.dat", FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
            //StreamWriter writer = new StreamWriter(F);
            StreamReader reader = new StreamReader(F);
            string votedIdString = reader.ReadLine();
            while (votedIdString != null && votedIdString != "")
            {
                arrayOfVotedId.Add(Convert.ToInt32(votedIdString));
                votedIdString = reader.ReadLine();
            }
            F.Close();

            MySqlDataAdapter myadp; // mysql数据适配器
            DataSet myds;   // 数据集
            string MyConnectionString;
            BindingSource bindingSource1 = new BindingSource();//绑定，桥梁
            dataGridView1.ReadOnly = true;
            //dataGridView1.AutoGenerateColumns = false;//不自动生成列名
            //dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //this.dataGridView1.Columns[0].FillWeight = 30;
            //this.dataGridView1.Columns[5].FillWeight = 150;
            try

            {

                //打开菜单配置数据库连接


                myadp = new MySqlDataAdapter("select ID,A,B,C,D,description from vote", ConnectForm.conn);
                myds = new DataSet();
                // 填充和绑定数据


                myadp.Fill(myds, "vote");//table
                bindingSource1.DataSource = myds.Tables["vote"];
                dataGridView1.DataSource = bindingSource1;
                //DataTable dtbl = myds.Tables["vote"];
                //dataGridView1.Columns["ID"].DataPropertyName = dtbl.Columns["id"].ToString();

            }

            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("不能连接到数据库服务器，请联系数据库管理员！"); break;
                    case 1045:
                        MessageBox.Show("无效的用户名/密码,请重试！"); break;
                    case 1049:
                        MessageBox.Show("数据库不存在，或数据库名错误"); break;
                    default:
                        MessageBox.Show(ex.Message); break;
                }
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            FileStream F = new FileStream("VotedID.dat", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(F);//接着文件尾写

            //值得注意的是dataGridView1.Rows.Count比实际投票项目的数值多出1，因为多了一行空白行！
            int[] exsitID = new int[this.dataGridView1.Rows.Count];
            for (int i = 0; i < this.dataGridView1.Rows.Count-1; i++)//所以必须要减去1
            {
                DataGridViewRow row = this.dataGridView1.Rows[i];
                exsitID[i] =Convert.ToInt32 (row.Cells[0].Value.ToString());
            }
            //

            int id = Convert.ToInt32 (IDtextBox.Text);
            if (exsitID.Contains(id))
            {
                if (!arrayOfVotedId.Contains(id))
                {
                    string selection = SelectiontextBox.Text;
                    if (selection == "a" || selection == "A" || selection == "b" || selection == "B"
                        || selection == "c" || selection == "C" || selection == "d" || selection == "D")
                    {
                        try
                        {
                            //MySqlCommand cmd = new MySqlCommand("update  vote set @selection = @selection  +1 where id = @id", ConnectForm.conn);

                            //cmd.Parameters.AddWithValue("@id", id);
                            switch (selection)
                            {
                                case "A":
                                case "a":
                                    selection = "acount";
                                    break;
                                case "B":
                                case "b":
                                    selection = "bcount";
                                    break;
                                case "C":
                                case "c":
                                    selection = "ccount";
                                    break;
                                default:
                                    selection = "dcount";
                                    break;


                            }
                            string cmdString = "update vote set " + selection + " = " + selection + "+1" + "  where id =" + Convert.ToString(id);
                            //MySqlCommand cmd = new MySqlCommand("update  vote set acount =acount  +1  where id = 2", ConnectForm.conn);
                            MySqlCommand cmd = new MySqlCommand(cmdString, ConnectForm.conn);
                            cmd.ExecuteNonQuery();

                            arrayOfVotedId.Add(id);
                            MessageBox.Show("投票成功了呢\n你可以在已投项目中看到该投票项目的具体票数呢!");
                            // cmd.Parameters.AddWithValue("@selection", selection);
                            //MessageBox.Show(cmdString);
                            writer.WriteLine(id);
                            writer.Flush();
                            F.Close();

                        }
                        catch (Exception x)
                        {
                            MessageBox.Show(x.ToString());
                        }

                    }
                    else
                    {
                        MessageBox.Show("不存在该选项");
                    }

                }
                else
                {
                    MessageBox.Show("每人每项只能投票一次哦！");
                }
            }
            else
                MessageBox.Show("不存在ID为 "+Convert.ToString(id)+" 的投票项目哦");
        }

        private void haveVotedbutton_Click(object sender, EventArgs e)
        {
            if (arrayOfVotedId.Count != 0)
            {
                SuccessfulVoteForm successfulvoteForm = new SuccessfulVoteForm();
                successfulvoteForm.Show();
            }
            else
                MessageBox.Show("目前你还没有投票过任何一项呢!");
        }
    }
}
