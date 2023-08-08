using AgileCMS.Common.Attributes;
using AgileCMS.Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileCMS.Domain
{
    /// <summary>
    /// Base class for entities
    /// </summary>
    public abstract partial class BaseEntity
    {
        protected BaseEntity()
        {
            _id = UniqueIdentifier.New;
        }

        /// <summary>
        /// we need to set ID for each entity 
        /// </summary>
        [DBFieldName("_id")]
        public string Id
        {
            get { return _id; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    _id = UniqueIdentifier.New;
                else
                    _id = value;
            }
        }

        private string _id;
    }
}
