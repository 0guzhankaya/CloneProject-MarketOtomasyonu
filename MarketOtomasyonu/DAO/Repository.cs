using MarketOtomasyonu.Enumarations;
using MarketOtomasyonu.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu.DAO
{
    // Veritabanı ile iletişime geçen classtır.
    public class Repository
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        int returnValue;
        List<LoginTable> loginTableList;

        public Repository()
        {
            connection = new SqlConnection("Data Source=OGUZHANKAYA;Initial Catalog=MarketOtomasyonDB;Integrated Security=True;TrustServerCertificate=True");
        }

        public void configureConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            else
            {
                connection.Close();
            }
        }

        public User login(string username, string password)
        {
            connection.Open();

            command = new SqlCommand("SELECT * FROM tbl_Login WHERE UserName = @username AND Password = @password", connection);
            command.Parameters.AddWithValue("UserName", username);
            command.Parameters.AddWithValue("Password", password);
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                User user = new User();
                user.Id = int.Parse(reader["Id"].ToString());
                user.Name = reader["Name"].ToString();
                user.Surname = reader["Surname"].ToString();
                user.UserName = reader["UserName"].ToString();
                user.Password = reader["Password"].ToString();
                user.Authory = reader["Authory"].ToString();
                user.Email = reader["email"].ToString();
                user.SecurityQuestion = reader["SecurityQuestion"].ToString();
                user.SecurityAnswer = reader["SecurityAnswer"].ToString();
                user.status = LoginStatus.SUCCESS;
                return user;
            }
            else
            {
                User user = new User();
                user.status = LoginStatus.UNSUCCESS;
                return user;
            }

        }

        public List<LoginTable> getLoginTable()
        {
            loginTableList = new List<LoginTable>();

            try
            {
                connection.Open();

                command = new SqlCommand("securityQuestion_sp", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                reader = command.ExecuteReader();

                // Veritabanından gelen verileri okuyup, ilgili Model class'ına atıyor.
                while (reader.Read())
                {
                    LoginTable loginTable = new LoginTable();
                    loginTable.Id = int.Parse(reader["Id"].ToString());
                    loginTable.Name = reader["Name"].ToString();
                    loginTable.Surname = reader["Surname"].ToString();
                    loginTable.UserName = reader["UserName"].ToString();
                    loginTable.Password = reader["Password"].ToString();
                    loginTable.Authory = reader["Authory"].ToString();
                    loginTable.Email = reader["Email"].ToString();
                    loginTable.SecurityQuestion = reader["SecurityQuestion"].ToString();
                    loginTable.SecurityAnswer = reader["SecurityAnswer"].ToString();
                    loginTableList.Add(loginTable);
                }
                connection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Hata\n" + e.StackTrace);
            }

            return loginTableList;
        }

        public LoginStatus doAuthentication(string username, string securityquestion, string securityanswer)
        {
            connection.Open();

            command = new SqlCommand("SELECT COUNT(*) FROM tbl_Login WHERE username=@UserName AND securityquestion=@SecurityQuestion AND securityanswer=@SecurityAnswer", connection);
            command.Parameters.AddWithValue("@UserName", username);
            command.Parameters.AddWithValue("@SecurityQuestion", securityquestion);
            command.Parameters.AddWithValue("@SecurityAnswer", securityanswer);

            returnValue = (int)command.ExecuteScalar();

            connection.Close();

            if (returnValue == 1)
                return LoginStatus.SUCCESS;
            else
                return LoginStatus.UNSUCCESS;

        }

        public LoginStatus changePassword(string username, string password)
        {
            connection.Open();

            command = new SqlCommand("updatePassword_sp", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            returnValue = command.ExecuteNonQuery();

            connection.Close();

            return LoginStatus.SUCCESS;
        }

        // Email açığı
        public string checkEmailAddress(string username)
        {
            connection.Open();
            command = new SqlCommand("SELECT Email FROM tbl_Login WHERE username=@UserName", connection);
            command.Parameters.AddWithValue("@UserName", username);
            string emailAddress = (string)command.ExecuteScalar();

            connection.Close();

            return emailAddress;
        }

        public Product getProduct(string barcode)
        {
            connection.Open();

            command = new SqlCommand("SELECT * FROM tbl_Product WHERE Barcode = @Barcode", connection);
            command.Parameters.AddWithValue("@Barcode", barcode);
            reader = command.ExecuteReader();

            Product product = new Product();

            while (reader.Read())
            {
                product.Id = reader["Id"].ToString();
                product.QRCode = reader["QRCode"].ToString();
                product.Barcode = reader["Barcode"].ToString();
                //product.CreationDate = DateTime.Parse(reader["CreationDate"].ToString());
                //product.UpdateDate = DateTime.Parse(reader["UpdateDate"].ToString());
                product.ProductName = reader["ProductName"].ToString();
                product.Kilogram = int.Parse(reader["Kilogram"].ToString());
                product.Price = int.Parse(reader["Price"].ToString());
                //product.Endorsement = int.Parse(reader["Endorsement"].ToString());
            }
            connection.Close();

            return product;
        }

        public List<User> getAllUsers()
        {
            List<User> usersList = new List<User>();

            connection.Open();

            command = new SqlCommand("SELECT * FROM tbl_Login", connection);
            reader = command.ExecuteReader();

            User user = new User();

            while (reader.Read())
            {
                user.Id = int.Parse(reader["Id"].ToString());
                user.Name = reader["Name"].ToString();
                user.Surname = reader["Surname"].ToString();
                user.UserName = reader["UserName"].ToString();
                //user.Password = reader["Password"].ToString();
                user.Authory = reader["Authory"].ToString();
                user.Email = reader["Email"].ToString();
                user.SecurityQuestion = reader["SecurityQuestion"].ToString();
                user.SecurityAnswer = reader["SecurityAnswer"].ToString();
                usersList.Add(user);
            }

            connection.Close();

            return usersList;
        }

        public LoginStatus addUser(User user)
        {
            connection.Open();

            command = new SqlCommand("addUser_sp", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@name", user.Name);
            command.Parameters.AddWithValue("@surname", user.Surname);
            command.Parameters.AddWithValue("@username", user.UserName);
            command.Parameters.AddWithValue("@password", user.Password);
            command.Parameters.AddWithValue("@authory", user.Authory);
            command.Parameters.AddWithValue("@email", user.Email);
            command.Parameters.AddWithValue("@securityquestion", user.SecurityQuestion);
            command.Parameters.AddWithValue("@securityanswer", user.SecurityAnswer);

            int returnValue = command.ExecuteNonQuery();

            connection.Close();

            if (returnValue == 1)
            {
                return LoginStatus.SUCCESS;
            }
            else
                return LoginStatus.UNSUCCESS;

        }

        public LoginStatus updateUser(User user)
        {
            connection.Open();
            command = new SqlCommand("updateUser_sp", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", user.Id);
            command.Parameters.AddWithValue("@name", user.Name);
            command.Parameters.AddWithValue("@surname", user.Surname);
            command.Parameters.AddWithValue("@username", user.UserName);
            command.Parameters.AddWithValue("@password", user.Password);
            command.Parameters.AddWithValue("@authory", user.Authory);
            command.Parameters.AddWithValue("@email", user.Email);
            command.Parameters.AddWithValue("@securityquestion", user.SecurityQuestion);
            command.Parameters.AddWithValue("@securityanswer", user.SecurityAnswer);

            int resultValue = command.ExecuteNonQuery();

            connection.Close();

            if (returnValue == 1)
            {
                return LoginStatus.SUCCESS;
            }
            return LoginStatus.UNSUCCESS;
        }

        public LoginStatus deleteUser(int id)
        {
            connection.Open();
            command = new SqlCommand("DELETE FROM tbl_Login WHERE Id=@id", connection);
            command.Parameters.AddWithValue("@id", id);
            int returnValue = command.ExecuteNonQuery();

            connection.Close();

            if (returnValue == 1)
            {
                return LoginStatus.SUCCESS;
            }
            else
            {
                return LoginStatus.UNSUCCESS;
            }
        }

        public List<Product> getAllProducts()
        {
            List<Product> productsList = new List<Product>();
            connection.Open();

            command = new SqlCommand("SELECT * FROM tbl_Product", connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                Product product = new Product();
                product.Id = reader["Id"].ToString();
                product.QRCode = reader["QRCode"].ToString();
                product.Barcode = reader["Barcode"].ToString();
                product.CreationDate = DateTime.Parse(reader["CreationDate"].ToString());

                if (!string.IsNullOrEmpty(reader["UpdateDate"].ToString()))
                {
                    product.UpdateDate = DateTime.Parse(reader["UpdateDate"].ToString());
                }

                product.ProductName = reader["ProductName"].ToString();
                product.Kilogram = int.Parse(reader["Kilogram"].ToString());
                product.Price = int.Parse(reader["Price"].ToString());

                if (!string.IsNullOrEmpty(reader["Endorsement"].ToString()))
                {
                    product.Endorsement = int.Parse(reader["Endorsement"].ToString());
                }

                productsList.Add(product);
            }
            connection.Close();
            return productsList;
        }

        public LoginStatus addProduct(Product product)
        {
            connection.Open();

            command = new SqlCommand("addProduct_sp", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id", product.Id);
            command.Parameters.AddWithValue("@qrcode", product.QRCode);
            command.Parameters.AddWithValue("@barcode", product.Barcode);
            command.Parameters.AddWithValue("@creationdate", product.CreationDate);
            command.Parameters.AddWithValue("@updatedate", product.UpdateDate);
            command.Parameters.AddWithValue("@productname", product.ProductName);
            command.Parameters.AddWithValue("@kilogram", product.Kilogram);
            command.Parameters.AddWithValue("@price", product.Price);
            command.Parameters.AddWithValue("@endorsement", product.Endorsement);
            int returnValue = command.ExecuteNonQuery();

            connection.Close();

            if (returnValue == 1)
            {
                return LoginStatus.SUCCESS;
            }
            return LoginStatus.UNSUCCESS;
        }

        public LoginStatus updateProduct(Product product)
        {
            connection.Open();
            command = new SqlCommand("updateProduct_sp", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id", product.Id);
            command.Parameters.AddWithValue("@qrcode", product.QRCode);
            command.Parameters.AddWithValue("@barcode", product.Barcode);
            command.Parameters.AddWithValue("@creationdate", product.CreationDate);
            command.Parameters.AddWithValue("@updatedate", product.UpdateDate);
            command.Parameters.AddWithValue("@productname", product.ProductName);
            command.Parameters.AddWithValue("@kilogram", product.Kilogram);
            command.Parameters.AddWithValue("@fiyat", product.Price);
            command.Parameters.AddWithValue("@endorsement", product.Endorsement);
            int returnValue = command.ExecuteNonQuery();

            connection.Close();

            if (returnValue == 1)
            {
                return LoginStatus.SUCCESS;
            }
            else
                return LoginStatus.UNSUCCESS;
        }

        public LoginStatus deleteProduct(string id)
        {
            connection.Open();
            command = new SqlCommand("DELETE FROM tbl_Product WHERE Id = @id", connection);

            command.Parameters.AddWithValue("@id", id);
            int returnValue = command.ExecuteNonQuery();
            connection.Close();

            if (returnValue == 1)
            {
                return LoginStatus.SUCCESS;
            }
            return LoginStatus.UNSUCCESS;
        }
    }
}
