package com.heroCorp;

import org.springframework.stereotype.Repository;

import java.io.IOException;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Optional;
import java.util.stream.Collectors;

@Repository
public class HeroRepository {

    private Map<String, Hero> heroes = new HashMap<>();

    public HeroRepository(HeroesLoader loader) throws IOException {
        load(loader);
    }

    private void load(HeroesLoader loader) throws IOException {
        for(Hero hero:loader.load()){
            String key = hero.getName().toLowerCase();
            if (!heroes.containsKey(key)){
                heroes.put(key,hero);
            }
        }
    }

    public List<Hero> search(String name) {
        String lowerName = name.toLowerCase();
        return heroes.keySet().stream().filter(k -> k.contains(lowerName)).limit(10).map(heroes::get).collect(Collectors.toList());
    }

    public Optional<Hero> get(String name) {
        String realKey = name.toLowerCase();
        return heroes.containsKey(realKey) ? Optional.of(heroes.get(realKey)) : Optional.empty();
    }
}
