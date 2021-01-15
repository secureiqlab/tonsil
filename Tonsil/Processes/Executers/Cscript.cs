﻿using System;
using System.Collections.Generic;
using System.Text;

using Tonsil.Files;

namespace Tonsil.Processes.Executers
{
    public class Cscript : Executer
    {
        public override string ImagePath { get; } = @"c:\windows\system32\cscript.exe";
        public override List<FilePathType> ValidSourcePathTypes { get; } = new List<FilePathType>() { FilePathType.SMB, FilePathType.Local, FilePathType.ADS };
        public override List<FileType> ValidSourceFileTypes { get; } = new List<FileType>() { FileType.VBScript, FileType.JavaScript };
    }
}
