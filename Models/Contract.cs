/*
 * Simple emlpoyee contract tracker api
 *
 * This API allows management of client contracts and tracks history of employee contract assignments 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = SimpleTracker.Web.Client.OpenAPIDateConverter;

namespace SimpleTracker.Web.Models
{
    /// <summary>
    /// Contract data
    /// </summary>
    [DataContract]
    public partial class Contract :  IEquatable<Contract>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contract" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="clientId">clientId.</param>
        /// <param name="type">type.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="tech">tech.</param>
        public Contract(int id = default(int), int clientId = default(int), string type = default(string), string startDate = default(string), string endDate = default(string), List<string> tech = default(List<string>))
        {
            this.Id = id;
            this.ClientId = clientId;
            this.Type = type;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Tech = tech;
        }

        public Contract()
        {
            this.ClientId = default(int);
            this.Id = default(int);
            this.Type = default(string);
            this.StartDate = default(string);
            this.EndDate = default(string);
            this.Tech = default(List<string>);
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public int ClientId { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string? Type { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public string? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public string? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Tech
        /// </summary>
        [DataMember(Name="tech", EmitDefaultValue=false)]
        public List<string>? Tech { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Contract {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Tech: ").Append(Tech).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Contract);
        }

        /// <summary>
        /// Returns true if Contract instances are equal
        /// </summary>
        /// <param name="input">Instance of Contract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Contract input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                ) && 
                (
                    this.Tech == input.Tech ||
                    this.Tech != null &&
                    input.Tech != null &&
                    this.Tech.SequenceEqual(input.Tech)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Tech != null)
                    hashCode = hashCode * 59 + this.Tech.GetHashCode();
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
