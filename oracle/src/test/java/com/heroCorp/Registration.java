package com.heroCorp;

public class Registration{
    private String name;
    private String key;

    private Registration(){}

    public Registration(String name, String key) {
        this.name = name;
        this.key = key;
    }

    public String getName() {
        return name;
    }

    public String getKey() {
        return key;
    }
}
