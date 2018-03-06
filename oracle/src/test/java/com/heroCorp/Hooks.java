package com.heroCorp;

import cucumber.api.java.Before;
import retrofit2.Response;

import java.io.IOException;

public class Hooks {

    private RestClient client;

    public Hooks(RestClient client) {

        this.client = client;
    }

    @Before
    public void before() throws IOException {
        Response<Void> execute = client.getClient().sendEvent(new Event("End Of Mission", "Secret", 0)).execute();
    }

}
