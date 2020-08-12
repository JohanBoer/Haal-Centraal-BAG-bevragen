/* 
 * Huidige bevragingen API
 *
 * Deze API levert actuele gegevens over adressen, adresseerbaar objecten en panden. Actueel betekent in deze API `zonder eindstatus`. De bron voor deze API is de basisregistratie adressen en gebouwen (BAG).
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: bag@kadaster.nl
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// AdresseerbaarObjectHal
    /// </summary>
    [DataContract]
    public partial class AdresseerbaarObjectHal :  IEquatable<AdresseerbaarObjectHal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdresseerbaarObjectHal" /> class.
        /// </summary>
        /// <param name="identificatie">Dit is de identificatie van een ligplaats, standplaats of verblijfsobject..</param>
        /// <param name="domein">Het domein waartoe de identificatie behoort..</param>
        /// <param name="type">type.</param>
        /// <param name="documentdatum">De vaststellingsdatum van het brondocument dat de basis is voor opname, wijziging of een verwijdering van een object..</param>
        /// <param name="documentnummer">De unieke aanduiding van het brondocument op basis waarvan een opname, mutatie of een verwijdering van gegevens ten aanzien van een woonplaats heeft plaatsgevonden, binnen een gemeente. Alle karakters uit de MES-1 karakterset zijn toegstaan..</param>
        /// <param name="gebruiksdoelen">gebruiksdoelen.</param>
        /// <param name="geconstateerd">Indicatie dat een standplaats, ligplaats of verblijfsobject in de registratie is opgenomen door een feitelijke constatering, zonder dat er een brondocument aan ten grondslag ligt. Het adresseerbaar object is mogelijk illegaal..</param>
        /// <param name="geometrie">geometrie.</param>
        /// <param name="pandIdentificaties">Identificatie(s) van het pand of de panden waar het verblijfsobject deel van is..</param>
        /// <param name="nummeraanduidingIdentificaties">Identificatie(s) van de hoofd- en nevenadressen van de standplaats, ligplaats of verblijfsobject..</param>
        /// <param name="oppervlakte">oppervlakte.</param>
        /// <param name="status">status.</param>
        /// <param name="mogelijkOnjuist">mogelijkOnjuist.</param>
        /// <param name="links">links.</param>
        /// <param name="embedded">embedded.</param>
        public AdresseerbaarObjectHal(string identificatie = default(string), string domein = default(string), TypeAdresseerbaarObjectEnum type = default(TypeAdresseerbaarObjectEnum), DateTime documentdatum = default(DateTime), string documentnummer = default(string), List<GebruiksdoelEnum> gebruiksdoelen = default(List<GebruiksdoelEnum>), bool geconstateerd = default(bool), PuntOfVlak geometrie = default(PuntOfVlak), List<string> pandIdentificaties = default(List<string>), List<NummeraanduidingIdentificatiesArray> nummeraanduidingIdentificaties = default(List<NummeraanduidingIdentificatiesArray>), int oppervlakte = default(int), AdresseerbaarObjectStatusEnum status = default(AdresseerbaarObjectStatusEnum), AdresseerbaarObjectMogelijkOnjuist mogelijkOnjuist = default(AdresseerbaarObjectMogelijkOnjuist), AdresseerbaarObjectLinks links = default(AdresseerbaarObjectLinks), AdresseerbaarObjectEmbedded embedded = default(AdresseerbaarObjectEmbedded))
        {
            this.Identificatie = identificatie;
            this.Domein = domein;
            this.Type = type;
            this.Documentdatum = documentdatum;
            this.Documentnummer = documentnummer;
            this.Gebruiksdoelen = gebruiksdoelen;
            this.Geconstateerd = geconstateerd;
            this.Geometrie = geometrie;
            this.PandIdentificaties = pandIdentificaties;
            this.NummeraanduidingIdentificaties = nummeraanduidingIdentificaties;
            this.Oppervlakte = oppervlakte;
            this.Status = status;
            this.MogelijkOnjuist = mogelijkOnjuist;
            this.Links = links;
            this.Embedded = embedded;
        }
        
        /// <summary>
        /// Dit is de identificatie van een ligplaats, standplaats of verblijfsobject.
        /// </summary>
        /// <value>Dit is de identificatie van een ligplaats, standplaats of verblijfsobject.</value>
        [DataMember(Name="identificatie", EmitDefaultValue=false)]
        public string Identificatie { get; set; }

        /// <summary>
        /// Het domein waartoe de identificatie behoort.
        /// </summary>
        /// <value>Het domein waartoe de identificatie behoort.</value>
        [DataMember(Name="domein", EmitDefaultValue=false)]
        public string Domein { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeAdresseerbaarObjectEnum Type { get; set; }

        /// <summary>
        /// De vaststellingsdatum van het brondocument dat de basis is voor opname, wijziging of een verwijdering van een object.
        /// </summary>
        /// <value>De vaststellingsdatum van het brondocument dat de basis is voor opname, wijziging of een verwijdering van een object.</value>
        [DataMember(Name="documentdatum", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Documentdatum { get; set; }

        /// <summary>
        /// De unieke aanduiding van het brondocument op basis waarvan een opname, mutatie of een verwijdering van gegevens ten aanzien van een woonplaats heeft plaatsgevonden, binnen een gemeente. Alle karakters uit de MES-1 karakterset zijn toegstaan.
        /// </summary>
        /// <value>De unieke aanduiding van het brondocument op basis waarvan een opname, mutatie of een verwijdering van gegevens ten aanzien van een woonplaats heeft plaatsgevonden, binnen een gemeente. Alle karakters uit de MES-1 karakterset zijn toegstaan.</value>
        [DataMember(Name="documentnummer", EmitDefaultValue=false)]
        public string Documentnummer { get; set; }

        /// <summary>
        /// Gets or Sets Gebruiksdoelen
        /// </summary>
        [DataMember(Name="gebruiksdoelen", EmitDefaultValue=false)]
        public List<GebruiksdoelEnum> Gebruiksdoelen { get; set; }

        /// <summary>
        /// Indicatie dat een standplaats, ligplaats of verblijfsobject in de registratie is opgenomen door een feitelijke constatering, zonder dat er een brondocument aan ten grondslag ligt. Het adresseerbaar object is mogelijk illegaal.
        /// </summary>
        /// <value>Indicatie dat een standplaats, ligplaats of verblijfsobject in de registratie is opgenomen door een feitelijke constatering, zonder dat er een brondocument aan ten grondslag ligt. Het adresseerbaar object is mogelijk illegaal.</value>
        [DataMember(Name="geconstateerd", EmitDefaultValue=false)]
        public bool Geconstateerd { get; set; }

        /// <summary>
        /// Gets or Sets Geometrie
        /// </summary>
        [DataMember(Name="geometrie", EmitDefaultValue=false)]
        public PuntOfVlak Geometrie { get; set; }

        /// <summary>
        /// Identificatie(s) van het pand of de panden waar het verblijfsobject deel van is.
        /// </summary>
        /// <value>Identificatie(s) van het pand of de panden waar het verblijfsobject deel van is.</value>
        [DataMember(Name="pandIdentificaties", EmitDefaultValue=false)]
        public List<string> PandIdentificaties { get; set; }

        /// <summary>
        /// Identificatie(s) van de hoofd- en nevenadressen van de standplaats, ligplaats of verblijfsobject.
        /// </summary>
        /// <value>Identificatie(s) van de hoofd- en nevenadressen van de standplaats, ligplaats of verblijfsobject.</value>
        [DataMember(Name="nummeraanduidingIdentificaties", EmitDefaultValue=false)]
        public List<NummeraanduidingIdentificatiesArray> NummeraanduidingIdentificaties { get; set; }

        /// <summary>
        /// Gets or Sets Oppervlakte
        /// </summary>
        [DataMember(Name="oppervlakte", EmitDefaultValue=false)]
        public int Oppervlakte { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public AdresseerbaarObjectStatusEnum Status { get; set; }

        /// <summary>
        /// Gets or Sets MogelijkOnjuist
        /// </summary>
        [DataMember(Name="mogelijkOnjuist", EmitDefaultValue=false)]
        public AdresseerbaarObjectMogelijkOnjuist MogelijkOnjuist { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public AdresseerbaarObjectLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets Embedded
        /// </summary>
        [DataMember(Name="_embedded", EmitDefaultValue=false)]
        public AdresseerbaarObjectEmbedded Embedded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdresseerbaarObjectHal {\n");
            sb.Append("  Identificatie: ").Append(Identificatie).Append("\n");
            sb.Append("  Domein: ").Append(Domein).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Documentdatum: ").Append(Documentdatum).Append("\n");
            sb.Append("  Documentnummer: ").Append(Documentnummer).Append("\n");
            sb.Append("  Gebruiksdoelen: ").Append(Gebruiksdoelen).Append("\n");
            sb.Append("  Geconstateerd: ").Append(Geconstateerd).Append("\n");
            sb.Append("  Geometrie: ").Append(Geometrie).Append("\n");
            sb.Append("  PandIdentificaties: ").Append(PandIdentificaties).Append("\n");
            sb.Append("  NummeraanduidingIdentificaties: ").Append(NummeraanduidingIdentificaties).Append("\n");
            sb.Append("  Oppervlakte: ").Append(Oppervlakte).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  MogelijkOnjuist: ").Append(MogelijkOnjuist).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Embedded: ").Append(Embedded).Append("\n");
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
            return this.Equals(input as AdresseerbaarObjectHal);
        }

        /// <summary>
        /// Returns true if AdresseerbaarObjectHal instances are equal
        /// </summary>
        /// <param name="input">Instance of AdresseerbaarObjectHal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdresseerbaarObjectHal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Identificatie == input.Identificatie ||
                    (this.Identificatie != null &&
                    this.Identificatie.Equals(input.Identificatie))
                ) && 
                (
                    this.Domein == input.Domein ||
                    (this.Domein != null &&
                    this.Domein.Equals(input.Domein))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Documentdatum == input.Documentdatum ||
                    (this.Documentdatum != null &&
                    this.Documentdatum.Equals(input.Documentdatum))
                ) && 
                (
                    this.Documentnummer == input.Documentnummer ||
                    (this.Documentnummer != null &&
                    this.Documentnummer.Equals(input.Documentnummer))
                ) && 
                (
                    this.Gebruiksdoelen == input.Gebruiksdoelen ||
                    this.Gebruiksdoelen != null &&
                    input.Gebruiksdoelen != null &&
                    this.Gebruiksdoelen.SequenceEqual(input.Gebruiksdoelen)
                ) && 
                (
                    this.Geconstateerd == input.Geconstateerd ||
                    (this.Geconstateerd != null &&
                    this.Geconstateerd.Equals(input.Geconstateerd))
                ) && 
                (
                    this.Geometrie == input.Geometrie ||
                    (this.Geometrie != null &&
                    this.Geometrie.Equals(input.Geometrie))
                ) && 
                (
                    this.PandIdentificaties == input.PandIdentificaties ||
                    this.PandIdentificaties != null &&
                    input.PandIdentificaties != null &&
                    this.PandIdentificaties.SequenceEqual(input.PandIdentificaties)
                ) && 
                (
                    this.NummeraanduidingIdentificaties == input.NummeraanduidingIdentificaties ||
                    this.NummeraanduidingIdentificaties != null &&
                    input.NummeraanduidingIdentificaties != null &&
                    this.NummeraanduidingIdentificaties.SequenceEqual(input.NummeraanduidingIdentificaties)
                ) && 
                (
                    this.Oppervlakte == input.Oppervlakte ||
                    (this.Oppervlakte != null &&
                    this.Oppervlakte.Equals(input.Oppervlakte))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.MogelijkOnjuist == input.MogelijkOnjuist ||
                    (this.MogelijkOnjuist != null &&
                    this.MogelijkOnjuist.Equals(input.MogelijkOnjuist))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Embedded == input.Embedded ||
                    (this.Embedded != null &&
                    this.Embedded.Equals(input.Embedded))
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
                if (this.Identificatie != null)
                    hashCode = hashCode * 59 + this.Identificatie.GetHashCode();
                if (this.Domein != null)
                    hashCode = hashCode * 59 + this.Domein.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Documentdatum != null)
                    hashCode = hashCode * 59 + this.Documentdatum.GetHashCode();
                if (this.Documentnummer != null)
                    hashCode = hashCode * 59 + this.Documentnummer.GetHashCode();
                if (this.Gebruiksdoelen != null)
                    hashCode = hashCode * 59 + this.Gebruiksdoelen.GetHashCode();
                if (this.Geconstateerd != null)
                    hashCode = hashCode * 59 + this.Geconstateerd.GetHashCode();
                if (this.Geometrie != null)
                    hashCode = hashCode * 59 + this.Geometrie.GetHashCode();
                if (this.PandIdentificaties != null)
                    hashCode = hashCode * 59 + this.PandIdentificaties.GetHashCode();
                if (this.NummeraanduidingIdentificaties != null)
                    hashCode = hashCode * 59 + this.NummeraanduidingIdentificaties.GetHashCode();
                if (this.Oppervlakte != null)
                    hashCode = hashCode * 59 + this.Oppervlakte.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.MogelijkOnjuist != null)
                    hashCode = hashCode * 59 + this.MogelijkOnjuist.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Embedded != null)
                    hashCode = hashCode * 59 + this.Embedded.GetHashCode();
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
