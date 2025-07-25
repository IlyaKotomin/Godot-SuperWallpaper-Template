using System;
using SuperWallpaper.Scripts.Events.Contracts;
using SuperWallpaper.Scripts.Events.Contracts.Attributes;
using SuperWallpaper.Scripts.Events.Contracts.Interfaces;

namespace SuperWallpaper.Scripts.Events.EventTypes;

[HyprlandEvent("closelayer")]
public class CloseLayerEvent(string @namespace) : EventArgs, ISystemEvent
{
    public string Namespace { get; } = @namespace;
}