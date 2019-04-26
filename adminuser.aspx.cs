using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_adminuser : System.Web.UI.Page
{
    Consultassql datos = new Consultassql();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            loaddgvadminuser();
        }
    }
    protected void loaddata()
    {
        if (Request.Cookies["idchangeadmin"] != null)
        {
            HttpCookie idadminuser = Request.Cookies["idchangeadmin"];
            DataTable dt = new DataTable();
            dt = datos.extraedatos("SELECT firstname, lastname, email, pass FROM tadminuser WHERE idadminuser=" + idadminuser.Value);
            txtfirstname.Text = dt.Rows[0][0].ToString();
            txtlastname.Text = dt.Rows[0][1].ToString();
            txtemail.Text = dt.Rows[0][2].ToString();
            txtpass.Text = "";
            txtconfirmpass.Text = "";
            btndelete.Visible = true;
            btnadduser.Text = "UPDATE DATA";
            btnadduser.Attributes.Add("class", "btn btn-warning");
        }
    }
    protected void newuser()
    {
        txtfirstname.Text = "";
        txtlastname.Text = "";
        txtemail.Text = "";
        txtpass.Text = "";
        txtconfirmpass.Text = "";
        btndelete.Visible = false;
        btnadduser.Text = "SAVE DATA";
        btnadduser.Attributes.Add("class", "btn btn-info");
        // Delete cookie
        if (Request.Cookies["idchangeadmin"] != null)
        {
            HttpCookie myCookie = new HttpCookie("idchangeadmin");
            myCookie.Expires = DateTime.Now.AddDays(-1d);
            Response.Cookies.Add(myCookie);
        }
    }
    protected void btnadduser_Click(object sender, EventArgs e)
    {
        if (Request.Cookies["idchangeadmin"] == null)
        {
            if (txtfirstname.Text != "" && txtlastname.Text != "" && txtemail.Text != "" && txtpass.Text != "" && txtconfirmpass.Text != "")
            {
                if (txtpass.Text == txtconfirmpass.Text)
                {
                    try
                    {
                        datos.enviardatos("INSERT INTO tadminuser (firstname, lastname, email, pass) VALUES ('" + txtfirstname.Text + "', '" + txtlastname.Text + "', '" + txtemail.Text + "', '" + txtpass.Text + "')");
                        Response.Write("<script>alert('User was successfully added.')</script>");
                        newuser();
                    }
                    catch (Exception)
                    {
                        Response.Write("<script>alert('There was an error adding the user, please check the data entered.')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Passwords do not match, please re-enter passwords.')</script>");
                }
                
            }
            else
            {
                Response.Write("<script>alert('Please enter all the data.')</script>");
            }
            
        }
        else
        {
            if (txtfirstname.Text != "" && txtlastname.Text != "" && txtemail.Text != "" && txtpass.Text != "" && txtconfirmpass.Text != "")
            {
                if (txtpass.Text == txtconfirmpass.Text)
                {
                    try
                    {
                        HttpCookie idadminuser = Request.Cookies["idchangeadmin"];
                        datos.enviardatos("UPDATE tadminuser SET firstname='" + txtfirstname.Text + "', lastname='" + txtlastname.Text + "', email='" + txtemail.Text + "', pass='" + txtpass + "' WHERE idadminuser=" + idadminuser.Value);
                        Response.Write("<script>alert('User successfully updated.')</script>");
                    }
                    catch (Exception)
                    {
                        Response.Write("<script>alert('There was an error updating, please check the data entered.')</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Passwords do not match, please re-enter passwords.')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Please enter all the data.')</script>");
            }
        }
    }
    protected void btndelete_Click(object sender, EventArgs e)
    {
        if (Request.Cookies["idchangeadmin"] != null)
        {
            try
            {
                datos.enviardatos("INSERT INTO tadminuser (firstname, lastname, email, pass) VALUES ('" + txtfirstname.Text + "', '" + txtlastname.Text + "', '" + txtemail.Text + "', '" + txtpass.Text + "')");
                Response.Write("<script>alert('User was successfully added.')</script>");
                newuser();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('There was an error adding the user, please check the data entered.')</script>");
            }

        }
    }
    protected void btnnewuser_Click(object sender, EventArgs e)
    {
        newuser();
    }
    protected void loaddgvadminuser()
    {
        DataTable dt = new DataTable();
        dt = datos.extraedatos("SELECT idadminuser, firstname, lastname, email, pass from tadminuser");
        dgvadminuser.DataSource = dt;
        dgvadminuser.DataBind();
    }
    protected void dgvadminuser_OnRowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(dgvadminuser, "Select$" + e.Row.RowIndex);
            e.Row.ToolTip = "Click to select user";
        }
    }
    protected void dgvadminuser_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow idfila = dgvadminuser.SelectedRow;
        //int idpersona = Convert.ToInt32(dgvpersona.DataKeys[idfila.RowIndex].Value);
        int idadminuser = Convert.ToInt32(dgvadminuser.DataKeys[idfila.RowIndex].Values[0]);

        // Delete cookie
        if (Request.Cookies["idchangeadmin"] != null)
        {
            HttpCookie myCookie = new HttpCookie("idchangeadmin");
            myCookie.Expires = DateTime.Now.AddDays(-1d);
            Response.Cookies.Add(myCookie);
        }

        // Make Cookie
        HttpCookie idadmin = new HttpCookie("idchangeadmin");
        // Set the cookie value.
        idadmin.Value = idadminuser.ToString();
        // Set the cookie expiration date.
        idadmin.Expires = DateTime.Now.AddDays(1d);
        // Add the cookie.
        Response.Cookies.Add(idadmin);

        loaddata();
    }
    protected void dgvadminuser_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        // opcion 1
        dgvadminuser.PageIndex = e.NewPageIndex;
        dgvadminuser.DataBind();

        // opcion 2
        //GridView gv = (GridView)sender;
        //gv.PageIndex = e.NewPageIndex;

        //DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
        loaddgvadminuser();
    }

    
}