<%@ Page Title="" Language="C#" MasterPageFile="~/PMAWeb.Master" AutoEventWireup="true" CodeBehind="Projects.aspx.cs" Inherits="PMAWeb.Pages.Projects" %>

<asp:Content ID="CurrentPageName" ContentPlaceHolderID="CurrentPageName" runat="server">
    Projets
</asp:Content>
<asp:Content ID="PageContent" ContentPlaceHolderID="PageContent" runat="server">
    <div class="row-fluid sortable">
        <div class="box span12">
            <div class="box-header" data-original-title>
                <h2><i class="halflings-icon list-alt"></i><span class="break"></span>Projets</h2>
                <div class="box-icon">
                    <a href="#" class="btn-minimize"><i class="halflings-icon chevron-up"></i></a>
                </div>
            </div>
            <div class="box-content">

                <table class="table table-striped table-bordered datatable">
                    <thead>
                        <tr>
                            <th>Nom</th>
                            <th>Date de Début</th>
                            <th>Date de Fin</th>
                            <th>Responsable</th>
                            <%--<th>Statut</th>--%>
                        </tr>
                    </thead>
                    <tbody>
                        <asp:Repeater ID="Repeater1" runat="server">

                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <asp:Label runat="server" ID="ProjectName"
                                            Text='<%# Eval("Name") %>' />
                                    </td>
                                    <td>
                                        <asp:Label runat="server" ID="StartDate"
                                            Text='<%# Convert.ToDateTime(Eval("StartDate")).ToString("dd/MM/yyyy") %>' />
                                    </td>
                                    <td>
                                        <asp:Label runat="server" ID="EndDate"
                                            Text='<%# Convert.ToDateTime(Eval("EndDate")).ToString("dd/MM/yyyy")  %>' />
                                    </td>
                                    <td>
                                        <asp:Label runat="server" ID="OwnerName"
                                            Text='<%# string.Concat(Eval("OwnerFirstName") + " " + Eval("OwnerLastName")) %>' />
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <%--                            <tr>
                                <td>PMA</td>
                                <td>Jason Tresfield</td>
                                <td>Octobre 2014</td>
                                <td>Octobre 2015</td>
                                <td>
                                    <span class="label label-warning">En Cours</span>
                                </td>
                            </tr>--%>
                        </asp:Repeater>
                    </tbody>
                </table>
            </div>
        </div>
        <!--/span-->

    </div>
    <!--/row-->
</asp:Content>
