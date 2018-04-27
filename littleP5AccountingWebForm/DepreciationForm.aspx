<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DepreciationForm.aspx.cs" Inherits="littleP5AccountingWebForm.DepreciationForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <asp:Label ID="lblStartV" runat="server" Text="Starting Value: "></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtStartingV" runat="server" TextMode="Number"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblSalvageV" runat="server" Text="Salvage Value: "></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtSalvageV" runat="server" TextMode="Number"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblLifetime" runat="server" Text="Estimated Lifetime of Asset: "></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtLifetime" runat="server" TextMode="Number"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblAge" runat="server" Text="Age of Asset in Years: "></asp:Label>

    </p>
    <p>
        <asp:TextBox ID="txtAge" runat="server" TextMode="Number"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblType" runat="server" Text="Type of Deprecation: "></asp:Label>
    </p>
    <p>
        <asp:RadioButton ID="rbStraight" runat="server" GroupName="dType" />
        <asp:Label ID="lblStraight" runat="server" Text="Straight Line"></asp:Label>
    </p>
    <p>
        <asp:RadioButton ID="rbDouble" runat="server" GroupName="dType"/>
        <asp:Label ID="lblDouble" runat="server" Text="Double declining"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
    </p>
    <p>
        <asp:TextBox ID="txtResult" Width="500" Height="200" TextMode="MultiLine" runat="server" ReadOnly="True"></asp:TextBox>
    </p>





</asp:Content>
