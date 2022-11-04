using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunStok
{
    internal class userManager : IUser<UserClass>
    {
        SqlConnection conn;
        SqlDataAdapter adapter;
        DataTable dt;
        SqlCommand cmd;
        public userManager()
        {
            conn = new SqlConnection();
            conn.ConnectionString = "Server=DESKTOP-LKOHK1C;Database=stok;Trusted_Connection=True;";
        }

        public void CreateUser(UserClass obj)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "Insert Into userInfo(userName,user_password,email,nickName,kisiSepetTutari,kisiSepetUrunSayisi) Values(@uName,@uPassword,@email,@nick,@sepetTutari,@urunSayisi)";
            cmd.Parameters.AddWithValue("@uName", obj.userName);
            cmd.Parameters.AddWithValue("@uPassword", obj.password);
            cmd.Parameters.AddWithValue("@email", obj.email);
            cmd.Parameters.AddWithValue("@nick", obj.nickName);
            cmd.Parameters.AddWithValue("@sepetTutari", 0);
            cmd.Parameters.AddWithValue("@urunSayisi", 0);

            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
