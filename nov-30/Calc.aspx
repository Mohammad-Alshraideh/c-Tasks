<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calc.aspx.cs" Inherits="nov_30.Calc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style6 {
            width: 29%;
            height: 232px;
        }
        .auto-style7 {
            width: 16%;
            height: 218px;
            border: 1px solid #000000;
        }
        .auto-style8 {
            width: 457px;
        }
        .auto-style10 {
            width: 205px;
        }
        .auto-style11 {
            width: 412px;
        }
        .auto-style12 {
            width: 100%;
        }
        .auto-style13 {
            width: 412px;
            height: 54px;
        }
        .auto-style14 {
            height: 54px;
        }
        .auto-style15 {
            width: 457px;
            height: 54px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" Width="298px"></asp:TextBox>

        </div>
        <table class="auto-style6">
            <tr>
                <td class="auto-style10">
                    <table class="auto-style7">
                        <tr>
                            <td class="auto-style11">
                                <asp:Button ID="Button4" runat="server" Height="40px" OnClick="Button4_Click" Text="0" UseSubmitBehavior="False" Width="68px" />
                            </td>
                            <td>
                                <asp:Button ID="Button2" runat="server" Height="40px" OnClick="Button2_Click1" Text="+" Width="68px" />
                            </td>
                            <td class="auto-style8">
                                <asp:Button ID="Button1" runat="server" Height="40px" OnClick="Button1_Click" Text="-" Width="68px" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style11">
                                <asp:Button ID="Button10" runat="server" Height="40px" OnClick="Button10_Click" Text="7" Width="68px" />
                            </td>
                            <td>
                                <asp:Button ID="Button11" runat="server" Height="40px" OnClick="Button11_Click1" Text="8" Width="68px" />
                            </td>
                            <td class="auto-style8">
                                <asp:Button ID="Button7" runat="server" Height="40px" OnClick="Button7_Click" Text="9" Width="68px" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style11">
                                <asp:Button ID="Button14" runat="server" Height="40px" OnClick="Button14_Click" Text="4" Width="68px" />
                            </td>
                            <td>
                                <asp:Button ID="Button12" runat="server" Height="40px" OnClick="Button12_Click" Text="5" Width="68px" />
                            </td>
                            <td class="auto-style8">
                                <asp:Button ID="Button8" runat="server" Height="40px" OnClick="Button8_Click" Text="6" Width="68px" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style13">
                                <asp:Button ID="Button15" runat="server" Height="40px" OnClick="Button15_Click" Text="1" Width="68px" />
                            </td>
                            <td class="auto-style14">
                                <asp:Button ID="Button13" runat="server" Height="40px" OnClick="Button13_Click" Text="2" Width="68px" />
                            </td>
                            <td class="auto-style15">
                                <asp:Button ID="Button9" runat="server" Height="40px" OnClick="Button9_Click" Text="3" Width="68px" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td>
                    <table class="auto-style12">
                        <tr>
                            <td>
            <asp:Button ID="Button17" runat="server" OnClick="Button17_Click" Text="C" Height="40px" Width="68px" />
                                </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button6" runat="server" Height="40px" OnClick="Button6_Click" Text="*" Width="68px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button3" runat="server" Height="40px" OnClick="Button3_Click" Text="/" Width="68px" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button16" runat="server" Height="40px" OnClick="Button16_Click" Text="." Width="68px" />
                                </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="Button5" runat="server" Height="40px" OnClick="Button5_Click" Text="=" Width="116px" />
                                </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
