 string connectionString = "User Id=system;Password=***;Data Source=localhost:49161/xe";
 OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                string sql = @"SELECT * FROM TBL_USERS";
                OracleCommand cmd = new OracleCommand(sql, conn);
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show(reader["email"].ToString());
                }
                reader.Close();
            }
