using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
   public class SiteDetailsXMLParent
    {
        private SiteDetailsXMLChild[] sites;

        public SiteDetailsXMLChild[] Sites
        {
            get { return sites; }
            set { sites = value; }
        }
    }
}
