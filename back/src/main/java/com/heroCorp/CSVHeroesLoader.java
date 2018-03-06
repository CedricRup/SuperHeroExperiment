package com.heroCorp;

import org.apache.commons.csv.CSVFormat;
import org.apache.commons.csv.CSVRecord;
import org.springframework.core.io.ClassPathResource;
import org.springframework.stereotype.Component;

import java.io.IOException;
import java.io.InputStreamReader;
import java.io.Reader;
import java.util.ArrayList;
import java.util.List;

@Component
public class CSVHeroesLoader implements HeroesLoader {

    @Override
    public List<Hero> load() throws IOException {
        ClassPathResource classPathResource = new ClassPathResource("collection.csv");
        Reader in = new InputStreamReader(classPathResource.getInputStream());
        CSVFormat rfc4180 = CSVFormat.RFC4180;

        Iterable<CSVRecord> records = rfc4180.withFirstRecordAsHeader().parse(in);

        List<Hero> heroes = new ArrayList<>();

        for (CSVRecord record : records) {
            String name = record.get("NAME");
            String eye = record.get("EYE");
            String alive = record.get("ALIVE");
            String appearances = record.get("APPEARANCES");
            String firstAppearance = record.get("FIRST APPEARANCE");
            String hair = record.get("HAIR");
            String sex = record.get("SEX");
            String align = record.get("ALIGN");
            String id = record.get("ID");
            String secret = record.get("SECRET");

            Hero hero = new Hero(name, eye, alive, appearances, firstAppearance, hair, sex, align, id, secret);
            heroes.add(hero);
        }
        return heroes;

    }
}
