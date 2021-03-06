﻿using SawingFactory.DAL.Entities;
using System;
using System.Windows.Forms;
using System.Linq;

namespace SawingFactory
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        public BaseForm(BaseForm baseForm)
        {
            InitializeComponent();
            PrevForm_ = baseForm;
        }

        public void Back()
        {
            if (PrevForm_ == null) return;
            PrevForm_.Show();
            Hide();
        }

        public void Open()
        {
            if (PrevForm_ == null) return;
            Show();
            PrevForm_.Hide();
        }

        protected BaseForm PrevForm_ { get; set; }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (PrevForm_ == null) return;
            PrevForm_.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Back();
        }
    }
}
