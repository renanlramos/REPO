﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            using (SqlConnection con = new SqlConnection("Server=AME0556343W10-1\\SQLEXPRESS;Database=db_google;Trusted_Connection=Yes;"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tb_posts", con))
                {
                    con.Open();
                    dtlPosts.DataSource = cmd.ExecuteReader();
                    dtlPosts.DataBind();
                }
            }
        }
    }
}