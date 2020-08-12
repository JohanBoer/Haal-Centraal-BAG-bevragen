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
import org.openapitools.client.model.PandHalBasis;

/**
 * PandHalCollectieEmbedded
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2020-08-11T16:02:19.372+02:00[Europe/Amsterdam]")
public class PandHalCollectieEmbedded {
  public static final String SERIALIZED_NAME_PANDEN = "panden";
  @SerializedName(SERIALIZED_NAME_PANDEN)
  private List<PandHalBasis> panden = null;


  public PandHalCollectieEmbedded panden(List<PandHalBasis> panden) {
    
    this.panden = panden;
    return this;
  }

  public PandHalCollectieEmbedded addPandenItem(PandHalBasis pandenItem) {
    if (this.panden == null) {
      this.panden = new ArrayList<>();
    }
    this.panden.add(pandenItem);
    return this;
  }

   /**
   * Get panden
   * @return panden
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<PandHalBasis> getPanden() {
    return panden;
  }


  public void setPanden(List<PandHalBasis> panden) {
    this.panden = panden;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PandHalCollectieEmbedded pandHalCollectieEmbedded = (PandHalCollectieEmbedded) o;
    return Objects.equals(this.panden, pandHalCollectieEmbedded.panden);
  }

  @Override
  public int hashCode() {
    return Objects.hash(panden);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class PandHalCollectieEmbedded {\n");
    sb.append("    panden: ").append(toIndentedString(panden)).append("\n");
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

