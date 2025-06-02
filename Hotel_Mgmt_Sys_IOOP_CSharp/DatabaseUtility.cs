using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Mgmt_Sys_IOOP_CSharp
{
    internal class DatabaseUtility
    {
        //private string conn_string;
        private SqlConnection connection;
        private SqlCommand cmd;

        public SqlConnection Connection { get => connection; set => connection = value; }
        public SqlCommand Cmd { get => cmd; set => cmd = value; }


        //GetSet 

        public DatabaseUtility(string connectionName)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionName].ToString());
            connection.Open(); 
        }

        public string Select(List<string> columnName, string tableSource, string conditions)
        {
            string cmdColumnString = "";

            string command = "";
            string commCondition = ""; 

            if (columnName.Count != 0)
            {              
                foreach (string str in columnName)
                {
                    if (columnName.IndexOf(str) != (columnName.Count - 1))
                    {
                        cmdColumnString += str;
                        cmdColumnString += ", ";
                    }
                    else
                    { cmdColumnString += str; }
                }

                if (conditions != "")
                {
                    commCondition = $" WHERE {conditions}";
                }

                command = $"SELECT {cmdColumnString} FROM {tableSource}" + commCondition;              
            }
            return command; 
        }

        
        //SubFunctions
        public int SqlCmdExecute(string commandSQL, Dictionary<string, string> cmdParameDict, cmdExeWriteMode executeMode, out object resultQueryScalar)
        {
            int status = 0;
            resultQueryScalar = null; 

            try 
            {
                cmd = new SqlCommand(commandSQL, connection);

                if (cmdParameDict.Count > 0)
                {
                    foreach (KeyValuePair<string, string> kvp in cmdParameDict) //i = 0; i < cmdParameDict.Count; i++)
                    {
                        cmd.Parameters.AddWithValue(kvp.Key, kvp.Value);
                    }
                }

                switch (executeMode)
                {
                    case cmdExeWriteMode.Scalar:
                        resultQueryScalar = cmd.ExecuteScalar();
                        status = 1; 
                        break;
                    case cmdExeWriteMode.NonQuery:
                        status = cmd.ExecuteNonQuery(); // return number of rows affected 
                        break; 
                    //case cmdExecuteMode.
                    //default: 
                }               
            }
            catch(Exception e)
            {
               MessageBox.Show(e.Message + "\n\n" + e.StackTrace);
                status = -1; 
            }
            
            return status;
        }

        public List<List<string>> SqlCmdReader()
        {
            List<List<string>> result = new List<List<string>>(); 
            try
            {
                //cmd = new SqlCommand(SQLCommandToRead, connection);               
                SqlDataReader rd = cmd.ExecuteReader();
                List<ArrayList> arrListDB = new List<ArrayList>();
                while (rd.Read())
                {
                    object[] objectArr = new object[rd.FieldCount];
                    rd.GetValues(objectArr);
                    arrListDB.Add(new ArrayList(objectArr)); //.GetValue(i)) requires for loop; //.GetString(i));
                }
                rd.Close();

                for (int l = 0; l < arrListDB.Count; l++)
                {
                    ArrayList dataObjRow = arrListDB[l];

                    List<string> dataRowStore = new List<string>(); 
                    foreach (object dataSingle in dataObjRow)
                    {
                        dataRowStore.Add(dataSingle.ToString()); 
                    }
                    result.Add(dataRowStore); 
                }

                //SqlDataReader reader = cmd.ExecuteReader();
                
                //while (reader.Read())
                //{
                //    result.Add(reader.GetString(columnReadIndex)); 
                //}

                //foreach (KeyValuePair<string, string> kvp in cmdParameDict) //i = 0; i < cmdParameDict.Count; i++)
                //{
                //    cmd.Parameters.AddWithValue(kvp.Key, kvp.Value);
                //}

                //switch (executeMode)
                //{
                //    case cmdExeWriteMode.Scalar:
                //        result = cmd.ExecuteScalar();
                //        status = 1;
                //        break;
                //    case cmdExeWriteMode.NonQuery:
                //        status = cmd.ExecuteNonQuery(); // return number of rows affected 
                //        break;
                //        //case cmdExecuteMode.
                //        //default: 
                //}

                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + "\n\n" + e.StackTrace);
            }
        }

        public List<string> GetColumnData(string columnName, string DbTableName)
        {
            List<string> columnDataList = new List<string>();
            try
            {
                cmd = new SqlCommand($@"SELECT DISTINCT {columnName} FROM {DbTableName}", connection);
                SqlDataReader rd = cmd.ExecuteReader();

                int i = 0;
                while (rd.Read())
                {
                    columnDataList.Add(rd.GetValue(0).ToString());
                    i++;
                }
                rd.Close();
                return columnDataList;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + "\n\n" + e.StackTrace);
            }
        }

        public Dictionary<string,string> GetRowData(string DbTableName, string columnNameIdentifier, string fieldValue)
        {
            Dictionary<string, string> rowDataDict = new Dictionary<string, string>();
            try
            {
                cmd = new SqlCommand($@"SELECT * FROM {DbTableName} WHERE {columnNameIdentifier} = @fieldValue", connection);
                cmd.Parameters.AddWithValue("@fieldValue", fieldValue); 
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    //object[] objectArr = new object[rd.FieldCount];
                    //rd.GetValue(objectArr);
                    //arrListDB.Add(new ArrayList(objectArr)); //.GetValue(i)) requires for loop; //.GetString(i));

                    for (int col = 0; col < rd.FieldCount; col++)
                    {
                        //string dictkey = rd.GetName(col).ToString();
                        //string dictvalue = rd.GetValue(col).ToString();
                        //rowDataDict.Add(rd.GetName(col).ToString(), rd.GetString(col).ToString());
                        rowDataDict.Add(rd.GetName(col), rd.GetValue(col).ToString());
                    }                  
                }
                rd.Close();
                return rowDataDict;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + "\n\n" + e.StackTrace);
            }
        }

        public List<string> RetriveTableHeader(string DbTableName)
        {

            List<string> header = new List<string>();
            try
            {
                cmd = new SqlCommand($"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{DbTableName}'", connection);
                SqlDataReader rd = cmd.ExecuteReader();

                int i = 0;
                while (rd.Read())
                {
                    //object[] objectArr = new object[rd.FieldCount];
                    header.Add(rd.GetString(0));
                    i++;
                    //arrListDB.Add(new ArrayList(objectArr)); //.GetValue(i)) requires for loop; //.GetString(i));
                }
                rd.Close();

                //for (int l = 0; l < arrListDB.Count; l++)
                //{
                //    ArrayList dataObjRow = arrListDB[l];

                //    List<string> dataRowStore = new List<string>();
                //    foreach (object dataSingle in dataObjRow)
                //    {
                //        dataRowStore.Add(dataSingle.ToString());
                //    }
                //    //header.Add(dataRowStore);
                //}
                return header;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + "\n\n" + e.StackTrace);
            }
        }



        public enum cmdExeWriteMode
        { 
            Scalar, //Executes the query, and returns the first column of the first row in the result
                    //set returned by the query. Additional columns or rows are ignored.
            NonQuery, //INSERT, DELETE, UPDATE
            //Reader // READ 
        }

        public void Close()
        {
            connection.Close();         
        }



    }
}
