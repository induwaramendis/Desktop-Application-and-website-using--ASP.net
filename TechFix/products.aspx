<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="TechFix.products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>
        body { 
        font-family: Arial, sans-serif; 
         background-image:url(images/adminbackground.jpg);
 background-repeat:no-repeat;  
        margin: 0;
        padding: 0; 
        display: flex; 
        justify-content: center;
        align-items: center; 
        height: 100vh; 
        
        } form
        { 
        background-color: white;
        padding: 20px; 
        border-radius: 8px; 
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        } 
        label 
        { 
        display: block; 
        margin-bottom: 8px; 
        font-weight: bold;
        }
        input[type="text"], input[type="file"] { 
        width: 90%; 
        padding: 8px; 
        margin-bottom: 20px; 
        border: 1px solid #ccc; 
        border-radius: 4px; 
        } 
        input[type="text"]:focus, input[type="file"]:focus { 
        border-color: #007bff;
        outline: none; 
        }
        .button-container { 
        text-align: center; 
        } 
        input[type="submit"] {
        background-color: #ff0000;
        color: white; 
        padding: 10px 20px;
        border: none; 
        border-radius: 4px; 
        cursor: pointer; 
        font-size: 16px;
        } 
        input[type="submit"]:hover { 
           
        background-color: #0056b3;
        }
        </style>

</head>
<body>
    
    <form id="form1" runat="server" enctype="multipart/form-data">
        <label for="name">Product Name:</label>
        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        <br />
        <label for="price">Product Price:</label>
        <asp:TextBox ID="txtprice" runat="server"></asp:TextBox>
        <br />
        <label for="category">Product Category:</label>
        <asp:TextBox ID="Category" runat="server"></asp:TextBox>
        <br />
        <label for="image">Product Image:</label>
        <asp:FileUpload ID="Image" runat="server" />
        <br />
        <asp:Button ID="addProductButton" runat="server" Text="Add Product" OnClick="AddProductButton_Click" /><br /><br />
       
        <asp:Button ID="backbtn" runat="server" Text="Back" OnClick="backbtn_Click1" />
    </form>
</body>
</html>
