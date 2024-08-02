using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Remoting.Contexts;
using System.Net;
using WindowsFormsApp1.Logic;

namespace WindowsFormsApp1.Data
{
    internal class DataHandler
    {
        string connect = "Server = HOODED_PC\\MSSQLSERVER01; Initial Catalog = Project; Integrated Security = SSPI";
        
        public void WriteToStudents(Student s)
        {
            string query = $"INSERT INTO StudentInfo VALUES({s.SNumber},'{s.SName}','{s.SSurname}',{s.SDOB},'{s.SGender}','{s.SPhone}','{s.SAddress}', '{s.SModule}')";
            
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void WriteToModules(Module m)
        {
            string query = $"INSERT INTO ModuleInfo VALUES ('{m.MCode}', '{m.MName}', '{m.MDescription}', '{m.MResource}');";

            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable ReadFromStudents()
        {
            string query = $"SELECT * FROM StudentInfo";
            SqlDataAdapter sda = new SqlDataAdapter(query, connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public DataTable ReadFromModules()
        {
            string query = $"SELECT * FROM ModuleInfo";
            SqlDataAdapter sda = new SqlDataAdapter(query, connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public void UpdateStudent(Student s)
        {
            string query = $"UPDATE StudentInfo SET " +
                $"StudentName = '{s.SName}', StudentSurname = '{s.SSurname}', " +
                $"DOB = '{s.SDOB}', Gender = '{s.SGender}', Phone = '{s.SPhone}', " +
                $"Address = '{s.SAddress}', ModuleCodes = '{s.SModule}' " +
                $"WHERE StudentNumber = {s.SNumber}";

            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void UpdateModule(Module mod)
        {
            string query = $"UPDATE ModuleInfo SET " +
                $"ModuleName = '{mod.MName}', ModuleDescription = '{mod.MDescription}', " +
                $"OnlineResource = '{mod.MResource}' " +
                $"WHERE ModuleCode = '{mod.MCode}'";

            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void deleteStudent(int s)
        {
            string query = $"DELETE FROM StudentInfo " +
                $"WHERE StudentNumber = {s}";

            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void deleteModule(string m)
        {
            string query = $"DELETE FROM ModuleInfo " +
                $"WHERE ModuleCode = '{m}'";

            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable searchStudent(int s)
        {
            string query = $"SELECT * FROM StudentInfo " +
                $"WHERE StudentNumber = {s}";

            SqlDataAdapter da = new SqlDataAdapter(query, connect);
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
        public DataTable searchModule(string m)
        {
            string query = $"SELECT * FROM ModuleInfo " +
                $"WHERE ModuleCode = '{m}'";

            SqlDataAdapter da = new SqlDataAdapter(query, connect);
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
}
