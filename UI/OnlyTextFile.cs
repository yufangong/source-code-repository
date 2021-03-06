﻿///////////////////////////////////////////////////////////////////////////
////  OnlyTextFile.cs - make sure a file is a text file pattern        ////
////  Language:    C#                                                  ////
////  Writer:      Yufan Gong                                          ////
////  Class:       CSE 681 SMA                                         ////
////  Project:     project4                                            ////
///////////////////////////////////////////////////////////////////////////
/*
 * Package: Client
 * ==============================
 * 
 * Class:OnlyTextFile
 * ===============
 * 
 * This class aim to judge is this file a text file.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentVault
{
    class OnlyTextFile
    {
        public bool textFile(string ext)
        {
            switch (ext)
            {
                case ".cs": return true;
                case ".csproj": return true;
                case ".config": return true;
                case ".txt": return true;
                case ".bat": return true;
                default: return false;
            }
        }
    }
}
