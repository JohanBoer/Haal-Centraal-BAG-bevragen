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
import io.swagger.annotations.ApiModel;
import com.google.gson.annotations.SerializedName;

import java.io.IOException;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;

/**
 * Een aanduiding van alle waarden die de status van een woonplaats kan aannemen.
 */
@JsonAdapter(StatusWoonplaatsEnum.Adapter.class)
public enum StatusWoonplaatsEnum {
  
  WOONPLAATS_AANGEWEZEN("Woonplaats aangewezen");

  private String value;

  StatusWoonplaatsEnum(String value) {
    this.value = value;
  }

  public String getValue() {
    return value;
  }

  @Override
  public String toString() {
    return String.valueOf(value);
  }

  public static StatusWoonplaatsEnum fromValue(String value) {
    for (StatusWoonplaatsEnum b : StatusWoonplaatsEnum.values()) {
      if (b.value.equals(value)) {
        return b;
      }
    }
    throw new IllegalArgumentException("Unexpected value '" + value + "'");
  }

  public static class Adapter extends TypeAdapter<StatusWoonplaatsEnum> {
    @Override
    public void write(final JsonWriter jsonWriter, final StatusWoonplaatsEnum enumeration) throws IOException {
      jsonWriter.value(enumeration.getValue());
    }

    @Override
    public StatusWoonplaatsEnum read(final JsonReader jsonReader) throws IOException {
      String value = jsonReader.nextString();
      return StatusWoonplaatsEnum.fromValue(value);
    }
  }
}

