<%@ Page Title="" Language="C#" MasterPageFile="~/admin/adminmaster.master" AutoEventWireup="true" EnableEventValidation="false" CodeFile="productsearch.aspx.cs" Inherits="admin_productsearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" Runat="Server">
    <div class="container">
        <h2>Buscar Producto</h2>
        <div class="row">
            <div class="col-md-12">
                <!-- Slider one -->
                <div class="box box-solid box-primary">
                    <div class="box-header with-border">

                        <h3 class="box-title">Búsqueda</h3>

                        <div class="box-tools pull-right">
                            <!-- Buttons, labels, and many other things can be placed here! -->
                            <!-- Here is a label for example -->
                            <%--<span class="label label-primary">Label</span>--%>
                            <asp:Button ID="linkproduct"  class="btn btn-info" runat="server" Text="Agregar Producto" OnClick="linkproduct_Click" />
                        </div>
                    </div>
                    <div class="box-body">
                        <div class="row">
                            <div class="col-md-12">
                                <asp:TextBox ID="txtsearchproduct" class="form-control" onkeyup='Filter(this);' runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <br />

                        <div class="row">
                            <div class="col-md-12">
                                <asp:GridView ID="dgvproduct" AllowPaging="true" PagerSettings-PageButtonCount="32" PageSize="20" OnPageIndexChanging="dgvproduct_PageIndexChanging" 
                                    CssClass="table table-bordered" role="grid" DataKeyNames="idproduct" AutoGenerateColumns="False" runat="server" 
                                    OnRowDataBound="dgvproduct_OnRowDataBound" OnSelectedIndexChanged="dgvproduct_SelectedIndexChanged">
                                    <HeaderStyle BackColor="#f9f9f9"  Font-Bold="True" />
                                    <EditRowStyle BackColor="#ffffcc" />
                                    <EmptyDataRowStyle forecolor="#26a69a" CssClass="table table-bordered" />
                                    <emptydatatemplate>
                                        ¡There are no products!  
                                    </emptydatatemplate>

                                    <pagersettings mode="NumericFirstLast"
                                            position="Bottom"           
                                            pagebuttoncount="10" FirstPageText="First" PreviousPageText="Back" NextPageText="Next" LastPageText="Last"/>
                                    <pagerstyle CssClass="paginationstyle"/>
                                    <Columns>
                                        <%--<asp:BoundField DataField="numeracion" HeaderText="#" />--%>
                                        <asp:BoundField DataField="sku" HeaderText="SKU" />
                                        <asp:BoundField DataField="nameproduct" HeaderText="Nombre" />
                                        <asp:BoundField DataField="composition" HeaderText="Composición" />
                                        <asp:BoundField DataField="madein" HeaderText="Hecho en" />
                                        <asp:TemplateField HeaderText="Estado">
                                            <ItemTemplate>
                                                <asp:Label ID="disablelbl" Font-Size="1em" runat="server" Text='<%# Eval("disable")%>' ></asp:Label>
                                                <asp:Label ID="textdisablelbl" Font-Size="1em" runat="server" Text='' ></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView> 
                            </div>
                        </div>

                        <%--<div class="row">
                            <div class="col-md-12">
                                <table id="search" class="table table-bordered table-striped">
                                    <tr>
                                      <th style="width: 10px">#</th>
                                      <th>Name</th>
                                      <th>Company Name</th>
                                      <th>Progress</th>
                                      <th>Status</th>
                                      <th>Total</th>
                                    </tr>
                                    <tr>
                                      <td>1.</td>
                                      <td><a href="orderdetail.aspx">Maria Luisa Flores Valenzuela</a></td>
                                      <td>Sant S.A</td>
                                      <td>
                                        <div class="progress">
                                          <div class="progress-bar progress-bar-danger" style="width: 33%"></div>
                                        </div>
                                      </td>
                                      <td><strong>ORDER RECEIVED</strong></td>
                                      <td><strong>$10000.00</strong></td>
                                    </tr>
                                    <tr>
                                      <td>2.</td>
                                      <td>Luis Ramos Paredes</td>
                                      <td>Romero S.A.C</td>
                                      <td>
                                        <div class="progress">
                                          <div class="progress-bar progress-bar-warning" style="width: 66%"></div>
                                        </div>
                                      </td>
                                      <td><strong>IN PROCESS</strong></td>
                                      <td><strong>$20000.00</strong></td>
                                    </tr>
                                    <tr>
                                      <td>3.</td>
                                      <td>Jimena Landa Rojas</td>
                                      <td>Ramos S.A</td>
                                      <td>
                                        <div class="progress">
                                          <div class="progress-bar progress-bar-danger" style="width: 33%"></div>
                                        </div>
                                      </td>
                                      <td><strong>ORDER RECEIVED</strong></td>
                                      <td><strong>$5000.00</strong></td>
                                    </tr>
                                    <tr>
                                      <td>4.</td>
                                      <td>Juan Perez</td>
                                      <td>Santa Cruz S.A.C</td>
                                      <td>
                                        <div class="progress">
                                          <div class="progress-bar progress-bar-success" style="width: 100%"></div>
                                        </div>
                                      </td>
                                      <td><strong>SENT</strong></td>
                                      <td><strong>$15700.00</strong></td>
                                    </tr>
                                  </table>
                            </div>
                        </div>--%>
                        
                        

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
            var product = document.getElementById('product');
            product.setAttribute('class', 'active');
        });
    </script>
    <script>
        //onkeyup = 'Filter(this);'
        function Filter(Obj) {


            //todas las celdas
            var grid = document.getElementById('contenido_dgvproduct');
            var terms = Obj.value.toUpperCase();
            //var cellNr = 2; //your grid cellindex like name
            var ele;
            for (var r = 1; r < grid.rows.length; r++) {
                ele = grid.rows[r].innerHTML.replace(/<[^>]+>/g, "");
                if (ele.toUpperCase().indexOf(terms) >= 0)
                    grid.rows[r].style.display = '';
                else grid.rows[r].style.display = 'none';
            }

            //solo una celda
            //var grid = document.getElementById('cuerpo_dgvcompras');
            //var terms = Obj.value.toUpperCase();
            //var cellNr = 2; //your grid cellindex like name
            //var ele;
            //for (var r = 1; r < grid.rows.length; r++) {
            //    ele = grid.rows[r].cells[cellNr].innerHTML.replace(/<[^>]+>/g, "");
            //    if (ele.toUpperCase().indexOf(terms) >= 0)
            //        grid.rows[r].style.display = '';
            //    else grid.rows[r].style.display = 'none';
            //}
        }
    </script>
</asp:Content>

