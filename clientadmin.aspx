<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminmaster.master" AutoEventWireup="true" enableEventValidation="false" CodeFile="clientadmin.aspx.cs" Inherits="admin_clientadmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <div class="container">
        <h2>Register Detail</h2>
        <div class="row">
            <div class="col-md-12">
                <!-- Slider one -->
                <div id="colorbox" class="box box-solid box-info" runat="server">
                    <div class="box-header with-border">

                        <h3 class="box-title">Client Data</h3>
                        <%--<label class="client-check pull-right">CLIENT ACCEPTTED</label>--%>
                        <div class="box-tools pull-right">
                            <!-- Buttons, labels, and many other things can be placed here! -->
                            <!-- Here is a label for example -->
                            <%--<span class="label label-primary">Label</span>--%>
                            
                            <%--<label class="switch" style="display: inline-block;margin-left: 1em">
                                <input id="check-accept" type="checkbox" style="display: inline-block"/>
                                <div class="slider"></div>
                            </label>--%>
                        </div>
                    </div>
                    <div class="box-body">
                        <div class="row">
                            <div class="col-md-2 col-md-offset-10">
                                <asp:LinkButton ID="btnsessionclient" class="btn btn-danger" Width="100%" runat="server" OnClick="btnsessionclient_Click">Open the client session</asp:LinkButton>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <h3>Personal Data</h3>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6">
                                <div class="row form-group">
                                    <div class="col-md-3 dataform">
                                        <label class="control-label">First Name</label>
                                    </div>
                                    <div class="col-md-7">
                                        <asp:TextBox ID="txtfirstname" type="text" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row form-group">
                                    <div class="col-md-3 dataform">
                                        <label class="control-label">Last Name</label>
                                    </div>
                                    <div class="col-md-7">
                                        <asp:TextBox ID="txtlastname" type="text" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row form-group">
                                    <div class="col-md-3 dataform">
                                        <label>Date of birth</label>
                                    </div>
                                    <div class="col-md-7">
                                        <asp:TextBox ID="txtbirth" class="form-control datepicker" placeholder="mm-dd-yyyy" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row form-group">
                                    <div class="col-md-3 dataform">
                                        <label>Phone</label>
                                    </div>
                                    <div class="col-md-7">
                                        <asp:TextBox ID="txtphone" type="tel" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row form-group">
                                    <div class="col-md-3 dataform">
                                        <label class="control-label">Address 1</label>
                                    </div>
                                    <div class="col-md-7">
                                        <asp:TextBox ID="txtaddress" type="text" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="row form-group">
                                    <div class="col-md-3 dataform">
                                        <label>Country</label>
                                    </div>
                                    <div class="col-md-7">
                                        <asp:TextBox ID="txtcountry" type="text" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row form-group">
                                    <div class="col-md-3 dataform">
                                        <label>State / Province / Region</label>
                                    </div>
                                    <div class="col-md-7">
                                        <asp:TextBox ID="txtstate" type="text" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row form-group">
                                    <div class="col-md-3 dataform">
                                        <label class="control-label">Zip / Postal Code</label>
                                    </div>
                                    <div class="col-md-7">
                                        <asp:TextBox ID="txtpostalcode" type="text" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row form-group">
                                    <div class="col-md-3 dataform">
                                        <label class="control-label">City</label>
                                    </div>
                                    <div class="col-md-7">
                                        <asp:TextBox ID="txtcity" type="text" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="divider" style="border:1px solid #eee"></div>

                        <div class="row">
                            <div class="col-md-6">
                                <div class="row">
                                    <div class="col-md-12">
                                        <h3>Shopper Information</h3>
                                    </div>
                                </div>
                                <div class="row form-group">
                                    <div class="col-md-3 dataform">
                                        <label for="txtemail" class="control-label">E-Mail</label>
                                    </div>
                                    <div class="col-md-7">
                                        <asp:TextBox ID="txtemail" type="email" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row form-group">
                                    <div class="col-md-3 dataform">
                                        <label for="txtpassword" class="control-label">Password</label>
                                    </div>
                                    <div class="col-md-7">
                                        <asp:TextBox ID="txtpassword" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-3 dataform">
                                        <label>Others</label>
                                    </div>
                                    <div class="col-md-7">
                                        <asp:TextBox ID="txtothers" type="text" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="row">
                                    <div class="col-md-12">
                                        <h3>Bill To</h3>
                                    </div>
                                </div>
                                <div class="row form-group">
                                    <div class="col-md-3 dataform">
                                        <label>Company Name</label>
                                    </div>
                                    <div class="col-md-7">
                                        <asp:TextBox ID="txtcompanyname" type="text" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row form-group">
                                    <div class="col-md-3 dataform">
                                        <label>TaxID</label>
                                    </div>
                                    <div class="col-md-7">
                                        <asp:TextBox ID="txttaxid" type="text" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row form-group">
                                    <div class="col-md-3 dataform">
                                        <label>Website</label>
                                    </div>
                                    <div class="col-md-7">
                                        <asp:TextBox ID="txtwebsite" type="text" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>


                        <div class="divider" style="border:1px solid #eee"></div>
                        
                        <br />
                        <div class="row">
                            <div class="col-md-5 col-lg-offset-3 buttonreg">
                                <%--<asp:LinkButton ID="btnaccept" Width="100%" class="btn btn-primary" runat="server" OnClick="btnaccept_Click">ACCEPT</asp:LinkButton>--%>
                                <%--<asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" Visible="false" />--%>
                            </div>
                        </div>
                    </div>
                    <!-- /.box-body-->
                    <%--<div class="box-footer">
                    The footer of the box
                    </div>--%><!-- box-footer -->
                </div>
                <!-- /.box -->
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <!-- Slider one -->
                <div class="box box-solid box-warning">
                    <div class="box-header with-border">

                        <h3 class="box-title">Shopping Cart Orders</h3>

                        <div class="box-tools pull-right">
                            <!-- Buttons, labels, and many other things can be placed here! -->
                            <!-- Here is a label for example -->
                            <%--<span class="label label-primary">Label</span>--%>
                        </div>
                    </div>
                    <div class="box-body">
                        <div class="row">
                            <div class="col-md-12">
                                <asp:GridView ID="dgvorderclient" Width="100%" AllowPaging="true" PagerSettings-PageButtonCount="32" PageSize="20" 
                                    OnPageIndexChanging="dgvorderclient_PageIndexChanging" runat="server" CssClass="table table-bordered" AutoGenerateColumns="False" 
                                    GridLines="None" DataKeyNames="idcart" OnSelectedIndexChanged="dgvorderclient_SelectedIndexChanged" OnRowDataBound="dgvorderclient_OnRowDataBound">
                                    <HeaderStyle BackColor="#f9f9f9" Font-Bold="True" />
                                    <EditRowStyle BackColor="#ffffcc" />
                                    <EmptyDataRowStyle forecolor="#26a69a" CssClass="table table-bordered" />
                                    <emptydatatemplate>
                                        ¡There is no order!  
                                    </emptydatatemplate>
                                    <pagersettings mode="NumericFirstLast"
                                            position="Bottom"           
                                            pagebuttoncount="10" FirstPageText="Inicio" PreviousPageText="Atrás" NextPageText="Adelante" LastPageText="Último"/>
                                    <pagerstyle CssClass="paginationstyle"/>
                                    <Columns>
                                        <asp:TemplateField HeaderText="Order">
                                            <ItemTemplate>
                                                <asp:Label ID="orderlbl" Font-Size="1em" runat="server" Text='<%# Eval("numorder")%>' >
		                                        </asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Client">
                                            <ItemTemplate>
                                                <asp:Label ID="namelbl" Font-Size="1em" runat="server" Text='<%# Eval("clientname")%>' >
		                                        </asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Company Name">
                                            <ItemTemplate>
                                                <asp:Label ID="companylbl" Font-Size="1em" runat="server" Text='<%# Eval("companyname")%>' >
		                                        </asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Progress">
                                            <ItemTemplate>
                                                <asp:Label ID="shippingprogresslbl" Font-Size="1em" runat="server" Text='<%# Eval("shippingprogress")%>' ></asp:Label>
                                                <div class="progress">
                                                    <asp:Panel ID="Panelprogress" class="progress-bar progress-bar-danger" style="width:0%" runat="server"></asp:Panel>
                                                </div>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Status">
                                            <ItemTemplate>
                                                <asp:Label ID="statuslbl" Font-Size="1em" style="font-weight:700" runat="server" Text='' ></asp:Label>
                                                <asp:Label ID="notificationlbl" Font-Size="1em" style="font-weight:700" runat="server" Text='<%# Eval("notifpaidorder")%>' ></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Total">
                                            <ItemTemplate>
                                                <asp:Label ID="totallbl" Font-Size="1em" runat="server" Text='<%# Eval("total")%>' >
		                                        </asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Date">
                                            <ItemTemplate>
                                                <asp:Label ID="datepaymentcartlbl" Font-Size="1em" runat="server" Text='<%# Eval("datepaymentcart")%>' >
		                                        </asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                            

                                        <%--<asp:TemplateField HeaderText="" ShowHeader="false">
                                            <ItemTemplate>
                                                <div class="right">
                                                <asp:LinkButton ID="btnedit" class="btn btn-primary btncircle" title="Edit" runat="server" CommandName="Edit"><i class="fa fa-pencil"></i></asp:LinkButton>
                                                <asp:LinkButton ID="btneliminar" class="btn btn-danger btncircle" title="Delete" OnClientClick="return confirm('¿Seguro que desea eliminar la sub categoria, si ya fue usado esta coleccion en algún producto generara errores al eliminar?');" runat="server" CommandName="Delete"><i class="fa fa-times"></i></asp:LinkButton>
                                                </div>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <div class="right">
                                                <asp:LinkButton ID="btnupdate" class="btn btn-success btncircle" title="Save" runat="server" CommandName="Update"><i class="fa fa-floppy-o"></i></asp:LinkButton>
                                                <asp:LinkButton ID="btncancel" class="btn btn-warning btncircle" title="Cancel" runat="server" CommandName="Cancel"><i class="fa fa-ban"></i></asp:LinkButton>
                                                </div>
                                            </EditItemTemplate>
                                            </asp:TemplateField>--%>
              
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                    <!-- /.box-body-->
                    <%--<div class="box-footer">
                    The footer of the box
                    </div>--%><!-- box-footer -->
                </div>
                <!-- /.box -->
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="script" Runat="Server">
    <script>
        window.addEventListener('load', function () {
            var product = document.getElementById('client');
            product.setAttribute('class', 'active');
        });
    </script>
</asp:Content>

