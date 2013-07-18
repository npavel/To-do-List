using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using WindowsFormsApplication1.Mapping;
using WindowsFormsApplication1.Domain;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Customers customer1 = new Customers { Name = "Name 1", status = true },
                      customer2 = new Customers { Name = "Name 2", status = false };
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var trans = session.BeginTransaction())
                {
                    session.Save(customer1);
                    session.Save(customer2);
                    trans.Commit();
                }
            }
        }
    }
}
