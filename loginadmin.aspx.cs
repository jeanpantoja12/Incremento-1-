using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_loginadmin : System.Web.UI.Page
{
    Consultassql datos = new Consultassql();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            inputEmail.Focus();
        }
    }
    protected void login()
    {
        DataTable dt = new DataTable();
        dt = datos.extraedatos("select count(*) from tadminuser where email='" + inputEmail.Text + "' and pass='" + inputPassword.Text + "'");
        if (dt.Rows[0][0].ToString() != "0")
        {
            //try
            //{
                dt.Rows.Clear();
                //dt = datos.extraedatos("select concat(firstname,' ',lastname) from tadminuser where email='" + inputEmail.Text + "' and pass='" + inputPassword.Text + "'");
                dt = datos.extraedatos("call bdarparic.loginadmin1('" + inputEmail.Text + "', '" + inputPassword.Text + "')");

                // Eliminar cookie
                if (Request.Cookies["usernameartvus"] != null)
                {
                    HttpCookie myCookie = new HttpCookie("usernameartvus");
                    myCookie.Expires = DateTime.Now.AddDays(-1d);
                    Response.Cookies.Add(myCookie);
                }

                // Creando Cookie
                HttpCookie nameuser = new HttpCookie("usernameartvus");
                // Set the cookie value.
                nameuser.Value = dt.Rows[0][0].ToString();
                // Set the cookie expiration date.
                nameuser.Expires = DateTime.Now.AddDays(1d);
                // Add the cookie.
                Response.Cookies.Add(nameuser);

                //datos.enviardatos("call bdsistemaventas.guardarlog('"+ nameuser.Value + "', 'inició sesion');");

                Response.Redirect("productsearch.aspx");
            //}
            //catch (Exception)
            //{

            //}
            
        }
        else
        {
            alerta.Visible = true;
            alerta.Attributes.Add("class", "alert alert-danger");
            alerta.InnerText = "Contraseña Incorrecta";
        }
    }

    protected void btningresar_Click(object sender, EventArgs e)
    {
        login();
    }

    protected void inputEmail_TextChanged(object sender, EventArgs e)
    {
        login();
    }
    
}