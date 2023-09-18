using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eLearningProject.DAL.Entities
{
    public class Feature
    {
        public int FeatureID { get; set; }
        public string FeatureTitle { get; set; }
        public string FeatureIcon { get; set; }
        public string FeatureDescription { get; set; }
    }
}