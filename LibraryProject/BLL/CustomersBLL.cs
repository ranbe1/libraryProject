using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class CustomersBLL
    {

        public Customer Verify_Login(string Username, string Password)
        {
            CustomersDAL objdal = new CustomersDAL();
            DataTable dt =  objdal.Login(Username, Password);
            Customer customer;

            if (dt.Rows.Count > 0)
            {
                customer = new Customer(dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(),
                    dt.Rows[0][3].ToString(), Convert.ToChar(dt.Rows[0][4].ToString())/*[0]*/, (int)dt.Rows[0][5]);
                return customer;
            }
            return null;
        }

        public bool Register(string Name,string Username, string Password)
        {
            Boolean isRegistered = false;
            CustomersDAL objdal = new CustomersDAL();
          
                if (!objdal.checkExistCust(Username))
                {

                    if (objdal.Register(Name, Username, Password) > 0)
                        isRegistered = true;

                }
                return isRegistered;
        }

        public int DeleteAcc(string Username)
        {
            CustomersDAL objdal = new CustomersDAL();

            if (!objdal.checkExistCust(Username))
                return 1; //not exist
            else
            {
                if (objdal.DeleteAcc(Username))
                    return 0;
                else
                    return 2;
            }
        }

        public int AddAdmin(string Username)
        {
            CustomersDAL objdal = new CustomersDAL();

            if (!objdal.checkExistCust(Username))
                return 1; //not exist
            else
            {
                if (objdal.AddAdmin(Username))
                    return 0;
                else
                    return 2;
            }
        }

        public void updateLoans(string Username)
        {
            CustomersDAL objdal = new CustomersDAL();

            objdal.UpdateLoans(Username);
        }

    }
}
