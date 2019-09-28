/* 
 * Brainrex API Explorer
 *
 * Welcome to the Brainrex API explorer, we make analytics tools for crypto and blockchain. Our currently propiertary models offer sentiment analysis, market making, blockchain monitoring and face-id verification. This AI models can be consumed from this API. We also offer integrations to open data and propietary data providers, as well as free test data we collect. There is a collection of data transformation tools. Join our Telegram group to get the latest news and ask questions [https://t.me/brainrex, #brainrex](https://t.me/brainrex). More about Brainrex at [https://brainrex.com](http://brainrex.com). Full Documentation can be found at [https://brainrexapi.github.io/docs](https://brainrexapi.github.io/docs)
 *
 * OpenAPI spec version: 0.1.1
 * Contact: support@brainrex.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Request2
    /// </summary>
    [DataContract]
    public partial class Request2 :  IEquatable<Request2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Request2" /> class.
        /// </summary>
        /// <param name="exchange">Name of the exchange.</param>
        /// <param name="market">Name of the currency pair.</param>
        /// <param name="dataFormat">Name of the data format availables (standard).</param>
        /// <param name="orient">Name of the market.</param>
        /// <param name="candleSize">Name of the market.</param>
        /// <param name="startDate">Start date in YYYY/MM/DD.</param>
        /// <param name="endDate">End date YYYY/MM/DD.</param>
        public Request2(string exchange = default(string), string market = default(string), string dataFormat = default(string), string orient = default(string), string candleSize = default(string), string startDate = default(string), string endDate = default(string))
        {
            this.Exchange = exchange;
            this.Market = market;
            this.DataFormat = dataFormat;
            this.Orient = orient;
            this.CandleSize = candleSize;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
        
        /// <summary>
        /// Name of the exchange
        /// </summary>
        /// <value>Name of the exchange</value>
        [DataMember(Name="exchange", EmitDefaultValue=false)]
        public string Exchange { get; set; }

        /// <summary>
        /// Name of the currency pair
        /// </summary>
        /// <value>Name of the currency pair</value>
        [DataMember(Name="market", EmitDefaultValue=false)]
        public string Market { get; set; }

        /// <summary>
        /// Name of the data format availables (standard)
        /// </summary>
        /// <value>Name of the data format availables (standard)</value>
        [DataMember(Name="data_format", EmitDefaultValue=false)]
        public string DataFormat { get; set; }

        /// <summary>
        /// Name of the market
        /// </summary>
        /// <value>Name of the market</value>
        [DataMember(Name="orient", EmitDefaultValue=false)]
        public string Orient { get; set; }

        /// <summary>
        /// Name of the market
        /// </summary>
        /// <value>Name of the market</value>
        [DataMember(Name="candle_size", EmitDefaultValue=false)]
        public string CandleSize { get; set; }

        /// <summary>
        /// Start date in YYYY/MM/DD
        /// </summary>
        /// <value>Start date in YYYY/MM/DD</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// End date YYYY/MM/DD
        /// </summary>
        /// <value>End date YYYY/MM/DD</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Request2 {\n");
            sb.Append("  Exchange: ").Append(Exchange).Append("\n");
            sb.Append("  Market: ").Append(Market).Append("\n");
            sb.Append("  DataFormat: ").Append(DataFormat).Append("\n");
            sb.Append("  Orient: ").Append(Orient).Append("\n");
            sb.Append("  CandleSize: ").Append(CandleSize).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Request2);
        }

        /// <summary>
        /// Returns true if Request2 instances are equal
        /// </summary>
        /// <param name="input">Instance of Request2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Request2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Exchange == input.Exchange ||
                    (this.Exchange != null &&
                    this.Exchange.Equals(input.Exchange))
                ) && 
                (
                    this.Market == input.Market ||
                    (this.Market != null &&
                    this.Market.Equals(input.Market))
                ) && 
                (
                    this.DataFormat == input.DataFormat ||
                    (this.DataFormat != null &&
                    this.DataFormat.Equals(input.DataFormat))
                ) && 
                (
                    this.Orient == input.Orient ||
                    (this.Orient != null &&
                    this.Orient.Equals(input.Orient))
                ) && 
                (
                    this.CandleSize == input.CandleSize ||
                    (this.CandleSize != null &&
                    this.CandleSize.Equals(input.CandleSize))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Exchange != null)
                    hashCode = hashCode * 59 + this.Exchange.GetHashCode();
                if (this.Market != null)
                    hashCode = hashCode * 59 + this.Market.GetHashCode();
                if (this.DataFormat != null)
                    hashCode = hashCode * 59 + this.DataFormat.GetHashCode();
                if (this.Orient != null)
                    hashCode = hashCode * 59 + this.Orient.GetHashCode();
                if (this.CandleSize != null)
                    hashCode = hashCode * 59 + this.CandleSize.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
