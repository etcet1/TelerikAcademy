﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    public class WordDocument : OfficeDocument, IEditable
    {
        public long? Characters { get; protected set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "chars")
            {
                this.Characters = long.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("chars", this.Characters));
            base.SaveAllProperties(output);
        }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }
    }
}

