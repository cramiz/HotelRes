using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

public partial class _Default : System.Web.UI.Page
{
    private ReservationForm reservation = new ReservationForm();
    private string connectionString = WebConfigurationManager.ConnectionStrings["zzCs321_ConnectionString"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {

        reservation = (ReservationForm)Session["Reservation"];
        
        // Set arrival time to current date
        if (!IsPostBack)
        {
            txtboxArrival.Text = DateTime.Today.ToShortDateString();

        }

        // Generate 1-4 for Adults and 0-4 for Children
        for (int i = 0; i <= 4; i++)
        {
            if (i == 0)
            {
                ddlChildren.Items.Add(new ListItem(Convert.ToString(i), Convert.ToString(i)));
            } else
            {
                ddlAdults.Items.Add(new ListItem(Convert.ToString(i), Convert.ToString(i)));
                ddlChildren.Items.Add(new ListItem(Convert.ToString(i), Convert.ToString(i)));
            }
        }
        
        // Set default radio button values
        rbtnRoom.SelectedIndex = 2;
        rbtnBed.SelectedIndex = 0;

    }

    

    protected void Submit_Click(object sender, EventArgs e)
    {
        // Store form data into session.
        Session["arrival"] = txtboxArrival.Text;
        Session["nights"] = txtboxNights.Text;
        Session["adults"] = ddlAdults.SelectedValue;
        Session["children"] = ddlChildren.SelectedValue;
        Session["smoking"] = chkSmoking.Checked;
        Session["special"] = txtboxSpecial.Text;
        Session["name"] = txtName.Text;
        Session["email"] = txtEmail.Text;
        Session["specialMessage"] = txtboxSpecial.Text;

        

        


        
    }

    protected void Clear_Click(object sender, EventArgs e)
    {
        // Clear field values
        txtboxArrival.Text = DateTime.Today.ToShortDateString();
        txtboxNights.Text = "";
        ddlAdults.SelectedIndex = -1;
        ddlChildren.SelectedIndex = -1;
        chkSmoking.Checked = false;
        txtboxSpecial.Text = "";
        txtName.Text = "";
        txtEmail.Text = "";
        
    }
}