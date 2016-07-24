using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ReservationFormResult : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            
           
            string arrival = ((TextBox)PreviousPage.FindControl("txtboxArrival")).Text;
            string nights = ((TextBox)PreviousPage.FindControl("txtboxNights")).Text;
            DropDownList ddlAdults = (DropDownList)PreviousPage.FindControl("ddlAdults");
            string selectedAdults = ddlAdults.SelectedValue;
            DropDownList ddlChildren = (DropDownList)PreviousPage.FindControl("ddlChildren");
            string selectedChildren = ddlChildren.SelectedValue;
            RadioButtonList rbtnRoom = (RadioButtonList)PreviousPage.FindControl("rbtnRoom");
            string selectedRoom = rbtnRoom.SelectedValue;
            RadioButtonList rbtnBed = (RadioButtonList)PreviousPage.FindControl("rbtnBed");
            string selectedBed = rbtnBed.SelectedValue;
            CheckBox cboxSmoking = (CheckBox)PreviousPage.FindControl("chkSmoking");
            Boolean selectedSmoking = cboxSmoking.Checked;
            string specialRequests = ((TextBox)PreviousPage.FindControl("txtboxSpecial")).Text;
            string name = ((TextBox)PreviousPage.FindControl("txtName")).Text;
         
            string email = ((TextBox)PreviousPage.FindControl("txtEmail")).Text;

            lblReservationResults.Text = string.Format("Name: {0}  <br />Email: {1} <br />Arrival date: {2} <br />Departure date:  {3} <br />Number of adults: {4} <br />Number of children: {5} <br />Room type {6} <br />Bed Type: {7} <br />Smoking: {8} <br />Special requests {9}", name, email, arrival, nights, selectedAdults, selectedChildren, selectedRoom, selectedBed, selectedSmoking, specialRequests );
        }   

        catch
        {
            lblReservationResults.Text = "The originating page must contain all requested values.";
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       

        string insertSQL;
        insertSQL = "INSERT INTO dbo.ReservationForm_1 (";
        insertSQL += "arrivalDate, numberOfNights, numAdults, numChildren, roomTypeBusiness, roomTypeSuite, roomTypeStandard, ";
        insertSQL += "bedTypeKing, bedTypeDouble, ";
        insertSQL += "smokingOption, ";
        insertSQL += "specialRequests, name, email)";

    }
}