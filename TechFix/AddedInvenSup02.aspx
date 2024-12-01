<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddedInvenSup02.aspx.cs" Inherits="TechFix.AddedInvenSup02" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <style>
        body {
    font-family: Arial, sans-serif;
     background-image:url(images/adminbackground.jpg);
    background-repeat:no-repeat;
    padding: 20px;
}

.container {
    background-color: #fff;
    padding: 20px;
    margin: 0 auto;
    max-width: 800px;
    border-radius: 5px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
}

h2 {
    text-align: center;
    margin-bottom: 20px;
}

table {
    width: 100%;
    border-collapse: collapse;
    margin-top: 20px;
}

thead {
    background-color: #ff0000;
    color: white;
}

th, td {
    border: 1px solid #ccc;
    padding: 10px;
    text-align: left;
}

th {
    font-weight: bold;
}

tr:nth-child(even) {
    background-color: #f2f2f2;
}




            .auto-style1 {
                height: 46px;
            }




    </style>
</head>
<body>
   <div class="container">
   <center> <h2>Inventories</h2></center>
    
    <br />
    <table>
        <thead>
            <tr>
                
                <th>ItemId</th>
                <th>SupplierID</th>
                <th>ItemName</th>
                <th>Quantity</th>
                <th>UnitePrice</th>
                
                
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="AddedInvenRepeater" runat="server">
                <ItemTemplate>
                    <tr>
                     
                        <td><%# Eval("ItemId") %></td>
                        <td><%# Eval("SupplierID") %></td>
                        <td><%# Eval("ItemName") %></td>
                        <td><%# Eval("Quantity") %></td>
                        <td><%# Eval("UnitPrice") %></td>
                       
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</div>
</body>
</html>

