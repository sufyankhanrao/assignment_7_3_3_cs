/*
 * CountriesAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using CountriesAPI.Standard;
using CountriesAPI.Standard.Utilities;


namespace CountriesAPI.Standard.Models
{
    public class CountryInfo : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string code;
        private string mvalue;

        /// <summary>
        /// This indicates the code of country
        /// </summary>
        [JsonProperty("code")]
        public string Code 
        { 
            get 
            {
                return this.code; 
            } 
            set 
            {
                this.code = value;
                onPropertyChanged("Code");
            }
        }

        /// <summary>
        /// This indicates the name of country
        /// </summary>
        [JsonProperty("value")]
        public string Value 
        { 
            get 
            {
                return this.mvalue; 
            } 
            set 
            {
                this.mvalue = value;
                onPropertyChanged("Value");
            }
        }
    }
} 