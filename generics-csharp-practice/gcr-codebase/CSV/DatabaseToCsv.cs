
using System;
using System.Data.SqlClient;
using System.IO;

class Program {
    static void Main() {
        using(SqlConnection con = new SqlConnection("your_connection")) {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Employees", con);
            SqlDataReader dr = cmd.ExecuteReader();

            using(StreamWriter sw = new StreamWriter("report.csv")) {
                sw.WriteLine("ID,Name,Department,Salary");
                while(dr.Read()) {
                    sw.WriteLine($"{dr[0]},{dr[1]},{dr[2]},{dr[3]}");
                }
            }
        }
    }
}
