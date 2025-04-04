using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MovieX
{
    public partial class Form1 : Form
    {

        private static List<User> users = new List<User>();

        public Form1()
        {
            InitializeComponent();
            txt2.UseSystemPasswordChar = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string input = txt1.Text;
            string password = txt2.Text;

            User user = users.Find(u => (u.Email == input || u.Username == input) && u.Password == password);
            if (user != null)
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(users);
            form2.Show();
            this.Hide();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt2.UseSystemPasswordChar = true;
            }
            else
            {
                txt2.UseSystemPasswordChar = false;
            }
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class User
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string email, string username, string password)
        {
            Email = email;
            Username = username;
            Password = password;
        }
    }
}