using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//add the following
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

public partial class ReservationManagerStarterFile : System.Web.UI.Page
{
    //declare the connection string
    //private string connectionString = WebConfigurationManager.ConnectionStrings["SimplePerson"].ConnectionString;
    private string connectionString = WebConfigurationManager.ConnectionStrings["zzCs321_ConnectionString"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!this.IsPostBack)
        {
            FillPersonList();
        }
    }
    private void FillPersonList()
    {
        ddlPerson.Items.Clear();

        //Define the Select statement.
        //Three pieces of information are needed: the unique id, the first name and the last name
        string selectSQL = "SELECT customerID, name FROM ReservationForm_1";

        //Define the ADO.NET objects.
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(selectSQL, con);
        SqlDataReader reader;

        //Try to open database and read information.
        try
        {
            con.Open();
            reader = cmd.ExecuteReader();

            //For each item, add the person name to the displayed
            //  list box text, and store the unique ID in the Value property.
            while (reader.Read())
            {
                ListItem newItem = new ListItem();
                newItem.Text = reader["name"].ToString();
                newItem.Value = reader["customerID"].ToString();
                ddlPerson.Items.Add(newItem);
            }
            reader.Close();
        }
        catch (Exception err)
        {
            lblResults.Text = "Error reading list of names. ";
            lblResults.Text += err.Message;
        }
        finally
        {
            con.Close();
        }
    }
    protected void ddlPerson_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Create a Select statement that searches for a record
        //  matching the specific author id from the Value property
        string selectSQL;
        selectSQL = "SELECT * from ReservationForm_1 ";
        selectSQL += "WHERE customerID = '" + ddlPerson.SelectedItem.Value + "'";

        //Define the ADO.NE objects
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(selectSQL, con);
        SqlDataReader reader;

        //Try to open database and read information.
        try
        {
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();

            //Fill the controls.
            txtID.Text = reader["customerID"].ToString();
            txtName.Text = reader["name"].ToString();
          

            reader.Close();

            lblResults.Text = "";
        }
        catch (Exception err)
        {
            lblResults.Text = "Error getting person. ";
            lblResults.Text += err.Message;
        }
        finally
        {
            con.Close();
        }
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        //Create SQL update string
        string updateSQL;
        updateSQL = "UPDATE ReservationForm_1 SET ";
        updateSQL += "name = @name";
        updateSQL += "WHERE customerID = @ID_original";
        
        //Define ADO.NET objects
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(updateSQL, con);

        //Add the parameters.
        cmd.Parameters.AddWithValue("@name", txtName.Text);
        cmd.Parameters.AddWithValue("@ID_original", ddlPerson.SelectedItem.Value);

        //Try to open the database and execute the update.
        int updated = 0;  //counter
        try
        {
            con.Open();
            updated = cmd.ExecuteNonQuery();
            lblResults.Text = updated.ToString() + " record updated.";
        }
        catch (Exception err)
        {
            lblResults.Text = "Error inserting record. ";
            lblResults.Text += err.Message;
        }
        finally
        {
            con.Close();
        }

        //If the update succeeded, refresh the person list
        if (updated > 0)
        {
            FillPersonList();
        }
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //Create the SQL delete string
        string deleteSQL;
        deleteSQL = "DELETE FROM ReservationForm_1 ";
        deleteSQL += "WHERE customerID = @customerID";
        
        //Define ADO.NET objects
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(deleteSQL, con);

        //Add the parameters.
        cmd.Parameters.AddWithValue("@customerID", ddlPerson.SelectedItem.Value);

        //Try to open the database and execute the update.
        int deleted = 0;  //counter
        try
        {
            con.Open();
            deleted = cmd.ExecuteNonQuery();
            lblResults.Text = deleted.ToString() + " Record deleted.";
        }
        catch (Exception err)
        {
            lblResults.Text = "Error deleting person. ";
            lblResults.Text += err.Message;
        }
        finally
        {
            con.Close();
        }

        //If the delete succeeded, refresh the person list
        if (deleted > 0)
        {
            FillPersonList();
        }
    }
    protected void btnNew_Click(object sender, EventArgs e)
    {
        //clear values before creating a new record
        txtID.Visible = false; //user does not enter this value
        txtName.Text = "";
        

        lblResults.Text = "Click Insert New to add the completed record.";
    }
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        //Perform user-defined checks.
        if (txtName.Text == "" )
        {
            lblResults.Text = "Records require a name.";
            return;
        }

        //Define SQL insert string
        string insertSQL;
        insertSQL = "INSERT INTO ReservationForm_1 (";
        insertSQL += "name)";
        insertSQL += "VALUES (";
        insertSQL += "@Name";

        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(insertSQL, con);

        //Add the parameters.
        cmd.Parameters.AddWithValue("@Name", txtName.Text);
        

        //Try to open the database and execute the update.
        int added = 0;  //counter
        try
        {
            con.Open();
            added = cmd.ExecuteNonQuery();
            lblResults.Text = added.ToString() + " record inserted.";
        }
        catch (Exception err)
        {
            lblResults.Text = "Error inserting record. ";
            lblResults.Text += err.Message;
        }
        finally
        {
            con.Close();
        }

        //If the insert succeeded, refresh the person list
        if (added > 0)
        {
            FillPersonList();
        }
    }
}