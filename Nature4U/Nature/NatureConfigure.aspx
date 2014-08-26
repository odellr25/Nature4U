<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NatureConfigure.aspx.cs" Inherits="Nature4U.Nature.NatureConfigure" MasterPageFile="~/Nature4UMaster.Master"%>

<asp:Content ID="cNatureConfigure" runat="server" ContentPlaceHolderID="cphMainContent">
    <div id="dNatureConfiguration" class="marginLR5">
        <br />
        <asp:Label ID="lblTittle" runat="server" Text="<%$ Resources:NatureConf, lblTittle %> " CssClass="NatureTittle"></asp:Label>
        <br />
    </div> 
    <div id="dNCBodyParts" class="marginLR5">
        <br />
        <div class="NatureBoxConf">
            <br />
            &nbsp<asp:Label ID="lblBodyParts" Text="<% $ Resources:NatureConf, lblBodyParts%>" runat="server" CssClass="NatureSubTittle" />
            <hr style="color:#0024ff"/>
            &nbsp;<table style="width:100%;">
                <tr>
                    <td>
                        &nbsp;
                        <asp:Label ID="lblName" runat="server" Text="<% $ Resources:NatureConf, lblName%>"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" CssClass="TextBoxCSSStyle" Width="100%"></asp:TextBox>
                    </td>
                    <td style="width:10px;">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp; 
                        <asp:Label ID="lblDescription" runat="server" Text="<% $ Resources:NatureConf, lblDescription%>"></asp:Label>
                    </td>
                    <td rowspan="2">
                        <asp:TextBox ID="txtDescription" runat="server" CssClass="TextBoxCSSStyle" TextMode="MultiLine" Width="100%" Height="70px"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;
                        <asp:Label ID="lblParentPart" runat="server" Text="<% $ Resources:NatureConf,lblParentPart%>"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlParentParts" runat="server" CssClass="DropDownCSSStyle">
                        </asp:DropDownList>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3" align="center">
                        <asp:Button ID="btnInsert" runat="server" Text="<% $ Resources:NatureConf,btnInsert%>" CssClass="ButtonCSSStyle" OnClick="btnInsert_Click" />
                        <asp:Button ID="bntClean" runat="server" Text="<% $ Resources:NatureConf,bntClean%>" CssClass="ButtonCSSStyle" OnClick="bntClean_Click" />
                    </td>
                </tr>
            </table>
            <asp:Label ID="lblMessages" runat="server" Text=""></asp:Label>
            <br />
           
          </div>
        <br />
        <br />
    </div>
</asp:Content>