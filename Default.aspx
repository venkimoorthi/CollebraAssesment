<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table border="1">
                <tr>
                    <th colspan="4" style="text-align: center">Promotion Engine</th>
                </tr>
                <tr>
                    <th>Item</th>
                    <th>Price</th>
                    <th>Quantity</th>
                    <th>Option</th>
                </tr>
                <tr>
                    <td>A : </td>
                    <td>50 </td>
                    <td>
                        <asp:TextBox ID="txtQtyA" runat="server">0</asp:TextBox>
                    </td>
                    <td>
                        <asp:CheckBox ID="chkA" runat="server" /></td>
                </tr>
                <tr>
                    <td>B : </td>
                    <td>30 </td>
                    <td>
                        <asp:TextBox ID="txtQtyB" runat="server">0</asp:TextBox>
                    </td>
                    <td>
                        <asp:CheckBox ID="chkB" runat="server" /></td>
                </tr>
                <tr>
                    <td>C : </td>
                    <td>20 </td>
                    <td>
                        <asp:TextBox ID="txtQtyC" runat="server">0</asp:TextBox>
                    </td>
                    <td>
                        <asp:CheckBox ID="chkC" runat="server" /></td>
                </tr>
                <tr>
                    <td>D : </td>
                    <td>15 </td>
                    <td>
                        <asp:TextBox ID="txtQtyD" runat="server">0</asp:TextBox>
                    </td>
                    <td>
                        <asp:CheckBox ID="chkD" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td colspan="4" style="text-align: center">
                        <asp:Button ID="btnSubmit" runat="server" Text="Validate Order" OnClick="btnSubmit_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="4" style="text-align: center; color: green">
                        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
