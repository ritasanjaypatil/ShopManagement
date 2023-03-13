using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ShopManagement
{
    class ProductClass
    {
        SqlConnection con = new SqlConnection("Data Source=PRATHAMESH\\SQLEXPRESS;Initial Catalog=UserManagement01;Integrated Security=True");
        public int TypeId { get; set; }
        public string TypeName { get; set; }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int SizeId { get; set; }
        public string SizeName { get; set; }
        public string Size { get; set; }
        public int MRP { get; set; }
        public int RealPrice { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }
        public string UserDiscount { get; set; }

        public ProductClass()
        {

        }
        public ProductClass(int UserId1, int SizeId1, string status1, string Discount1)
        {
            UserId = UserId1;
            SizeId = SizeId1;
            Status = status1;
            UserDiscount = Discount1;

        }

        public ProductClass(int Id)
        {
            TypeId = Id;
        }
        public ProductClass(string tName)
        {
            TypeName = tName;
        }
        public ProductClass(int tId, string pName)
        {
            TypeId = tId;
            ProductName = pName;
        }
        public ProductClass(int tId, int pId, string size, int mrp, int Rprice)
        {
            TypeId = tId;
            ProductId = pId;
            Size = size;
            MRP = mrp;
            RealPrice = Rprice;

        }
        public ProductClass(int SizeId2, int UserId2,string Discount2)
        {
            UserDiscount = Discount2;
            UserId = UserId2;
            SizeId = SizeId2;
        }
        public void SaveType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShop_Management", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveType");
            cmd.Parameters.AddWithValue("@Typename", TypeName);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public DataTable GetType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShop_Management", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetType");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }
        public void SaveProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShop_Management", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveProduct");
            cmd.Parameters.AddWithValue("@TypeId", TypeId);
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public DataTable GetProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShop_Management", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetProduct");
            cmd.Parameters.AddWithValue("@TypeId", TypeId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public void SaveSize()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SPShop_Management", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveSize");
            cmd.Parameters.AddWithValue("@TypeId", TypeId);
            cmd.Parameters.AddWithValue("@ProductId", ProductId);
            cmd.Parameters.AddWithValue("@Size", Size);
            cmd.Parameters.AddWithValue("@MRP", MRP);
            cmd.Parameters.AddWithValue("@RealPrice", RealPrice);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public DataTable GetSize()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShop_Management", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetSize");
            cmd.Parameters.AddWithValue("@ProductId", TypeId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public SqlDataReader GetPrice()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShop_Management", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetPrice");
            cmd.Parameters.AddWithValue("@SizeId", TypeId);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }
        public void OrderConfirmed()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShop_Management", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "OrderConfirmed");
            cmd.Parameters.AddWithValue("@UserId", UserId);
            cmd.Parameters.AddWithValue("@SizeId", SizeId);
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@Updated ", UserDiscount);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public DataTable OrderProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShop_Management", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "OrderDetails");

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();

        }
        public DataTable SearchName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShop_Management", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SearchName");
            cmd.Parameters.AddWithValue("@Name", TypeName);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();


        }
        public DataTable SearchProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShop_Management", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SearchProduct");
            cmd.Parameters.AddWithValue("@ProductName", TypeName);


            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public void UpdateDiscount()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShop_Management", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateDiscount");
            cmd.Parameters.AddWithValue("@SizeId", SizeId);
            cmd.Parameters.AddWithValue("@UserId", UserId);
            cmd.Parameters.AddWithValue("@Updated ", UserDiscount);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public DataTable AllData1()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShop_Management", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetAllData");

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable UnorderProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShop_Management", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UnorderProduct");

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable UnorderCustomer()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShop_Management", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UnorderCustomer");

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public void  DeleteData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPShop_Management", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "DeleteData");
            cmd.Parameters.AddWithValue("@OrderId", TypeId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

        
    }
