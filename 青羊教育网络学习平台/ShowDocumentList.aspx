﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowDocumentList.aspx.cs" Inherits="青羊教育网络学习平台.ShowDocument" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 348px">
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="搜索" />
        <br />
        <asp:TextBox ID="TXT1" runat="server" Height="189px" TextMode="MultiLine" Width="492px"></asp:TextBox>
        <asp:GridView ID="GridView1" runat="server" Width="270px">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
