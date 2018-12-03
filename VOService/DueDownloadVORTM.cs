using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VOService
{
    public class DueDownloadVORTM
    {
        private String cmdName;

        public String CmdName
        {
            get { return cmdName; }
            set { cmdName = value; }
        }
        private String userName;

        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private String password;

        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        private byte[] acccountName;

        public byte[] AcccountName
        {
            get { return acccountName; }
            set { acccountName = value; }
        }
        private String version;

        public String Version
        {
            get { return version; }
            set { version = value; }
        }
        private EntityVORTM[] entities;

        public EntityVORTM[] Entities
        {
            get { return entities; }
            set { entities = value; }
        }

        private SiteVO[] sites;

        public SiteVO[] Sites
        {
            get { return sites; }
            set { sites = value; }
        }

        private UserSiteMappingVO[] userSiteMapping;

        public UserSiteMappingVO[] UserSiteMapping
        {
            get { return userSiteMapping; }
            set { userSiteMapping = value; }
        }

        private CompanyCardVO[] companyCard;

        public CompanyCardVO[] CompanyCard
        {
            get { return companyCard; }
            set { companyCard = value; }
        }

        private TISWEBCompanyVO[] tISWEBCompanyCardVO;

        public TISWEBCompanyVO[] TISWEBCompanyCardVO
        {
            get { return tISWEBCompanyCardVO; }
            set { tISWEBCompanyCardVO = value; }
        }

        private TISWEBFrequencyFileExt[] tISWEBFrequencyFileExt;

        public TISWEBFrequencyFileExt[] TISWEBFrequencyFileExt
        {
            get { return tISWEBFrequencyFileExt; }
            set { tISWEBFrequencyFileExt = value; }
        }


        private VU vU; // RTM-TIS-Office Change.

        public VU VU
        {
            get { return vU; }
            set { vU = value; }
        }
        private SV sV;

        public SV SV
        {
            get { return sV; }
            set { sV = value; }
        }
    }
}
