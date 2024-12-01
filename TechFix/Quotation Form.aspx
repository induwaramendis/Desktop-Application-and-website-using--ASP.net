<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Quotation Form.aspx.cs" Inherits="TechFix.Quotation_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <title>Add Quotation</title>
    <style>
        /*Add Quotation*/
/* General Styles */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

body {
    font-family: Arial, sans-serif;
    background-color: #f4f4f4;
    color: #333;}

/* Container */
.container {
    width: 90%;
    max-width: 600px;
    margin: 50px auto;
    background-color: white;
    padding: 30px;
    border-radius: 10px;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);}

h1 {
    text-align: center;
    margin-bottom: 30px;
    color: #ff0000;}

/* Input fields */
.input-text {
    width: 100%;
    padding: 10px;
    margin-bottom: 20px;
    border: 1px solid #ccc;
    border-radius: 5px;
    font-size: 16px;}

/* Submit Button */
.btn-submit {
    width: 100%;
    padding: 12px;
    background-color: #ff0000;
    color: white;
    font-size: 16px;
    font-weight: bold;
    border: none;
    border-radius: 5px;
    cursor: pointer;
    transition: background-color 0.3s ease;}

.btn-submit:hover {
        background-color: #f5b041;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Add Quotation</h1>
           
            
            <!-- Customer Name -->
            <label for="txtcustomername">Customer Name:</label>
            <asp:TextBox ID="txtcustomername" runat="server" CssClass="input-text"></asp:TextBox><br /><br />

            <!-- Item -->
            <label for="txtitem">Item:</label>
            <asp:TextBox ID="txtitem" runat="server" CssClass="input-text"></asp:TextBox><br /><br />


            <!-- Quotation Date -->
            <label for="txtQuotationDate">Quotation Date:</label>
            <asp:TextBox ID="txtQuotationDate" runat="server" CssClass="input-text"></asp:TextBox><br /><br />

            <!-- Specifications -->
            <label for="txtspec">Specifications:</label>
            <asp:TextBox ID="txtspec" runat="server" CssClass="input-text"></asp:TextBox><br /><br />

            <!-- Status--> 
            <label for="txtNumber">Contact Number:</label>
            <asp:TextBox ID="txtNumber" runat="server" CssClass="input-text"></asp:TextBox><br /><br />

            <!-- Add Quotation Button -->
            <asp:Button ID="btnAddQuotation" runat="server" Text="Add Quotation" OnClick="btnAddQuotation_Click" CssClass="btn-submit" />
        </div>
    </form>
</body>
</html>
