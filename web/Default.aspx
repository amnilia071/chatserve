<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style3
        {
            height: 53px;
        }
        .style4
        {
            height: 29px;
        }
        .style5
        {
            height: 64px;
        }
        .style6
        {
            height: 9px;
        }
        .style7
        {
            height: 7px;
        }
        .style8
        {
            height: 296px;
        }
        .style9
        {
            height: 53px;
            width: 263px;
        }
        .style10
        {
            height: 64px;
            width: 263px;
        }
        .style11
        {
            height: 29px;
            width: 263px;
        }
        .style13
        {
            height: 9px;
            width: 263px;
        }
        .style14
        {
            height: 7px;
            width: 263px;
        }
        .style16
        {
            width: 263px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table width="100%">
        <tr>
            <td align="center" class="style8">
                <table style="background-image: url('pic/Chat.jpg'); height: 244px; width: 28%;">
                    <tr>
                        <td class="style3">
                        </td>
                        <td class="style9">
                        </td>
                        <td class="style3">
                        </td>
                    </tr>
                    <tr>
                         
                        <td colspan ="2" align ="center"  class="style10">
                            <asp:Label ID="Label3" runat="server" Text="Technical Chat Support System" 
                                style="font-size: large; font-family: 'Baskerville Old Face'"></asp:Label>
                        </td>
                        <td class="style5">
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style4">
                            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
                        </td>
                        <td align="left" class="style11">
                            &nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtusername" runat="server" 
                                Width="150px"></asp:TextBox>
                        </td>
                        <td class="style4">
                        </td>
                    </tr>
                    <tr>
                        <td align="right">
                            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                        </td>
                        <td align="left" class="style16">
                            &nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtpassword" runat="server" 
                                TextMode="Password" Width="150px"></asp:TextBox>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                        </td>
                        <td align="left" class="style13">
                            <asp:Label ID="lblmes" runat="server"></asp:Label>
                        </td>
                        <td class="style6">
                        </td>
                    </tr>
                    <tr>
                        <td class="style7">
                        </td>
                        <td align="left" class="style14">
                          
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/SignUp.aspx">Sign Up here!!</asp:HyperLink>
&nbsp;</td>
                        <td >
                        </td>
                    </tr>
                     <tr>
                        <td class="style7">
                        </td>
                        <td align="left" class="style14">
                          
                            <asp:Button ID="Button1" runat="server" Text="Login" Width="151px" />
                          
                            </td>
                        <td >
                        </td>
                    </tr>
                  
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

