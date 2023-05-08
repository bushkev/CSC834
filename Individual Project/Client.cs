using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Individual_Project
{
    class Client
    {
        private int _clientID;
        private string _firstName;
        private string _lastName;
        private string _fullName;
        private int _teamID;
        private bool _isManager;
        private bool _isCredentialsGood;
        private List<TeamMember> _teamMembers;

        public int ClientID { get => _clientID; }
        public string FirstName { get => _firstName; }
        public string LastName { get => _lastName; }
        public string FullName { get => _fullName; }
        public bool IsManager { get => _isManager; }
        public bool IsCredentialsGood { get => _isCredentialsGood; }
        public int TeamID { get => _teamID; }
        public List<TeamMember> TeamMembers { get => _teamMembers; }

        public Client(string userName, string password) 
        {
            SetInfo(userName, password);
        }

        private void SetInfo (string userName, string password)
        {
            MySqlConnection conn = new MySqlConnection(GlobalVariables.ConnString);
            DataTable myTable = new DataTable();

            try
            {
                conn.Open();

                string sqlQuery = $"select * from {GlobalVariables.ClientTableName} WHERE userName=@username";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@username", userName);

                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(myTable);

                if (myTable.Rows.Count > 0)
                {
                    var row = myTable.Rows[0];
                    if (row["password"].ToString() == password)
                    {
                        _isCredentialsGood = true;
                        _clientID = Convert.ToInt32(row["clientID"]);
                        _firstName = row["firstName"].ToString();
                        _lastName = row["lastName"].ToString();
                        _isManager = Convert.ToBoolean(row["isManager"]);
                        _teamID = Convert.ToInt32(row["teamId"]);
                        _fullName = $"{LastName}, {FirstName}";
                    }
                }

                if (IsManager)
                {
                    string getTeamMemberQuery = $"select ClientID, firstName, lastName from {GlobalVariables.ClientTableName}" +
                                $" WHERE teamID=@teamID";
                    MySqlCommand teamMemberCmd = new MySqlCommand(getTeamMemberQuery, conn);
                    teamMemberCmd.Parameters.AddWithValue("@teamID", _teamID);

                    myAdapter = new MySqlDataAdapter(teamMemberCmd);
                    myTable.Clear();
                    myAdapter.Fill(myTable);

                    _teamMembers = new List<TeamMember>();

                    foreach (DataRow row in myTable.Rows)
                    {
                        int id = Convert.ToInt32(row["ClientID"]);
                        string fullName = $"{row["lastName"]}, {row["firstName"]}";
                        _teamMembers.Add(new TeamMember(id, fullName));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
            }
            conn.Close();
        }
    }
}
