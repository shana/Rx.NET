﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System;

#if SIGNED

#if SIGNENHANCED // Key 272 for .NET 4.5 and beyond
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("System.Reactive.Debugger, PublicKey=00240000048000009400000006020000002400005253413100040000010001007ddf06d75282534628bc06c6efc04558173409710f3632305d60c3321975ec4aa5ed1ce319aaf67109c3009d6587af34d7fd00233af81eb0054fe09b8e8b8de01b57ad60ab2863277d50c7e71f78b9c60a236caf06d21dd8d358ad376b914cb5af27bd0628b044a820e7b1d97ca6683f5d674ee83e85e4d4003c3028fe5f6ac4")]
#else            // Key 35 for older platforms
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("System.Reactive.Debugger, PublicKey=00240000048000009400000006020000002400005253413100040000010001007ddf06d75282534628bc06c6efc04558173409710f3632305d60c3321975ec4aa5ed1ce319aaf67109c3009d6587af34d7fd00233af81eb0054fe09b8e8b8de01b57ad60ab2863277d50c7e71f78b9c60a236caf06d21dd8d358ad376b914cb5af27bd0628b044a820e7b1d97ca6683f5d674ee83e85e4d4003c3028fe5f6ac4")]
#endif

#else

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("System.Reactive.Debugger")]

#endif