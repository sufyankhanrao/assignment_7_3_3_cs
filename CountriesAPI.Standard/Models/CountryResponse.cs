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
    public class CountryResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int httpCode;
        private string responseCode;
        private string responseMsg;
        private List<Models.CountryInfo> data;

        /// <summary>
        /// HTTP status code
        /// </summary>
        [JsonProperty("http_code")]
        public int HttpCode 
        { 
            get 
            {
                return this.httpCode; 
            } 
            set 
            {
                this.httpCode = value;
                onPropertyChanged("HttpCode");
            }
        }

        /// <summary>
        /// Response code of API
        /// </summary>
        [JsonProperty("response_code")]
        public string ResponseCode 
        { 
            get 
            {
                return this.responseCode; 
            } 
            set 
            {
                this.responseCode = value;
                onPropertyChanged("ResponseCode");
            }
        }

        /// <summary>
        /// Response message of API
        /// </summary>
        [JsonProperty("response_msg")]
        public string ResponseMsg 
        { 
            get 
            {
                return this.responseMsg; 
            } 
            set 
            {
                this.responseMsg = value;
                onPropertyChanged("ResponseMsg");
            }
        }

        /// <summary>
        /// This is the list of countries object
        /// </summary>
        [JsonProperty("data")]
        public List<Models.CountryInfo> Data 
        { 
            get 
            {
                return this.data; 
            } 
            set 
            {
                this.data = value;
                onPropertyChanged("Data");
            }
        }
    }
} 