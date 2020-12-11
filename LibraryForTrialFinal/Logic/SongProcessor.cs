using LibraryForTrialFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForTrialFinal.Logic
{
    public static class SongProcessor
    {
        public static int CreateSong(string SongName, string SongLength)
        {
            SongModel data = new SongModel
            {
                SongName = SongName,
                SongLength = SongLength
            };

            string sql = "INSERT INTO dbo.Songs(SongName, SongLength) VALUES(@SongName, @SongLength)";

            return DataAccess.SqlDataAccess.SaveData(sql, data);
        }

        public static List<SongModel> LoadSongs()
        {
            string sql = "SELECT * FROM dbo.Songs";

            return DataAccess.SqlDataAccess.LoadData<SongModel>(sql);
        }
    }
}
