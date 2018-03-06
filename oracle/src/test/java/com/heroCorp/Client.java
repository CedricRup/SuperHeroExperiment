package com.heroCorp;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.GET;
import retrofit2.http.Headers;
import retrofit2.http.POST;
import java.util.List;

public interface Client {

    @Headers({"Accept: application/json"})
    @POST("registration")
    Call<Void> register(@Body Registration registration);

    @Headers({"Accept: application/json"})
    @POST("event")
    Call<Void> sendEvent(@Body Event registration);

    @Headers({"Accept: application/json"})
    @GET("interventionPlan")
    Call<List<Intervention>> getPlan();

}