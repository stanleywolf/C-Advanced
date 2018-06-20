﻿using System;
using System.Collections.Generic;
using System.Text;

public class MakeDirectoryCommand:Command
    {
        public MakeDirectoryCommand(string input, string[] data, IContentComparer judge, IDatabase repository, IDirectoryManager inputOutputManager) : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }
            string folderName = this.Data[1];
        this.InputOutputManager.CreateDirectoryInCurrentFolder(folderName);
        }
    }
  