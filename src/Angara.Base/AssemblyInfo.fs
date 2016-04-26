﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Angara.Base")>]
[<assembly: AssemblyProductAttribute("Angara")>]
[<assembly: AssemblyDescriptionAttribute("The modelling environment")>]
[<assembly: AssemblyVersionAttribute("0.2.2")>]
[<assembly: AssemblyFileVersionAttribute("0.2.2")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.2.2"
    let [<Literal>] InformationalVersion = "0.2.2"
