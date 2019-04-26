using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_clientadmin : System.Web.UI.Page
{
    Consultassql datos = new Consultassql();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            loadclient();
            loaddgvorderclient();
        }
    }
    protected void loadclient()
    {
        if (Request.Cookies["idclientadmin"] != null)
        {
            DataTable dt = new DataTable();
            HttpCookie idclient = Request.Cookies["idclientadmin"];
            dt = datos.extraedatos("SELECT firstname, lastname, birth, phone, address, country, state, postalcode, city, companyname, taxid, website, others, email, passwd, usercondition FROM tclient WHERE idclient=" + idclient.Value);
            txtfirstname.Text = dt.Rows[0][0].ToString();
            txtlastname.Text = dt.Rows[0][1].ToString();
            txtbirth.Text = dt.Rows[0][2].ToString();
            txtphone.Text = dt.Rows[0][3].ToString();
            txtaddress.Text = dt.Rows[0][4].ToString();
            txtcountry.Text = dt.Rows[0][5].ToString();
            txtstate.Text = dt.Rows[0][6].ToString();
            txtpostalcode.Text = dt.Rows[0][7].ToString();
            txtcity.Text = dt.Rows[0][8].ToString();

            txtcompanyname.Text = dt.Rows[0][9].ToString();
            txttaxid.Text = dt.Rows[0][10].ToString();
            txtwebsite.Text = dt.Rows[0][11].ToString();
            txtothers.Text = dt.Rows[0][12].ToString();

            txtemail.Text = dt.Rows[0][13].ToString();
            txtpassword.Text = dt.Rows[0][14].ToString();
        }
        
    }
    protected void loaddgvorderclient()
    {
        if (Request.Cookies["idclientadmin"] != null)
        {
            HttpCookie idclient = Request.Cookies["idclientadmin"];
            DataTable dt = new DataTable();
            dt = datos.extraedatos("SELECT idcart, concat(tcl.firstname,' ',tcl.lastname) as clientname, tcl.companyname, tcr.shippingprogress, concat('$',tcr.subtotal) as total,tcr.notifpaidorder,tcr.numorder,tcr.datepaymentcart " +
                "FROM tcart tcr INNER JOIN tclient tcl ON tcr.idclient=tcl.idclient " +
                "WHERE tcr.idclient=" + idclient.Value + " ORDER BY tcr.idcart DESC");
            dgvorderclient.DataSource = dt;
            dgvorderclient.DataBind();
        }
    }
    protected void dgvorderclient_OnRowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
    {
        DataRowView drview = e.Row.DataItem as DataRowView;
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(dgvorderclient, "Select$" + e.Row.RowIndex);
            e.Row.ToolTip = "Click to select order";

            Label shippingprogress = (Label)e.Row.FindControl("shippingprogresslbl");
            Panel panelprogress = (Panel)e.Row.FindControl("Panelprogress");
            Label status = (Label)e.Row.FindControl("statuslbl");
            Label notif = (Label)e.Row.FindControl("notificationlbl");
            if (notif.Text == "0")
            {
                e.Row.BackColor = System.Drawing.Color.FromName("#fffdc1");
            }
            notif.Visible = false;
            //System.Web.UI.WebControls.Image img = (System.Web.UI.WebControls.Image)e.Row.FindControl("img");
            if (shippingprogress.Text == "1")
            {
                panelprogress.Attributes.Add("class", "progress-bar progress-bar-danger");
                panelprogress.Attributes.Add("style", "width:33%");
                status.Text = "ORDER RECEIVED";
            }
            else
            {
                if (shippingprogress.Text == "2")
                {
                    panelprogress.Attributes.Add("class", "progress-bar progress-bar-warning");
                    panelprogress.Attributes.Add("style", "width:66%");
                    status.Text = "IN PROCESS";
                }
                else
                {
                    if (shippingprogress.Text == "3")
                    {
                        panelprogress.Attributes.Add("class", "progress-bar progress-bar-success");
                        panelprogress.Attributes.Add("style", "width:100%");
                        status.Text = "SENT";
                    }
                }
            }
            shippingprogress.Visible = false;

        }
    }
    protected void dgvorderclient_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow idfila = dgvorderclient.SelectedRow;
        //int idpersona = Convert.ToInt32(dgvpersona.DataKeys[idfila.RowIndex].Value);
        int idcartdgv = Convert.ToInt32(dgvorderclient.DataKeys[idfila.RowIndex].Values[0]);

        // Delete cookie
        if (Request.Cookies["idcartadmin"] != null)
        {
            HttpCookie myCookie = new HttpCookie("idcartadmin");
            myCookie.Expires = DateTime.Now.AddDays(-1d);
            Response.Cookies.Add(myCookie);
        }

        // Make Cookie
        HttpCookie idcart = new HttpCookie("idcartadmin");
        // Set the cookie value.
        idcart.Value = idcartdgv.ToString();
        // Set the cookie expiration date.
        idcart.Expires = DateTime.Now.AddDays(1d);
        // Add the cookie.
        Response.Cookies.Add(idcart);

        Response.Redirect("orderdetail.aspx");
    }
    protected void dgvorderclient_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        // opcion 1
        dgvorderclient.PageIndex = e.NewPageIndex;
        dgvorderclient.DataBind();

        // opcion 2
        //GridView gv = (GridView)sender;
        //gv.PageIndex = e.NewPageIndex;

        //DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
        loaddgvorderclient();
    }


    protected void btnsessionclient_Click(object sender, EventArgs e)
    {
        if (Request.Cookies["idclientadmin"] != null)
        {
            // Delete cookie
            if (Request.Cookies["idclientuser"] != null)
            {
                HttpCookie myCookie = new HttpCookie("idclientuser");
                myCookie.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Add(myCookie);
            }

            HttpCookie idclientadmin = Request.Cookies["idclientadmin"];
            DataTable dtuser = new DataTable();
            dtuser = datos.extraedatos("SELECT idclient, concat(firstname,' ',lastname) FROM tclient WHERE idclient=" + idclientadmin.Value);
            // Make cookie
            HttpCookie idclient = new HttpCookie("idclientuser");
            idclient.Values["iduser"] = dtuser.Rows[0][0].ToString();
            idclient.Values["userName"] = dtuser.Rows[0][1].ToString();
            idclient.Expires = DateTime.Now.AddDays(1d);
            Response.Cookies.Add(idclient);
            Response.Write("<script>javascript:window.open('/','_blank');</script>");
            //ScriptManager.RegisterStartupScript(Page, Page.GetType(), "popup", "window.open('/','_blank')", true);
        }

    }
}