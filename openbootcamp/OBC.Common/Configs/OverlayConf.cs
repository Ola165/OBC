// This file is part of OpenBootCamp.
// Copyright © Sparronator9999 2024-2026.
//
// OpenBootCamp is free software: you can redistribute it and/or modify it
// under the terms of the GNU General Public License as published by the Free
// Software Foundation, either version 3 of the License, or (at your option)
// any later version.
//
// OpenBootCamp is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for
// more details.
//
// You should have received a copy of the GNU General Public License along with
// OpenBootCamp. If not, see <https://www.gnu.org/licenses/>.

using MessagePack;
using System.Xml.Serialization;

namespace OBC.Common.Configs;

/// <summary>
/// Represents a configuration for OBC's Battery Manager module.
/// </summary>
[MessagePackObject]
public sealed class OverlayConf
{
    /// <summary>
    /// Gets or sets whether the background behind
    /// overlays should have a blur effect applied.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Only supported on Windows 10 and later
    /// (the background will be opaque on older Windows versions).
    /// </para>
    /// <para>
    /// Defaults to <see cref="BlurMode.Automatic"/>, which
    /// will show a blurred background if the Windows 10 setting
    /// "Transparency effects" is enabled, and an opaque background
    /// if the same setting is disabled.
    /// </para>
    /// </remarks>
    [XmlElement]
    [Key(0)]
    public BlurMode BlurMode { get; set; } = BlurMode.Automatic;
}

public enum BlurMode
{
    /// <summary>
    /// Match the system "Transparency effects" setting.
    /// </summary>
    Automatic = 0,
    /// <summary>
    /// Always blur the overlay background.
    /// </summary>
    Enabled = 1,
    /// <summary>
    /// Never blur the overlay background.
    /// </summary>
    Disabled = 2,
}
