using Npgsql;

namespace zooShop
{

    public partial class loginForm : Form
    {
        private static string connectionString = "Database=zooShop;Username=postgres;Host=localhost;Password=1;Port=5432";

        public loginForm()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"SELECT * FROM users WHERE login = @login AND password = @password";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("login", login);
                    cmd.Parameters.AddWithValue("password", password);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Program.currentFio = reader["fio"].ToString();
                            Program.currentRole = Convert.ToUInt16(reader["user_role_id"]);
                            MainForm form = new MainForm();
                            form.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Неправильный логин или пароль");
                            return;
                        }
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Hide();
            
        }
    }
}
