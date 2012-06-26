using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Googajax
{
   
    public sealed class GImageSearcher : GSearcher<GImageResultSet>
    {
        private const string SiteSearchParameter = "as_sitesearch";

        private int ImageRightsMask = 0;

        public GImageSearcher() :
            base("images")
        {
        }

        public GSafetyLevel SafetyLevel
        {
            get { return (GSafetyLevel)GetParameter(GSafetyLevel.InternalName); }
            set { if (value != null) SetParameter(value); else ClearParameter(GSafetyLevel.InternalName); }
        }

        public GImageSize ImageSize
        {
            get { return (GImageSize)GetParameter(GImageSize.InternalName); }
            set { if (value != null) SetParameter(value); else ClearParameter(GImageSize.InternalName); }
        }

        public GImageColor ImageColor
        {
            get { return (GImageColor)GetParameter(GImageColor.InternalName); }
            set { if (value != null) SetParameter(value); else ClearParameter(GImageColor.InternalName); }
        }

        public GImageColorization Colorization
        {
            get { return (GImageColorization)GetParameter(GImageColorization.InternalName); }
            set { if (value != null) SetParameter(value); else ClearParameter(GImageColorization.InternalName); }
        }

        public GImageType ImageType
        {
            get { return (GImageType)GetParameter(GImageType.InternalName); }
            set { if (value != null) SetParameter(value); else ClearParameter(GImageType.InternalName); }
        }

        public GImageFileType FileType
        {
            get { return (GImageFileType)GetParameter(GImageFileType.InternalName); }
            set { if (value != null) SetParameter(value); else ClearParameter(GImageFileType.InternalName); }
        }

        public int ImageRights
        {
            get { return ImageRightsMask; }
            set 
            {
                ImageRightsMask = value;

                if(ImageRightsMask <= 0)
                    ClearParameter(GImageRights.InternalName);

                string rightsStr = "";
                string includeStr = "";
                string excludeStr = "";

                BuildRightsParm(GImageRights.PublicDomain, GImageRights.IncludePublicDomain, GImageRights.ExcludePublicDomain, ref includeStr, ref excludeStr);
                BuildRightsParm(GImageRights.Attribute, GImageRights.IncludeAttribute, GImageRights.ExcludeAttribute, ref includeStr, ref excludeStr);
                BuildRightsParm(GImageRights.ShareAlike, GImageRights.IncludeShareAlike, GImageRights.ExcludeShareAlike, ref includeStr, ref excludeStr);
                BuildRightsParm(GImageRights.NonCommercial, GImageRights.IncludeNonCommercial, GImageRights.ExcludeNonCommercial, ref includeStr, ref excludeStr);
                BuildRightsParm(GImageRights.NonDerived, GImageRights.IncludeNonDerived, GImageRights.ExcludeNonDerived, ref includeStr, ref excludeStr);

                if(includeStr.Length > 0)
                    rightsStr = "(" + includeStr.Remove(includeStr.Length - 1) + ")";

                if(excludeStr.Length > 0)
                {
                    if(rightsStr.Length > 0)
                        rightsStr += ".";

                    rightsStr += "-(" + excludeStr.Remove(excludeStr.Length - 1) + ")";
                }

                if(rightsStr.Length > 0)
                    SetParameter(new GSearchParameter(GImageRights.InternalName, rightsStr));
                else
                    ClearParameter(GImageRights.InternalName);
            }
        }

        private void BuildRightsParm(string parm, int includeFlag, int excludeFlag, ref string includeStr, ref string excludeStr)
        {
            if ((ImageRightsMask & includeFlag) == includeFlag &&
                    !((ImageRightsMask & excludeFlag) == excludeFlag))
                includeStr += parm + "|";
            else if ((ImageRightsMask & excludeFlag) == excludeFlag &&
                    !((ImageRightsMask & includeFlag) == includeFlag))
                excludeStr += parm + "|";
        }

        public string SiteSearch
        {
            get { GSearchParameter parm = GetParameter(SiteSearchParameter); return parm != null ? parm.Value : null; }
            set { if (value != null && value.Length > 0) SetParameter(new GSearchParameter(SiteSearchParameter, value)); else ClearParameter(SiteSearchParameter); }
        }
    }
}
