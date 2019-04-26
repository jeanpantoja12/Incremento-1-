using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Web.Routing;

public partial class index : System.Web.UI.Page
{
    Consultassql datos = new Consultassql();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //slider();
            loadnew();
            loadslider();
            loadfeaturedproducts();
            loadtagcloud();
            loadadvertisements();
        }
    }
    
    // SLIDER
    protected void loadslider()
    {
        System.Web.UI.HtmlControls.HtmlGenericControl li_indicators;
        System.Web.UI.HtmlControls.HtmlGenericControl div_item;
        System.Web.UI.HtmlControls.HtmlGenericControl a_item;
        System.Web.UI.HtmlControls.HtmlGenericControl img_slide;
        System.Web.UI.HtmlControls.HtmlGenericControl div_carousel;

        DataTable dtslider = new DataTable();
        dtslider = datos.extraedatos("SELECT slider1, slider2, slider3, slider4, slider5, slider6, numslide, link1, link2, link3, link4, link5, link6 FROM tsliderindex");
        foreach (DataRow dtRow in dtslider.Rows)
        {
            int count = 0;
            foreach (DataColumn dtColumn in dtslider.Columns)
            {
                count++;
                if (int.Parse(dtRow[6].ToString()) >= count )
                {
                    li_indicators = new System.Web.UI.HtmlControls.HtmlGenericControl("li");
                    div_item = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
                    a_item = new System.Web.UI.HtmlControls.HtmlGenericControl("a");
                    img_slide = new System.Web.UI.HtmlControls.HtmlGenericControl("img");
                    div_carousel = new System.Web.UI.HtmlControls.HtmlGenericControl("div");

                    plsliderindicator.Controls.Add(li_indicators);
                    li_indicators.Attributes.Add("data-target", "#carousel-example-generic");
                    li_indicators.Attributes.Add("data-slide-to", (count-1).ToString());
                    if (count == 1)
                    {
                        li_indicators.Attributes.Add("class", "active");
                    }


                    plsliderimage.Controls.Add(div_item);

                    div_item.Controls.Add(a_item);
                    div_item.Controls.Add(div_carousel);

                    a_item.Controls.Add(img_slide);
                    if (count == 1)
                    {
                        div_item.Attributes.Add("class", "item active slide");
                    }
                    else
                    {
                        div_item.Attributes.Add("class", "item slide");
                    }

                    if (dtRow[count+6].ToString() != "")
                    {
                        a_item.Attributes.Add("href", dtRow[count + 6].ToString());
                    }
                    img_slide.Attributes.Add("src", dtRow[dtColumn].ToString());
                    img_slide.Attributes.Add("alt", "slide " + count.ToString());
                    img_slide.Attributes.Add("style", "width:100%");

                    div_carousel.Attributes.Add("class", "carousel-caption");
                    div_carousel.InnerText = "...";
                }
                else
                {
                    break;
                }
            }
        }
        


    }
    //protected void slider()
    //{
    //    DataTable dt = new DataTable();
    //    dt = datos.extraedatos("SELECT numslide FROM tsliderindex");
    //    if (dt.Rows[0][0].ToString() == "1")
    //    {
    //        slide2.Visible = false;
    //        slide3.Visible = false;
    //        slide4.Visible = false;
    //        slide5.Visible = false;
    //        slide6.Visible = false;
            
    //        slide2indicator.Visible = false;
    //        slide3indicator.Visible = false;
    //        slide4indicator.Visible = false;
    //        slide5indicator.Visible = false;
    //        slide6indicator.Visible = false;
    //    }
    //    else
    //    {
    //        if (dt.Rows[0][0].ToString() == "2")
    //        {
    //            slide2.Visible = true;
    //            slide3.Visible = false;
    //            slide4.Visible = false;
    //            slide5.Visible = false;
    //            slide6.Visible = false;
                
    //            slide2indicator.Visible = true;
    //            slide3indicator.Visible = false;
    //            slide4indicator.Visible = false;
    //            slide5indicator.Visible = false;
    //            slide6indicator.Visible = false;
    //        }
    //        else
    //        {
    //            if (dt.Rows[0][0].ToString() == "3")
    //            {
    //                slide2.Visible = true;
    //                slide3.Visible = true;
    //                slide4.Visible = false;
    //                slide5.Visible = false;
    //                slide6.Visible = false;
                    
    //                slide2indicator.Visible = true;
    //                slide3indicator.Visible = true;
    //                slide4indicator.Visible = false;
    //                slide5indicator.Visible = false;
    //                slide6indicator.Visible = false;
    //            }
    //            else
    //            {
    //                if (dt.Rows[0][0].ToString() == "4")
    //                {
    //                    slide2.Visible = true;
    //                    slide3.Visible = true;
    //                    slide4.Visible = true;
    //                    slide5.Visible = false;
    //                    slide6.Visible = false;
                        
    //                    slide2indicator.Visible = true;
    //                    slide3indicator.Visible = true;
    //                    slide4indicator.Visible = true;
    //                    slide5indicator.Visible = false;
    //                    slide6indicator.Visible = false;
    //                }
    //                else
    //                {
    //                    if (dt.Rows[0][0].ToString() == "5")
    //                    {
    //                        slide2.Visible = true;
    //                        slide3.Visible = true;
    //                        slide4.Visible = true;
    //                        slide5.Visible = true;
    //                        slide6.Visible = false;
                            
    //                        slide2indicator.Visible = true;
    //                        slide3indicator.Visible = true;
    //                        slide4indicator.Visible = true;
    //                        slide5indicator.Visible = true;
    //                        slide6indicator.Visible = false;
    //                    }
    //                    else
    //                    {
    //                        if (dt.Rows[0][0].ToString() == "6")
    //                        {
    //                            slide2.Visible = true;
    //                            slide3.Visible = true;
    //                            slide4.Visible = true;
    //                            slide5.Visible = true;
    //                            slide6.Visible = true;

    //                            slide2indicator.Visible = true;
    //                            slide3indicator.Visible = true;
    //                            slide4indicator.Visible = true;
    //                            slide5indicator.Visible = true;
    //                            slide6indicator.Visible = true;
    //                        }
    //                    }
    //                }
    //            }
    //        }
    //    }
    //}

    // ADVERTISEMENTS
    protected void loadadvertisements()
    {
        DataTable dt = new DataTable();
        dt = datos.extraedatos("SELECT count(*) FROM tadvertisements");
        if (dt.Rows[0][0].ToString() != "0")
        {
            dt.Rows.Clear();
            dt = datos.extraedatos("SELECT src_ad1, url_ad1, src_ad2, url_ad2, src_ad3, url_ad3 FROM tadvertisements");
            ad_img1.Src = dt.Rows[0][0].ToString();
            ad_url1.HRef = dt.Rows[0][1].ToString();
            ad_img2.Src = dt.Rows[0][2].ToString();
            ad_url2.HRef = dt.Rows[0][3].ToString();
            ad_img3.Src = dt.Rows[0][4].ToString();
            ad_url3.HRef = dt.Rows[0][5].ToString();
        }
    }
    // NEW
    protected void loadnew()
    {
        System.Web.UI.HtmlControls.HtmlGenericControl div_thumbnail;
        System.Web.UI.HtmlControls.HtmlGenericControl a_link;
        //LinkButton lb_link;
        System.Web.UI.HtmlControls.HtmlGenericControl div_newicon;
        System.Web.UI.HtmlControls.HtmlGenericControl p_newicon;
        System.Web.UI.HtmlControls.HtmlGenericControl div_onsaleicon;
        System.Web.UI.HtmlControls.HtmlGenericControl p_onsaleicon;
        System.Web.UI.HtmlControls.HtmlGenericControl div_imagesize;
        System.Web.UI.HtmlControls.HtmlGenericControl img_imgshow;
        System.Web.UI.HtmlControls.HtmlGenericControl img_imghidden;
        System.Web.UI.HtmlControls.HtmlGenericControl div_description;
        System.Web.UI.HtmlControls.HtmlGenericControl h3_name;
        System.Web.UI.HtmlControls.HtmlGenericControl p_composition;
        System.Web.UI.HtmlControls.HtmlGenericControl p_price;
        System.Web.UI.HtmlControls.HtmlGenericControl div_divider;
        System.Web.UI.HtmlControls.HtmlGenericControl p_details;
        System.Web.UI.HtmlControls.HtmlGenericControl span_details;
        System.Web.UI.HtmlControls.HtmlGenericControl i_icondet;
        System.Web.UI.HtmlControls.HtmlGenericControl span_shopnow;

        

        DataTable dt = new DataTable();
        dt = datos.extraedatos("SELECT tp.idproduct, tp.nameproduct, tp.composition, tp.newproduct, tp.onsale FROM tproduct tp LEFT JOIN tsizecolor tsc ON tp.idproduct=tsc.idproduct WHERE tp.newproduct=" + 1 + " and (tp.disable is null or tp.disable='') GROUP BY tp.idproduct HAVING SUM(tsc.stock)<>0 ORDER BY tp.idproduct DESC limit 0,10 ");
        foreach (DataRow dtRow in dt.Rows)
        {
            div_thumbnail = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
            a_link = new System.Web.UI.HtmlControls.HtmlGenericControl("a");
            //lb_link = new LinkButton();
            div_newicon = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
            p_newicon = new System.Web.UI.HtmlControls.HtmlGenericControl("p");
            div_onsaleicon = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
            p_onsaleicon = new System.Web.UI.HtmlControls.HtmlGenericControl("p");
            div_imagesize = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
            img_imgshow = new System.Web.UI.HtmlControls.HtmlGenericControl("img");
            img_imghidden = new System.Web.UI.HtmlControls.HtmlGenericControl("img");
            div_description = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
            h3_name = new System.Web.UI.HtmlControls.HtmlGenericControl("h3");
            p_composition = new System.Web.UI.HtmlControls.HtmlGenericControl("p");
            p_price = new System.Web.UI.HtmlControls.HtmlGenericControl("p");
            div_divider = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
            p_details = new System.Web.UI.HtmlControls.HtmlGenericControl("p");
            span_details = new System.Web.UI.HtmlControls.HtmlGenericControl("span");
            i_icondet = new System.Web.UI.HtmlControls.HtmlGenericControl("i");
            span_shopnow = new System.Web.UI.HtmlControls.HtmlGenericControl("span");

            placeholder_new.Controls.Add(div_thumbnail);

            div_thumbnail.Controls.Add(a_link);

            a_link.Controls.Add(div_newicon);
            a_link.Controls.Add(div_onsaleicon);
            a_link.Controls.Add(div_imagesize);
            a_link.Controls.Add(div_description);

            div_newicon.Controls.Add(p_newicon);
            div_onsaleicon.Controls.Add(p_onsaleicon);

            div_imagesize.Controls.Add(img_imgshow);
            div_imagesize.Controls.Add(img_imghidden);

            div_description.Controls.Add(h3_name);
            div_description.Controls.Add(p_composition);
            div_description.Controls.Add(p_price);
            div_description.Controls.Add(div_divider);
            div_description.Controls.Add(p_details);
            p_details.Controls.Add(span_details);
            span_details.Controls.Add(i_icondet);
            span_details.Controls.Add(span_shopnow);

            DataTable dt1, dt2, dt3 = new DataTable();
            dt1 = datos.extraedatos("select count(*) from tproductimage where idproduct=" + dtRow[0].ToString() + " and position=" + 1);
            if (dt1.Rows[0][0].ToString() != "0")
            {
                dt1.Rows.Clear();
                dt1 = datos.extraedatos("select substring(urlresize1 from 3) as url from tproductimage where idproduct=" + dtRow[0].ToString() + " and position=" + 1);
            }
            dt2 = datos.extraedatos("select count(*) from tproductimage where idproduct=" + dtRow[0].ToString() + " and position=" + 2);
            if (dt2.Rows[0][0].ToString() != "0")
            {
                dt2.Rows.Clear();
                dt2 = datos.extraedatos("select substring(urlresize1 from 3) as url from tproductimage where idproduct=" + dtRow[0].ToString() + " and position=" + 2);
            }
            
            dt3 = datos.extraedatos("select format(min(price),2) from tsizecolor where idproduct=" + dtRow[0].ToString());

            // <div class="newicon">
            div_newicon.Attributes.Add("class", "newicon");
            p_newicon.InnerText = "NEW";
            
            // <div class="onsaleicon">
            div_onsaleicon.Attributes.Add("class", "onsaleicon");
            p_onsaleicon.InnerText = "ON SALE";
            if (dtRow[4].ToString() == "0")
            {
                div_onsaleicon.Attributes.Add("class", "onsaleicon hidden");
            }
            // <div class="imgsize">
            div_imagesize.Attributes.Add("class", "imgsize");
            img_imgshow.Attributes.Add("class", "imgshow");
            img_imgshow.Attributes.Add("src", dt1.Rows[0][0].ToString());
            img_imghidden.Attributes.Add("class", "imghidden");
            img_imghidden.Attributes.Add("src", dt2.Rows[0][0].ToString());
            // <div class="caption description">
            div_description.Attributes.Add("class", "caption description");
            h3_name.Attributes.Add("class", "name");
            h3_name.Attributes.Add("title", dtRow[1].ToString());
            h3_name.InnerText = dtRow[1].ToString();
            p_composition.Attributes.Add("class", "compprod");
            p_composition.Attributes.Add("title", dtRow[2].ToString());
            p_composition.InnerText = dtRow[2].ToString();
            p_price.Attributes.Add("class", "priceprod costs");
            if (Request.Cookies["idclientuser"] != null)
            {
                p_price.InnerText = dt3.Rows[0][0].ToString();
            }
            else
            {
                p_price.Attributes.Add("class", "priceprod");
                p_price.InnerHtml = "<br/>";
            }
            div_divider.Attributes.Add("class", "divider");
            p_details.Attributes.Add("class", "moredetails");
            span_details.Attributes.Add("class", "shopnow");
            i_icondet.Attributes.Add("class", "fa fa-shopping-bag");
            i_icondet.Attributes.Add("aria-hidden", "true");
            span_shopnow.InnerText = " Shop now";

            // <asp:Linkbutton class="link-detailproduct">
            a_link.Attributes.Add("class", "link-detailproduct");
            //string url = "detailproduct.aspx?product=" + dtRow[0].ToString();
            string nameproduct = (dtRow[1].ToString().Replace(" ", "-")).ToLower();
            string url = "Products/" + dtRow[0].ToString() + "/" + nameproduct;
            a_link.Attributes.Add("href", url);
            // <div class="slide thumbnail">
            div_thumbnail.Attributes.Add("class", "slide thumbnail");
        }

        
    }

    // FEATURED PRODUCTS
    protected void loadfeaturedproducts()
    {
        System.Web.UI.HtmlControls.HtmlGenericControl div_thumbnail;
        System.Web.UI.HtmlControls.HtmlGenericControl a_link;
        //LinkButton lb_link;
        System.Web.UI.HtmlControls.HtmlGenericControl div_newicon;
        System.Web.UI.HtmlControls.HtmlGenericControl p_newicon;
        System.Web.UI.HtmlControls.HtmlGenericControl div_onsaleicon;
        System.Web.UI.HtmlControls.HtmlGenericControl p_onsaleicon;
        System.Web.UI.HtmlControls.HtmlGenericControl div_imagesize;
        System.Web.UI.HtmlControls.HtmlGenericControl img_imgshow;
        System.Web.UI.HtmlControls.HtmlGenericControl img_imghidden;
        System.Web.UI.HtmlControls.HtmlGenericControl div_description;
        System.Web.UI.HtmlControls.HtmlGenericControl h3_name;
        System.Web.UI.HtmlControls.HtmlGenericControl p_composition;
        System.Web.UI.HtmlControls.HtmlGenericControl p_price;
        System.Web.UI.HtmlControls.HtmlGenericControl div_divider;
        System.Web.UI.HtmlControls.HtmlGenericControl p_details;
        System.Web.UI.HtmlControls.HtmlGenericControl span_details;
        System.Web.UI.HtmlControls.HtmlGenericControl i_icondet;
        System.Web.UI.HtmlControls.HtmlGenericControl span_shopnow;

        
        DataTable dt = new DataTable();
        dt = datos.extraedatos("SELECT tp.idproduct, tp.nameproduct, tp.composition, tp.newproduct, tp.onsale" +
            " FROM tproduct tp INNER JOIN tsizecolor tsc ON tp.idproduct=tsc.idproduct" +
            " INNER JOIN tdetailcart tdc ON tsc.idsizecolor=tdc.idsizecolor" +
            " INNER JOIN tcart tc ON tdc.idcart=tc.idcart" +
            " WHERE tc.state=2 and (tp.disable is null or tp.disable='') and tp.rmbestseller='0' GROUP BY tp.idproduct" +
            " ORDER BY tc.idcart DESC limit 0,10");
        foreach (DataRow dtRow in dt.Rows)
        {
            div_thumbnail = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
            a_link = new System.Web.UI.HtmlControls.HtmlGenericControl("a");
            //lb_link = new LinkButton();
            div_newicon = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
            p_newicon = new System.Web.UI.HtmlControls.HtmlGenericControl("p");
            div_onsaleicon = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
            p_onsaleicon = new System.Web.UI.HtmlControls.HtmlGenericControl("p");
            div_imagesize = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
            img_imgshow = new System.Web.UI.HtmlControls.HtmlGenericControl("img");
            img_imghidden = new System.Web.UI.HtmlControls.HtmlGenericControl("img");
            div_description = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
            h3_name = new System.Web.UI.HtmlControls.HtmlGenericControl("h3");
            p_composition = new System.Web.UI.HtmlControls.HtmlGenericControl("p");
            p_price = new System.Web.UI.HtmlControls.HtmlGenericControl("p");
            div_divider = new System.Web.UI.HtmlControls.HtmlGenericControl("div");
            p_details = new System.Web.UI.HtmlControls.HtmlGenericControl("p");
            span_details = new System.Web.UI.HtmlControls.HtmlGenericControl("span");
            i_icondet = new System.Web.UI.HtmlControls.HtmlGenericControl("i");
            span_shopnow = new System.Web.UI.HtmlControls.HtmlGenericControl("span");

            placeholder_featured.Controls.Add(div_thumbnail);

            div_thumbnail.Controls.Add(a_link);

            a_link.Controls.Add(div_newicon);
            a_link.Controls.Add(div_onsaleicon);
            a_link.Controls.Add(div_imagesize);
            a_link.Controls.Add(div_description);

            div_newicon.Controls.Add(p_newicon);
            div_onsaleicon.Controls.Add(p_onsaleicon);

            div_imagesize.Controls.Add(img_imgshow);
            div_imagesize.Controls.Add(img_imghidden);

            div_description.Controls.Add(h3_name);
            div_description.Controls.Add(p_composition);
            div_description.Controls.Add(p_price);
            div_description.Controls.Add(div_divider);
            div_description.Controls.Add(p_details);
            p_details.Controls.Add(span_details);
            span_details.Controls.Add(i_icondet);
            span_details.Controls.Add(span_shopnow);

            DataTable dt1, dt2, dt3 = new DataTable();
            dt1 = datos.extraedatos("select count(*) from tproductimage where idproduct=" + dtRow[0].ToString() + " and position=" + 1);
            if (dt1.Rows[0][0].ToString() != "0")
            {
                dt1.Rows.Clear();
                dt1 = datos.extraedatos("select substring(urlresize1 from 3) as url from tproductimage where idproduct=" + dtRow[0].ToString() + " and position=" + 1);
            }
            dt2 = datos.extraedatos("select count(*) from tproductimage where idproduct=" + dtRow[0].ToString() + " and position=" + 2);
            if (dt2.Rows[0][0].ToString() != "0")
            {
                dt2.Rows.Clear();
                dt2 = datos.extraedatos("select substring(urlresize1 from 3) as url from tproductimage where idproduct=" + dtRow[0].ToString() + " and position=" + 2);
            }

            dt3 = datos.extraedatos("select format(min(price),2) from tsizecolor where idproduct=" + dtRow[0].ToString());

            // <div class="newicon">
            div_newicon.Attributes.Add("class", "newicon");
            p_newicon.InnerText = "NEW";

            // <div class="onsaleicon">
            div_onsaleicon.Attributes.Add("class", "onsaleicon");
            p_onsaleicon.InnerText = "ON SALE";
            if (dtRow[4].ToString() == "0")
            {
                div_onsaleicon.Attributes.Add("class", "onsaleicon hidden");
            }
            // <div class="imgsize">
            div_imagesize.Attributes.Add("class", "imgsize");
            img_imgshow.Attributes.Add("class", "imgshow");
            img_imgshow.Attributes.Add("src", dt1.Rows[0][0].ToString());
            img_imghidden.Attributes.Add("class", "imghidden");
            img_imghidden.Attributes.Add("src", dt2.Rows[0][0].ToString());
            // <div class="caption description">
            div_description.Attributes.Add("class", "caption description");
            h3_name.Attributes.Add("class", "name");
            h3_name.Attributes.Add("title", dtRow[1].ToString());
            h3_name.InnerText = dtRow[1].ToString();
            p_composition.Attributes.Add("class", "compprod");
            p_composition.Attributes.Add("title", dtRow[2].ToString());
            p_composition.InnerText = dtRow[2].ToString();
            p_price.Attributes.Add("class", "priceprod costs");
            if (Request.Cookies["idclientuser"] != null)
            {
                p_price.InnerText = dt3.Rows[0][0].ToString();
            }
            else
            {
                p_price.Attributes.Add("class", "priceprod");
                p_price.InnerHtml = "<br/>";
            }
            div_divider.Attributes.Add("class", "divider");
            p_details.Attributes.Add("class", "moredetails");
            span_details.Attributes.Add("class", "shopnow");
            i_icondet.Attributes.Add("class", "fa fa-shopping-bag");
            i_icondet.Attributes.Add("aria-hidden", "true");
            span_shopnow.InnerText = " Shop now";

            // <asp:Linkbutton class="link-detailproduct">
            a_link.Attributes.Add("class", "link-detailproduct");   
            //string url = "detailproduct.aspx?product=" + dtRow[0].ToString();
            string nameproduct = (dtRow[1].ToString().Replace(" ", "-")).ToLower();
            string url = "Products/" + dtRow[0].ToString() + "/" + nameproduct;
            a_link.Attributes.Add("href", url);

            // <div class="slide thumbnail">
            div_thumbnail.Attributes.Add("class", "slide thumbnail");
        }


    }

    protected void loadtagcloud()
    {
        DataTable dt = new DataTable();
        dt = datos.extraedatos("SELECT idtagcloud, tagname, urltag FROM ttagcloud ORDER BY RAND()");
        //dt.Columns.Add("Tag", typeof(string));
        //dt.Rows.Add("Asp.Net");
        //dt.Rows.Add("C#");
        //dt.Rows.Add("VB");
        //dt.Rows.Add("SQL");
        //dt.Rows.Add("JavaScript");
        //dt.Rows.Add("JQuery");
        //dt.Rows.Add("Ajax");
        //dt.Rows.Add("Linq to Sql");
        //dt.Rows.Add("XML");
        //dt.Rows.Add("WCF");
        //dt.Rows.Add("WPF");
        //dt.Rows.Add("WebService");
        //dt.Rows.Add("XAML");
        //dt.Rows.Add("Crystal Report");
        //dt.Rows.Add("RDLC");
        this.Reapeater1.DataSource = dt;
        this.Reapeater1.DataBind();
    }
}