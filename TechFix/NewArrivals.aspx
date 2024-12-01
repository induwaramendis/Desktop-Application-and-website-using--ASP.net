<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewArrivals.aspx.cs" Inherits="TechFix.NewArrivals" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">


    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>TechFix - New Arrivals</title>
    <link rel="stylesheet" href="css.css">


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
            height: 44px;
  }
 .card {
    background-color: #fff;
    border-radius: 8px;
    padding: 20px;
    box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
    text-align: center;
}

.card h2 {
    font-size: 1.5rem;
    margin-bottom: 10px;
}

.card p {
    font-size: 1rem;
    color: #fff;
    margin-bottom: 15px;
}

.card button {
    background-color: #ff0000;
    color: white;
    border: none;
    padding: 10px 20px;
    border-radius: 5px;
    cursor: pointer;
}
.card button a{
    color:#f2f2f2;
}

.card button:hover {
    background-color: #0056b3;
}




    </style>

</head>
<body>
    <div class="container">
       <center> <h2>New Arrivals</h2></center>
        
        <br />
        <table>
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Category</th>
                    <th>Price</th>
                    <th>Image</th>
                    
                    
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="ProductsRequestRepeater" runat="server">
                    <ItemTemplate>
                        <tr>

                            <td><%# Eval("ID") %></td>
                            <td><%# Eval("Name") %></td>
                            <td><%# Eval("Category") %></td>
                            <td><%# Eval("Price") %></td>
                            <td>
    <img src='<%# ResolveUrl("~/uploaded_img/" + Eval("Image")) %>' alt='Product Image' width='100'/>
</td>

                           
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
    <br />
                 <div class="card">
    
    <h2>Place Order</h2>
    <button><a href="Orders.aspx" >Go</a></button>
</div>
</body>
</html>