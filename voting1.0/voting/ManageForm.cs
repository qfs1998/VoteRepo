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
    public partial class ManageForm : Form
    {
        public ManageForm()
        {
            InitializeComponent();
        }
        MySqlDataAdapter myadp; // mysql数据适配器
        DataSet myds;   // 数据集
        string MyConnectionString;
        BindingSource bindingSource1;
        private void ManageForm_Load(object sender, EventArgs e)
        {
            //MySqlDataAdapter myadp; // mysql数据适配器
            //DataSet myds;   // 数据集
            //string MyConnectionString;
            //BindingSource bindingSource1 = new BindingSource();//绑定，桥梁
            bindingSource1 = new BindingSource();//绑定，桥梁
            try

            {

                //打开菜单配置数据库连接


                myadp = new MySqlDataAdapter("select * from vote", ConnectForm.conn);
                myds = new DataSet();
                // 填充和绑定数据


                myadp.Fill(myds, "vote");//table
                bindingSource1.DataSource = myds.Tables["vote"];
                dataGridView2.DataSource = bindingSource1;

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

        //删除投票项目
        private void deletebutton_Click(object sender, EventArgs e)
        {
            for (int i = this.dataGridView2.SelectedRows.Count; i > 0; i--)
            {
                //int ID = Convert.ToInt32(dataGridView2.SelectedRows[i - 1].Cells[0].Value);
                dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[i - 1].Index);
            }
        }

        //同步保存到数据库
        private void savebutton_Click(object sender, EventArgs e)
        {
            //string MyConnectionString;
            //MyConnectionString = "server = localhost; uid = root; pwd = 123456; database = mytest";
            try
            {
                bindingSource1.DataSource = myds.Tables["vote"];
                dataGridView2.DataSource = bindingSource1;
                //使用MySqlCommandBuilder可以避免自己编写SQL的语句，从而Update时
                //MySQLDataAdapter可以根据用户操作自动判别是修改、删除还是插入特性
                //并生成相应的SQL命令用来更新数据库。
                MySqlCommandBuilder mycb = new MySqlCommandBuilder(myadp);
                myadp.Update(myds, "vote");
                ManageForm_Load(sender, e);

            }

            

            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    default:
                        MessageBox.Show(ex.Message); break;
                }
}
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            ManageForm_Load(sender, e);
        }
    }
}
