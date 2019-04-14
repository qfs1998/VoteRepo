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
namespace voting
{
    public partial class SuccessfulVoteForm : Form
    {
        public SuccessfulVoteForm()
        {
            InitializeComponent();
        }
        MySqlDataAdapter myadp; // mysql数据适配器
        DataSet myds;   // 数据集
        string MyConnectionString;
        BindingSource bindingSource1;
        private void SuccessfulVote_Load(object sender, EventArgs e)
        {
            bindingSource1 = new BindingSource();//绑定，桥梁
            try

            {
                string s1 = "( ";
                //打开菜单配置数据库连接
                for(int i=0;i<VoteForm.arrayOfVotedId.Count-1;++i)
                {
                    s1 = s1 + Convert.ToString(VoteForm.arrayOfVotedId[i]) + " , ";
                }
                s1 = s1 + Convert.ToString(VoteForm.arrayOfVotedId[VoteForm.arrayOfVotedId.Count - 1]) + "  )";
                string adpstr = "select * from vote where id in    " + s1;
                //myadp = new MySqlDataAdapter("select * from vote ", ConnectForm.conn);
                myadp = new MySqlDataAdapter(adpstr, ConnectForm.conn);

                myds = new DataSet();
                // 填充和绑定数据


                myadp.Fill(myds, "vote");//table
                bindingSource1.DataSource = myds.Tables["vote"];
                dataGridView1.DataSource = bindingSource1;
                dataGridView1.ReadOnly = true;

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
    }
}
