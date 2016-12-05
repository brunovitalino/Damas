<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DAMAS!!!</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 100%;
        }
        .auto-style2 {
            width: 85px;
            height: 85px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2>Jogo de Damas</h2>
    
    </div>
    <div style="text-align: center;">
        -----------------</div>
    <div style="display: inline; float: left; width: 303px; height: 107px;">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Height="30px" OnClick="Button1_Click" Text="Jogar" Width="82px" />
    </div>
    <div style="display: inline; float: left; background-image: url('Imagens/damas.png'); height: 705px; width: 702px;">
        <table class="auto-style1" style="text-align: center">
            <tr>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton11" runat="server" ImageUrl="~/Imagens/preto.png" OnClick="ImageButton11_Click" Enabled="False" />
                </td>
                <td class="auto-style2"></td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton13" runat="server" ImageUrl="~/Imagens/preto.png" OnClick="ImageButton13_Click" Enabled="False" />
                </td>
                <td class="auto-style2"></td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton15" runat="server" ImageUrl="~/Imagens/preto.png" OnClick="ImageButton15_Click" Enabled="False" />
                </td>
                <td class="auto-style2"></td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton17" runat="server" ImageUrl="~/Imagens/preto.png" OnClick="ImageButton17_Click" Enabled="False" />
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton22" runat="server" ImageUrl="~/Imagens/preto.png" OnClick="ImageButton22_Click" Enabled="False" />
                </td>
                <td class="auto-style2"></td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton24" runat="server" ImageUrl="~/Imagens/preto.png" OnClick="ImageButton24_Click" Enabled="False" />
                </td>
                <td class="auto-style2"></td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton26" runat="server" ImageUrl="~/Imagens/preto.png" OnClick="ImageButton26_Click" Enabled="False" />
                </td>
                <td class="auto-style2"></td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton28" runat="server" ImageUrl="~/Imagens/preto.png" OnClick="ImageButton28_Click" Enabled="False" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton31" runat="server" ImageUrl="~/Imagens/preto.png" OnClick="ImageButton31_Click" Enabled="False" />
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton33" runat="server" ImageUrl="~/Imagens/preto.png" OnClick="ImageButton33_Click" Enabled="False" />
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton35" runat="server" ImageUrl="~/Imagens/vazio.png" OnClick="ImageButton35_Click" Enabled="False" />
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton37" runat="server" ImageUrl="~/Imagens/preto.png" OnClick="ImageButton37_Click" Enabled="False" />
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton42" runat="server" ImageUrl="~/Imagens/vazio.png" OnClick="ImageButton42_Click" Enabled="False" />
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton44" runat="server" ImageUrl="~/Imagens/vermelho.png" OnClick="ImageButton44_Click" Enabled="False" />
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton46" runat="server" ImageUrl="~/Imagens/vazio.png" OnClick="ImageButton46_Click" Enabled="False" />
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton48" runat="server" ImageUrl="~/Imagens/vermelho.png" OnClick="ImageButton48_Click" Enabled="False" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton51" runat="server" ImageUrl="~/Imagens/vazio.png" OnClick="ImageButton51_Click" Enabled="False" />
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton53" runat="server" ImageUrl="~/Imagens/preto.png" OnClick="ImageButton53_Click" Enabled="False" />
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton55" runat="server" ImageUrl="~/Imagens/vazio.png" OnClick="ImageButton55_Click" Enabled="False" />
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton57" runat="server" ImageUrl="~/Imagens/preto.png" OnClick="ImageButton57_Click" Enabled="False" />
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton62" runat="server" ImageUrl="~/Imagens/vermelho.png" OnClick="ImageButton62_Click" Enabled="False" />
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton64" runat="server" ImageUrl="~/Imagens/vermelho.png" OnClick="ImageButton64_Click" Enabled="False" />
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton66" runat="server" ImageUrl="~/Imagens/vermelho.png" OnClick="ImageButton66_Click" Enabled="False" />
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton68" runat="server" ImageUrl="~/Imagens/vermelho.png" OnClick="ImageButton68_Click" Enabled="False" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton71" runat="server" ImageUrl="~/Imagens/vazio.png" OnClick="ImageButton71_Click" Enabled="False" />
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton73" runat="server" ImageUrl="~/Imagens/preto.png" OnClick="ImageButton73_Click" Enabled="False" />
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton75" runat="server" ImageUrl="~/Imagens/vazio.png" OnClick="ImageButton75_Click" Enabled="False" />
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton77" runat="server" ImageUrl="~/Imagens/vermelho.png" OnClick="ImageButton77_Click" Enabled="False" />
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton82" runat="server" ImageUrl="~/Imagens/vermelho.png" OnClick="ImageButton82_Click" Enabled="False" />
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton84" runat="server" ImageUrl="~/Imagens/vazio.png" OnClick="ImageButton84_Click" Enabled="False" />
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton86" runat="server" ImageUrl="~/Imagens/vermelho.png" OnClick="ImageButton86_Click" Enabled="False" />
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    <asp:ImageButton ID="ImageButton88" runat="server" ImageUrl="~/Imagens/vazio.png" OnClick="ImageButton88_Click" Enabled="False" />
                </td>
            </tr>
        </table>
    </div>
    </form>
    </body>
</html>
