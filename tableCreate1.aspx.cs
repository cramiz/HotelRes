using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class tableCreate1 : System.Web.UI.Page
{

    private string connectionString = WebConfigurationManager.ConnectionStrings["zzCs321_ConnectionString"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private void CreateTable1(object sender, EventArgs e)
    {


< sql >
    USE zzCX321_4
    GO

    SET ANSI_NULLS ON
    GO

    SET QUOTED_IDENTIFIER ON
    GO

    CREATE TABLE[dbo].[ReservationForm_1](
        [customerID]
    [int] IDENTITY(1,1) NOT NULL,

[arrivalDate][datetime]
    NOT NULL,

[numberOfNights][int] NOT NULL,

[numAdults][int] NULL,
        [numChildren]
    [int] NULL,
        [roomTypeBusiness]
    [bit]
    NULL,
        [roomTypeSuite]
    [bit]
    NULL,
        [roomTypeStandard]
    [bit]
    NULL,
        [bedTypeKing]
    [bit]
    NULL,
        [bedTypeDouble]
    [bit]
    NULL,
        [smokingOption]
    [bit]
    NULL,
        [specialRequests]
    [nvarchar](50) NULL,
        [name]
    [nvarchar](50) Null,
        [email]
    [nvarchar](50) NULL,
   CONSTRAINT[PK_CustomerID] PRIMARY KEY CLUSTERED
    (
        [customerID] ASC
    )WITH(PAD_INDEX_= OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS= ON, ALLOW_PAGE_LOCKS-ON) ON[PRIMARY]
    )ON[PRIMARY]

    GO
</sql>

}

}