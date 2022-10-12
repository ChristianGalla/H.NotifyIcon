﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using H.NotifyIcon.Core;

namespace H.NotifyIcon.Core;

/// <inheritdoc/>
public class PopupSubMenu : PopupItem
{
    /// <inheritdoc/>
    public PopupSubMenu()
    { }

    /// <inheritdoc/>
    public PopupSubMenu(string text)
    {
        Text = text;
    }

    /// <inheritdoc/>
    public string Text { get; set; } = string.Empty;

    /// <inheritdoc/>
    public ICollection<PopupItem> Items { get; } = new List<PopupItem>();

}
