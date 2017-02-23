<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false"
    CodeFile="Menu.aspx.vb" Inherits="Menu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    <style type="text/css">
        .style1
        {
            width: 14px;
        }
        .style2
        {
            width: 18px;
        }
        .style3
        {
            height: 42px;
        }
        .style4
        {
            width: 14px;
            height: 42px;
        }
        .style5
        {
            width: 158px;
        }
        .style6
        {
            height: 24px;
        }
        .style7
        {
            height: 23px;
        }
        .style8
        {
            height: 23px;
            width: 263px;
        }
        .style9
        {
            width: 263px;
        }
        .style10
        {
            height: 42px;
            width: 263px;
        }
        .style11
        {
            height: 23px;
            width: 88px;
        }
        .style12
        {
            width: 88px;
        }
        .style13
        {
            height: 42px;
            width: 88px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <table>
        <tr>
            <td align="center">
                <table style="width: 101%">
                    <tr>
                        <td colspan="3">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:ScriptManager ID="ScriptManager1" runat="server">

                </asp:ScriptManager>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/pic/123.jpg" />
                        </td>
                    </tr>
                    <tr>
                        <td align="center" valign="top" class="style5">
                            <table style="background-image: url('pic/pics.jpg'); height: 356px; width: 174px;
                                margin-top: 0px;">
                                <tr>
                                    <td class="style6">
                                    </td>
                                    <td class="style6">
                                        <asp:Label ID="Label3" runat="server" Text="Select Room" 
                                            Style="color: #FFFFFF"></asp:Label>
                                    </td>
                                    <td class="style6">
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style6">
                                    </td>
                                    <td class="style6">
                                        <asp:DropDownList ID="DropDownList1"  AutoPostBack ="true"  runat="server" 
                                            Height="18px" Width="104px">
                                        </asp:DropDownList>
                                    </td>
                                    <td class="style6">
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style3" valign="top">
                                        &nbsp;</td>
                                    <td valign="top" rowspan="5" align="left" class="style4">
                                        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label4" runat="server" Text="Select user" 
                                            Style="color: #FFFFFF"></asp:Label>
                                        <asp:DropDownList ID="DropDownList2"  AutoPostBack ="true"  runat="server" 
                                            Height="18px" Width="104px">
                                        </asp:DropDownList>
                                        </td>
                                    <td class="style4">
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style3" valign="top">
                                    </td>
                                    <td align="left" class="style4">
                                        &nbsp;&nbsp;&nbsp;&nbsp;
                                    </td>
                                    
                                </tr>
                                <tr>
                                    <td class="style2" valign="top">
                                        &nbsp;
                                    </td>
                                    <td align="left">
                                        &nbsp;&nbsp;&nbsp;&nbsp;
                                    </td>
                                   
                                </tr>
                                <tr>
                                    <td class="style1">
                                        &nbsp;
                                    </td>
                                    <td align="left" class="style1">
                                        &nbsp;
                                    </td>
                                     
                                </tr>
                                <tr>
                                    <td class="style1">
                                        &nbsp;
                                    </td>
                                    <td align="left" class="style1">
                                        
                                    </td>
                                    
                                </tr>
                                <tr>
                                    <td>
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                            </table>
                            <asp:Timer ID="Timer1" runat="server" Interval="8000">
                            </asp:Timer>
                        </td>
                        <td align="left">
                            <table style="background-image: url('pic/pics.jpg'); height: 356px; width: 464px;
                                margin-top: 0px;">
                                <tr>
                                    <td class="style11">
                                    </td>
                                    <td class="style8">
                                    </td>
                                    <td class="style7">
                                    </td>
                                </tr>
                                <tr>
                                    <td class="style12">
                                        &nbsp;
                                    </td>
                                    <td class="style9">
                                        &nbsp;</td>
                                    <td class="style1">
                                    </td>
                                </tr>
                                <tr>
                                    <td valign="top" class="style13">
                                        <asp:Label ID="Label2" runat="server" Text="Sales" Style="color: #FFFFFF"></asp:Label>
                                    &nbsp;<asp:Label ID="Label5" runat="server"></asp:Label>
                                    </td>
                                    <td align="left" class="style10">
                                       
                                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                            <ContentTemplate>
                                                <asp:TextBox ID="TextBox1" runat="server" Height="211px" ReadOnly="True" 
                                                    TextMode="MultiLine" Width="300px"></asp:TextBox>
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </td>
                                    <td class="style4">
                                    </td>
                                </tr>
                                <tr>
                                    <td valign="top" class="style13">
                                        <asp:Label ID="Label1" runat="server" Text="Me:" Style="color: #FFFFFF"></asp:Label>
                                    </td>
                                    <td align="left" class="style10">
                                   <table><tr><td>
                                        <asp:TextBox ID="txtnote" runat="server" Height="43px" Width="246px"></asp:TextBox>
                                        </td><td>
                                        <asp:Button ID="Button1" runat="server" Text="Send" Height="52px" Width="52px" />
                                        </td></tr></table>
                                    </td>
                                    <td class="style4">
                                    </td>
                                </tr>
                                
                            </table>
                            <br />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
