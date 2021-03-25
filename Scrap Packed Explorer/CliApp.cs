﻿using ch.romibi.Scrap.Packed.PackerLib;
using CommandLine;
using System;
using System.Collections.Generic;
using System.Text;

namespace ch.romibi.Scrap.Packed.Explorer
{
    class CliApp
    {
        public int Run(string[] args)
        {
            return Parser.Default.ParseArguments<AddOptions, RemoveOptions>(args)
                .MapResult(
                    (AddOptions options) => RunAdd(options),
                    (RemoveOptions options) => RunRemove(options),
                    errors => 1);
        }


        private int RunAdd(AddOptions options)
        {
            Console.WriteLine("test add");
            var packer = new ScrapPacker();
            packer.OpenPack("test");
            return 0;
        }

        private int RunRemove(RemoveOptions options)
        {
            Console.WriteLine("test remove");
            return 0;
        }

    }
}
