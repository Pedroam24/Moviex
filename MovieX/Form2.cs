using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MovieX
{
    public partial class Form2 : Form
    {
        private List<User> users;

        public Form2(List<User> users)
        {
            InitializeComponent();
            this.users = users;
            txt5.UseSystemPasswordChar = false;
            txt6.UseSystemPasswordChar = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string email = txt3.Text.Trim(); 
            string username = txt4.Text.Trim();
            string password = txt5.Text; 
            string confirmPassword = txt6.Text; 

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Por favor, preencha todos os campos de email e usuário.", "Informação Faltando", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }

            if (users.Exists(u => u.Email == email || u.Username == username))
            {
                MessageBox.Show("Usuário ou email já existe.");
            }

            users.Add(new User(email, username, password));
            MessageBox.Show("Conta criada com sucesso!");

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }


        private void btn4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt5.UseSystemPasswordChar = true;
            }
            else
            {
                txt5.UseSystemPasswordChar = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        { 
        if (checkBox2.Checked)
            {
                txt6.UseSystemPasswordChar = true;
            }
            else
            {
                txt6.UseSystemPasswordChar = false;
            }
            }
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

