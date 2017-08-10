//作者：周雄.net 4.0及以上版本
using System;
using System.Collections.Generic;
using System.Text;

namespace zhouxiong
{
   public class MSreplication_options
    {
        private string optname;
        private bool value;
        private int major_version;
        private int minor_version;
        private int revision;
        private int install_failures;


        public string Optname
        {
            get { return optname; }
            set { optname = value; }
        }
        public bool Value
        {
            get { return value; }
            set { value = value; }
        }
        public int Major_version
        {
            get { return major_version; }
            set { major_version = value; }
        }
        public int Minor_version
        {
            get { return minor_version; }
            set { minor_version = value; }
        }
        public int Revision
        {
            get { return revision; }
            set { revision = value; }
        }
        public int Install_failures
        {
            get { return install_failures; }
            set { install_failures = value; }
        }
    }
}

