using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern
{
    public class EncryptedCloudStream : CloudStream
    {
        public override void write(string data)
        {
            var encrypted = encrypt(data);
            base.write(encrypted);
        }


        private string encrypt(string data)
        {
            return "@#$%WCGTD$%^&$#@";
        }
    }
}
