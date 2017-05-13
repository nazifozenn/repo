using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Sd_service
{
    public class Service1 : IService1
    {
        ServiceDeskDBEntities Sd_context = new ServiceDeskDBEntities();

        public int login(string username, string password)
        {
            var users = Sd_context.Users.ToList();
            var user_count = users.Where(u => u.user_name == username && u.user_password == password).Count();

            if (Convert.ToInt32(user_count) < 1)
            {
                return 0;  //if user not exist
            }
            else
            {
                return 1;//if user exist
            }
            
        }
      

        public int create_customer(string customer_name, string customer_surname, string customer_phone, string customer_mail, string customer_adress)
        {
            Customer new_customer = new Customer();
            new_customer.customer_name = customer_name;
            new_customer.customer_surname = customer_surname;
            new_customer.customer_phone = customer_phone;
            new_customer.customer_mail = customer_mail;
            new_customer.customer_adress = customer_adress;

            Sd_context.Customer.Add(new_customer);

            try
            {
                Sd_context.SaveChanges();//1 => success
                return 1;
            }
            catch (Exception)
            {
                return 0;//0 => fail
            }
        }

    

        public CustomerData customer()
        {
            var customers = Sd_context.Customer.ToList();

            List<Customer> list = customers.Select(c => c).ToList();

            DataTable dt = ToDataTable<Customer>(list);

            CustomerData DATA = new CustomerData();

            DATA.CustomersTable = dt;

            return DATA;

        }

        public UserData user()
        {
            var users = Sd_context.Users.ToList();

            List<Users> list = users.Select(c => c).ToList();

            DataTable dt = ToDataTable<Users>(list);

            UserData DATA = new UserData();

            DATA.UserTable = dt;

            return DATA;
        }

        public TaskData task()
        {
            var tasks = Sd_context.Tasks.ToList();

            List<Tasks> list = tasks.Select(c => c).ToList();

            DataTable dt = ToDataTable<Tasks>(list);

            TaskData DATA = new TaskData();

            DATA.TaskTable = dt;

            return DATA;
        }

        public static DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        public int create_task(int customer_id, int users_user_id, string task_product_type, string task_product_name, string task_product_brand, string task_product_serial_number, string task_detail, int status)
        {

            Tasks task = new Tasks();
            task.customer_id = customer_id;
            task.users_user_id = users_user_id;
            task.task_product_type = task_product_type;
            task.task_product_name = task_product_name;
            task.task_product_brand = task_product_brand;
            task.task_product_serial_number = task_product_serial_number;
            task.task_status = status;
            task.task_detail = task_detail;

            Sd_context.Tasks.Add(task);
            try
            {
                Sd_context.SaveChanges();//1 => success
                return 1;
            }
            catch (Exception)
            {

                return 0;//0 => fail
            }
           
        }


        public int update_task(int task_id, int status)
        {

            Tasks task = (from t in Sd_context.Tasks where t.task_id == task_id select t).SingleOrDefault();
       
            task.task_status = status;

            try
            {
                Sd_context.SaveChanges();//1 => success
                return 1;
            }
            catch (Exception)
            {

                return 0;//0 => fail
            }

        }
      
    }
}
