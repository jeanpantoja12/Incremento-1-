using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_adminmaster : System.Web.UI.MasterPage
{
    Consultassql datos = new Consultassql();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            loadnotification();
        }
        if (Request.Cookies["usernameartvus"] == null)
        {
            Response.Redirect("loginadmin.aspx");
        }
        else
        {
            HttpCookie idadminuser = Request.Cookies["usernameartvus"];
            lblusername1.Text = idadminuser.Value;
            lblusername2.Text = idadminuser.Value;
        }
    }

    protected void loadnotification()
    {
        System.Web.UI.HtmlControls.HtmlGenericControl li_notify;
        System.Web.UI.HtmlControls.HtmlGenericControl a_notify;
        System.Web.UI.HtmlControls.HtmlGenericControl i_notify;
        System.Web.UI.HtmlControls.HtmlGenericControl span_notify;
        // Paid Order
        DataTable dtpaidorder = new DataTable();
        dtpaidorder = datos.extraedatos("SELECT count(*) FROM tcart WHERE state=2 and notifpaidorder='0'");
        if (dtpaidorder.Rows[0][0].ToString() != "0")
        {
            li_notify = new System.Web.UI.HtmlControls.HtmlGenericControl("li");
            a_notify = new System.Web.UI.HtmlControls.HtmlGenericControl("a");
            i_notify = new System.Web.UI.HtmlControls.HtmlGenericControl("i");
            span_notify = new System.Web.UI.HtmlControls.HtmlGenericControl("span");

            plnotify.Controls.Add(li_notify);
            li_notify.Controls.Add(a_notify);
            a_notify.Controls.Add(i_notify);
            a_notify.Controls.Add(span_notify);
            a_notify.Attributes.Add("href", "#");
            i_notify.Attributes.Add("class", "fa fa-money text-green");
            span_notify.InnerText = dtpaidorder.Rows[0][0].ToString() + " New Paid Orders";
        }
        
        // Orders in cart
        DataTable dtordercart = new DataTable();
        dtordercart = datos.extraedatos("SELECT count(*) FROM tcart WHERE state=1 and statequotation <> 2 and notiforderincart='0'");
        if (dtordercart.Rows[0][0].ToString() != "0")
        {
            li_notify = new System.Web.UI.HtmlControls.HtmlGenericControl("li");
            a_notify = new System.Web.UI.HtmlControls.HtmlGenericControl("a");
            i_notify = new System.Web.UI.HtmlControls.HtmlGenericControl("i");
            span_notify = new System.Web.UI.HtmlControls.HtmlGenericControl("span");

            plnotify.Controls.Add(li_notify);
            li_notify.Controls.Add(a_notify);
            a_notify.Controls.Add(i_notify);
            a_notify.Controls.Add(span_notify);
            a_notify.Attributes.Add("href", "#");
            i_notify.Attributes.Add("class", "fa fa-shopping-cart text-red");
            span_notify.InnerText = dtordercart.Rows[0][0].ToString() + " New Orders in Cart";
        }

        // Pending ordering
        DataTable dtpendingorder = new DataTable();
        dtpendingorder = datos.extraedatos("SELECT count(*) FROM tcart WHERE state=1 and statequotation=2 and notifpendingorder='0'");
        if (dtpendingorder.Rows[0][0].ToString() != "0")
        {
            li_notify = new System.Web.UI.HtmlControls.HtmlGenericControl("li");
            a_notify = new System.Web.UI.HtmlControls.HtmlGenericControl("a");
            i_notify = new System.Web.UI.HtmlControls.HtmlGenericControl("i");
            span_notify = new System.Web.UI.HtmlControls.HtmlGenericControl("span");

            plnotify.Controls.Add(li_notify);
            li_notify.Controls.Add(a_notify);
            a_notify.Controls.Add(i_notify);
            a_notify.Controls.Add(span_notify);
            a_notify.Attributes.Add("href", "#");
            i_notify.Attributes.Add("class", "fa fa-clock-o text-aqua");
            span_notify.InnerText = dtpendingorder.Rows[0][0].ToString() + " New Pending Orders";
        }
        string notifytotal = (int.Parse(dtpaidorder.Rows[0][0].ToString()) + int.Parse(dtordercart.Rows[0][0].ToString()) + int.Parse(dtpendingorder.Rows[0][0].ToString())).ToString();
        lblnotify.Text = notifytotal;
        lblnotifytext.Text = notifytotal;
    }
    
    protected void btnmanageuser_Click(object sender, EventArgs e)
    {
        // Delete cookie
        if (Request.Cookies["idchangeadmin"] != null)
        {
            HttpCookie myCookie = new HttpCookie("idchangeadmin");
            myCookie.Expires = DateTime.Now.AddDays(-1d);
            Response.Cookies.Add(myCookie);
        }
        Response.Redirect("adminuser.aspx");
    }

    protected void btnsingout_Click(object sender, EventArgs e)
    {
        // Eliminar cookie
        if (Request.Cookies["usernameartvus"] != null)
        {
            HttpCookie myCookie = new HttpCookie("usernameartvus");
            myCookie.Expires = DateTime.Now.AddDays(-1d);
            Response.Cookies.Add(myCookie);
        }
        Response.Redirect("loginadmin.aspx");
    }
}
