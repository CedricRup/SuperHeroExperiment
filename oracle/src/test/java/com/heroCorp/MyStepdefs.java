package com.heroCorp;

import cucumber.api.DataTable;
import cucumber.api.java.en.Given;
import cucumber.api.java.en.Then;
import cucumber.api.java.en.When;
import org.junit.Assert;
import retrofit2.Response;

import java.io.IOException;
import java.util.List;
import java.util.Map;
import java.util.stream.Collectors;

import static org.junit.Assert.assertEquals;

public class MyStepdefs {

    private RestClient restClient;
    private Response<Void> registerResult;


    public MyStepdefs(RestClient restClient){
        this.restClient = restClient;
    }

    Map<String,CukeHero> heroes;

    @Given("^this heroes may register$")
    public void this_heroes_may_register(List<CukeHero> heroes) {
        this.heroes = heroes.stream().collect(Collectors.toMap(h->h.name,h->h));
    }

    @When("^a hero called \"([^\"]*)\" tries to register with the key \"([^\"]*)\"$")
    public void registerHero(String name, String key) throws Exception {
        registerResult = restClient.getClient().register(new Registration(name,key)).execute();
    }

    @Then("^the registration is a success$")
    public void the_registration_is_a_success() throws Exception {
        assertEquals(200, registerResult.code());
    }


    @Then("^the registration is forbidden$")
    public void the_registration_is_forbidden() throws Exception {
        assertEquals(401, registerResult.code());
    }

    @When("^powers are determined for \"([^\"]*)\"$")
    public void powers_are_determined_for(String arg1) throws Exception {
        // Write code here that turns the phrase above into concrete actions
    }

    @Then("^this hero has \"([^\"]*)\" Power$")
    public void this_hero_has_Power(String power) throws Exception {
        // Write code here that turns the phrase above into concrete actions
    }

    @Then("^this hero has no \"([^\"]*)\" Power$")
    public void this_hero_has_no_Power(String power) throws Exception {
        // Write code here that turns the phrase above into concrete actions
    }

    @When("^strenght is determined for \"([^\"]*)\"$")
    public void strenght_is_determined_for(String heroName) throws Exception {
        // Write code here that turns the phrase above into concrete actions
    }

    @Then("^strength is (\\d+)$")
    public void strength_is(int arg1) throws Exception {
        // Write code here that turns the phrase above into concrete actions
    }

    @When("^powers are determined for \"([^\"]*)\" in \"([^\"]*)\"$")
    public void powers_are_determined_for_in(String arg1, String arg2) throws Exception {
        // Write code here that turns the phrase above into concrete actions
    }



    @Given("^these heroes registrations$")
    public void these_heroes_registrations(List<CukeHero>  heroes) throws Exception {

        heroes.forEach(hero-> {
            try {
                registerHero(hero.name,this.heroes.get(hero.name).secret);
            } catch (Exception e) {
                Assert.fail();
            }
        });
    }

    @Then("^the intervention plan should be$")
    public void the_intervention_plan_should_be(DataTable interventions) throws Exception {
        Response<List<Intervention>> execute = restClient.getClient().getPlan().execute();
        List<Intervention> real = execute.body();// Write code here that turns the phrase above into concrete actions
        interventions.diff(real);
    }

    @When("^these events occur$")
    public void these_events_occur(List<Event> events) throws Exception {

        events.forEach(e->{
            try {
                restClient.getClient().sendEvent(e).execute();
            } catch (IOException e1) {
                Assert.fail();
            }
        });
    }

    @Then("^the intervention plan should be empty$")
    public void the_intervention_plan_should_be_empty() throws Exception {
        assertEquals(204, restClient.getClient().getPlan().execute().code());
    }
}
