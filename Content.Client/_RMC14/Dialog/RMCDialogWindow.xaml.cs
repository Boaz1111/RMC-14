﻿using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client._RMC14.Dialog;

[GenerateTypedNameReferences]
public sealed partial class RMCDialogWindow : DefaultWindow
{
    public RMCDialogWindow()
    {
        RobustXamlLoader.Load(this);
    }
}
