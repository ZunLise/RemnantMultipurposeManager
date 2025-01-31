﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemnantBuildRandomizer
{
    public class RemnantProfile
    {

        private string foldername;
        private List<RemnantCharacter> chars;
        public RemnantProfile(string path)
        {
            this.foldername = path.Split('\\').Last();
            chars = RemnantCharacter.GetCharactersFromSave(path);

        }

        public string Profile
        {
            get => foldername; set =>RenameFolder(value);
        }
        public string Characters { get => string.Join(",", chars); }
        public void RenameFolder(string name)
        {
            Debug.WriteLine(MainWindow.ProfilesDirPath + "\\" + Profile);
            Debug.WriteLine(MainWindow.ProfilesDirPath + "\\" + name);
            Directory.Move(MainWindow.ProfilesDirPath + "\\" + Profile, MainWindow.ProfilesDirPath + "\\" + name);
            foldername = name;
        }
    }

}
