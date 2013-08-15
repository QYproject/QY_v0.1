<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowDocumentList.aspx.cs" Inherits="青羊教育网络学习平台.ShowDocument" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 447px">
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="搜索" />
        <br />
        <asp:TextBox ID="TXT1" runat="server" Height="21px" TextMode="MultiLine" Width="629px"></asp:TextBox>
        <asp:GridView ID="GridView1" runat="server" Width="625px" AllowPaging="True" AutoGenerateColumns="False" BackColor="#F4F4FF" BorderColor="White" BorderStyle="None" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="7">
            <Columns>
                <asp:TemplateField HeaderText="资源名称">
                    <ItemTemplate>
                        <a href="ShowDocumentDetail.aspx?ID=<%#Eval("ID")%> "><%#Eval("Title")%> </a>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Size" HeaderText="资料大小" />

                <asp:BoundField DataField="Format" HeaderText="格式" />
                <asp:ButtonField DataTextField="Title" />
                <asp:CommandField />
            </Columns>
            <PagerStyle BackColor="#CCCCFF" />
        </asp:GridView>
    
        <asp:Repeater ID="Repeater1" runat="server">
        </asp:Repeater>
    
    </div>    
    </form>
</body>
</html>
