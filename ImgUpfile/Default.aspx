<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>第一个Azure web page</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
第一个Azure web page
    </div>
        <% for (int i = 0; i < 10; i++)
           {%>
              <h<%=i %>>  h<%=i %>这里是标提</h<%=i %>>
          </div>        
          <% } %>
       
          
    </form>
    <table class="auto-style1">
        <tr>
            <td style="color: #FF6600">&nbsp;wewrwr</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</body>
</html>
