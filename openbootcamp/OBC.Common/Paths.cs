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

using System;
using System.IO;

namespace OBC.Common;

public static class Paths
{
    /// <summary>
    /// <c>C:\ProgramData\Sparronator9999\OpenBootCamp\obc.xml</c> on Windows.
    /// </summary>
    public static readonly string Config = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
        "Sparronator9999", "OpenBootCamp", "obc.xml");
}
