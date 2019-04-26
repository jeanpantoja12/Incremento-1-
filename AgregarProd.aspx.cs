using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.ComponentModel;
using System.Reflection;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Net;

public partial class admin_AgregarProd : System.Web.UI.Page
{
    Consultassql datos = new Consultassql();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            llenarlstcategory();
        }
    }
    protected void btnsaveproductdata_Click(object sender, EventArgs e)
    {
        if (Request.Cookies["idproduct"] != null)
        {
            txtname.Text = txtname.Text.ToUpper();
            int chknew = 0;
            if (hiddenchknew.Value == "true") { chknew = 1; }
            else if (hiddenchknew.Value == "false") { chknew = 0; }
            int chkonsale = 0;
            if (hiddenchkonsale.Value == "true") { chkonsale = 1; }
            else if (hiddenchkonsale.Value == "false") { chkonsale = 0; }


            int chkbest = 0;
            if (chkbestseller.Checked == true) { chkbest = 1; }
            else if (chkbestseller.Checked == false) { chkbest = 0; }

            HttpCookie idproduct = Request.Cookies["idproduct"];
            datos.enviardatos("UPDATE tproduct SET idcollection=" + lstcollection.SelectedValue + ", idcategory=" + lstcategory.SelectedValue + ", idsubcategory=" + lstsubcategory.SelectedValue + ", nameproduct='" + txtname.Text + "', composition='" + txtcomposition.Text + "', madein='" + txtmade.Text + "', newproduct=" + chknew + ", onsale=" + chkonsale + ", description='" + txtareadescription.InnerText + "', sizedetail='" + imginstruction.ImageUrl + "', careinstruction='xsx', rmbestseller='" + chkbest.ToString() + "' WHERE idproduct=" + idproduct.Value);
        }
        else
        {
            if (txtname.Text != "" && txtcomposition.Text != "")
            {
                DataTable dt = new DataTable();
                txtname.Text = txtname.Text.ToUpper();

                int chknew = 0;
                if (hiddenchknew.Value == "true") { chknew = 1; }
                else if (hiddenchknew.Value == "false") { chknew = 0; }
                int chkonsale = 0;
                if (hiddenchkonsale.Value == "true") { chkonsale = 1; }
                else if (hiddenchkonsale.Value == "false") { chkonsale = 0; }



                dt = datos.extraedatos("call bdarparic.saveproductdata(" + lstcollection.SelectedValue + ", " + lstcategory.SelectedValue + ", " + lstsubcategory.SelectedValue + ", '" + txtname.Text + "', '" + txtcomposition.Text + "', '" + txtmade.Text + "'," + chknew + "," + chkonsale + ",'" + txtareadescription.InnerText + "','" + imginstruction.ImageUrl + "','sada')");

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
                idproduct.Value = dt.Rows[0][0].ToString();
                // Set the cookie expiration date.
                idproduct.Expires = DateTime.Now.AddDays(1d);
                // Add the cookie.
                Response.Cookies.Add(idproduct);

                //int cont = 0;
                //string xs = "", s = "", m = "", l = "", xl = "", xxl = "", xxxl = "";
                //if (hdchkxs.Value == "true") { xs = "XS"; cont++; }
                //if (hdchks.Value == "true") { s = "S"; cont++; }
                //if (hdchkm.Value == "true") { m = "M"; cont++; }
                //if (hdchkl.Value == "true") { l = "L"; cont++; }
                //if (hdchkxl.Value == "true") { xl = "XL"; cont++; }
                //if (hdchkxxl.Value == "true") { xxl = "XXL"; cont++; }
                //if (hdchkxxxl.Value == "true") { xxxl = "XXXL"; cont++; }
                //string[] sizes = new string[] {xs, s, m, l, xl, xxl, xxxl};
                //foreach (var size in sizes)
                //{
                //    if (size != "")
                //    {
                //        datos.enviardatos("INSERT INTO tproductsizes (idproduct,size) VALUES (" + dt.Rows[0][0].ToString() + ",'" + size + "')");
                //        //txtname.Text = txtname.Text + size + ",";
                //    }

                //}

                //Session["idproduct"] = dt.Rows[0][0].ToString();
                generarcodigo(dt.Rows[0][0].ToString());
                datos.enviardatos("update tproduct set sku='" + txtsku.Text + "' where idproduct=" + dt.Rows[0][0].ToString());
            }
            else
            {
                Response.Write("<script>alert('Enter the name and composition of the product to be able to add it.')</script>");
            }
        }

    }
    protected void generarcodigo(string idproduct)
    {
        //DataTable dt = new DataTable();
        //dt = datos.extraedatos("SELECT MAX(idproduct) FROM tproduct");
        //if (dt.Rows[0][0].ToString().Equals("0"))
        //{
        //    dt.Rows.Clear();
        //    dt = datos.extraedatos("SELECT COUNT(sku)+1 FROM tproduct");
        //    //dt = datos.extraedatos("SELECT codirequi FROM tinicializarcodigos");
        //}
        //else
        //{
        //    dt.Rows.Clear();
        //    dt = datos.extraedatos("SELECT MAX(codirequi)+1 FROM tcodigosrequi");
        //}
        //Session["idproduct"] = dt.Rows[0][0].ToString();
        int ini = 0;
        string ceros = "";
        int tamaño = idproduct.Length;
        if (tamaño < 4)
        {
            ini = 4;
        }
        else
        {
            ini = 6;
        }
        while (ini - tamaño > 0)
        {
            ceros = ceros + "0";
            ini = ini - 1;
        }
        string codigo = ceros + idproduct;
        txtsku.Text = codigo;
    }

    // PRODUCT DATA
    protected void llenarlstcategory()
    {
        DataTable dt = new DataTable();
        lstcategory.Items.Clear();
        lstcategory.Items.Insert(0, new System.Web.UI.WebControls.ListItem { Value = "-1", Text = "--Select Category--" });
        lstcategory.Items[0].Attributes.Add("disabled", "");
        lstcategory.Items[0].Attributes.Add("selected", "");
        dt = datos.extraedatos("select idcategory, namecategory from tcategory");
        lstcategory.DataSource = dt;
        lstcategory.DataValueField = "idcategory";
        lstcategory.DataTextField = "namecategory";
        lstcategory.DataBind();
    }
    protected void lstcategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        string idcategory = lstcategory.SelectedValue;
        llenarlstsubcategory(idcategory);
    }
    protected void llenarlstsubcategory(string idcategory)
    {
        DataTable dt = new DataTable();
        lstsubcategory.Items.Clear();
        lstsubcategory.Items.Insert(0, new System.Web.UI.WebControls.ListItem { Value = "-1", Text = "--Select Sub-Category--" });
        lstsubcategory.Items[0].Attributes.Add("disabled", "");
        lstsubcategory.Items[0].Attributes.Add("selected", "");
        dt = datos.extraedatos("select idsubcategory, namesubcategory from tsubcategory where idcategory=" + idcategory);
        lstsubcategory.DataSource = dt;
        lstsubcategory.DataValueField = "idsubcategory";
        lstsubcategory.DataTextField = "namesubcategory";
        lstsubcategory.DataBind();
    }
}