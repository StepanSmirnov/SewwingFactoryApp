﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SawingFactory.DAL.Entities;

namespace SawingFactory.Forms
{
    public partial class ManagerForm : BaseMenuForm
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        public ManagerForm(BaseForm baseForm, User user) : base(baseForm, user)
        {
            InitializeComponent();
        }

        private void showProducts(object sender, EventArgs e)
        {
            ShowNestedForm(new ProductsForm());
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            AddMenuItem("Изделия", showProducts);
            AddMenuItem("Остатки продукции", showProducedProducts);
            showProducts(sender, e);
        }

        private void showProducedProducts(object sender, EventArgs e)
        {
            ShowNestedForm(new ProducedProductsForm());
        }
    }
}
