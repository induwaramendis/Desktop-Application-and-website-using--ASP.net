<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Repairs.aspx.cs" Inherits="TechFix.Repairs" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Contact Us</title>
    <link rel="stylesheet" href="styles.css">
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
        }

        .container {
            background-color: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            width: 400px;
            text-align: center;
        }

        h3 {
            font-size: 24px;
            margin-bottom: 20px;
            color:#ffffff
        }

        input[type="text"], input[type="email"], textarea {
            width: 100%;
            padding: 10px;
            margin: 10px 0;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
        }

        textarea {
            height: 100px;
        }

        button {
            background-color: #ff0000;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        button:hover {
            background-color: #45a049;
        }

        .breadcrumb {
            margin-bottom: 20px;
            font-size: 14px;
        }

        .breadcrumb a {
            color: #4CAF50;
            text-decoration: none;
        }

        .breadcrumb a:hover {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <header>
        <div class="heading">
    <h2>Repairs</h2>
    <p><a href="home.html">Home</a> <span> / Repairs</span></p>
</div><!-- Your header content -->
    </header><br />
    
    <section class="contact">
        <div class="row">
            <!--<div class="image">
                <img src="images/3.png" alt="">
            </div>-->
       <center> <form id="contactForm" runat="server" onsubmit="ContactSubmit">
                <h3>Enter Details</h3><br />
                <asp:TextBox ID="billnum" runat="server" MaxLength="50" CssClass="box" placeholder="Enter your bill number" required="required" />
                <asp:TextBox ID="txtname" runat="server" MaxLength="50" CssClass="box" placeholder="Enter your name" required="required" />
                <asp:TextBox ID="txtnumber" runat="server" MaxLength="10" CssClass="box" placeholder="Enter your number" required="required" />
                <asp:TextBox ID="txtemail" runat="server" MaxLength="50" CssClass="box" placeholder="Enter your email" required="required" />
                <asp:TextBox ID="txtReq" runat="server" TextMode="MultiLine" Rows="10" Columns="30" MaxLength="500" CssClass="box" placeholder="Enter your request" required="required" />
                <asp:Button ID="sendButton" runat="server" Text="Send Message" CssClass="btn" OnClick="sendButton_Click" BackColor="Red" BorderColor="White" Font-Size="Large" ForeColor="White" Height="50px" Width="300px" />
        
            </form></center>
        </div>
    </section>
</body>

</html>
