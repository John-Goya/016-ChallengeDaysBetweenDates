<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default_DaysBetweenDates.aspx.cs" Inherits="ChallengeDaysBetweenDates.Default_DaysBetweenDates" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            How many days have elapsed?<br />
            <br />
            Choose one date:
            <asp:Label ID="selectedFirstDateLabel" runat="server"></asp:Label>
            <asp:Calendar ID="firstCalendar" runat="server" OnSelectionChanged="firstCalendar_SelectionChanged"></asp:Calendar>
            <br />
            <br />
            Choose a second date:
            <asp:Label ID="selectedSecondDateLabel" runat="server"></asp:Label>
            <asp:Calendar ID="secondCalendar" runat="server" OnSelectionChanged="secondCalendar_SelectionChanged"></asp:Calendar>
            <br />
            <br />
            <asp:Button ID="calculateButton" runat="server" Text="Ok" OnClick="calculateButton_Click" />
            <br />
            <br />
            Number of days between selected dates : <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
