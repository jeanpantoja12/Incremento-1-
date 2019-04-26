using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Routing;
public partial class principalmaster : System.Web.UI.MasterPage
{
    Consultassql datos = new Consultassql();
    settings db = new settings();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //loadmenu();
            //loadpreviewcart();
            this.txtpassword.Attributes.Add("onkeypress", "button_click(this,'" + this.btnloginmaster.ClientID + "')");
            this.txtsearch.Attributes.Add("onkeypress", "button_click(this,'" + this.btnsearch.ClientID + "')");
        }
        
        try
        {
            RegisterRoutes(RouteTable.Routes);
        }
        catch { }
        loadmenu();
        loadpreviewcart();
        loadusername();
        loaddatafooter();
        loadsocialnetwork();
    }
    protected void Application_Start(object sender, EventArgs e)
    {
        RegisterRoutes(RouteTable.Routes);
    }
    private static void RegisterRoutes(RouteCollection routes)
    {
        // public Route.MapPageRoute(
        //        string routeName,
        //        string routeUrl,
        //        string physicalFile,
        //        bool checkPhysicalUrlAccess,
        //        RouteValueDictionary defaults
        //);
        //routes.MapPageRoute("", "{detalle}/{id}/{*pagina}", "~/{detalle}.aspx");
        //routes.MapPageRoute("", "Contacto", "~/contacto.aspx");
        //routes.MapPageRoute("", "Carrito", "~/carrito.aspx");
        //routes.MapPageRoute("", "Busqueda", "~/Busqueda.aspx");
        //routes.MapPageRoute("", "Nosotros", "~/Nosotros.aspx");
        //routes.MapPageRoute("", "Carrito", "~/Carrito.aspx");
        //routes.MapPageRoute("", "Sesion", "~/Sesion.aspx");
        //routes.MapPageRoute("", "Registro", "~/Registro.aspx");
        //routes.MapPageRoute("", "Direccion", "~/Direccion.aspx");
        //routes.MapPageRoute("", "", "~/index.aspx");
        //routes.MapPageRoute("", "{detalle}/{id}", "~/Index.aspx");        

        routes.MapPageRoute("", "favorite-products", "~/favoriteproducts.aspx");
        routes.MapPageRoute("", "register", "~/registerform.aspx");

        routes.MapPageRoute("", "about-us", "~/aboutus.aspx");
        routes.MapPageRoute("", "shipping-policy", "~/shippingpolicy.aspx");
        routes.MapPageRoute("", "about-alpaca", "~/aboutalpaca.aspx");
        routes.MapPageRoute("", "privacy-policy", "~/privacypolicy.aspx");
        routes.MapPageRoute("", "faqs", "~/faqs.aspx");

        routes.MapPageRoute("", "my-profile", "~/myprofile.aspx");
        routes.MapPageRoute("", "order-history", "~/orderhistory.aspx");

        routes.MapPageRoute("", "shopping-cart-Step-1", "~/shoppingcart.aspx");
        routes.MapPageRoute("", "shopping-cart-Step-2", "~/shippingdata.aspx");
        routes.MapPageRoute("", "shopping-cart-Step-3", "~/methodpayment.aspx");
        routes.MapPageRoute("", "shopping-cart-Step-4", "~/purchasesummary.aspx");

        routes.MapPageRoute("", "c/{typecategory}/{namecategory}/{id}", "~/productcategory.aspx");
        routes.MapPageRoute("", "Products/{idproduct}/{nameproduct}", "~/detailproduct.aspx");
        routes.MapPageRoute("", "", "~/index.aspx");

        //routes.MapPageRoute("","Category/{action}/{categoryName}","~/categoriespage.aspx");
        //routes.MapPageRoute("", "", "~/index.aspx");
    }
    protected void loadsocialnetwork()
    {
        DataTable dt = new DataTable();
        dt = datos.extraedatos("SELECT count(*) FROM tsocialnetwork");
        if (dt.Rows[0][0].ToString() != "0")
        {
            System.Web.UI.HtmlControls.HtmlGenericControl a_sn;
            System.Web.UI.HtmlControls.HtmlGenericControl span_sn;
            dt.Rows.Clear();
            dt = datos.extraedatos("SELECT socialnetwork, url FROM tsocialnetwork WHERE active='1'");
            string[] socialN = new string[] { "Facebook", "Twitter", "Pinterest", "Instagram", "Whatsapp", "Youtube" };
            foreach (DataRow dtRow in dt.Rows)
            {
                string a_snclass = null;
                string span_snclass = null;
                string snurl = null;
                if (dtRow[0].ToString() == "Facebook")
                {
                    a_snclass = "btn btn-social-icon btn-sm btn-facebook";
                    span_snclass = "fa fa-facebook";
                    snurl = dtRow[1].ToString();
                }
                else
                {
                    if (dtRow[0].ToString() == "Twitter")
                    {
                        a_snclass = "btn btn-social-icon btn-sm btn-twitter";
                        span_snclass = "fa fa-twitter";
                        snurl = dtRow[1].ToString();
                    }
                    else
                    {
                        if (dtRow[0].ToString() == "Pinterest")
                        {
                            a_snclass = "btn btn-social-icon btn-sm btn-pinterest";
                            span_snclass = "fa fa-pinterest";
                            snurl = dtRow[1].ToString();
                        }
                        else
                        {
                            if (dtRow[0].ToString() == "Instagram")
                            {
                                a_snclass = "btn btn-social-icon btn-sm btn-instagram";
                                span_snclass = "fa fa-instagram";
                                snurl = dtRow[1].ToString();
                            }
                            else
                            {
                                if (dtRow[0].ToString() == "Whatsapp")
                                {
                                    a_snclass = "btn btn-social-icon btn-sm btn-whatsapp";
                                    span_snclass = "fa fa-whatsapp";
                                    snurl = "https://api.whatsapp.com/send?phone=" + dtRow[1].ToString();
                                }
                                else
                                {
                                    if (dtRow[0].ToString() == "Youtube")
                                    {
                                        a_snclass = "btn btn-social-icon btn-sm btn-pinterest";
                                        span_snclass = "fa fa-youtube-play";
                                        snurl = dtRow[1].ToString();
                                    }
                                }
                            }
                        }
                    }
                }
                a_sn = new System.Web.UI.HtmlControls.HtmlGenericControl("a");
                span_sn = new System.Web.UI.HtmlControls.HtmlGenericControl("span");

                plsocialnetwork.Controls.Add(a_sn);

                a_sn.Controls.Add(span_sn);
                a_sn.Attributes.Add("href", snurl);
                a_sn.Attributes.Add("class", a_snclass);
                a_sn.Attributes.Add("target", "_blank");
                a_sn.Attributes.Add("style", "border-radius:50%");

                span_sn.Attributes.Add("class", span_snclass);
            }
        }
    }
    protected void loaddatafooter()
    {
        DataTable dt = new DataTable();
        dt = datos.extraedatos("SELECT count(*) FROM tdataartvus");
        if (dt.Rows[0][0].ToString() != "0")
        {
            dt.Rows.Clear();
            dt = datos.extraedatos("SELECT namecompany, description, address, phone, email FROM tdataartvus");

            System.Web.UI.HtmlControls.HtmlGenericControl div_logo;
            System.Web.UI.HtmlControls.HtmlGenericControl p_description;
            System.Web.UI.HtmlControls.HtmlGenericControl p_address;
            System.Web.UI.HtmlControls.HtmlGenericControl i_address;
            System.Web.UI.HtmlControls.HtmlGenericControl span_address;
            System.Web.UI.HtmlControls.HtmlGenericControl p_phone;
            System.Web.UI.HtmlControls.HtmlGenericControl i_phone;
            System.Web.UI.HtmlControls.HtmlGenericControl span_phone;
            System.Web.UI.HtmlControls.HtmlGenericControl p_email;
            System.Web.UI.HtmlControls.HtmlGenericControl i_email;
            System.Web.UI.HtmlControls.HtmlGenericControl span_email;
            div_logo = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
            p_description = new System.Web.UI.HtmlControls.HtmlGenericControl("p");
            p_address = new System.Web.UI.HtmlControls.HtmlGenericControl("p");
            i_address = new System.Web.UI.HtmlControls.HtmlGenericControl("i");
            span_address = new System.Web.UI.HtmlControls.HtmlGenericControl("span");
            p_phone = new System.Web.UI.HtmlControls.HtmlGenericControl("p");
            i_phone = new System.Web.UI.HtmlControls.HtmlGenericControl("i");
            span_phone = new System.Web.UI.HtmlControls.HtmlGenericControl("span");
            p_email = new System.Web.UI.HtmlControls.HtmlGenericControl("p");
            i_email = new System.Web.UI.HtmlControls.HtmlGenericControl("i");
            span_email = new System.Web.UI.HtmlControls.HtmlGenericControl("span");

            pldataartvus.Controls.Add(div_logo);
            pldataartvus.Controls.Add(p_description);
            pldataartvus.Controls.Add(p_address);
            pldataartvus.Controls.Add(p_phone);
            pldataartvus.Controls.Add(p_email);

            div_logo.Attributes.Add("class", "logofooter");
            div_logo.InnerText = " " + dt.Rows[0][0].ToString();

            p_description.Attributes.Add("class", "description-company");
            p_description.InnerText = dt.Rows[0][1].ToString();

            p_address.Controls.Add(i_address);
            p_address.Controls.Add(span_address);
            i_address.Attributes.Add("class", "fa fa-map-pin");
            span_address.InnerText = " " + dt.Rows[0][2].ToString();

            p_phone.Controls.Add(i_phone);
            p_phone.Controls.Add(span_phone);
            i_phone.Attributes.Add("class", "fa fa-phone");
            span_phone.InnerText = " " + dt.Rows[0][3].ToString();

            p_email.Controls.Add(i_email);
            p_email.Controls.Add(span_email);
            i_email.Attributes.Add("class", "fa fa-envelope");
            span_email.InnerText = " " + dt.Rows[0][4].ToString();
        }
    }
    protected void btnloginmaster_Click(object sender, EventArgs e)
    {
        if (txtusername.Text != "" && txtpassword.Text != "")
        {
            DataTable dtuser = new DataTable();
            dtuser = datos.extraedatos("SELECT count(*) FROM tclient WHERE email='" + txtusername.Text + "' and passwd='" + txtpassword.Text + "'");
            if (dtuser.Rows[0][0].ToString() != "0")
            {
                dtuser.Rows.Clear();
                dtuser = datos.extraedatos("SELECT count(*) FROM tclient WHERE email='" + txtusername.Text + "' and passwd='" + txtpassword.Text + "' and usercondition=1");
                if (dtuser.Rows[0][0].ToString() != "0")
                {
                    dtuser.Rows.Clear();
                    //dtuser = datos.extraedatos("SELECT idclient, concat(firstname,' ',lastname) FROM tclient WHERE email='" + txtusername.Text + "' and passwd='" + txtpassword.Text + "'");
                    dtuser = datos.extraedatos("call " + db.dbName + ".loginclient1('" + txtusername.Text + "','" + txtpassword.Text + "')");

                    datos.enviardatos("UPDATE tclient SET sessioncounter=sessioncounter+1 WHERE idclient=" + dtuser.Rows[0][0].ToString());
                    DateTime now = DateTime.Now;
                    datos.enviardatos("INSERT INTO tuserlogin (idclient,datelogin) VALUES ("+ dtuser.Rows[0][0].ToString() + ", '"+ now.ToString("yyyy-MM-dd") + "')");
                    // Delete cookie
                    if (Request.Cookies["idclientuser"] != null)
                    {
                        HttpCookie myCookie = new HttpCookie("idclientuser");
                        myCookie.Expires = DateTime.Now.AddDays(-1d);
                        Response.Cookies.Add(myCookie);
                    }
                    // Make cookie
                    HttpCookie idclient = new HttpCookie("idclientuser");
                    idclient.Values["iduser"] = dtuser.Rows[0][0].ToString();
                    idclient.Values["userName"] = dtuser.Rows[0][1].ToString();
                    idclient.Expires = DateTime.Now.AddDays(1d);
                    Response.Cookies.Add(idclient);
                    lblalertlogin.Visible = true;
                    lblalertlogin.Attributes.Add("class", "alert alert-success");
                    lblalertlogin.Text = "Login is successful";
                    cleanshoppingcart();
                    invalidatecoupon();
                    Response.Redirect("/");
                }
                else
                {
                    //Response.Write("<script language=javascript>alert('Your user has not yet been activated.');</script>");
                    lblalertlogin.Visible = true;
                    lblalertlogin.Attributes.Add("class", "alert alert-warning");
                    lblalertlogin.Text = "Your user has not yet been activated";
                    //Response.Redirect("index.aspx");
                }

            }
            else
            {
                //ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                //Response.Write("<script language=javascript>alert('Username or password incorrect');</script>");
                lblalertlogin.Visible = true;
                lblalertlogin.Attributes.Add("class", "alert alert-danger");
                lblalertlogin.Text = "Username or password incorrect";
                //Response.Redirect("index.aspx");
            }
            loadusername();
        }
        else
        {
            lblalertlogin.Visible = true;
            lblalertlogin.Attributes.Add("class", "alert alert-info");
            lblalertlogin.Text = "Enter your username and password";
        }
    }
    protected void loadusername()
    {
        System.Web.UI.HtmlControls.HtmlGenericControl span_username;
        if (Request.Cookies["idclientuser"] != null)
        {
            //HttpCookie idclient = Request.Cookies["idprevclient"];
            string username = Server.HtmlDecode(Request.Cookies["idclientuser"]["userName"]);
            linklogin.Visible = false;
            linkregister.Visible = false;
            lblbienvenido.Visible = true;
            linkusername.Visible = true;
            myaccount.Visible = true;
            btnlogout.Visible = true;
            accountmobile.Visible = true;
            liloginmobile.Visible = false;
            liregistermobile.Visible = false;


            span_username = new System.Web.UI.HtmlControls.HtmlGenericControl("span");

            plusername.Controls.Add(span_username);
            span_username.InnerText = username;
        }
        else
        {
            linklogin.Visible = true;
            linkregister.Visible = true;
            lblbienvenido.Visible = false;
            linkusername.Visible = false;
            btnlogout.Visible = false;
            liloginmobile.Visible = true;
            liregistermobile.Visible = true;
        }
    }
    protected void btnlogoutmaster_Click(object sender, EventArgs e)
    {
        // Delete cookie
        if (Request.Cookies["idclientuser"] != null)
        {
            HttpCookie myCookie = new HttpCookie("idclientuser");
            myCookie.Expires = DateTime.Now.AddDays(-1d);
            Response.Cookies.Add(myCookie);
            linklogin.Visible = true;
            linkregister.Visible = true;
            lblbienvenido.Visible = false;
            linkusername.Visible = false;
            btnlogout.Visible = false;
            liloginmobile.Visible = true;
            liregistermobile.Visible = true;
            Response.Redirect("/");
        }
        //Response.Write("<script language=javascript>window.addEventListener('onload',function(){__doPostBack('', '')});</script>");
    }
    protected void loadmenu()
    {
        
        System.Web.UI.HtmlControls.HtmlGenericControl li_menu;
        System.Web.UI.HtmlControls.HtmlGenericControl a_menu;

        System.Web.UI.HtmlControls.HtmlGenericControl span_text_a;
        System.Web.UI.HtmlControls.HtmlGenericControl span_icon_a;
        System.Web.UI.HtmlControls.HtmlGenericControl ul_submenu;
        System.Web.UI.HtmlControls.HtmlGenericControl li_submenu;
        System.Web.UI.HtmlControls.HtmlGenericControl a_submenu;

        DataTable dtcollection1 = new DataTable();
        dtcollection1 = datos.extraedatos("SELECT count(*) FROM tcollection");
        if (dtcollection1.Rows[0][0].ToString() != "0")
        {
            dtcollection1.Rows.Clear();
            dtcollection1 = datos.extraedatos("SELECT count(*) FROM tmenu");

            if (dtcollection1.Rows[0][0].ToString() != "0")
            {
                dtcollection1.Rows.Clear();
                dtcollection1 = datos.extraedatos("SELECT menu6, menu7, menu8 FROM tmenu");
                if (dtcollection1.Rows[0][0].ToString() == "1")
                {
                    li_menu = new System.Web.UI.HtmlControls.HtmlGenericControl("li");
                    a_menu = new System.Web.UI.HtmlControls.HtmlGenericControl("a");
                    span_text_a = new System.Web.UI.HtmlControls.HtmlGenericControl("span");
                    span_icon_a = new System.Web.UI.HtmlControls.HtmlGenericControl("span");
                    ul_submenu = new System.Web.UI.HtmlControls.HtmlGenericControl("ul");
                    placeholder_menu.Controls.Add(li_menu);
                    li_menu.Controls.Add(a_menu);
                    li_menu.Controls.Add(ul_submenu);

                    a_menu.Controls.Add(span_text_a);
                    a_menu.Controls.Add(span_icon_a);

                    li_menu.Attributes.Add("class", "dropdown");
                    a_menu.Attributes.Add("href", "#");
                    a_menu.Attributes.Add("class", "dropdown-toggle menu__link level-1");
                    a_menu.Attributes.Add("data-toggle", "dropdown");
                    span_text_a.InnerText = "Collections ";
                    span_icon_a.Attributes.Add("class", "caret");

                    dtcollection1.Rows.Clear();
                    dtcollection1 = datos.extraedatos("SELECT idcollection, name FROM tcollection");
                    foreach (DataRow dtRow in dtcollection1.Rows)
                    {
                        li_submenu = new System.Web.UI.HtmlControls.HtmlGenericControl("li");
                        a_submenu = new System.Web.UI.HtmlControls.HtmlGenericControl("a");

                        ul_submenu.Controls.Add(li_submenu);
                        li_submenu.Controls.Add(a_submenu);

                        ul_submenu.Attributes.Add("class", "dropdown-menu menu_level-2");

                        //string urlcollection = "productcategory.aspx?collection=" + dtRow[0].ToString();
                        string namecollection = (dtRow[1].ToString()).Replace(" ", "-").ToLower();
                        string urlcollection = "../../../c/Collection/" + namecollection + "/" + dtRow[0].ToString();
                        a_submenu.Attributes.Add("href", urlcollection);
                        a_submenu.Attributes.Add("class", "menu__link level-2");
                        a_submenu.InnerText = dtRow[1].ToString();
                    }
                }
            }
            
        }


        DataTable dt = new DataTable();
        dt = datos.extraedatos("SELECT count(*) FROM tmenu");
        if (dt.Rows[0][0].ToString() != "0")
        {
            dt.Rows.Clear();
            dt = datos.extraedatos("SELECT menu1, menu2, menu3 FROM tmenu");
            int cont = 0;
            foreach (DataRow dtRow in dt.Rows)
            {
                foreach (DataColumn dtColumn in dt.Columns)
                {
                    cont++;
                    if (dtRow[dtColumn].ToString() != "-1")
                    {
                        DataTable dtsubmenu = new DataTable();
                        dtsubmenu = datos.extraedatos("SELECT count(*) FROM tsubcategory WHERE idcategory=" + dtRow[dtColumn].ToString());
                        if (dtsubmenu.Rows[0][0].ToString() == "0")
                        {
                            DataTable dt1 = new DataTable();
                            dt1 = datos.extraedatos("SELECT namecategory FROM tcategory WHERE idcategory=" + dtRow[dtColumn].ToString());
                            li_menu = new System.Web.UI.HtmlControls.HtmlGenericControl("li");
                            a_menu = new System.Web.UI.HtmlControls.HtmlGenericControl("a");

                            placeholder_menu.Controls.Add(li_menu);
                            li_menu.Controls.Add(a_menu);
                            //string url = "productcategory.aspx?category=" + dtRow[dtColumn].ToString();
                            string namecategory = (dt1.Rows[0][0].ToString()).Replace(" ", "-").ToLower();
                            string url = "../../../c/Category/" + namecategory + "/" + dtRow[dtColumn].ToString();
                            a_menu.Attributes.Add("href", url);
                            a_menu.Attributes.Add("class", "menu__link level-1");
                            a_menu.InnerText = dt1.Rows[0][0].ToString();
                        }
                        else
                        {
                            DataTable dt2 = new DataTable();
                            dt2 = datos.extraedatos("SELECT namecategory FROM tcategory WHERE idcategory=" + dtRow[dtColumn].ToString());
                            li_menu = new System.Web.UI.HtmlControls.HtmlGenericControl("li");
                            a_menu = new System.Web.UI.HtmlControls.HtmlGenericControl("a");
                            span_text_a = new System.Web.UI.HtmlControls.HtmlGenericControl("span");
                            span_icon_a = new System.Web.UI.HtmlControls.HtmlGenericControl("span");
                            ul_submenu = new System.Web.UI.HtmlControls.HtmlGenericControl("ul");


                            placeholder_menu.Controls.Add(li_menu);
                            li_menu.Controls.Add(a_menu);
                            li_menu.Controls.Add(ul_submenu);

                            a_menu.Controls.Add(span_text_a);
                            a_menu.Controls.Add(span_icon_a);
                            
                            li_menu.Attributes.Add("class", "dropdown");
                            //string url = "productcategory.aspx?category=" + dtRow[dtColumn].ToString();
                           // string namecategory = (dt2.Rows[0][0].ToString()).Replace(" ", "-").ToLower();
                            //string url = "../../../c/Category/" + namecategory + "/" + dtRow[dtColumn].ToString();
                           // a_menu.Attributes.Add("href", url);
                            a_menu.Attributes.Add("class", "dropdown-toggle disabled menu__link level-1");
                            a_menu.Attributes.Add("data-toggle", "dropdown");
                            span_text_a.InnerText = dt2.Rows[0][0].ToString() + " ";
                            span_icon_a.Attributes.Add("class", "caret");

                            

                            DataTable dtsubmenu2 = new DataTable();
                            dtsubmenu2 = datos.extraedatos("SELECT idsubcategory, namesubcategory FROM tsubcategory WHERE idcategory=" + dtRow[dtColumn].ToString());
                            foreach (DataRow dtRowsub in dtsubmenu2.Rows)
                            {
                                
                                li_submenu = new System.Web.UI.HtmlControls.HtmlGenericControl("li");
                                a_submenu = new System.Web.UI.HtmlControls.HtmlGenericControl("a");
                                
                                ul_submenu.Controls.Add(li_submenu);
                                li_submenu.Controls.Add(a_submenu);
                                                                
                                ul_submenu.Attributes.Add("class", "dropdown-menu menu_level-2");

                                //string urlsub = "productcategory.aspx?subcategory=" + dtRowsub[0].ToString();
                                string namesubcategory = (dtRowsub[1].ToString()).Replace(" ", "-").ToLower();
                                string urlsub = "../../../c/Subcategory/" + namesubcategory + "/" + dtRowsub[0].ToString();
                                a_submenu.Attributes.Add("href", urlsub);
                                a_submenu.Attributes.Add("class", "menu__link level-2");
                                a_submenu.InnerText = dtRowsub[1].ToString();
                            }
                            
                        }
                    }

                }
            }
        }
        
        
    }

    protected void loadpreviewcart()
    {
        if (Request.Cookies["idclientuser"] != null)
        {
            string iduser = Server.HtmlEncode(Request.Cookies["idclientuser"]["iduser"]);

            System.Web.UI.HtmlControls.HtmlGenericControl tr_preview;
            System.Web.UI.HtmlControls.HtmlGenericControl td_image;
            System.Web.UI.HtmlControls.HtmlGenericControl div_image;
            System.Web.UI.HtmlControls.HtmlGenericControl img_image;
            System.Web.UI.HtmlControls.HtmlGenericControl td_name;
            System.Web.UI.HtmlControls.HtmlGenericControl div_name;
            System.Web.UI.HtmlControls.HtmlGenericControl h3_name;
            System.Web.UI.HtmlControls.HtmlGenericControl td_quantity;
            System.Web.UI.HtmlControls.HtmlGenericControl div_quantity;
            System.Web.UI.HtmlControls.HtmlGenericControl p_quantity;
            System.Web.UI.HtmlControls.HtmlGenericControl td_price;
            System.Web.UI.HtmlControls.HtmlGenericControl div_price;
            System.Web.UI.HtmlControls.HtmlGenericControl p_price;

            DataTable dtcount = new DataTable();
            dtcount = datos.extraedatos("SELECT count(*) FROM tcart WHERE idclient=" + iduser + " and state=1");
            if (dtcount.Rows[0][0].ToString() != "0")
            {
                DataTable dtmaxcart, dtproduct = new DataTable();
                dtmaxcart = datos.extraedatos("SELECT max(idcart) FROM tcart WHERE idclient=" + iduser + " and state=1");
                dtproduct = datos.extraedatos("SELECT (select url from tproductimage tpi where tpi.idproduct=tp.idproduct order by tpi.idproductimage asc limit 0,1), tp.nameproduct, sum(tdc.quantity), format(round(sum(tdc.totalitem),2),2), round(sum(tsc.offer),2), tp.idproduct " +
                    "FROM tdetailcart tdc " +
                    "LEFT JOIN tsizecolor tsc ON tdc.idsizecolor=tsc.idsizecolor " +
                    "LEFT JOIN tproduct tp ON tsc.idproduct=tp.idproduct " +
                    "LEFT JOIN tcart tcar ON tdc.idcart=tcar.idcart " +
                    "WHERE tcar.idcart=" + dtmaxcart.Rows[0][0].ToString() + " " +
                    "group by tp.idproduct");
                foreach (DataRow dtRowProduct in dtproduct.Rows)
                {
                    tr_preview = new System.Web.UI.HtmlControls.HtmlGenericControl("tr");
                    td_image = new System.Web.UI.HtmlControls.HtmlGenericControl("td");
                    div_image = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
                    img_image = new System.Web.UI.HtmlControls.HtmlGenericControl("img");
                    td_name = new System.Web.UI.HtmlControls.HtmlGenericControl("td");
                    div_name = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
                    h3_name = new System.Web.UI.HtmlControls.HtmlGenericControl("h3");
                    td_quantity = new System.Web.UI.HtmlControls.HtmlGenericControl("td");
                    div_quantity = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
                    p_quantity = new System.Web.UI.HtmlControls.HtmlGenericControl("p");
                    td_price = new System.Web.UI.HtmlControls.HtmlGenericControl("td");
                    div_price = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
                    p_price = new System.Web.UI.HtmlControls.HtmlGenericControl("p");

                    plpreviewcart.Controls.Add(tr_preview);

                    tr_preview.Controls.Add(td_image);
                    tr_preview.Controls.Add(td_name);
                    tr_preview.Controls.Add(td_quantity);
                    tr_preview.Controls.Add(td_price);

                    td_image.Controls.Add(div_image);
                    div_image.Controls.Add(img_image);

                    td_name.Controls.Add(div_name);
                    div_name.Controls.Add(h3_name);

                    td_quantity.Controls.Add(div_quantity);
                    div_quantity.Controls.Add(p_quantity);

                    td_price.Controls.Add(div_price);
                    div_price.Controls.Add(p_price);

                    div_image.Attributes.Add("class", "image");
                    img_image.Attributes.Add("src", "../../" +dtRowProduct[0].ToString());

                    div_name.Attributes.Add("class", "name");
                    h3_name.InnerText = dtRowProduct[1].ToString();

                    div_quantity.Attributes.Add("class", "quantity");
                    p_quantity.InnerText = dtRowProduct[2].ToString();

                    div_price.Attributes.Add("class", "price-item");
                    p_price.InnerText = dtRowProduct[3].ToString();
                    p_price.Attributes.Add("class", "costs");
                }

                DataTable dtsubtotal = new DataTable();
                dtsubtotal = datos.extraedatos("SELECT format(subtotal,2) FROM tcart WHERE idcart=" + dtmaxcart.Rows[0][0].ToString());

                System.Web.UI.HtmlControls.HtmlGenericControl span_subtotal1;
                System.Web.UI.HtmlControls.HtmlGenericControl span_subtotal2;
                span_subtotal1 = new System.Web.UI.HtmlControls.HtmlGenericControl("span");
                span_subtotal2 = new System.Web.UI.HtmlControls.HtmlGenericControl("span");

                plsubtotal1.Controls.Add(span_subtotal1);
                plsubtotal2.Controls.Add(span_subtotal2);

                if (dtsubtotal.Rows[0][0].ToString() != "0")
                {
                    span_subtotal1.Attributes.Add("class", "subt1 costs");
                    span_subtotal1.InnerText = dtsubtotal.Rows[0][0].ToString();
                    span_subtotal2.Attributes.Add("class", "subt1 costs");
                    span_subtotal2.InnerText = dtsubtotal.Rows[0][0].ToString();

                    DataTable dtstatepurchase = new DataTable();
                    dtstatepurchase = datos.extraedatos("SELECT purchasestatus FROM tcart WHERE idcart=" + dtmaxcart.Rows[0][0].ToString());
                    if (dtstatepurchase.Rows[0][0].ToString() == "1")
                    {
                        carttotal.Attributes.Add("href", "shopping-cart-Step-1"); //shoppingcart.aspx
                    }
                    else
                    {
                        if (dtstatepurchase.Rows[0][0].ToString() == "2")
                        {
                            carttotal.Attributes.Add("href", "shopping-cart-Step-2"); //shippingdata.aspx
                        }
                        else
                        {
                            if (dtstatepurchase.Rows[0][0].ToString() == "3")
                            {
                                carttotal.Attributes.Add("href", "shopping-cart-Step-3"); //methodpayment.aspx
                            }
                        }
                    }
                    
                }
                else
                {
                    loademptycart();
                }
            }
            else
            {
                loademptycart();
            }
            
        }
        else
        {
            loademptycart();
        }
        
    }
    protected void loademptycart()
    {
        System.Web.UI.HtmlControls.HtmlGenericControl span_subtotal1;
        span_subtotal1 = new System.Web.UI.HtmlControls.HtmlGenericControl("span");

        plsubtotal1.Controls.Add(span_subtotal1);
        span_subtotal1.InnerText = "$0.00";
        carttotal.Attributes.Remove("href");

        System.Web.UI.HtmlControls.HtmlGenericControl tr_empty;
        System.Web.UI.HtmlControls.HtmlGenericControl td_empty;
        tr_empty = new System.Web.UI.HtmlControls.HtmlGenericControl("tr");
        td_empty = new System.Web.UI.HtmlControls.HtmlGenericControl("td");

        trheadprev.Visible = false;
        tbodystyle.Attributes.Add("style", "overflow-Y:hidden");
        prevfooter.Visible = false;

        plpreviewcart.Controls.Add(tr_empty);
        tr_empty.Controls.Add(td_empty);
        tr_empty.Attributes.Add("style", "display:block;width:243px;border:0");

        td_empty.InnerText = "Your cart is empty";
        td_empty.Attributes.Add("style", "color:#000;font-weight:700;padding:7em 5em 0");
    }


    protected void btnsendmessage_Click(object sender, EventArgs e)
    {
        if (txtname.Text != "" && txtemail.Text != "" && txtmessage.Text != "")
        {
            string body = "<html><body><div style='text-align: left;'>" +
                "<p><span style='font-weight:700'>Full Name:</span> " + txtname.Text + "</p>" +
                "<p><span style='font-weight:700'>Email:</span> " + txtemail.Text + "</p>" +
                "<p><span style='font-weight:700'>Content of the message:</span></p>" +
                "<p>" + txtmessage.Text + "</p>" +
                "</div></body></html>";
            sendemail mail = new sendemail();
            try
            {
                mail.email("info@artvus.com", "Contact us, was sent out", body);
                lblmessagesend.Visible = true;
                lblmessagesend.Attributes.Add("class", "alert alert-success");
                lblmessagesend.Text = "Your message was sent successfully. We will respond shortly.";
                // The delivery of the mail was satisfactory, the administrator will contact you as soon as possible
                txtname.Text = "";
                txtemail.Text = "";
                txtmessage.Text = "";
            }
            catch (Exception ex)
            {
                lblmessagesend.Visible = true;
                lblmessagesend.Attributes.Add("class", "alert alert-danger");
                lblmessagesend.Text = "Sorry, your message could not be sent. Please try again.";
                //An error occurred while sending the mail, if it is urgent you can send to contact@artvus.com
                txtname.Text = "";
                txtemail.Text = "";
                txtmessage.Text = "";
            }
        }
        else
        {
            txtname.Attributes.Add("style", "border:1px solid #ccc");
            txtemail.Attributes.Add("style", "border:1px solid #ccc");
            txtmessage.Attributes.Add("style", "border:1px solid #ccc");
            if (txtname.Text == "" ) { txtname.Attributes.Add("style", "border:1px solid red"); }
            if (txtemail.Text == "" ) { txtemail.Attributes.Add("style", "border:1px solid red"); }
            if (txtmessage.Text == "" ) { txtmessage.Attributes.Add("style", "border:1px solid red"); }
            lblmessagesend.Visible = true;
            lblmessagesend.Attributes.Add("class", "alert alert-warning");
            lblmessagesend.Text = "Please fill in all the fields.";
        }

    }

    protected void cleanshoppingcart()
    {
        DataTable dtcart = new DataTable();
        dtcart = datos.extraedatos("SELECT idcart, datecreatecart FROM tcart WHERE state=1");
        foreach (DataRow dtRow in dtcart.Rows)
        {
            DateTime now = DateTime.Now;
            DateTime datecart = Convert.ToDateTime(dtRow[1].ToString());
            DateTime datelimit = datecart.AddHours(24);
            if (datelimit < now)
            {
                datos.enviardatos("DELETE FROM tdestination WHERE idcart=" + dtRow[0].ToString());
                DataTable dtdetailcart = new DataTable();
                dtdetailcart = datos.extraedatos("SELECT iddetailcart,idsizecolor,quantity FROM tdetailcart WHERE idcart=" + dtRow[0].ToString());
                foreach (DataRow dtdetRow in dtdetailcart.Rows)
                {
                    datos.enviardatos("UPDATE tsizecolor SET stock=stock+" + dtdetRow[2].ToString() + " WHERE idsizecolor=" + dtdetRow[1].ToString());
                }
                datos.enviardatos("DELETE FROM tdetailcart WHERE idcart=" + dtRow[0].ToString());
                datos.enviardatos("DELETE FROM tcart WHERE idcart=" + dtRow[0].ToString());
            }
        }
    }
    protected void invalidatecoupon()
    {
        DateTime now = DateTime.Now;
        datos.enviardatos("update tcouponlocation set state = 2 where dateexpiration < '" + now.ToString("yyyy-MM-dd- H:mm:ss") + "'");
        datos.enviardatos("update tcouponclient set used = 1 where dateexpiration < '" + now.ToString("yyyy-MM-dd- H:mm:ss") + "'");
        //delimiter
        //CREATE TRIGGER expirationcoupon BEFORE INSERT
        //    ON tdetailcart FOR EACH ROW BEGIN
        //        DECLARE datenow DATE;
        //        set datenow = CURDATE();
        //        update tcouponlocation set state = 2 where dateexpiration < datenow;
        //        update tcouponclient set used = 1 where dateexpiration < datenow;
        //        END;
        //delimiter;
    }

    protected void btnsearch_Click(object sender, EventArgs e)
    {
        if (txtsearch.Text != "")
        {
            Session["globalsearch"] = null;
            Session["globalsearch"] = txtsearch.Text;
            Response.Redirect("/c/Products/Search/" + (txtsearch.Text).Replace(" ","-"));
        }
    }
}

