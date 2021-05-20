using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managing_Car_Program
{
    class MSDBHelper
    {

        public static void DBConnect()
        {

            try

                {

                    SqlConnection DataBaseConnection = new SqlConnection();

                     DataBaseConnection.ConnectionString =

                        "Server = 192.168.51.44,1433; database = car_manager; uid = DG2; pwd = 1126";

                    //DB연결

                    DataBaseConnection.Open();

                    MessageBox.Show("데이터베이스에 연결하였습니다.", "Information");

                    //DB닫기

                    DataBaseConnection.Close();

                }

                catch (SqlException ex)

                {

                    MessageBox.Show(ex.Message, "Information");

                }

        }

       


    }
}
