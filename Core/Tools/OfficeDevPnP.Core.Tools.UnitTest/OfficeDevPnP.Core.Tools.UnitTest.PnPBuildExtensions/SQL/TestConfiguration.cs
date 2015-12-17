//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OfficeDevPnP.Core.Tools.UnitTest.PnPBuildExtensions.SQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TestConfiguration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TestConfiguration()
        {
            this.TestRuns = new HashSet<TestRun>();
            this.TestConfigurationProperties = new HashSet<TestConfigurationProperty>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string VSBuildConfiguration { get; set; }
        public string Branch { get; set; }
        public TestConfigurationType Type { get; set; }
        public string Build { get; set; }
        public string TenantUrl { get; set; }
        public string TestSiteUrl { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestRun> TestRuns { get; set; }
        public virtual TestAuthentication TestAuthentication { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestConfigurationProperty> TestConfigurationProperties { get; set; }
    }
}
