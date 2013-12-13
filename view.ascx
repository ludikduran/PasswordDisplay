<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="view.ascx.cs" Inherits="LD2.PasswordDisplay.view" %>
<%@ Register TagPrefix="dnn" TagName="label" Src="~/controls/LabelControl.ascx" %>

<asp:Repeater ID="rptUserList" runat="server">
    <HeaderTemplate>
        <table width="100%">
            <thead>
                <tr>
                    <th>
                        <asp:Label ID="lblUserID" runat="server" Text="UserId" />
                    </th>
                    <th>
                        <asp:Label ID="lblUserName" runat="server" Text="UserName" />
                    </th>
                    <th>
                        <asp:Label ID="lblPassword" runat="server" Text="Password" />
                    </th>
                </tr>
            </thead>
    </HeaderTemplate>

    <ItemTemplate>
        <tr>
            <td>
                <asp:Label ID="ItmUserID" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"userID").ToString() %>' />
            </td>
            <td>
                <asp:Label ID="ItmUserName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"userName").ToString() %>' />
            </td>
            <td>
                <asp:Label ID="ItmPassword" runat="server" Text='Password' />
            </td>
        </tr>
    </ItemTemplate>

    <FooterTemplate>
        </table>
    </FooterTemplate>
</asp:Repeater>

