using AdExercize.Entities;
using AdExercize.Repos;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Design;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace AdExercize
{
    public partial class FormAdDetails : Form
    {
        private string _connString = "Data Source=localhost;Initial Catalog=AdExercise;" +
             "Integrated Security=SSPI; TrustServerCertificate=True;";



        public FormAdDetails()
        {
            InitializeComponent();
            GetCategories();

        }
        private void GetCategories()
        {
            string sql = "select CategoryName from Category";
            List<String> result;

            using (IDbConnection db = new SqlConnection(_connString))
            {
                result = (List<String>)db.Query<String>(sql);
            }
            comboBoxCN.Items.AddRange(result.ToArray());
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var adDetails = new AdDetails
            {
                AdID = Convert.ToInt32(textBoxAdNumber.Text),
                Title = textBoxTitle.Text,
                Price = Convert.ToInt32(textBoxPrice.Text),
                Description = textBoxDescription.Text,
                CategoryID = Convert.ToInt32(textBoxCategoryID.Text)


            };
            var repo = new AdDetailsRepo();
            repo.Insert(adDetails);

            MessageBox.Show("AdDetails added successfully");

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();
            string searchCategory = comboBoxCN.Text.Trim();

            AdDetailsRepo repo = new AdDetailsRepo();
            List<AdDetails> list = repo.SearchAdDetails(searchText, searchCategory);
            dataGridViewDetails.DataSource = list;
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var adDetails = new AdDetails
            {
                AdID = Convert.ToInt32(textBoxAdNumber.Text),
                Title = textBoxTitle.Text,
                Price = Convert.ToInt32(textBoxPrice.Text),
                Description = textBoxDescription.Text,
                CategoryID = Convert.ToInt32(textBoxCategoryID.Text)


            };
            var repo = new AdDetailsRepo();
            repo.Update(adDetails);
            MessageBox.Show("AdDetails updated successfully");
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var adDetails = new AdDetails
            {
                AdID = Convert.ToInt32(textBoxAdNumber.Text)
            };
            var repo = new AdDetailsRepo();
            repo.Delete(adDetails);
            MessageBox.Show("AdDetails deleted successfully");


        }

        private void dataGridViewDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = dataGridViewDetails.CurrentRow;
            if (currentRow != null)
            { 

                textBoxCategoryID.Text = currentRow.Cells["CategoryID"].Value.ToString();
                textBoxAdNumber.Text = currentRow.Cells["ADID"].Value.ToString();
                textBoxTitle.Text = currentRow.Cells["Title"].Value.ToString();
                textBoxPrice.Text = currentRow.Cells["Price"].Value.ToString();
                textBoxDescription.Text = currentRow.Cells["Description"].Value.ToString();
                
            }


        }
    }

    
}
   
