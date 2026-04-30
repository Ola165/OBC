# OpenBootCamp

An open-source implementation of some of Boot Camp's keyboard services in C#.

> [!IMPORTANT]
> I recently replaced the Windows install on one of the laptops I wrote this for with Linux. The other laptop I wrote this program for (which is still on Windows) is not regularly used by me anymore, due to being too slow for my needs. I may try to get Linux support working with this project, but I'll probably end up forking [mbpfan](https://github.com/linux-on-mac/mbpfan) to implement the features I want from OBC on Linux instead.
> 
> In other words, OpenBootCamp will likely **not receive any more major updates,** (or if it does, they will be few and far between) and is being deprecated in favour of just installing Linux and [mbpfan](https://github.com/linux-on-mac/mbpfan) on your Apple computers instead.
> 
> Thank you to the [3 other people](https://github.com/Sparronator9999/OpenBootCamp/stargazers) (as of writing) who checked this out in the meantime. I had fun making this, but unfortunately Microsoft is making it ***very*** hard for me to justify continued use of their ~~spyware~~ operating system.

## Disclaimers

- This program was developed by using clean-room reverse-engineering
  techniques (including decompiling Boot Camp services) and publicly-available
  information on Apple hardware (particularly the SMC).
- This program, repository and its authors are **not** affiliated with Apple
  Inc. in any way, shape, or form.

## Features

OpenBootCamp currently implements the following features of Boot Camp Manager:

- **Fn behaviour switching:** Switch whether the default Fn behaviour should be
  the standard Fn keys, or the special function printed on each key.
- **Special Fn key handling:** This includes keys like the display brightness,
  keyboard brightness, and optical drive eject keys.
- **Fan control** (WIP): Fix Apple's garbage fan profiles without
  having to decide between terrible thermals or terrible battery life\*.
- **Battery charge limit**: Extend your laptop's battery lifespan by limiting
  its full charge capacity to 80% (or whatever you want). Similar to macOS's
  Optimised Battery Charging on newer devices, but doesn't arbitrarily charge
  to 100% when it thinks you'll need it.

<sub>\*When running on Windows, [Macs Fan Control](https://crystalidea.com/macs-fan-control)
appears to install its own driver that significantly impacts battery life
*even after closing Macs Fan Control*, and persists until a reboot. OBC uses
the `MacHALDriver` that comes with official Boot Camp services to control fan
speeds. Obviously, increasing your fan speeds from stock will still impact battery life.</sub>

Additionally, the following bugs from the official Boot Camp Manager are fixed:

- Keyboard backlight state is not remembered across reboots\*\*
- Special Fn keys do not work before login (Apple's Boot Camp Manager doesn't
  run until a user logs in)

<sub>along with introducing a whole lot of other bugs/missing features, but still...</sub>

<sub>\*\* This bug was present on my 2012 MacBook Pro when running Boot Camp 5
(which is what [Brigadier](https://github.com/timsutton/brigadier) found for my
Mac), and switched to keyboard events not working *at all* when upgrading to
Boot Camp 6 via Apple Software Update.</sub>

## Planned features

Roughly in priority order:

- Finish the config application. Learn to edit XML to use the fan controller for now.
- A few power saving features:
  - Set keyboard backlight state based on power source or battery charge (e.g.
    low battery, switching between AC and battery power)
- Volume control on older Windows versions (7 and earlier?)
- Smooth keyboard backlight animations
- More that I haven't thought of yet

## Supported systems

Only Apple computers that can run Windows are supported (i.e. any Intel Mac).
Any non-Apple Windows systems are not supported (even if using an external
Magic Mouse/Trackpad/Keyboard).

Windows 7 SP1 and later with .NET Framework 4.8 should mostly work without
issues.

Windows Vista/XP may work if you build the project against .NET Framework 4.6
(for Vista SP2) or 4.0 (for XP SP3), but are currently unsupported.

## Additional requirements

The following drivers are required for OpenBootCamp to work:

- The Apple Keyboard driver (`Keymagic.sys`) for OSX Fn behaviour switching
  and enabling display brightness shortcuts on Windows 8 and later.
- `KeyAgent.sys` (or `KeyManager.sys` on newer Macs) for enabling other special
  Fn keys and for brightness/volume keys on Windows 7 and lower.
- `MacHALDriver.sys` for keyboard backlight and fan control support.

See [here](#how-do-i-obtain-keyagentsys-and-machaldriversys) for how to obtain them.

## Download

Downloads are currently unavailable.

Please [compile the program yourself](#compile) in the meantime.

<!--Development builds are available through [GitHub Actions](https://github.com/Sparronator9999/OpenBootCamp/actions).

Alternatively, if you don't have a GitHub account, you can download the latest
build from [nightly.link](https://nightly.link/Sparronator9999/OpenBootCamp/workflows/build/main?preview).

(You probably want the `Release` build, unless you're debugging issues with the program)

Alternatively, you can [compile the program yourself](#compile).-->

## Compile

### Using Visual Studio

1.  Install Visual Studio 2022 with the `.NET Desktop Development` workload
    checked.
2.  Download the code repository, or clone it with `git`.
3.  Extract the downloaded code, if needed.
4.  Open `OBC.sln` in Visual Studio.
5.  Click `Build` > `Build Solution` to build everything.
6.  Your output, assuming default build settings, is located in
    `OBC.Service\bin\Debug\net48\`.
7.  ???
8.  Profit!

### From the command line

1.  Follow steps 1-3 above to install Visual Studio and download the code.
2.  Open `Developer Command Prompt for VS 2022` and `cd` to your project
    directory.
3.  Run `msbuild /t:restore` to restore the solution, including NuGet packages.
4.  Run `msbuild OBC.sln /p:platform="Any CPU" /p:configuration="Debug"` to
    build the project, substituting `Debug` with `Release` for a Release build
    instead.
5.  Your output should be located in `OBC.Service\bin\Debug\net48\` (or similar).
6.  ???
7.  Profit!

## FAQ

### Wait, you can install Windows on a Mac?

Yep, and it's [officially supported by Apple](https://support.apple.com/en-us/102622)
on any Intel Mac (with varying "official" Windows support, but I was able to get
the latest Windows 10 LTSC single-booting on a 2010 MacBook (the white unibody
model) and a 2012 MacBook Pro with few issues).

Note that Windows 11 on Mac is not officially supported by Apple, and most likely
Microsoft as well (especially on older devices that need legacy BIOS mode (CSM)
to boot properly with all drivers working, as only UEFI boot is officially
supported by Windows 11).

### How did you make this?!

I originally made this with only the keyboard functionality (changing Fn
behaviour, handling keyboard brightness/backlight/CD eject events) by decompiling
`Bootcamp.exe` (located at `C:\Program Files\Boot Camp` on a Mac running Windows
with Boot Camp installed) with [Binary Ninja](https://binary.ninja/). I was going
to use [ghidra](https://github.com/NationalSecurityAgency/ghidra), but found
Binary Ninja produced more readable pseudo-code.

The fan control and battery management featurs were implemented using
information from [SMCKit](https://github.com/beltex/SMCKit) and
[VirtualSMC](https://github.com/acidanthera/VirtualSMC) (among others, but these
two were the most significant), along with more independent RE.

### *Why* did you make this?

Because I was/am unhappy with the Apple-provided Boot Camp services.

Also, reverse-engineering is fun :D (if you know what you're doing, that is)

### How do I install this?

1. Obtain a copy of `KeyAgent.sys`/`KeyManager.sys` and `MacHALDriver.sys` for
   your laptop (see [below](#how-do-i-obtain-keyagentsys-and-machaldriversys)).
2. Create a folder in the same location as `ObcSettings.exe` called `BootCamp`
   (if it doesn't exist), and move both files there.
3. Run `ObcSettings.exe`, go to the `Debug` tab, and click `Install manager`
   on the right.
4. In the window that pops up, install both `KeyAgent.sys` and `MacHALDriver.sys`
   using thier `Install` buttons, then reboot.
4. Run `ObcSettings.exe` again, navigate to the same page, and install and
   run `OpenBootCamp service`.
5. ???
6. Profit!

NOTE: if you try to uninstall `MacHALDriver.sys` in the future, it might still
show as "Installed" until you reboot. This will be fixed in a future commit.

### How do I obtain `KeyAgent.sys` and `MacHALDriver.sys`?

1. Download the Boot Camp support software for your Mac using Boot Camp
   Assistant (or [Brigadier](https://github.com/timsutton/brigadier) if you're
   already on Windows).
2. Navigate to and open `Drivers\Apple\BootCamp.msi` in 7-Zip.
3. Copy `KeyAgent.sys` (or `KeyManager.sys` on newer devices) and `MacHALDriver.sys`
   to a folder named `BootCamp` in the same folder as `ObcSettings.exe`, then
   follow the [instructions](#how-do-i-install-this) to install them with OpenBootCamp.

While you're here, install `AppleKeyboardInstaller64.exe` (located in the same folder as
`BootCamp.msi`) to enable proper keyboard support.

### I want \<feature X\> in OpenBootCamp!

Ask nicely in the [issues](https://github.com/Sparronator9999/Sparronator9999/issues),
and I might add your feature if I know how, have time, and I think it'll
benefit the project.

Alternatively, create a [pull request](https://github.com/Sparronator9999/Sparronator9999/pulls)
and add the feature yourself.

### .NET/Core?

No.

### Linux?

Linux already has native support for Apple hardware (at least on the laptops
I tested it on), so a Linux port would be pointless.

## Special thanks

- [VirtualSMC](https://github.com/acidanthera/VirtualSMC) for their detailed
  SMC key documentation (check the `Docs` folder in the linked repo).
- [SMCKit](https://github.com/beltex/SMCKit)/[libsmc](https://github.com/beltex/libsmc)
  for the SMC function names used in
  [MacHALDriverIoCtl.cs](https://github.com/Sparronator9999/OpenBootCamp/blob/main/OBC.Service/MacHALDriverIOCTL.cs).

## License and Copyright

Copyright © 2024-2026 Sparronator9999.

This program is free software: you can redistribute it and/or modify it under
the terms of the GNU General Public License as published by the Free Software
Foundation, either version 3 of the License, or (at your option) any later
version.

This program is distributed in the hope that it will be useful, but WITHOUT ANY
WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A
PARTICULAR PURPOSE. See the [GNU General Public License](LICENSE.md) for more
details.
