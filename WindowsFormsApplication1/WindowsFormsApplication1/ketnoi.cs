﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace buoi9
{
    class ketnoi
    {
        public SqlConnection connect;
        public ketnoi()
        {
            connect = new SqlConnection("Data Source=A209PC42;Initial Catalog=tracnghiem;Integrated Security=True");
        }
        public ketnoi(string strcn)
        {
            connect = new SqlConnection(strcn);
        }
    }
}