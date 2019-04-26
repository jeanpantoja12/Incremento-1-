<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminmaster.master" AutoEventWireup="true" CodeFile="AgregarProd.aspx.cs" Inherits="admin_AgregarProd" %>


<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" href="css/productadmin.css" />
    <link rel="stylesheet" href="css/checkboxstyle.css" />
    <style>
        .checkbox {
          padding-left: 20px; }
          .checkbox label {
            display: inline-block;
            position: relative;
            padding-left: 5px; }
            .checkbox label::before {
              content: "";
              display: inline-block;
              position: absolute;
              width: 17px;
              height: 17px;
              left: 0;
              margin-left: -20px;
              border: 1px solid #cccccc;
              border-radius: 3px;
              background-color: #fff;
              -webkit-transition: border 0.15s ease-in-out, color 0.15s ease-in-out;
              -o-transition: border 0.15s ease-in-out, color 0.15s ease-in-out;
              transition: border 0.15s ease-in-out, color 0.15s ease-in-out; }
            .checkbox label::after {
              display: inline-block;
              position: absolute;
              width: 16px;
              height: 16px;
              left: 0;
              top: 0;
              margin-left: -20px;
              padding-left: 3px;
              padding-top: 1px;
              font-size: 11px;
              color: #555555; }
          .checkbox input[type="checkbox"] {
            opacity: 0; }
            .checkbox input[type="checkbox"]:focus + label::before {
              outline: thin dotted;
              outline: 5px auto -webkit-focus-ring-color;
              outline-offset: -2px; }
            .checkbox input[type="checkbox"]:checked + label::after {
              font-family: 'FontAwesome';
              content: "\f00c"; }
            .checkbox input[type="checkbox"]:disabled + label {
              opacity: 0.65; }
              .checkbox input[type="checkbox"]:disabled + label::before {
                background-color: #eeeeee;
                cursor: not-allowed; }
          .checkbox.checkbox-circle label::before {
            border-radius: 50%; }
          .checkbox.checkbox-inline {
            margin-top: 0; }

        .checkbox-primary input[type="checkbox"]:checked + label::before {
          background-color: #428bca;
          border-color: #428bca; }
        .checkbox-primary input[type="checkbox"]:checked + label::after {
          color: #fff; }

        .checkbox-danger input[type="checkbox"]:checked + label::before {
          background-color: #d9534f;
          border-color: #d9534f; }
        .checkbox-danger input[type="checkbox"]:checked + label::after {
          color: #fff; }

        .checkbox-info input[type="checkbox"]:checked + label::before {
          background-color: #5bc0de;
          border-color: #5bc0de; }
        .checkbox-info input[type="checkbox"]:checked + label::after {
          color: #fff; }

        .checkbox-warning input[type="checkbox"]:checked + label::before {
          background-color: #f0ad4e;
          border-color: #f0ad4e; }
        .checkbox-warning input[type="checkbox"]:checked + label::after {
          color: #fff; }

        .checkbox-success input[type="checkbox"]:checked + label::before {
          background-color: #5cb85c;
          border-color: #5cb85c; }
        .checkbox-success input[type="checkbox"]:checked + label::after {
          color: #fff; }

        .radio {
          padding-left: 20px; }
          .radio label {
            display: inline-block;
            position: relative;
            padding-left: 5px; }
            .radio label::before {
              content: "";
              display: inline-block;
              position: absolute;
              width: 17px;
              height: 17px;
              left: 0;
              margin-left: -20px;
              border: 1px solid #cccccc;
              border-radius: 50%;
              background-color: #fff;
              -webkit-transition: border 0.15s ease-in-out;
              -o-transition: border 0.15s ease-in-out;
              transition: border 0.15s ease-in-out; }
            .radio label::after {
              display: inline-block;
              position: absolute;
              content: " ";
              width: 11px;
              height: 11px;
              left: 3px;
              top: 3px;
              margin-left: -20px;
              border-radius: 50%;
              background-color: #555555;
              -webkit-transform: scale(0, 0);
              -ms-transform: scale(0, 0);
              -o-transform: scale(0, 0);
              transform: scale(0, 0);
              -webkit-transition: -webkit-transform 0.1s cubic-bezier(0.8, -0.33, 0.2, 1.33);
              -moz-transition: -moz-transform 0.1s cubic-bezier(0.8, -0.33, 0.2, 1.33);
              -o-transition: -o-transform 0.1s cubic-bezier(0.8, -0.33, 0.2, 1.33);
              transition: transform 0.1s cubic-bezier(0.8, -0.33, 0.2, 1.33); }
          .radio input[type="radio"] {
            opacity: 0; }
            .radio input[type="radio"]:focus + label::before {
              outline: thin dotted;
              outline: 5px auto -webkit-focus-ring-color;
              outline-offset: -2px; }
            .radio input[type="radio"]:checked + label::after {
              -webkit-transform: scale(1, 1);
              -ms-transform: scale(1, 1);
              -o-transform: scale(1, 1);
              transform: scale(1, 1); }
            .radio input[type="radio"]:disabled + label {
              opacity: 0.65; }
              .radio input[type="radio"]:disabled + label::before {
                cursor: not-allowed; }
          .radio.radio-inline {
            margin-top: 0; }

        .radio-primary input[type="radio"] + label::after {
          background-color: #428bca; }
        .radio-primary input[type="radio"]:checked + label::before {
          border-color: #428bca; }
        .radio-primary input[type="radio"]:checked + label::after {
          background-color: #428bca; }

        .radio-danger input[type="radio"] + label::after {
          background-color: #d9534f; }
        .radio-danger input[type="radio"]:checked + label::before {
          border-color: #d9534f; }
        .radio-danger input[type="radio"]:checked + label::after {
          background-color: #d9534f; }

        .radio-info input[type="radio"] + label::after {
          background-color: #5bc0de; }
        .radio-info input[type="radio"]:checked + label::before {
          border-color: #5bc0de; }
        .radio-info input[type="radio"]:checked + label::after {
          background-color: #5bc0de; }

        .radio-warning input[type="radio"] + label::after {
          background-color: #f0ad4e; }
        .radio-warning input[type="radio"]:checked + label::before {
          border-color: #f0ad4e; }
        .radio-warning input[type="radio"]:checked + label::after {
          background-color: #f0ad4e; }

        .radio-success input[type="radio"] + label::after {
          background-color: #5cb85c; }
        .radio-success input[type="radio"]:checked + label::before {
          border-color: #5cb85c; }
        .radio-success input[type="radio"]:checked + label::after {
          background-color: #5cb85c; }
    </style>

    <link rel="stylesheet" href="css/custom-file-input.css" />
    <script>(function(e,t,n){var r=e.querySelectorAll("html")[0];r.className=r.className.replace(/(^|\s)no-js(\s|$)/,"$1js$2")})(document,window,0);</script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenido" Runat="Server">
     <div class="container">
        <h2>Agregar Producto</h2>
        <div class="row" id="slide1" runat="server">
            <div class="col-md-12">
                <!-- Slider one -->
                <div class="box box-solid box-primary">
                    <div class="box-header with-border">

                        <h3 class="box-title">Detalle Producto</h3>
                        </div>
                     <div class="col-md-6">
                                        <div class="form-group">
                                            <label for="txtsku">SKU</label>
                                            <asp:textbox id="txtsku" class="form-control" type="text" placeholder="SKU" runat="server" ReadOnly="true"></asp:textbox>
                                        </div>
                                    
                            <div class="col-md-2" onload="loadcheck()">
                                        <div class="form-group">
                                            <label for="check-code">Nuevo</label>
                                            <!-- Rectangular switch -->
                                            <label class="switch">
                                                <input id="check-new" type="checkbox" enableviewstate="false" />
                                                <div class="slider"></div>
                                            </label>
                                            <asp:HiddenField ID="hiddenchknew" runat="server" />
                                        </div>
                                    </div>
                                
                                    <div class="col-md-3">
                                        <div class="form-group">
                                            <label for="check-onsale">En Venta</label>
                                            <!-- Rectangular switch -->
                                            <label class="switch">
                                                <input id="check-onsale" type="checkbox" />
                                                <div class="slider"></div>
                                            </label>
                                            <asp:HiddenField ID="hiddenchkonsale" runat="server" />
                                        </div>
                                    </div>
                                    <div class="row">
                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <label for="txtname">Nombre</label>
                                            <asp:textbox id="txtname" class="form-control" type="text" placeholder="Nombre" runat="server"></asp:textbox>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <label for="txtcomposition">Composición</label>
                                            <asp:textbox id="txtcomposition" class="form-control" type="text" placeholder="Composicion" runat="server"></asp:textbox>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <label for="txtmade">Lugar de fabricación</label>
                                            <asp:textbox id="txtmade" class="form-control" type="text" placeholder="Hecho en" runat="server"></asp:textbox>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <label for="lstcollection">Colección</label>
                                            <asp:DropDownList ID="lstcollection" OnSelectedIndexChanged="lstcategory_SelectedIndexChanged" CssClass="form-control" AppendDataBoundItems="true" runat="server" Visible="True">
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <label for="lstcategory">Categoria</label>
                                            <asp:DropDownList ID="lstcategory" CssClass="form-control" AppendDataBoundItems="true" runat="server" Visible="True" AutoPostBack="true" >
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <label for="txtsubcategory">Sub-Categoria</label>
                                            <asp:DropDownList ID="lstsubcategory" CssClass="form-control" AppendDataBoundItems="true" runat="server" Visible="True">
                                                <asp:listitem value ="-1" disabled selected>--Select Sub-Category--</asp:listitem>  
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                </div>
                                </div>
                                
                </div>
                 <div class="col-md-6">
                                <div class="row">
                                    <div class="col-md-12">
                                        <div class="form-group">
                                            <label for="txtsku">Descripción</label>
                                            <textarea id="txtareadescription" class="form-control" rows="7" runat="server"></textarea>
                                        </div>
                                    </div>
                                </div>

                                <div id="imgsizedetail" class="row" runat="server">
                                    <div class="col-md-12 size-detail">
                                        <div class="row">
                                    
                                            <div class="col-md-12">
                                                <label>Talla</label>
                                                <asp:Image ID="imginstruction" CssClass="imageslide" runat="server" />
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-12 contentupload">
                                                <div class="js">
                                                    <asp:FileUpload id="fileinstruction" name="file-1[]" CssClass="fileinline inputfile inputfile-1" data-multiple-caption="{count} files selected" multiple runat="server" />
					                                <label for="contenido_fileinstruction" runat="server"><svg xmlns="http://www.w3.org/2000/svg" width="20" height="17" viewBox="0 0 20 17"><path d="M10 0l-5.2 4.9h3.3v5.1h3.8v-5.1h3.3l-5.2-4.9zm9.3 11.5l-3.2-2.1h-2l3.4 2.6h-3.5c-.1 0-.2.1-.2.1l-.8 2.3h-6l-.8-2.2c-.1-.1-.1-.2-.2-.2h-3.6l3.4-2.6h-2l-3.2 2.1c-.4.3-.7 1-.6 1.5l.6 3.1c.1.5.7.9 1.2.9h16.3c.6 0 1.1-.4 1.3-.9l.6-3.1c.1-.5-.2-1.2-.7-1.5z"/></svg> <span>Choose a file&hellip;</span></label>
				                                </div>
                                                <div class="buttons">
                                                <asp:LinkButton ID="btnconfirminstruction" CssClass="btn btn-info btnstyle fileinline confirm" runat="server" title="Confirm" ><i class="fa fa-check" aria-hidden="true"></i></asp:LinkButton>
                                                <asp:LinkButton ID="btncleaninstruction" CssClass="btn btn-warning btnstyle fileinline clean" runat="server" title="Clean" ><i class="fa fa-times" aria-hidden="true"></i></asp:LinkButton>
                                                <asp:Label ID="lbluploadedinstruction" class="lbluploaded" runat="server" Text=""></asp:Label>
                                                    </div>
                                            </div>
                                        </div>
                                        
                                    </div>
                                </div>

                                <div class="row" id="bestprod" runat="server">
                                    <div class="col-md-12">
                                        <h3>Más vendidos</h3>
                                        <div class="row">
                                            <div class="col-md-12">
                                                <asp:CheckBox ID="chkbestseller" Text="&nbsp;Remover de lista de más vendidos" runat="server" />
                                            </div>
                                        </div>
                                
                                    </div>
                                </div>
                    </div>
                </div>
            </div>
          <div class="row" id="Div1" runat="server">
            <div class="col-md-12">
                 <div class="box-body">

                        
                        <div class="row">
                            <div class="col-md-4">
                                <asp:Button ID="Button1" type="submit" class="btn btn-primary" runat="server" Text="Save"  Visible="false" />
                                <div id="prueba" class="hidden" style="width:20px; height:20px; background-color: blue">click</div>
                            </div>
                        </div>
                        
                    </div>
                    <!-- /.box-body-->
                    <div class="box-footer">
                    <div class="row">
                        <div class="col-md-12">
                            <asp:Button ID="btnsaveproductdata" style="width:100%" type="submit" class="btn btn-info" runat="server" Text="Guardar Datos" OnClick="btnsaveproductdata_Click"/>
                        </div>
                    </div>
                    </div>
                    <!-- box-footer -->
                </div>
                </div>
              </div>
         
   
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="script" Runat="Server">
</asp:Content>

