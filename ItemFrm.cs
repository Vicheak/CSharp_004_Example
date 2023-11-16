using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Item_CRUD_practice
{
    public partial class ItemFrm : Form
    {
        protected SqlConnection connection = 
            new SqlConnection(@"Data Source=localhost\SQLEXPRESS; Initial Catalog=PhoneStore; Integrated Security=True;");

        protected DataSet dataSet = new DataSet();

        protected SqlCommand[] commands = new SqlCommand[2];

        protected SqlDataAdapter itemAdapter = new SqlDataAdapter();
        protected BindingSource itemBindingSource = new BindingSource();

        protected SqlDataAdapter categoryAdapter = new SqlDataAdapter(); 
        protected BindingSource categoryBindingSource = new BindingSource();

        protected SqlDataAdapter brandAdapter = new SqlDataAdapter();
        protected BindingSource brandBindingSource = new BindingSource(); 

        public ItemFrm()
        {
            InitializeComponent();
        }

        private void ItemFrm_Load(object sender, EventArgs e)
        {
            lblValue.Text = string.Empty;

            commands[0] = new SqlCommand("SELECT * FROM VItemList;", connection);
            commands[1] = new SqlCommand
            {
                CommandText = "FindItems",
                CommandType = CommandType.StoredProcedure,
                Connection = connection
            };
            commands[1].Parameters.Add("@Find", SqlDbType.VarChar, 50).Direction = ParameterDirection.Input;

            itemAdapter.SelectCommand = commands[0];

            itemAdapter.InsertCommand = 
                new SqlCommand("INSERT Items VALUES (@ItemName, @CategoryId, @BrandId);" +
                "SELECT * FROM VItemList WHERE ItemId = @@IDENTITY;", connection);
            itemAdapter.InsertCommand.Parameters.Add("@ItemName", SqlDbType.VarChar, 50, "ItemName");
            itemAdapter.InsertCommand.Parameters.Add("@CategoryId", SqlDbType.Int, 0, "CategoryId");
            itemAdapter.InsertCommand.Parameters.Add("@BrandId", SqlDbType.Int, 0, "BrandId");

            itemAdapter.UpdateCommand =
                new SqlCommand("UPDATE Items SET ItemName = @ItemName, CategoryId = @CategoryId, BrandId = @BrandId " +
                "WHERE ItemId = @ItemId; SELECT * FROM VItemList WHERE ItemId = @ItemId;", connection);
            itemAdapter.UpdateCommand.Parameters.Add("@ItemName", SqlDbType.VarChar, 50, "ItemName");
            itemAdapter.UpdateCommand.Parameters.Add("@CategoryId", SqlDbType.Int, 0, "CategoryId");
            itemAdapter.UpdateCommand.Parameters.Add("@BrandId", SqlDbType.Int, 0, "BrandId");
            itemAdapter.UpdateCommand.Parameters.Add("@ItemId", SqlDbType.Int, 0, "ItemId");

            itemAdapter.DeleteCommand =
                new SqlCommand("DELETE Items WHERE ItemId = @ItemId;", connection);
            itemAdapter.DeleteCommand.Parameters.Add("@ItemId", SqlDbType.Int, 0, "ItemId");

            itemAdapter.TableMappings.Add("Table", "Items"); 
            itemAdapter.Fill(dataSet);

            //define primary key for data table of table item
            var itemTable = dataSet.Tables["Items"];
            itemTable.PrimaryKey = new DataColumn[]
            {
                itemTable.Columns["ItemId"]
            };

            itemBindingSource.DataSource = dataSet;
            itemBindingSource.DataMember = "Items";

            dataGridViewShowItemInfo.DataSource = itemBindingSource;

            categoryAdapter.SelectCommand = new SqlCommand("SELECT * FROM Categories;", connection);
            brandAdapter.SelectCommand = new SqlCommand("SELECT * FROM Brands;", connection);

            categoryAdapter.TableMappings.Add("Table", "Categories"); 
            categoryAdapter.Fill(dataSet);
            brandAdapter.TableMappings.Add("Table", "Brands");
            brandAdapter.Fill(dataSet);

            categoryBindingSource.DataSource = dataSet;
            categoryBindingSource.DataMember = "Categories";
            brandBindingSource.DataSource = dataSet;
            brandBindingSource.DataMember = "Brands"; 

            cbCategory.DataSource = categoryBindingSource;
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryId"; 
            cbBrand.DataSource = brandBindingSource;
            cbBrand.DisplayMember = "BrandName";
            cbBrand.ValueMember = "BrandId";

            //bind to controls
            txtItemId.DataBindings.Add("Text", itemBindingSource, "ItemId");
            txtItemName.DataBindings.Add("Text", itemBindingSource, "ItemName");
            cbCategory.DataBindings.Add("SelectedValue", itemBindingSource, "CategoryId");
            cbBrand.DataBindings.Add("SelectedValue", itemBindingSource, "BrandId"); 
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            lblValue.Text = "-- Auto As Identity --";

            //access data row
            var currentRow = itemBindingSource.Current as DataRowView;
            if(currentRow != null)
            {
                if ((int)currentRow.Row["ItemId"] == -1)
                {
                    MessageBox.Show("Please fill in the information!",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
            }

            var newRow = itemBindingSource.AddNew() as DataRowView; 

            if (newRow != null)
            {
                newRow.Row["ItemId"] = -1;
            }

            //set default for combo box
            cbCategory.SelectedIndex = 0;
            cbBrand.SelectedIndex = 0; 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemName.Text))
            {
                MessageBox.Show("Please type in item name",
                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtItemName.Focus();
                return; 
            }

            lblValue.Text = string.Empty;

            //save data to data set 
            itemBindingSource.EndEdit();

            //save data to data source
            itemAdapter.Update(dataSet, "Items"); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblValue.Text = string.Empty; 

            itemBindingSource.CancelEdit();

            //reject changes from data set 
            dataSet.RejectChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //access current data row
            var currentRow = itemBindingSource.Current as DataRowView;

            string expression = string.IsNullOrEmpty(currentRow.Row["ItemName"].ToString()) ? 
                string.Empty : $"with item name {currentRow.Row["ItemName"]}";

            //check confirmation
            DialogResult result = MessageBox.Show($"Are you sure to want to remove the record {expression}?",
                "Confirmation", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                itemBindingSource.RemoveCurrent();

                btnSave.PerformClick();

                lblValue.Text = string.Empty;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblValue.Text = string.Empty;

            dataSet.Tables["Items"].Clear();
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                itemAdapter.SelectCommand = commands[0];
            }
            else
            {
                itemAdapter.SelectCommand = commands[1];
                commands[1].Parameters["@Find"].Value = txtSearch.Text;
            }
            itemAdapter.Fill(dataSet, "Items");
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSearch.PerformClick();
            }
        }
    }
}
