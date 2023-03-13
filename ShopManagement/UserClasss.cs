using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ShopManagement
{
     class UserClasss
    {
        SqlConnection con = new SqlConnection("Data Source=PRATHAMESH\\SQLEXPRESS;Initial Catalog=UserManagement01;Integrated Security=True");
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name{ get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }

        public string State{ get; set; }
        public string Password{ get; set; }

        public string Type2 { get; set; }

        public string PhoneNo { get; set; }
        public UserClasss(string Type1, string Name1, string Email1, string Gender1, string State1, string Password1,string PhoneNo1)
        {
            Type = Type1; 
            Name = Name1;
            Email = Email1;
            Gender = Gender1;
            State = State1;
            Password = Password1;
            PhoneNo = PhoneNo1;

        }
        public UserClasss(string Email2, string Password2)
        {
            Email = Email2;
            Password = Password2;
        }
        public UserClasss(string Typecs)
        {
            Type2 = Typecs;
        }

        public void RegisterData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShop_Management", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "RegisterSave");
            cmd.Parameters.AddWithValue("@Type",Type );
            cmd.Parameters.AddWithValue("@Name", Name );
            cmd.Parameters.AddWithValue("@Email",Email);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@State", State);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public SqlDataReader LoginData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShop_Management", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "loginData");
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Password", Password);
            SqlDataReader dt = cmd.ExecuteReader();
            return dt;
            con.Close();

        }
        
        


    }
}
