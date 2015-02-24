<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Wizard.aspx.cs" Inherits="WebApp2.TestControls.Wizard" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="3" 
            onnextbuttonclick="Wizard1_NextButtonClick">
            <WizardSteps>
                <asp:WizardStep ID="WizardStep1" runat="server" Title="Exterior">
                <div>
                    <asp:RadioButton ID="RadioButton1" runat="server" Text="1" />
                    </div>
                    <div>
                    <asp:RadioButton ID="RadioButton2" runat="server" Text="2" />
                    </div>
                    
                    <div>
                        <asp:RadioButton ID="RadioButton3" runat="server" Text="3" />
                    </div>
                </asp:WizardStep>
                <asp:WizardStep ID="WizardStep2" runat="server" Title="Interior">
                    <div>
                        <asp:RadioButton ID="RadioButton4" runat="server" Text="4" />
                    </div>
                    <div>
                        <asp:RadioButton ID="RadioButton5" runat="server" Text="5" />
                    </div>
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="Options">
                <div>
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="6" />
                </div>
                <div>
                    <asp:CheckBox ID="CheckBox2" runat="server" Text="7" />
                </div>
                <div>
                    <asp:CheckBox ID="CheckBox3" runat="server" Text="8" />
                </div>
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="Summary">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
    </div>
    </form>
</body>
</html>
