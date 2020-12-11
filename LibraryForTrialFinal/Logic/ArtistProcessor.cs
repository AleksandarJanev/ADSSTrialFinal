using LibraryForTrialFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForTrialFinal.Logic
{
    public static class ArtistProcessor
    {
        public static int CreateArtist(string FirstName, string LastName)
        {
            ArtistModel data = new ArtistModel
            {
                FirstName = FirstName,
                LastName = LastName
            };

            string sql = "INSERT INTO dbo.Artist(FirstName, LastName) VALUES(@FirstName, @LastName)";

            return DataAccess.SqlDataAccess.SaveData(sql, data);
        }


        public static List<ArtistModel> LoadAllArtists()
        {
            string sql = "SELECT * FROM dbo.Artists";

            return DataAccess.SqlDataAccess.LoadData<ArtistModel>(sql);
        }
    }
}
