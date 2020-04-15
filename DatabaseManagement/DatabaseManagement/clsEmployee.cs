using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DatabaseManagement
{
    public class clsEmployee
    {
        private int mId;
        private string mName;
        private int mNationalID;
        private double mHeight;
        private double mWeight;
        private DateTime mBirthdate;
        private static SqlConnection mSqlConnection;

        public clsEmployee()
        {
        }


        // Return information about database path
        private static string Connection
        {
            get
            {
                return "Data Source=localhost;Initial Catalog=EmployeesManagement;User ID=sa;Password=sedco@123";
            }
        }


        // Connect to database
        private static void ConnectDB()
        {            
            try
            {
                mSqlConnection = new SqlConnection(Connection);
                if (mSqlConnection.State != ConnectionState.Open)
                    mSqlConnection.Open();
            }
            catch (Exception obj)
            { mdlGeneral.ErrorLogging(obj); }
        }


        // Disconnect database 
        private static void DisconnectDB()
        {
            try
            {
                mSqlConnection = new SqlConnection(Connection);
                if (mSqlConnection.State != ConnectionState.Closed)
                    mSqlConnection.Close();
            }
            catch (Exception obj)
            { mdlGeneral.ErrorLogging(obj); }
        }

        public int ID
        {
            get
            {
                try
                {
                    return mId;
                }
                catch (Exception obj)
                {
                    mdlGeneral.ErrorLogging(obj);
                    return mdlGeneral.cERROR;
                }
            }
            set
            {
                try
                {
                    mId = value;
                }
                catch (Exception obj)
                {
                    mdlGeneral.ErrorLogging(obj);
                }
            }
        }

        public string Name
        {
            set
            {
                try
                {
                    mName = value;
                }
                catch (Exception obj)
                { mdlGeneral.ErrorLogging(obj); }
            }
            get
            {
                try { return mName; }
                catch (Exception obj)
                {
                    mdlGeneral.ErrorLogging(obj);
                    return "";
                }
            }
        }


        public int NationalID
        {
            set
            {
                try {
                    mNationalID = value; }
                catch (Exception obj)
                {
                    mdlGeneral.ErrorLogging(obj);
                }
            }
            get
            {
                try
                {
                    return mNationalID;
                }
                catch (Exception obj)
                {
                    mdlGeneral.ErrorLogging(obj);
                    return 0;
                }
            }
        }


        public double Height
        {
            set
            {
                try
                {
                    mHeight = value;
                }
                catch (Exception obj)
                {
                    mdlGeneral.ErrorLogging(obj);
                }
            }
            get
            {
                try
                {
                    return mHeight;
                }
                catch (Exception obj)
                {
                    mdlGeneral.ErrorLogging(obj);
                    return 0;
                }
            }
        }

        public double Weight
        {
            set
            {
                try
                {
                    mWeight = value;
                }
                catch (Exception obj)
                {
                    mdlGeneral.ErrorLogging(obj);
                }
            }
            get
            {
                try
                {
                    return mWeight;
                }
                catch (Exception obj)
                {
                    mdlGeneral.ErrorLogging(obj);
                    return 0;
                }
            }
        }

        public DateTime Birthdate
        {
            set
            {
                try
                {
                    mBirthdate = value.Date;
                }
                catch (Exception obj)
                {
                    //MessageBox.Show(obj.Message, "Error");
                    mdlGeneral.ErrorLogging(obj);
                }
            }

            get
            {
                try
                {
                    return mBirthdate;
                }
                catch (Exception obj)
                {
                    //MessageBox.Show(obj.Message, "Error");
                    mdlGeneral.ErrorLogging(obj);
                    return DateTime.Now;
                }
            }
        }


        //get other infomration by ID
        public int Read()
        {
            try
            {
                ConnectDB();
                string query = "SELECT Name, NationalID, Height, Weight," +
                    "Birthdate FROM EmployeeInformation WHERE ID = @id ";
                SqlCommand command = new SqlCommand(query, mSqlConnection);
                command.Parameters.AddWithValue("@id", ID);
                SqlDataReader read = command.ExecuteReader();
                if (read.Read())
                {
                    Name = read["Name"].ToString();
                    NationalID = Convert.ToInt32(read["NationalID"].ToString());
                    Height = Convert.ToDouble(read["Height"].ToString());
                    Weight = Convert.ToDouble(read["Weight"].ToString());
                    Birthdate = Convert.ToDateTime(read["Birthdate"].ToString()).Date;
                }
                read.Close();
                DisconnectDB();
                return mdlGeneral.cSUCCESS;
            }
            catch(Exception obj)
            { //MessageBox.Show(obj.Message);
                mdlGeneral.ErrorLogging(obj);
                return mdlGeneral.cERROR;
            }
        }
        

        // if ID is exist edit information else add new employee
        public int Update()
        {
            try 
            {
                
                if (ExistID() == 1)
                {
                    ConnectDB();
                    string query = "UPDATE EmployeeInformation SET Name=@name, NationalID=@natID, Height=@height," +
                        " Weight=@weight, Birthdate=@bod WHERE ID=@id";
                    SqlCommand command = new SqlCommand(query, mSqlConnection);
                    command.Parameters.AddWithValue("@name", Name);
                    command.Parameters.AddWithValue("@natID", NationalID);
                    command.Parameters.AddWithValue("@height", Height);
                    command.Parameters.AddWithValue("@weight", Weight);
                    command.Parameters.AddWithValue("@bod", Birthdate);
                    command.Parameters.AddWithValue("@id", ID);
                    command.ExecuteNonQuery();
                    DisconnectDB();
                }
                else {                   
                    SetID();
                    ConnectDB();
                    string query = "INSERT INTO EmployeeInformation " +
                            "VALUES (@id , @name , @nationalID, @height, @weight, @birthdate);";
                    SqlCommand command = new SqlCommand(query, mSqlConnection);
                    command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                    command.Parameters.Add("@name", SqlDbType.VarChar).Value = Name;
                    command.Parameters.Add("@nationalID", SqlDbType.Int).Value = ID;
                    command.Parameters.Add("@height", SqlDbType.Real).Value = Height;
                    command.Parameters.Add("@weight", SqlDbType.Real).Value = Weight;
                    command.Parameters.Add("@birthdate", SqlDbType.Date).Value = Birthdate.Date;
                    command.ExecuteNonQuery();
                    DisconnectDB();
                }
                
                return mdlGeneral.cSUCCESS;
            }
            catch (Exception obj)
            { mdlGeneral.ErrorLogging(obj);
                return mdlGeneral.cERROR;
            }
        }


        // Delete employee using id
        public int Delete()
        {
            try
            {
                ConnectDB();
                // Delete query
                string query = "DELETE FROM EmployeeInformation WHERE ID = @id";
                // Execute query 
                SqlCommand command = new SqlCommand(query, mSqlConnection);
                command.Parameters.AddWithValue("@id", ID);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                DisconnectDB();
                return mdlGeneral.cSUCCESS;
            }
            catch (Exception obj)
            {
                mdlGeneral.ErrorLogging(obj);
                return mdlGeneral.cERROR;
            }
        }


        //Check if the employee's national id exist in database
        public int ExistNationalID(int id)
        {
            ConnectDB();
            string query = "SELECT COUNT(*) FROM EmployeeInformation WHERE NationalID = @id";
            SqlCommand command = new SqlCommand(query, mSqlConnection);
            command.Parameters.AddWithValue("@id", id);
            Int32 count = Convert.ToInt32(command.ExecuteScalar());
            DisconnectDB();
            return count;
        }


        //Check if the employee's national id exist in database
        private int ExistID()
        {
            ConnectDB();
            string query = "SELECT COUNT(*) FROM EmployeeInformation WHERE ID = @id";
            SqlCommand command = new SqlCommand(query, mSqlConnection);
            command.Parameters.AddWithValue("@id", ID);
            Int32 count = Convert.ToInt32(command.ExecuteScalar());
            DisconnectDB();
            return count;
        }


        //Set id using sequence
        private int SetID()
        {
            try
            {
                ConnectDB();
                string query = "SELECT NEXT VALUE FOR ID_Sequence";
                SqlCommand command = new SqlCommand(query, mSqlConnection);
                ID = Convert.ToInt32(command.ExecuteScalar());
                DisconnectDB();
                return mdlGeneral.cSUCCESS;
            }
            catch (Exception obj)
            {
                mdlGeneral.ErrorLogging(obj);
                return mdlGeneral.cERROR;
            }
        }


        // Get list of employees from database
        public static List<clsEmployee> GetEmployees()
        {
            List <clsEmployee> employees = new List<clsEmployee>();
            ConnectDB();
            string query = "SELECT * FROM EmployeeInformation ";
            SqlCommand command = new SqlCommand(query, mSqlConnection);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                clsEmployee employee = new clsEmployee();
                employee.ID = Convert.ToInt32(read["ID"]);
                employee.Name = read["Name"].ToString();
                employee.NationalID = Convert.ToInt32(read["NationalID"]);
                employee.Height = Convert.ToDouble(read["Height"]);
                employee.Weight = Convert.ToDouble(read["Weight"]);
                employee.Birthdate= Convert.ToDateTime(read["Birthdate"].ToString()).Date;
                employees.Add(employee);
            }
            read.Close();
            DisconnectDB();
            return employees;
        }
    }
}
