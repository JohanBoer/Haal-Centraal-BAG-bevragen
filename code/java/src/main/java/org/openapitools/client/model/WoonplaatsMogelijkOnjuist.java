/*
 * Huidige bevragingen API
 * Deze API levert actuele gegevens over adressen, adresseerbaar objecten en panden. Actueel betekent in deze API `zonder eindstatus`. De bron voor deze API is de basisregistratie adressen en gebouwen (BAG).
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: bag@kadaster.nl
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

/**
 * Wanneer true is de waarde mogelijk onjuist en wordt juistheid op dit moment onderzocht. Zie toelichting.
 */
@ApiModel(description = "Wanneer true is de waarde mogelijk onjuist en wordt juistheid op dit moment onderzocht. Zie toelichting.")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2020-08-11T16:02:19.372+02:00[Europe/Amsterdam]")
public class WoonplaatsMogelijkOnjuist {
  public static final String SERIALIZED_NAME_NAAM = "naam";
  @SerializedName(SERIALIZED_NAME_NAAM)
  private Boolean naam;

  public static final String SERIALIZED_NAME_GEOMETRIE = "geometrie";
  @SerializedName(SERIALIZED_NAME_GEOMETRIE)
  private Boolean geometrie;

  public static final String SERIALIZED_NAME_STATUS = "status";
  @SerializedName(SERIALIZED_NAME_STATUS)
  private Boolean status;

  public static final String SERIALIZED_NAME_TOELICHTING = "toelichting";
  @SerializedName(SERIALIZED_NAME_TOELICHTING)
  private List<String> toelichting = null;


  public WoonplaatsMogelijkOnjuist naam(Boolean naam) {
    
    this.naam = naam;
    return this;
  }

   /**
   * Get naam
   * @return naam
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getNaam() {
    return naam;
  }


  public void setNaam(Boolean naam) {
    this.naam = naam;
  }


  public WoonplaatsMogelijkOnjuist geometrie(Boolean geometrie) {
    
    this.geometrie = geometrie;
    return this;
  }

   /**
   * Get geometrie
   * @return geometrie
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getGeometrie() {
    return geometrie;
  }


  public void setGeometrie(Boolean geometrie) {
    this.geometrie = geometrie;
  }


  public WoonplaatsMogelijkOnjuist status(Boolean status) {
    
    this.status = status;
    return this;
  }

   /**
   * Get status
   * @return status
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getStatus() {
    return status;
  }


  public void setStatus(Boolean status) {
    this.status = status;
  }


  public WoonplaatsMogelijkOnjuist toelichting(List<String> toelichting) {
    
    this.toelichting = toelichting;
    return this;
  }

  public WoonplaatsMogelijkOnjuist addToelichtingItem(String toelichtingItem) {
    if (this.toelichting == null) {
      this.toelichting = new ArrayList<>();
    }
    this.toelichting.add(toelichtingItem);
    return this;
  }

   /**
   * Get toelichting
   * @return toelichting
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<String> getToelichting() {
    return toelichting;
  }


  public void setToelichting(List<String> toelichting) {
    this.toelichting = toelichting;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    WoonplaatsMogelijkOnjuist woonplaatsMogelijkOnjuist = (WoonplaatsMogelijkOnjuist) o;
    return Objects.equals(this.naam, woonplaatsMogelijkOnjuist.naam) &&
        Objects.equals(this.geometrie, woonplaatsMogelijkOnjuist.geometrie) &&
        Objects.equals(this.status, woonplaatsMogelijkOnjuist.status) &&
        Objects.equals(this.toelichting, woonplaatsMogelijkOnjuist.toelichting);
  }

  @Override
  public int hashCode() {
    return Objects.hash(naam, geometrie, status, toelichting);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class WoonplaatsMogelijkOnjuist {\n");
    sb.append("    naam: ").append(toIndentedString(naam)).append("\n");
    sb.append("    geometrie: ").append(toIndentedString(geometrie)).append("\n");
    sb.append("    status: ").append(toIndentedString(status)).append("\n");
    sb.append("    toelichting: ").append(toIndentedString(toelichting)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

