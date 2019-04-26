<%@ Page Title="" Language="C#" MasterPageFile="~/principalmaster.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<asp:Content ID="Contenttitle" ContentPlaceHolderID="title" Runat="server">
    <title>Wholesale Luxury Alpaca Products | Artvus Alpaca</title>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <%--<link href="css/carouseltumbs.css" rel="stylesheet"/>--%>
    <link href="css/estilosindex.min.css" rel="stylesheet"/>
    <link href="css/jquery.bxslider.min.css" rel="stylesheet" />

    <!-- basic stylesheet -->
    <link rel="stylesheet" href="css/newsWidget.css"/>
                
    <!-- OPTIONAL! ADD a theme for easy customization-->
    <link rel="stylesheet" href="css/newsWidget_theme.css"/>
    <link rel="stylesheet" href="css/hover-icon_products.min.css"/>
    <style type="text/css">       
        .tagRepeater
        {           
            width: 100%;
            height: auto;
        }
        a.anchorRepeater
        {
            padding:3px;        
            display: inline-block;
            /*height: 20px;*/
            background-color: #fff;
            color: #777;
            margin: 2px 1px 2px 1px;
            border: 1px solid #c1c1c1;
            text-decoration: none;       
        }
        a.anchorRepeater:hover {
            color: #23527c;
            background-color: #eee;
        }
        /* Slider shadow left and right*/
        .carousel-control.left, .carousel-control.right {
            background-image: none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
      <!-- Indicators -->
      <ol class="carousel-indicators">
          <asp:PlaceHolder ID="plsliderindicator" runat="server"></asp:PlaceHolder>
        <%--<li data-target="#carousel-example-generic" data-slide-to="0" class="active" id="slide1indicator" runat="server"></li>
        <li data-target="#carousel-example-generic" data-slide-to="1" id="slide2indicator" visible="false" runat="server"></li>
        <li data-target="#carousel-example-generic" data-slide-to="2" id="slide3indicator" visible="false" runat="server"></li>
        <li data-target="#carousel-example-generic" data-slide-to="3" id="slide4indicator" visible="false" runat="server"></li>
        <li data-target="#carousel-example-generic" data-slide-to="4" id="slide5indicator" visible="false" runat="server"></li>
        <li data-target="#carousel-example-generic" data-slide-to="5" id="slide6indicator" visible="false" runat="server"></li>--%>
      </ol>

      <!-- Wrapper for slides -->
      <div class="carousel-inner" role="listbox">
          <asp:PlaceHolder ID="plsliderimage" runat="server"></asp:PlaceHolder>
        <%--<div class="item active slide" id="slide1" runat="server">
            <a href="#"><img src="../uploadfiles/sliderofindex/1423x622slide1.jpg" alt="slide 1" style="width:100%"/></a>
          <div class="carousel-caption">
            ...
          </div>
        </div>
        <div class="item slide" id="slide2" visible="false" runat="server">
          <img src="../uploadfiles/sliderofindex/1423x622slide2.jpg" alt="slide 2" style="width:100%"/>
          <div class="carousel-caption">
            ...
          </div>
        </div>
        <div class="item slide" id="slide3" visible="false" runat="server">
          <img src="../uploadfiles/sliderofindex/1423x622slide3.jpg" alt="slide 3" style="width:100%"/>
          <div class="carousel-caption">
            ...
          </div>
        </div>
        <div class="item slide" id="slide4" visible="false" runat="server">
          <img src="../uploadfiles/sliderofindex/1423x622slide4.jpg" alt="slide 4" style="width:100%"/>
          <div class="carousel-caption">
            ...
          </div>
        </div>
        <div class="item slide" id="slide5" visible="false" runat="server">
          <img src="../uploadfiles/sliderofindex/1423x622slide5.jpg" alt="slide 5" style="width:100%"/>
          <div class="carousel-caption">
            ...
          </div>
        </div>
        <div class="item slide" id="slide6" visible="false" runat="server">
          <img src="../uploadfiles/sliderofindex/1423x622slide6.jpg" alt="slide 6" style="width:100%"/>
          <div class="carousel-caption">
            ...
          </div>
        </div>--%>
        <%--...--%>
      </div>

      <!-- Controls -->
      <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
        <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
        <span class="sr-only">Previous</span>
      </a>
      <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
        <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
        <span class="sr-only">Next</span>
      </a>
    </div>



    <div class="row">
        <div class="container">
            <div class="col-md-12 cont">
                <div class="adversing">
                    <div class="adon ad1">
                        <a href="#" id="ad_url1" runat="server"><img src="/" alt="" id="ad_img1" runat="server" /></a>
                    </div>
                    <div class="adon ad2">
                        <a href="#" id="ad_url2" runat="server"><img src="/" alt="" id="ad_img2" runat="server"/></a>
                    </div>
                    <div class="adon ad3">
                        <a href="#" id="ad_url3" runat="server"><img src="/" alt="" id="ad_img3" runat="server"/></a>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <%--<div class="row">
        <div class="col-xs-6 col-md-3">
        <a href="#" class="thumbnail">
            <img src="img/accesorios1.jpg" alt="...">
        </a>
        </div>
        ...
    </div>--%>

    <%--  --%>

    <%--<div class="container">
    <div class="row">
        <div class="row">
            <div class="col-md-9">
                <h3>New Products</h3>
            </div>
        </div>
        <div id="carousel-example" class="carousel slide hidden-xs" data-ride="carousel">
            <!-- Wrapper for slides -->
            <div class="carousel-inner">
                <div class="item active">
                    <div class="row">
                        <div class="col-sm-3">
                            <div class="col-item"">
                                <div class="photo" >
                                    <img src="img/alpaca6.jpg" class="img-responsive" alt="a" />
                                </div>
                                <div class="info">
                                    <div class="row">
                                        <div class="price col-md-6">
                                            <h5>
                                                Product 1</h5>
                                            <h5 class="price-text-color">
                                                $199.99</h5>
                                        </div>
                                        <div class="rating hidden-sm col-md-6">
                                            <i class="price-text-color fa fa-star"></i><i class="price-text-color fa fa-star">
                                            </i><i class="price-text-color fa fa-star"></i><i class="price-text-color fa fa-star">
                                            </i><i class="fa fa-star"></i>
                                        </div>
                                    </div>
                                    <div class="separator clear-left">
                                        <p class="btn-add">
                                            <i class="fa fa-shopping-cart"></i><a href="http://www.jquery2dotnet.com" class="hidden-sm">Shop now</a></p>
                                        <p class="btn-details">
                                            <i class="fa fa-list"></i><a href="http://www.jquery2dotnet.com" class="hidden-sm">More details</a></p>
                                    </div>
                                    <div class="clearfix">
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-sm-3">
                            <div class="col-item">
                                <div class="photo">
                                    <img src="img/alpaca3.jpg" class="img-responsive" alt="a" />
                                </div>
                                <div class="info">
                                    <div class="row">
                                        <div class="price col-md-6">
                                            <h5>
                                                Product Example</h5>
                                            <h5 class="price-text-color">
                                                $249.99</h5>
                                        </div>
                                        <div class="rating hidden-sm col-md-6">
                                        </div>
                                    </div>
                                    <div class="separator clear-left">
                                        <p class="btn-add">
                                            <i class="fa fa-shopping-cart"></i><a href="http://www.jquery2dotnet.com" class="hidden-sm">Shop now</a></p>
                                        <p class="btn-details">
                                            <i class="fa fa-list"></i><a href="http://www.jquery2dotnet.com" class="hidden-sm">More details</a></p>
                                    </div>
                                    <div class="clearfix">
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-sm-3">
                            <div class="col-item">
                                <div class="photo">
                                    <img src="img/alpaca4.jpg" class="img-responsive" alt="a" />
                                </div>
                                <div class="info">
                                    <div class="row">
                                        <div class="price col-md-6">
                                            <h5>
                                                Next Sample Product</h5>
                                            <h5 class="price-text-color">
                                                $149.99</h5>
                                        </div>
                                        <div class="rating hidden-sm col-md-6">
                                            <i class="price-text-color fa fa-star"></i><i class="price-text-color fa fa-star">
                                            </i><i class="price-text-color fa fa-star"></i><i class="price-text-color fa fa-star">
                                            </i><i class="fa fa-star"></i>
                                        </div>
                                    </div>
                                    <div class="separator clear-left">
                                        <p class="btn-add">
                                            <i class="fa fa-shopping-cart"></i><a href="http://www.jquery2dotnet.com" class="hidden-sm">Shop now</a></p>
                                        <p class="btn-details">
                                            <i class="fa fa-list"></i><a href="http://www.jquery2dotnet.com" class="hidden-sm">More details</a></p>
                                    </div>
                                    <div class="clearfix">
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-sm-3">
                            <div class="col-item">
                                <div class="photo">
                                    <img src="img/alpaca7.jpg" class="img-responsive" alt="a" />
                                </div>
                                <div class="info">
                                    <div class="row">
                                        <div class="price col-md-6">
                                            <h5>
                                                Sample Product</h5>
                                            <h5 class="price-text-color">
                                                $199.99</h5>
                                        </div>
                                        <div class="rating hidden-sm col-md-6">
                                            <i class="price-text-color fa fa-star"></i><i class="price-text-color fa fa-star">
                                            </i><i class="price-text-color fa fa-star"></i><i class="price-text-color fa fa-star">
                                            </i><i class="fa fa-star"></i>
                                        </div>
                                    </div>
                                    <div class="separator clear-left">
                                        <p class="btn-add">
                                            <i class="fa fa-shopping-cart"></i><a href="http://www.jquery2dotnet.com" class="hidden-sm">Shop now</a></p>
                                        <p class="btn-details">
                                            <i class="fa fa-list"></i><a href="http://www.jquery2dotnet.com" class="hidden-sm">More details</a></p>
                                    </div>
                                    <div class="clearfix">
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="item">
                    <div class="row">
                        <div class="col-sm-3">
                            <div class="col-item">
                                <div class="photo">
                                    <img src="img/alpaca8.jpg" class="img-responsive" alt="a" />
                                </div>
                                <div class="info">
                                    <div class="row">
                                        <div class="price col-md-6">
                                            <h5>
                                                Product with Variants</h5>
                                            <h5 class="price-text-color">
                                                $199.99</h5>
                                        </div>
                                        <div class="rating hidden-sm col-md-6">
                                            <i class="price-text-color fa fa-star"></i><i class="price-text-color fa fa-star">
                                            </i><i class="price-text-color fa fa-star"></i><i class="price-text-color fa fa-star">
                                            </i><i class="fa fa-star"></i>
                                        </div>
                                    </div>
                                    <div class="separator clear-left">
                                        <p class="btn-add">
                                            <i class="fa fa-shopping-cart"></i><a href="http://www.jquery2dotnet.com" class="hidden-sm">Shop now</a></p>
                                        <p class="btn-details">
                                            <i class="fa fa-list"></i><a href="http://www.jquery2dotnet.com" class="hidden-sm">More details</a></p>
                                    </div>
                                    <div class="clearfix">
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-sm-3">
                            <div class="col-item">
                                <div class="photo">
                                    <img src="img/alpaca10.jpg" class="img-responsive" alt="a" />
                                </div>
                                <div class="info">
                                    <div class="row">
                                        <div class="price col-md-6">
                                            <h5>
                                                Grouped Product</h5>
                                            <h5 class="price-text-color">
                                                $249.99</h5>
                                        </div>
                                        <div class="rating hidden-sm col-md-6">
                                        </div>
                                    </div>
                                    <div class="separator clear-left">
                                        <p class="btn-add">
                                            <i class="fa fa-shopping-cart"></i><a href="http://www.jquery2dotnet.com" class="hidden-sm">Shop now</a></p>
                                        <p class="btn-details">
                                            <i class="fa fa-list"></i><a href="http://www.jquery2dotnet.com" class="hidden-sm">More details</a></p>
                                    </div>
                                    <div class="clearfix">
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-sm-3">
                            <div class="col-item">
                                <div class="photo">
                                    <img src="img/alpaca3.jpg" class="img-responsive" alt="a" />
                                </div>
                                <div class="info">
                                    <div class="row">
                                        <div class="price col-md-6">
                                            <h5>
                                                Product with Variants</h5>
                                            <h5 class="price-text-color">
                                                $149.99</h5>
                                        </div>
                                        <div class="rating hidden-sm col-md-6">
                                            <i class="price-text-color fa fa-star"></i><i class="price-text-color fa fa-star">
                                            </i><i class="price-text-color fa fa-star"></i><i class="price-text-color fa fa-star">
                                            </i><i class="fa fa-star"></i>
                                        </div>
                                    </div>
                                    <div class="separator clear-left">
                                        <p class="btn-add">
                                            <i class="fa fa-shopping-cart"></i><a href="http://www.jquery2dotnet.com" class="hidden-sm">Shop now</a></p>
                                        <p class="btn-details">
                                            <i class="fa fa-list"></i><a href="http://www.jquery2dotnet.com" class="hidden-sm">More details</a></p>
                                    </div>
                                    <div class="clearfix">
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-sm-3">
                            <div class="col-item">
                                <div class="photo">
                                    <img src="img/alpaca4.jpg" class="img-responsive" alt="a" />
                                </div>
                                <div class="info">
                                    <div class="row">
                                        <div class="price col-md-6">
                                            <h5>
                                                Product with Variants</h5>
                                            <h5 class="price-text-color">
                                                $199.99</h5>
                                        </div>
                                        <div class="rating hidden-sm col-md-6">
                                            <i class="price-text-color fa fa-star"></i><i class="price-text-color fa fa-star">
                                            </i><i class="price-text-color fa fa-star"></i><i class="price-text-color fa fa-star">
                                            </i><i class="fa fa-star"></i>
                                        </div>
                                    </div>
                                    <div class="separator clear-left">
                                        <p class="btn-add">
                                            <i class="fa fa-shopping-cart"></i><a href="http://www.jquery2dotnet.com" class="hidden-sm">Shop now</a></p>
                                        <p class="btn-details">
                                            <i class="fa fa-list"></i><a href="http://www.jquery2dotnet.com" class="hidden-sm">More details</a></p>
                                    </div>
                                    <div class="clearfix">
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>--%>
    





   <%-- <ul class="bxslider">
      <li><img src="/img/alpaca6.jpg" /></li>
      <li><img src="/img/alpaca6.jpg" /></li>
      <li><img src="/img/alpaca6.jpg" /></li>
      <li><img src="/img/alpaca6.jpg" /></li>
    </ul>--%>

    
    
    <div class="container">
        <div class="row">
            <div class="col-md-9">
                <h3>New Products</h3>
            </div>
        </div>
    <div class="slider1">
        <asp:PlaceHolder ID="placeholder_new" runat="server"></asp:PlaceHolder>

      <%--<div class="slide thumbnail">
        <a href="faqs.aspx" class="link-detailproduct">
            <div class="newicon"><p>NEW</p></div>
            <div class="onsaleicon"><p>ON SALE</p></div>
            <div class="imgsize">
                <img class="imgshow" src="img/alpaca12.jpg"/>
                <img class="imghidden" src="img/alpaca13.jpg" />
            </div>
            <div class="caption description">
                <h3 class="name" title="Suki Baby Alpaca Jacquard Cardigan">Suki Baby Alpaca Jacquard Cardigan</h3>
                <p class="compprod" title="*43% Alpaca *42% Acrylic *15% Nylon">*43% Alpaca *42% Acrylic *15% Nylon</p>
                <p class="priceprod">$199.99</p>
                <div class="divider"></div>
                <p class="moredetails">
                    <span class="shopnow"><i class="fa fa-shopping-bag" aria-hidden="true"></i> Shop now</span>
                </p>
                <span class="divider-vertical"></span>
                <p class="moredetails der">
                    <a href="#" class=""><i class="fa fa-info-circle" aria-hidden="true"></i> More details</a>
                </p>
            </div>
        </a>
    </div>
    <div class="slide thumbnail">
        <div class="newicon"><p>NEW</p></div>
        <div class="onsaleicon hidden"><p>ON SALE</p></div>
        <div class="imgsize">
            <img class="imgshow" src="img/alpaca14.jpg"/>
            <img class="imghidden" src="img/alpaca15.jpg"/>
        </div>
        <div class="caption description">
            <h3 class="name" title="Swetter">Swetter</h3>
            <p class="compprod" title="*43% Alpaca *42% Acrylic *15% Nylon">*43% Alpaca *42% Acrylic *15% Nylon</p>
            <p class="priceprod">$199.99</p>
                <div class="divider"></div>
            <p class="moredetails izq">
                <a href="#" class="" role="button"><i class="fa fa-shopping-bag" aria-hidden="true"></i> Shop now</a>
            </p>
            <span class="divider-vertical"></span>
            <p class="moredetails der">
                <a href="#" class="" role="button"><i class="fa fa-info-circle" aria-hidden="true"></i> More details</a>
            </p>
        </div>
    </div>
    <div class="slide thumbnail">
        <div class="newicon hidden"><p>NEW</p></div>
        <div class="onsaleicon"><p>ON SALE</p></div>
        <div class="imgsize">
            <img class="imgshow" src="img/alpaca4.jpg"/>
            <img class="imghidden" src="img/alpaca3.jpg" />
        </div>
        <div class="caption description">
            <h3 class="name" title="Pullover">Pullover</h3>
            <p class="compprod" title="*43% Alpaca *42% Acrylic *15% Nylon">*43% Alpaca *42% Acrylic *15% Nylon</p>
            <p class="priceprod">$199.99</p>
                <div class="divider"></div>
            <p class="moredetails izq">
                <a href="#" class="" role="button"><i class="fa fa-shopping-bag" aria-hidden="true"></i> Shop now</a>
            </p>
                <span class="divider-vertical"></span>
            <p class="moredetails der">
                <a href="#" class="" role="button"><i class="fa fa-info-circle" aria-hidden="true"></i> More details</a>
            </p>
        </div>
    </div>
    <div class="slide thumbnail">
        <div class="newicon"><p>NEW</p></div>
        <div class="onsaleicon hidden"><p>ON SALE</p></div>
        <div class="imgsize">
            <img class="imgshow" src="img/alpaca3.jpg"/>
            <img class="imghidden" src="img/alpaca4.jpg" />
        </div>
        <div class="caption description">
            <h3 class="name" title="Tunic">Tunic</h3>
            <p class="compprod" title="*43% Alpaca *42% Acrylic *15% Nylon">*43% Alpaca *42% Acrylic *15% Nylon</p>
            <p class="priceprod">$199.99</p>
                <div class="divider"></div>
            <p class="moredetails izq">
                <a href="#" class="" role="button"><i class="fa fa-shopping-bag" aria-hidden="true"></i> Shop now</a>
            </p>
                <span class="divider-vertical"></span>
            <p class="moredetails der">
                <a href="#" class="" role="button"><i class="fa fa-info-circle" aria-hidden="true"></i> More details</a>
            </p>
        </div>
    </div>
    <div class="slide thumbnail">
        <div class="newicon"><p>NEW</p></div>
        <div class="onsaleicon hidden"><p>ON SALE</p></div>
        <div class="imgsize">
            <img class="imgshow" src="img/alpaca7.jpg"/>
            <img class="imghidden" src="img/alpaca8.jpg"/>
        </div>
        <div class="caption description">
            <h3 class="name" title="Swetter">Swetter</h3>
            <p class="compprod" title="*43% Alpaca *42% Acrylic *15% Nylon">*43% Alpaca *42% Acrylic *15% Nylon</p>
            <p class="priceprod">$199.99</p>
                <div class="divider"></div>
            <p class="moredetails izq">
                <a href="#" class="" role="button"><i class="fa fa-shopping-bag" aria-hidden="true"></i> Shop now</a>
            </p>
                <span class="divider-vertical"></span>
            <p class="moredetails der">
                <a href="#" class="" role="button"><i class="fa fa-info-circle" aria-hidden="true"></i> More details</a>
            </p>
        </div>
    </div>
    <div class="slide thumbnail">
        <div class="newicon hidden"><p>NEW</p></div>
        <div class="onsaleicon hidden"><p>ON SALE</p></div>
        <div class="imgsize">
            <img class="imgshow" src="img/alpaca11.jpg"/>
            <img class="imghidden" src="img/alpaca6.jpg"/>
        </div>
        <div class="caption description">
            <h3 class="name" title="Swetter">Swetter</h3>
            <p class="compprod" title="*43% Alpaca *42% Acrylic *15% Nylon">*43% Alpaca *42% Acrylic *15% Nylon</p>
            <p class="priceprod">$199.99</p>
                <div class="divider"></div>
            <p class="moredetails izq">
                <a href="#" class="" role="button"><i class="fa fa-shopping-bag" aria-hidden="true"></i> Shop now</a>
            </p>
                <span class="divider-vertical"></span>
            <p class="moredetails der">
                <a href="#" class="" role="button"><i class="fa fa-info-circle" aria-hidden="true"></i> More details</a>
            </p>
        </div>
    </div>
    <div class="slide thumbnail">
        <div class="newicon hidden"><p>NEW</p></div>
        <div class="onsaleicon hidden"><p>ON SALE</p></div>
        <div class="imgsize">
            <img class="imgshow" src="img/alpaca3.jpg"/>
            <img class="imghidden" src="img/alpaca4.jpg"/>
        </div>
        <div class="caption description">
            <h3 class="name" title="Swetter">Swetter</h3>
            <p class="compprod" title="*43% Alpaca *42% Acrylic *15% Nylon">*43% Alpaca *42% Acrylic *15% Nylon</p>
            <p class="priceprod">$199.99</p>
                <div class="divider"></div>
            <p class="moredetails izq">
                <a href="#" class="" role="button"><i class="fa fa-shopping-bag" aria-hidden="true"></i> Shop now</a>
            </p>
                <span class="divider-vertical"></span>
            <p class="moredetails der">
                <a href="#" class="" role="button"><i class="fa fa-info-circle" aria-hidden="true"></i> More details</a>
            </p>
        </div>
    </div>--%>
    </div>
    </div>

    <%-- Featureds Products --%>
    <div class="container">
        <div class="row">
            <div class="col-md-9">
                <h3>Best Seller</h3>
            </div>
        </div>
    <div class="slider1">
        <asp:PlaceHolder ID="placeholder_featured" runat="server"></asp:PlaceHolder>
      <%--<div class="slide thumbnail">
        <div class="newicon"><p>NEW</p></div>
        <div class="onsaleicon hidden"><p>ON SALE</p></div>
        <div class="imgsize">
            <img class="imgshow" src="img/alpaca7.jpg"/>
            <img class="imghidden" src="img/alpaca8.jpg"/>
        </div>
        <div class="caption description">
            <h3 class="name" title="Swetter">Swetter</h3>
            <p class="compprod" title="*43% Alpaca *42% Acrylic *15% Nylon">*43% Alpaca *42% Acrylic *15% Nylon</p>
            <p class="priceprod">$199.99</p>
                <div class="divider"></div>
            <p class="moredetails izq">
                <a href="#" class="" role="button"><i class="fa fa-shopping-bag" aria-hidden="true"></i> Shop now</a>
            </p>
                <span class="divider-vertical"></span>
            <p class="moredetails der">
                <a href="#" class="" role="button"><i class="fa fa-info-circle" aria-hidden="true"></i> More details</a>
            </p>
        </div>
    </div>
    <div class="slide thumbnail">
        <div class="newicon hidden"><p>NEW</p></div>
        <div class="onsaleicon hidden"><p>ON SALE</p></div>
        <div class="imgsize">
            <img class="imgshow" src="img/alpaca11.jpg"/>
            <img class="imghidden" src="img/alpaca6.jpg"/>
        </div>
        <div class="caption description">
            <h3 class="name" title="Swetter">Swetter</h3>
            <p class="compprod" title="*43% Alpaca *42% Acrylic *15% Nylon">*43% Alpaca *42% Acrylic *15% Nylon</p>
            <p class="priceprod">$199.99</p>
                <div class="divider"></div>
            <p class="moredetails izq">
                <a href="#" class="" role="button"><i class="fa fa-shopping-bag" aria-hidden="true"></i> Shop now</a>
            </p>
                <span class="divider-vertical"></span>
            <p class="moredetails der">
                <a href="#" class="" role="button"><i class="fa fa-info-circle" aria-hidden="true"></i> More details</a>
            </p>
        </div>
    </div>
    <div class="slide thumbnail">
        <div class="newicon hidden"><p>NEW</p></div>
        <div class="onsaleicon hidden"><p>ON SALE</p></div>
        <div class="imgsize">
            <img class="imgshow" src="img/alpaca3.jpg"/>
            <img class="imghidden" src="img/alpaca4.jpg"/>
        </div>
        <div class="caption description">
            <h3 class="name" title="Swetter">Swetter</h3>
            <p class="compprod" title="*43% Alpaca *42% Acrylic *15% Nylon">*43% Alpaca *42% Acrylic *15% Nylon</p>
            <p class="priceprod">$199.99</p>
                <div class="divider"></div>
            <p class="moredetails izq">
                <a href="#" class="" role="button"><i class="fa fa-shopping-bag" aria-hidden="true"></i> Shop now</a>
            </p>
                <span class="divider-vertical"></span>
            <p class="moredetails der">
                <a href="#" class="" role="button"><i class="fa fa-info-circle" aria-hidden="true"></i> More details</a>
            </p>
        </div>
    </div>
    <div class="slide thumbnail">
        <div class="newicon"><p>NEW</p></div>
        <div class="onsaleicon"><p>ON SALE</p></div>
        <div class="imgsize">
            <img class="imgshow" src="img/alpaca8.jpg"/>
            <img class="imghidden" src="img/alpaca7.jpg" />
        </div>
        <div class="caption description">
            <h3 class="name" title="Suki Baby Alpaca Jacquard Cardigan">Suki Baby Alpaca Jacquard Cardigan</h3>
            <p class="compprod" title="*43% Alpaca *42% Acrylic *15% Nylon">*43% Alpaca *42% Acrylic *15% Nylon</p>
            <p class="priceprod">$199.99</p>
            <div class="divider"></div>
            <p class="moredetails izq">
                <a href="#" class="" role="button"><i class="fa fa-shopping-bag" aria-hidden="true"></i> Shop now</a>
            </p>
            <span class="divider-vertical"></span>
            <p class="moredetails der">
                <a href="#" class="" role="button"><i class="fa fa-info-circle" aria-hidden="true"></i> More details</a>
            </p>
        </div>
    </div>
    <div class="slide thumbnail">
        <div class="newicon"><p>NEW</p></div>
        <div class="onsaleicon hidden"><p>ON SALE</p></div>
        <div class="imgsize">
            <img class="imgshow" src="img/front1.jpg"/>
            <img class="imghidden" src="img/back1.jpg"/>
        </div>
        <div class="caption description">
            <h3 class="name" title="Swetter">Swetter</h3>
            <p class="compprod" title="*43% Alpaca *42% Acrylic *15% Nylon">*43% Alpaca *42% Acrylic *15% Nylon</p>
            <p class="priceprod">$199.99</p>
                <div class="divider"></div>
            <p class="moredetails izq">
                <a href="#" class="" role="button"><i class="fa fa-shopping-bag" aria-hidden="true"></i> Shop now</a>
            </p>
                <span class="divider-vertical"></span>
            <p class="moredetails der">
                <a href="#" class="" role="button"><i class="fa fa-info-circle" aria-hidden="true"></i> More details</a>
            </p>
        </div>
    </div>
    <div class="slide thumbnail">
        <div class="newicon hidden"><p>NEW</p></div>
        <div class="onsaleicon"><p>ON SALE</p></div>
        <div class="imgsize">
            <img class="imgshow" src="img/alpaca4.jpg"/>
            <img class="imghidden" src="img/alpaca3.jpg" />
        </div>
        <div class="caption description">
            <h3 class="name" title="Pullover">Pullover</h3>
            <p class="compprod" title="*43% Alpaca *42% Acrylic *15% Nylon">*43% Alpaca *42% Acrylic *15% Nylon</p>
            <p class="priceprod">$199.99</p>
                <div class="divider"></div>
            <p class="moredetails izq">
                <a href="#" class="" role="button"><i class="fa fa-shopping-bag" aria-hidden="true"></i> Shop now</a>
            </p>
                <span class="divider-vertical"></span>
            <p class="moredetails der">
                <a href="#" class="" role="button"><i class="fa fa-info-circle" aria-hidden="true"></i> More details</a>
            </p>
        </div>
    </div>
    <div class="slide thumbnail">
        <div class="newicon"><p>NEW</p></div>
        <div class="onsaleicon hidden"><p>ON SALE</p></div>
        <div class="imgsize">
            <img class="imgshow" src="img/alpaca3.jpg"/>
            <img class="imghidden" src="img/alpaca4.jpg" />
        </div>
        <div class="caption description">
            <h3 class="name" title="Tunic">Tunic</h3>
            <p class="compprod" title="*43% Alpaca *42% Acrylic *15% Nylon">*43% Alpaca *42% Acrylic *15% Nylon</p>
            <p class="priceprod">$199.99</p>
                <div class="divider"></div>
            <p class="moredetails izq">
                <a href="#" class="" role="button"><i class="fa fa-shopping-bag" aria-hidden="true"></i> Shop now</a>
            </p>
                <span class="divider-vertical"></span>
            <p class="moredetails der">
                <a href="#" class="" role="button"><i class="fa fa-info-circle" aria-hidden="true"></i> More details</a>
            </p>
        </div>
    </div>--%>
    </div>
    </div>

    <div class="container">
        <div class="tagRepeater">
            <asp:Repeater ID="Reapeater1" runat="server">
                <ItemTemplate>
                    <a class="anchorRepeater" href='<%#Eval("urltag")%>'><%#Eval("tagname")%></a>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
    <br />

    <%-- News --%>

   <%-- <div class="container">
        <div class="row">
            <div class="col-md-9">
                <h3>News</h3>
            </div>
        </div>
        <ul id="mainNewsWidget"> 
            <!-- Minimal Settings --> 
            <li data-title="title" data-date="24-5-2017" data-image="img/news1.jpg" >
                Body of article.Text or html code.
            </li> 
            
    
            <!-- Example 1 --> 
            <li data-title="New Products Now" data-date="24-5-2017" data-image="img/news2.jpg"> 
                 <h2> A heading 2 </h2> 
                 <p> A paragraph here  <img src="img/news2.jpg" />   </p> 
                Features
                 <ul> 
       	             <li> 4.7 Inch </li> 
                     <li> Sense 5 </li> 
                 </ul> 
            </li> 
    
    
        </ul>   
    </div>--%>
    


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="script" Runat="Server">
   
    <!-- bxSlider Javascript file -->
    <script src="js/jquery.bxslider.js"></script>
    <script>
        $(document).ready(function () {
            $('.bxslider').bxSlider();
        });
    </script>
    <script>
        $(document).ready(function () {
            $('.slider1').bxSlider({
                slideWidth: 250,
                minSlides: 2,
                maxSlides: 5,
                //moveSlides: 1,
                slideMargin: 10,
                auto: true,
                autoControls: true,
                speed: 1000,
                pause: 6000,
                autoHover: true
            });
        });
    </script>

    <!-- If you already have TweenMax on your page, you shouldnt include it second time. -->
    <script src="js/TweenMax.min.js"></script>  
 
    <!-- News Widget JS script file --> 
    <script src="js/jquery.newsWidget.js"></script>

    <script>
        jQuery(document).ready(function($) {
            $("#mainNewsWidget").newsWidget({
                // Options go here
                // Example, choose the full article mode.
                currentNewsWidth: 900,
                currentNewsHeight: 280,
                fullArticleType: "full",
                navBtns: "left",
                imgInPreview: true
            });  
        });
    </script>
</asp:Content>

