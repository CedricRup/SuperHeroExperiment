package com.heroCorp;

import java.io.IOException;
import java.util.List;

public interface HeroesLoader {
    List<Hero> load() throws IOException;
}
