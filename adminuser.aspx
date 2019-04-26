<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminmaster.master" AutoEventWireup="true" enableEventValidation="false" CodeFile="adminuser.aspx.cs" Inherits="admin_adminuser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <div class="container">
        <h2>Administración de Usuarios</h2>
        <div class="row">
            <div class="col-md-12">
                <!-- Slider one -->
                <div class="box box-solid box-info">
                    <div class="box-header with-border">
                        <h3 class="box-title">Agregar Usuario</h3>
                        <div class="box-tools pull-right">
                            <!-- Buttons, labels, and many other things can be placed here! -->
                            <!-- Here is a label for example -->
                            <%--<span class="label label-primary">Label</span>--%>
                        </div>
                    </div>
                    <div class="box-body">
                        <div class="row">
                            <div class="col-md-6">
                                <div class="row form-group">
                                    <div class="col-md-4">
                                        <label>Primer Nombre</label>
                                    </div>
                                    <div class="col-md-8">
                                        <asp:TextBox ID="txtfirstname" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row form-group">
                                    <div class="col-md-4">
                                        <label>Apellidos</label>
                                    </div>
                                    <div class="col-md-8">
                                        <asp:TextBox ID="txtlastname" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row form-group">
                                    <div class="col-md-4">
                                        <label>Email</label>
                                    </div>
                                    <div class="col-md-8">
                                        <asp:TextBox ID="txtemail" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row form-group">
                                    <div class="col-md-4">
                                        <label>Password</label>
                                    </div>
                                    <div class="col-md-8">
                                        <asp:TextBox ID="txtpass" type="password" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row form-group">
                                    <div class="col-md-4">
                                        <label>Confirmar Password</label>
                                    </div>
                                    <div class="col-md-8">
                                        <asp:TextBox ID="txtconfirmpass" type="password" class="form-control" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row form-group">
                                    <div class="col-md-4"></div>
                                    <div class="col-md-4">
                                        <asp:LinkButton ID="btnadduser" Width="100%" class="btn btn-info" runat="server" OnClick="btnadduser_Click">GUARDAR</asp:LinkButton>
                                    </div>
                                    <div class="col-md-4">
                                        <asp:LinkButton ID="btndelete" Width="48%" Visible="false" class="btn btn-danger" runat="server" OnClick="btndelete_Click">Borrar</asp:LinkButton>
                                        <asp:LinkButton ID="btnnewuser" Width="48%" class="btn btn-default" runat="server" OnClick="btnnewuser_Click">New</asp:LinkButton>
                                    </div>
                                </div>
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
                        <h3 class="box-title">Users</h3>
                        <div class="box-tools pull-right">
                            <!-- Buttons, labels, and many other things can be placed here! -->
                            <!-- Here is a label for example -->
                            <%--<span class="label label-primary">Label</span>--%>
                        </div>
                    </div>
                    <div class="box-body">
                        <div class="row">
                            <div class="col-md-12">
                                <asp:GridView ID="dgvadminuser" AllowPaging="true" PagerSettings-PageButtonCount="32" PageSize="15" OnPageIndexChanging="dgvadminuser_PageIndexChanging" 
                                    CssClass="table table-bordered" role="grid" DataKeyNames="idadminuser" AutoGenerateColumns="False" runat="server" 
                                    OnRowDataBound="dgvadminuser_OnRowDataBound" OnSelectedIndexChanged="dgvadminuser_SelectedIndexChanged">
                                    <HeaderStyle BackColor="#f9f9f9"  Font-Bold="True" />
                                    <EditRowStyle BackColor="#ffffcc" />
                                    <EmptyDataRowStyle forecolor="#26a69a" CssClass="table table-bordered" />
                                    <emptydatatemplate>
                                        There are no users!  
                                    </emptydatatemplate>

                                    <pagersettings mode="NumericFirstLast"
                                            position="Bottom"           
                                            pagebuttoncount="10" FirstPageText="First" PreviousPageText="Back" NextPageText="Next" LastPageText="Last"/>
                                    <pagerstyle CssClass="paginationstyle"/>
                                    <Columns>
                                        <%--<asp:BoundField DataField="numeracion" HeaderText="#" />--%>
                                        <asp:BoundField DataField="firstname" HeaderText="Primer Nombre" />
                                        <asp:BoundField DataField="lastname" HeaderText="Apellidos" />
                                        <asp:BoundField DataField="email" HeaderText="Email" />
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
</asp:Content>

