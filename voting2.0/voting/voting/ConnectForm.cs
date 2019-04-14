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
    public partial class ConnectForm : Form
    {
        private bool isconn = false;
        static public MySqlConnection conn;

        public ConnectForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string databaseIp = databaseIptextBox.Text.ToString();
            string account = accounttextBox.Text.ToString();
            string password = passwordtextBox.Text.ToString();
            string port = porttextBox.Text.ToString();
            //string constr = "server=localhost;User id=root;password=123456;Database=mytest";

            //string constr = "server=" + databaseIp + ";" + "User id=root;password=123456;Database=mytest";
            string constr = "server=" + databaseIp + ";" + "User id="+account+";"+"password="+password+";"+
                "Database=mytest;"+"port="+port+";";

            //MySqlConnectionStringBuilder sqlbulider = new MySqlConnectionStringBuilder();
            //sqlbulider.Server = databaseIp;
            //sqlbulider.UserID = "root";
            //sqlbulider.Password = "123456";
            //sqlbulider.Database = "mytest";

            conn = new MySqlConnection(constr);
            try
            {
                conn.Open();
                label1.Text = "打开数据库成功";
                isconn = true;

            }
            catch (Exception x)
            {
                //label1.Text = x.ToString();
                label1.Text = "打开数据库失败";
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLable.Text = "欢迎使用本投票系统，当前时间为：" + DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss");
        }

        private void databaseIptextBox_Click(object sender, EventArgs e)
        {
            if (databaseIptextBox.Text == "输入数据库ip")
                databaseIptextBox.Text = "";
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            if (isconn)
            {
                LoginForm loginform = new LoginForm();
                loginform.Show();
                //this.Hide();
            }
            else
                MessageBox.Show("还没连接到数据库");
        }

        private void votebutton_Click(object sender, EventArgs e)
        {
            if (isconn)
            {
                VoteForm voteForm = new VoteForm();
                voteForm.Show();
            }
            else
                MessageBox.Show("还没连接数据库");
        }

        private void accounttextBox_Click(object sender, EventArgs e)
        {
            accounttextBox.Text = "";
        }

        private void passwordtextBox_Click(object sender, EventArgs e)
        {
            passwordtextBox.Text = "";
        }

        private void porttextBox_Click(object sender, EventArgs e)
        {
            porttextBox.Text = "";
        }
    }
}
