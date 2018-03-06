package com.heroCorp;

import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;
import org.mockito.Mockito;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

import static org.hamcrest.MatcherAssert.assertThat;
import static org.hamcrest.Matchers.hasItem;
import static org.hamcrest.Matchers.is;
import static org.mockito.Mockito.when;

public class HeroRepositoryTests {

    private HeroesLoader loader;
    private HeroRepository repository;

    @Before
    public void before() throws IOException {
        loader = Mockito.mock(HeroesLoader.class);
        ArrayList<Hero> heroes = new ArrayList<>();
        heroes.add(createHero("Batman"));
        heroes.add(createHero("Superman"));
        heroes.add(createHero("MeanBatman"));
        heroes.add(createHero("ManBatman"));
        when(loader.load()).thenReturn(heroes);
        repository = getRepository();

    }

    private HeroRepository getRepository() throws IOException {
        return new HeroRepository(loader);
    }

    private Hero createHero(String name) {
        return new Hero(name, null, null, null, null, null, null, null, null, null);
    }

    private List<String> getResultNamesForSearch(String name) {
        return repository.search(name).stream().map(Hero::getName).collect(Collectors.toList());
    }

    @Test
    public void when_get_should_be_able_to_pick_one_hero_with_unchanged_name() {
        Assert.assertTrue(repository.get("Batman").isPresent());
    }

    @Test
    public void when_get_should_be_able_to_pick_one_hero_with_lowercase_name() {
        Assert.assertTrue(repository.get("batman").isPresent());
    }

    @Test
    public void when_search_should_find_string_in_the_middle_of_name(){
        List<String> result = getResultNamesForSearch("pe");
        assertThat(result, hasItem("Superman"));
    }

    @Test
    public void when_search_should_find_lowered_string(){
        List<String> result = getResultNamesForSearch("su");
        assertThat(result, hasItem("Superman"));
    }

    @Test
    public void when_search_should_find_many_results(){
        List<String> result = getResultNamesForSearch("at");
        assertThat(result.size(), is(3));
    }


}
