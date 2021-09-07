<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
	 &nbsp;Number Sorting Web Application</p>
<p>
	 Please enter numbers to be sorted followed by commas.</p>
<p>
	 For example : 1,0,2,9,3,8,4,7,5,6</p>
<p>
	 &nbsp;</p>
<p>
	 ---------&nbsp;&nbsp; ENTER INPUT HERE&nbsp;&nbsp;&nbsp; ------&gt;&nbsp;&nbsp;
	 <asp:TextBox ID="TextBox1" runat="server" Width="554px"></asp:TextBox>
	 <asp:Button ID="Button1" runat="server" Text="Click me to Sort!" />
    </p>
<p>
	 ------&nbsp; SORTED NUMBERS ARE&nbsp; ------&gt;&nbsp;&nbsp;
	 <asp:TextBox ID="TextBox2" runat="server" Width="552px"></asp:TextBox>
</p>
<p>
	 &nbsp;</p>


</asp:Content>
