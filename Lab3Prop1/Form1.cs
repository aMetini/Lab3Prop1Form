﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3Prop1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (var db = new TBMContext())
            {
                if (db.Database.CanConnect())
                {
                    var stockbalances = db.StockBalances.ToList();

                }
                else Debug.WriteLine("Connection failed!");
            }
        }

    }
}
