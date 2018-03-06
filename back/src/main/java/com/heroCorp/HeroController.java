package com.heroCorp;

import java.util.List;

import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class HeroController {


    private HeroRepository respository;

    public HeroController(HeroRepository respository) {
        this.respository = respository;
    }

    @RequestMapping("/api/hero")
    public ResponseEntity<Hero>  get(@RequestParam(value = "name", defaultValue = "World") String name) {
        return respository.get(name).map(ResponseEntity::ok).orElseGet(() -> ResponseEntity.notFound().build());
    }

    @RequestMapping("/api/search")
    public ResponseEntity<List<Hero>>  search(@RequestParam(value = "name")String name) {
        return ResponseEntity.ok(respository.search(name));
    }
}
