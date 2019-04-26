using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_productsearch : System.Web.UI.Page
{
    Consultassql datos = new Consultassql();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            loaddgvproduct();
        }
    }
    protected void linkproduct_Click(object sender, EventArgs e)
    {
        // Delete cookie
        //if (Request.Cookies["idproduct"] != null)
        //{
        //    HttpCookie myCookie = new HttpCookie("idproduct");
        //    myCookie.Expires = DateTime.Now.AddDays(-1d);
        //    Response.Cookies.Add(myCookie);
        //}
        Response.Redirect("AgregarProd.aspx");
    }
    protected void loaddgvproduct()
    {
        DataTable dt = new DataTable();
        dt = datos.extraedatos("SELECT idproduct, sku, nameproduct, composition, madein, disable from tproduct");
        dgvproduct.DataSource = dt;
        dgvproduct.DataBind();
    }
    protected void dgvproduct_OnRowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(dgvproduct, "Select$" + e.Row.RowIndex);
            e.Row.ToolTip = "Click to select product";

            Label disable = (Label)e.Row.FindControl("disablelbl");
            Label disabletext = (Label)e.Row.FindControl("textdisablelbl");
            if (disable.Text == "")
            {
                disabletext.Text = "ENABLED";
                disable.Visible = false;
            }
            else
            {
                disabletext.Text = "DISABLED";
                disable.Visible = false;
                e.Row.BackColor = System.Drawing.Color.FromName("#ed715c");
            }
        }
    }
    protected void dgvproduct_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow idfila = dgvproduct.SelectedRow;
        //int idpersona = Convert.ToInt32(dgvpersona.DataKeys[idfila.RowIndex].Value);
        int idproductdgv = Convert.ToInt32(dgvproduct.DataKeys[idfila.RowIndex].Values[0]);

        // Delete cookie
        if (Request.Cookies["idproduct"] != null)
        {
            HttpCookie myCookie = new HttpCookie("idproduct");
            myCookie.Expires = DateTime.Now.AddDays(-1d);
            Response.Cookies.Add(myCookie);
        }

        // Make Cookie
        HttpCookie idproduct = new HttpCookie("idproduct");
        // Set the cookie value.
        idproduct.Value = idproductdgv.ToString();
        // Set the cookie expiration date.
        idproduct.Expires = DateTime.Now.AddDays(1d);
        // Add the cookie.
        Response.Cookies.Add(idproduct);

        Response.Redirect("productadmin.aspx");
    }
    protected void dgvproduct_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        // opcion 1
        dgvproduct.PageIndex = e.NewPageIndex;
        dgvproduct.DataBind();

        // opcion 2
        //GridView gv = (GridView)sender;
        //gv.PageIndex = e.NewPageIndex;

        //DropDownList pageList = (DropDownList)pagerRow.Cells[0].FindControl("PageDropDownList");
        loaddgvproduct();
    }
}