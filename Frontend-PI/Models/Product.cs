using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Frontend_PI.Models
{
    public class Product
    {
        public int id { get; set; }
        public String title { get; set; }
        public DateTime publicationDate { get; set; }
        public Category category { get; set; }
        public float price { get; set; }
        public String description { get; set; }
        public String image { get; set; }

        [Display(Name = "description")]
        public string descriptionTrimmed
        {
            get
            {
                if (this.description != null) { 
                    if (this.description.Length > 120)
                    return this.description.Substring(0, 120) + "...";
                }

                    return this.description;
                
            }
        }

    }
}