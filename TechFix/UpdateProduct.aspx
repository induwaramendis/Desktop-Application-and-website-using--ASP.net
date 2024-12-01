<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProduct.aspx.cs" Inherits="TechFix.UpdateProduct" %>


<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="UTF-8" />
    <title>Update Product</title>
    <link rel="stylesheet" href="../css/admin_styles.css" />
    <style type="text/css">
        .btn {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
        <div>
            <h1 class="heading">Update Product</h1>
            <asp:HiddenField ID="hdnOldImage" runat="server" />
            <asp:TextBox ID="txtName" runat="server" placeholder="Enter product name" MaxLength="100" CssClass="box" />
            <asp:TextBox ID="txtPrice" runat="server" placeholder="Enter product price" TextMode="Number" CssClass="box" />
            <asp:DropDownList ID="ddlCategory" runat="server" CssClass="box">
                <asp:ListItem Text="Laptop" Value="Laptops" />
                <asp:ListItem Text="Console & Handheld Gaming" Value="Console & Handheld Gaming" />
                <asp:ListItem Text="Graphics Tablet / Tab" Value="Graphics Tablet / Tab" />
                <asp:ListItem Text="Chinese" Value="chinese" />
                <asp:ListItem Text="Beverages" Value="beverages" />
                <asp:ListItem Text="Desserts" Value="desserts" />
            </asp:DropDownList>
            <asp:FileUpload ID="fileUploadImage" runat="server" CssClass="box" />
            <asp:Image ID="imgProduct" runat="server" />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" CssClass="btn" />
            <asp:Label ID="lblMessage" runat="server" Text="" CssClass="message" />
        </div>
    </form>
</body>
</html>

