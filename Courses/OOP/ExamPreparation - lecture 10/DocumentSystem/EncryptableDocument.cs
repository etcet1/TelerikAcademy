using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    public abstract class EncryptableDocument : BinaryDocument, IEncryptable
    {
        public bool IsEncrypted { get; private set; }

        public void Decrypt()
        {
            this.IsEncrypted = false;
        }

        public void Encrypt()
        {
            this.IsEncrypted = true;
        }

        public override string ToString()
        {
            if (this.IsEncrypted)
            {
                var result = new StringBuilder();
                result.Append(this.GetType().Name);
                result.Append("[encrypted]");

                return result.ToString();
            }
            else
            {
                return base.ToString();
            }


        }
    }
}
