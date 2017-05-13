using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Sd_service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        int login(string username, string password);

        [OperationContract]
        int create_customer(string customer_name, string customer_surname, string customer_phone, string customer_mail, string customer_adress);

         [OperationContract]
         CustomerData customer();

         [OperationContract]
         UserData user();

         [OperationContract]
         TaskData task();


         [OperationContract]
         int create_task(int customer_id, int users_user_id, string task_product_type, string task_product_name, string task_product_brand, string task_product_serial_number, string task_detail, int status);

         [OperationContract]
         int update_task(int task_id,int status);

      

    }

    [DataContract]
    public class CustomerData
    {
        public CustomerData()
        {
            this.CustomersTable = new DataTable("CustomersData");
        }

        [DataMember]
        public DataTable CustomersTable { get; set; }
    }

    [DataContract]
    public class UserData
    {
        public UserData()
        {
            this.UserTable = new DataTable("UserData");
        }

        [DataMember]
        public DataTable UserTable { get; set; }
    }

    public class TaskData
    {
        public TaskData()
        {
            this.TaskTable = new DataTable("TaskData");
        }

        [DataMember]
        public DataTable TaskTable { get; set; }
    }
   



}
