using Service_Desk.ServiceDesk_service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Service_Desk
{
    public partial class RadForm2 : Telerik.WinControls.UI.RadForm
    {
        public RadForm2()
        {
            InitializeComponent();
        }

        private void RadForm2_Load(object sender, EventArgs e)
        {
            update_grids();

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Service1Client client = new Service1Client();

            var create_control = client.create_customer(name_txt.Text, surname_txt.Text, phone_txt.Text, mail_txt.Text, adress_txt.Text);

            client.Close();

            if (Convert.ToInt32(create_control) == 1)
            {
                MessageBox.Show("Customer was created successfully.");
                name_txt.Clear();
                surname_txt.Clear();
                phone_txt.Clear();
                mail_txt.Clear();
                adress_txt.Clear();
                update_grids();
            }
            else
            {
                MessageBox.Show("An error occured when customer creating.");
            }
        }

        private void customer_grid_SelectionChanged(object sender, EventArgs e)
        {
            if (Program.login_control == 1)
            {
                if (customer_grid.CurrentRow != null)
                {
                    customer_grid.SelectionMode = GridViewSelectionMode.FullRowSelect;
                    GridViewRowInfo row = customer_grid.CurrentRow;

                    customer_name_txt.Text = row.Cells[1].Value.ToString();
                    customer_surname_txt.Text = row.Cells[2].Value.ToString();
                }
            }
        }

        private void save_task_Click(object sender, EventArgs e)
        {
            GridViewRowInfo row = customer_grid.CurrentRow;

            GridViewRowInfo row_user = user_grid.CurrentRow;

            string c_id= row.Cells[0].Value.ToString();

             string u_id= row_user.Cells[0].Value.ToString();

             int status = 0;//status 0 = not Didn't Start, 1 = Started, 2=Finish

            Service1Client client = new Service1Client();

            var task_create_control = client.create_task(Convert.ToInt32(c_id), Convert.ToInt32(u_id), product_type_txt.Text, product_name_txt.Text, product_brand_txt.Text, product_serial_no_txt.Text, detail_txt.Text, status);

            client.Close();

            if (Convert.ToInt32(task_create_control) == 1)
            {
                MessageBox.Show("Task was created successfully.");
                customer_name_txt.Clear();
                customer_surname_txt.Clear();
                product_type_txt.Clear();
                product_name_txt.Clear();
                product_brand_txt.Clear();
                product_serial_no_txt.Clear();
                detail_txt.Clear();
                update_grids();
            }
            else
            {
                MessageBox.Show("An error occured when customer creating.");
            }
        }

        private void task_grid_SelectionChanged(object sender, EventArgs e)
        {
            if (Program.login_control == 1)
            {
                if (task_grid.CurrentRow != null)
                {
                    task_grid.SelectionMode = GridViewSelectionMode.FullRowSelect;
                    GridViewRowInfo row = task_grid.CurrentRow;

                    if (row.Cells[8].Value.ToString()=="0")
                    {
                        status_combo.SelectedIndex = 0;
                    }
                    if (row.Cells[8].Value.ToString() == "1")
                    {
                        status_combo.SelectedIndex = 1;
                    }
                    if (row.Cells[8].Value.ToString() == "2")
                    {
                        status_combo.SelectedIndex = 2;
                    }
                    
                }
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            Service1Client client = new Service1Client();
            task_grid.SelectionMode = GridViewSelectionMode.FullRowSelect;
            GridViewRowInfo row = task_grid.CurrentRow;

            var task_update_control = client.update_task(Convert.ToInt32(row.Cells[0].Value.ToString()),status_combo.SelectedIndex);

            client.Close();
            if (Convert.ToInt32(task_update_control) == 1)
            {
                MessageBox.Show("Task was updated successfully.");
                update_grids();
            }
            else
            {
                MessageBox.Show("An error occured when customer creating.");
            }

        }

        public void update_grids()
        {
            Service1Client client = new Service1Client();

            DataTable dt = new DataTable();
            dt = client.customer().CustomersTable;
            customer_grid.DataSource = dt;

            DataTable dt_user = new DataTable();
            dt_user = client.user().UserTable;
            user_grid.DataSource = dt_user;

            DataTable dt_task = new DataTable();
            dt_task = client.task().TaskTable;
            task_grid.DataSource = dt_task;
        }
    }
}
