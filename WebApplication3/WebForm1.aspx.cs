using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Web.UI.WebControls;
using System;

namespace WebApplication3
{
    
        public partial class WebForm1 : System.Web.UI.Page
        {

        


        protected void Button1_Click(object sender, System.EventArgs e)
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
            int i = 0;
            while (reader.Read())
            {
                i = i + 1;
                //this.Label1.Text = i.ToString();
                //this.Label1.Text +"<br />"+ reader["authors"].ToString();
            }

            HyperLink[] links = new HyperLink[i];

            //for (int j = 0; j < i; j++)
            //    links[j] = new HyperLink();
            reader.Close();
            MySqlDataReader reader1 = command.ExecuteReader();

            int k = 0;
            while (reader1.Read()) {
                links[k] = new HyperLink();
                hp.Controls.Add(links[k]);
                links[k].Text = reader1["authors"].ToString()+"<br />";
                links[k].ID = "link" + k;
                //links[k].NavigateUrl = "About.aspx";
                links[k].NavigateUrl = "one.aspx?id="+links[k].ID;

               
                k++;
              
            }   
        }
        }
    }