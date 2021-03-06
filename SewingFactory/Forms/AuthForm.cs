﻿using System;
using System.Data;
using System.Linq;
using SawingFactory.DAL.Entities;
using SawingFactory.Forms;

namespace SawingFactory
{
    public partial class AuthForm : BaseForm
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        public AuthForm(BaseForm baseForm) : base(baseForm)
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new FactoryContext())
            {
                var query = context.Users.Where(u => u.Login == textBox1.Text && u.Password == textBox2.Text);
                if (query.Count() == 0)
                {
                    System.Windows.Forms.MessageBox.Show("Ошибочно введён логин или пароль");
                }
                else
                {
                    switch (query.First().Role)
                    {
                        case User.UserRole.Customer:
                            new CustomerForm(this, query.First()).Open();
                            break;
                        case User.UserRole.Manager:
                            new ManagerForm(this, query.First()).Open();
                            break;
                        case User.UserRole.StoreKeeper:
                            new StoreKeeperForm(this, query.First()).Open();
                            break;
                        case User.UserRole.Director:
                            new DirectorForm(this, query.First()).Open();
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            //Debug code
            using (var context = new FactoryContext())
            {
                var user = context.Users.Where(u => u.RoleId == (int)User.UserRole.StoreKeeper).First();
                textBox1.Text = user.Login;
                textBox2.Text = user.Password;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new RegisterForm(this).Open();
        }
    }
}
