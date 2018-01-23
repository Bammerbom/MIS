using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS
{
    public class ReviewManager
    {
        /// <summary>
        /// vraagt de review op met het reviewid
        /// </summary>
        /// <param name="reviewid"></param>
        /// <returns>De review</returns>
        public static Review ReviewOpvragen(int reviewid)
        {
            //Create select command
            var cmd = new SQLiteCommand("SELECT * FROM reviews WHERE reviewid = @reviewid", SqlTools.Connection);
            cmd.Parameters.Add("@reviewid", DbType.Int32).Value = reviewid;
            var reader = cmd.ExecuteReader();
            reader.Read();

            //Sla data op in een review struct
            return ReviewVanData(reader);
        }

        /// <summary>
        /// voegt de nieuwe review toe
        /// </summary>
        /// <param name="review"></param>
        /// <returns>het reviewid van de nieuwe review</returns>
        public static int ReviewToevoegen(Review review)
        {
            //Create insert command
            var cmd = new SQLiteCommand("INSERT INTO reviews (reviewedid, reviewerid, rating, title, body) " +
                "VALUES (@reviewedid, @reviewerid, @rating, @title, @body)", SqlTools.Connection);
            cmd = ReviewNaarData(cmd, review);
            cmd.ExecuteNonQuery();

            //Verkrijg reviewid
            return (int)SqlTools.Connection.LastInsertRowId;
        }

        /// <summary>
        /// verwijderd de gebruiker
        /// </summary>
        public static bool ReviewVerwijderen(int reviewid)
        {
            //Create delete command
            var cmd = new SQLiteCommand("DELETE FROM reviews WHERE reviewid = @reviewid", SqlTools.Connection);
            cmd.Parameters.Add("@reviewid", DbType.String).Value = reviewid;
            return cmd.ExecuteNonQuery() > 0;
        }
        
        /// <summary>
        /// vraagt alle reviews op met het reviewedid
        /// </summary>
        /// <param name="reviewedid"></param>
        /// <returns>Een array met alle reviews op een gebruiker</returns>
        public static Review[] ReviewsOppasser(int reviewedid)
        {
            List<Review> reviewlist = new List<Review>();

            var cmd = new SQLiteCommand("SELECT * FROM reviews WHERE reviewedid = @reviewedid", SqlTools.Connection);
            cmd.Parameters.Add("@reviewedid", DbType.Int32).Value = reviewedid;
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                reviewlist.Add(ReviewVanData(reader));
            }
            
            return reviewlist.ToArray();
        }

        public static int BerekenRating(int reviewedid)
        {
            double totaalrating = 0;
            Review[] reviewarray = ReviewsOppasser(reviewedid);

            foreach (var review in reviewarray)
            {
                totaalrating = totaalrating + review.rating;
            }

            if (reviewarray.Count() == 0) return 0;
            return Convert.ToInt32(totaalrating / reviewarray.Count());
        }

        private static Review ReviewVanData(SQLiteDataReader reader)
        {
            return new Review
            {
                reviewid = Convert.ToInt32(reader["reviewid"]),
                reviewedid = Convert.ToInt32(reader["reviewedid"]),
                reviewerid = Convert.ToInt32(reader["reviewerid"]),
                rating = Convert.ToInt32(reader["rating"]),
                title = (string)reader["title"],
                body = (string)reader["body"],
            };
        }

        private static SQLiteCommand ReviewNaarData(SQLiteCommand cmd, Review review)
        {
            cmd.Parameters.Add("@reviewid", DbType.Int32).Value = review.reviewid;
            cmd.Parameters.Add("@reviewedid", DbType.Int32).Value = review.reviewedid;
            cmd.Parameters.Add("@reviewerid", DbType.Int32).Value = review.reviewerid;
            cmd.Parameters.Add("@rating", DbType.Int32).Value = review.rating;
            cmd.Parameters.Add("@title", DbType.String).Value = review.title;
            cmd.Parameters.Add("@body", DbType.String).Value = review.body;
            return cmd;
        }
    }

    public struct Review
    {
        public int reviewid;
        public int reviewedid;
        public int reviewerid;
        public int rating;
        public string title;
        public string body;
    }
}
