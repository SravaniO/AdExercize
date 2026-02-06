using AdExercize.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdExercize.Repos
{
    public class AdDetailsRepo
    {
        private string _connString = "Data Source=localhost;Initial Catalog=AdExercise;" +
            "Integrated Security=SSPI; TrustServerCertificate=True;";
        

        public void Insert(AdDetails adDetails)
        {
            using (IDbConnection db = new SqlConnection(_connString))
            {
                db.Open();

                var parameters = new DynamicParameters();
                parameters.Add("@AdID", adDetails.AdID);
                parameters.Add("@Title", adDetails.Title);
                parameters.Add("@Price", adDetails.Price);
                parameters.Add("@Description", adDetails.Description);
                parameters.Add("@CategoryID", adDetails.CategoryID);


                db.Execute("Insert_AdDetails", parameters,
                        commandType: CommandType.StoredProcedure
                    );
            }
        }

        public void Update(AdDetails adDetails)
        {

            using (IDbConnection db = new SqlConnection(_connString))
            {
                db.Open();

                var parameters = new DynamicParameters();
                parameters.Add("@AdID", adDetails.AdID);
                parameters.Add("@Title", adDetails.Title);
                parameters.Add("@Price", adDetails.Price);
                parameters.Add("@Description", adDetails.Description);
                parameters.Add("@CategoryID", adDetails.CategoryID);

                db.Execute("Update_AdDetails", parameters,
                        commandType: CommandType.StoredProcedure
                    );
            }
        }

        public void Delete(AdDetails adDetails)
        {

            using (IDbConnection db = new SqlConnection(_connString))
            {
                db.Open();

                var parameters = new DynamicParameters();
                parameters.Add("@AdID", adDetails.AdID);
                parameters.Add("@Title", adDetails.Title);
                parameters.Add("@Price", adDetails.Price);
                parameters.Add("@Description", adDetails.Description);
                parameters.Add("@CategoryID", adDetails.CategoryID);


                db.Execute("Delete_AdDetails", parameters,
                        commandType: CommandType.StoredProcedure
                    );
            }
        }

        public List<AdDetails> SearchAdDetails(string searchText, string Category)
        {
            using (IDbConnection db = new SqlConnection(_connString))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@SearchText", searchText.Trim());
                parameters.Add("@categoryName", Category.Trim());


                List<AdDetails> list = db.Query<AdDetails>("Search_AdDetails", parameters,
                    commandType: CommandType.StoredProcedure).ToList();

                return list;
            }
        }
    }
}
                

               

            

        
