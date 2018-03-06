package com.heroCorp;

import java.util.Objects;

public class Intervention {
    private String action;
    private String location;
    private String hero;

    private Intervention(){}

    public Intervention(String type, String location, String hero) {
        this.action = type;
        this.location = location;
        this.hero = hero;
    }

    public String getAction() {
        return action;
    }

    public String getLocation() {
        return location;
    }

    public String getHero() {
        return hero;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Intervention that = (Intervention) o;
        return Objects.equals(getAction(), that.getAction()) &&
                Objects.equals(getLocation(), that.getLocation()) &&
                Objects.equals(getHero(), that.getHero());
    }

    @Override
    public int hashCode() {

        return Objects.hash(getAction(), getLocation(), getHero());
    }
}
