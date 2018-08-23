using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication3
{
    public partial class one : System.Web.UI.Page
    {
        Label label = new Label();
        protected void Page_Load(object sender, EventArgs e)
        {
            string connstring = "Server=localhost;Database=book;Uid=root;Pwd=root";
            MySqlConnection conn = new MySqlConnection(connstring);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "select distinct(authors) from books order by authors asc";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            MySqlDataReader reader = command.ExecuteReader();

            //HyperLink ph = sender as HyperLink;
            string id = Request.QueryString["id"];
            string name;
            // Console.WriteLine("ID is......."+id);
            int l = 0;
            string str;
            while (l != 78)
            {
                str = "link" + l;
                if (id == str)
                {
                    for (int i = 1; i < l+2; i++)
                    {
                        reader.Read();

                        name = reader["authors"].ToString();
                        //this.Controls.Add(label);
                        command.CommandText = "select title from books where authors= '" + name + "' ";
                    }


                    reader.Close();
                    MySqlDataReader reader1 = command.ExecuteReader();
                    while (reader1.Read())
                    {
                        label.Text = label.Text + "<br />" + reader1["title"].ToString();
                        this.Controls.Add(label);
                    }
                    break;
                }
                l++;
            }
           
        }
    }
}