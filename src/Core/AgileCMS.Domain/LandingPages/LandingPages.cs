using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileCMS.Domain.LandingPages
{  
    
     /// <summary>
     /// Represents a page
     /// </summary>
    public class LandingPages : BaseEntity
    { 
        
        /// <summary>
        /// Title of page
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the entity is published
        /// </summary>
        public bool Published { get; set; }
      

        /// <summary>
        /// Body content of page
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the sename - Search Engine 
        /// </summary>
        public string SeName { get; set; }


        /// <summary>
        /// Gets or sets the meta description
        /// </summary>
        public string MetaDescription { get; set; }

        /// <summary>
        /// Gets or sets the meta title
        /// </summary>
        public string MetaTitle { get; set; }

      
       
        /// <summary>
        /// Gets or sets a start date of page
        /// </summary>
        public DateTime? PublishStartDateUtc { get; set; }
        /// <summary>
        /// Gets or sets a end date of page
        /// </summary>
        public DateTime? PublishEndDateUtc { get; set; }
    }
}
