using MarketOtomasyonu.DAO;
using MarketOtomasyonu.Enumarations;
using MarketOtomasyonu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Controllers
{
    public class Controller
    {
        Repository repository;

        public Controller()
        {
            repository = new Repository();
        }

        public User login(string username, string password)
        {
            User result;
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                result = repository.login(username, password);

                return result;
            }
            else
            {
                User user = new User();
                user.status = LoginStatus.MISSING_PARAMETER;
                return user;
            }

        }

        public List<LoginTable> getLoginTable()
        {
            List<LoginTable> loginTableList = repository.getLoginTable();
            return loginTableList;
        }

        public LoginStatus doAuthentication(string username, string securityquestion, string securityanswer)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(securityquestion) && !string.IsNullOrEmpty(securityanswer))
            {
                LoginStatus result = repository.doAuthentication(username, securityquestion, securityanswer);

                if (result == LoginStatus.SUCCESS)
                {
                    return result;
                }
                else
                {
                    return LoginStatus.UNSUCCESS;
                }
            }
            else
            {
                return LoginStatus.MISSING_PARAMETER;
            }
        }

        public LoginStatus changePassword(string username, string password)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                return repository.changePassword(username, password);
            }
            else
            {
                return LoginStatus.MISSING_PARAMETER;
            }
        }

        public string checkEmailAddress(string username)
        {
            return repository.checkEmailAddress(username);
        }

        public Product getProduct(string barcode)
        {
            if (!string.IsNullOrEmpty(barcode))
            {
                return repository.getProduct(barcode);
            }
            return null;
        }

        public List<User> getAllUsers()
        {
            return repository.getAllUsers();
        }

        public LoginStatus addUser(User user)
        {
            if (!string.IsNullOrEmpty(user.UserName) && !string.IsNullOrEmpty(user.Password) && !string.IsNullOrEmpty(user.Authory) && !string.IsNullOrEmpty(user.Email) && !string.IsNullOrEmpty(user.SecurityQuestion) && !string.IsNullOrEmpty(user.SecurityAnswer))
            {
                LoginStatus result = repository.addUser(user);
                return result;
            }
            return LoginStatus.MISSING_PARAMETER;
        }

        public LoginStatus updateUser(User user)
        {
            return repository.updateUser(user);
        }

        public LoginStatus deleteUser(int id)
        {
            if (!string.IsNullOrEmpty(id.ToString()))
            {
                return repository.deleteUser(id);
            }
            else
            {
                return LoginStatus.MISSING_PARAMETER;
            }
        }

        public List<Product> getAllProducts()
        {
            return repository.getAllProducts();
        }

        public LoginStatus addProduct(Product product)
        {
            if (!string.IsNullOrEmpty(product.Id) && !string.IsNullOrEmpty(product.ProductName) && !string.IsNullOrEmpty(product.Barcode))
            {
                return repository.addProduct(product);
            }
            else
                return LoginStatus.MISSING_PARAMETER;
        }

        public LoginStatus updateProduct(Product product)
        {
            if (!string.IsNullOrEmpty(product.Id) && !string.IsNullOrEmpty(product.ProductName) && !string.IsNullOrEmpty(product.Barcode))
            {
                return repository.updateProduct(product);
            }
            else
                return LoginStatus.MISSING_PARAMETER;
        }

        public LoginStatus deleteProduct(int id)
        {
            if (!string.IsNullOrEmpty(id.ToString()))
            {
                return repository.deleteProduct(id.ToString());
            }
            else
            {
                return LoginStatus.MISSING_PARAMETER;
            }
        }
    }
}
