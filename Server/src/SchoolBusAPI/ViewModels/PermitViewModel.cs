/*
 * REST API Documentation for the MOTI School Bus Application
 *
 * The School Bus application tracks that inspections are performed in a timely fashion. For each school bus the application tracks information about the bus (including data from ICBC, NSC, etc.), it's past and next inspection dates and results, contacts, and the inspector responsible for next inspecting the bus.
 *
 * OpenAPI spec version: v1
 * 
 * 
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SchoolBusAPI.Models;

namespace SchoolBusAPI.ViewModels
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class PermitViewModel : IEquatable<PermitViewModel>
    {
        /// <summary>
        /// Default constructor, required by entity framework
        /// </summary>
        public PermitViewModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermitViewModel" /> class.
        /// </summary>
        /// <param name="PermitNumber">PermitNumber.</param>
        /// <param name="PermitIssueDate">PermitIssueDate.</param>
        /// <param name="SchoolBusOwnerName">SchoolBusOwnerName.</param>
        /// <param name="SchoolBusOwnerAddressLine1">SchoolBusOwnerAddressLine1.</param>
        /// <param name="SchoolBusOwnerAddressLine2">SchoolBusOwnerAddressLine2.</param>
        /// <param name="SchoolBusMobilityAidCapacity">SchoolBusMobilityAidCapacity.</param>
        /// <param name="SchoolBusOwnerCity">SchoolBusOwnerCity.</param>
        /// <param name="SchoolBusOwnerProvince">SchoolBusOwnerProvince.</param>
        /// <param name="SchoolBusOwnerPostalCode">SchoolBusOwnerPostalCode.</param>
        /// <param name="IcbcRegistrationNumber">IcbcRegistrationNumber.</param>
        /// <param name="VehicleIdentificationNumber">VehicleIdentificationNumber.</param>
        /// <param name="IcbcModelYear">IcbcModelYear.</param>
        /// <param name="IcbcMake">IcbcMake.</param>
        /// <param name="RestrictionsText">RestrictionsText.</param>
        /// <param name="SchoolDistrictshortName">SchoolDistrictshortName.</param>
        /// <param name="SchoolBusSeatingCapacity">SchoolBusSeatingCapacity.</param>
        /// <param name="UnitNumber">The unit number of the Bus as defined by the School Bus owner - freeform text..</param>
        /// <param name="PermitClassCode">The enumerated class of School Bus from drop down.</param>
        /// <param name="BodyTypeCode">The enumerated body type of the School Bus from drop down.</param>
        public PermitViewModel(int? PermitNumber = null, string PermitIssueDate = null, string SchoolBusOwnerName = null, string SchoolBusOwnerAddressLine1 = null, string SchoolBusOwnerAddressLine2 = null, string SchoolBusMobilityAidCapacity = null, string SchoolBusOwnerCity = null, string SchoolBusOwnerProvince = null, string SchoolBusOwnerPostalCode = null, string IcbcRegistrationNumber = null, string VehicleIdentificationNumber = null, int? IcbcModelYear = null, string IcbcMake = null, string RestrictionsText = null, string SchoolDistrictshortName = null, int? SchoolBusSeatingCapacity = null, string UnitNumber = null, string PermitClassCode = null, string BodyTypeCode = null)
        {               this.PermitNumber = PermitNumber;
            this.PermitIssueDate = PermitIssueDate;
            this.SchoolBusOwnerName = SchoolBusOwnerName;
            this.SchoolBusOwnerAddressLine1 = SchoolBusOwnerAddressLine1;
            this.SchoolBusOwnerAddressLine2 = SchoolBusOwnerAddressLine2;
            this.SchoolBusMobilityAidCapacity = SchoolBusMobilityAidCapacity;
            this.SchoolBusOwnerCity = SchoolBusOwnerCity;
            this.SchoolBusOwnerProvince = SchoolBusOwnerProvince;
            this.SchoolBusOwnerPostalCode = SchoolBusOwnerPostalCode;
            this.IcbcRegistrationNumber = IcbcRegistrationNumber;
            this.VehicleIdentificationNumber = VehicleIdentificationNumber;
            this.IcbcModelYear = IcbcModelYear;
            this.IcbcMake = IcbcMake;
            this.RestrictionsText = RestrictionsText;
            this.SchoolDistrictshortName = SchoolDistrictshortName;
            this.SchoolBusSeatingCapacity = SchoolBusSeatingCapacity;
            this.UnitNumber = UnitNumber;
            this.PermitClassCode = PermitClassCode;
            this.BodyTypeCode = BodyTypeCode;
        }

        /// <summary>
        /// Gets or Sets PermitNumber
        /// </summary>
        [DataMember(Name="permitNumber")]
        public int? PermitNumber { get; set; }

        /// <summary>
        /// Gets or Sets PermitIssueDate
        /// </summary>
        [DataMember(Name="permitIssueDate")]
        public string PermitIssueDate { get; set; }

        /// <summary>
        /// Gets or Sets SchoolBusOwnerName
        /// </summary>
        [DataMember(Name="schoolBusOwnerName")]
        public string SchoolBusOwnerName { get; set; }

        /// <summary>
        /// Gets or Sets SchoolBusOwnerAddressLine1
        /// </summary>
        [DataMember(Name="schoolBusOwnerAddressLine1")]
        public string SchoolBusOwnerAddressLine1 { get; set; }

        /// <summary>
        /// Gets or Sets SchoolBusOwnerAddressLine2
        /// </summary>
        [DataMember(Name="schoolBusOwnerAddressLine2")]
        public string SchoolBusOwnerAddressLine2 { get; set; }

        /// <summary>
        /// Gets or Sets SchoolBusMobilityAidCapacity
        /// </summary>
        [DataMember(Name="schoolBusMobilityAidCapacity")]
        public string SchoolBusMobilityAidCapacity { get; set; }

        /// <summary>
        /// Gets or Sets SchoolBusOwnerCity
        /// </summary>
        [DataMember(Name="schoolBusOwnerCity")]
        public string SchoolBusOwnerCity { get; set; }

        /// <summary>
        /// Gets or Sets SchoolBusOwnerProvince
        /// </summary>
        [DataMember(Name="schoolBusOwnerProvince")]
        public string SchoolBusOwnerProvince { get; set; }

        /// <summary>
        /// Gets or Sets SchoolBusOwnerPostalCode
        /// </summary>
        [DataMember(Name="schoolBusOwnerPostalCode")]
        public string SchoolBusOwnerPostalCode { get; set; }

        /// <summary>
        /// Gets or Sets IcbcRegistrationNumber
        /// </summary>
        [DataMember(Name="icbcRegistrationNumber")]
        public string IcbcRegistrationNumber { get; set; }

        /// <summary>
        /// Gets or Sets VehicleIdentificationNumber
        /// </summary>
        [DataMember(Name="vehicleIdentificationNumber")]
        public string VehicleIdentificationNumber { get; set; }

        /// <summary>
        /// Gets or Sets IcbcModelYear
        /// </summary>
        [DataMember(Name="icbcModelYear")]
        public int? IcbcModelYear { get; set; }

        /// <summary>
        /// Gets or Sets IcbcMake
        /// </summary>
        [DataMember(Name="icbcMake")]
        public string IcbcMake { get; set; }

        /// <summary>
        /// Gets or Sets RestrictionsText
        /// </summary>
        [DataMember(Name="restrictionsText")]
        public string RestrictionsText { get; set; }

        /// <summary>
        /// Gets or Sets SchoolDistrictshortName
        /// </summary>
        [DataMember(Name="schoolDistrictshortName")]
        public string SchoolDistrictshortName { get; set; }

        /// <summary>
        /// Gets or Sets SchoolBusSeatingCapacity
        /// </summary>
        [DataMember(Name="schoolBusSeatingCapacity")]
        public int? SchoolBusSeatingCapacity { get; set; }

        /// <summary>
        /// The unit number of the Bus as defined by the School Bus owner - freeform text.
        /// </summary>
        /// <value>The unit number of the Bus as defined by the School Bus owner - freeform text.</value>
        [DataMember(Name="unitNumber")]
        [MetaDataExtension (Description = "The unit number of the Bus as defined by the School Bus owner - freeform text.")]
        public string UnitNumber { get; set; }

        /// <summary>
        /// The enumerated class of School Bus from drop down
        /// </summary>
        /// <value>The enumerated class of School Bus from drop down</value>
        [DataMember(Name="permitClassCode")]
        [MetaDataExtension (Description = "The enumerated class of School Bus from drop down")]
        public string PermitClassCode { get; set; }

        /// <summary>
        /// The enumerated body type of the School Bus from drop down
        /// </summary>
        /// <value>The enumerated body type of the School Bus from drop down</value>
        [DataMember(Name="bodyTypeCode")]
        [MetaDataExtension (Description = "The enumerated body type of the School Bus from drop down")]
        public string BodyTypeCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermitViewModel {\n");
            sb.Append("  PermitNumber: ").Append(PermitNumber).Append("\n");
            sb.Append("  PermitIssueDate: ").Append(PermitIssueDate).Append("\n");
            sb.Append("  SchoolBusOwnerName: ").Append(SchoolBusOwnerName).Append("\n");
            sb.Append("  SchoolBusOwnerAddressLine1: ").Append(SchoolBusOwnerAddressLine1).Append("\n");
            sb.Append("  SchoolBusOwnerAddressLine2: ").Append(SchoolBusOwnerAddressLine2).Append("\n");
            sb.Append("  SchoolBusMobilityAidCapacity: ").Append(SchoolBusMobilityAidCapacity).Append("\n");
            sb.Append("  SchoolBusOwnerCity: ").Append(SchoolBusOwnerCity).Append("\n");
            sb.Append("  SchoolBusOwnerProvince: ").Append(SchoolBusOwnerProvince).Append("\n");
            sb.Append("  SchoolBusOwnerPostalCode: ").Append(SchoolBusOwnerPostalCode).Append("\n");
            sb.Append("  IcbcRegistrationNumber: ").Append(IcbcRegistrationNumber).Append("\n");
            sb.Append("  VehicleIdentificationNumber: ").Append(VehicleIdentificationNumber).Append("\n");
            sb.Append("  IcbcModelYear: ").Append(IcbcModelYear).Append("\n");
            sb.Append("  IcbcMake: ").Append(IcbcMake).Append("\n");
            sb.Append("  RestrictionsText: ").Append(RestrictionsText).Append("\n");
            sb.Append("  SchoolDistrictshortName: ").Append(SchoolDistrictshortName).Append("\n");
            sb.Append("  SchoolBusSeatingCapacity: ").Append(SchoolBusSeatingCapacity).Append("\n");
            sb.Append("  UnitNumber: ").Append(UnitNumber).Append("\n");
            sb.Append("  PermitClassCode: ").Append(PermitClassCode).Append("\n");
            sb.Append("  BodyTypeCode: ").Append(BodyTypeCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) { return false; }
            if (ReferenceEquals(this, obj)) { return true; }
            if (obj.GetType() != GetType()) { return false; }
            return Equals((PermitViewModel)obj);
        }

        /// <summary>
        /// Returns true if PermitViewModel instances are equal
        /// </summary>
        /// <param name="other">Instance of PermitViewModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PermitViewModel other)
        {

            if (ReferenceEquals(null, other)) { return false; }
            if (ReferenceEquals(this, other)) { return true; }

            return                 
                (
                    this.PermitNumber == other.PermitNumber ||
                    this.PermitNumber != null &&
                    this.PermitNumber.Equals(other.PermitNumber)
                ) &&                 
                (
                    this.PermitIssueDate == other.PermitIssueDate ||
                    this.PermitIssueDate != null &&
                    this.PermitIssueDate.Equals(other.PermitIssueDate)
                ) &&                 
                (
                    this.SchoolBusOwnerName == other.SchoolBusOwnerName ||
                    this.SchoolBusOwnerName != null &&
                    this.SchoolBusOwnerName.Equals(other.SchoolBusOwnerName)
                ) &&                 
                (
                    this.SchoolBusOwnerAddressLine1 == other.SchoolBusOwnerAddressLine1 ||
                    this.SchoolBusOwnerAddressLine1 != null &&
                    this.SchoolBusOwnerAddressLine1.Equals(other.SchoolBusOwnerAddressLine1)
                ) &&                 
                (
                    this.SchoolBusOwnerAddressLine2 == other.SchoolBusOwnerAddressLine2 ||
                    this.SchoolBusOwnerAddressLine2 != null &&
                    this.SchoolBusOwnerAddressLine2.Equals(other.SchoolBusOwnerAddressLine2)
                ) &&                 
                (
                    this.SchoolBusMobilityAidCapacity == other.SchoolBusMobilityAidCapacity ||
                    this.SchoolBusMobilityAidCapacity != null &&
                    this.SchoolBusMobilityAidCapacity.Equals(other.SchoolBusMobilityAidCapacity)
                ) &&                 
                (
                    this.SchoolBusOwnerCity == other.SchoolBusOwnerCity ||
                    this.SchoolBusOwnerCity != null &&
                    this.SchoolBusOwnerCity.Equals(other.SchoolBusOwnerCity)
                ) &&                 
                (
                    this.SchoolBusOwnerProvince == other.SchoolBusOwnerProvince ||
                    this.SchoolBusOwnerProvince != null &&
                    this.SchoolBusOwnerProvince.Equals(other.SchoolBusOwnerProvince)
                ) &&                 
                (
                    this.SchoolBusOwnerPostalCode == other.SchoolBusOwnerPostalCode ||
                    this.SchoolBusOwnerPostalCode != null &&
                    this.SchoolBusOwnerPostalCode.Equals(other.SchoolBusOwnerPostalCode)
                ) &&                 
                (
                    this.IcbcRegistrationNumber == other.IcbcRegistrationNumber ||
                    this.IcbcRegistrationNumber != null &&
                    this.IcbcRegistrationNumber.Equals(other.IcbcRegistrationNumber)
                ) &&                 
                (
                    this.VehicleIdentificationNumber == other.VehicleIdentificationNumber ||
                    this.VehicleIdentificationNumber != null &&
                    this.VehicleIdentificationNumber.Equals(other.VehicleIdentificationNumber)
                ) &&                 
                (
                    this.IcbcModelYear == other.IcbcModelYear ||
                    this.IcbcModelYear != null &&
                    this.IcbcModelYear.Equals(other.IcbcModelYear)
                ) &&                 
                (
                    this.IcbcMake == other.IcbcMake ||
                    this.IcbcMake != null &&
                    this.IcbcMake.Equals(other.IcbcMake)
                ) &&                 
                (
                    this.RestrictionsText == other.RestrictionsText ||
                    this.RestrictionsText != null &&
                    this.RestrictionsText.Equals(other.RestrictionsText)
                ) &&                 
                (
                    this.SchoolDistrictshortName == other.SchoolDistrictshortName ||
                    this.SchoolDistrictshortName != null &&
                    this.SchoolDistrictshortName.Equals(other.SchoolDistrictshortName)
                ) &&                 
                (
                    this.SchoolBusSeatingCapacity == other.SchoolBusSeatingCapacity ||
                    this.SchoolBusSeatingCapacity != null &&
                    this.SchoolBusSeatingCapacity.Equals(other.SchoolBusSeatingCapacity)
                ) &&                 
                (
                    this.UnitNumber == other.UnitNumber ||
                    this.UnitNumber != null &&
                    this.UnitNumber.Equals(other.UnitNumber)
                ) &&                 
                (
                    this.PermitClassCode == other.PermitClassCode ||
                    this.PermitClassCode != null &&
                    this.PermitClassCode.Equals(other.PermitClassCode)
                ) &&                 
                (
                    this.BodyTypeCode == other.BodyTypeCode ||
                    this.BodyTypeCode != null &&
                    this.BodyTypeCode.Equals(other.BodyTypeCode)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks
                if (this.PermitNumber != null)
                {
                    hash = hash * 59 + this.PermitNumber.GetHashCode();
                }                
                                if (this.PermitIssueDate != null)
                {
                    hash = hash * 59 + this.PermitIssueDate.GetHashCode();
                }                
                                if (this.SchoolBusOwnerName != null)
                {
                    hash = hash * 59 + this.SchoolBusOwnerName.GetHashCode();
                }                
                                if (this.SchoolBusOwnerAddressLine1 != null)
                {
                    hash = hash * 59 + this.SchoolBusOwnerAddressLine1.GetHashCode();
                }                
                                if (this.SchoolBusOwnerAddressLine2 != null)
                {
                    hash = hash * 59 + this.SchoolBusOwnerAddressLine2.GetHashCode();
                }                
                                if (this.SchoolBusMobilityAidCapacity != null)
                {
                    hash = hash * 59 + this.SchoolBusMobilityAidCapacity.GetHashCode();
                }                
                                if (this.SchoolBusOwnerCity != null)
                {
                    hash = hash * 59 + this.SchoolBusOwnerCity.GetHashCode();
                }                
                                if (this.SchoolBusOwnerProvince != null)
                {
                    hash = hash * 59 + this.SchoolBusOwnerProvince.GetHashCode();
                }                
                                if (this.SchoolBusOwnerPostalCode != null)
                {
                    hash = hash * 59 + this.SchoolBusOwnerPostalCode.GetHashCode();
                }                
                                if (this.IcbcRegistrationNumber != null)
                {
                    hash = hash * 59 + this.IcbcRegistrationNumber.GetHashCode();
                }                
                                if (this.VehicleIdentificationNumber != null)
                {
                    hash = hash * 59 + this.VehicleIdentificationNumber.GetHashCode();
                }                
                                if (this.IcbcModelYear != null)
                {
                    hash = hash * 59 + this.IcbcModelYear.GetHashCode();
                }                
                                if (this.IcbcMake != null)
                {
                    hash = hash * 59 + this.IcbcMake.GetHashCode();
                }                
                                if (this.RestrictionsText != null)
                {
                    hash = hash * 59 + this.RestrictionsText.GetHashCode();
                }                
                                if (this.SchoolDistrictshortName != null)
                {
                    hash = hash * 59 + this.SchoolDistrictshortName.GetHashCode();
                }                
                                if (this.SchoolBusSeatingCapacity != null)
                {
                    hash = hash * 59 + this.SchoolBusSeatingCapacity.GetHashCode();
                }                
                                if (this.UnitNumber != null)
                {
                    hash = hash * 59 + this.UnitNumber.GetHashCode();
                }                
                                if (this.PermitClassCode != null)
                {
                    hash = hash * 59 + this.PermitClassCode.GetHashCode();
                }                
                                if (this.BodyTypeCode != null)
                {
                    hash = hash * 59 + this.BodyTypeCode.GetHashCode();
                }                
                
                return hash;
            }
        }

        #region Operators
        
        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(PermitViewModel left, PermitViewModel right)
        {
            return Equals(left, right);
        }

        /// <summary>
        /// Not Equals
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator !=(PermitViewModel left, PermitViewModel right)
        {
            return !Equals(left, right);
        }

        #endregion Operators
    }
}
