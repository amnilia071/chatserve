<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="SignUp.aspx.vb" Inherits="SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 285px;
        }
        .style2
        {
            width: 283px;
        }
        .style3
        {
            width: 237px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table width="100%">
        <tr>
            <td align="center">
                <table style="background-image: url('pic/Chat.jpg'); height: 356px; width: 464px;">
                    <tr>
                        <td class="style3">
                        </td>
                        <td class="style2">
                        </td>
                        
                    </tr>
                    <tr>
                         
                        <td colspan ="2" align ="center"  class="style2">
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/pic/123.jpg" Width="425px" />
                        </td>
                        
                    </tr>
                    <tr>
                        <td align="left" class="style3">
                            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
                        </td>
                        <td align="left" class="style2">
                           
                            <asp:TextBox ID="txtusername" runat="server" Height="20px" Width="200px"></asp:TextBox>
                        </td>
                       
                    </tr>
                    <tr>
                        <td align="left" class="style3">
                            <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
                        </td>
                        <td align="left" class="style2">
                          
                            <asp:TextBox ID="TextBox1" runat="server" Height="20px" TextMode="Password" 
                                Width="200px"></asp:TextBox>
                        </td>
                        
                    </tr>
                    <tr>
                        <td align="left" class="style3">
                            <asp:Label ID="Label2" runat="server" Text="Confirm Password"></asp:Label>
                        </td>
                        <td align="left" class="style2">
                          
                            <asp:TextBox ID="TextBox2" runat="server" Height="20px" TextMode="Password" 
                                Width="200px"></asp:TextBox>
                        </td>
                         
                    </tr>
                    <tr>
                        <td align="left" class="style3">
                            <asp:Label ID="Label4" runat="server" Text="Account Type"></asp:Label>
                        </td>
                        <td align="left" class="style2">
                         
                            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" 
                                Height="20px" Width="200px">
                            </asp:DropDownList>
                        </td>
                        
                    </tr>
                    <tr>
                        <td align="right" class="style3">
                            &nbsp;</td>
                        <td align="center" class="style2">
                            <asp:Label ID="lblmes" runat="server"></asp:Label>
                        </td>
                       
                    </tr>
                    <tr>
                        <td class="style3">
                        </td>
                        <td align="left" class="style2">
                            <asp:Button ID="Button1" runat="server" Height="23px" Text="Save" 
                                Width="126px" />
                        </td>
                        
                    </tr>
                    <tr>
                        <td class="style3">
                        </td>
                        <td align="left" class="style2">
                           
                        </td>
                       
                    </tr>
                    <tr>
                        <td class="style3">
                        </td>
                        <td class="style2">
                            &nbsp;
                        </td>
                         
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

