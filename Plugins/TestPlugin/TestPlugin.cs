﻿/***

   Copyright (C) 2018. dc-koromo. All Rights Reserved.

   Author: Koromo Copy Developer

***/

using Hik.Sps;
using Koromo_Copy.Plugin;

namespace TestPlugin
{
    [PlugIn("Test", "0.1.0")]
    public class TestPlugin : NonePlugin
    {
        public override void Send(string user_input)
        {
            Application.ApplicationProxy.Send(this, $"Nothing happend! {Version} {user_input}", false);
        }
    }
}
